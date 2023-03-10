using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvropskoPrvenstvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NogometnaLiga n=new NogometnaLiga();
            //  n.IzpišiTurnir();
            n.ObdelajKolo(1);
            n.IzpisVseh();
            Console.ReadLine();
        }
    }
}
