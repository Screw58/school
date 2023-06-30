using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr7_zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 3;
            double y1 = 1;
            double x2 = 5;
            double y2 = 6;

            double result = CalculateDistance(x1, y1, x2, y2);

            Console.WriteLine("Długość odcinka wynosi: "+result);
            Console.ReadLine();
        }
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double tmp;
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            tmp = deltaX * deltaX + deltaY * deltaY;
            double distance = Math.Sqrt(tmp);

            return distance;
        }
    }
}
