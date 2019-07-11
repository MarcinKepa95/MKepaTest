using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_6_Application_1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,
            FancyDecorations.Checked, HealthyOption.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDown2.Value, checkBox2.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }



        private void FancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = FancyDecorations.Checked;
            DisplayDinnerPartyCost();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void HealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = HealthyOption.Checked;
            DisplayDinnerPartyCost();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecoration = checkBox2.Checked;
            DisplayBirthdayPartyCost();
        }

        private void CakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            Cost.Text = cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            TooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            label4.Text = cost.ToString("c");
        }
    }
}
