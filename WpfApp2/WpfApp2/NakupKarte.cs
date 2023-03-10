using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class NakupKarte
    {
        private string imeDogodka;
        public string ImeDogodka
        {
            get { return imeDogodka; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ApplicationException("Izbrati moraš dogodek");
                else
                    imeDogodka = value;
            }
        }

        private string štKupca;
        public string ŠtKupca
        {
            get { return štKupca; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ApplicationException("Zapiši kupca");
                else
                    štKupca = value;
            }
        }
    }
}
