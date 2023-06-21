using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr4_zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[] { 41, 5, 12, 27, 32, 18, 29 }; 

            int n = tablica.Length;
            Console.WriteLine("Tablica w początkowym stanie: ");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            //sortowanie
            for (int i = 1; i < n; i++)
            {
                int keyVal = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > keyVal)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = keyVal;
            }
            Console.WriteLine("\nTablica po posortowaniu: ");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
