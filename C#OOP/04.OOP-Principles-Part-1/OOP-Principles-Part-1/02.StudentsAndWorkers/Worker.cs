using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;
        private const int workingDays = 5;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary cannot be negative");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day cannot be negative or more than 24");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return (double)((this.weekSalary) / ((double)workingDays * workHoursPerDay)); 
        }
    }
}
