using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class LetniDelavec : DelavecAbs,IVarnost
    {
        double letnaPlača;
        public override double BrutoPlača
        { 
        get { return letnaPlača / 12; }
        }

        public double LetnaPlača { get => letnaPlača; set => letnaPlača = value; }

        public void Geslo()
        {
            Console.WriteLine("Preverjanje gesla");
        }

        public override void Izpis()
        {
            Console.WriteLine("***********DELAVEC************");
            Console.WriteLine("ID    " + delID);
            Console.WriteLine("Ime   " + ime);
            Console.WriteLine("Letna plača   " + letnaPlača);
            Console.WriteLine("Bruto plača   " + BrutoPlača);
            Console.WriteLine("*****************************");
        }

        public void UgotoviUporabnika()
        {
            Console.WriteLine("Vprašaj za up. ime");
        }

        public void ZapišiDogodek()
        {
            Console.WriteLine("Zapiši dogodek");
        }
    }
}
