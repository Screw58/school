using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr7_zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                {1,2,3,4,5 },
                { 6,7,8,9,0 },
                {10, 11, 12, 13, 14 },
                { 1, 3,3,4,5 } };

            FindMostSimilarRows(array, out int row1, out int row2);
            Console.WriteLine($"Najbardziej podobne wiersze: {row1} i {row2}");
            Console.ReadLine();
        }
        static void FindMostSimilarRows(int[,] array, out int row1, out int row2)
        {
            row1 = 0;
            row2 = 0;

            long LeastDifference = long.MaxValue;

            int RowsQuantity = array.GetLength(0);
            int ColumnQuantity = array.GetLength(1);


            for (int i = 0; i < RowsQuantity; i++)
            {
                for (int j = i + 1; j < RowsQuantity; j++)
                {
                    long Diff = CalculateDifference(array, i, j);
                    if (Diff < LeastDifference)
                    {
                        LeastDifference = Diff;
                        row1 = i;
                        row2 = j;
                    }
                }
            }
        }

        static long CalculateDifference(int[,] array, int i, int j)
        {
            int ColumnQuantity = array.GetLength(1);
            long Diff = 0;

            for (int kol = 0; kol < ColumnQuantity; kol++)
            {
                Diff += (long)Math.Pow(array[i, kol] - array[j, kol], 2);
            }
            return Diff;
        }

    }
}

