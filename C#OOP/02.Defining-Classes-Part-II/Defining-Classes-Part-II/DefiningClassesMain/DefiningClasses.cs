using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    [VersionAttribute("2", "11")]
    class DefiningClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********");
            Console.WriteLine("POINT 3D:");
            Console.WriteLine("*********");
            Point3D testPoint1 = new Point3D(5, 6, 7);
            Point3D testPoint2 = new Point3D(6, 7, 9);
            Console.WriteLine("Point1: {0}", testPoint1);
            Console.WriteLine("Point2: {0}", testPoint2);
            Console.WriteLine("Distance: {0}", Distance3D.Distance(testPoint1, testPoint2));
            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine("GENERIC CLASS:");
            Console.WriteLine("**************");
            GenericList<int> testList = new GenericList<int>(2);
            testList.AddElement(1);
            testList.AddElement(2);
            testList.AddElement(3);
            testList.AddElement(4);
            testList.AddElement(5);
            testList.InsertElementAtGivenPosition(6, 1);
            testList.RemoveElementByIndex(0);
            Console.WriteLine(testList);
            Console.WriteLine("Position of 4: {0}", testList.FindElementByValue(4));
            Console.WriteLine("Max element: {0}", testList.Max());
            Console.WriteLine("Min element: {0}", testList.Min());
            Console.WriteLine("Count: {0}", testList.Count);
            Console.WriteLine("Capacity: {0}", testList.Capacity);
            testList.ClearList();
            testList.AddElement(800);
            Console.WriteLine(testList);
            Console.WriteLine();
            Console.WriteLine("*************");
            Console.WriteLine("MATRIX CLASS:");
            Console.WriteLine("*************");
            Matrix<int> m1 = new Matrix<int>(3, 3);
            Matrix<int> m2 = new Matrix<int>(3, 3);
            // Fill with random numbers
            Random randomGenerator = new Random();
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    m1[i, j] = randomGenerator.Next(20);
                    m2[i, j] = randomGenerator.Next(20);
                }
            }
            Console.WriteLine("Matrix 1");
            Console.WriteLine(m1);
            Console.WriteLine("Matrix 2");
            Console.WriteLine(m2);
            Console.WriteLine("Matrix 1 + Matrix 2");
            Console.WriteLine(m1 + m2);
            Console.WriteLine("Matrix 1 - Matrix 2");
            Console.WriteLine(m1 - m2);
            Console.WriteLine("Matrix 1 * Matrix 2");
            Console.WriteLine(m1 * m2);

            Console.WriteLine("******************");
            Console.WriteLine("VERSION ATTRIBUTE:");
            Console.WriteLine("******************");
            Type type = typeof(DefiningClasses);
            object[] allCustomAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attribute in allCustomAttributes)
            {
                Console.WriteLine("Current version is: {0}", attribute.FullVersion);
            }
        }
    }
}
