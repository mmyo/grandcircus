using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 17 - need to test

            int spaceCounter = 10;
            for (int i = 0; i < 11; i++)
            {             
                for (int k = spaceCounter; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("" + i);
                spaceCounter = spaceCounter - 1;
            }

            

            Console.ReadKey();
        }
    }
}
