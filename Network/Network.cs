using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameThread = _4945_A2.Threads.GameThread;



namespace _4945_A2.Network
{
    public abstract class Network
    {
        private const int PORT = 8000; 
        private const string IP_ADDRESS = "";

        private int port;
        private string ipAddress; 
        private GameThread gt;

        public Network(GameThread gt) {
            this.port = PORT; 
            this.ipAddress = IP_ADDRESS;
            this.gt = gt;
        }

        public Network(int port, string ipAddress, GameThread gt)
        {
            this.port = port;
            this.ipAddress = ipAddress;
            this.gt = gt;
        }
    }
}
