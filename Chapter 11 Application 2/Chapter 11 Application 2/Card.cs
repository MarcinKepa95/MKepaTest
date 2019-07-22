using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_Application_2
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "http://www.headfirstlabs.com/Chapter11")]
    class Card
    {
        [DataMember]
        public Suit suit { get; set; }

        [DataMember]
        public Value value { get; set; }

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }

        private static Random r = new Random();

        public static Card RandomCard()
        {
            return new Card((Suit)r.Next(4), (Value)r.Next(1, 14));
        }
        public string Name
        {
            get { return value.ToString() + " of " + suit.ToString(); }
        }
        public override string ToString() { return Name; }
    }
    enum Suit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    }
    enum Value
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
}