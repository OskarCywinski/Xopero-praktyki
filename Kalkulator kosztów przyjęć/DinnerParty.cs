using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_kosztów_przyjęć
{
    class DinnerParty : Party
    {

        public bool HealthyOption { get; set; }
        public DinnerParty (int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
        
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal CostOfBeveragesPerPerson;
            if (HealthyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;

            return CostOfBeveragesPerPerson;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                    totalCost *= 0.95M;
                return totalCost;
            }

        }

    }
}
