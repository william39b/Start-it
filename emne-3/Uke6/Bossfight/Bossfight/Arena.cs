namespace Bossfight;

internal class Arena(GameCharacter hero, GameCharacter boss)
{
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
        while (hero.Health > 0 && boss.Health > 0)
        {
            hero.Fight(boss);
            if (boss.Health > 0)
            {
                boss.RandomStrengthGenerator();
                boss.Fight(hero);
            }
            ShowStats();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        string victory = boss.Health <= 0 ? $"{hero.Name} Won!" : $"{boss.Name} Won!";
        Console.WriteLine(victory);
    }

    private void ShowStats()
    {
        Console.WriteLine( 
            $"{hero.Name}{string.Empty.PadLeft(21 - hero.Name.Length, ' ')}{boss.Name}\n" +
            $"{ShowFieldAndValue("Health", hero.Health, boss.Health)}\n" +
            $"{ShowFieldAndValue("Strength", hero.Strength, boss.Strength)}\n" +
            $"{ShowFieldAndValue("Stamina", hero.Stamina, boss.Stamina)}");
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