using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie7
{
    public class Triangle : Objekt2D
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }

        public override double Surface()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override String ToString()
        {
            return String.Format("Surface of Triangle: " + Surface());
        }

    }
}
