using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator
{
    public partial class Form1 : Form
    {
        bool win;
        int winner;
        public GreyHound[] greyHounds = new GreyHound[4];
        public Punter[] punters = new Punter[3];
        public Form1()
        {
            InitializeComponent();
            GreyHound.randomizer = new Random();
            greyHounds[0] = new GreyHound()
            {
                MyPictureBox = Dog1,
                startingPosition = Dog1.Left
            };
            greyHounds[1] = new GreyHound()
            {
                MyPictureBox = Dog2,
                startingPosition = Dog2.Left
            };
            greyHounds[2] = new GreyHound()
            {
                MyPictureBox = Dog3,
                startingPosition = Dog3.Left
            };
            greyHounds[3] = new GreyHound()
            {
                MyPictureBox = Dog4,
                startingPosition = Dog4.Left
            };

            punters[0] = new Punter()
            {
                name = "Joe",
                cash = 50,
                label = joeBetLabel,
                radioButton = joeRadioButton
            };
            punters[1] = new Punter()
            {
                name = "Bob",
                cash = 75,
                label = bobBetLabel,
                radioButton = BobRadioButton
            };
            punters[2] = new Punter()
            {
                name = "Al",
                cash = 45,
                label = alBetLabel,
                radioButton = alRadioButton
            };
            for(int i=0; i<3; i++)
            {
                punters[i].bet = new Bet() { Amount = 0, Dog = 0, punter = punters[i] };
                punters[i].Collect(0);
            }
        }

        private void MinimumBetLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if(punters[i].radioButton.Checked)
                {
                    punters[i].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int i = 0; i < 4; i++)
            {
                greyHounds[i].RacetrackLength = pictureBox1.Width - Dog1.Width;
                groupBox1.Enabled = false;
            }
            win = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!win)
            {
                winner = GreyHound.randomizer.Next(4);
                if (greyHounds[winner].Run())
                {
                    win = true;
                }
                if (win)
                {
                    MessageBox.Show("Dog #" + winner+" won the race!", "We have a winner");

                    for (int i = 0; i < 4; i++)
                        greyHounds[i].TakeStartingPosition();
                    for (int i = 0; i < 3; i++)
                    {
                        punters[i].Collect(winner);
                    }
                    groupBox1.Enabled = true;
                }
            }
        }
    }
}
