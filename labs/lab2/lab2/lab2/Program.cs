using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {           

            string userWantsToContinue = null;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to GC Room Detail Generator Thing\n");
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Area: " + length * width);

                Console.WriteLine("Perimeter: " + (2 * length + 2 * width));

                Console.Write("\nDo you want to continue? y/n");
                userWantsToContinue = Console.ReadLine();
            } while (userWantsToContinue == "y");

            //Console.ReadKey();
        }
    }
}
