using System;

namespace class0415_functionpassbyref
{
    class Program
    {
        static void Main(string[] args)
        {
            // return a number. take in string. return length of string.


            Console.Write("Enter a string: ");

            string userInput = Console.ReadLine();

            Console.WriteLine(GimmeTheLengthOfTheString(userInput));

            Console.ReadLine();

        }

        static int GimmeTheLengthOfTheString(string theWord)
        {
    
            return theWord.Length; 
        }

    }
}
