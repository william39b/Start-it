using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Fag
    {
        public string Fagkode { get; private set; } 
        public string Fagnavn {  get; private set; } 
        public int AntallStudiepoeng { get; private set; }

        public Fag(string fagkode, string fagnavn, int antallStudiepoeng)
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
