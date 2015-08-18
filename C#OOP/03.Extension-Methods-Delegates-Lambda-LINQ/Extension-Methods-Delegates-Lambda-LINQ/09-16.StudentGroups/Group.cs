using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16.StudentGroups
{
    //Problem 16.* Groups
    //Create a class Group with properties GroupNumber and DepartmentName.
    class Group
    {
        // Fields
        private int groupNumber;
        private string departmentName;

        // Constructor
        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        // Properties
        public int GroupNumber
        {
            get { return this.groupNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Group number cannot be negative or zero!");
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }

        public string DepartmentName
        {
            get { return this.departmentName; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Department name cannot be null!");
                }
                else
                {
                    this.departmentName = value;
                }
            }
        }
    }
}
