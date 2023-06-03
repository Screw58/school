using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables declaration
            double personHeight = 0;
            double personWeight = 0;

            //get data from user
            Console.Write("Podaj wzrost (metry): ");
            personHeight = Double.Parse(Console.ReadLine());
            Console.Write("Podaj wagę (kilogramy): ");
            personWeight = Double.Parse(Console.ReadLine());

            //print output 
            Console.WriteLine("Twoje BMI wynosi: "+ ( personWeight / (personHeight * personHeight)) );
            Console.ReadLine();
        }
    }
}
