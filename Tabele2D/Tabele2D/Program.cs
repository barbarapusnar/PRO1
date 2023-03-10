using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabele2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] a = {
            //{82,91,73 },
            //{80,65,88 },
            //{64,56,33 },
            //{80,85,81 }
            //};
            ////izpis
            //for (int vrstica = 0; vrstica < 4; vrstica++)
            //{
            //    for (int stolpec = 0; stolpec < 3; stolpec++)
            //    {
            //        Console.Write(a[vrstica,stolpec]+"\t");
            //    }//po vsaki izpisani vrstici, pojdi v novo
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            Napis x = new Napis("C#");
            x.Izpis();
            Napis[] tabela = new Napis[2];
            //tabela[0] = new Napis("C#");
            //tabela[1] = new Napis("Java");
            for (int k = 0; k < tabela.Length; k++)
            {
                Console.WriteLine("Vnesi tvoj jezik");
                string odg = Console.ReadLine();
                tabela[k] = new Napis(odg);
            }
            for (int k = 0; k < tabela.Length; k++)
            {
                tabela[k].Izpis();
            }
            Console.ReadLine();
        }
    }
}
