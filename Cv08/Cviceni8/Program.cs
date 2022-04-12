using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathWrite = @"archivTeplot.txt";
            string pathRead = @"Teploty.txt";

            RecordsOfTemperature temperature = new RecordsOfTemperature();

            temperature.Load(pathRead);
            temperature.PrintTemperature();
            temperature.PrintAverageTemperature();
            temperature.PrintAverageMensemTemperature();
            temperature.Calibration(-0.1);
            temperature.Find(2013);          
            Console.ReadLine();
            temperature.Save(pathWrite);
        }
    }
}
