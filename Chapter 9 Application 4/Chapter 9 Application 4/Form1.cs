using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter_9_Application_4
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card(
                (Suit)random.Next(4),
                (Value)random.Next(1, 14)));
            }
            return myDeck;
        }
        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("------------------");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Deck decktowrite = RandomDeck(5);

            using (Stream output = File.Create("deck1.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, decktowrite);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("deck1.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                DealCards((Deck)formatter.Deserialize(input), "What i read from the file");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for(int i=1; i<5; i++)
                {
                    Deck decktowrite = RandomDeck(random.Next(1, 10));
                    bf.Serialize(output, decktowrite);
                    DealCards(decktowrite, "Deck #" + i + " written");
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for(int i=1; i<5; i++)
                {
                    DealCards((Deck)bf.Deserialize(input), "Deck #" + i + " read");
                }
            }
        }
    }
}
