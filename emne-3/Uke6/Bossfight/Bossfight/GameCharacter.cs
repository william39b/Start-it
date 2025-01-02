namespace Bossfight;

internal class GameCharacter(string name, int health, int strength, int stamina)
{
    public string Name { get; private set; } = name;
    public int Health { get; private set; } = health;
    public int Strength { get; private set; } = strength;
    public int Stamina { get; private set; } = stamina;

    private int _stamina = stamina;

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