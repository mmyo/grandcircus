using System;
using System.Collections.Generic;

namespace exercise47
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> userWordsSentence = new List<string>();

            string keepGoing = null;
            do
            {
                Console.WriteLine("Enter text: ");
                userWordsSentence.Add(Console.ReadLine());

                Console.Write("keep going? y/n: ");
                keepGoing = Console.ReadLine();

            } while (keepGoing.Equals("y", StringComparison.OrdinalIgnoreCase));

            foreach (var item in userWordsSentence)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
            
        }   
    }       
}
