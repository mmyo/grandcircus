using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzWoof
{
    public class FBW
    {
        public void DisplayAllNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i} ({FizzBuzzWoof(i)}) | ");
            }

            Console.ReadLine();
        }

        public string FizzBuzzWoof(int number)
        {
            string fizz = null;
            string buzz = null;
            string woof = null;

            if (number == 3 || (number % 3 == 0) || number.ToString().Contains(3.ToString()))
            {
                fizz = "fizz";
            }
            if (number == 5 || (number % 5 == 0) || number.ToString().Contains(5.ToString()))
            {
                buzz = "buzz";
            }
            if (number == 7 || (number % 7 == 0) || number.ToString().Contains(7.ToString()))
            {
                woof = "woof";
            }

           
            return fizz+buzz+woof;
        }
    }
}
