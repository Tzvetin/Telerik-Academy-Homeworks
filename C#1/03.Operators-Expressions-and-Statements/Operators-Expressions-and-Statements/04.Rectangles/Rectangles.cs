using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter the rectangle width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the rectangle height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("The rectangle perimeter is: {0}", 2 * (width + height));
            Console.WriteLine("The rectangle area is: {0}", width * height);
        }
    }

