using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Fish_WPF_
{
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(new Card((Suit)i, (Value)j));
                }
            }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count{get{ return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card toDeal = cards[index];
            cards.RemoveAt(index);
            return toDeal;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            List<Card> c2 = new List<Card>();
            int cardscount = cards.Count;
            for (int i=0; i<cardscount; i++)
            {
                int x = rand.Next(cards.Count);
                c2.Add(cards[x]);
                cards.RemoveAt(x);
            }
            cards = c2;
        }

        public IEnumerable<string> getCardsName()
        {
            string[] cardsname = new string[cards.Count];
            for(int i=0; i<cards.Count;i++)
            {
                cardsname[i] = cards[i].Name;
            }
            return cardsname;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer());
        }
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }
        public Card Deal()
        {
            return Deal(0);
        }

        public bool ContainsValue(Value value)
        {
            foreach (Card card in cards)
                if (card.value == value)
                    return true;
            return false;
        }

        public Deck PullOutValues(Value value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        public bool HasBook(Value value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }
    }
}
