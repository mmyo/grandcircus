using System;

namespace exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            int total = 1;

            for (int i = userNumber - 2; i <= userNumber; i++)
            {
                total = total * i;
            }

            Console.WriteLine($"The product of {userNumber}, {userNumber-1}, and {userNumber-2} is {total}");
            Console.ReadKey();
        }
    }
}
