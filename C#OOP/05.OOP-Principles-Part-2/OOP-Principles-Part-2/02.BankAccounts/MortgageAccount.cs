using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentOutOfRangeException("Number of months cannot be negative");
            }

            if (Customer.CustomerType == CustomerType.Individual)
            {
                if (numberOfMonths >= 0 && numberOfMonths <= 6)
                {
                    return 0;
                }
                else
                {
                    return (decimal)(numberOfMonths - 6) * this.InterestRate;
                }
            }
            else //Customer.CustomerType == CustomerType.Company
            {
                if (numberOfMonths >= 0 && numberOfMonths <= 12)
                {
                    return (decimal)(numberOfMonths) * this.InterestRate * 0.5M;
                }
                else
                {
                    return (decimal)(numberOfMonths - 12) * this.InterestRate + 12.0M * this.InterestRate * 0.5M;
                }
            }
        }

    }
}
