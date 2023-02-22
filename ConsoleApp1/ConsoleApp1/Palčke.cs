using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Palčke
    {
        int štPalčk;
        int igralec;

        public Palčke()
        {
            štPalčk = 7;
            igralec = 1;
        }

        public bool VzemiPalčke(int n)
        {
            if (n < 1 | n > 3)
                return false;
            štPalčk = štPalčk - n;
            igralec=3-igralec;
            return true;
        }

        public bool KonecIgre()
        {
            return (štPalčk <= 0);
        }

        public int DobiZmagovalca()
        {
            return igralec;
        }

        public void Izpis()
        {
            Console.WriteLine();
            Console.WriteLine("Na mizi je " + štPalčk + " palčk.");
            Console.WriteLine("Na vrsti je igralec " + igralec + ".");
        }
    }
}
