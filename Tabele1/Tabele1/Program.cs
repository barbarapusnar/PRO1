using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabele1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] t1 = { 1, 2, 3, 4, 5, 6 };
            int[] t2 = new int[6];
            for (int k = 0; k < 6; k++)
            {
                t2[k] = t1[k];
            }
        
            t2[0] = 75;
            for (int k = 0; k < 6; k++)
            {
                Console.Write(t1[k]+"\t");
            }
            Console.ReadLine();
        }
    }
}
