using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr3_zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int x = int.Parse(Console.ReadLine());

            //int n = 0;
            int suma = 1;

            for(int n= 1; suma <= x; n++)
            {
                suma *= n;
                if (suma == x)
                {
                    Console.WriteLine($"Liczba {x} jest silnią liczby {n}.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine($"Liczba {x} nie jest silnią żadnej liczby.");

            Console.ReadLine();

        }
    }
}
