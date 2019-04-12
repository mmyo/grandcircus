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

                try
                {
                    Console.Write("Enter length: ");
                    double length = double.Parse(Console.ReadLine());

                    Console.Write("Enter width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.WriteLine("Area: " + length * width);

                    Console.WriteLine("Perimeter: " + (2 * length + 2 * width));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nRuh roh, try again\n\n" + ex.ToString());
                    //throw;
                }             

                Console.Write("\nDo you want to continue? y/n: ");
                userWantsToContinue = Console.ReadLine();
            } while (userWantsToContinue == "y");

            //Console.ReadKey();
        }
    }
}
