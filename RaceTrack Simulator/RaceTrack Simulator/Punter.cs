using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Punter punter;

        public string GetDescription()
        {
            if (Amount == 0)
                return punter.name + " hasn't placed a bet";
            return punter.name + " bets " + Amount + " on dog #" + Dog;
        }

        public int PayOut(int winner)
        {
            if (winner == Dog) return Amount;
            else return -Amount;
        }
    }

    public class GreyHound
    {
        public int startingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public static Random randomizer;

        public bool Run()
        {
            Location += 5;
            MyPictureBox.Left = startingPosition + Location;
            return RacetrackLength <= MyPictureBox.Left - startingPosition;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = startingPosition;
        }
    }

    public class Punter
    {
        public string name;
        public int cash;
        public Bet bet;

        public RadioButton radioButton;
        public Label label;

        public void updateLabel()
        {
            radioButton.Text = name + " has " + cash + " bucks";
            label.Text = bet.GetDescription();
        }

        public void ClearBet()
        {
            bet.Amount = 0;
        }

        public bool PlaceBet(int betAmount, int dogToWin)
        {
            bet.Dog = dogToWin;
            if (betAmount <= cash)
                bet.Amount = betAmount;
            else
            {
                bet.Amount = 0;
                MessageBox.Show(name + " Dont have enough bucks");
            }
            updateLabel();
            return betAmount <= cash;
        }
        
        public void Collect(int Winner)
        {
            cash+=bet.PayOut(Winner);
            ClearBet();
            updateLabel();
        }
    }
}
