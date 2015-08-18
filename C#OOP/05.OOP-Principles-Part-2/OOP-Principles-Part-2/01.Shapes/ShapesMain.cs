/*
Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
    (heightwidth for rectangle and heightwidth/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and 
    implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) 
    stored in an array.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class ShapesMain
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(5, 7),
                new Rectangle(6, 8),
                new Square(9)
            };

            foreach (Shape element in shapes)
            {
                Console.WriteLine("{0}: Surface is {1}", element.GetType().Name, element.CalculateSurface());
            }
        }
    }
}
