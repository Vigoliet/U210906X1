using System;

namespace Uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Låt användaren mata in ett ord i taget
            // 2. Avsluta programmet om användaren matar in AVSLUTA
            // 3. Skriv ut din mening just nu är: skriv ut alla inmatade ord

            string sentence = "";
            while (true)
            {
                Console.WriteLine("Skriv ett ord:"); // skriv mening
                string word = Console.ReadLine();
                

                if (word == "avsluta" || word == "Avsluta" || word == "AVSLUTA")
                {
                    break;
                }
                sentence = sentence + " " + word;
            }
            Console.WriteLine($"Din mening just nu är: {sentence}");






        }
    }
}
