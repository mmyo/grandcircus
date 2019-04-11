using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.WriteLine("What's your name?");

            //string userInput = Console.ReadLine();

            //Console.WriteLine("Hi, " + userInput);

            int simpsonsFamilyAddress = 742;

            Console.WriteLine("The Simpsons family lives at: " + simpsonsFamilyAddress + " Evergreen Terrace");
            Console.WriteLine("Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Let's set Bart's home address to the family address now.");

            int bartsAddress = simpsonsFamilyAddress;

            Console.WriteLine("Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Ok, now Bart's address is: " + bartsAddress + " Evergreen Terrace");

            Console.WriteLine("Let's set Lisa's home address to the family address now.");

            int lisasAddress = simpsonsFamilyAddress;

            Console.WriteLine("Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Ok, now Lisa's address is: " + lisasAddress + " Evergreen Terrace");
            Console.WriteLine("Enter to continue...");
            Console.ReadLine();


            Console.ReadLine();

        }
    }
}
