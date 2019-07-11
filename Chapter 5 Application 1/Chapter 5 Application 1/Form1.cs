using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_5_Application_1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(25, FancyDecorations.Checked, HealthyOption.Checked);
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            Cost.Text = dinnerParty.Cost.ToString("c");
        }

        private void FancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = FancyDecorations.Checked;
            Cost.Text = dinnerParty.Cost.ToString("c");
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            Cost.Text = dinnerParty.Cost.ToString("c");
        }

        private void HealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = HealthyOption.Checked;
            Cost.Text = dinnerParty.Cost.ToString("c");
        }
    }
}
