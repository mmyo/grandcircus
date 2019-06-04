using System;
using System.Collections;
using System.Collections.Generic;

namespace classexercise0603
{
    public class Program
    {
        static void Main(string[] args)
        {

            var myList = new List<int>();

            var myArrayList = new ArrayList();
            myArrayList.Add(56);
            myArrayList.Add("hello");

            //var value = (int)myArrayList[1];

            // List
            var list = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"List capacity: {list.Capacity}, count: {list.Count}");
                list.Add($"{i}");
            }

            var intArray = new int[5];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
                Console.WriteLine($"Array length: {intArray.Length}");
            }

            var intArray2 = new int[10];
            intArray2 = intArray;
            intArray2[6] = 1;
            Console.WriteLine(intArray2.Length);

            //Console.WriteLine($"Default list size: {list.Capacity}");

            // remove by value
            list.Remove("2");

            // remove by index
            list.RemoveAt(1);

            // list contains, returns boolean
            list.Contains("2");

            //add range
            var test = new string[2];
            list.AddRange(test);
            var test2 = new List<string>();
            list.AddRange(test2);

            Console.ReadLine();
        }
    }
}
