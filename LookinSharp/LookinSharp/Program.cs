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
            Console.WriteLine("Hey there! Gahdamn, you looking real sharp!");
            // Without the using System line, you'd have to write System.Console.WriteLine() for this to work

            string Homeboy = "Godfrey"; // Declaring a variable
            Console.WriteLine(Homeboy); // Calling a declared variable
        }
    }
}


