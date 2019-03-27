using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1FunRecommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");

            Console.WriteLine("Hello! \n\nHere are your options, pick a numner:\n" +
                "1 - Action\n" +
                "2 - Chilling\n" +
                "3 - Danger\n" +
                "4 - Good food");

            string chosenActivity = Console.ReadLine();

            if ((chosenActivity == "1") || (chosenActivity == "2") || (chosenActivity == "3") || (chosenActivity == "4"))
            {

                Console.WriteLine("How many people are you bringing with you?");

                int numberOfPeople = int.Parse(Console.ReadLine());

                string travelMethod = null;
                if (numberOfPeople == 0)
                    travelMethod = "sneakers";
                else if (numberOfPeople > 0 && numberOfPeople <= 4)
                    travelMethod = "a sedan";
                else if (numberOfPeople > 4 && numberOfPeople <= 10)
                    travelMethod = "a VW bus";
                else if (numberOfPeople > 10)
                    travelMethod = "an airplane";

                //Console.WriteLine(chosenActivity + " " + numberOfPeople); //test

                string recommendedActivity = null;
                switch (chosenActivity)
                {
                    case "1":
                        chosenActivity = "action";
                        recommendedActivity = "stock car racing";
                        break;
                    case "2":
                        chosenActivity = "chilling";
                        recommendedActivity = "hiking";
                        break;
                    case "3":
                        chosenActivity = "danger";
                        recommendedActivity = "skydiving";
                        break;
                    case "4":
                        chosenActivity = "good food";
                        recommendedActivity = "to Taco Bell";
                        break;
                    default:
                        break;
                }


                Console.WriteLine("Okay, if you're in the mood for " + chosenActivity
                    + ", then you should go to " + recommendedActivity
                    + " and travel in " + travelMethod
                    + "\n\nGood bye!");

            }
            else
                Console.WriteLine("Hmmm, you entered something wrong. Next time try entering a number.");

            Console.ReadLine();

        }
    }
}
