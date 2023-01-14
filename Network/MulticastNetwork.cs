using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using _4945_A2.Threads;
using GameThread = _4945_A2.Threads.GameThread;
using P = _4945_A2.Packet.Packet;

namespace _4945_A2.Network
{
    public class MulticastNetwork : Network
    {
        private IPAddress mcastAddress;
        private Socket mcastSocket;
        private MulticastOption mcastOption;

        public MulticastNetwork(GameThread gt) : base(gt)
        {
            SetupReceiver();
        }

        public MulticastNetwork(int port, string ipAddress, GameThread gt) : base(port, ipAddress, gt) { }


        public MulticastNetwork(int port, string ipAddress, GameThread gt, int bufferSize) : base(port, ipAddress, gt, bufferSize) { }

        private void SetupReceiver()
        {
            mcastAddress = IPAddress.Parse(this.GetIPAddress());

            mcastSocket = new Socket(AddressFamily.InterNetwork,
                                     SocketType.Dgram,
                                     ProtocolType.Udp);

            IPAddress localIP = IPAddress.Any;
            EndPoint localEP = (EndPoint)new IPEndPoint(localIP, this.GetPort());
            mcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);

            mcastSocket.Bind(localEP);

            mcastOption = new MulticastOption(mcastAddress, localIP);

            mcastSocket.SetSocketOption(SocketOptionLevel.IP,
                                        SocketOptionName.AddMembership,
                                        mcastOption);
        }

        protected override void receive()
        {
            IPEndPoint groupEP = new IPEndPoint(mcastAddress, this.GetPort());
            EndPoint remoteEP = (EndPoint)new IPEndPoint(IPAddress.Any, 0);

            mcastSocket.ReceiveFrom(buffer, ref remoteEP);

            P packet = new P(buffer[0], buffer[1], buffer[2], buffer[3], buffer[4], buffer[5]);

            Console.WriteLine("Received broadcast from {0} :\n {1}\n",
              remoteEP.ToString(),
              Encoding.ASCII.GetString(buffer, 0, buffer.Length));

            Console.WriteLine("PACKET: " + packet.ToString());
        }

        public override void send(P packet)
        {

        }


    }



}
