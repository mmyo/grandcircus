using System;

namespace exercise22_number_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Check if this number is within range: ");
            int checkNumber = int.Parse(Console.ReadLine());

            if (checkNumber >= firstNumber && checkNumber <= secondNumber)
            {
                Console.WriteLine($"{checkNumber} is within the range of {firstNumber} and {secondNumber}.");
            }
            else
            {
                Console.WriteLine($"{checkNumber} is NOT within range of {firstNumber} and {secondNumber}.");
            }



            Console.ReadKey();
        }
    }
}
