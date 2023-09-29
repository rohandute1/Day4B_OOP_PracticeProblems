using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    class ArrayMinMaxFinder
    {
        public int FindMax(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Array is empty or null.");
                return int.MinValue; 
            }

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public int FindMin(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Array is empty or null.");
                return int.MaxValue;
            }

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
