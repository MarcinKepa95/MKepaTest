using System;
using System.Collections.Generic;

namespace Chapter_8_Application_9
{
    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana
    }
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public int flapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for(int i=0; i<howMany; i++)
                meal.Push(food);
        }

        public void EatFlapjacks()
        {
            while(meal.Count>0)
                Console.WriteLine(Name + " ate a " + meal.Pop() + " flapjack");

        }

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

    }
}
