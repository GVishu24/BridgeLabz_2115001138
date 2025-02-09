using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("General Bank Account");
        }
    }

    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }
    }

    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit { get; set; }

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
        }
    }

    class FixedDepositAccount : BankAccount
    {
        public int MaturityPeriod { get; set; } // in months

        public FixedDepositAccount(string accountNumber, double balance, int maturityPeriod)
            : base(accountNumber, balance)
        {
            MaturityPeriod = maturityPeriod;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account");
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount savings = new SavingsAccount("SA12345", 5000.00, 3.5);
            BankAccount checking = new CheckingAccount("CA67890", 2000.00, 1000.00);
            BankAccount fixedDeposit = new FixedDepositAccount("FD11223", 10000.00, 12);

            savings.DisplayAccountType();
            checking.DisplayAccountType();
            fixedDeposit.DisplayAccountType();
        }
    }
}
