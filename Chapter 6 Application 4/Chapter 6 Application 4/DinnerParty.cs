using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Application_4
{
    class DinnerParty : Party
    {

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostForBeveragesPerPerson() * NumberOfPeople;

                if (HealthyOption)
                    totalCost -= 0.05M * totalCost;
                return totalCost;
            }
        }

        public bool HealthyOption { get; set; }

        private decimal CalculateCostForBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5M;
            return 20M;
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool HealthyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            FancyDecoration = fancyDecorations;
            this.HealthyOption = HealthyOption;
        }
    }
}
