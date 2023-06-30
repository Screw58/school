using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr6_zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            for (int Row = 0; Row < 10; Row++)
            {
                if (Row % 2 == 0)
                {
                    for (int Column = 0; Column < 10; Column++)
                    {
                        array[Row, Column] = Row * 10 + Column + 1;
                    }
                }
                else
                {
                    for (int Column = 0; Column < 10; Column++)
                    {
                        array[Row, Column] = (Row + 1) * 10 - Column;
                    }
                }
            }
            for (int Row = 0; Row < 10; Row++)
            {
                for (int Column = 0; Column < 10; Column++)
                {
                    Console.Write(array[Row, Column] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
