using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables declaration
            int x;
            int y;
            int r;

            //define const variables
            const int a = 0;      //value x of middle circle point
            const int b = 0;      //value y of middle circle point


            //get the data
            Console.Write("Podaj współrzędną X punktu P: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną Y punktu P: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Podaj promień koła: ");
            r = int.Parse(Console.ReadLine());

            //check if point P is in the circle field
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                Console.Write("Punkt leży w obrębie koła!");
            }
            else
            {
                Console.Write("Punkt leży poza obrębem koła!");
            }

            Console.ReadLine();
        }
    }
}
