using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using withdrawal_functionality.Logic_Layer;

namespace withdrawal_functionality.DataBase_Layer
{
    public class SystemDB : IBankDatabase
    {
        private static SystemDB instance;
        private Dictionary<long, IAccount> accounts;

        private SystemDB()
        {
            accounts = new Dictionary<long, IAccount>();
            // Prepopulate the database
            accounts.Add(1, new SavingsAccount(1, 2000));
            accounts.Add(2, new SavingsAccount(2, 5000));
            accounts.Add(3, new CurrentAccount(3, 10000));
            accounts.Add(4, new CurrentAccount(4, 20000));
        }

        public static SystemDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SystemDB();
                }
                return instance;
            }
        }

        public IAccount GetAccount(long accountId)
        {
            if (accounts.ContainsKey(accountId))
            {
                return accounts[accountId];
            }
            return null;
        }
    }
}
