using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_6
{

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

        public static bool DoesCardMatch(Card cardToCheck, Suit suit)
        {
            if (cardToCheck.suit == suit)
                return true;
            return false;
        }
        public static bool DoesCardMatch(Card cardToCheck, Value value)
        {
            if (cardToCheck.value == value)
                return true;
            return false;
        }

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }

    }
}
