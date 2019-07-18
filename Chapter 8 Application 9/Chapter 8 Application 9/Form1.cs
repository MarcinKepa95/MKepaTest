using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8_Application_9
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public Form1()
        {
            InitializeComponent();
            RedrawList();
            label2.Text = "";
        }

        private void AddFlapjackButton_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Flapjack food;
            if (crispyRadio.Checked) food = Flapjack.Crispy;
            else if (soggyRadio.Checked) food = Flapjack.Soggy;
            else if (brownedRadio.Checked) food = Flapjack.Browned;
            else food = Flapjack.Banana;

            Lumberjack current = breakfastLine.Peek();
            current.TakeFlapjacks(food, (int)numberOfLumberjack.Value);
            RedrawList();
            label2.Text = current.Name + " has " + current.flapjackCount + " flapjacks";
        }

        private void RedrawList()
        {
            line.Items.Clear();
            int i = 1;
            foreach(Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(i+ ". " + lumberjack.Name);
                i++;
            }
        }

        private void NextLumberjackButton_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack current = breakfastLine.Dequeue();
            current.EatFlapjacks();
            label2.Text = "";
            RedrawList();
        }

        private void AddLumberjackButton_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            name.Text = "";
            RedrawList();
        }

        private void Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                breakfastLine.Enqueue(new Lumberjack(name.Text));
                name.Text = "";
                RedrawList();
            }

        }
    }
}
