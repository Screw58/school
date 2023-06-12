using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr3_zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, k;
            n = k = 0;

            double nSilnia, kSilnia;
            nSilnia = kSilnia = 1;

            Console.WriteLine("Podaj liczbę n: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę k: ");
            k = double.Parse(Console.ReadLine());

           while( k < 5)
           {
                Console.WriteLine("Podana liczba k musi być większa od 5!\nPodaj poprawną liczbę k: ");
                k = double.Parse(Console.ReadLine());
            }
           while (n < 5)
           {
                Console.WriteLine("Podana liczba n musi być większa od 5!\nPodaj poprawną liczbę n: ");
                n = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Podano poprawne liczby!");

            for (double i = 1; i <= k; i++)
            {
                kSilnia *= i;
            }
            for (double i =1;  i <= n; i++) 
            {
                nSilnia *= i;
            }

            Console.WriteLine("Liczba m wynosi: " + ((nSilnia-kSilnia)/kSilnia) );

            Console.ReadLine();

        }
    }
}
