using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening:"); // skriv mening
            
            string sentence = Console.ReadLine(); // sparar mening i strängen sentence
           
            string[] subs = sentence.Split(' ');  // delar upp mening
            foreach (string word in subs)
            {
                Console.WriteLine($"{word}"); // printar de uppdelade orden på ny rad
            }
        
        }
    }
}
