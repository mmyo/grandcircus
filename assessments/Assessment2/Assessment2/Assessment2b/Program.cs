using System;

namespace Assessment2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = new int[10];

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter a positive odd integer: ");
                    
                if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber > 0 && (userNumber % 2 > 0))
                {
                    userArray[i] = userNumber;
            }
                else
                {
                    Console.WriteLine("Try again");
                    i--;
                }
            }

            Console.WriteLine("Here's your array:");
            foreach (var item in userArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
