using System;

namespace Uppgift9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in hur många tal: ");

            int QuantitiyOfNumbers = Convert.ToInt32(Console.ReadLine()); //användaren bestämmer antal siffror som skall matas in
            int[] arr = new int[QuantitiyOfNumbers]; // skapar en array för siffrorna


            for (int i = 0; i < arr.Length; i++) //loop som ber användaren mata in tal tills antal tal = arr (dvs antal tal som användaren först valde)
            {
                Console.WriteLine("Skriv in ett tal: "); 
                arr[i] = Convert.ToInt32(Console.ReadLine()); // gör om inmatad tal från string till integer

            }
            // loop tagen från exempel
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
