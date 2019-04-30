using System;
using System.Collections.Generic;

namespace classnotes0429
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<string>(); //calling default list constructor

            people.Add("James");
            people.Add("Tom");

            people.Remove("Tom");

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            people.Add(Console.ReadLine());

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            
            Console.ReadLine();
        }
    }
}
