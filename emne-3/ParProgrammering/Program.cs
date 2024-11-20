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
    char[] charArr = input.ToCharArray();
    string reversedText = "";

    for (int i = charArr.Length - 1; i >= 0; i--)
    {
        reversedText += charArr[i];
    }
    return reversedText;
}