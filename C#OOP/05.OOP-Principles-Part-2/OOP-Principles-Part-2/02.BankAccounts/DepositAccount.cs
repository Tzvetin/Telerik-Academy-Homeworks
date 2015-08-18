using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentOutOfRangeException("Number of months cannot be negative");
            }
            if (base.Balance >= 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            { 
                return (decimal)numberOfMonths * this.InterestRate;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Withdraw amount cannot be negative");
            }
            if (amount > this.Balance)
            {
                throw new ArgumentException("There are not enough money in the account");
            }
            this.Balance -= amount;
        }
    }
}
