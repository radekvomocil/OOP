using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie6.Objekty
{
    class Cylinder : Objekt3D
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double CalcSurface()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public override double CountExtend()
        {
            return Math.PI * radius * radius * height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Cylinder\nradius:{radius}, height:{height}");
        }
    }
}
