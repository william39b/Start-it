using KlikkerSpill;

var game = new ClickerGame();
var commands = new CommandSet(game);

while (true)
{
    Console.Clear();
    Console.WriteLine(
        "Kommandoer:\n " +
        "- SPACE = klikk (og få poeng)\n " +
        "- K = kjøp oppgradering øker poeng per klikk koster 10 poeng\n " +
        "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\n " +
        "- X = avslutt applikasjonen\n");

    Console.WriteLine($"Du har {game.Points} poeng.");
    Console.WriteLine("Trykk tast for ønsket kommando.");
    var command = Console.ReadKey().KeyChar;
    commands.RunCommand(command);
}