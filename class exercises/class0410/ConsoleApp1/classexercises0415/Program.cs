using System;

namespace classexercises0415
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = AddTwoNumbers(2, 3);

            Console.WriteLine(results);

            Console.ReadLine();
        }

        static int AddTwoNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static bool IsOldEnoughToDrink(int age)
        {
            //if (age >= 21)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return age >= 21;
        }
    }
}