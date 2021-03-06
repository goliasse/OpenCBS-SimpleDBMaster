﻿using System;
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

        public List<string> FetchCashiers()
        {
            return _counterBalanceManager.FetchCashiers();
        }


        public List<BranchCounter> FetchCounters(string branch)
        {
            return _counterBalanceManager.FetchCounters(branch);
        }

        public int SaveBranchCounter(BranchCounter branchCounter)
        {

            if (branchCounter.Branch == "Select Branch..")
                throw new OpenCbsAllocateCounterException(OpenCbsAllocateCounterExceptionEnum.AddCounterSelectBranch);

            if (string.IsNullOrEmpty(branchCounter.Description))
                throw new OpenCbsAllocateCounterException(OpenCbsAllocateCounterExceptionEnum.AddCounterDescriptionIsEmpty);

            return _counterBalanceManager.SaveBranchCounter(branchCounter);
        }

        public void UpdateBranchCounter(BranchCounter branchCounter)
        {
            _counterBalanceManager.UpdateBranchCounter(branchCounter);
        }

        private void ValidateProduct(CounterBalance counterBalance)
        {

            if (string.IsNullOrEmpty(counterBalance.Branch))
                throw new OpenCbsAllocateCounterException(OpenCbsAllocateCounterExceptionEnum.CounterBalanceBranchIsNotSelected);


            if (string.IsNullOrEmpty(counterBalance.CashierId))
                throw new OpenCbsAllocateCounterException(OpenCbsAllocateCounterExceptionEnum.CounterBalanceCashierIsNotSelected);


            if (string.IsNullOrEmpty(counterBalance.CounterId))
                throw new OpenCbsAllocateCounterException(OpenCbsAllocateCounterExceptionEnum.CounterBalanceCounterIsNotSelected);



            if (counterBalance.Amount < 0 || (counterBalance.Amount.Value % 1000) != 0 || counterBalance.Type == "Opening Amount")
                throw new OpenCbsAllocateCounterException(OpenCbsAllocateCounterExceptionEnum.CounterBalanceOpeningAmountIsInvalid);



            if (counterBalance.Amount < 0 || (counterBalance.Amount.Value % 1000) != 0 || counterBalance.Type == "TopUp Amount")
                throw new OpenCbsAllocateCounterException(OpenCbsAllocateCounterExceptionEnum.CounterBalanceTopUpAmountIsInvalid);


}





    }
}
