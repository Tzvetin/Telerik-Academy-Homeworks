/*
Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
*/
using System;

    class SolveTasks
    {
        static int ReverseDigits(int number)
        {
            int reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            return reversed;
        }

        static double Average(int[] arr)
        {
            double average = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                average += arr[i];
            }

            average /= (double)arr.Length;
            return average;
        }

        static double LinearEquation(int a, int b)
        {
            return (-b / (double)a);
        }

        static void Main()
        {
            Console.WriteLine("Please select the task: ");
            Console.WriteLine(" Select 1 to reverse digits");
            Console.WriteLine(" Select 2 to find the average");
            Console.WriteLine(" Select 3 to solve a linear equation");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.Write("Please enter the number: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        Console.WriteLine("Reversed number: {0}", ReverseDigits(num));
                    }
                    else
                    {
                        Console.WriteLine("Number should be positive");
                    }
                    break;

                case 2: Console.Write("How many numbers? ");
                    int count = int.Parse(Console.ReadLine());
                    int[] myArray = new int[count];
                    if (count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Please enter number {0}: ", i);
                            myArray[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Average: {0}", Average(myArray));
                    }
                    else
                    {
                        Console.WriteLine("You must select at least one number");
                    }
                    break;

                case 3: Console.Write("Please enter a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Please enter b: ");
                    int b = int.Parse(Console.ReadLine());
                    if (b > 0)
                    {
                        Console.WriteLine("Solution: {0}", LinearEquation(a, b));
                    }
                    else
                    {
                        Console.WriteLine("b must be positive");
                    }
                    break;

                default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

