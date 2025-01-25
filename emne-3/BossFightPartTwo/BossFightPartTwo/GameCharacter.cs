namespace BossFightPartTwo
{
    internal abstract class GameCharacter
    {
        public string Name { get; protected set; }
        public int Health { get; protected internal set; }
        public int Strength { get; protected set; } 
        public int Stamina { get; protected set; } 
        private int _baseStamina;

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            _baseStamina = stamina;
        }

        public virtual void Fight(GameCharacter opponent)
        {
            if (Stamina <= 0) Recharge();
            else
            {
                opponent.Health -= Strength;
                Stamina -= 10;
                Console.WriteLine($"{Name} hit {opponent.Name} with {Strength} damage");
            }
        }

        protected void Recharge()
        {
            Console.WriteLine($"{Name} had to recharge!");
            Stamina += _baseStamina;
            
        }

       
    }
}
