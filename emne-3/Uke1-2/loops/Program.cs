// Oppgave 1
// Lag en for-løkke som printer "Terje er kul" til konsollen 5 ganger.

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Terje er kul");
}

// Oppgave 2
// Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen.

string text = "Hello World";
foreach (char c in text)   
{
    Console.WriteLine(c); 
}

// Oppgave 3
// Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde,
// så lenge rundetelleren er mindre enn 10.

int number = 0;
while (number < 10)
{
    number++;
    Console.WriteLine($"Runde number {number}");
}