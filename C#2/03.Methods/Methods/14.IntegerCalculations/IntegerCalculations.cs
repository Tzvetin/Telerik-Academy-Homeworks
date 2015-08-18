/*
Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
*/
using System;

    class IntegerCalculations
    {
        static int CalcMin(params int[] elements)
        {
            int min = Int32.MaxValue;
            foreach (int element in elements)
            {
                if (element < min)
                { 
                    min = element;
                }
            }
            return min;
        }

        static int CalcMax(params int[] elements)
        {
            int max = Int32.MinValue;
            foreach (int element in elements)
            {
                if (element > max)
                { 
                    max = element; 
                }
            }
            return max;
        }

        static double CalcAverage(params int[] elements)
        {
            double average = 0;
            int count = 0;
            foreach (int element in elements)
            {
                average += element;
                count++;
            }
            return average / (double)count;
        }

        static long CalcSum(params int[] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            { 
                sum += element; 
            }
            return sum;
        }

        static long CalcProduct(params int[] elements)
        {
            long product = 1;
            foreach (int element in elements)
            { 
                product *= element; 
            }
            return product;
        }

        static void Main()
        {
            Console.WriteLine(CalcProduct(2, 5, 8));
            Console.WriteLine(CalcSum(2, 5));
            Console.WriteLine(CalcAverage(4, 0, -2, 12));
            Console.WriteLine(CalcMax(-4, 5, 9));
            Console.WriteLine(CalcMin(-4, 5, 9));
        }
    }
