namespace BossFightPartTwo
{
    internal class Boss : GameCharacter
    {
        public Boss(string name, int health, int strength, int stamina)
            : base(name, health, strength, stamina) { }
      
        public override void Fight(GameCharacter opponent)
        {
            if (Stamina <= 0) Recharge();
            else
            {
                RandomStrengthGenerator();
                opponent.Health -= Strength;
                Stamina -= 10;
                Console.WriteLine($"{Name} hit {opponent.Name} with {Strength} damage");
            }
        }
        
        private void RandomStrengthGenerator()
        {
            Random rnd = new Random();
            Strength = rnd.Next(0, 31);
        }
    }
}
