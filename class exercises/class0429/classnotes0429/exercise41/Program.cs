using System;

namespace exercise41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber}/{secondNumber} is approximately: {Math.Round(firstNumber/secondNumber, 2)}");

            Console.ReadLine();
        }
    }
}
