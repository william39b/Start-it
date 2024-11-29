namespace Overloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage w = new WelcomeMessage();
            
            Console.WriteLine($"{w.PrintWelcomeMessage()}, {w.Compliment()}"); // Default value
            Console.WriteLine($"{w.PrintWelcomeMessage()}, {w.Compliment("du er kul")}"); // Overloaded default value
        }   
    }

    class WelcomeMessage
    {
        public string PrintWelcomeMessage() 
        {
            return "Hei og velkommen";
        }

        public string Compliment(string compliment = "du er snill") // Method with a default value
        {
            return compliment;
        }
    }
}
