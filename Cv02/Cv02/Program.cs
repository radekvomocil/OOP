using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv02
{
    class cislo
    {
        public int Realna;
        public int Imaginarni;
        static void Main(string[] args)
        {
            cislo cislo = new cislo();
            cislo.Realna = 1;
            cislo.Imaginarni = 2;
            Console.WriteLine(cislo.Realna, Cv02.cislo.Imaginarni) ;
            Console.ReadLine();
        }
        
    }
}
