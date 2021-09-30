from pyModbusTCP.server import DataBank, ModbusServer
import random
from time import sleep

class ServidorMODBUS ():
  def __init__(self, host_ip,port):
    self.server = ModbusServer(host=host_ip,port = port,no_block=True)
    self._db = DataBank

  def run(self):
    try:
      self.server.start()
      print("Servidor MODBUS em execução")
      while True:
        if self._db.get_bits(5)[0]:
          self._db.set_words(19,[random.randrange(1, 201)])
          self._db.set_words(18,[random.randrange(1, 101)])
          self._db.set_words(17,[random.randrange(1, 101)])
          self._db.set_words(16,[random.randrange(1, 101)])
          coiValue1 = random.randrange(1, 3)
          coiValue2 = random.randrange(1, 5)
          
          if(coiValue1 == 1):
            self._db.set_bits(3,[False])
            self._db.set_bits(1,[True])
          else :
            self._db.set_bits(3,[True])
            self._db.set_bits(1,[False])
          if(coiValue2 ==1):
            self._db.set_bits(4,[False])
          else:
            self._db.set_bits(4,[True])
          
          print("=========")
          print("Tabela MODBUS")
          print(f'Holding Register \r\n R1000:{self._db.get_words(19)}')
          print(f'Holding Register \r\n R2000:{self._db.get_words(18)}')
          print(f'Holding Register \r\n R3000:{self._db.get_words(17)}')
          print(f'Holding Register \r\n R4000:{self._db.get_words(16)}')
          print(f'Coil \r\n C3000:{self._db.get_bits(3)}')
          print(f'Coil \r\n C1000:{self._db.get_bits(1)}')
          print(f'Coil \r\n C4000:{self._db.get_bits(4)}')
          print(f'Coil \r\n C5000:{self._db.get_bits(5)}')
        sleep(2)
    except Exception as e:
      print("Erro:",e.args)
      