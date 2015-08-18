using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClassesMain
{
    public static class PathStorage
    {
        //static method to save paths to a text file
        public static void SavePaths(Path path, string fileLocation)
        {
            StreamWriter writer = new StreamWriter(fileLocation);
            using (writer)
            {
                foreach (var item in path.PathList)
                {
                    writer.WriteLine(item);
                }
            }
        }
        // static method to load paths from a text file
        public static Path LoadPaths(string fileLocation)
        {
            StreamReader reader = new StreamReader(fileLocation);
            Path result = new Path();
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] coordinatesAsStrings = line.Split(new char[] { ',', '{', '}', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] coordinates = new int[coordinatesAsStrings.Length];
                    for (int i = 0; i < coordinatesAsStrings.Length; i++)
                    {
                        coordinates[i] = int.Parse(coordinatesAsStrings[i]); 
                    }
                    result.PathList.Add(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                }
                if (result.PathList == null)
                {
                    throw new InvalidDataException("The file doesn't contain any path information");
                }
                return result;
            }
        }
    }
}
