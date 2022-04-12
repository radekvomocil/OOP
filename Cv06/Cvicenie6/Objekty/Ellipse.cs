using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie6.Objekty
{
    class Ellipse : Objekt2D
    {
        private double halfaxisA;
        private double helfaxisB;

        public Ellipse(double a, double b)
        {
            this.halfaxisA = a;
            this.helfaxisB = b;
        }

        public override double CalcArea()
        {
            return halfaxisA * helfaxisB * Math.PI;
        }

        public override void Draw()
        {
            Console.WriteLine($"Ellipse\nhalfaxis A:{halfaxisA}, halfaxis B:{helfaxisB}\n");
        }
    }
}
