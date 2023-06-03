using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables init 
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int x = 0;
            int y = 0;


            Console.Write("Program liczący x/y wg podanego wzoru: x/y = a/b + c/d\n");

            //get data from user
            Console.Write("Podaj liczbę całkowitą a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę całkowitą b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę całkowitą c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę całkowitą d: ");
            d = int.Parse(Console.ReadLine());

            //check if b and d are different to 0
            if (b == 0 || d == 0)
            {
                Console.WriteLine("Brak rozwiązania!");
            }
            else
            {
                x = a * d + b * c;
                y = b * d;

                Console.WriteLine("Licznik x: " + x);
                Console.WriteLine("Mianownik y: " + y);
            }

            Console.ReadLine();
        }
    }
}
