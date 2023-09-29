using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 4B OOP's Practice Problems.");
            bool continueExecution = true;
            while (continueExecution)
            {
                Console.WriteLine("Please choose program which you want to perform.");
                Console.WriteLine("" +
                    "1.Duplicate Counter.\n" +
                    "2.Unique element finder.\n" +
                    "3.Frequency counter.\n" +
                    "4.Max and Min Finder.\n" +
                    "5.Print reverse right-angled triangle pattern.\n" +
                    "6.Print Hollow-Rectangular Pattern.\n" +
                    "7.Reverse each word of given array.\n" +
                    "8.Calculate sum of all digits of given number.\n" +
                    "9.Calculate sun of all row of matrix.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.Write("Enter the number of elements in the array: ");
                        int n = int.Parse(Console.ReadLine());

                        int[] arr = new int[n];
                        Console.WriteLine("Enter the elements of the array:");

                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = int.Parse(Console.ReadLine());
                        }

                        DuplicateCounter counter = new DuplicateCounter(arr);
                        int duplicateCount = counter.CountDuplicates();

                        Console.WriteLine($"Total number of duplicate elements: {duplicateCount}");
                        break;

                    case 2:
                        Console.Write("Enter the number of elements in the array: ");
                        int num = int.Parse(Console.ReadLine());

                        int[] ar = new int[num];
                        Console.WriteLine("Enter the elements:");

                        for (int i = 0; i < num; i++)
                        {
                            ar[i] = int.Parse(Console.ReadLine());
                        }

                        UniqueElementsFinder finder = new UniqueElementsFinder();
                        int[] uniqueElements = finder.FindUniqueElements(ar);

                        Console.WriteLine("Unique elements in the array:");
                        foreach (int element in uniqueElements)
                        {
                            Console.WriteLine(element);
                        }
                        break;

                    case 3:
                        Console.Write("Enter the number of elements in the array: ");
                        int number = int.Parse(Console.ReadLine());

                        int[] a = new int[number];
                        Console.WriteLine("Enter the elements of the array:");

                        for (int i = 0; i < number; i++)
                        {
                            Console.Write($"Element {i + 1}: ");
                            a[i] = int.Parse(Console.ReadLine());
                        }

                        FrequencyCounter count = new FrequencyCounter();
                        int[] frequencies = count.CountFrequencies(a);

                        Console.WriteLine("\nElement Frequencies:");
                        for (int i = 0; i < number; i++)
                        {
                            if (frequencies[i] != -1)
                            {
                                Console.WriteLine($"{a[i]} occurs {frequencies[i]} times.");
                            }
                        }
                        break;

                    case 4:
                        Console.Write("Enter the number of elements in the array: ");
                        int x = int.Parse(Console.ReadLine());

                        int[] array = new int[x];
                        Console.WriteLine($"Enter {x} elements:");

                        for (int i = 0; i < x; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine());
                        }

                        ArrayMinMaxFinder find = new ArrayMinMaxFinder();
                        int max = find.FindMax(array);
                        int min = find.FindMin(array);

                        if (max != int.MinValue)
                        {
                            Console.WriteLine($"Maximum element: {max}");
                        }

                        if (min != int.MaxValue)
                        {
                            Console.WriteLine($"Minimum element: {min}");
                        }
                        break;

                    case 5:
                        Console.Write("Enter the number of rows: ");
                        int p = Convert.ToInt32(Console.ReadLine());

                        TriangularPattern patternPrinter = new TriangularPattern();
                        patternPrinter.PrintPattern(p);
                        break;

                    case 6:
                        Console.Write("Enter the height of the pattern: ");
                        int height = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the width of the pattern: ");
                        int width = Convert.ToInt32(Console.ReadLine());

                        RectangularPattern patternPrint = new RectangularPattern(height, width);
                        patternPrint.PrintPattern();
                        break;

                    case 7:
                        Console.WriteLine("Enter a string:");
                        string input = Console.ReadLine();

                        WordReverser wordReverser = new WordReverser();
                        string reversedString = wordReverser.ReverseWords(input);

                        Console.WriteLine("Reversed string:");
                        Console.WriteLine(reversedString);
                        break;

                    case 8:
                        Console.Write("Enter a number: ");
                        int inputNumber = Convert.ToInt32(Console.ReadLine());

                        DigitSumCalculate calculator = new DigitSumCalculate();

                        int sumOfDigits = calculator.CalculateDigitSum(inputNumber);

                        Console.WriteLine($"Sum of digits: {sumOfDigits}");
                        break;

                    case 9:
                        Console.Write("Enter the number of rows: ");
                        int rows = int.Parse(Console.ReadLine());

                        Console.Write("Enter the number of columns: ");
                        int columns = int.Parse(Console.ReadLine());

                        MatrixSumCalculator matrixSumCalculator = new MatrixSumCalculator(rows, columns);

                        matrixSumCalculator.InputMatrix();
                        matrixSumCalculator.CalculateAndPrintRowSums();
                        break;
                }
                Console.WriteLine("Do you want to continue (yes or no)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }
            Console.ReadLine();
        }
    }
}
