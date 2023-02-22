using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeZanke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double člen = 1;
            double vsota = 1;
            Console.WriteLine("Vnesi vrednost x");
            double x = double.Parse(Console.ReadLine());
            //ponavljaj 100x
            //for (int k = 1; k <= 100; k++)
            int k = 1;
            while (Math.Abs(vsota-Math.Exp(x))>0.000001)
            {
                člen = člen * x / k;
                vsota = vsota + člen;
                k++;
            }
            Console.WriteLine("Vsota je   "+vsota);
            Console.WriteLine("e na x je  " + Math.Exp(x));
            Console.ReadLine();
        }
    }
}
