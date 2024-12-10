using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public string Navn;
        string Alder;
        string Studieprogram;
        string StudentID;

        public List<Fag> _fag = new List<Fag>();
        public int _karakter;


        public Student(string navn, string alder, string studieprogram, string studentID, List<Fag> fag)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentID;
            _fag = fag;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine(
                $"--- Student Info ---\n" +
                $"Navn: {Navn}\n" +
                $"Alder: {Alder}\n" +
                $"Studieprogram: {Studieprogram}\n" +
                $"StudentID: {StudentID}\n");
        }

    }
}
