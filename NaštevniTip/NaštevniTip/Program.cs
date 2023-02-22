using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaštevniTip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi tip klica 1- mobilno,2-stacionarno");
            TipKlica tip = (TipKlica)int.Parse(Console.ReadLine());
            //na enak način vnesi minue
            Console.WriteLine("Vnesi število minut");
            int minute = int.Parse(Console.ReadLine());

            double z = 0;
            if (tip == TipKlica.KlicVMobilno)
            {
                z = minute * 0.03;
            }
            else
            {
                z = minute * 0.2;
            }
            Console.WriteLine("Dolguješ "+z);
            Console.ReadLine();
        }
    }
}
