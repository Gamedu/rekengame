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
        public string ExtractedData { get; private set; } = "";
        private string IncomingData { get; set; } = "";
        public bool ReceivingData { get; set; } = true;
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
                IncomingData = "";
                IncomingData += poort.ReadExisting();
                firstindex = IncomingData.IndexOf('>');
                lastindex = IncomingData.IndexOf('<');
                for (int x = firstindex + 1; x < lastindex; x++)
                {
                    ExtractedData += IncomingData[x];

                }
                messageHandled = true;
                
            }


        }
        public void ClearIncomingData()
        {
            ExtractedData = "";
            IncomingData = "";
        }
        public void SendMessage(string message, SerialPort port)
        {
            char startCharacter = '>';
            char endCharacter = '<';
            string sendMessage = "";
            sendMessage += startCharacter;
            sendMessage += message;
            sendMessage += endCharacter;
            port.Write(sendMessage);
                  
        
        }
    }
}
