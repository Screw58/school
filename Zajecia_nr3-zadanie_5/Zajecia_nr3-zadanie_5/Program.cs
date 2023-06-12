using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr3_zadanie_5
{
    internal class Program
    {
           static void Main(string[] args)
           {
               int x = 0;
               int n = 0;
               double suma = 0;
               Console.Write("Podaj potęge x: ");
               x = int.Parse(Console.ReadLine());
               Console.Write("Podaj n: ");
               n = int.Parse(Console.ReadLine());

               for (int i = 0; i <= n; i++)
               {
                   suma += Math.Pow(x, i) / WartoscSilni(i);
               }
               Console.WriteLine("Wartość funkcji e do potęgi x wynosi: " + suma);
               Console.ReadLine();
           }

           public static int WartoscSilni(int PodstSilni)
           {
               int silnia = 1;
               for (int i = 1; i <= PodstSilni; i++)
               {
                   silnia *= i;
               }
               return silnia;
           }

    }
}
