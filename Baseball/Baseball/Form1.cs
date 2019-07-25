using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball
{
    public partial class Form1 : Form
    {
        Ball ball;
        Fan fan;
        Umpire umpire;
        Pitcher pitcher;
        public Form1()
        {
            InitializeComponent();
            ball = new Ball();
            fan = new Fan(ball);
            umpire = new Umpire(ball);
            pitcher = new Pitcher(ball);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            ball.OnBallInPlay(new BallEventArgs(rand.Next(0,30), rand.Next(50,90)));
        }
    }
}
