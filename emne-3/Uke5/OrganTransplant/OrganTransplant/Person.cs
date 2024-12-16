using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Person
    {
        public string Name { get; private set; }
        private int kidneys;
        public int Kidneys
        {
            get { return kidneys; }
            set
            {
                if (value == 2 || value == 1)
                {
                    kidneys = value;
                }
                else
                {
                    kidneys = 0;
                }
            }
        }

        public Person(string name, int kidneys)
        {
            Name = name;
            Kidneys = kidneys;
        }
    }
}
