using System;
using System.Text.RegularExpressions;

namespace classnotes0417_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex.IsMatch("123456789", @"^\d{3}-?\d{2}-?\d{4}$"); //@ means string literal 

            Console.WriteLine("Hello World!");
        }
    }
}
