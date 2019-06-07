using System;

namespace exercise75_sqroot_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            var userInput = int.Parse(Console.ReadLine());

            Console.Write("\nUsing Math.Sqrt method: ");
            CalcSqMathMethod(userInput);

            Console.Write("\nSquaring until found: ");
            CalcSqRtSquareFromOne(userInput);

            Console.Write("\nDividing until found: ");
            CalcSqRtDivideFromOne(userInput);

            
            Console.ReadLine();
        }

        public static void CalcSqMathMethod(int userNumber)
        {
            Console.WriteLine($"Square root of {userNumber} is {Math.Sqrt(userNumber)}");

        }

        public static void CalcSqRtSquareFromOne(int userNumber)
        {
            var isPerfectSquare = false;

            for (int i = 1; i < userNumber; i++)
            {
                if (i * i == userNumber)
                {
                    Console.WriteLine($"Square root of {userNumber} is {i}");
                    isPerfectSquare = true;
                    break;
                }
            }

            if (isPerfectSquare == false)
            {
                Console.WriteLine($"Not a perfect square");
            }
          
        }

        public static void CalcSqRtDivideFromOne(int userNumber)
        {
            var isPerfectSquare = false;

            double y = userNumber;

            for (double x = 1; x < y; x++)
            {
                y = userNumber / x;

                if (y == x)
                {
                    Console.WriteLine($"Square root of {userNumber} is {x}");
                    isPerfectSquare = true;
                    break;
                }
            }

            if (isPerfectSquare == false)
            {
                Console.WriteLine($"Not a perfect square");
            }
        }
    }
}
