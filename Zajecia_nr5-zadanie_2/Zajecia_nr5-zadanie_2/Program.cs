using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr5_zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wersja1();
            Wersja2();

        }

        static void Wersja1()
        {
            Console.Write("Wersja 1: ");

            Random random = new Random();
            int AmountOfEvenNumbers = 10;
            int DrawCounter = 0;
            Console.WriteLine("Podaj ilość liczb parzystych: ");
            AmountOfEvenNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < AmountOfEvenNumbers; i++)
            {
                int DrawedNumber;
                do
                {
                    DrawedNumber = random.Next(-8, 9);
                    DrawCounter++;
                } while (DrawedNumber % 2 != 0);

                Console.Write(DrawedNumber);

                if (i < AmountOfEvenNumbers - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Liczba wykonanych losowań: " + DrawCounter);

        }

        static void Wersja2()
        {
            Console.Write("\n------------------------\n");
            Console.Write("Wersja 2: ");
            int AmountOfEvenNumbers;

            Random random = new Random();
            Console.WriteLine("Podaj ilość liczb parzystych: ");
            AmountOfEvenNumbers = int.Parse(Console.ReadLine());

            int DrawCounter = 0; // Licznik losowań

            for (int i = 0; i < AmountOfEvenNumbers; i++)
            {
                int DrawedNumber = random.Next(-4, 5) * 2;
                DrawCounter++;

                Console.Write(DrawedNumber);

                if (i < AmountOfEvenNumbers - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Liczba wykonanych losowań: " + DrawCounter);

            Console.ReadLine();

        }
    }
}

