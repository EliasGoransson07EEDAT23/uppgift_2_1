using System;
namespace uppgift_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, snabb fråga. Vilken är din favoritbok? Skriv titeln nedan!:");
            string book = Console.ReadLine();
            Console.WriteLine("Okej, så din favoritbok är alltså " + book + ".");
            Console.ReadKey();

        }
    }
}