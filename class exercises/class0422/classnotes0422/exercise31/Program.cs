using System;

namespace exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue = null;

            int[] coolArray = new int[] { 2, 8, 0, 24, 51 };

            do
            {
                foreach (var item in coolArray)
                {
                    Console.Write($"{item} ");
                }

                Console.Write("\nEnter an index: ");

                if (int.TryParse(Console.ReadLine(), out int userIndex) && userIndex >= 0 && userIndex < coolArray.Length)
                {
                    Console.WriteLine($"\nThe value at index {userIndex} is {coolArray[userIndex]}");
                }
                else
                {
                    Console.WriteLine("Not a valid index");
                }

                Console.Write("\nDo you want to try again? y/n: ");
                userWantsToContinue = Console.ReadLine();

            } while (userWantsToContinue.Equals("y", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Bye");         
        }
    }
}
