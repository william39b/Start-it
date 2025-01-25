namespace BossFightPartTwo
{
    internal class Arena
    {
        private Hero _hero;
        private Boss _boss;
        
        public Arena(Hero hero, Boss boss)
        {
            _hero = hero;
            _boss = boss;
        }
        
        public void BossFight()
        {
            Console.WriteLine("Boss fight");
            ShowStats();
            Console.Write("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();
            StartFight();
        }

        private void StartFight()
        {
            while (_hero.Health > 0 && _boss.Health > 0)
            {
                _hero.Fight(_boss);
                if (_boss.Health > 0) _boss.Fight(_hero);
                ShowStats();
                Console.Write("Press any key to continue: ");
                Console.ReadKey();
                Console.Clear();
            }
            ShowWinner();
        }

        private void ShowWinner()
        {
            string winner = _boss.Health <= 0 ? $"{_hero.Name} Won!" : $"{_boss.Name} Won!";
            Console.WriteLine(winner);
            Console.WriteLine("Try again?");
            Console.ReadKey();
        }

        private void ShowStats()
        {
            Console.WriteLine(
                $"\n{_hero.Name}{string.Empty.PadLeft(21 - _hero.Name.Length, ' ')}{_boss.Name}\n" +
                $"{ShowLabelAndValue("Health", _hero.Health, _boss.Health)}\n" +
                $"{ShowLabelAndValue("Strength", _hero.Strength, _boss.Strength)}\n" +
                $"{ShowLabelAndValue("Stamina", _hero.Stamina, _boss.Stamina)}");
        }

        private static string ShowLabelAndValue(string label, int heroValue, int bossValue)
        {
            int labelWidth = 10;
            int valueWidth = 10;
            labelWidth -= label.Length;
            valueWidth -= Convert.ToString(heroValue).Length;
            return $"{label}:{string.Empty.PadLeft(labelWidth, ' ')}{heroValue}{string.Empty.PadLeft(valueWidth, ' ')}" +
                   $"{label}:{string.Empty.PadLeft(labelWidth, ' ')}{bossValue}";
        }


    }
}
