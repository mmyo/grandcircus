using System;

namespace lab89_students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] studentsArray = new string[20, 3];
            studentsArray[0, 0] = "Kim";
            studentsArray[0, 1] = "Detroit";
            studentsArray[0, 2] = "Pizza";
            studentsArray[1, 0] = "Bob";
            studentsArray[1, 1] = "New York";
            studentsArray[1, 2] = "Burgers";

            Console.Write("Which student? ");
            int userStudent = int.Parse(Console.ReadLine());

            Console.WriteLine(studentsArray[userStudent, 0]);

            Console.Write("What do you want to know? (hometown/food): ");
            string userWantsToKnow = null;
            int userWantsToKnowIndex;

            switch (userWantsToKnow)
            {
                case "hometown":
                    userWantsToKnowIndex = 1;
                    break;
                case "food":
                    userWantsToKnowIndex = 2;
                    break;
                default:
                    break;
            }

            Console.WriteLine(studentsArray[userStudent, userWantsToKnowIndex]);


            Console.ReadLine();
        }
    }
}
