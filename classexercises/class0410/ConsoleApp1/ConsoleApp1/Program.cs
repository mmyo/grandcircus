using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1
            string userWantsToRepeatExercise = null;
            do
            {
                Console.WriteLine("Exercise 1 - Echo string");
                Console.WriteLine("Enter some text: ");
                string userInput = Console.ReadLine();
                Console.WriteLine(userInput);

                Console.WriteLine("\n\nDo you wish to do the exercise again? y/n");
                userWantsToRepeatExercise = Console.ReadLine();

            } while (userWantsToRepeatExercise == "y");
            Console.WriteLine("Goodbye!");
            userWantsToRepeatExercise = null;
            Console.Clear();

            //Exercise 2
            do
            {
                Console.WriteLine("Exercise 2 - Add one to integer");
                Console.WriteLine("Enter a number: ");
                int userInput2 = int.Parse(Console.ReadLine());
                Console.WriteLine(++userInput2);

                Console.WriteLine("\n\nDo you wish to do the exercise again? y/n");
                userWantsToRepeatExercise = Console.ReadLine();

            } while (userWantsToRepeatExercise == "y");
            Console.WriteLine("Goodbye!");
            userWantsToRepeatExercise = null;
            Console.Clear();

            //Exercise 3
            do
            {
                Console.WriteLine("Exercise 3 - Add 0.5 to double");
                Console.WriteLine("Enter a number: ");
                double userInput3 = double.Parse(Console.ReadLine());
                Console.WriteLine(userInput3 + 0.5);

                Console.WriteLine("\n\nDo you wish to do the exercise again? y/n");
                userWantsToRepeatExercise = Console.ReadLine();

            } while (userWantsToRepeatExercise == "y");
            Console.WriteLine("Goodbye!");
            userWantsToRepeatExercise = null;
            Console.Clear();

            //Exercise 4
            do
            {
                Console.WriteLine("Exercise 4 - sum two numbers");
                Console.WriteLine("enter first number: ");
                double userinput4 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter another number: ");
                double userinput41 = double.Parse(Console.ReadLine());
                Console.WriteLine("the sum is: " + (userinput4 + userinput41));

                Console.WriteLine("\n\nDo you wish to do the exercise again? y/n");
                userWantsToRepeatExercise = Console.ReadLine();

            } while (userWantsToRepeatExercise == "y");
            Console.WriteLine("Goodbye!");
            userWantsToRepeatExercise = null;
            Console.Clear();

            //Exercise 5
            do
            {
                Console.WriteLine("Exercise 5 - multiply two numbers");
                Console.WriteLine("Enter first number: ");
                double userInput5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                double userInput51 = double.Parse(Console.ReadLine());
                Console.WriteLine("The product is: " + (userInput5 * userInput51));

                Console.WriteLine("\n\nDo you wish to do the exercise again? y/n");
                userWantsToRepeatExercise = Console.ReadLine();

            } while (userWantsToRepeatExercise == "y");
            Console.WriteLine("Goodbye!");
            userWantsToRepeatExercise = null;
            Console.Clear();

            //Exercise 13
            do
            {
                Console.WriteLine("Exercise 13 - countdown to zero");
                Console.WriteLine("Enter a number: ");
                int userInput13 = int.Parse(Console.ReadLine());

                for (int i = userInput13; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine("\n\nDo you wish to do the exercise again? y/n");
                userWantsToRepeatExercise = Console.ReadLine();

            } while (userWantsToRepeatExercise == "y");
            Console.WriteLine("Goodbye!");
            userWantsToRepeatExercise = null;
            Console.Clear();

            //Exercise 14 - squares
            do
            {
                Console.WriteLine("Exercise 14 - square numbers from 1 to your number");
                Console.WriteLine("Enter a number: ");
                int userInput14 = int.Parse(Console.ReadLine());

                for (int i = 1; i <= userInput14; i++)
                {
                    Console.Write(i*i + " ");
                }

                Console.WriteLine("\n\nDo you wish to do the exercise again? y/n");
                userWantsToRepeatExercise = Console.ReadLine();

            } while (userWantsToRepeatExercise == "y");
            Console.WriteLine("Goodbye!");
            Console.Clear();


            Console.ReadKey();
        }
    }
}
