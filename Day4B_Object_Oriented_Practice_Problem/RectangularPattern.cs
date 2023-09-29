using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    class RectangularPattern
    {
        private int height;
        private int width;

        public RectangularPattern(int h, int w)
        {
            height = h;
            width = w;
        }

        public void PrintPattern()
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (i == 1 || i == height || j == 1 || j == width)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
