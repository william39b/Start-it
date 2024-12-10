using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Fag
    {
        string Fagkode;
        public string Fagnavn;
        string AntallStudiepoeng;

        public Fag(string fagkode, string fagnavn, string antallStudiepoeng)
        {
            Fagkode = fagkode;
            Fagnavn = fagnavn;
            AntallStudiepoeng = antallStudiepoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine(
                $"--- Fag Info ---\n" +
                $"Fagkode: {Fagkode}\n" +
                $"Fagnavn: {Fagnavn}\n" +
                $"AntallStudiepoeng: {AntallStudiepoeng}\n");
        }
    }
}
