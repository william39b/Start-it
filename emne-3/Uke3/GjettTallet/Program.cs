// Oppgave
// Lag et program hvor brukeren skal gjette et tilfeldig tall mellom 1-100
// Hver gang brukeren skriver inn et tall vil man få svar fra programmet om man må høyere eller lavere, helt til man gjetter riktig tall.
// Da skal man få spørsmål om man vil spille på nytt

newGame();
void newGame()
{
    Console.Clear();
    Console.WriteLine("Guess a number 1 - 100");

    bool rightNum = false;
    Random random = new Random();
    int randomNum = random.Next(1, 101);

    while (!rightNum)
    {
        int input = Convert.ToInt32(Console.ReadLine());

        if (input < randomNum)
        {
            Console.WriteLine("Higher");
        }
        else if (input > randomNum)
        {
            Console.WriteLine("lower");
        }
        else
        {
            Console.WriteLine("correct");
            Console.Write("\nplay again? [y/n]:");
            string input2 = Console.ReadLine();

            if (input2 == "y") newGame();
            else rightNum = true;
        }

    }
}

