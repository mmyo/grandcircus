using System;

namespace classnotes0417
{
    class Program
    {
        static void Main(string[] args)
        {
            //var again = true;
            //while (again)
            //{
            //    Console.Write("Enter number (x to quit): ");
            //    var response = Console.ReadLine();
            //    if (response.Equals("x", StringComparison.OrdinalIgnoreCase))
            //    {
            //        again = false;
            //    }
            //    else
            //    {
            //        var number = int.Parse(response);
            //        Console.WriteLine($"You entered - {number}");
            //    }

            //}

            //Console.Write("Enter number (x to quit): ");
            //var response = Console.ReadLine();
            //int number = 0;



            //if (int.TryParse(response, out number))
            //{
            //    Console.WriteLine($"You entered - {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number");
            //}


            //try
            //{
            //    number = int.Parse(response);
            //}
            //catch (Exception ex)
            //{

            //}
            var input = "Hello";
            string lower;

            var result = IsLowerCase(input, out lower);

            Console.WriteLine();

            Console.ReadKey();
        }

        public static bool IsLowerCase(string input, out string lower)
        {
            lower = input.ToLower();

            return input == lower;
        }
    }
}
