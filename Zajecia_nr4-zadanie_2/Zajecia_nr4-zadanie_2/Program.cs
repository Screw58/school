using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr4_zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ROZMIAR = 15;

            int[] tablica = new int[ROZMIAR] { 234, 24, 12, 45, 523, 5, 31, 643, 75, 7, 52, 1622, 45, 1, 637 };

            int LeastVal, BiggestVal;

            LeastVal = BiggestVal = tablica[0];

            for(int i = 1; i < ROZMIAR; i++) 
            {
                if(LeastVal < tablica[i])
                {
                    LeastVal = tablica[i]; 
                }

                if(BiggestVal > tablica[i])
                {
                    BiggestVal = tablica[i];
                }
            }
            Console.WriteLine($"Największa wartość tablicy: {BiggestVal} oraz najmniejsza wartość tablicy: {LeastVal}.");

            Console.ReadLine();

        }
    }
}
