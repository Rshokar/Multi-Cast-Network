using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4945_A2.Packet
{
    public class Packet
    {
        private const int DEFAULT_SIZE = 6;
        private byte[] data = new byte[DEFAULT_SIZE];

        public Packet() {
            // Set default values for each byte in the data
            Random random = new Random();
            for (int i = 0; i < DEFAULT_SIZE; i++)
            {
                data[i] = (byte) random.Next(0, 255);
            }
        }

        public Packet(byte user, byte fruit, byte action)
        {
            SetUser(user);
            SetFruit(fruit);
            SetAction(action);
        }

        // End: takes a score
        public Packet(byte user, byte fruit, byte action, byte score)
        {
            SetUser(user);
            SetFruit(fruit);
            SetAction(action);
            SetValues(score, 0, 0);
        }

        // Throw: takes 3 position values
        public Packet(byte user, byte fruit, byte action, byte x, byte y, byte z)
        {
            SetUser(user);
            SetFruit(fruit);
            SetAction(action);
            SetValues(x, y, z);
        }



        public byte GetUser()
        {
            return data[0];
        }
        public void SetUser(byte userID)
        {
            data[0] = userID;
        }

        public byte GetFruit()
        {
            return data[1];
        }
        public void SetFruit(byte fruit)
        {
            data[1] = fruit;
        }

        public byte GetAction()
        {
            return data[2];
        }
        public void SetAction(byte action)
        {
            data[2] = action;
        }

       
        public byte[] GetValues()
        {
            // Values in our packet are 3 bytes in size
            byte[] values = new byte[3];
            values[0] = data[3];
            values[1] = data[4];
            values[2] = data[5];

            return values;
        }
        public void SetValues(byte val1, byte val2, byte val3)
        {
            data[3] = val1;
            data[4] = val2;
            data[5] = val3;
        }

    }
}
