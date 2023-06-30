using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Zajecia_nr8_zadanie_3
{

    enum Rzadkosc_t
    {
        Powszechny,
        Rzadki,
        Unikalny,
        Epicki
    }

    enum TypPrzedmiotu_t
    {
        Bron,
        Zbroja,
        Amulet,
        Pierscien,
        Helm,
        Tarcza,
        Buty
    }

    struct Przedmiot_t
    {
        public double Waga;
        public int Wartosc;
        public Rzadkosc_t Rzadkosc;
        public TypPrzedmiotu_t Typ;
        public string Nazwa;

        public void WypelnijPrzedmiot(double waga, int wartosc, Rzadkosc_t rzadkosc, TypPrzedmiotu_t typ, string nazwa)
        {
            Waga = waga;
            Wartosc = wartosc;
            Rzadkosc = rzadkosc;
            Typ = typ;
            Nazwa = nazwa;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Przedmiot: " + Nazwa);
            Console.WriteLine("Typ: " + Typ);
            Console.WriteLine("Rzadkosc: " + Rzadkosc);
            Console.WriteLine("Waga: " + Waga);
            Console.WriteLine("Wartosc: " + Wartosc + " sztuk złota");
        }
    }

    class Program
    {
        static Przedmiot_t LosujPrzedmiot(Przedmiot_t[] przedmioty)
        {
            Random random = new Random();
            Rzadkosc_t[] rzadkosci = { Rzadkosc_t.Powszechny, Rzadkosc_t.Rzadki, Rzadkosc_t.Unikalny, Rzadkosc_t.Epicki };
            double[] szanse = { 0.6, 0.3, 0.08, 0.02 }; // Przykładowe szanse na wylosowanie rzadkości

            double los = random.NextDouble();
            double sumaSzanse = 0.0;

            for (int i = 0; i < szanse.Length; i++)
            {
                sumaSzanse += szanse[i];

                if (los < sumaSzanse)
                {
                    Rzadkosc_t wylosowanaRzadkosc = rzadkosci[i];
                    Przedmiot_t[] dostepnePrzedmioty = Array.FindAll(przedmioty, p => p.Rzadkosc == wylosowanaRzadkosc);
                    int index = random.Next(dostepnePrzedmioty.Length);
                    return dostepnePrzedmioty[index];
                }
            }

            return przedmioty[random.Next(przedmioty.Length)];
        }

        static void Main(string[] args)
        {
            Przedmiot_t[] przedmioty = new Przedmiot_t[8];
            przedmioty[0].WypelnijPrzedmiot(2.5, 10, Rzadkosc_t.Powszechny, TypPrzedmiotu_t.Bron, "Miecz");
            przedmioty[1].WypelnijPrzedmiot(1.0, 20, Rzadkosc_t.Rzadki, TypPrzedmiotu_t.Zbroja, "Pancerz");
            przedmioty[2].WypelnijPrzedmiot(0.5, 50, Rzadkosc_t.Unikalny, TypPrzedmiotu_t.Amulet, "Amulet Mocy");
            przedmioty[3].WypelnijPrzedmiot(0.2, 100, Rzadkosc_t.Epicki, TypPrzedmiotu_t.Pierscien, "Pierscien Nieskonczonosci");
            przedmioty[4].WypelnijPrzedmiot(1.5, 15, Rzadkosc_t.Powszechny, TypPrzedmiotu_t.Helm, "Helm Rycerza");
            przedmioty[5].WypelnijPrzedmiot(0.8, 25, Rzadkosc_t.Rzadki, TypPrzedmiotu_t.Tarcza, "Tarcza Odpornosci");
            przedmioty[6].WypelnijPrzedmiot(1.2, 35, Rzadkosc_t.Unikalny, TypPrzedmiotu_t.Buty, "Buty Zwinności");
            przedmioty[7].WypelnijPrzedmiot(0.3, 80, Rzadkosc_t.Epicki, TypPrzedmiotu_t.Amulet, "Amulet Życia");

            Przedmiot_t losowyPrzedmiot = LosujPrzedmiot(przedmioty);
            Console.WriteLine("Wylosowany przedmiot:");
            losowyPrzedmiot.WyswietlInformacje();

            Console.ReadKey();
        }
    }
}