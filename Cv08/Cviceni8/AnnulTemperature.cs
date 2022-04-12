using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni8
{
    class AnnulTemperature
    {
        private double year;
        private List<double> mensemTemperature;
        private double averageAnnumTemperature;

        public AnnulTemperature(double year, List<double> temperature)
        {
            this.year = year;
           // this.mensemTemperature = new List<double>();
            this.mensemTemperature = temperature;
        }
       
        public double Year
        {
            get { return year; }
            set { year = value; }
        }

        public List<double> MensemTemperature
        {
            get=> mensemTemperature;
            set=> mensemTemperature = value; 
        }
        
        public double MaxTemp
        {
            get 
            {
                return mensemTemperature.Max();
            }
        }

        public double MinTemp
        {
            get 
            {
                return mensemTemperature.Min();
            }
        }

        public double AverageAnnumTemperature
        {
            get 
            {
                averageAnnumTemperature = mensemTemperature.Average();
                return averageAnnumTemperature; 
            }
        }

    }
}
