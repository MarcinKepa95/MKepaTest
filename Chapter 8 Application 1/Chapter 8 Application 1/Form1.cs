using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8_Application_1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        List<Card> cards = new List<Card>();
        public Form1()
        {
            InitializeComponent();
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<13; j++)
                {
                    cards.Add(new Card((Suit)i, (Value)j+1));
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cards[rand.Next(0, 52)].Name);
        }
    }
}
