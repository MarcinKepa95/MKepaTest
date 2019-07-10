using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suit.Clubs, Value.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Value.Three);
            Console.WriteLine(doesItMatch);
            Console.ReadKey();
        }
    }
}
