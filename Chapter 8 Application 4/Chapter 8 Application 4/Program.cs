using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Random random = new Random();
                List<Card> cards = new List<Card>()
            {
                new Card((Suit)random.Next(0,4), (Value)random.Next(1,14)),
                new Card((Suit)random.Next(0,4), (Value)random.Next(1,14)),
                new Card((Suit)random.Next(0,4), (Value)random.Next(1,14)),
                new Card((Suit)random.Next(0,4), (Value)random.Next(1,14)),
                new Card((Suit)random.Next(0,4), (Value)random.Next(1,14))
            };
                foreach (Card card in cards)
                {
                    Console.WriteLine(card.Name);
                }
                cards.Sort(new CardComparer());
                Console.WriteLine();
                foreach (Card card in cards)
                {
                    Console.WriteLine(card.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
