using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie6.Objekty
{
    class Block : Objekt3D
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Block(double a, double b, double c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }

        public override double CalcSurface()
        {
            return 2 * (sideA * sideB + sideB * sideC + sideA * sideC);
        }

        public override double CountExtend()
        {
            return sideA * sideB * sideC;
        }

        public override void Draw()
        {
            Console.WriteLine($"Block\nside A:{sideA}, side B:{sideB}, side C:{sideC}\n");
        }
    }
}
