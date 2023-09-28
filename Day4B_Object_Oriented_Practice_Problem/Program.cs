﻿using System;
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
                Console.WriteLine("1.Duplicate Counter\n");
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
