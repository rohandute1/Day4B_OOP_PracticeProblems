using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    class MatrixSumCalculator
    {
        private int[,] matrix;
        public MatrixSumCalculator(int rows, int columns)
        {
            matrix = new int[rows, columns];
        }

        public void InputMatrix()
        {
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Enter element at position ({i + 1}, {j + 1}): ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void CalculateAndPrintRowSums()
        {
            Console.WriteLine("Sum of each row:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }
                Console.WriteLine($"Row {i + 1}: {rowSum}");
            }
        }
    }
}
