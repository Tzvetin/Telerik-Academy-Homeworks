using System;
//Write an expression that checks for given point (x, y) if it is 
//within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
    class InsideCircleOutsideOfRectangle
    {
        static void Main()
        {
            bool insideCircleOutsideRectangle = false;
            Console.Write("Enter x of the point: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y of the point: ");
            double y = double.Parse(Console.ReadLine());
            
                if ((x >= -1) && (x <= 5) && (y >= -1) && (y <= 1))
                {
                    Console.WriteLine("The point is inside the rectangle!");
                }
                else
                {
                    double distance = Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)));
                    Console.WriteLine("The distance to the centre of the circle is {0}", distance);
                    if (distance <= 1.5)
                    {
                        insideCircleOutsideRectangle = true;
                        Console.WriteLine("The point is inside the circle and outside the rectangle");
                    }
                    else
                    {
                        Console.WriteLine("The point is outside the circle and outside the rectangle");
                    }
                }
            Console.WriteLine("Is the point ({0},{1}) inside the circle and out of the rectangle?: {2}", x, y, insideCircleOutsideRectangle);
            
        }
    }

