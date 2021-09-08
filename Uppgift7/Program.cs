using System;

namespace Uppgift7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Be användaren mata in en mening.
            // Översätt till Leeet Speak
            Console.WriteLine("Skriv en mening: "); // ber användaren skriva en mening
            string[] leetArray;
                                     // A     B      C     D     E     F      G      H     I      J      K     L     M      N      O     P       Q      R      S     T      U      V       W       X        Y     Z
            leetArray = new string[26] { "4" , "|3" , "(" , "|)", "3" , "|=" , "6" , "|-|" , "l", "_|" , "|<" , "1", "|V|" , "/|/", "0" , "|D" , "(,)" , "|2" , "$" , "7" , "|_|" , "|/" , "|/|/" , "><"  , "'/" , "2" };

            Console.WriteLine(leetArray[25]);
        }
    }
}
