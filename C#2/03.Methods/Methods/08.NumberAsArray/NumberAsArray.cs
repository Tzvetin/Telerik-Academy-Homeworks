/*
Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
 the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/
using System;
using System.Collections.Generic;

    class NumberAsArray
    {
        static List<int> AddArrays(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            int carry = 0;
            int currentDigit = 0;

            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                if (i < a.Length && i >= b.Length)
                {
                    currentDigit = a[i] + carry;
                }
                else if (i >= a.Length && i > b.Length)
                {
                    currentDigit = b[i] + carry;
                }
                else // if (i < a.Length && i < b.Length)
                {
                    currentDigit = a[i] + b[i] + carry;
                }
                carry = currentDigit / 10;
                result.Add(currentDigit % 10);
            }

            if (carry == 1)
            {
                result.Add(1);
            }
            return result;
        }

        static void Main()
        {
            int[] a = new int[] { 4, 6, 7, 3, 4, 1 };
            int[] b = new int[] { 5, 1, 0, 9, 6 };

            List<int> sum = new List<int>();
            sum = AddArrays(a, b);

            for (int index = sum.Count - 1; index >= 0; index--)
            {
                Console.Write(sum[index]);
            }
            Console.WriteLine();
        }
    }

