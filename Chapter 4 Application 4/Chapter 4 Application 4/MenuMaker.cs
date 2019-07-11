using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Application_4
{
    class MenuMaker
    {
        public Random randomizer;

        string[] meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "Yellow mustard", "Brown mustard", "Honey mustard", "Mayo", "Relish", "French dressing" };
        string[] Breads = { "Rye", "White", "Wheat", "Pumpernickel", "Italian bread", "A roll" };
        
        public string GetMenuItems()
        {
            string randomMeat = meats[randomizer.Next(0, meats.Length)];
            string randomCondiments = Condiments[randomizer.Next(0, Condiments.Length)];
            string randomBreads = Breads[randomizer.Next(0, Condiments.Length)];
            return randomMeat + " with " + randomCondiments + " on " + randomBreads;
        }
    }
}
