using System;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Låt användaren mata in en mening
            // 2- Skriv ut antal ord
            // 3- Skriv ut varje ord på en egen rad med antal tecken i ordet (ex hej (3))


            Console.WriteLine("Skriv en mening:"); //skriv mening
            
            string sentence = Console.ReadLine();

            int wordCount = 0;

            // Loopa genom strängen
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                // Räknar alla mellanslag i strängen
                if (sentence[i] == ' ' && Char.IsLetter(sentence[i + 1]) && (i > 0)) 
                {
                    wordCount++;
                }
            }
            // Lägg till 1 för att räkna sista ordet
            wordCount++;

            Console.WriteLine($"Antalet ord i meningen är: {wordCount}");

            string[] subs = sentence.Split(' ');
            foreach (string word in subs)
            {
                Console.WriteLine($"{word} ({word.Length})");
            }



        }
    }
}
