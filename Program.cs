using _4945_A2.Network;
using _4945_A2.Threads;


using Network = _4945_A2.Network.Network;
using MultiCast = _4945_A2.Network.MulticastNetwork;
using WebScoket = _4945_A2.Network.WebSocketNetwork;

using Game = _4945_A2.Threads.GameThread;
using User = _4945_A2.Threads.UserThread;

namespace Program { 
    public class Program
    {

        public static void testOneM()
        {
            Game g = new Game();
            Network n = new MultiCast(g);
            User u = new User(n);
        }
        public static void testTwoM()
        {
        }
        public static void testThreeM()
        {
        }

        public static void testMulti() {
            testOneM();
            testTwoM();
            testThreeM();
        }
        public static void Main(string[] args)
        {

            testMulti();

            //testWeb();
        }
    }
}