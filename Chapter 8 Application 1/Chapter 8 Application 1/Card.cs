using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_1
{
    public enum Suit
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }
    public enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
    class Card
    {
        Suit suit;
        Value value;
        public string Name
        {
            get
            {
                return suit.ToString() + " of " + value.ToString();
            }
        }

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
