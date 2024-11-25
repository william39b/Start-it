string newString = "";

Console.Write("1. RotateText\n2. Change word\n\nSelect: ");
var select = Console.ReadLine();

switch(select)
{
    case "1":
        rotateText();
        Console.WriteLine($"Input rotated:\n{newString}");
        break;
    case "2": 
        ChangeText();
        Console.WriteLine($"{newString}");
        break;
}

void rotateText()
{
    var input = Console.ReadLine();
    string newInput = "";
    for (int i = input.Length - 1; i >= 0; i--)
    {
        newInput += input[i];
    }
    newString = newInput;
}

void ChangeText()
{
    string input = Console.ReadLine();
    string newInput = input.Replace("c", "e");
    newString = newInput;   
}