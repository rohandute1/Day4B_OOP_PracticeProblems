using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    class DigitSumCalculate
    {
        public int CalculateDigitSum(int number)
        {
            int sum = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;

                sum += digit;

                number /= 10;
            }

            return sum;
        }
    }
}
