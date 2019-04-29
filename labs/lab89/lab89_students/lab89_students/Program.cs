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
            FillObjectListFromTwoDimArray(studentsDataArray, studentList);

            int userMenuSelection = 0;
            do
            {
                Console.Clear();
                DisplayMainMenu();

                int.TryParse(Console.ReadLine(), out userMenuSelection);

                switch (userMenuSelection)
                {
                    case 1:
                        DisplayAllStudents(studentList);
                        Console.WriteLine("\npress any key to continue ...");
                        Console.ReadKey();
                        break; 
                    case 2:
                        DisplayAllStudents(studentList);
                        LookUpStudentInfo(studentList);
                        Console.WriteLine("\npress any key to continue ...");
                        Console.ReadKey();
                        break;
                    case 3:
                        AddStudent(studentList);
                        break;
                    default:
                        break;
                }
            } while (userMenuSelection == 1 || userMenuSelection == 2 || userMenuSelection == 3);

            Console.WriteLine("Bye!");
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

        public static void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to our C# class");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - See all students");
            Console.WriteLine("2 - See student info");
            Console.WriteLine("3 - Add student");
            Console.WriteLine("4 - Exit");
            Console.Write("Enter a number: ");

        }

        public static void AddStudent(List<StudentInfo> studentList)
        {
            string userWantsToAddAnotherStudent = null;
            do
            {

                Console.Write("\nEnter name: ");
                string newStudentName = Console.ReadLine();
                Console.Write("Enter hometown: ");
                string newStudentHometown = Console.ReadLine();
                Console.Write("Enter favorite food: ");
                string newStudentFood = Console.ReadLine();
                Console.Write("Enter favorite color: ");
                string newStudentColor = Console.ReadLine();

                if (string.IsNullOrEmpty(newStudentName) || string.IsNullOrEmpty(newStudentHometown) || string.IsNullOrEmpty(newStudentFood) || string.IsNullOrEmpty(newStudentColor))
                {
                    Console.WriteLine("New student not added. All fields must be filled out.");        
                }
                else
                {
                    var newStudent = new StudentInfo { Name = newStudentName, Hometown = newStudentHometown, Food = newStudentFood, Color = newStudentColor };
                    studentList.Add(newStudent);
                    Console.WriteLine($"{newStudent.Name} added.");
                }

                Console.Write("\nDo you want to add another student? y/n: ");
                userWantsToAddAnotherStudent = Console.ReadLine();

            } while (userWantsToAddAnotherStudent.Equals("y", StringComparison.OrdinalIgnoreCase));

        }

        public static void LookUpStudentInfo(List<StudentInfo> studentList)
        {
            Console.Write($"\nWhich student would you like to learn more about? \nEnter 0-{ studentList.Count - 1}: ");
            int studentRequestedByUser = -1;
            int.TryParse(Console.ReadLine(), out studentRequestedByUser);

            try
            {
                Console.Write($"\nWhat do you want to know about {studentList[studentRequestedByUser].Name}? (hometown/food/color): ");
                string userWantsToKnow = Console.ReadLine();

                switch (userWantsToKnow.ToLower())
                {
                    case "hometown":
                        Console.WriteLine($"\n{studentList[studentRequestedByUser].Name}'s hometown is: {studentList[studentRequestedByUser].Hometown}");
                        break;
                    case "food":
                        Console.WriteLine($"\n{studentList[studentRequestedByUser].Name}'s favorite food is: {studentList[studentRequestedByUser].Food}");
                        break;
                    case "color":
                        Console.WriteLine($"\n{studentList[studentRequestedByUser].Name}'s favorite color is: {studentList[studentRequestedByUser].Color}");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn exception has happened. Take cover. \nMessage: {ex.Message}");
                //throw;
            }
 
        }

        public static void DisplayAllStudents(List<StudentInfo> studentList)
        {
            Console.WriteLine("\nStudent List:\n");

            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Name}");
            }
        }

    }
}
