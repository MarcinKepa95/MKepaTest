using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Application_1
{
    class DinnerParty
    {
        public const int CostForFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public decimal Cost
        {
            get
            {
                decimal cost;
                cost = CalculateCostForDecorative() + 
                    CalculateCostForBeveragesPerPerson() * NumberOfPeople + 
                    CostForFoodPerPerson * NumberOfPeople;

                if (HealthyOption)
                    cost -= 0.05M * cost;
                return cost;
            }
        }

        public bool FancyDecorations { get; set; }

        public bool HealthyOption { get; set; }

        private decimal CalculateCostForDecorative()
        {
            if (FancyDecorations)
                return 15M * NumberOfPeople + 50M;
            return 7.5M * NumberOfPeople + 30M;
        }
        private decimal CalculateCostForBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5M;
            return 20M;
        }

        public DinnerParty(int numberOfPeople, bool FancyDecorations, bool HealthyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecorations = FancyDecorations;
            this.HealthyOption = HealthyOption;
        }
    }
}
