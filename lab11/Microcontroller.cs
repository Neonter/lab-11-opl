using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    struct Microcontroller
    {
        private string m_sName;
        private int m_iFlashMemory;
        private int m_iRamMemory;
        private string m_iAdcChannel;
        private int m_iLcd;
        private int m_iSci;
        private int m_Spi;
        private int m_il2c;
        public Microcontroller(string name, int flash, int ram, string channel, int lcd=1, int sci=1, int spi=1, int iic=1)
        {
            m_sName = name;
            m_iFlashMemory = flash;
            m_iRamMemory = ram;
            m_iAdcChannel = channel;
            m_iLcd = lcd;
            m_iSci = sci;
            m_Spi = spi;
            m_il2c = iic;
        }
        public void Show()
        {
            Console.WriteLine("Name: {0}, Flash: {1}kB, Ram: {2}kB, Channel: {3}, Lcd: {4}, Sci: {5}, Spi: {6}, IIC: {7}", m_sName, m_iFlashMemory, m_iRamMemory, m_iAdcChannel, m_iLcd, m_iSci, m_Spi, m_il2c);
        }
        public string getName() => m_sName;
        public int getFlashMemory() => m_iFlashMemory;
        public int getRamMemort() => m_iRamMemory;
        public string getAdcChannel() => m_iAdcChannel;
        public int getLCD() => m_iLcd;
        public int getSci() => m_iSci;
        public int getSpi() => m_Spi;
        public int getI2c() => m_il2c;
    }
}
