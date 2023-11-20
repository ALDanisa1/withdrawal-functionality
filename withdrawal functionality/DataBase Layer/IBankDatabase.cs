using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using withdrawal_functionality.Logic_Layer;

namespace withdrawal_functionality.DataBase_Layer
{
    // Database Interfaces
    public interface IBankDatabase
    {
        IAccount GetAccount(long accountId);
    }
}
