using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace iExosTest1_1
{
    public class UdpSender
    {
        public string DestinationIP { get; }
        public string DestinationPort { get; }

        public UdpSender(string destIP, string destinationPort)
        {
            DestinationIP = destIP;
            DestinationPort = destinationPort;
        }

        public void SendMessage(string msg)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(msg);
            UdpClient udpClient = new UdpClient();

            //udpClient.Client.Bind(new IPEndPoint(IPAddress.Parse(DestinationIP), Convert.ToInt16(DestinationPort)));
            udpClient.Connect(new IPEndPoint(IPAddress.Parse(DestinationIP), Convert.ToInt32(DestinationPort)));
            udpClient.Send(bytes, bytes.Length);
        }
    }
}
