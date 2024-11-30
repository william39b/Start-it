namespace Overloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage w = new WelcomeMessage();
            
            Console.WriteLine($"{w.PrintWelcomeMessage()}"); // Without argument
            Console.WriteLine($"{w.PrintWelcomeMessage("du er kul")}"); // With argument

            Console.WriteLine($"{w.Compliment("du er kul")}");
            Console.WriteLine($"{w.Compliment()}");
        }   
    }

    class WelcomeMessage
    {
        public string PrintWelcomeMessage() 
        {
            return "Hei og velkommen";
        }

        public string PrintWelcomeMessage(string compliment) // Method returning a string argument
        {
            return $"Hei og velkommen, {compliment}";
        }


        public string Compliment(string compliment = "du er snill") // Method with a default value
        {
            return compliment;
        }
    }
}
