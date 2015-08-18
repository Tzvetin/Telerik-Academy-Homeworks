using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Write the circle's radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter is: {0:F2}", 2 * Math.PI * r);
            Console.WriteLine("The area is: {0:F2}", Math.PI * r * r);
        }
    }

