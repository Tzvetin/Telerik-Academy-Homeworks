using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Teacher : Person
    {
        private List<Discipline> setOfDisciplines;

        public Teacher(string name, List<Discipline> setOfDisciplines)
            : base(name)
        {
            this.SetOfDisciplines = setOfDisciplines;
        }

        public List<Discipline> SetOfDisciplines
        {
            get { return this.setOfDisciplines; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Discipline cannot be null!");
                }
                this.setOfDisciplines = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Teacher: {0} - Disciplines: {1}", this.Name, String.Join("; ", setOfDisciplines));
        }
    }
}
