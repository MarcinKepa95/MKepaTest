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

namespace ExcusesManager
{
    public partial class Form1 : Form
    {
        private Excuse currentexcuse;
        private bool formChanged;
        private string Folder;
        public Form1()
        {
            InitializeComponent();
            currentexcuse = new Excuse();
            if(currentexcuse != null)
                currentexcuse.LastUsed = lastUsed.Value;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Folder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentexcuse.Description;
                this.results.Text = results.Text;
                this.lastUsed.Value = currentexcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentexcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentexcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
                else
                    this.Text = "Excuse Manager*";
                this.formChanged = changed;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            currentexcuse.SaveFile(Folder);
        }
    }
}
