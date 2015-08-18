/*
Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
*/
using System;

    class TriangleSurface
    {
        static void Main()
        {
            double altitude = 1.5;
            double a = 2.2;
            double b = 3;
            double c = 2.8;
            double angle = 1;
            double s = 0.5 * (a + b + c);
            Console.WriteLine("Area 1: {0}", 0.5 * a * altitude);
            Console.WriteLine("Area 2: {0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            Console.WriteLine("Area 3: {0}", 0.5 * b * c * Math.Sin(angle));
        }
    }

