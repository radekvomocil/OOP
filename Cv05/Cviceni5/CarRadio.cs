using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni5
{
    class CarRadio
    {
        private double tunedFrequency;
        private bool radioOn = false;
        private Dictionary<int, double> allFrequencies;
        private int total = 0;

        public void radioIsOn(bool onOff)
        {
            if (onOff)
            {
                radioOn = true;
            }
            else
                radioOn = false;
        }

        public void setCode(int number, double frequency)
        {
            if (total == 0)
            {
                allFrequencies = new Dictionary<int, double>();
                total++;
                allFrequencies.Add(number, frequency);
            }
            else
                 allFrequencies.Add(number, frequency);
        }



        public void setNewCode(int number)
        {
            if (allFrequencies.ContainsKey(number))
            {
                tunedFrequency = allFrequencies[number];
            }
            else
                throw new Exception("Wrong frequency");
        }

        public override string ToString()
        {
            if (radioOn)
            {
                return String.Format($"Is radio on? {radioOn}, tuned frequency: {tunedFrequency} MHz \n");
            }
            else
                return String.Format($"Is radio on? {radioOn}\n");
        }
    }
}

