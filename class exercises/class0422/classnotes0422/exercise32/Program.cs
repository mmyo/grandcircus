using System;

namespace exercise32
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            int[] coolArray = new int[] { 2, 8, 0, 24, 51 };

            bool isUserInputInArray = false;

            for (int i = 0; i < coolArray.Length ; i++)
            {
                if (userInput == coolArray[i])
                {
                    Console.WriteLine($"The value of {userInput} can be found at index {i}");
                    isUserInputInArray = true;
                }
            }

            if (isUserInputInArray == false)
            {
                Console.WriteLine("That value cannot be found in the array.");
            }

            Console.ReadLine();
        }
    }
}
