using System;

namespace exercise35
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalArray = new string[] { "cow", "elephant", "jaguar", "horse", "crow" };

            Console.Write("Enter two indcies: ");

            string[] userIndicies = Console.ReadLine().Split(" ");

            Console.WriteLine(userIndicies[0].ToString());
            Console.WriteLine(userIndicies[1].ToString());


            //if (int.TryParse(userIndicies[0] && userIndex >= 0 && userIndex < animalArray.Length)
            //{

            //}


            Console.ReadLine();
        }
    }
}
