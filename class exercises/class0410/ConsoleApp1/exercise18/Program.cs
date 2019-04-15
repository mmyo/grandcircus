using System;

namespace exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i <= userNumber; i++)
            {
                total = total + i;
            }

            Console.WriteLine(total);
            Console.ReadKey();

        }
    }
}
