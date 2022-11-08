// See https://aka.ms/new-console-template for more information
using System; // We're using classes from the System namespace

namespace LookinSharp // Organizes code; container for classes and other namespaces
{
    class Program // Container for data and methods
    {
        static void Main(string[] args) // Every C# program has a Main method; all code in this block is executed
        {
            // Console is a class from the system namespace
            // WriteLine is a method from the Console class that is used to print/ouput text
            // Without the using System line, you'd have to write System.Console.WriteLine() for this to work

            // Declaring variables
            string FavAnime = "Naruto";
            string FavAnime2 = "My Hero Academia";
            string FavAnime3 = "Samurai Champloo";
            // A string without a declared name is called a string literal
            Console.WriteLine($"My top three favorite anime are {FavAnime}, {FavAnime2}, and {FavAnime3}."); // Interpolating strings

            Console.WriteLine($"The title Naruto has {FavAnime.Length} letters in it.");
            Console.WriteLine($"Okay. Well how many characters are in {FavAnime2} and {FavAnime3}?");
            Console.WriteLine($"{FavAnime2} has {FavAnime2.Length} characters in it, and {FavAnime3} has {FavAnime3.Length}.");
            Console.WriteLine($"Alright, got it. Thanks bro.");
            Console.WriteLine("Anytime, bro.");
        }
    }
}


