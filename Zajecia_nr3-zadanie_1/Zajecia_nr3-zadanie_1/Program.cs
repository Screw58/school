using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr3_zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint podstawa, wykladnik, suma;
            podstawa = wykladnik  = 0;
            suma = 1;

            Console.WriteLine("***Program potegujący liczby naturalne***\n");
            Console.WriteLine("Podaj podstawę: ");
            podstawa = uint.Parse(Console.ReadLine());
            Console.WriteLine("A teraz podaj wykladnik: ");
            wykladnik = uint.Parse(Console.ReadLine());

            for(int i = 0; i < wykladnik; i++)
            {
                suma *= podstawa;
            }

            Console.WriteLine($"{podstawa} do potęgi {wykladnik} = {suma} ");

            Console.ReadLine();
        }
    }
}

