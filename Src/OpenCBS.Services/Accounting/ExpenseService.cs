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
    public class ExpenseService 
    {
        private readonly ExpenseManager _expenseManager;
        
        private readonly User _user;


        public ExpenseService(ExpenseManager expenseManager)
		{
            _expenseManager = expenseManager;
		}

        public ExpenseService(User pUser)
        {
            _user = pUser;
            
            _expenseManager = new ExpenseManager(pUser);
        }

        public ExpenseService(string testDb)
        {
            //_user = new User();

            _expenseManager = new ExpenseManager(testDb);
            
        }

        public int AddExpense(Expense expense)
        {
          return _expenseManager.AddExpense(expense);
        }

        private void ValidateAddExpense(Expense addExpense)
        {

            if (addExpense.ExpenseDate == null)
                throw new OpenCbsExpenseException(OpenCbsExpenseExceptionsEnum.ExpenseDateIsEmpty);
            if (addExpense.ExpenseDate.Date < DateTime.Now.Date)
                throw new OpenCbsExpenseException(OpenCbsExpenseExceptionsEnum.ExpenseDateIsInvalid);


            if (string.IsNullOrEmpty(addExpense.ExpenseCategory))
                throw new OpenCbsExpenseException(OpenCbsExpenseExceptionsEnum.ExpenseCategoryIsEmpty);


            if (string.IsNullOrEmpty(addExpense.ExpenseDescription))
                throw new OpenCbsExpenseException(OpenCbsExpenseExceptionsEnum.ExpenseDescriptionIsEmpty);

            if (!addExpense.ExpenseAmount.HasValue)
                throw new OpenCbsExpenseException(OpenCbsExpenseExceptionsEnum.ExpenseAmountIsEmpty);

            if (Convert.ToDecimal(addExpense.ExpenseAmount) < 0)
                throw new OpenCbsExpenseException(OpenCbsExpenseExceptionsEnum.ExpenseAmountIsInvalid);


            if (string.IsNullOrEmpty(addExpense.Reference))
                throw new OpenCbsExpenseException(OpenCbsExpenseExceptionsEnum.ReferenceIsEmpty);
        }


        public List<Expense> FetchExpenses()
        {

            return _expenseManager.FetchExpenses();

        }

        public int UpdateExpense(Expense expense)
        {
           
            return _expenseManager.UpdateExpense(expense);
        }

        public int DeleteExpense(int Id)
        {
           return _expenseManager.DeleteExpense(Id);
        }

    }
}
