using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Application_1
{
    class DinnerParty
    {
        private int costForFoodPerPerson;
        public int CostForFoodPerPerson { get { return costForFoodPerPerson; } }

        private int numberOfPeople;

        private decimal cost;
        public decimal Cost
        {
            get
            {
                CalculateCostForBeveragesPerPerson();
                CalculateCostForDecorative();
                cost = CalculateCostForDecorative() + CalculateCostForBeveragesPerPerson() * NumberOfPeople + CostForFoodPerPerson * NumberOfPeople;
                if (HealthyOption)
                    cost -= 0.05M * cost;
                return cost;
            }
        }
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
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

        public DinnerParty(int costForFoodPerPerson, bool FancyDecorations, bool HealthyOption)
        {
            this.costForFoodPerPerson = costForFoodPerPerson;
            this.FancyDecorations = FancyDecorations;
            this.HealthyOption = HealthyOption;
        }
    }
}
