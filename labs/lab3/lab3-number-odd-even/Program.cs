using System;

namespace lab3_number_odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue = null;
            do
            {
                Console.Clear();
                Console.Write("Enter a number 1 - 100: ");

                //bool isReallyAnInteger = int.TryParse(Console.ReadLine(), out int userInput);          
                //Console.WriteLine("Number is: " + EvaluateIfNumberIsEvenOrOdd(userInput, out string whatIsTheNumber));      

                if (int.TryParse(Console.ReadLine(), out int userInput) && userInput > 0 && userInput <= 100)
                {
                    EvaluateIfNumberIsEvenOrOdd(userInput, out string whatIsTheNumber);

                    if (whatIsTheNumber == "Odd")
                    {
                        Console.WriteLine(userInput + " and " + whatIsTheNumber);
                    }
                    else if (whatIsTheNumber == "Even" && userInput >= 2 && userInput <= 25)
                    {
                        Console.WriteLine(whatIsTheNumber + " and less than 25");
                    }
                    else if (whatIsTheNumber == "Even" && userInput > 25 && userInput <= 60)
                    {
                        Console.WriteLine(whatIsTheNumber);
                    }
                    else if (whatIsTheNumber == "Even" && userInput > 60)
                    {
                        Console.WriteLine(userInput + " and " + whatIsTheNumber);

                    }
                }
                else
                {
                    Console.WriteLine("\nYou didn't enter an integer between 1-100. Try again");
                }

                Console.Write("\nDo you want to continue? (y/n)");
                userWantsToContinue = Console.ReadLine();
            } while (userWantsToContinue == "y");

            //Console.ReadLine();

        }

        static string EvaluateIfNumberIsEvenOrOdd(int number, out string evenOrOdd)
        {
            var divideTwoNumbers = number % 2;

            if(divideTwoNumbers>0)
            {
                return evenOrOdd = "Odd";
            }
            else
            {
                return evenOrOdd = "Even";
            }
           
          
        }
    }
}
