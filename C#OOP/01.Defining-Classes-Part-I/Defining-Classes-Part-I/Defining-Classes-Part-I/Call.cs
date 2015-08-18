using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public class Call
    {
        // Fields
        private DateTime dateAndTime;
        private string dialedNumber;
        private int duration;

        // Constructor
        public Call(DateTime dateAndTime, string dialedNumber, int duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        // Properties
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }
        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set
            {
            if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid number!");
                }
                this.dialedNumber = value;
            }
        }
        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid duration! It cannot be negative.");
                }
                this.duration = value;
            }
        }
    }
}
