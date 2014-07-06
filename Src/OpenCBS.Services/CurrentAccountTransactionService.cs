using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;

namespace OpenCBS.Services
{
    public class CurrentAccountTransactionService
    {

        private readonly CurrentAccountTransactionManager _currentAccountTransactionManager;
        private User _user;

        public CurrentAccountTransactionService(CurrentAccountTransactionManager currentAccountProductManager)
		{
            _currentAccountTransactionManager = currentAccountProductManager;
		}

        public CurrentAccountTransactionService(User user)
		{
            _user = user;
            _currentAccountTransactionManager = new CurrentAccountTransactionManager(user);
		}


        public int SaveCurrentAccountTransactions(CurrentAccountTransactions currentAccountTransactions)
        {
            return _currentAccountTransactionManager.SaveCurrentAccountTransactions(currentAccountTransactions);
        }

          public void  UpdateCurrentAccountTransactions(CurrentAccountTransactions transaction,string transactionId)
          {
              _currentAccountTransactionManager.UpdateCurrentAccountTransactions(transaction, transactionId);
          }
              public  CurrentAccountTransactions FetchTransaction(int transactionId)
              {
                  return _currentAccountTransactionManager.FetchTransaction(transactionId);
              }

              public List<CurrentAccountTransactions> FetchTransactions(string accountNumber)
              {
                  return _currentAccountTransactionManager.FetchTransactions(accountNumber);
              }


    }
}
