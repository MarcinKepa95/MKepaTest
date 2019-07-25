using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_13_Application_3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public int ReturnThreeValues(out double half, out int twice)
        {
            int val = random.Next(1000);
            half = 0.5d * val;
            twice = 2 * val;
            return val;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            double b = 0;
            int c = 0;
            a = ReturnThreeValues(out b, out c);
            MessageBox.Show(a + "\n" + b + "\n" + c);
        }
        public void modifyAnIntAndButton(ref int value, ref Button button)
        {
            int i = value;
            i *= 5;
            value = i - 3;
            button = button1;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            int q = 100;
            Button b = button2;
            modifyAnIntAndButton(ref q, ref b);
            Console.WriteLine("q = {0}, b.Text = {1}", q, b.Text);
        }

        public void CheckTemperature(double temperature, double TooHigh = 37, double TooLow = 36)
        {
            if (temperature < TooHigh && temperature > TooLow)
                Console.WriteLine("Feeling Good!");
            else Console.WriteLine("Uh-Oh -- Better see a doctor");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CheckTemperature(37.3);
            CheckTemperature(37.3, 37.6, 37.2);
            CheckTemperature(35.9, TooLow: 35.8);
        }
    }
}
