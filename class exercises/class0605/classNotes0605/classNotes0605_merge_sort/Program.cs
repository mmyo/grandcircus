using System;
using System.Collections.Generic;

namespace classNotes0605_merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }

        public static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 0)
            {
                return unsorted;
            }

            var middle = unsorted.Count / 2;

            var left = new List<int>();
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            var right = new List<int>();
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return MergeSort(left, right);
        }

        private static List<int> MergeSort(List<int>, List<int>)
        {

        }
    }
}
