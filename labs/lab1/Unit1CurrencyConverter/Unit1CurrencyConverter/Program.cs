using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Unit1CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter first number");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                double secondNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter third number");
                double thirdNumber = double.Parse(Console.ReadLine());

                //calculate average of three numbers
                double averageOfThreeNumbers = (firstNumber + secondNumber + thirdNumber) / 3;
                double totalOfThreeNumbers = firstNumber + secondNumber + thirdNumber;

                Console.WriteLine(); //add a space to make it easier to read

                Console.WriteLine("Here's the average: " + averageOfThreeNumbers);
                Console.WriteLine("Here's the lowest: " + Math.Min(firstNumber, (Math.Min(secondNumber, thirdNumber))));
                Console.WriteLine("Here's the highest: " + Math.Max(firstNumber, (Math.Max(secondNumber, thirdNumber))));

                Console.WriteLine(); //add a space to make it easier to read

                Console.WriteLine("US: " + totalOfThreeNumbers.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //US
                Console.WriteLine("Swedish: " + totalOfThreeNumbers.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));//Swedish
                Console.WriteLine("Japanese: " + totalOfThreeNumbers.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));//Japanese 
                Console.WriteLine("Thai: " + totalOfThreeNumbers.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));//Thai

                Console.ReadLine(); //pause
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something bad happened!");

                Console.WriteLine(ex); //something bad happened

                Console.ReadLine(); //pause
            }


        }
    }
}
