using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameThread = _4945_A2.Threads.GameThread;

namespace _4945_A2.Network
{
    public class WebSocketNetwork : Network
    {
        public WebSocketNetwork(GameThread gt) : base(gt) {
            
        }

        public WebSocketNetwork(int port, string ipAddress, GameThread gt) : base(port, ipAddress, gt) { }

    }
}
