using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaIzpis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 5678;
            Console.WriteLine("a="   +  a  +" b="+b);
            //formatiranje izpisa
            Console.WriteLine("a={0} b={1}",a,b);
            Console.WriteLine("a={0,6} b={1,6}", a, b);
            Console.WriteLine("a={0,6:d} b={1,6:d}", a, b);
            Console.WriteLine("a={0,6:x} b={1,6:x}", a, b);
            double r = 12345.6789;
            Console.WriteLine("r={0,10:f2}\nr={0,10:e2}", r,r);
            //Console.WriteLine("r={0,10:e2}", r);
            Console.WriteLine("r={0,10:g2}", r);
            Console.WriteLine("r={0,10:n3}", r);
            double p = 0.25;
            Console.WriteLine("{0,10:p2}", p);
            Console.ReadLine();

        }
    }
}
