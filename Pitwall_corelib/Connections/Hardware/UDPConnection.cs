using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Pitwall_corelib.Connections.Hardware
{
    public class UDPConnection : IConnection
    {
        private Socket Socket { get; set; }

        public UDPConnection()
        {
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }
        
        public void Connect()
        {
            throw new System.NotImplementedException();
        }

        public void Disconnect()
        {
            throw new System.NotImplementedException();
        }

        public bool IsAlive()
        {
            throw new System.NotImplementedException();
        }

        public void Send()
        {
            throw new System.NotImplementedException();
        }
    }
}