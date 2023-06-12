using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr3_zadanie_4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration and init
            uint liczba_msc = 0;
            double kwota_poczatkowa, oprocentowanie_rok, oprocentowanie_msc, suma, zysk;
            double podatekBelki = 0.19;    
            kwota_poczatkowa = oprocentowanie_rok = oprocentowanie_msc  = 0;

            //get data from user
            Console.WriteLine("Podaj kwotę początkową: ");
            kwota_poczatkowa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj oprocentowanie konta w skali roku: ");
            oprocentowanie_rok = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę miesięcy oszczędzania: ");
            liczba_msc = uint.Parse(Console.ReadLine());

            //calculation
            oprocentowanie_msc = oprocentowanie_rok / 12;
            suma = kwota_poczatkowa * (1 + oprocentowanie_msc / 100)* liczba_msc;
            zysk = suma - (kwota_poczatkowa * liczba_msc);

            //print output
            Console.WriteLine($"Po {liczba_msc} miesiącach twój zysk wynosi: {zysk} zł , a po odjęciu podatku Belki (19%) wynosi: " + (zysk - (zysk* podatekBelki)));

            Console.ReadLine();



        }
    }
}
