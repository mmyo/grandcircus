using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi friend, what's your name: ");
            var userInputName = Console.ReadLine();

            string didUserContinue = null;
            do
            {

                Console.Write($"{userInputName}, please enter a number between 1 and 100: ");
                var userNumberInput = Console.ReadLine();

                var number = 0;
                if (int.TryParse(userNumberInput, out number))
                {

                    var response = NumberEvenOrOdd(number);

                    if (number >= 1 && number <= 100)
                    {
                        Console.WriteLine(response);

                    }
                    else
                    {
                        Console.WriteLine($"{userInputName}, you did not follow the directions. Nice try, but try again!!");
                    }

                }

                else
                {
                    Console.WriteLine($"{userInputName},you didn't enter a number!!!");
                }

                Console.Write("Continue?(y/n)");

                didUserContinue = Console.ReadLine();

            } while (didUserContinue.ToLower() != "n");

        }



        static string NumberEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {

                if (number >= 2 && number <= 25)
                {
                    return "Even and less than 25";
                }
                else if (number >= 26 && number <= 60)
                {
                    return "Even";
                }
                else
                {
                    return $"{number} and Even";
                }


            }
            else
            {
                if (number >= 60)
                {
                    return $"{number} and Odd";
                }
                else
                {
                    return $"{number} and Odd";
                }

            }

        }


    }

}