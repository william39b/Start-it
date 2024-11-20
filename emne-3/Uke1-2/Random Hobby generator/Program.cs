Console.WriteLine("Type your name: ");
string name = Console.ReadLine();

Console.WriteLine($"Hi my name is {name} and im a ");
RandomHobby();

void RandomHobby()
{
    Random random = new Random();
    int number = random.Next(0, 5);

    switch (number)
    {
        case 0:
            Console.WriteLine("0");
            break;
        case 1:
            Console.WriteLine("1");
            break;
        case 2:
            Console.WriteLine("2");
            break;
        case 3:
            Console.WriteLine("3");
            break;
        case 4:
            Console.WriteLine("4");
            break;
        case 5:
            Console.WriteLine("5");
            break;
    }

}
