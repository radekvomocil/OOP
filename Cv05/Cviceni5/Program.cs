using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(5, 50, 10, Auto.TypPaliva.Benzine);
            Car car2 = new Car(1, 34, 4, Auto.TypPaliva.Hydrogen);
            Truck truck = new Truck(15, 70, 2, Auto.TypPaliva.Oil);
            Truck truck2 = new Truck(25, 64, 3, Auto.TypPaliva.Electric);

            car.setRadio(false);
            car2.setRadio(true);
            truck.setRadio(true);
            truck2.setRadio(false);
            car.setCode(3, 142);
            car2.setCode(4, 55.8);
            truck.setCode(5, 15.6);
            truck2.setCode(6, 45.6);
            car.setNewCode(3);
            car.writeRadio();
            car2.setNewCode(4);
            car2.writeRadio();
            truck.setNewCode(5);
            truck.writeRadio();
            truck2.setNewCode(6);
            truck2.writeRadio();


            Console.WriteLine(car);
            Console.WriteLine(car2);
            Console.WriteLine(truck);
            Console.WriteLine(truck2);
            Console.ReadLine();
        }
    }
}
