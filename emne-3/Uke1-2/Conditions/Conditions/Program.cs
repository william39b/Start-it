// Conditions - if/else

// Oppgave 1:
// Lag en metode som tar imot to tall og returnerer true dersom tallene er like.

int tall1 = 15;
int tall2 = 15;

bool IsEqual()
{
    if (tall1 == tall2)
        return true;
    else 
        return false;
}
Console.WriteLine($"Oppgave 1: {IsEqual()}\n");


// Oppgave 2:
// Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, 
// og returnerer tallene multiplisert med hverandre dersom de er like.

int sum;

void IsEqual2()
{
    if (tall1 != tall2)
    {
        sum = tall1 + tall2;
        Console.WriteLine($"Tallene er ulike");
        Console.WriteLine($"Summen av ({tall1} + {tall2}) = {sum}\n");
    }
    else
    {
        sum = tall1 + tall2;
        Console.WriteLine($"Tallene er like");
        Console.WriteLine($"({tall1} * {tall2}) = {sum}\n");
    }
}
Console.Write("Oppgave2:\n");
IsEqual2();

// Oppgave 3:
// Lag en metode som tar inn to int verdier.
// Dersom en av de, eller summen til int verdiene blir 30, skal metoden returnere true.
// Ellers returnerer metoden false.

bool CheckNum()
{ 
    if (tall1 + tall2 == 30 || tall1 == 30 || tall2 == 30)
        return true;
    else 
        return false;
}
Console.WriteLine($"Oppgave 3: {CheckNum()}");
