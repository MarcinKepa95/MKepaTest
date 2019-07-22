using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xaml;

namespace Go_Fish_WPF_
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private Game game;
        
        public Player(String name, Random random, Game game)
        {
            this.name = name;
            this.random = random;
            List<Card> cart = new List<Card>();
            cards = new Deck(cart);

            game.AddProgress(name + " has just joined the game");
        }
        public IEnumerable<Value> PullOutBooks()
        {
            List<Value> books = new List<Value>();
            for (int i = 1; i <= 13; i++)
            {
                Value value = (Value)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }
        public Value GetRandomValue()
        {
            int v;
            do
            {
                v = random.Next(1, 13);
            } while (!cards.ContainsValue((Value)v));
            return (Value)v;
        }
        public Deck DoYouHaveAny(Value value)
        {
            Deck exactCards = cards.PullOutValues(value);
            if (exactCards.Count > 0)
                game.AddProgress(name + " has " + exactCards.Count + " " + Card.Plural(value));
                SortHand();
            return exactCards;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            AskForACard(players, myIndex, stock, GetRandomValue());
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Value value)
        {
            game.AddProgress(name + " asks if anyone has a "+value);
            int DeckCount = CardCount;
            foreach(Player player in players)
            {
                if (player != this)
                {
                    Deck deck = player.DoYouHaveAny(value);
                    while (deck.Count > 0)
                    {
                        DeckCount++;
                        TakeCard(deck.Deal(0));
                    }
                }
            }
            if (DeckCount == 0)
            {
                game.AddProgress(name + " must draw from the stock.");
                TakeCard(stock.Deal(0));
            }
            SortHand();
        }

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.getCardsName(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
    public partial class Card
    {
        public static string Plural(Value value)
        {
            if (value == Value.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}
