using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_Square_wih_Maximum_Sum
{
    class SuqreMaxSum
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = sizes[0];
            var cols = sizes[1];
            int[,] matrix = new int[rows, cols];
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                var colElements = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int colIndex = 0; colIndex < colElements.Length; colIndex++)
                {
                    matrix[rowIndex, colIndex] = colElements[colIndex];
                }
            }

            var sum = 0;
            var maxElementRow = 0;
            var maxElementCol = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    var curElement = matrix[i, j];
                    var nextElement = matrix[i, j + 1];
                    var thirdElement = matrix[i + 1, j];
                    var fourthElement = matrix[i + 1, j + 1];
                    var curSum = curElement + nextElement + thirdElement + fourthElement;
                    if (curSum > sum)
                    {
                        sum = curSum;
                        maxElementRow = i;
                        maxElementCol = j;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxElementRow, maxElementCol]} {matrix[maxElementRow, maxElementCol + 1]}");
            Console.WriteLine($"{matrix[maxElementRow + 1, maxElementCol]} {matrix[maxElementRow + 1, maxElementCol + 1]}");
            Console.WriteLine(sum);
        }
    }
}
