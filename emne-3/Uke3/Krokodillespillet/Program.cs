int points = 0;
bool isRunning = true;

while(isRunning)
{
    var rand = new Random();
    int number1 = rand.Next(0, 10);
    int number2 = rand.Next(0, 10);

    Console.WriteLine($"{number1}_{number2}");
    var input = Console.ReadLine();

    switch (input)
    {
        case "<":
            if (number1 <= number2) points++;
            else points--;
            break;
        case ">":
            if (number1 >= number2) points++;
            else points--;
            break;
        default:
            isRunning = false;
            break;
    }

    Console.WriteLine($"points: {points}\n");
}






