using System;

namespace Uppgift6
{
    class Program
    {
        static void Main(string[] args)
            
        {
            // 1. Be användaren gissa ett tal mellan 1-21
            // 2. Skapa ett slumptal mellan 1-21
            // 3. Om användaren gissat rätt: skriv ut Grattis!
            // 4. Annars fortsätt be användaren gissa

            Console.WriteLine("Gissa ett tal mellan 1-21"); // Ber användaren gissa ett tal mellan 1-21
            Random rnd = new Random(); // skapar ett 
            int number = rnd.Next(1, 22); // skapar int "number" som ett slumptal mellan 1-21

            while(true) //loop
            {
                int yourguess = Convert.ToInt32(Console.ReadLine()); // Konverterar inputen från string till integer
                
                if (yourguess == number) 
                {
                    Console.WriteLine($"Grattis, du svarade korrekt. Talet är {number}"); 
                    break; //avslutar loopen när conditionet stämmer med ifsatsen
                }
                else
                {
                    Console.WriteLine("Fel nummer, försök igen!"); // startar om loopen.
                }
            }
        }
    }
}
