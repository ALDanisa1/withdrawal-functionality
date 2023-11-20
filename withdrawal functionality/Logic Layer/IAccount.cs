using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withdrawal_functionality.Logic_Layer
{
    public interface IAccount
    {
        long Id { get; }
        void Withdraw(double amount);
        void Deposit(double amount);
    }
}
