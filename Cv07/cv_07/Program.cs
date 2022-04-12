using System;
using System.Linq;

namespace Cvicenie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] poleInt = new int[] { 1,5,3,7,9};
            string[] poleString = new string[] { "item1", "item2", "item3" };
            Circle[] poleCircle = new Circle[] { new Circle(5), new Circle(7), new Circle(1), };
            Rectangle[] poleRectangle = new Rectangle[] { new Rectangle(5,6), new Rectangle(7,6), new Rectangle(1,5), };
            Objekt2D[] poleObj = new Objekt2D[] { new Circle(1), new Square(16) };
           
            Console.WriteLine("Largest " + Extremy.Largest(poleRectangle) + "\n");
            Console.WriteLine("Largest item is: " + Extremy.Largest(poleString) + "\n");
            Console.WriteLine("Largest number is: " + Extremy.Largest(poleInt) + "\n");
            Console.WriteLine("Largest surface has " + Extremy.Largest(poleObj) + "\n");
            Console.WriteLine("Smallest " + Extremy.Smallest(poleCircle) + "\n");
            Console.WriteLine("Smallest: " + Extremy.Smallest(poleString) + "\n");
            Console.WriteLine("Smallest number is: " + Extremy.Smallest(poleInt) + "\n");
            Console.WriteLine("Smallest surface has " + Extremy.Smallest(poleObj) + "\n");

            var filtered = poleInt.Where(v=> v>4 && v<8);

            Console.Write("Linq filter result: ");
            foreach (int item in filtered)
            {
                Console.Write(item+",");
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
