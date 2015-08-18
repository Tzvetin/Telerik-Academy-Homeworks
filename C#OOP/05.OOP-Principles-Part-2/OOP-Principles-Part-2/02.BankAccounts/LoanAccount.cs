using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
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
                if (numberOfMonths >= 0 && numberOfMonths <= 3)
                {
                    return 0;
                }
                else
                {
                    return (decimal)(numberOfMonths - 3) * this.InterestRate;
                }
            }
            else //Customer.CustomerType == CustomerType.Company
            {
                if (numberOfMonths >= 0 && numberOfMonths <= 2)
                {
                    return 0;
                }
                else
                {
                    return (decimal)(numberOfMonths - 2) * this.InterestRate;
                }
            }
        }

    }
}
