using System;

    class PointInACircle
    {
        static void Main()
        {
            Console.Write("Enter x of the point: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y of the point: ");
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("The distance from the centre is {0}", distance);
            bool insideTheCircle;
            if (distance <= 2)
            {
                insideTheCircle = true;
            }
            else
            {
                insideTheCircle = false;
            }
            Console.WriteLine("Is the point ({0}, {1}) inside the circle? -> {2}", x, y, insideTheCircle);
        }
    }

