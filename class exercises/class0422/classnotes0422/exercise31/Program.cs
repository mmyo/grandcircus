using System;

namespace exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue = null;
            do
            {
                int[] coolArray = new int[] { 2, 8, 0, 24, 51 };

                Console.Write("Enter an index: ");
                int userIndex = int.Parse(Console.ReadLine());

                if (userIndex > coolArray.Length -1 || userIndex < 0)
                {
                    Console.WriteLine("\nThat is not a valid index");
                }
                else
                {
                    Console.WriteLine($"\nThe value at index {userIndex} is {coolArray[userIndex]}");
                }

                Console.Write("\nDo you want to try again? y/n: ");
                userWantsToContinue = Console.ReadLine();

            } while (userWantsToContinue.Equals("y", StringComparison.OrdinalIgnoreCase));



            Console.WriteLine("Bye");
            
            //Console.ReadLine();
        }
    }
}
