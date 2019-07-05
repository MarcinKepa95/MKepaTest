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
        DinnerParty dinnerParty = new DinnerParty();
        public Form1()
        {
            InitializeComponent();
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            dinnerParty.CalculateCostOfDecorations(FancyDecorations.Checked);
            dinnerParty.SetHealthlyOption(HealthyOption.Checked);
            Cost.Text = dinnerParty.CalculateCost(HealthyOption.Checked);
        }

        private void FancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(FancyDecorations.Checked);
            Cost.Text = dinnerParty.CalculateCost(HealthyOption.Checked);
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            dinnerParty.CalculateCostOfDecorations(FancyDecorations.Checked);
            dinnerParty.SetHealthlyOption(HealthyOption.Checked);
            Cost.Text = dinnerParty.CalculateCost(HealthyOption.Checked);
        }

        private void HealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthlyOption(HealthyOption.Checked);
            Cost.Text = dinnerParty.CalculateCost(HealthyOption.Checked);
        }
    }
}
