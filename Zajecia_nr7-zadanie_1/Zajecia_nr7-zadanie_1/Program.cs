using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr7_zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowTime(332);

            Console.ReadLine();
        }

        static void ShowTime(int time)
        {
            int hours, mins, secs;
            hours = mins = secs = 0;

            hours = time / 3600;
            mins = (time % 3600) / 60;
            secs = time % 60;

            Console.Write($"{hours:D2}:{mins:D2}:{secs:D2}");
        }
    }
}
