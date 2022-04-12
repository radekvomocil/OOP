using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni8
{
    class RecordsOfTemperature
    {
        private SortedDictionary<double,AnnulTemperature> _record;

        public void Load(string path)
        {
            StreamReader reader = File.OpenText(path);
            _record = new SortedDictionary<double,AnnulTemperature>();
            double year = 0;
            double number = 0;
 
            string radek = null;
            while ((radek = reader.ReadLine()) != null)
            {
                List<double> temperature = new List<double>();
                radek = radek.Replace(" ","");
                List<string> values = radek.Split(':',';').ToList();

                for (int i = 0; i < values.Count; i++) {
                    number = Convert.ToDouble(values[i]);

                    if (i == 0) year = number;
                    else {
                        temperature.Add(number);
                    }
                }

                _record.Add(year, new AnnulTemperature(year, temperature));
            }
        }
        public void Save(string path)
        {
            StreamWriter writer = File.CreateText(path);

            foreach (var item in _record.Values)
            {
                writer.Write("{0}: ", item.Year);
                for (int i = 0; i < item.MensemTemperature.Count; i++)
                {
             /*      if (i + 1 == item.MensemTemperature.Count)
                    {
                        writer.Write("{0:0.0} ", item.MensemTemperature[i]);
                    }
                    else*/
                        writer.Write("{0:0.0}; ", item.MensemTemperature[i]);
                }
                writer.WriteLine();
            }
            Console.WriteLine("\n\nRecords saved");
            writer.Close();
        }

        public void Calibration(double number)
        {
            Console.WriteLine("Calibration: ");
            foreach (var item in _record.Values)
            {
                for (int i = 0; i < item.MensemTemperature.Count; i++)
                {
                    item.MensemTemperature[i] += number;
                }
            }
            PrintTemperature();
        }

        public void Find(int year)
        {
            Console.WriteLine("Year: " + year);
            if (_record.ContainsKey(year))
            {
                Console.Write("{0}: ", _record[year].Year);
                for (int i = 0; i < _record[year].MensemTemperature.Count; i++)
                {
                    Console.Write("{0:0.0}; ", _record[year].MensemTemperature[i]);
                }
            }
            else
                throw new Exception("You´ve entered year out of database");
        }

        public void PrintTemperature()
        {
            Console.WriteLine("List of temperature: ");
            foreach (var item in _record.Values)
            {
                Console.Write("{0}: ",item.Year);
                for (int i = 0; i < item.MensemTemperature.Count; i++)
                {
                 /*   if (i+1 == item.MensemTemperature.Count)
                    {
                        Console.Write("{0:0.0} ", item.MensemTemperature[i]);
                    }
                    else*/
                        Console.Write("{0:0.0}; ", item.MensemTemperature[i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintAverageTemperature()
        {
            Console.WriteLine("List of average temperature: ");
            foreach (var item in _record.Values)
            {
                Console.Write("{0}: ", item.Year);
                Console.WriteLine("{0:0.0} ", item.AverageAnnumTemperature);
            }
            Console.WriteLine();
        }

        public void PrintAverageMensemTemperature()
        {
            Console.Write("Avg.: ");
            List<double> averageMensem = new List<double>() {0};
            for(int i = 0; i < 12; i++)
            {
                averageMensem.Add(0);
            }

            foreach (var item in _record.Values)
            {
                for (int i = 0; i < item.MensemTemperature.Count; i++)
                {
                    averageMensem[i] += item.MensemTemperature[i];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                averageMensem[i] = averageMensem[i] / _record.Keys.Count;
                Console.Write(" {0:0.0};", averageMensem[i]);
            }
            Console.WriteLine("\n");
        }

    }
}
