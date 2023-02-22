using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class LDelavec:Delavec
    {
        double letnaPlača;

        public double LetnaPlača { get => letnaPlača; set => letnaPlača = value; }
        public new double BrutoPlača
        {
            get
            { return letnaPlača/12; }
        }
        public new void Izpis()
        {
            Console.WriteLine("***********DELAVEC************");
            Console.WriteLine("ID    " + delID);
            Console.WriteLine("Ime   " + ime);
            Console.WriteLine("Letna plača   "+letnaPlača);
            Console.WriteLine("Bruto plača   " + BrutoPlača);
            Console.WriteLine("*****************************");
        }
        //public LDelavec()
        //{
        //    Console.WriteLine("Sem v konstruktorju LDelavec");
        //}
    }
}
