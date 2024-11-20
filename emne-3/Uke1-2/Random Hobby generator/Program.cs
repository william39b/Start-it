// Oppgave:
// Skriv navn inn i konsollen, la en funksjon trekke en tilfeldig hobby og vis dette sammen med navnet i konsollvinduet.

Console.WriteLine("Type your name: ");
string name = Console.ReadLine();

Console.Write($"Hi my name is {name} and my hobby is ");
RandomHobby();

void RandomHobby()
{
    Random random = new Random();
    int number = random.Next(0, 5);

    switch (number)
    {
        case 0:
            Console.WriteLine("cycling");
            break;
        case 1:
            Console.WriteLine("jogging");
            break;
        case 2:
            Console.WriteLine("boxing");
            break;
        case 3:
            Console.WriteLine("gaming");
            break;
        case 4:
            Console.WriteLine("reading");
            break;
        case 5:
            Console.WriteLine("trainspottting");
            break;
    }

}
