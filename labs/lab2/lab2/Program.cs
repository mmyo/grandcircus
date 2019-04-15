using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to GC Room Detail Generator Thing\n");

                try
                {
                    Console.Write("Enter room length: ");
                    double length = double.Parse(Console.ReadLine());

                    Console.Write("Enter room width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nArea: " + length * width);
                    Console.WriteLine("Perimeter: " + (2 * length + 2 * width));

                    Console.Write("\nDo you want to calcuate volume? y/n: ");
                    string userWantsToCalculateVolume = Console.ReadLine();

                    if (userWantsToCalculateVolume == "y")
                    {
                        Console.Write("\nEnter room height: ");
                        double height = double.Parse(Console.ReadLine());

                        Console.WriteLine("Volume: " + (length * width * height) + " unit(s) cubed");
                    }

                    //string userWantsToDrawBox = null;
                    Console.Write("\nDo you want to draw the room (from above)? y/n: ");
                    string userWantsToDrawBox = Console.ReadLine();
                    

                    if (userWantsToDrawBox == "y")
                    {
                        Console.WriteLine("\nHere's a " + length + " by " + width + " room:\n");

                        for (int j = 0; j < width; j++)
                        {
                            for (int i = 0; i < length; i++)
                            {
                                Console.Write("* ");
                            }
                            Console.Write("\n");
                        }
                    }             
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nRuh roh, try again\n\n" + ex.ToString());
                }             

                Console.Write("\nDo you want to continue? y/n: ");
                userWantsToContinue = Console.ReadLine();

            } while (userWantsToContinue == "y");

        }
    }
}
