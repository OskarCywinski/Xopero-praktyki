using System;
using System.Collections.Generic;
using System.Text;

namespace Planowanie_przyjęcia
{
    class DinnerParty
    {
        //public const int CostOfFoodPerPerson = 25;
        //public int NumberOfPeople { get; set; }
        //public bool FancyDecorations { get; set; }
        //public bool HealthyOption { get; set; }

        //public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        //{
        //    NumberOfPeople = numberOfPeople;
        //    FancyDecorations = fancyDecorations;
        //    HealthyOption = healthyOption;
        //}

        //private decimal CalculateCosOfDecorations()
        //{
        //    decimal costOfDecorations;
        //    if (FancyDecorations)
        //    {
        //        costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
        //    }
        //    else
        //    {
        //        costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        //    }
        //    return costOfDecorations;
        //}

        //private decimal CalculateCostOfBeveragesPerPerson()
        //{
        //    decimal costOfBeveragesPerPerson;
        //    if (HealthyOption)
        //    {
        //        costOfBeveragesPerPerson = 5M;
        //    }
        //    else
        //    {
        //        costOfBeveragesPerPerson = 20M;
        //    }
        //    return costOfBeveragesPerPerson;
        //}

        //public decimal Cost
        //{
        //    get
        //    {
        //        decimal totalCost = CalculateCosOfDecorations();
        //        totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
        //        if (HealthyOption)
        //        {
        //            totalCost *= .95M;
        //        }
        //        return totalCost;
        //    }
        //}


        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.0M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.0M;
            }
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.0M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
