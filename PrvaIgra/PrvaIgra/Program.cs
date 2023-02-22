using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaIgra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.1.Izberi začetno število palčk
            Palčke p = new Palčke(13,2);
            //2.2.Dokler ni konec igre, ponavljaj
            while (!p.JeKonec())
            {
                //2.2.1.poročaj o stanju(število palčk na mizi,
                //kateri igralec je na vrsti)
                Console.WriteLine(p.IzpisStanja1());
                //2.2.2.naredi naslednjo potezo
                Console.WriteLine("Koliko palčk vzameš?");
                int x=int.Parse(Console.ReadLine());
                p.VzemiPalčke(x);
            }
            //2.3.poročaj o zmagovalcu
            Console.WriteLine("Zmagal je igralec "+p.DobiZmagovalca());
            
            Console.ReadLine();
        }
    }
}
