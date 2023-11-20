using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using withdrawal_functionality.DataBase_Layer;

namespace withdrawal_functionality.Logic_Layer
{
    public class BankService : IAccountService
    {
        private IBankDatabase bankDatabase;

        public BankService(IBankDatabase bankDatabase)
        {
            this.bankDatabase = bankDatabase;
        }

        public void OpenSavingsAccount(long accountId, double amountToDeposit)
        {
            bankDatabase.GetAccount(accountId); // Check if account exists (not necessary for opening)
            bankDatabase.GetAccount(accountId); // Open a savings account
        }

        public void OpenCurrentAccount(long accountId)
        {
            bankDatabase.GetAccount(accountId); // Check if account exists (not necessary for opening)
            bankDatabase.GetAccount(accountId); // Open a current account
        }

        public void Withdraw(long accountId, double amountToWithdraw)
        {
            var account = bankDatabase.GetAccount(accountId);
            if (account != null)
            {
                account.Withdraw(amountToWithdraw);
            }
            else
            {
                throw new AccountNotFoundException($"Account with ID {accountId} not found");
            }
        }

        public void Deposit(long accountId, double amountToDeposit)
        {
            var account = bankDatabase.GetAccount(accountId);
            if (account != null)
            {
                account.Deposit(amountToDeposit);
            }
            else
            {
                throw new AccountNotFoundException($"Account with ID {accountId} not found");
            }
        }
    }
}
