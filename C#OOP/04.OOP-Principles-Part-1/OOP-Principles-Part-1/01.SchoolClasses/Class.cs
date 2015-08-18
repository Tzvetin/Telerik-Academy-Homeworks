using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Class : Comment
    {
        private string textIdentifier;
        private List<Teacher> setOfTeachers;
        private static HashSet<string> textIdentifiers;

        static Class()
        {
            textIdentifiers = new HashSet<string>();
        }

        public Class(string textIdentifier, List<Teacher> setOfTeachers)
        {
            this.TextIdentifier = textIdentifier;
            this.setOfTeachers = setOfTeachers;
        }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class identifier cannot be null or empty");
                }
                if (textIdentifiers.Contains(value))
                {
                    throw new ArgumentException("Text identifier already used");
                }
                this.textIdentifier = value;
                textIdentifiers.Add(value);
            }
        }

        public List<Teacher> SetOfTeachers
        {
            get { return this.setOfTeachers; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Teachers cannot be null!");
                }
                this.setOfTeachers = value;
            }
        }
       
        public override string ToString()
        {
            return string.Format("Class: {0} - {1}", this.TextIdentifier, String.Join("; ", setOfTeachers));
        }
    }
}
