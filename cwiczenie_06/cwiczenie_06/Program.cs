using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables declaration
            double side1, side2, side3;

            //variables init
            side1 = side2 = side3 = 0;

            //print general info
            Console.Write("***Program sprawdzający czy można złożyć trójkąt równoboczny z podanych boków!***\n");

            //get data from user
            Console.Write("Podaj pierwszy bok: ");
            side1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugi bok: ");
            side2 = double.Parse(Console.ReadLine());
            Console.Write("Podaj trzeci bok: ");
            side3 = double.Parse(Console.ReadLine());

            //check possibility and print result
            if (side1 == side2 && side2 == side3)
            {
                Console.Write("Z podanych boków można złożyć trójkąt równoboczny!");
            }
            else
            {
                Console.Write("Boki nie mogą utworzyć trójkąta równobocznego.");
            }

            Console.ReadLine();
        }
    }
}
