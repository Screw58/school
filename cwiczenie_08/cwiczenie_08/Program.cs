using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double value1;
            double value2;
            byte mathType;

            Console.Write("*****PROSTY KALKULATOR 4-DZIAŁANIOWY*****\n");
            Console.Write("*---------------------------------------*\n");
            Console.Write("* Wybierz typ działania:                *\n");
            Console.Write("* 1-dodawanie              3- mnożenie  *\n");
            Console.Write("* 2-odejmowanie            4- dzielenie *\n");
            Console.Write("*---------------------------------------*\n");
            Console.Write("*Twój wybór: ");

            mathType = byte.Parse(Console.ReadLine());

            if ( (mathType >= 1 ) && (mathType <= 4) )
            {
                Console.Write("Podaj pierwszą liczbę: ");
                value1 = double.Parse(Console.ReadLine());
                Console.Write("A teraz podaj drugą liczbę: ");
                value2 = double.Parse(Console.ReadLine());

                switch (mathType)
                {
                    case 1: Console.Write($"Suma liczb wynosi: {value1 + value2}");
                            break;
                    case 2: Console.Write($"Różnica liczb wynosi: {value1 - value2}");
                            break;
                    case 3: Console.Write($"Iloczyn liczb wynosi: {value1 * value2}");
                            break;
                    case 4:
                        if (value2 != 0)
                        {
                            Console.Write($"Iloraz liczb wynosi: {value1 / value2}");
                        }
                        else
                        {
                            Console.Write($"Wynik dla {value1} i {value2} to {value1}/{value2}");
                        }
                        break;
                }
            }
            else
            {
                Console.Write("Nie ma takiego typu działania!\nWybierz poprawny typ!");
            }

            Console.ReadLine();
        }
    }
}
