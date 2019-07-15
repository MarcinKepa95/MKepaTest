using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter_9_Application_3
{
    public partial class Form1 : Form
    {
        Guy Joe;
        Guy Bob;
        int Bank = 100;
        public Form1()
        {
            InitializeComponent();
            Joe = new Guy() { Cash = 50, Name = "Joe" };
            Bob = new Guy() { Cash = 100, Name = "Bob" };

        }

        private void UpdateForm()
        {
            JoesCashLabel.Text = Joe.Name + " has $" + Joe.Cash;
            BobsCashLabel.Text = Bob.Name + " has $" + Bob.Cash;
            BankLabel.Text = "The bank has $" + Bank;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Bank >= 10)
            {
                Bank -= Joe.ReceiveCash(10);
                UpdateForm();
            }
            else
                MessageBox.Show("The bank is out of money.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Bank += Bob.GiveCash(5);
            UpdateForm();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Joe.GiveCash(Bob.ReceiveCash(10));
            UpdateForm();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Bob.GiveCash(Joe.ReceiveCash(5));
            UpdateForm();
        }

        private void SaveJoe_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, Joe);
            }
        }

        private void LoadJoe_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Joe = (Guy)formatter.Deserialize(input);
                UpdateForm();
            }
        }
    }
}
