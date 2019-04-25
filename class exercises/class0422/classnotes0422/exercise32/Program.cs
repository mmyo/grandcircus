using System;

namespace exercise32
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");

            int[] coolArray = new int[] { 2, 8, 0, 24, 51, 2 };

            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                FindNumberWithinArray(userNumber, coolArray);
            }
       
            Console.ReadLine();
        }

        static void FindNumberWithinArray(int userNumber, int[] userArray)
        {
            bool isUserInputInArray = false;

            for (int i = 0; i < userArray.Length; i++)
            {
                if (userNumber == userArray[i])
                {
                    Console.WriteLine($"The value of {userNumber} can be found at index {i}");
                    isUserInputInArray = true;
                }
            }

            if (isUserInputInArray == false)
            {
                Console.WriteLine("That value cannot be found in the array.");
            }
        }
    }
}
