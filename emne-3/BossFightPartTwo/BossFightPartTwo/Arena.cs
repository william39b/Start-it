using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFightPartTwo
{
    internal class Arena
    {
        private GameCharacter _hero;
        private GameCharacter _boss;
        public Arena(GameCharacter hero, GameCharacter boss)
        {
            _hero = hero;
            _boss = boss;
        }
        public void Bossfight()
        {
            Console.WriteLine("Boss fight\n");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            StartFight();
        }

        private void StartFight()
        {
            while (_hero.Health > 0 && _boss.Health > 0)
            {
                _hero.Fight(_boss);
                if (_boss.Health > 0)
                {
                    _boss.RandomStrengthGenerator();
                    _boss.Fight(_hero);
                }
                ShowStats();
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            string victory = _boss.Health <= 0 ? $"{_hero.Name} Won!" : $"{_boss.Name} Won!";
            Console.WriteLine(victory);
        }

        private void ShowStats()
        {
            Console.WriteLine(
                $"{_hero.Name}{string.Empty.PadLeft(21 - _hero.Name.Length, ' ')}{_boss.Name}\n" +
                $"{ShowFieldAndValue("Health", _hero.Health, _boss.Health)}\n" +
                $"{ShowFieldAndValue("Strength", _hero.Strength, _boss.Strength)}\n" +
                $"{ShowFieldAndValue("Stamina", _hero.Stamina, _boss.Stamina)}");
        }

        private static string ShowFieldAndValue(string label, int heroValue, int bossValue)
        {
            int labelWidth = 10;
            int statsWidth = 10;
            labelWidth -= label.Length;
            statsWidth -= Convert.ToString(heroValue).Length;
            return $"{label}:{string.Empty.PadLeft(labelWidth, ' ')}{heroValue}{string.Empty.PadLeft(statsWidth, ' ')}" +
                   $"{label}:{string.Empty.PadLeft(labelWidth, ' ')}{bossValue}";
        }


    }
}
