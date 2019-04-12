using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 16 - need to test

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine(""+i);
            }

            Console.ReadKey();
        }
    }
}
