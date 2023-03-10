using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozniPark
{
    internal class Avto:Vozilo,IDrivable
    {
        // Avtomobili imajo več vrat in prostornino prtljažnika.
        int štVrat;
        int velikostPrtljažnika;

        public int ŠtVrat { get => štVrat; set => štVrat = value; }
        public int VelikostPrtljažnika { get => velikostPrtljažnika; set => velikostPrtljažnika = value; }

        public double Drive(int štKilometrov)
        {
            //na primer, da avto porabi 6 litrov na 100 km
            return štKilometrov * 6 / 100.0;
        }
    }
}
