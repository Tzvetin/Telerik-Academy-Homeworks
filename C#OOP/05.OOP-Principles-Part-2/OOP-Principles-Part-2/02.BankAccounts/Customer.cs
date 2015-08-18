using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class Customer
    {
        private CustomerType customerType;
        private string fullName;

        public Customer(CustomerType type, string name)
        {
            this.CustomerType = type;
            this.FullName = name;
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            private set { this.customerType = value; }
        }
        
        public string FullName
        {
            get { return this.fullName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.fullName = value;
            }
        }
    }
}
