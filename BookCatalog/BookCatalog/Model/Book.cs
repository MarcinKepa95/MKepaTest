using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Model
{
    [Serializable]
    class Book
    {
        public string Title { get; protected set; }
        public string Description { get; protected set; }

        public int relaseDate { get; protected set; }
        protected bool required;
        protected int year;
        protected string direction;
        
        public string Required
        {
            get
            {
                if (required)
                    return "Ta książka jest obowiązkowa na " + year + " roku kształcenia na kierunku: " + direction + ".";
                else return "To nie jest lektura obowiązkowa.";
            }
        }
        public void EditBook(string Title = null, string description = null, int? relasedata = null, 
            bool? required = null, int? year = null, string direction = null)
        {
            if (Title != null)
                this.Title = Title;
            if (description != null)
                this.Description = null;
            if (relasedata != null)
                this.Description = null;
            if (required != null)
                this.required = (bool)required;
            if (year != null)
                this.year = (int)year;
            if (direction != null)
                this.direction = direction;
        }
        public Book(string Title, string Description, int relaseDate, bool required = false, int year = 0, string direction = "" )
        {
            this.Title = Title;
            this.Description = Description;
            this.required = required;
            this.year = year;
            this.direction = direction;
            this.relaseDate = relaseDate;
        }
    }

    class RareBook : Book
    {
        public string History { get; private set; }

        public new string Description
        {
            get
            {
                return base.Description + Environment.NewLine + Environment.NewLine + History;
            }
        }
        public RareBook(string Title, string Description, int relaseDate, string History) : base(Title, Description,relaseDate)
        {
            this.History = History;
        }
    }


}
