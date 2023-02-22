using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class DelavecNaUro:DelavecAbs
    {
        int štUr;
        double urnaPostavka;

        public int ŠtUr { get => štUr; set => štUr = value; }
        public double UrnaPostavka { get => urnaPostavka; set => urnaPostavka = value; }

        public override double BrutoPlača
        {
            get { return urnaPostavka * štUr; }
        }
        public override void Izpis()
        {
            Console.WriteLine("***********DELAVEC************");
            Console.WriteLine("ID    " + delID);
            Console.WriteLine("Ime   " + ime);
            Console.WriteLine("Urna postavka " + urnaPostavka);
            Console.WriteLine("Število ur    " + štUr);
            Console.WriteLine("Bruto plača   " + BrutoPlača);
            Console.WriteLine("*****************************");
        }
    }
}
