using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni5
{
    class Truck : Auto
    {
        private int maxLoad;
        private double transportingLoad;
        private int maxPeople;
        private int transportingPeople;

        public Truck(double amountofLoad, double amountOfFuel, int amountOfPeople, TypPaliva fuel):base(amountOfFuel, fuel)
        {
            maxLoad = 100;
            maxFuel = 190;
            maxPeople = 3;

            if (amountofLoad <= maxLoad && amountOfFuel <= maxFuel && amountOfPeople <= maxPeople)
            {
                transportingLoad = amountofLoad;
                transportingPeople = amountOfPeople;
                this.Oil = fuel;
            }

            else
            {
                throw new Exception("You are dumb, you´ve entered more than max number of load, fuel or people");
            }
        }

        public override string ToString()
        {
            return String.Format($"Truck \nNumber of transporting people: {transportingPeople}, number of transporting load: {transportingLoad} t, amount of fuel {tankCondition}l, type of fuel: {Oil}\n");
        }
    }
}
