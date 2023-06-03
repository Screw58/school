using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables declaration
            double radius = 0;
            double CircleField = 0;

            //get data from user
            Console.Write("Program obliczający obwód koła na pdostawie jego pola.\n");
            Console.Write("Podaj pole koła: ");
            CircleField = Double.Parse(Console.ReadLine());

            //calculation
            radius = Math.Sqrt(CircleField / Math.PI);

            //Print the result
            Console.Write("Obwód koła wynosi: " + 2 * radius * Math.PI);
            Console.ReadLine();
        }
    }
}
