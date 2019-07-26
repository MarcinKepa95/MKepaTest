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
    
    public partial class BookCatalog : Form
    {
        Model.Catalog catalog = new Model.Catalog();
        string path;
        public BookCatalog()
        {
            InitializeComponent();
            Genre.Items.AddRange(Enum.GetNames(typeof(Model.BookGenre)));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook(catalog, BookList);
            addbook.ShowDialog();
            Publisher.Items.Clear();
            foreach(Model.Publishers p in catalog.PublishersBooks.Values)
            Publisher.Items.Add(p.PublisherName);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            catalog.SaveClass("");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            catalog.LoadClass("");
        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(catalog.Books.Count < BookList.SelectedIndex)
            BookDescription.Text = catalog.Books[BookList.SelectedIndex].Description;
        }
    }
}
