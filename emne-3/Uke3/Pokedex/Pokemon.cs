using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Pokemon
    {
        public string name;
        public int lvl;
        public int hp;

        public Pokemon(string Name, int Lvl, int Hp)
        {
            name = Name;
            lvl = Lvl;
            hp = Hp;
        }

        public void Run()
        {
            Console.WriteLine($"{name} has {lvl}hp and is {hp}lvl");
        }
    }
}
