using System;

namespace classNotes0605
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsorted = new[] { 8, 72, 37, 16, 2, 24};

            Console.WriteLine(string.Join(",", unsorted));

            Console.WriteLine(string.Join(",", Sort(unsorted)));

            var unsortedString = new[] { "a", "z", "b", "A" };

            Console.WriteLine(string.Join(",", unsortedString));


            Console.WriteLine(string.Join(",", Sort(unsortedString))); //possible because string implements IComparable


            Console.ReadLine();
        }

        public static int[] Sort(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i + 1; j < unsorted.Length; j++)
                {
                    if (unsorted[i] > unsorted[j])
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }
            }

            return unsorted;
        }

        public static T[] Sort<T>(T[] unsorted) where T:IComparable
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i + 1; j < unsorted.Length; j++)
                {
                    if (unsorted[i].CompareTo(unsorted[j]) >= 0)
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }
            }

            return unsorted;
        }
    }
}
