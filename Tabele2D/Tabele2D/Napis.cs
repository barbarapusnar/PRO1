using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabele2D
{
    internal class Napis
    {
        string najljubšiProgram;
        public void Izpis()
        {
            Console.WriteLine("Rad imam "+najljubšiProgram);
        }
        public Napis(string n)
        {
            najljubšiProgram = n;
        }
    }
}
