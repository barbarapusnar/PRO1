using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraljstvoŽivali
{
    internal class Žival
    {
        protected string opis;
        protected string ime;
        public void Oglašanje()
        {
            string glas = ((IGovor)this).Govor();
            Console.WriteLine("Sem "+opis+" "+ime+" "+glas);
        }
    }
}
