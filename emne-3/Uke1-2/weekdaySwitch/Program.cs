// Oppgave:
// Skriv et tall mellom 1-7 i konsollen.
// Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print ut dagen.

Main();
void Main()
{
    Console.WriteLine("Type a number from 1-7");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Sunday");
            break;
        case "2":
            Console.WriteLine("Monday");
            break;
        case "3":
            Console.WriteLine("Tuesday");
            break;
        case "4":
            Console.WriteLine("Wednesday");
            break;
        case "5":
            Console.WriteLine("Thursday");
            break;
        case "6":
            Console.WriteLine("Friday");
            break;
        case "7":
            Console.WriteLine("Saturday");
            break;
        default:
            Main();
            break;
    }


/*
    var weekday = input switch
    {
        "1" => "Sunday",
        "2" => "Monday",
        "3" => "Tuesday",
        "4" => "Wednesday",
        "5" => "Thursday",
        "6" => "Friday",
        "7" => "Saturday",
        _ => "Unknown input",
    };
    Console.WriteLine(weekday);
*/
}





