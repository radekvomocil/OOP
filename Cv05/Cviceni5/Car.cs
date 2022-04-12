using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni5
{
    class Car : Auto
    {
        private int maxPeople;
        private int transportPeople;
        private int maxLoad;
        private int transportLoad;

        public Car(int numberOfPeople, double amountOfFuel, int numberOfLoad, TypPaliva fuel):base(amountOfFuel, fuel)
        {
            maxPeople = 5;
            maxFuel = 70;
            maxLoad = 15;

            if(numberOfPeople <= maxPeople && amountOfFuel <= maxFuel && numberOfLoad <= maxLoad)
            {
                transportPeople = numberOfPeople;
                Oil = fuel;
                transportLoad = numberOfLoad;
            }
            else
                throw new Exception("You´re dumb, you´ve entered more than max number of load, fuel or people, repair it!");
        }

        public override string ToString()
        {
            return String.Format($"Car \nNumber of transporting people: {transportPeople}, number of transporting load: {transportLoad} kg, amount of fuel: {tankCondition}l, type of fuel: {Oil}\n");
        }

    }
}
