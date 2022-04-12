using Cvicenie6.Objekty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie6
{
    class Program
    {
        static void Main(string[] args)
        {
            GrObjekt[] pole = new GrObjekt[] {
                    new Circle(4.2),
                    new Ellipse(2, 6),
                    new Pyramid(2, 5.4, 4),
                    new Ball(3),
                    new Block(3, 5.4, 10),
                    new Oblong(6, 8),
                    new Triangle(4.2, 5, 8),
                    new Cylinder(2, 5)
            };

            double area = 0;
            double surface = 0;
            double Extend = 0;

            foreach (var item in pole)
            {
                item.Draw();
                if ( item is Objekt2D)
                {
                    area += ((Objekt2D)item).CalcArea();
                }
                else
                {
                    surface += ((Objekt3D)item).CalcSurface();
                    Extend += ((Objekt3D)item).CountExtend();
                }
            }

            Console.WriteLine($"\nTotal area is: {area} \nTotal surface is: {surface} \nTotal extend is: {Extend}");
            Console.ReadLine();

        }
    }
}
