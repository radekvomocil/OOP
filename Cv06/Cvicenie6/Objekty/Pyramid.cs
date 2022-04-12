using System;

namespace Cvicenie6.Objekty
{
    class Pyramid: Objekt3D
    {
        private double sideA;
        private double sideB;
        private double height;

        public Pyramid(double a, double b, double h)
        {
            this.sideA = a;
            this.sideB = b;
            this.height = h;
        }

        public override double CalcSurface()
        {
            return sideA * height * 2;
        }

        public override double CountExtend()
        {
            return (sideA * sideA * height) / 3;
        }

        public override void Draw()
        {
            Console.WriteLine($"Pyramid\nside A:{sideA}, side B:{sideB}, height:{height}\n");
        }
    }
}
