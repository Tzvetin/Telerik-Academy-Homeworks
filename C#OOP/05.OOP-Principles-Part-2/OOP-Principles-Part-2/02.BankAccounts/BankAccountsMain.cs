/*
A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). 
In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and 
    implement the calculation of the interest functionality through overridden methods.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class BankAccountsMain
    {
        static void Main(string[] args)
        {
            DepositAccount peshoAccount = new DepositAccount(new Customer(CustomerType.Individual, "Pesho Peshev"), 500M, 2.3M);
            DepositAccount killersAccount = new DepositAccount(new Customer(CustomerType.Company, "Killers"), 1500M, 2.3M);
            peshoAccount.Deposit(250M);
            killersAccount.Withdraw(250M);
            Console.WriteLine("DEPOSIT ACCOUNTS TEST");
            Console.WriteLine("Balance: {0:C}", peshoAccount.Balance);
            Console.WriteLine("Balance: {0:C}", killersAccount.Balance);
            Console.WriteLine("Interest: {0:F2} %", peshoAccount.CalculateInterestAmount(3));
            Console.WriteLine("Interest: {0:F2} %", killersAccount.CalculateInterestAmount(4));
            Console.WriteLine();

            LoanAccount goshoAccount = new LoanAccount(new Customer(CustomerType.Individual, "Gosho Goshev"), 300M, 2.3M);
            LoanAccount leadersAccount = new LoanAccount(new Customer(CustomerType.Company, "Leaders"), 3000M, 2.3M);
            goshoAccount.Deposit(250M);
            leadersAccount.Deposit(250M);
            Console.WriteLine("LOAN ACCOUNTS TEST");
            Console.WriteLine("Balance: {0:C}", goshoAccount.Balance);
            Console.WriteLine("Balance: {0:C}", leadersAccount.Balance);
            Console.WriteLine("Interest: {0:F2} %", goshoAccount.CalculateInterestAmount(4));
            Console.WriteLine("Interest: {0:F2} %", leadersAccount.CalculateInterestAmount(4));
            Console.WriteLine();

            MortgageAccount mimiAccount = new MortgageAccount(new Customer(CustomerType.Individual, "Maria Petrova"), 200M, 2.3M);
            MortgageAccount deadboysAccount = new MortgageAccount(new Customer(CustomerType.Company, "Dead Boys"), 23000M, 2.3M);
            mimiAccount.Deposit(250M);
            deadboysAccount.Deposit(250M);
            Console.WriteLine("MORTGAGE ACCOUNTS TEST");
            Console.WriteLine("Balance: {0:C}", mimiAccount.Balance);
            Console.WriteLine("Balance: {0:C}", deadboysAccount.Balance);
            Console.WriteLine("Interest: {0:F2} %", mimiAccount.CalculateInterestAmount(8));
            Console.WriteLine("Interest: {0:F2} %", deadboysAccount.CalculateInterestAmount(18));
            Console.WriteLine();
        }
    }
}
