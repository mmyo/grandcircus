using System;
using System.Collections.Generic;

namespace lab89_students
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] studentsDataArray = CreateStudentArray();

            List<StudentInfo> studentList = new List<StudentInfo>();

            studentList = FillObjectListFromTwoDimArray(studentsDataArray, studentList);

            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Name}, {item.Hometown}, {item.Food}");
            }

            Console.Write($"Which student? Enter 0-{studentList.Count-1}: ");
            int studentRequestedByUser = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nStudent {studentRequestedByUser} is {studentList[studentRequestedByUser].Name}");

            Console.Write($"\nWhat do you want to know about {studentList[studentRequestedByUser].Name}? (hometown/food): ");
            string userWantsToKnow = Console.ReadLine();

            switch (userWantsToKnow.ToLower())
            {
                case "hometown":
                    Console.WriteLine($"\n{studentList[studentRequestedByUser].Name}'s hometown is: {studentList[studentRequestedByUser].Hometown}");
                    break;
                case "food":
                    Console.WriteLine($"\n{studentList[studentRequestedByUser].Name}'s favorite food is: {studentList[studentRequestedByUser].Food}");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        public static string[,] CreateStudentArray( )
        {
            string[,] studentsArray = new string[5, 3];
            studentsArray[0, 0] = "Kim";
            studentsArray[0, 1] = "Detroit";
            studentsArray[0, 2] = "Pizza";

            studentsArray[1, 0] = "Bob";
            studentsArray[1, 1] = "New York";
            studentsArray[1, 2] = "Burgers";

            studentsArray[2, 0] = "Casey";
            studentsArray[2, 1] = "Mackinac";
            studentsArray[2, 2] = "Tacos";

            studentsArray[3, 0] = "Matt";
            studentsArray[3, 1] = "Detroit";
            studentsArray[3, 2] = "Sushi";

            studentsArray[4, 0] = "Homer";
            studentsArray[4, 1] = "Springfield";
            studentsArray[4, 2] = "Beer";

            return studentsArray;
        }

        public static List<StudentInfo> FillObjectListFromTwoDimArray(string[,] studentsDataArray, List<StudentInfo> studentList)
        {

            for (int i = 0; i < studentsDataArray.GetLength(0); i++)
            {
                studentList.Add(new StudentInfo { Name = studentsDataArray[i, 0], Hometown = studentsDataArray[i, 1], Food = studentsDataArray[i, 2] });

            }

            return studentList;
        }
    }
}
