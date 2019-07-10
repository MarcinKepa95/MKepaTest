using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_2
{
    public enum Style
    {
        Sneakers,
        Clogs,
        Wingtips,
        Loafers,
        FlipFlops
    }
    class Shoe
    {
        public Style Style { get; set; }
        public string Color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> ShoeCloset = new List<Shoe>();

            ShoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Black" });
            ShoeCloset.Add(new Shoe() { Style = Style.Clogs, Color = "Brown" });
            ShoeCloset.Add(new Shoe() { Style = Style.Wingtips, Color = "Black" });
            ShoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "White" });
            ShoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "Red" });
            ShoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Green" });

            int numberOfShoes = ShoeCloset.Count;

            foreach(Shoe shoe in ShoeCloset)
            {
                shoe.Style = Style.FlipFlops;
                shoe.Color = "Orange";
            }

            ShoeCloset.RemoveAt(4);
            Shoe thirdShoe = ShoeCloset[2];
            Shoe secondShoe = ShoeCloset[1];
            ShoeCloset.Clear();

            ShoeCloset.Add(thirdShoe);
            if (ShoeCloset.Contains(secondShoe))
                Console.WriteLine("That's surprising.");
            Console.ReadKey();
        }
    }
}
