using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables declaration 
            double val1, val2;

            //variables init
            val1 = val2 = 0;

            //get data from user
            Console.Write("***Program zwracający większą z dwóch wartości***\n");
            Console.Write("Podaj pierwszą wartość: ");
            val1 = Double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą wartość: ");
            val2 = Double.Parse(Console.ReadLine());

            //print results
            if(val1 > val2)
            {
                Console.Write("Pierwsza wartość jest większa.");
            }
            else if (val1 == val2)
            {
                Console.Write("Obie wartości są takie same!");
            }
            else
            {
                Console.Write("Druga wartość jest większa.");
            }

            Console.ReadLine();

        }
    }
}
