using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaDostopa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Študent janez = new Študent();
            //janez.starost = 4;
            //janez.povprečnaOcena = 9.5;
            Console.WriteLine(janez.Ime);
            janez.Ime = "Janez Kovač";
            janez.Starost = 12;
            if (janez.Starost==-1)
                Console.WriteLine("Napačna starost");
            janez.Izpis();
            
            Console.ReadLine();
        }
    }
}
