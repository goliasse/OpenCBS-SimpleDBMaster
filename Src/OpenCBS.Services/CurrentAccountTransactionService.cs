using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.ExceptionsHandler;

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


        public int SaveCurrentAccountTransactions(CurrentAccountTransactions currentAccountTransactions, CurrentAccountTransactionFees currentAccountTransactionFees)
        {
            return _currentAccountTransactionManager.SaveCurrentAccountTransactions(currentAccountTransactions, currentAccountTransactionFees);
        }


        void ValidateCurrentAccountTransaction(CurrentAccountTransactions currentAccountTransactions)
        {
            if (currentAccountTransactions.Amount.HasValue)
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.AmountIsInvalid);

            if (currentAccountTransactions.Amount.HasValue && currentAccountTransactions.Amount <= 0)
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.AmountIsInvalid);

            if (currentAccountTransactions.FromAccount == "")
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.FromAccountNotSelected);

            if (currentAccountTransactions.ToAccount == "")
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.ToAccountNotSelected);

            if (currentAccountTransactions.FromAccount == currentAccountTransactions.ToAccount)
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.ToAndFromAccountIsInvalid);

            //Purpose of transfre not be blank
        }


        public void UpdateCurrentAccountTransactions(decimal transactionFee, int transactionId)
          {
              _currentAccountTransactionManager.UpdateCurrentAccountTransactions(transactionFee, transactionId);
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
