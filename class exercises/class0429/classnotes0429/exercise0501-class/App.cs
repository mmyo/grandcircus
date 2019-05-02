using System;
using System.Collections.Generic;
using System.Text;

namespace exercise0501_class
{
    public static class App
    {

        public static void Run()
        {

            // create cow class. weight property. feed method. 
            // write program where a user feeds a cow
            // you can only feed a cow a carrot which has 1 wp, grass 1 wp, or pie 10 wp, 
            // if cow weighs 50 wp

            var cow = new Cow();

            string userWantsToKeepFeeding = null;

            do
            {
                Console.Write("\nWhat would you like to feed the cow? (carrot, grass, pie) ");
                var food = Console.ReadLine();
                cow.Feed(food);
                Console.WriteLine($"\nThe cow now weighs {cow.Weight} units");

                if (cow.Weight > 70)
                {
                    Console.WriteLine("\nCongrats, you overfed the cow and killed it.");
                    cow.IsAlive = false;
                    userWantsToKeepFeeding = "y";
                }

                Console.Write("\nAre you sure you want to keep feeding? y/n: ");

                userWantsToKeepFeeding = Console.ReadLine();

                if (userWantsToKeepFeeding.Equals("y", StringComparison.OrdinalIgnoreCase) && cow.IsAlive == false)
                {
                    Console.WriteLine("\nWtf, you can't feed a dead cow...");
                    userWantsToKeepFeeding = "n";
                }

            } while (userWantsToKeepFeeding.Equals("y", StringComparison.OrdinalIgnoreCase) && cow.IsAlive == true);

            Console.ReadLine();

        }

    }
}
