using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.Classes = classes;
        }

        public List<Class> Classes
        {
            get { return this.classes; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Classes cannot be null!");
                }
                this.classes = value;
            }
        }
        public override string ToString()
        {
            return string.Format("School classes: {0}", String.Join("; ", classes));
        }
    }
}
