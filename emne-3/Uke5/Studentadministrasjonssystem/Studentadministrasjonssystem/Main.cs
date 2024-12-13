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
            List<Fag> fag = new List<Fag>
            {
                new Fag("1", "Matematikk", 60),
                new Fag("2", "Engels", 30),
                new Fag("3", "Norsk", 30),
            };

            Student student1 = new Student(
                "Terje",
                "21", 
                "program1", 
                1, 
                new List<Fag>{ fag[0], fag[1] },
                new List<Karakter> { new Karakter(fag[0], 4), new Karakter(fag[1], 6) });
            student1.SkrivUtInfo();
        }
    }
}
