namespace BossFightPartTwo
{
    internal class Boss : GameCharacter
    {
        public Boss(string name, int health, int strength, int stamina)
            : base(name, health, strength, stamina) { }
      
        public void RandomStrengthGenerator()
        {
            Random rnd = new Random();
            Strength = rnd.Next(0, 31);
        }
    }
}
