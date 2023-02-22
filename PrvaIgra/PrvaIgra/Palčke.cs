using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaIgra
{
    internal class Palčke
    {
        int štPalčk;//koliko je trenutno palčk na mizi
        int igralec;//1 ali 2 - kdo je na vrsti

        public int ŠtPalčk { get => štPalčk;  }
        public int Igralec { get => igralec;  }
        public Palčke()
        {
            igralec = 1;
            štPalčk = 11;
        }
        public Palčke(int š)
        {
            štPalčk = š;
            igralec = 1;
        }
        public Palčke(int š,int i)
        {
            štPalčk = š;
            igralec = i;
        }
        public void IzpisStanja()
        {
            Console.WriteLine("Na mizi je "+štPalčk+" palčk");
            Console.WriteLine("Na vrsti je "+igralec);
        }
        public string IzpisStanja1()
        {
            string r = "";
            r=r+"Na mizi je " + štPalčk + " palčk";
            r=r+"\nNa vrsti je " + igralec;
            return r;
        }
        //vzemi n palčk iz mize in zamenja igralca
        public void VzemiPalčke(int n)
        {
            if (n < 1 || n > 3)
            {
                Console.WriteLine("Ne slepari");
                return;
            }
            štPalčk = štPalčk - n;
            igralec = 3 - igralec;
        }
        public bool JeKonec()
        {
            return štPalčk <= 0;

        }
        public int DobiZmagovalca()
        {
            return igralec;
        }
    }
}
