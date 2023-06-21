using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr4_zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[] { 13, 5, 2, 62, 24, 19, 94, 52, 78, 37 };
            Console.WriteLine("Tablica w początkowym stanie: ");
            for(int i =0; i< tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            //sortowanie
            for(int e = 0; e < tablica.Length; e++ )
            {
                int prevItem = tablica[0];
                for( int i = 1; i < tablica.Length; i++ ) 
                {
                    if(tablica[i] < prevItem)
                    {
                        tablica[i - 1] = tablica[i];
                        tablica[i] = prevItem;
                    }
                    prevItem = tablica[i];
                }
            }

            //wyswietlenie wyniku
            Console.WriteLine("\nTablica po posortowaniu: ");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
