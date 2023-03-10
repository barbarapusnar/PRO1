using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozniPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto a = new Avto();
            a.ŠtVrat = 5;
            a.Barva = "rdeča";
            a.Proizvajalec = "Alfa romeo";
            a.Model = "Đulijeta";
            a.Leto = 2023;
            Console.WriteLine("Avto*****");
            Console.WriteLine("Proizvajelc " + a.Proizvajalec);
            Console.WriteLine("Model       "+a.Model);
            Console.WriteLine("Leto        "+a.Leto);
            Console.WriteLine("Za 30 km porabiš "+a.Drive(30)+" litrov.");
            Console.ReadLine();
        }
    }
}
