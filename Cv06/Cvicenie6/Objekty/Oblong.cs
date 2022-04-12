using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie6.Objekty
{
    class Oblong:Objekt2D
    {
        private double sideA;
        private double sideB;

        public Oblong(double a, double b)
        {
            this.sideA = a;
            this.sideB = b;
        }

        public override double CalcArea()
        {
            return sideA * sideB;
        }

        public override void Draw()
        {
            Console.WriteLine($"Oblong\nside A:{sideA}, side B:{sideB}\n");
        }
    }
}
