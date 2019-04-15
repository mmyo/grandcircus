using System;
using System.Text;

namespace classnotes0411
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = "hi";

            Console.WriteLine(a1);

            string a2 = $"{a1} again"; //string interpolation

            Console.WriteLine(a2);

            string a3 = "Hello";
            string a4 = "hello";

            Console.WriteLine("Equals " + a3.Equals(a4, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Compare " + string.Compare(a3, a4, true));
            //1 = right value greater, 0 = same, -1 = left value greater 

            Console.WriteLine(a4.IndexOf('l'));
            Console.WriteLine(a4.Trim());

            StringBuilder builder = new StringBuilder();
            builder.Append("Hello ");
            builder.Append("World");
            Console.WriteLine(builder.ToString());


            Console.ReadKey();
        }
    }
}
