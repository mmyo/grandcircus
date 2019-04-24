using System;

namespace classnotes0422_two_dimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] perfectTwoDArry = new int[3,2]; // columns of length 3 and rows of length 2
            perfectTwoDArry[0, 0] = 1;

            int acc = 0;
            for (int row = 0; row < perfectTwoDArry.GetLength(0); row++)
            {
                for (int column = 0; column < perfectTwoDArry.GetLength(1); column++) //get next dimension's length
                {
                    perfectTwoDArry[row, column] = acc;
                    acc++;
                }
            }

            int[][] jaggedArry = new int[][] { new int[2], new int [2], new int [2], new int [3] }; //jagged array, [][] represents two dimensional

            var accTwo = 0;
            for (int row = 0; row < jaggedArry.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedArry[row].Length; col++)
                {
                    jaggedArry[row][col] = accTwo;
                    accTwo++;
                }
            }

            foreach (var row in jaggedArry)
            {
                foreach (var col in row)
                {
                    Console.WriteLine($"{col}");
                }
            }



            Console.ReadLine();
        }
    }
}
