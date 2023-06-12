using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr3_zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint liczba = 0;
             uint a = 0;
             uint b = 1;

            Console.WriteLine("Podaj ile chcesz wypisać wyrazów ciągu Fibonacciego: ");
            liczba = uint.Parse(Console.ReadLine());

            for (int i = 0; i < liczba; i++)
            {
                Console.WriteLine(b + " ");
                b += a;
                a = b - a; 
            }

            Console.ReadLine();
        }
    }
}
