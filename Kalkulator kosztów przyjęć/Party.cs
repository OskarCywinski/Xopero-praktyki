using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_kosztów_przyjęć
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal CalculateCostOfDecorations()
        {
            decimal CostOfDecorations;
            if (FancyDecorations)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;

            return CostOfDecorations;
        }
        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;
                return totalCost;
            }
        }

    }
}
