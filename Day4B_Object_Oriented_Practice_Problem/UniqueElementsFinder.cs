using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    class UniqueElementsFinder
    {
        public int[] FindUniqueElements(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[0];

            int[] uniqueElements = new int[arr.Length];
            int uniqueCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueElements[uniqueCount] = arr[i];
                    uniqueCount++;
                }
            }

            Array.Resize(ref uniqueElements, uniqueCount);

            return uniqueElements;
        }
    }
}
