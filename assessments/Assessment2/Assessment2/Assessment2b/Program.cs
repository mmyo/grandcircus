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

            Console.WriteLine("Here's your array (for and if loop):");
            foreach (var item in userArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            int counter=0;
            int[] userArray2 = new int[10];
            while (counter < userArray2.Length)
            {
                Console.WriteLine("Enter a positive odd integer: ");

                if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber > 0 && (userNumber % 2 > 0))
                {
                    userArray2[counter] = userNumber;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }

            Console.WriteLine("Here's your array (while loop):");
            foreach (var item in userArray2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
