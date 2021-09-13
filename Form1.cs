using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.IO.Ports;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;


// Sequencia para documentar: 4, 3, 5 e 1

namespace Supervisorio_Modbus
{

    public partial class Form1 : Form
    {
        ModbusClient modbusClient;
        int counterProduction = 0;
        string strCon = @"server=127.0.0.1;user id=root;database=supervisorio;SslMode=none";
        bool controlAlert = false;
        bool turnOnPlant = false;
                
        public Form1()
        {
            InitializeComponent();
            tb_Modbus_Server_IP.Text = getIP();
            cb_Inicial_Port.Text = "503";
            tb_Modbus_Server_IP.Enabled = false;
            lb_Status_Conection.ForeColor = Color.Red;
            tb_Production_Counter.Text = counterProduction.ToString();
            cb_Register1.Checked = true;
            
            
            
            hideItens();

        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
                        
            try
            {
                
                modbusClient = new ModbusClient(tb_Modbus_Server_IP.Text, Int32.Parse(cb_Inicial_Port.Text));
                modbusClient.Connect();
                lb_Status_Conection.Text = "Online";
                tim_Modbus_Com.Enabled = true;
                BeginInvoke(new Delegate_void_String(Append_Text),
                  new object[] { rt_Register_Log, string.Format("{0} - Conexão iniciada", DateTime.Now) });
                bt_Disconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                BeginInvoke(new Delegate_void_String(Append_Text),
                    new object[] { rt_Register_Log, string.Format("[Erro]: {0}", "Nenhum dispositivo foi encontrado na rede.") });

            }
        }

        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
           

                modbusClient.Disconnect();
                setOfftoStatusConection();
                tim_Modbus_Com.Enabled = false;
                BeginInvoke(new Delegate_void_String(Append_Text),
                      new object[] { rt_Register_Log, string.Format("{0} - Conexão finalizada", DateTime.Now)});
            
           
        }

        private string getIP() //Função para pegar o IP da máquina que esta rodando a aplicação
        {
            string host = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(host);
            
            return ip[1].ToString();
        }
        
        private void tim_Modbus_Com_Tick(object sender, EventArgs e)
        {
            tim_Modbus_Com.Enabled = false;

            var timeStamp = DateTime.Now;
            lb_Current_Date.Text = DateTime.Now.ToShortDateString();
            lb_Current_Time.Text = DateTime.Now.ToString("hh:mm:ss");
            try
            {
                tb_Register1_Value.Text = modbusClient.ReadHoldingRegisters(19, 1)[0].ToString();
                tb_Register1_Value.Enabled = false;
                tb_Register2_Value.Text = modbusClient.ReadHoldingRegisters(18, 1)[0].ToString();
                tb_Register2_Value.Enabled = false;
                tb_Register3_Value.Text = modbusClient.ReadHoldingRegisters(17, 1)[0].ToString();
                tb_Register3_Value.Enabled = false;
                tb_Register4_Value.Text = modbusClient.ReadHoldingRegisters(16, 1)[0].ToString();
                tb_Register4_Value.Enabled = false;
                tb_Coil4_Value.Text = modbusClient.ReadCoils(3, 3)[1].ToString();
                tb_Coil3_Value.Text = modbusClient.ReadCoils(2, 2)[1].ToString();
                tb_Coil2_Value.Text = modbusClient.ReadCoils(1, 1)[0].ToString();
                if(turnOnPlant == true)
                {
                    modbusClient.WriteSingleCoil(5, true);
                }
                else
                {
                    modbusClient.WriteSingleCoil(5, false);
                }

                if (tb_Coil3_Value.Text == "True")
                {
                    counterProduction += 1;
                    tb_Production_Counter.Text = counterProduction.ToString();
                                                          
                }

                try
                {
                    sendDataToDataBase();
                }
                catch (Exception ex)
                {
                    BeginInvoke(new Delegate_void_String(Append_Text),
                      new object[] { rt_Register_Log, string.Format("{0} - Não foi possível conectar ao banco de dados", DateTime.Now) });
                }

                tim_Modbus_Com.Enabled = true;

                monitoringCoil(tb_Coil4_Value);
                monitoringCoil(tb_Coil3_Value);
                monitoringCoil(tb_Coil2_Value);
                monitoringUpperBound(nud_Max_Limit1,tb_Register1_Value);
                monitoringInferiorBound(nud_Min_Limit1, tb_Register1_Value);
                monitoringUpperBound(nud_Max_Limit2, tb_Register2_Value);
                monitoringInferiorBound(nud_Min_Limit2, tb_Register2_Value);
                monitoringUpperBound(nud_Max_Limit3, tb_Register3_Value);
                monitoringInferiorBound(nud_Min_Limit3, tb_Register3_Value);
                monitoringUpperBound(nud_Max_Limit4, tb_Register3_Value);
                monitoringInferiorBound(nud_Min_Limit4, tb_Register3_Value);
                monitoringGoal(tb_Goal, tb_Production_Counter);



            } 
            catch (Exception ex)
            {
                BeginInvoke(new Delegate_void_String(Append_Text),
                    new object[] { rt_Register_Log, string.Format("{0} - [Alerta]: {1}, {2}", timeStamp, "Conexão interrompida.", ex.ToString())});
                
                setOfftoStatusConection();

            }

            plotRegistersChart();
            plotProductionChart();
            blinkLabel(lb_Status_Conection, "Online", Color.Green, Color.Red);
            blinkLabel(lb_Status_Plant,"Planta Ligada", Color.Green, Color.Red);
            blinkLabel(lb_Emergency_Status, "Emergência Ativada",Color.Red, Color.Gray);

            tim_Modbus_Com.Enabled = true;
        }

        public delegate void Delegate_void_String(RichTextBox textbox, string text);

        public void Append_Text(RichTextBox textbox, string text)
        {
            textbox.AppendText(text + "\r\n");
            textbox.ScrollToCaret();
        }

       
        public void plotRegistersChart() //Função para plotar o gráfico de acordo com os checkboxes
        {

            if (ch_Registrador.Series[0].Points.Count > 50)
            {
                ch_Registrador.Series[0].Points.RemoveAt(0);
                ch_Registrador.Update();
            }

            ch_Registrador.Series[0].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), tb_Register1_Value.Text);
            ch_Registrador.Series[0].Color = Color.Red;
            ch_Registrador.Series[1].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), tb_Register2_Value.Text);
            ch_Registrador.Series[1].Color = Color.Blue;
            ch_Registrador.Series[2].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), tb_Register3_Value.Text);
            ch_Registrador.Series[2].Color = Color.Yellow;
            ch_Registrador.Series[3].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), tb_Register4_Value.Text);
            ch_Registrador.Series[3].Color = Color.Black;

            if (cb_Register1.Checked == false)
            {
                ch_Registrador.Series[0].Enabled = false;
            }
            else
            {
                ch_Registrador.Series[0].Enabled = true;
            }
            
            if (cb_Register2.Checked == false)
            {
                ch_Registrador.Series[1].Enabled = false;
            }
            else
            {
                ch_Registrador.Series[1].Enabled = true;
            }
            
            if (cb_Register3.Checked == false)
            {
                ch_Registrador.Series[2].Enabled = false;
            }
            else
            {
                ch_Registrador.Series[2].Enabled = true;
            }
            if (cb_Register4.Checked == false)
            {
                ch_Registrador.Series[3].Enabled = false;
            }
            else
            {
                ch_Registrador.Series[3].Enabled = true;
            }

        }

        private void plotProductionChart() //Função para pltar o gráfico de produção
        {
            if (ch_Production.Series[0].Points.Count > 600)
            {
                ch_Production.Series[0].Points.RemoveAt(0);
                ch_Production.Update();
            }
            ch_Production.Series[0].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), tb_Production_Counter.Text);
        }

        public void sendAlert(string time, string warning, string source, int value, decimal limit) //Função genérica para enviar alarmes na tela de log
        {
            BeginInvoke(new Delegate_void_String(Append_Text),
              new object[] { rt_Register_Log, string.Format("{0} - [Alarme] - {1}: - {2}, [Leitura: {3} Limite: {4}]", time, source, warning,value,limit) });
        }

        private void sendEmail()
        {
            //Cria um cliente SMTP fake para receber emails
            var client = new SmtpClient("smtp.mailtrap.io", 2525) //porta 2525 utilizada pelo servidor SMTP do mailtrap
            {
                Credentials = new NetworkCredential("db918b21e49e11", "ad2afb52e48e69"), //Credencias fornecidas pelo proprio site mailtrap
                EnableSsl = true
            };

            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress("no-reply@supervision.com");
            foreach(var item in lb_Emails.Items)
            {
                message.To.Add(new MailAddress(item.ToString()));
            }
            
            //message.To.Add(new MailAddress("abud.igor@hotmail.com"));
            message.Subject = "Meta de produção atingida";
            message.Body = "<p>A meta de produção foi atingida.</p> " +
                            "<p>Mais detalhes no arquivo em anexo.</p>";
            message.Attachments.Add(new Attachment("LogProducao.txt"));
            client.Send(message);

        }
        private void blinkLabel(Label label, string statusText, Color colorUp, Color colorDown) //função para piscar o label do status da conexão
        {
            if (label.Text == statusText)
            {
                if (label.Visible == true)
                {
                    label.Visible = false;
                }
                else
                {
                    label.Visible = true;
                }
                label.ForeColor = colorUp;
            } else
            {
                label.ForeColor = colorDown;
            }
        }

        private void setOfftoStatusConection ()
        {
            lb_Status_Conection.Visible = true;
            lb_Status_Conection.Text = "Offline";
            lb_Status_Conection.ForeColor = Color.Red;
        }

        private void ch_Registrador_Click(object sender, EventArgs e)
        {

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            bool succesLogin = false;
           
            if (tb_Login_User.Text == "admin" && tb_Password_Login.Text == "mudar123")
            {
                MessageBox.Show("Login Realizado com sucesso");
                showItens();
                tb_Level_User.Text = "Administrador";
                tb_User.Text = "admin";
                BeginInvoke(new Delegate_void_String(Append_Text),
                  new object[] { rt_Register_Log, string.Format("{0}: Login realizado como: {1}.", DateTime.Now, tb_User.Text) });
                tb_Login_User.Clear();
                tb_Password_Login.Clear();
                succesLogin = true;

            } else if(tb_Login_User.Text == "operador1" && tb_Password_Login.Text == "mudar123")
            {
                MessageBox.Show("Login Realizado com sucesso");
                showItens();
                tb_Level_User.Text = "Operador 1";
                tb_User.Text = "Operador";
                BeginInvoke(new Delegate_void_String(Append_Text),
                  new object[] { rt_Register_Log, string.Format("{0}: Login realizado como: {1}.", DateTime.Now, tb_User.Text) });
                tb_Login_User.Clear();
                tb_Password_Login.Clear();
                succesLogin = true;
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado, favor entrar em contato com o Administrador.");
            }

            if(succesLogin == true)
            {
                enableItensByLevelUser();
                tb_Login_User.Enabled = false;
                tb_Password_Login.Enabled = false;
                bt_Login.Enabled = false;
            }
                
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            if (tb_User.Text == string.Empty)
            {
                MessageBox.Show("Nenhum usuário logado no sistema.");
            }
            hideItens();
            BeginInvoke(new Delegate_void_String(Append_Text),
                  new object[] { rt_Register_Log, string.Format("{0}: Logout realizado como: {1}.", DateTime.Now, tb_User.Text) });
            tb_User.Clear();
            tb_Level_User.Clear();
            tb_Login_User.Enabled = true;
            tb_Password_Login.Enabled = true;
            bt_Login.Enabled = true;
        }

        private void hideItens()
        {
            tabPage1.Enabled = false;
            tabPage2.Enabled = false;
            rt_Register_Log.Enabled = false;
            bt_Connect.Enabled = false;
            bt_Disconnect.Enabled = false;
        }

        private void showItens()
        {
            tabPage1.Enabled = true;
            tabPage2.Enabled = true;
            rt_Register_Log.Enabled = true;
            bt_Connect.Enabled = true;
            //bt_Disconnect.Enabled = true;

        }

        private void enableItensByLevelUser()                          //função genérica para habilidar ou desabilitar funcionalidades de acordo com o nível de acesso do usuário
        {
            if (tb_Level_User.Text == "Administrador")
            {
                nud_Max_Limit1.Enabled = true;
                nud_Min_Limit1.Enabled = true;
                nud_Max_Limit2.Enabled = true;
                nud_Min_Limit2.Enabled = true;
                nud_Max_Limit3.Enabled = true;
                nud_Min_Limit3.Enabled = true;
                nud_Max_Limit4.Enabled = true;
                nud_Min_Limit4.Enabled = true;
                tb_Goal.Enabled = true;
                cb_Inicial_Port.Enabled = true;
            } else
            {
                nud_Max_Limit1.Enabled = false;
                nud_Min_Limit1.Enabled = false;
                nud_Max_Limit2.Enabled = false;
                nud_Min_Limit2.Enabled = false;
                nud_Max_Limit3.Enabled = false;
                nud_Min_Limit3.Enabled = false;
                nud_Max_Limit4.Enabled = false;
                nud_Min_Limit4.Enabled = false;
                tb_Goal.Enabled = false;
                cb_Inicial_Port.Enabled = false;
            }
        }

        private void sendDataToDataBase()
        {

            MySqlConnection con = new MySqlConnection(strCon); //colocar como um objeto global
            con.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = con;
            comm.CommandType = CommandType.Text; //tipo de comando que eu vou utilizar
            comm.CommandText = "insert into dadosproducao values (default, " + tb_Register1_Value.Text + "," + tb_Production_Counter.Text + ")";
            comm.ExecuteNonQuery();
            comm.Connection.Close();
        }

        private void monitoringUpperBound(NumericUpDown controlTextBox,TextBox registerTextBox)
        {
            controlTextBox.ForeColor = Color.Red;
            if ((controlTextBox.Text != string.Empty) && Int32.Parse(registerTextBox.Text) > controlTextBox.Value && controlTextBox.Value != 0)
            {
                sendAlert(DateTime.Now.ToString("hh:mm:ss"), "Limite Superior atingido", registerTextBox.Name, modbusClient.ReadHoldingRegisters(19, 1)[0], controlTextBox.Value);
                controlTextBox.BackColor = Color.Red;
                controlTextBox.ForeColor = Color.White;
            }
            else if (controlTextBox.Value == 0)
            {
                controlTextBox.BackColor = Color.Gray;
            }
            else if (controlTextBox.Text != string.Empty)
            {
                controlTextBox.BackColor = Color.Green;
            }
            
        }

        private void monitoringInferiorBound(NumericUpDown controlTextBox, TextBox registerTextBox)
        {
            controlTextBox.ForeColor = Color.Red;
            if ((controlTextBox.Text != string.Empty) && Int32.Parse(registerTextBox.Text) < controlTextBox.Value  && controlTextBox.Value != 0)
            {
                sendAlert(DateTime.Now.ToString("hh:mm:ss"), "Limite Inferior atingido", registerTextBox.Name, modbusClient.ReadHoldingRegisters(19, 1)[0], controlTextBox.Value);
                controlTextBox.BackColor = Color.Red;
                controlTextBox.ForeColor = Color.White;
            }
            else if (controlTextBox.Value == 0)
            {
                controlTextBox.BackColor = Color.Gray;
            }
            else if (controlTextBox.Text != string.Empty)
            {
                controlTextBox.BackColor = Color.Green;
            }

        }
        private void monitoringCoil(TextBox textBox)
        {
            if(textBox.Text == "True")
            {
                textBox.BackColor = Color.Green;
                textBox.ForeColor = Color.Gray;
            } else if (textBox.Text == "False")
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.Gray;
            } else
            {
                textBox.BackColor = Color.Gray;
            }
        }

        private void monitoringGoal(TextBox textboxGoal, TextBox textboxCounter)
        {
            if (textboxGoal.Text != string.Empty && Int32.Parse(textboxCounter.Text) >= Int32.Parse(textboxGoal.Text))
            {
                if(controlAlert == false)
                {
                    BeginInvoke(new Delegate_void_String(Append_Text),
                      new object[] { rt_Register_Log, string.Format("{0}: Meta de produção - {1} unidades - atingida.", DateTime.Now, textboxGoal.Text) });
                    saveLog();
                    sendEmail();
                }
                controlAlert = true;
            }
        }

        private void saveLog()
        {
            string path = @"C:\Users\abudi\Desktop\Igor\TCC\Supervisório\Supervisorio_Modbus\bin\Debug";
            try
            {
                rt_Register_Log.SaveFile(path + @"\LogProducao.txt", RichTextBoxStreamType.PlainText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void bt_TurnOnPlant_Click(object sender, EventArgs e)
        {
            if(lb_Status_Conection.Text == "Offline")
            {
                MessageBox.Show("Sistema Offline.");
            } 
            else
            {

                turnOnPlant = true;
                BeginInvoke(new Delegate_void_String(Append_Text),
                          new object[] { rt_Register_Log, string.Format("{0}: Planta Ligada por {1}", DateTime.Now,tb_User.Text)});
                lb_Status_Plant.Text = "Planta Ligada";
            }
        }

        private void bt_TurnOffPlant_Click(object sender, EventArgs e)
        {
            if (lb_Status_Conection.Text == "Offline")
            {
                MessageBox.Show("Sistema Offline.");
            }
            else
            {
                turnOnPlant = false;
                BeginInvoke(new Delegate_void_String(Append_Text),
                          new object[] { rt_Register_Log, string.Format("{0}: Planta Desligada por {1}", DateTime.Now, tb_User.Text) });
                lb_Status_Plant.Text = "Planta Desligada";
            }
        }

        private void bt_Emergency_Click(object sender, EventArgs e)
        {
            if (lb_Status_Conection.Text == "Offline")
            {
                MessageBox.Show("Sistema Offline.");
            }
            else
            {
                turnOnPlant = false;
               
                if(lb_Emergency_Status.Text == "Emergência Desativada")
                {
                    lb_Emergency_Status.Text = "Emergência Ativada";
                    BeginInvoke(new Delegate_void_String(Append_Text),
                         new object[] { rt_Register_Log, string.Format("{0}: EMERGÊNCIA ATIVADA POR {1}", DateTime.Now, tb_User.Text) });
                }
                else
                {
                    lb_Emergency_Status.Text = "Emergência Desativada";
                    BeginInvoke(new Delegate_void_String(Append_Text),
                         new object[] { rt_Register_Log, string.Format("{0}: EMERGÊNCIA DESATIVADA POR {1}", DateTime.Now, tb_User.Text) });
                }
            }
        }

        private void bt_Add_Email_Click(object sender, EventArgs e)
        {
            if(tb_New_Email.Text != string.Empty)
            {
                
                lb_Emails.Items.Add(tb_New_Email.Text);
                tb_New_Email.Clear();
            }
        }

        private void bt_Remove_Item_Click(object sender, EventArgs e)
        {
            lb_Emails.Items.Remove(lb_Emails.SelectedItem);
        }
    }
}
