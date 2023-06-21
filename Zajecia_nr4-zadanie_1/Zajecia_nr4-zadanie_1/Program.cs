using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr4_zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ROZMIAR = 20;
            int[] tablica = new int[ROZMIAR];

            Random random = new Random();
            Console.WriteLine("Tablica na początku ma wartości: ");
            //wypelnianie tablicy losowymi wartosciami
            for (int i =0; i < ROZMIAR; i++) 
            {
                tablica[i] = random.Next(0, 1000); //min = 0 , max = 1000
                Console.Write(tablica[i]+ " ");
            }

            Console.WriteLine("\nTablica po odwróceniu ma wartości: ");
            for (int i = ROZMIAR -1; i >= 0; i--)
            {
                Console.Write(tablica[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
