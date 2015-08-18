//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;

    class SubtractingPolynomials
    {
        static int[] Multiplication(int[] first, int[] second)
        {
            int biggestPower = (first.Length - 1) * (second.Length - 1);
            int[] result = new int[biggestPower];

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    int power = i + j;
                    result[power] += first[i] * second[j];
                }
            }
            return result;
        }

        static int[] Substraction(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] result;

            if (firstPolynomial.Length < secondPolynomial.Length)
            {
                result = new int[secondPolynomial.Length];

                for (int i = 0; i < firstPolynomial.Length; i++)
                {
                    result[i] = firstPolynomial[i] - secondPolynomial[i];
                }
                
                for (int i = firstPolynomial.Length; i < secondPolynomial.Length; i++)
                {
                    result[i] = secondPolynomial[i] * (-1);
                }
            }
            else
            {
                result = new int[firstPolynomial.Length];

                for (int i = 0; i < secondPolynomial.Length; i++)
                {
                    result[i] = firstPolynomial[i] - secondPolynomial[i];
                }
                
                for (int i = secondPolynomial.Length; i < firstPolynomial.Length; i++)
                {
                    result[i] = firstPolynomial[i];
                }
            }
            return result;
        }

        static int[] Addition(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] result;

            if (firstPolynomial.Length < secondPolynomial.Length)
            {
                result = new int[secondPolynomial.Length];

                for (int i = 0; i < firstPolynomial.Length; i++)
                {
                    result[i] = firstPolynomial[i] + secondPolynomial[i];
                }
                
                for (int i = firstPolynomial.Length; i < secondPolynomial.Length; i++)
                {
                    result[i] = secondPolynomial[i];
                }
            }
            else
            {
                result = new int[firstPolynomial.Length];

                for (int i = 0; i < secondPolynomial.Length; i++)
                {
                    result[i] = firstPolynomial[i] + secondPolynomial[i];
                }
                
                for (int i = secondPolynomial.Length; i < firstPolynomial.Length; i++)
                {
                    result[i] = firstPolynomial[i];
                }
            }
            return result;
        }

        static string ReturnPositiveSign(int[] array, int i)
        {
            if (array[i] > 0 && array.Length - 1 != i)
            {
                string signPlus = "+";
                return signPlus;
            }
            else
            {
                return string.Empty;
            }
        }

        static void PrintResult(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != 0)
                {
                    if (i != 0 && i != 1)
                    {
                        Console.Write(" {2}{0}x^{1}", array[i], i, ReturnPositiveSign(array, i));
                    }
                    else if (i == 1)
                    {
                        Console.Write(" {1}{0}x", array[i], ReturnPositiveSign(array, i));
                    }
                    else if (i == 0)
                    {
                        Console.Write(" {1}{0}", array[i], ReturnPositiveSign(array, i));
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Enter length of first polynomial: ");
            int firstLength = int.Parse(Console.ReadLine());

            int[] firstPolynomial = new int[firstLength];

            for (int i = 0; i < firstLength; i++)
            {
                Console.Write("Enter coefficient for x{0}: ", i);
                firstPolynomial[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter length of second polynomial: ");
            int secondLength = int.Parse(Console.ReadLine());

            int[] secondPolynomial = new int[secondLength];

            for (int i = 0; i < secondLength; i++)
            {
                Console.Write("Enter coefficient for x{0}: ", i);
                secondPolynomial[i] = int.Parse(Console.ReadLine());
            }

            int[] result = Substraction(firstPolynomial, secondPolynomial);
            PrintResult(result);

            int[] result2 = Multiplication(firstPolynomial, secondPolynomial);
            PrintResult(result2);
        }
    }

