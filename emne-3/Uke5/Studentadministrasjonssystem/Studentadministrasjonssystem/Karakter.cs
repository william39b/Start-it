using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Karakter
    {
        public Student Student { get; private set; }
        public Fag Fag { get; private set; }
        public double Karakterverdi { get; private set; }

        public Karakter(Fag fag, double karakterverdi)
        {
            Fag = fag;
            Karakterverdi = karakterverdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine(
                $"--- Karakter Info ---\n" +
                //$"Student: {Student.Navn}\n" +
                $"Fag: {Fag.Fagnavn}\n" +
                $"Karakterverdi: {Karakterverdi}\n");
        }
    }
}
