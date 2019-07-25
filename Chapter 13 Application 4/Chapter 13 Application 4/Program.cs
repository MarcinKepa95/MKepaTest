using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13_Application_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter birthday: ");
            string birthday = Console.ReadLine();
            Console.Write("Enter height in inches: ");
            string height = Console.ReadLine();
            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy.ToString());
            Console.ReadKey();
        }
    }

    public class RobustGuy
    {
        public DateTime? Birthday { get; private set; }
        public int? Height { get; private set; }

        public RobustGuy(string birthday, string height)
        {
            DateTime tempdate;
            if (DateTime.TryParse(birthday, out tempdate))
                Birthday = tempdate;
            else
                Birthday = null;
            int tempInt;
            if (int.TryParse(height, out tempInt))
                Height = tempInt;
            else Height = null;
        }

        public override string ToString()
        {
            string description;
            if (Birthday.HasValue)
                description = "I was born on " + Birthday.Value.ToLongDateString();
            else
                description = "I dont know my birthday";
            if (Height.HasValue)
                description += ", and Im " + Height + "inches tall";
            else description += ", and I dont know my height";
            return description;
        }
    }
}
