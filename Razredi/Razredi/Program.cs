using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Napis x = new Napis("C#");
            x.Izpiši();
            Napis.Koliko();
            Napis y=new Napis();
            y.najljubšiProgram = "python";
            y.Izpiši();
            Napis.Koliko();
            Napis.Koliko();
            Napis.štIzvodov = 5;

            Console.ReadLine();
        }
    }
}
