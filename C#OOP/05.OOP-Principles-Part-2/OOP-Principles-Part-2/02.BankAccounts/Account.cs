using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class Account : IDeposit
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer canno be null");
                }
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be negative");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentOutOfRangeException("Number of months cannot be negative");
            }
            return (decimal)numberOfMonths * this.InterestRate;
        }

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit amount cannot be negative");
            }
            this.Balance += amount;
        }
    }
}
