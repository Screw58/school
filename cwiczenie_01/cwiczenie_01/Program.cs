using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration variables
            double val1, val2, val3;

            //initialize variables to 0
            val1 = val2 = val3 = 0;

            //read values from user
            Console.Write("Podaj pierwszą liczbe: ");
            val1 = Double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbe: ");
            val2 = Double.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbe: ");
            val3 = Double.Parse(Console.ReadLine());

            //print arithmetic average
            Console.Write("Średnia arytmetyczna trzech liczb wynosi: " + (val1 + val2 + val3) / 3);

            Console.ReadLine();
        }
    }
}
