using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public string Navn { get; private set; } 
        public string Alder { get; private set; } 
        public string Studieprogram { get; private set; }
        public int StudentID { get; private set; } 

        private List<Fag> FagList = new List<Fag>();
        private List<Karakter> KarakterListe = new List<Karakter>();

        public Student(string navn, string alder, string studieprogram, int studentID, List<Fag> fag, List<Karakter> karakterListe)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentID;
            FagList = fag;
            KarakterListe = karakterListe;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine(
                $"--- Student Info ---\n" +
                $"Navn: {Navn}\n" +
                $"Alder: {Alder}\n" +
                $"Studieprogram: {Studieprogram}\n" +
                $"StudentID: {StudentID}\n");
            SkrivUtKarakterInfo();
            Studiepoeng();
        }

        public void SkrivUtKarakterInfo()
        {
            Console.WriteLine("--- Karakterer ---");
            foreach (Karakter k in KarakterListe)
            {
                Console.WriteLine($"{k.Fag.Fagnavn}: {k.Karakterverdi}");
            }
            Gjennomsnittskarakter();
        }

        public void Gjennomsnittskarakter()
        {
            double sum = 0;
            foreach (Karakter k in KarakterListe)
            {
                sum += k.Karakterverdi;
            }
            double gjennomsnitt = sum / KarakterListe.Count;
            Console.WriteLine($"Gjennomsnittskarakter: {gjennomsnitt}");
        }

        public void Studiepoeng()
        {
            double sum = 0;
            foreach (Fag f in FagList)
            {
                sum += f.AntallStudiepoeng;
            }
            Console.WriteLine($"Totalt antall studiepoeng: {sum}");
        }

    }
}
