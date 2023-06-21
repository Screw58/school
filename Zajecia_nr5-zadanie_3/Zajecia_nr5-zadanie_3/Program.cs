using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr5_zadanie_3
{
    internal class Program
    {
        static uint minColumnIndexToWritePlus;
        static uint maxColumnIndexToWritePlus;
        static void Main(string[] args)
        {
            uint amountRows;
            uint amountColumns = 1;
            Console.Write("Podaj liczbę wierszy: ");
            amountRows = uint.Parse(Console.ReadLine());

            for (int i = 2; i <= amountRows; i++)
            {
                amountColumns += 2;
            }
            minColumnIndexToWritePlus = amountColumns / 2;
            maxColumnIndexToWritePlus = amountColumns / 2;
            for (int i = 0; i < amountRows; i++)
            {
                for (int j = 0; j < amountColumns; j++)
                {
                    WriteRowColumn(j);
                }
                minColumnIndexToWritePlus--;
                maxColumnIndexToWritePlus++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void WriteRowColumn(int currentColumn)
        {
            if (currentColumn >= minColumnIndexToWritePlus && currentColumn <= maxColumnIndexToWritePlus)
            {
                Console.Write("+ ");
            }
            else
            {
                Console.Write("  ");
            }
        }
       
    }
}
