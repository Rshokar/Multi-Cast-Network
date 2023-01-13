using _4945_A2.Network;
using _4945_A2.Threads;


using Network = _4945_A2.Network.Network;
using MultiCast = _4945_A2.Network.MulticastNetwork;
using WebScoket = _4945_A2.Network.WebSocketNetwork;

using Game = _4945_A2.Threads.GameThread;
using User = _4945_A2.Threads.UserThread;

using P = _4945_A2.Packet.Packet;

namespace Program { 
    public class Program
    {

        public static void testOneM()
        {
            P[] packets = {
                new P(), new P(), new P(), new P(),
                new P(), new P(), new P(), new P(), 
            }; 


            Game g = new Game();
            Network n = new MultiCast(g);
            User u = new User(n);

            n.execute();

            for (int i = 0; i < packets.Length; i++) {
                n.send(packets[i]);
            }
            Console.WriteLine("\n\nEND \n\n");

            Console.WriteLine("Press any key to continue to next test.");
            Console.ReadLine();
        }
        public static void testTwoM()
        {
            P[] packets = {
                new P(), new P(), new P(), new P(),
                new P(), new P(), new P(), new P(),
            };


            Game g = new Game();
            Network n = new MultiCast(g);
            User u = new User(n);

            n.execute();

            for (int i = 0; i < packets.Length; i++)
            {
                n.send(packets[i]);
            }
            Console.WriteLine("\n\nEND \n\n");

            Console.WriteLine("Press any key to continue to next test.");
            Console.ReadLine();
        }

        public static void testThreeM()
        {
            P[] packets = {
                new P(), new P(), new P(), new P(),
                new P(), new P(), new P(), new P(),
            };


            Game g = new Game();
            Network n = new MultiCast(g);
            User u = new User(n);

            n.execute();

            for (int i = 0; i < packets.Length; i++)
            {
                n.send(packets[i]);
            }
            Console.WriteLine("\n\nEND \n\n");

            Console.WriteLine("Press any key to continue to next test.");
            Console.ReadLine();
        }

        public static void testMulti() {
            testOneM();
            //testTwoM();
            //testThreeM();
        }
        public static void Main(string[] args)
        {

            testMulti();
            //testWeb();
        }
    }
}