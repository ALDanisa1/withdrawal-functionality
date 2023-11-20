using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withdrawal_functionality.Logic_Layer
{
    // Business Exceptions
    public class WithdrawalAmountTooLargeException : Exception
    {
        public WithdrawalAmountTooLargeException(string message) : base(message)
        {
        }
    }

    public class AccountNotFoundException : Exception
    {
        public AccountNotFoundException(string message) : base(message)
        {
        }
    }
}
