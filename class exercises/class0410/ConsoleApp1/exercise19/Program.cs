using System;

namespace exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                total = total + i;
               
            }

            Console.WriteLine($"Sum from {firstNumber} to {secondNumber} is {total}.");

            Console.ReadKey();
        }
    }
}
