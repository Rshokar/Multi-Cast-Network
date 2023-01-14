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

        public MulticastNetwork(GameThread gt) : base(gt)
        {
        }

        public MulticastNetwork(int port, string ipAddress, GameThread gt) : base(port, ipAddress, gt) { }


        public MulticastNetwork(int port, string ipAddress, GameThread gt, int bufferSize) : base(port, ipAddress, gt, bufferSize) { }


        public override void send(P packet) {
            Console.WriteLine("Inside multicast");
            Console.WriteLine(packet.ToString());
            IPEndPoint endPoint;

            try
            {
                //Send multicast packets to the listener.
                endPoint = new IPEndPoint(this.mcastAddress, GetPort());
                this.mcastSocket.SendTo(packet.GetBuffer(), endPoint);
                Console.WriteLine("Multicast data sent.....");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.ToString());
            }

            //mcastSocket.Close();
        }
        public override void execute()
        {

            base.setup();

            IPAddress localIP = IPAddress.Any;
            EndPoint localEP = (EndPoint)new IPEndPoint(localIP, this.GetPort());
            mcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);

            mcastSocket.Bind(localEP);

            MulticastOption mcastOption = new MulticastOption(mcastAddress, localIP);

            mcastSocket.SetSocketOption(SocketOptionLevel.IP,
                                        SocketOptionName.AddMembership,
                                        mcastOption);
            base.execute();
        }

        protected override void receive()
        {
            IPEndPoint groupEP = new IPEndPoint(mcastAddress, this.GetPort());
            EndPoint remoteEP = (EndPoint)new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                mcastSocket.ReceiveFrom(buffer, ref remoteEP);

                P packet = new P(buffer[0], buffer[1], buffer[2], buffer[3], buffer[4], buffer[5]);

                Console.WriteLine("RECEIVED PACKET: " + packet.ToString());

                // gameEngine.notify()
            }
           
        }

    }

}
