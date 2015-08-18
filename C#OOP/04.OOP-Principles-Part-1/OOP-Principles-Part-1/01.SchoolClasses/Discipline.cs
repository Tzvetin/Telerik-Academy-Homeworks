using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Discipline : Comment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;
        
        public Discipline(string disciplineName, int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string DisciplineName
        { 
            get { return this.disciplineName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline name cannot be null or empty");
                }
                this.disciplineName = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercises cannot be negative");
                }
                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - lectures: {1}, exercises: {2}", this.DisciplineName, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
