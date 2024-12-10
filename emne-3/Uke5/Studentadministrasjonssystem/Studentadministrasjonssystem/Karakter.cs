using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Karakter
    {
        public Student _student;
        public Fag _fag;
        string _karakterverdi;

        public Karakter(Student student, Fag fag, string karakterverdi)
        {
            _student = student;
            _fag = fag;
            _karakterverdi = karakterverdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine(
                $"--- Karakter Info ---\n" +
                $"Student: {_student.Navn}\n" +
                $"Fag: {_fag.Fagnavn}\n" +
                $"Karakterverdi: {_karakterverdi}\n");
        }
    }
}
