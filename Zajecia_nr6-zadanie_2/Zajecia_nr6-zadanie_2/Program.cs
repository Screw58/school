using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr6_zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int number = 1;
            int row = 0;
            int column = 0;
            string direction = "right";
            while (number <= 100)
            {
                array[row, column] = number;
                switch (direction)
                {
                    case "right":
                        column++;
                        if (column == 10 || array[row, column] != 0)
                        {
                            column--;
                            row++;
                            direction = "down";
                        }
                        break;
                    case "down":
                        row++;
                        if (row == 10 || array[row, column] != 0)
                        {
                            row--;
                            column--;
                            direction = "left";
                        }
                        break;
                    case "left":
                        column--;
                        if (column == -1 || array[row, column] != 0)
                        {
                            column++;
                            row--;
                            direction = "up";
                        }
                        break;
                    case "up":
                        row--;
                        if (row == -1 || array[row, column] != 0)
                        {
                            row++;
                            column++;
                            direction = "right";
                        }
                        break;
                }
                number++;
            }
            for (row = 0; row < array.GetLength(0); row++)
            {
                for (column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
