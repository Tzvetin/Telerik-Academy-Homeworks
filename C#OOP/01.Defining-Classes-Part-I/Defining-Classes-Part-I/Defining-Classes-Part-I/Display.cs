using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public class Display
    {
        // Fields
        private int size;
        private int numberOfColors;

        // Constructors
        public Display() : this(0, 0)
        {
        }
        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        // Properties
        public int Size
        {
            get { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid size! It cannot be negative.");
                }
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of colors! It cannot be negative.");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder displayFullInformation = new StringBuilder();
            displayFullInformation.AppendLine("Display size: " + this.Size);
            displayFullInformation.AppendLine("Display number of colors: " + this.NumberOfColors);
            return displayFullInformation.ToString();
        }
    }
}
