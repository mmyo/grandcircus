using System;
using System.IO;

namespace classnotes0509_fileio
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("C:\\SomeFile.txt"))
            {
                Console.WriteLine("This file exists");
            }

            File.WriteAllText("SomeFile.txt", "hello");

            var writer = new StreamWriter("SomeStreamFile.txt");

            writer.WriteLine("Hello");
            writer.WriteLine("World");
            writer.Flush();

            Console.WriteLine("Hello World!");
        }
    }
}
