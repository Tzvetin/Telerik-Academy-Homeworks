using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get { return this.start; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Start range cannot be null!");
                }
                else
                {
                    this.start = value;
                }
            }
        }

        public T End
        {
            get { return this.end; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("End range cannot be null!");
                }
                else
                {
                    this.end = value;
                }
            }
        }
    }
}
