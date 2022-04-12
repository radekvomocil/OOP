using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie6.Objekty
{
    class Ball : Objekt3D
    {
        private double radius;

        public Ball(double r)
        {
            this.radius = r;
        }

        public override double CalcSurface()
        {
            return 4 * Math.PI * radius * radius;
        }

        public override double CountExtend()
        {
            return (4 * Math.PI * radius * radius * radius) * 3;
        }

        public override void Draw()
        {
            Console.WriteLine($"Ball\nradius:{radius}\n");
        }
    }
}
