using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    class Messages
    {
        public string extractedData { get; private set; } = "";
        private string incomingData { get; set; } = "";
        public bool receivingData { get; set; } = true;
        public Messages(SerialPort poort)
        {
            poort.Open();
        }
        public void Receive(SerialPort poort)
        {
            bool messageHandled = false;
            int firstindex;
            int lastindex;
            if (messageHandled == false)
            {
                incomingData = "";
                incomingData += poort.ReadExisting();
                firstindex = incomingData.IndexOf('>');
                lastindex = incomingData.IndexOf('<');
                for (int x = firstindex + 1; x < lastindex; x++)
                {
                    extractedData += incomingData[x];

                }
                messageHandled = true;
                
            }


        }
        public void clearIncomingData()
        {
            extractedData = "";
            incomingData = "";
        }
    }
}
