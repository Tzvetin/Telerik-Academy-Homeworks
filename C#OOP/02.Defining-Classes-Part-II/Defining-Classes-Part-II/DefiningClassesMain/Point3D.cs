using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    // structure to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space
    public struct Point3D
    {
        //Field
        // hold the start of the coordinate system – the point O{0, 0, 0}.
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        //Constructors
        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        // hold the start of the coordinate system – the point O{0, 0, 0}.
        public static Point3D PointO
        {
            get { return pointO; }
        }

        //Methods
        //  printing a 3D point
        public override string ToString()
        {
            string result = "{" + X + ", " + Y + ", " + Z + "}";
            return result;
        }
    }
}
