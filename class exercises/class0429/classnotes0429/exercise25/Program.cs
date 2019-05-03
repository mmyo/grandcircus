using System;
using System.Collections.Generic;

namespace exercise25
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a sentence: ");
            var userSentence = Console.ReadLine();

            string[] sentenceArray = userSentence.Split(" ");

            foreach (var item in sentenceArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
