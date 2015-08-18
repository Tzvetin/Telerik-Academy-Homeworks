/*
Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:
x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
*/
using System;

    class AddingPolynomials
    {
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

            int[] result = Addition(firstPolynomial, secondPolynomial);

            Console.Write("Result: ");

            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(result[i]);
                    break;
                }
                if (result[i] != 0)
                {
                    Console.Write(result[i] + "x" + i + " + ");
                }
            }

        }
    }

