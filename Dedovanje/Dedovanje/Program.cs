using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            LetniDelavec a = new LetniDelavec();
            a.DelID = "5678";
            a.Ime = "Miha Potrč";
            a.LetnaPlača = 12000;
            a.Izpis();
            //DelavecAbs x = new DelavecAbs();
            //DelavecAbs x = new DelavecNaUro
            a.Geslo();
            Console.ReadLine();
        }
    }
}
