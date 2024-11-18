using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    public class Datatyper
    {
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
        static void Oppgave2()
        {
            int a = 5;
            decimal b = 3;
            decimal sum = a + b;
        }


        // --- Variabeltilordning --- 
        // Oppgave 1
        static int num1 = 1;
        static int num2 = 2;

        public static int Tall(int tall1, int tall2)
        {
            return tall1 + tall2;
        }

        public static void Run()
        {
            Console.WriteLine($"Oppgave 1: {Tall(num1, num2)}");
            
        }

        // Oppgave 2
        public static void Setning()
        { 
            Console.WriteLine("Oppgave 2: Denne metoden returnerer ingenting"); 
        }

    }

}
