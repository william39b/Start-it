// --- Variabeltilordning --- 
// Oppgave 1
int num1 = 1;
int num2 = 2;

static int Tall(int tall1, int tall2)
{
    return tall1 + tall2;
}
Console.WriteLine($"Oppgave 1: {Tall(num1, num2)}");

// Oppgave 2
static void Setning()
{
    Console.WriteLine("Oppgave 2: Denne metoden returnerer ingenting");
}
Setning();

