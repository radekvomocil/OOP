using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni5
{
    class Auto
    {

        protected double maxFuel;
        protected double tankCondition;
        protected TypPaliva Oil;
        private CarRadio radio = new CarRadio();
        public enum TypPaliva { Benzine, Oil, Hybrid, Electric, Hydrogen }

        public Auto(double tank, TypPaliva myOil)
        {
            tankCondition = tank;
            Oil = myOil;
        }

        public double size
        {
            get { return maxFuel; }
            set { maxFuel = value; }
        }

        public double condition
        {
            get { return tankCondition; }
            set { tankCondition = value; }
        }

        public TypPaliva typeOfGas
        {
            get { return Oil; }
            set { Oil = value; }
        }

        public void refuel(TypPaliva fuel, double amount)
        {
            if ((tankCondition + amount) <= maxFuel && this.Oil == fuel)
            {
                tankCondition += amount;
            }
            else
            {
                throw new Exception("You´re dumb, you´ve put wrong amount of fuel or type of fuel");
            }
        }

        public void setRadio(bool onOff)
        {
            radio.radioIsOn(onOff);
        }

        public void setCode(int number, double frequency)
        {
            radio.setCode(number, frequency);
        }

        public void setNewCode(int number)
        {
            radio.setNewCode(number);
        }
        public void writeRadio()
        {
            Console.WriteLine(radio);
        }

    }
}
