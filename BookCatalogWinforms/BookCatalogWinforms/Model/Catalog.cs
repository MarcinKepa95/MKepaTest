using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BookCatalogWinforms.Model
{
    [Serializable]
    class Catalog
    {
        public List<Book> Books = new List<Book>();
        public List<Publishers> publishers = new List<Publishers>();
        public Dictionary<Book, List<BookGenre>> GenreBooks = new Dictionary<Book, List<BookGenre>>();
        public Dictionary<Book, Publishers> PublishersBooks = new Dictionary<Book, Publishers>();
        public Catalog()
        {

        }

        public void AddBook(string Title, string Description, List<BookGenre> genre, string Publisher, int relaseDate,
            bool required = false, int year = 0, string direction = "")
        {
            bool publisherFound = false;
            Book book = new Book(Title, Description, relaseDate, required, year, direction);
            Books.Add(book);
            GenreBooks.Add(book, genre);
            foreach (Publishers p in publishers)
            {
                if (p.PublisherName == Publisher)
                {
                    PublishersBooks.Add(book, p);
                    publisherFound = true;
                }
            }
            if (!publisherFound)
            {
                Publishers p = new Publishers(Publisher);
                publishers.Add(p);
                PublishersBooks.Add(book, p);
            }
        }

        public List<Book> FindByBookGenre(List<BookGenre> genre, List<Book> FromList = null)
        {
            if (FromList == null)
                FromList = Books;
            List<Book> bookstoreturn = new List<Book>();
            foreach (Book book in FromList)
            {
                bool a = true;
                for (int i = 0; i < genre.Count; i++)
                {
                    if (!GenreBooks[book].Contains(genre[i]))
                    {
                        a = false;
                        break;
                    }
                }
                if (a) bookstoreturn.Add(book);

            }
            return bookstoreturn;
        }

        public List<Book> FindByPublisher(string Publisher, List<Book> FromList = null)
        {
            if (FromList == null)
                FromList = Books;
            List<Book> bookstoreturn = new List<Book>();
            foreach (Publishers p in publishers)
            {
                if (p.PublisherName == Publisher)
                {
                    foreach (Book book in FromList)
                    {
                        if (PublishersBooks[book] == p)
                            bookstoreturn.Add(book);
                        break;
                    }
                    break;
                }
            }
            return bookstoreturn;
        }

        public List<Book> FindByGenreAndPublisher(List<BookGenre> genre, string Publisher)
        {
            return FindByBookGenre(genre, FindByPublisher(Publisher));
        }

        public List<Book> FindByTitle(string title)
        {
            List<Book> bk = new List<Book>();
            foreach (Book b in Books)
            {
                if (b.Title == title)
                    bk.Add(b);
            }
            return bk;
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
            GenreBooks.Remove(book);
            PublishersBooks.Remove(book);
        }

        public void SaveClass(string path)
        {
            using (Stream OutputStream = File.Create(path+"Catalog.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(OutputStream, this);
            }
        }
        public void LoadClass(string path)
        {
            using (Stream InputStream = File.OpenRead(path+"Catalog.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Catalog cat = (Catalog)bf.Deserialize(InputStream);
                this.Books = cat.Books;
                this.GenreBooks = cat.GenreBooks;
                this.publishers = cat.publishers;
                this.PublishersBooks = cat.PublishersBooks;
            }
        }
    }

    public class Publishers
    {
        public string PublisherName;
        public Publishers(string name)
        {
            PublisherName = name;
        }
    }
    enum BookGenre
    {
        Przyrodnicze,
        Historyczne,
        Fantasy,
        ScienceFiction,
        Horrory,
        Dokumentalne,
        Biografie,
        Autobiografie,
        Pamiętniki,
        Dzienniki,
        Komedie,
        Tragedie,
        ParanormalRomance,
        Kryminały,
        Detektywistyczne,
        Poradniki,
        Hobbistyczne,
        Naukowe,
        Psychologiczne,
        NaFaktach,
        Przygodowe,
        Młodzieżowe
    }
}
