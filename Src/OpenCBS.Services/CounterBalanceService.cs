using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Enums;
using OpenCBS.Shared;
using OpenCBS.Manager;

namespace OpenCBS.Services
{
    public class CounterBalanceService
    {
        
        private readonly CounterBalanceManager _counterBalanceManager;
        private User _user;

        public CounterBalanceService(CounterBalanceManager counterBalanceManager)
		{
            _counterBalanceManager = counterBalanceManager;
		}

        public CounterBalanceService(User user)
		{
            _user = user;
            _counterBalanceManager = new CounterBalanceManager(user);
		}
        public int UpdateCounterBalance(CounterBalance counterBalance)
        {
            return _counterBalanceManager.UpdateCounterBalance(counterBalance);

        }
        public int SaveCounterBalance(CounterBalance counterBalance)
        {
            return _counterBalanceManager.SaveCounterBalance(counterBalance);
        }

        public List<CounterBalance> FetchCounterBalance(string branch, string allocationDate)
        {
            return _counterBalanceManager.FetchCounterBalance(branch,allocationDate);
        }


    }
}
