using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Sum_MatrixElements
{
    class SumElements
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            var rows = sizes[0];
            var cols = sizes[1];
            int[,] matrix = new int[rows,cols];
            for (int rowIndex = 0; rowIndex< rows; rowIndex++)
            {
                var colElements = Console.ReadLine().Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                for (int colIndex = 0; colIndex < colElements.Length; colIndex++)
                {
                    matrix[rowIndex, colIndex] = colElements[colIndex];
                }
            }

            var sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum = sum + matrix[i, j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
