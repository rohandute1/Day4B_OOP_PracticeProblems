using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    class FrequencyCounter
    {
        public int[] CountFrequencies(int[] arr)
        {
            int n = arr.Length;
            int[] frequencies = new int[n];

            for (int i = 0; i < n; i++)
            {
                int count = 1;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        frequencies[j] = -1;
                    }
                }

                if (frequencies[i] != -1)
                    frequencies[i] = count;
            }

            return frequencies;
        }
    }
}
