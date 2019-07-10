using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_4
{
    public enum Suit
    {
        Diamonds,
        Clubs,  
        Hearts,
        Spades,
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
        public Suit suit;
        public Value value;

        public string Name
        {
            get
            {
                return value.ToString() + " of " + suit.ToString(); 
            }
        }

        public Card()
        {
        }

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }

    }

    class CardComparer : IComparer<Card>
    {

        public int Compare(Card x, Card y)
        {
            if (x.value > y.value)
                return 1;
            if (x.value < y.value)
                return -1;
            if (x.suit > y.suit)
                return 1;
            if (x.suit < y.suit)
                return -1;
            return 0;
        }
    }
}
