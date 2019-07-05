using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Application_1
{
    class DinnerParty
    {
        const int CostForFoodPerPerson = 25;
        public int NumberOfPeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;

        public void SetHealthlyOption(bool healthlyOption)
        {
            if (healthlyOption)
            {
                CostOfBeveragesPerPerson = 5m;
            }
            else CostOfBeveragesPerPerson = 20m;
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            if(fancyDecorations)
            {
                CostOfDecorations = 50m + (15m * NumberOfPeople);
            } else
            {
                CostOfDecorations = 30m + (7.5m * NumberOfPeople);
            }
        }

        public string CalculateCost(bool healthlyOption)
        {
            decimal totalCost = CostOfDecorations + CostOfBeveragesPerPerson * NumberOfPeople + CostForFoodPerPerson * NumberOfPeople;
            if (healthlyOption)
                totalCost -= 0.05m * totalCost;
            return "$" + totalCost.ToString("c");
        }
    }
}
