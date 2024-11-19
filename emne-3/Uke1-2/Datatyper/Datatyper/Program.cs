// --- Datatyper ---
// Oppgave 1
int tall = 10;
long tall2 = 20;

float desimalTall = 1.0f;
double desimalTall2 = 1.0;
decimal desimalTall3 = 3.3m;

bool santUsant = true;
int[] tallArr = { 1, 2, 3 };
string text = "Hello, World!";
char text2 = 'B';

// Oppgave 2
int a = 5;
decimal b = 3;
decimal sum = a + b;



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

