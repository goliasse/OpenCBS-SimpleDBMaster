// Octopus MFS is an integrated suite for managing a Micro Finance Institution: 
// clients, contracts, accounting, reporting and risk
// Copyright © 2006,2007 OCTO Technology & OXUS Development Network
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using OpenCBS.DatabaseConnection;
using OpenCBS.ExceptionsHandler.Exceptions.AccountExceptions;
using OpenCBS.Manager.Accounting;
using OpenCBS.CoreDomain;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Reports;
using OpenCBS.Shared;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Services.Currencies;
using OpenCBS.Enums;
using OpenCBS.Manager;
namespace OpenCBS.Services.Accounting
{
    public class IncomeService
    {
        private readonly IncomeManager _incomeManager;

        private readonly User _user;


        public IncomeService(IncomeManager IncomeManager)
        {
            _incomeManager = IncomeManager;
        }

        public IncomeService(User pUser)
        {
            _user = pUser;

            _incomeManager = new IncomeManager(pUser);
        }

        public IncomeService(string testDb)
        {
            _incomeManager = new IncomeManager(testDb);

        }


        public int UpdateIncome(Income addIncome)
        {
            return _incomeManager.UpdateIncome(addIncome);
        }

        public Income FetchIncome(int id)
        {
            return _incomeManager.FetchIncome(id);
        }

        public List<Income> FetchAll()
        {
            return _incomeManager.FetchAll();
        }

        public int SaveIncome(Income addIncome)
        {
            return _incomeManager.SaveIncome(addIncome);
        }
        public int DeleteIncome(int id)
        {
            return _incomeManager.DeleteIncome(id);
        }

        private void ValidateIncome(Income income)
        {

            if (income.IncomeDate == null)
                throw new OpenCbsIncomeException(OpenCbsIncomeExceptionEnum.IncomeDateIsEmpty);
           

            if (string.IsNullOrEmpty(income.IncomeCategory))
                throw new OpenCbsIncomeException(OpenCbsIncomeExceptionEnum.IncomeCategoryIsEmpty);


            if (string.IsNullOrEmpty(income.IncomeDescription))
                throw new OpenCbsIncomeException(OpenCbsIncomeExceptionEnum.IncomeDescriptionIsEmpty);

            if (!income.IncomeAmount.HasValue)
                throw new OpenCbsIncomeException(OpenCbsIncomeExceptionEnum.IncomeAmountIsEmpty);

            if (Convert.ToDecimal(income.IncomeAmount) < 0)
                throw new OpenCbsIncomeException(OpenCbsIncomeExceptionEnum.IncomeAmountIsInvalid);


            if (string.IsNullOrEmpty(income.Reference))
                throw new OpenCbsIncomeException(OpenCbsIncomeExceptionEnum.ReferenceIsEmpty);

            if (string.IsNullOrEmpty(income.Currency))
                throw new OpenCbsIncomeException(OpenCbsIncomeExceptionEnum.CurrencyIsEmpty);


            if (string.IsNullOrEmpty(income.Branch))
                throw new OpenCbsIncomeException(OpenCbsIncomeExceptionEnum.BranchIsEmpty);

        }



        

    }
}
