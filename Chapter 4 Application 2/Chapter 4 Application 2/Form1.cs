using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Application_2
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;

        double milestraveled;
        double reimburseRate = .39;
        double amountOwned;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int) Start.Value;
            endingMileage = (int)End.Value;
            if (startingMileage<endingMileage)
            {
                milestraveled = endingMileage - startingMileage;
                amountOwned = milestraveled * reimburseRate;
                Amount.Text = "$" +amountOwned;
            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot calculate Mileage");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milestraveled + " miles", "Miles traveled");
        }
    }
}
