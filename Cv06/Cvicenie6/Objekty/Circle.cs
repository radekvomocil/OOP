using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie6.Objekty
{
    class Circle : Objekt2D
    {
        private double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public override double CalcArea()
        {
            return Math.PI * radius * radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle\nradius:{radius}\n");
        }
    }
}
