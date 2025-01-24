using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BossFightPartTwo
{
    internal class GameCharacter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; } 
        public int Stamina { get; private set; } 

        private int _stamina;

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            _stamina = stamina;
        }

        public void Fight(GameCharacter opponent)
        {
            if (Stamina <= 0)
            {
                Recharge();
                Console.WriteLine($"{Name} had to recharge!");
            }
            else
            {
                opponent.Health -= Strength;
                Stamina -= 10;
                Console.WriteLine($"{Name} hit {opponent.Name} with {Strength} damage");
            }
        }

        private void Recharge()
        {
            Stamina += _stamina;
        }

        public void RandomStrengthGenerator()
        {
            Random rnd = new Random();
            Strength = rnd.Next(0, 30);
        }
    }
}
