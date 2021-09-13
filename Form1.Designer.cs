
namespace Supervisorio_Modbus
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tb_Modbus_Server_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Status_Conection = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.bt_Remove_Item = new System.Windows.Forms.Button();
            this.bt_Add_Email = new System.Windows.Forms.Button();
            this.tb_New_Email = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lb_Emails = new System.Windows.Forms.ListBox();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Password_Login = new System.Windows.Forms.TextBox();
            this.tb_Login_User = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_Emergency_Status = new System.Windows.Forms.Label();
            this.bt_Emergency = new System.Windows.Forms.Button();
            this.lb_Status_Plant = new System.Windows.Forms.Label();
            this.bt_TurnOffPlant = new System.Windows.Forms.Button();
            this.bt_TurnOnPlant = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_Coil4_Value = new System.Windows.Forms.TextBox();
            this.nud_Min_Limit4 = new System.Windows.Forms.NumericUpDown();
            this.nud_Max_Limit4 = new System.Windows.Forms.NumericUpDown();
            this.nud_Min_Limit3 = new System.Windows.Forms.NumericUpDown();
            this.nud_Max_Limit3 = new System.Windows.Forms.NumericUpDown();
            this.nud_Min_Limit2 = new System.Windows.Forms.NumericUpDown();
            this.nud_Max_Limit2 = new System.Windows.Forms.NumericUpDown();
            this.nud_Min_Limit1 = new System.Windows.Forms.NumericUpDown();
            this.nud_Max_Limit1 = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_Goal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_Production_Counter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Coil2_Value = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Coil3_Value = new System.Windows.Forms.TextBox();
            this.tb_Register4_Value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Register3_Value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Register2_Value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Register1_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_Register1 = new System.Windows.Forms.CheckBox();
            this.cb_Register4 = new System.Windows.Forms.CheckBox();
            this.cb_Register3 = new System.Windows.Forms.CheckBox();
            this.cb_Register2 = new System.Windows.Forms.CheckBox();
            this.ch_Production = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_Registrador = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tim_Modbus_Com = new System.Windows.Forms.Timer(this.components);
            this.lb_Current_Date = new System.Windows.Forms.Label();
            this.lb_Current_Time = new System.Windows.Forms.Label();
            this.rt_Register_Log = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tb_Level_User = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_Inicial_Port = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min_Limit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max_Limit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min_Limit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max_Limit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min_Limit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max_Limit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min_Limit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max_Limit1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Production)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Registrador)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Modbus_Server_IP
            // 
            this.tb_Modbus_Server_IP.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Modbus_Server_IP.Location = new System.Drawing.Point(113, 6);
            this.tb_Modbus_Server_IP.Name = "tb_Modbus_Server_IP";
            this.tb_Modbus_Server_IP.ReadOnly = true;
            this.tb_Modbus_Server_IP.Size = new System.Drawing.Size(114, 20);
            this.tb_Modbus_Server_IP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modbus Server IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta Inicial:";
            // 
            // bt_Connect
            // 
            this.bt_Connect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Connect.ImageKey = "(nenhum/a)";
            this.bt_Connect.Location = new System.Drawing.Point(233, 3);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(105, 27);
            this.bt_Connect.TabIndex = 4;
            this.bt_Connect.Text = "&Conectar";
            this.bt_Connect.UseVisualStyleBackColor = false;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.BackColor = System.Drawing.Color.Coral;
            this.bt_Disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Disconnect.Enabled = false;
            this.bt_Disconnect.Location = new System.Drawing.Point(233, 36);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(105, 27);
            this.bt_Disconnect.TabIndex = 5;
            this.bt_Disconnect.Text = "&Desconectar";
            this.bt_Disconnect.UseVisualStyleBackColor = false;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status da Conexão:";
            // 
            // lb_Status_Conection
            // 
            this.lb_Status_Conection.AutoSize = true;
            this.lb_Status_Conection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status_Conection.ForeColor = System.Drawing.Color.Red;
            this.lb_Status_Conection.Location = new System.Drawing.Point(378, 28);
            this.lb_Status_Conection.Name = "lb_Status_Conection";
            this.lb_Status_Conection.Size = new System.Drawing.Size(93, 31);
            this.lb_Status_Conection.TabIndex = 7;
            this.lb_Status_Conection.Text = "Offline";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(9, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1386, 443);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.bt_Remove_Item);
            this.tabPage3.Controls.Add(this.bt_Add_Email);
            this.tabPage3.Controls.Add(this.tb_New_Email);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.lb_Emails);
            this.tabPage3.Controls.Add(this.bt_Logout);
            this.tabPage3.Controls.Add(this.bt_Login);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.tb_Password_Login);
            this.tabPage3.Controls.Add(this.tb_Login_User);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1378, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Login";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(273, 145);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 20);
            this.label28.TabIndex = 13;
            this.label28.Text = "Novo Email:";
            // 
            // bt_Remove_Item
            // 
            this.bt_Remove_Item.BackColor = System.Drawing.Color.Coral;
            this.bt_Remove_Item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Remove_Item.Location = new System.Drawing.Point(396, 214);
            this.bt_Remove_Item.Name = "bt_Remove_Item";
            this.bt_Remove_Item.Size = new System.Drawing.Size(87, 37);
            this.bt_Remove_Item.TabIndex = 12;
            this.bt_Remove_Item.Text = "&Remover";
            this.bt_Remove_Item.UseVisualStyleBackColor = false;
            this.bt_Remove_Item.Click += new System.EventHandler(this.bt_Remove_Item_Click);
            // 
            // bt_Add_Email
            // 
            this.bt_Add_Email.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_Add_Email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Add_Email.Location = new System.Drawing.Point(396, 171);
            this.bt_Add_Email.Name = "bt_Add_Email";
            this.bt_Add_Email.Size = new System.Drawing.Size(87, 37);
            this.bt_Add_Email.TabIndex = 11;
            this.bt_Add_Email.Text = "&Adicionar";
            this.bt_Add_Email.UseVisualStyleBackColor = false;
            this.bt_Add_Email.Click += new System.EventHandler(this.bt_Add_Email_Click);
            // 
            // tb_New_Email
            // 
            this.tb_New_Email.Location = new System.Drawing.Point(371, 145);
            this.tb_New_Email.Name = "tb_New_Email";
            this.tb_New_Email.Size = new System.Drawing.Size(150, 20);
            this.tb_New_Email.TabIndex = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(283, 53);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 25);
            this.label27.TabIndex = 8;
            this.label27.Text = "Emails:";
            // 
            // lb_Emails
            // 
            this.lb_Emails.FormattingEnabled = true;
            this.lb_Emails.Items.AddRange(new object[] {
            "abud.igor@engenharia.ufjf.br",
            "abudfortes@gmail.com"});
            this.lb_Emails.Location = new System.Drawing.Point(371, 53);
            this.lb_Emails.Name = "lb_Emails";
            this.lb_Emails.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_Emails.Size = new System.Drawing.Size(150, 69);
            this.lb_Emails.TabIndex = 7;
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackColor = System.Drawing.Color.Coral;
            this.bt_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Logout.Location = new System.Drawing.Point(122, 186);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(111, 51);
            this.bt_Logout.TabIndex = 5;
            this.bt_Logout.Text = "&Logout";
            this.bt_Logout.UseVisualStyleBackColor = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Login.Location = new System.Drawing.Point(122, 129);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(111, 51);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "&Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Senha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Login:";
            // 
            // tb_Password_Login
            // 
            this.tb_Password_Login.Location = new System.Drawing.Point(122, 96);
            this.tb_Password_Login.Name = "tb_Password_Login";
            this.tb_Password_Login.PasswordChar = '*';
            this.tb_Password_Login.Size = new System.Drawing.Size(111, 20);
            this.tb_Password_Login.TabIndex = 1;
            // 
            // tb_Login_User
            // 
            this.tb_Login_User.AcceptsReturn = true;
            this.tb_Login_User.AcceptsTab = true;
            this.tb_Login_User.Location = new System.Drawing.Point(122, 53);
            this.tb_Login_User.Name = "tb_Login_User";
            this.tb_Login_User.Size = new System.Drawing.Size(111, 20);
            this.tb_Login_User.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.bt_Emergency);
            this.tabPage1.Controls.Add(this.bt_TurnOffPlant);
            this.tabPage1.Controls.Add(this.bt_TurnOnPlant);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.tb_Coil4_Value);
            this.tabPage1.Controls.Add(this.nud_Min_Limit4);
            this.tabPage1.Controls.Add(this.nud_Max_Limit4);
            this.tabPage1.Controls.Add(this.nud_Min_Limit3);
            this.tabPage1.Controls.Add(this.nud_Max_Limit3);
            this.tabPage1.Controls.Add(this.nud_Min_Limit2);
            this.tabPage1.Controls.Add(this.nud_Max_Limit2);
            this.tabPage1.Controls.Add(this.nud_Min_Limit1);
            this.tabPage1.Controls.Add(this.nud_Max_Limit1);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.tb_Goal);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.tb_Production_Counter);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tb_Coil2_Value);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tb_Coil3_Value);
            this.tabPage1.Controls.Add(this.tb_Register4_Value);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tb_Register3_Value);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_Register2_Value);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_Register1_Value);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1378, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visão Geral";
            // 
            // lb_Emergency_Status
            // 
            this.lb_Emergency_Status.AutoSize = true;
            this.lb_Emergency_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Emergency_Status.ForeColor = System.Drawing.Color.Gray;
            this.lb_Emergency_Status.Location = new System.Drawing.Point(544, 50);
            this.lb_Emergency_Status.Name = "lb_Emergency_Status";
            this.lb_Emergency_Status.Size = new System.Drawing.Size(302, 31);
            this.lb_Emergency_Status.TabIndex = 19;
            this.lb_Emergency_Status.Text = "Emergência Desativada";
            // 
            // bt_Emergency
            // 
            this.bt_Emergency.BackColor = System.Drawing.Color.Red;
            this.bt_Emergency.Location = new System.Drawing.Point(31, 176);
            this.bt_Emergency.Name = "bt_Emergency";
            this.bt_Emergency.Size = new System.Drawing.Size(114, 47);
            this.bt_Emergency.TabIndex = 46;
            this.bt_Emergency.Text = "EMERGÊNCIA";
            this.bt_Emergency.UseVisualStyleBackColor = false;
            this.bt_Emergency.Click += new System.EventHandler(this.bt_Emergency_Click);
            // 
            // lb_Status_Plant
            // 
            this.lb_Status_Plant.AutoSize = true;
            this.lb_Status_Plant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status_Plant.ForeColor = System.Drawing.Color.Red;
            this.lb_Status_Plant.Location = new System.Drawing.Point(580, 3);
            this.lb_Status_Plant.Name = "lb_Status_Plant";
            this.lb_Status_Plant.Size = new System.Drawing.Size(219, 31);
            this.lb_Status_Plant.TabIndex = 18;
            this.lb_Status_Plant.Text = "Planta Desligada";
            // 
            // bt_TurnOffPlant
            // 
            this.bt_TurnOffPlant.BackColor = System.Drawing.Color.Orange;
            this.bt_TurnOffPlant.Location = new System.Drawing.Point(31, 107);
            this.bt_TurnOffPlant.Name = "bt_TurnOffPlant";
            this.bt_TurnOffPlant.Size = new System.Drawing.Size(114, 47);
            this.bt_TurnOffPlant.TabIndex = 45;
            this.bt_TurnOffPlant.Text = "&Desligar Planta";
            this.bt_TurnOffPlant.UseVisualStyleBackColor = false;
            this.bt_TurnOffPlant.Click += new System.EventHandler(this.bt_TurnOffPlant_Click);
            // 
            // bt_TurnOnPlant
            // 
            this.bt_TurnOnPlant.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_TurnOnPlant.Location = new System.Drawing.Point(31, 42);
            this.bt_TurnOnPlant.Name = "bt_TurnOnPlant";
            this.bt_TurnOnPlant.Size = new System.Drawing.Size(114, 47);
            this.bt_TurnOnPlant.TabIndex = 44;
            this.bt_TurnOnPlant.Text = "&Ligar Planta";
            this.bt_TurnOnPlant.UseVisualStyleBackColor = false;
            this.bt_TurnOnPlant.Click += new System.EventHandler(this.bt_TurnOnPlant_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(813, 227);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 43;
            this.label25.Text = "Bobina 3:";
            // 
            // tb_Coil4_Value
            // 
            this.tb_Coil4_Value.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Coil4_Value.Enabled = false;
            this.tb_Coil4_Value.Location = new System.Drawing.Point(872, 220);
            this.tb_Coil4_Value.Name = "tb_Coil4_Value";
            this.tb_Coil4_Value.ReadOnly = true;
            this.tb_Coil4_Value.Size = new System.Drawing.Size(100, 20);
            this.tb_Coil4_Value.TabIndex = 42;
            // 
            // nud_Min_Limit4
            // 
            this.nud_Min_Limit4.Location = new System.Drawing.Point(1150, 107);
            this.nud_Min_Limit4.Name = "nud_Min_Limit4";
            this.nud_Min_Limit4.Size = new System.Drawing.Size(100, 20);
            this.nud_Min_Limit4.TabIndex = 41;
            // 
            // nud_Max_Limit4
            // 
            this.nud_Max_Limit4.Location = new System.Drawing.Point(1150, 73);
            this.nud_Max_Limit4.Name = "nud_Max_Limit4";
            this.nud_Max_Limit4.Size = new System.Drawing.Size(100, 20);
            this.nud_Max_Limit4.TabIndex = 40;
            // 
            // nud_Min_Limit3
            // 
            this.nud_Min_Limit3.Location = new System.Drawing.Point(872, 108);
            this.nud_Min_Limit3.Name = "nud_Min_Limit3";
            this.nud_Min_Limit3.Size = new System.Drawing.Size(100, 20);
            this.nud_Min_Limit3.TabIndex = 39;
            // 
            // nud_Max_Limit3
            // 
            this.nud_Max_Limit3.Location = new System.Drawing.Point(872, 74);
            this.nud_Max_Limit3.Name = "nud_Max_Limit3";
            this.nud_Max_Limit3.Size = new System.Drawing.Size(100, 20);
            this.nud_Max_Limit3.TabIndex = 38;
            // 
            // nud_Min_Limit2
            // 
            this.nud_Min_Limit2.Location = new System.Drawing.Point(565, 108);
            this.nud_Min_Limit2.Name = "nud_Min_Limit2";
            this.nud_Min_Limit2.Size = new System.Drawing.Size(100, 20);
            this.nud_Min_Limit2.TabIndex = 37;
            // 
            // nud_Max_Limit2
            // 
            this.nud_Max_Limit2.Location = new System.Drawing.Point(565, 74);
            this.nud_Max_Limit2.Name = "nud_Max_Limit2";
            this.nud_Max_Limit2.Size = new System.Drawing.Size(100, 20);
            this.nud_Max_Limit2.TabIndex = 36;
            // 
            // nud_Min_Limit1
            // 
            this.nud_Min_Limit1.Location = new System.Drawing.Point(297, 108);
            this.nud_Min_Limit1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_Min_Limit1.Name = "nud_Min_Limit1";
            this.nud_Min_Limit1.Size = new System.Drawing.Size(100, 20);
            this.nud_Min_Limit1.TabIndex = 35;
            // 
            // nud_Max_Limit1
            // 
            this.nud_Max_Limit1.Location = new System.Drawing.Point(297, 74);
            this.nud_Max_Limit1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_Max_Limit1.Name = "nud_Max_Limit1";
            this.nud_Max_Limit1.Size = new System.Drawing.Size(100, 20);
            this.nud_Max_Limit1.TabIndex = 34;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(256, 299);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 33;
            this.label26.Text = "Meta:";
            // 
            // tb_Goal
            // 
            this.tb_Goal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Goal.Location = new System.Drawing.Point(297, 296);
            this.tb_Goal.Name = "tb_Goal";
            this.tb_Goal.Size = new System.Drawing.Size(100, 20);
            this.tb_Goal.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1072, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "Limite Inferior:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1068, 79);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 13);
            this.label24.TabIndex = 26;
            this.label24.Text = "Limite Superior:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(794, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Limite Inferior:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(790, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Limite Superior:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(484, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Limite Inferior:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(480, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Limite Superior:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(229, 262);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Contador 1:";
            // 
            // tb_Production_Counter
            // 
            this.tb_Production_Counter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Production_Counter.Enabled = false;
            this.tb_Production_Counter.Location = new System.Drawing.Point(297, 259);
            this.tb_Production_Counter.Name = "tb_Production_Counter";
            this.tb_Production_Counter.ReadOnly = true;
            this.tb_Production_Counter.Size = new System.Drawing.Size(100, 20);
            this.tb_Production_Counter.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Limite Inferior:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Limite Superior:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bobina 2:";
            // 
            // tb_Coil2_Value
            // 
            this.tb_Coil2_Value.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Coil2_Value.Enabled = false;
            this.tb_Coil2_Value.Location = new System.Drawing.Point(565, 223);
            this.tb_Coil2_Value.Name = "tb_Coil2_Value";
            this.tb_Coil2_Value.ReadOnly = true;
            this.tb_Coil2_Value.Size = new System.Drawing.Size(100, 20);
            this.tb_Coil2_Value.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bobina 1:";
            // 
            // tb_Coil3_Value
            // 
            this.tb_Coil3_Value.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Coil3_Value.Enabled = false;
            this.tb_Coil3_Value.ForeColor = System.Drawing.Color.White;
            this.tb_Coil3_Value.Location = new System.Drawing.Point(297, 222);
            this.tb_Coil3_Value.Name = "tb_Coil3_Value";
            this.tb_Coil3_Value.ReadOnly = true;
            this.tb_Coil3_Value.Size = new System.Drawing.Size(100, 20);
            this.tb_Coil3_Value.TabIndex = 8;
            // 
            // tb_Register4_Value
            // 
            this.tb_Register4_Value.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Register4_Value.Location = new System.Drawing.Point(1150, 39);
            this.tb_Register4_Value.Name = "tb_Register4_Value";
            this.tb_Register4_Value.ReadOnly = true;
            this.tb_Register4_Value.Size = new System.Drawing.Size(100, 20);
            this.tb_Register4_Value.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1071, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Registrador 4:";
            // 
            // tb_Register3_Value
            // 
            this.tb_Register3_Value.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Register3_Value.Location = new System.Drawing.Point(872, 40);
            this.tb_Register3_Value.Name = "tb_Register3_Value";
            this.tb_Register3_Value.ReadOnly = true;
            this.tb_Register3_Value.Size = new System.Drawing.Size(100, 20);
            this.tb_Register3_Value.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Registrador 3:";
            // 
            // tb_Register2_Value
            // 
            this.tb_Register2_Value.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Register2_Value.Location = new System.Drawing.Point(562, 40);
            this.tb_Register2_Value.Name = "tb_Register2_Value";
            this.tb_Register2_Value.ReadOnly = true;
            this.tb_Register2_Value.Size = new System.Drawing.Size(100, 20);
            this.tb_Register2_Value.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Registrador 2:";
            // 
            // tb_Register1_Value
            // 
            this.tb_Register1_Value.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Register1_Value.Location = new System.Drawing.Point(297, 40);
            this.tb_Register1_Value.Name = "tb_Register1_Value";
            this.tb_Register1_Value.ReadOnly = true;
            this.tb_Register1_Value.Size = new System.Drawing.Size(100, 20);
            this.tb_Register1_Value.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registrador 1:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.cb_Register1);
            this.tabPage2.Controls.Add(this.cb_Register4);
            this.tabPage2.Controls.Add(this.cb_Register3);
            this.tabPage2.Controls.Add(this.cb_Register2);
            this.tabPage2.Controls.Add(this.ch_Production);
            this.tabPage2.Controls.Add(this.ch_Registrador);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1378, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visão Gráfica";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(603, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "Entradas Disponíveis:";
            // 
            // cb_Register1
            // 
            this.cb_Register1.AutoSize = true;
            this.cb_Register1.Location = new System.Drawing.Point(607, 102);
            this.cb_Register1.Name = "cb_Register1";
            this.cb_Register1.Size = new System.Drawing.Size(89, 17);
            this.cb_Register1.TabIndex = 7;
            this.cb_Register1.Text = "Registrador 1";
            this.cb_Register1.UseVisualStyleBackColor = true;
            // 
            // cb_Register4
            // 
            this.cb_Register4.AutoSize = true;
            this.cb_Register4.Location = new System.Drawing.Point(607, 171);
            this.cb_Register4.Name = "cb_Register4";
            this.cb_Register4.Size = new System.Drawing.Size(89, 17);
            this.cb_Register4.TabIndex = 5;
            this.cb_Register4.Text = "Registrador 4";
            this.cb_Register4.UseVisualStyleBackColor = true;
            // 
            // cb_Register3
            // 
            this.cb_Register3.AutoSize = true;
            this.cb_Register3.Location = new System.Drawing.Point(607, 148);
            this.cb_Register3.Name = "cb_Register3";
            this.cb_Register3.Size = new System.Drawing.Size(89, 17);
            this.cb_Register3.TabIndex = 4;
            this.cb_Register3.Text = "Registrador 3";
            this.cb_Register3.UseVisualStyleBackColor = true;
            // 
            // cb_Register2
            // 
            this.cb_Register2.AutoSize = true;
            this.cb_Register2.Location = new System.Drawing.Point(607, 125);
            this.cb_Register2.Name = "cb_Register2";
            this.cb_Register2.Size = new System.Drawing.Size(89, 17);
            this.cb_Register2.TabIndex = 3;
            this.cb_Register2.Text = "Registrador 2";
            this.cb_Register2.UseVisualStyleBackColor = true;
            // 
            // ch_Production
            // 
            this.ch_Production.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ch_Production.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.ch_Production.Legends.Add(legend1);
            this.ch_Production.Location = new System.Drawing.Point(762, -2);
            this.ch_Production.Name = "ch_Production";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Produção";
            this.ch_Production.Series.Add(series1);
            this.ch_Production.Size = new System.Drawing.Size(620, 419);
            this.ch_Production.TabIndex = 18;
            this.ch_Production.Text = "chart1";
            // 
            // ch_Registrador
            // 
            this.ch_Registrador.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ch_Registrador.ChartAreas.Add(chartArea2);
            this.ch_Registrador.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.ch_Registrador.Legends.Add(legend2);
            this.ch_Registrador.Location = new System.Drawing.Point(3, 3);
            this.ch_Registrador.Name = "ch_Registrador";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Registrador 1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Registrador 2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Registrador 3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Registrador 4";
            this.ch_Registrador.Series.Add(series2);
            this.ch_Registrador.Series.Add(series3);
            this.ch_Registrador.Series.Add(series4);
            this.ch_Registrador.Series.Add(series5);
            this.ch_Registrador.Size = new System.Drawing.Size(733, 411);
            this.ch_Registrador.TabIndex = 0;
            this.ch_Registrador.Text = "chart1";
            this.ch_Registrador.Click += new System.EventHandler(this.ch_Registrador_Click);
            // 
            // tim_Modbus_Com
            // 
            this.tim_Modbus_Com.Interval = 2000;
            this.tim_Modbus_Com.Tick += new System.EventHandler(this.tim_Modbus_Com_Tick);
            // 
            // lb_Current_Date
            // 
            this.lb_Current_Date.AutoSize = true;
            this.lb_Current_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Current_Date.Location = new System.Drawing.Point(864, 8);
            this.lb_Current_Date.Name = "lb_Current_Date";
            this.lb_Current_Date.Size = new System.Drawing.Size(160, 20);
            this.lb_Current_Date.TabIndex = 10;
            this.lb_Current_Date.Text = "Data (DD/MM/AAAA)";
            // 
            // lb_Current_Time
            // 
            this.lb_Current_Time.AutoSize = true;
            this.lb_Current_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Current_Time.Location = new System.Drawing.Point(864, 28);
            this.lb_Current_Time.Name = "lb_Current_Time";
            this.lb_Current_Time.Size = new System.Drawing.Size(44, 20);
            this.lb_Current_Time.TabIndex = 11;
            this.lb_Current_Time.Text = "Hora";
            // 
            // rt_Register_Log
            // 
            this.rt_Register_Log.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rt_Register_Log.Location = new System.Drawing.Point(9, 526);
            this.rt_Register_Log.Name = "rt_Register_Log";
            this.rt_Register_Log.ReadOnly = true;
            this.rt_Register_Log.Size = new System.Drawing.Size(1382, 113);
            this.rt_Register_Log.TabIndex = 8;
            this.rt_Register_Log.Text = "";
            // 
            // tb_Level_User
            // 
            this.tb_Level_User.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Level_User.Enabled = false;
            this.tb_Level_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Level_User.Location = new System.Drawing.Point(1233, 52);
            this.tb_Level_User.Name = "tb_Level_User";
            this.tb_Level_User.ReadOnly = true;
            this.tb_Level_User.Size = new System.Drawing.Size(162, 31);
            this.tb_Level_User.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1057, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 31);
            this.label14.TabIndex = 13;
            // 
            // tb_User
            // 
            this.tb_User.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_User.Enabled = false;
            this.tb_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User.Location = new System.Drawing.Point(1233, 6);
            this.tb_User.Name = "tb_User";
            this.tb_User.ReadOnly = true;
            this.tb_User.Size = new System.Drawing.Size(162, 31);
            this.tb_User.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1159, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Usuário:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1102, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Nível de Acesso:";
            // 
            // cb_Inicial_Port
            // 
            this.cb_Inicial_Port.Enabled = false;
            this.cb_Inicial_Port.FormattingEnabled = true;
            this.cb_Inicial_Port.Items.AddRange(new object[] {
            "502",
            "503"});
            this.cb_Inicial_Port.Location = new System.Drawing.Point(113, 32);
            this.cb_Inicial_Port.Name = "cb_Inicial_Port";
            this.cb_Inicial_Port.Size = new System.Drawing.Size(61, 21);
            this.cb_Inicial_Port.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1402, 651);
            this.Controls.Add(this.lb_Emergency_Status);
            this.Controls.Add(this.cb_Inicial_Port);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lb_Status_Plant);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_Level_User);
            this.Controls.Add(this.rt_Register_Log);
            this.Controls.Add(this.lb_Current_Time);
            this.Controls.Add(this.lb_Current_Date);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_Status_Conection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Disconnect);
            this.Controls.Add(this.bt_Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Modbus_Server_IP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Supervisório";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min_Limit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max_Limit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min_Limit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max_Limit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min_Limit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max_Limit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min_Limit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max_Limit1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Production)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Registrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Modbus_Server_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Status_Conection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer tim_Modbus_Com;
        private System.Windows.Forms.Label lb_Current_Date;
        private System.Windows.Forms.Label lb_Current_Time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Coil2_Value;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Coil3_Value;
        private System.Windows.Forms.TextBox tb_Register4_Value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Register3_Value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Register2_Value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Register1_Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rt_Register_Log;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Registrador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cb_Register4;
        private System.Windows.Forms.CheckBox cb_Register3;
        private System.Windows.Forms.CheckBox cb_Register2;
        private System.Windows.Forms.CheckBox cb_Register1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Password_Login;
        private System.Windows.Forms.TextBox tb_Login_User;
        private System.Windows.Forms.TextBox tb_Level_User;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_Production_Counter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Production;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_Inicial_Port;
        private System.Windows.Forms.TextBox tb_Goal;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown nud_Max_Limit1;
        private System.Windows.Forms.NumericUpDown nud_Min_Limit4;
        private System.Windows.Forms.NumericUpDown nud_Max_Limit4;
        private System.Windows.Forms.NumericUpDown nud_Min_Limit3;
        private System.Windows.Forms.NumericUpDown nud_Max_Limit3;
        private System.Windows.Forms.NumericUpDown nud_Min_Limit2;
        private System.Windows.Forms.NumericUpDown nud_Max_Limit2;
        private System.Windows.Forms.NumericUpDown nud_Min_Limit1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_Coil4_Value;
        private System.Windows.Forms.Button bt_Emergency;
        private System.Windows.Forms.Button bt_TurnOffPlant;
        private System.Windows.Forms.Button bt_TurnOnPlant;
        private System.Windows.Forms.ListBox lb_Emails;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_New_Email;
        private System.Windows.Forms.Button bt_Add_Email;
        private System.Windows.Forms.Button bt_Remove_Item;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lb_Status_Plant;
        private System.Windows.Forms.Label lb_Emergency_Status;
    }
}

