using System;
using System.Collections.Generic;
using System.Text;

namespace Planowanie_przyjęcia_2
{
    class DinnerParty
    {
        private int NumberOfPeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;
        private const int CostOfFoodPerPerson = 25;
        private bool czyrabat;
        private const decimal rabat = 0.95M;
        public void setNumberOfPeople(int numberOfPeople)
        {
            NumberOfPeople = numberOfPeople;
        }
        
        public decimal CalculateCost(bool healthy, bool fancy)
        { 
            if (healthy)
            {
                CostOfBeveragesPerPerson = NumberOfPeople * 5M;
                czyrabat = true;
            }
            else
            {
                CostOfBeveragesPerPerson = NumberOfPeople * 20M;
                czyrabat = false;
            }

            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            
            decimal totalCost =(NumberOfPeople * CostOfFoodPerPerson) + CostOfDecorations + CostOfBeveragesPerPerson;
            if (czyrabat == true)
                return totalCost * rabat;
            else
                return totalCost;
        }


    }
}
