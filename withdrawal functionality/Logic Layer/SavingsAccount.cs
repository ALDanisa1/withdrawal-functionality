using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withdrawal_functionality.Logic_Layer
{
    // Business Entities
    public class SavingsAccount : IAccount
    {
        public long Id { get; }
        private double balance;

        public SavingsAccount(long id, double initialBalance)
        {
            Id = id;
            if (initialBalance >= 1000)
            {
                balance = initialBalance;
            }
            else
            {
                throw new ArgumentException("Savings account must be opened with at least R1000.00");
            }
        }

        public void Withdraw(double amount)
        {
            if (balance - amount >= 1000)
            {
                balance -= amount;
            }
            else
            {
                throw new WithdrawalAmountTooLargeException("Withdrawal amount too large for Savings Account");
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
