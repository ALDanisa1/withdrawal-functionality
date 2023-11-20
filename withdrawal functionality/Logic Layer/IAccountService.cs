using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withdrawal_functionality.Logic_Layer
{
    public interface IAccountService
    {
        void OpenSavingsAccount(long accountId, double amountToDeposit);
        void OpenCurrentAccount(long accountId);
        void Withdraw(long accountId, double amountToWithdraw);
        void Deposit(long accountId, double amountToDeposit);
    }
}
