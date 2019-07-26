using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCatalogWinforms
{
    partial class AddBook : Form
    {
        Model.Catalog refer;
        ListBox listBooks;
        public AddBook(Model.Catalog x, ListBox lb)
        {
            refer = x;
            listBooks = lb;
            InitializeComponent();
            Genre.Items.AddRange(Enum.GetNames(typeof(Model.BookGenre)));
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Required_CheckedChanged(object sender, EventArgs e)
        {
            year.Enabled = Required.Checked;
            direct.Enabled = Required.Checked;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<Model.BookGenre> text = new List<Model.BookGenre>();
            foreach(string cb in Genre.CheckedItems)
            {
                text.Add((Model.BookGenre)Enum.Parse(typeof(Model.BookGenre), cb));
            }
            foreach(Model.BookGenre t in text)
            {
                Console.WriteLine((int)t);
            }
            if (Required.Checked)
                refer.AddBook(bookname.Text, bookdesc.Text, text, publisher.Text, (int)bookrel.Value,
                    Required.Checked, Int32.Parse(year.Text), direct.Text);
            else
                refer.AddBook(bookname.Text, bookdesc.Text, text, publisher.Text, (int)bookrel.Value);
            listBooks.Items.Add(bookname.Text);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
