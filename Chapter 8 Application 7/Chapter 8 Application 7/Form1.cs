using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8_Application_7
{
    
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Deck Deck1;
        Deck Deck2;
        List<Card> cards = new List<Card>();
        public Form1()
        {
            InitializeComponent();
            InitDeck1();
            Deck2 = new Deck();
            UpdateStatus();
        }
        private void UpdateStatus()
        {
            DeckListBox1.Items.Clear();
            DeckListBox1.Items.AddRange(Deck1.getCardsName().ToArray());
            DeckListBox2.Items.Clear();
            DeckListBox2.Items.AddRange(Deck2.getCardsName().ToArray());
            Deck1Label.Text = "Deck #1 (" + DeckListBox1.Items.Count + "cards)";
            Deck2Label.Text = "Deck #2 (" + DeckListBox2.Items.Count + "cards)";
        }
        private void InitDeck1()
        {

            for (int i = 0; i < rand.Next(10); i++)
                cards.Add(new Card((Suit)rand.Next(4), (Value)rand.Next(1, 13)));
            Deck1 = new Deck(cards);
        }
        private void ResetDeck1_Click(object sender, EventArgs e)
        {
            Deck1 = new Deck(cards);
            UpdateStatus();
        }

        private void ResetDeck2_Click(object sender, EventArgs e)
        {
            Deck2 = new Deck();
            UpdateStatus();
        }

        private void LeftToRight_Click(object sender, EventArgs e)
        {
            int selected = DeckListBox1.SelectedIndex;
            Deck2.Add(Deck1.Deal(selected));
            UpdateStatus();
            if (selected > 0)
                selected--;
            if (selected < DeckListBox1.Items.Count)
                DeckListBox1.SelectedIndex = selected;
        }

        private void RightToLeft_Click(object sender, EventArgs e)
        {
            int selected = DeckListBox2.SelectedIndex;
            Deck1.Add(Deck2.Deal(DeckListBox2.SelectedIndex));
            UpdateStatus();
            if (selected > 0)
                selected--;
            if (selected < DeckListBox2.Items.Count)
                DeckListBox2.SelectedIndex = selected;
        }

        private void ShuffleDeck1_Click(object sender, EventArgs e)
        {
            Deck1.Shuffle();
            UpdateStatus();
        }

        private void ShuffleDeck2_Click(object sender, EventArgs e)
        {
            Deck2.Shuffle();
            UpdateStatus();
        }
    }
}
