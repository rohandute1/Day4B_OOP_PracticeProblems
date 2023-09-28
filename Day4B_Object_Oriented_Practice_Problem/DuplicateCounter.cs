using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    class DuplicateCounter
    {
        private int[] arr;

        public DuplicateCounter(int[] arr)
        {
            this.arr = arr;
        }

        public int CountDuplicates()
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
