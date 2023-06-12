using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr3_zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 20;
            int szukana = 0;

            Console.WriteLine("Wybierz liczbę z przedziału od 1 do 20.");
            Console.WriteLine("Jeśli liczba jest mniejsza wpisz dowolną ujemną liczbe,");
            Console.WriteLine("jeśli jest większa to wpisz dodatnią,");
            Console.WriteLine("a jeśli zgadłem wpisz 0.");

            while (true)
            {
                szukana = (min + max) / 2;
                Console.WriteLine($"Czy Twoja liczba to {szukana}? (odpowiedz ujemną, dodatnią lub 0)");

                int odp = int.Parse(Console.ReadLine());

                if (odp < 0)
                {
                    max = szukana - 1;
                }
                else if (odp > 0)
                {
                    min = szukana + 1;
                }
                else
                {
                    Console.WriteLine($"Twoja liczba to {szukana}.");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
