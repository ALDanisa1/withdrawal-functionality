using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withdrawal_functionality.Logic_Layer
{
    public class CurrentAccount : IAccount
    {
        public long Id { get; }
        private double balance;
        private double overdraftLimit;

        public CurrentAccount(long id, double overdraftLimit)
        {
            Id = id;
            this.overdraftLimit = overdraftLimit;
        }

        public void Withdraw(double amount)
        {
            if (balance - amount >= -overdraftLimit)
            {
                balance -= amount;
            }
            else
            {
                throw new WithdrawalAmountTooLargeException("Withdrawal amount too large for Current Account");
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
