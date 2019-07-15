using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter_9_application_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(Suit.Clubs, Value.Three);

            using (Stream input = File.Create("three-c.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(input, card);
            }
            card = new Card(Suit.Hearts, Value.Six);

            using (Stream input = File.Create("six-h.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(input, card);
            }

            byte[] firstfile = File.ReadAllBytes("three-c.dat");
            byte[] secondfile = File.ReadAllBytes("six-h.dat");

            for(int i=0; i<firstfile.Length; i++)
            {
                if (firstfile[i] != secondfile[i])
                    Console.WriteLine("Byte #{0}: {1} vs {2}", i, firstfile[i], secondfile[i]);
            }
            Console.ReadKey();

            firstfile[275] = (byte)Suit.Spades;
            firstfile[332] = (byte)Value.King;
            File.Delete("King-s.dat");
            File.WriteAllBytes("King-s.dat", firstfile);

            Card card2;
            using (Stream output = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                card2 = (Card)bf.Deserialize(output);
            }

            Console.WriteLine(card2.Name);
        }
    }
}
