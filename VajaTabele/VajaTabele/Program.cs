using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace VajaTabele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napišite program, v katerem imate deklarirano dvodimenzionalno
            //            //tabelo c, ki
            //vsebuje 5X5 malih črk.Tabelo napolnite z naključnimi malimi črkami. Izpišite
            //jo v obliki 5 vrstic in 5 stolpcev.Poiščite črko v tabeli, ki je po abecedi
            //najmanjša.Upoštevajte, da je ASCII koda 'a' = 97.
            char[,] c = new char[5, 5];
            Random r = new Random();
            //generiraj naključne črke
            for (int k = 0; k < c.GetLength(0); k++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[k, j] = (char)(r.Next(26) + 'a');
                }
            }
            //izpiši v obliki 5 vrstic in 5 stolpcev
            for (int k = 0; k < 5; k++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(c[k, j] + " ");
                }
                Console.WriteLine();
            }
            //poišči najmanšo črko
            char min = 'z';
            for (int k = 0; k < 5; k++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (c[k, j] < min)
                        min = c[k, j];
                }
            }
            Console.WriteLine("Po abecedi je prva " + min);
            Console.ReadLine();
        }
    }
}
