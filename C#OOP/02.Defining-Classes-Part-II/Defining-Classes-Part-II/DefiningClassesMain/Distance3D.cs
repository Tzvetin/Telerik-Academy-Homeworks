using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    public static class Distance3D
    {
        // static method to calculate the distance between two points in the 3D space
        public static double Distance(Point3D pointA, Point3D pointB)
        {
            double differenceX = (pointA.X - pointB.X) * (pointA.X - pointB.X);
            double differenceY = (pointA.Y - pointB.Y) * (pointA.Y - pointB.Y);
            double differenceZ = (pointA.Z - pointB.Z) * (pointA.Z - pointB.Z);
            double distance = Math.Sqrt(differenceX + differenceY + differenceZ);
            return distance;
        }
    }
}
