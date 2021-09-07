using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening:"); //skriv mening
            
            string sentence = Console.ReadLine(); // sparar mening i strängen sentence
           
            string[] subs = sentence.Split(' ');  
            foreach (string word in subs)
            {
                Console.WriteLine($"{word}");
            }
        
        }
    }
}
