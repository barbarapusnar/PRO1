using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinolovecKonzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] mine = new bool[10 + 2, 10 + 2];
            //generiraj naključno mine s 25% verjetnostjo
            //igra bo v vrsticah od 1 do 10, zgoraj je vrstica 0, spodaj 11
            Random r=new Random();
            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    mine[k, j] = r.NextDouble() < 0.25;
                    if (mine[k, j]==true)
                        Console.Write("* ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
            //izračunaj rešitev
            int[,] rešitev = new int[10 + 2, 10 + 2];
            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    for (int x = k - 1; x <= k + 1; x++)
                    {
                        for (int y = j - 1; y <= j + 1; y++)
                        {
                            if (mine[x, y] == true)
                                rešitev[k, j]++;
                        }
                    }
                }
            }
            for (int k = 1; k <= 10; k++)
            {

                for (int j = 1; j <= 10; j++)
                { 
                if (mine[k,j]==true)
                        Console.Write("*");
                else
                        Console.Write(rešitev[k,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
