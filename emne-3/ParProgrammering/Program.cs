// Par-Programmering-1) Reverser stringen!

// Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert.
// Gjør dette uten å bruke innebygde reverse metoder.
// Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
// Alternativer for hva man vil gjøre, trykk 1,2 eller 3 for å reversere, konvertere til uppercase eller lowercase.

Console.WriteLine("Type something");
var input = Console.ReadLine();

Console.WriteLine("1: to reverse");
Console.WriteLine("2: for uppercase");
Console.WriteLine("3: for lowercase");
var selectedNumber = Console.ReadLine();

switch (selectedNumber)
{
    case "1":
        Console.WriteLine(Reverse());
        break;
    case "2":
        Console.WriteLine(input.ToUpper());
        break;
    case "3":
        Console.WriteLine(input.ToLower());
        break;
}

string Reverse()
{
    string reversedText = "";

    for (int i = input.Length - 1; i >= 0; i--)
    {
        reversedText += input[i];
    }
    return reversedText;
}