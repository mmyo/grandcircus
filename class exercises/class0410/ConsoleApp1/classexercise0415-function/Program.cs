using System;

namespace classexercise0415_function
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            PrintToScreenThisManyTimes(userInput);

            Console.ReadKey();

        }

        static void PrintToScreenThisManyTimes(int thisManyTimes)
        {

            if (thisManyTimes <= 0)
            {
                Console.WriteLine("\nNope");
                return;
            }
            else
            {
                for (int i = 0; i < thisManyTimes; i++)
                {
                    Console.WriteLine(i);
                }
                //return;
            }

            
        }
    }
}
