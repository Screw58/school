using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_nr8_zadanie_4
{

        public enum Sex_t
        {
            Kobieta,
            Mezczyzna
        }

        public struct Student
        {
            public string surname;
            public int albumID;
            public double mark;
            public Sex_t sex;
        }

        public class Program
        {
            public static void FillInStudent(ref Student student, string nazwisko, int nrAlbumu, double ocena, Sex_t plec)
            {
                student.surname = nazwisko;
                student.albumID = nrAlbumu;
                student.mark = Math.Max(2.0, Math.Min(5.0, ocena));
                student.sex = plec;
            }


            public static void ShowStudent(Student student)
            {
                string plecStr = student.sex == Sex_t.Mezczyzna ? "Mężczyzna" : "Kobieta";
                Console.WriteLine($"Nazwisko: {student.surname}, Nr albumu: {student.albumID}, Ocena: {student.mark}, Płeć: {plecStr}");
            }


            public static double CalculateAverage(Student[] grupaStudentow)
            {
                double sumaOcen = 0;
                foreach (var student in grupaStudentow)
                {
                    sumaOcen += student.mark;
                }

                return sumaOcen / grupaStudentow.Length;
            }

            public static void Main(string[] args)
            {

                Student[] grupaStudentow = new Student[5];


                FillInStudent(ref grupaStudentow[0], "Czerwiński", 12345, 4.5, Sex_t.Mezczyzna);
                FillInStudent(ref grupaStudentow[1], "Baron", 23456, 3.8, Sex_t.Kobieta);
                FillInStudent(ref grupaStudentow[2], "Belok", 34567, 5.5, Sex_t.Mezczyzna);
                FillInStudent(ref grupaStudentow[3], "Lewandowska", 45678, 1.5, Sex_t.Kobieta);
                FillInStudent(ref grupaStudentow[4], "Wencel", 56789, 4.0, Sex_t.Mezczyzna);


                foreach (var student in grupaStudentow)
                {
                    ShowStudent(student);
                }


                double srednia = CalculateAverage(grupaStudentow);
                Console.WriteLine($"Średnia ocen: {srednia}");
                Console.ReadLine();
            }
        }
    
    
}
