using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Main
    {
        public void Run()
        {
            var fag1 = new Fag("1", "matematikk", "90");
            var fag2 = new Fag("2", "Engels", "60");
            var fag3 = new Fag("3", "Norsk", "60");
            List<Fag> fag = new List<Fag>
            {
                fag1, fag2, fag3
            };

            Student student1 = new Student("Terje", "21", "program1", "1", fag);
            Karakter karakter1 = new Karakter(student1, fag[0], "2");
            student1.SkrivUtInfo();
            karakter1.SkrivUtInfo();

            foreach (Fag f in fag)
            {
                f.SkrivUtInfo();
            }

        }
    }
}
