﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Enums;

namespace OpenCBS.Services
{
    public class CurrentAccountTransactionService
    {

        private readonly CurrentAccountTransactionManager _currentAccountTransactionManager;
        private readonly CurrentAccountProductHoldingManager _currentAccountProductHoldingManager;
        private readonly FixedDepositProductHoldingManager _fixedDepositProductHoldingManager;
        private User _user;

        public CurrentAccountTransactionService(CurrentAccountTransactionManager currentAccountTransactionManager)
		{
            _currentAccountTransactionManager = currentAccountTransactionManager;
		}

        public CurrentAccountTransactionService(User user)
		{
            _user = user;
            _currentAccountTransactionManager = new CurrentAccountTransactionManager(user);
            _currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(user);
            _fixedDepositProductHoldingManager = new FixedDepositProductHoldingManager(user);

		}


        //public int SaveCurrentAccountTransactions(CurrentAccountTransactions currentAccountTransactions, CurrentAccountTransactionFees currentAccountTransactionFees)
        //{
        //    ValidateCurrentAccountTransaction(currentAccountTransactions);
        //    return _currentAccountTransactionManager.SaveCurrentAccountTransactions(currentAccountTransactions, currentAccountTransactionFees);
        //}


        void ValidateCurrentAccountTransaction(CurrentAccountTransactions currentAccountTransactions, CurrentAccountProduct _currentAccountProduct, CurrentAccountProductHoldings currentAccountProductHoldings)
        {
            if (!currentAccountTransactions.Amount.HasValue)
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.CATAmountIsBlank);

            if (currentAccountTransactions.Amount.HasValue && currentAccountTransactions.Amount <= 0)
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.AmountIsInvalid);

            if (string.IsNullOrEmpty(currentAccountTransactions.FromAccount))
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.FromAccountNotSelected);

            if (string.IsNullOrEmpty(currentAccountTransactions.ToAccount))
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.ToAccountNotSelected);

            if (currentAccountTransactions.FromAccount == currentAccountTransactions.ToAccount)
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.ToAndFromAccountIsInvalid);

            if(currentAccountTransactions.TransactionType == OCurrentAccount.SelectPaymentMethodDefault)
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.CATSelectATransactionType);

            if (string.IsNullOrEmpty(currentAccountTransactions.PurposeOfTransfer))
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.PurposeOfTransferIsBlank);

            if ((currentAccountTransactions.TransactionType == "Transfer") || (currentAccountTransactions.TransactionMode == "Debit"))
            {
                if (currentAccountProductHoldings.OverdraftApplied == 0)
                {
                    if (_currentAccountProduct.BalanceMin > (currentAccountProductHoldings.Balance - currentAccountTransactions.Amount))
                        throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.CATBalanceLessThanMinBalance);
                }
            }
            
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


              public int MakeATransaction(CurrentAccountTransactions currentAccountTransactions, CurrentAccountTransactionFees currentAccountTransactionFees, CurrentAccountProduct _currentAccountProduct, CurrentAccountProductHoldings currentAccountProductHoldings)
              {
                  ValidateCurrentAccountTransaction(currentAccountTransactions, _currentAccountProduct, currentAccountProductHoldings);
                  currentAccountTransactions.toCAAccount = _currentAccountProductHoldingManager.FetchProduct(currentAccountTransactions.ToAccount);
                  currentAccountTransactions.fromCAAccount = _currentAccountProductHoldingManager.FetchProduct(currentAccountTransactions.FromAccount);
                  currentAccountTransactions.toFDAccount = _fixedDepositProductHoldingManager.FetchProduct(currentAccountTransactions.ToAccount);
                  currentAccountTransactions.fromFDAccount =_fixedDepositProductHoldingManager.FetchProduct(currentAccountTransactions.FromAccount);
                  return _currentAccountTransactionManager.MakeATransaction(currentAccountTransactions, currentAccountTransactionFees);
              }

              public int DebitFeeTransaction(CurrentAccountTransactions currentAccountTransactions)
              {
                  currentAccountTransactions.toCAAccount = _currentAccountProductHoldingManager.FetchProduct(currentAccountTransactions.ToAccount);
                  currentAccountTransactions.fromCAAccount = _currentAccountProductHoldingManager.FetchProduct(currentAccountTransactions.FromAccount);
                  currentAccountTransactions.toFDAccount = _fixedDepositProductHoldingManager.FetchProduct(currentAccountTransactions.ToAccount);
                  currentAccountTransactions.fromFDAccount = _fixedDepositProductHoldingManager.FetchProduct(currentAccountTransactions.FromAccount);
                 return _currentAccountTransactionManager.DebitFeeTransaction(currentAccountTransactions);
              }

              public List<CurrentAccountTransactions> FetchFeeTransactions(string accountNumber, string maker)
        {
            return _currentAccountTransactionManager.FetchFeeTransactions(accountNumber, maker);
        }

        public int MakeFDTransaction(CurrentAccountTransactions currentAccountTransactions)
        {
            currentAccountTransactions.toCAAccount = _currentAccountProductHoldingManager.FetchProduct(currentAccountTransactions.ToAccount);
            currentAccountTransactions.fromCAAccount = _currentAccountProductHoldingManager.FetchProduct(currentAccountTransactions.FromAccount);
            currentAccountTransactions.toFDAccount = _fixedDepositProductHoldingManager.FetchProduct(currentAccountTransactions.ToAccount);
            currentAccountTransactions.fromFDAccount = _fixedDepositProductHoldingManager.FetchProduct(currentAccountTransactions.FromAccount);
            return _currentAccountTransactionManager.MakeFDTransaction(currentAccountTransactions);
        }



    }
}
