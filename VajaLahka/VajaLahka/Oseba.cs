using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaLahka
{
    internal class Oseba
    {
        string ime;
        int starost;

        public string Ime { get => ime; }
        public int Starost { get => starost; }

        public Oseba(string i,int s)
        {
            ime = i;starost = s;
        }
//        GetAgeInMonths: vrne starost osebe v mesecih.
        public int GetAgeInMonths()
        {
            return 12 * starost;
        }
        //IsAdult: vrne true, če je oseba odrasla(tj.starejša od 18 let),
        //sicer vrne false.
        public bool IsAdult()
        {
            if (starost < 18)
                return false;
            
            return true;
        }
        //IsEqual: vrne true, če je oseba enaka primerku druge osebe(tj.če sta njuno ime in starost
        //enaka), sicer vrne false.
        public bool IsEqual(Oseba x)
        {
            if (this.ime == x.ime && this.starost == x.starost)
                return true;
            return false;
        }
    }
}
