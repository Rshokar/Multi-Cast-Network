using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4945_A2.Threads;
using GameThread = _4945_A2.Threads.GameThread;

namespace _4945_A2.Network
{
    public class MulticastNetwork : Network
    {

        public MulticastNetwork(GameThread gt) : base(gt)
        {

        }

        public MulticastNetwork(int port, string ipAddress, GameThread gt) : base(port, ipAddress, gt) { }

    }
}
