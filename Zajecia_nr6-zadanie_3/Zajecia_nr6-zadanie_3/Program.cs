using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr6_zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1:");
            Exercise1();
            Console.WriteLine("Zadanie 2:");
            Exercise2();
        }
        static void Exercise1()
        {
            Console.Write("Podaj rozmiar tablicy (liczba wierszy i kolumn): ");
            uint RowsAndColumnsQuantity;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out RowsAndColumnsQuantity) && RowsAndColumnsQuantity >= 1)
                    break;

                Console.Write("Niepoprawny rozmiar tablicy. Podaj liczbę naturalną większą od 0: ");
            }
            int[,] array = new int[RowsAndColumnsQuantity, RowsAndColumnsQuantity];
            for (int Row = 0; Row < RowsAndColumnsQuantity; Row++)
            {
                if (Row % 2 == 0)
                {
                    for (int Column = 0; Column < RowsAndColumnsQuantity; Column++)
                    {
                        array[Row, Column] = Row * (int)RowsAndColumnsQuantity + Column + 1;
                    }
                }
                else
                {
                    for (int Column = 0; Column < RowsAndColumnsQuantity; Column++)
                    {
                        array[Row, Column] = (Row + 1) * (int)RowsAndColumnsQuantity - Column;
                    }
                }
            }
            for (int Row = 0; Row < RowsAndColumnsQuantity; Row++)
            {
                for (int Column = 0; Column < RowsAndColumnsQuantity; Column++)
                {
                    Console.Write(array[Row, Column] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Exercise2()
        {
            Console.Write("Podaj rozmiar tablicy (liczba wierszy i kolumn): ");
            uint RowsAndColumnsQuantity;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out RowsAndColumnsQuantity) && RowsAndColumnsQuantity >= 1)
                    break;

                Console.Write("Niepoprawny rozmiar tablicy. Podaj liczbę naturalną większą od 0: ");
            }
            int[,] array = new int[RowsAndColumnsQuantity, RowsAndColumnsQuantity];
            int number = 1;
            int Row = 0;
            int Column = 0;
            string direction = "right";
            while (number <= RowsAndColumnsQuantity * RowsAndColumnsQuantity)
            {
                array[Row, Column] = number;
                switch (direction)
                {
                    case "right":
                        Column++;
                        if (Column == RowsAndColumnsQuantity || array[Row, Column] != 0)
                        {
                            Column--;
                            Row++;
                            direction = "down";
                        }
                        break;
                    case "down":
                        Row++;
                        if (Row == RowsAndColumnsQuantity || array[Row, Column] != 0)
                        {
                            Row--;
                            Column--;
                            direction = "left";
                        }
                        break;
                    case "left":
                        Column--;
                        if (Column == -1 || array[Row, Column] != 0)
                        {
                            Column++;
                            Row--;
                            direction = "up";
                        }
                        break;
                    case "up":
                        Row--;
                        if (Row == -1 || array[Row, Column] != 0)
                        {
                            Row++;
                            Column++;
                            direction = "right";
                        }
                        break;
                }
                number++;
            }
            for (Row = 0; Row < array.GetLength(0); Row++)
            {
                for (Column = 0; Column < array.GetLength(1); Column++)
                {
                    Console.Write(array[Row, Column] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    
}
