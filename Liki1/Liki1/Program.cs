using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik p = new Pravokotnik(0, 1, 1, 0);
            Console.WriteLine("Koordinati kota levo zgoraj = " + p.X1 + "," + p.Y1 +
            "\nKoordinati kota desno spodaj = " + p.X2 + "," + p.Y2);
            Console.WriteLine("Stranica a " + p.StranicaA());
            Console.WriteLine("Stranica b " + p.StranicaB());
            Console.WriteLine("Ploščina " + p.Ploščina());

            Kvader kv = new Kvader(0, 1, 1, 0, 1);
            Console.WriteLine("Prostornina kvadra je "+kv.Prostornina());
            Console.WriteLine("Površina kvadra je    "+kv.Površina());

            Console.ReadLine();

        }
    }
}
