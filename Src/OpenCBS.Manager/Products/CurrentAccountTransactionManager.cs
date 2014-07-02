﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.CoreDomain.Contracts.Loans.Installments;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Enums;
using System.Data.SqlClient;

namespace OpenCBS.Manager.Products
{
    public class CurrentAccountTransactionManager : Manager
    {
        public CurrentAccountTransactionManager(User pUser) : base(pUser)
        {
        }

        public CurrentAccountTransactionManager(string testDB)
            : base(testDB)
        {
        }



        public int SaveCurrentAccountTransactions(CurrentAccountTransactions currentAccountTransactions)
        {
            const string q = @"INSERT INTO [CurrentAccountTransactions]
           ([from_account],
[to_account],
[amount],
[transaction_date],
[transaction_mode],
[transaction_type],
[transaction_fees],
[maker],
[checker])
                VALUES
(@fromAccount,
@toAccount,
@amount,
@transactionDate,
@transactionMode,
@transactionType,
@transactionFees,
@maker,
@checker)
         
                SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {


                SetProduct(c, currentAccountTransactions);
                currentAccountTransactions.Id = Convert.ToInt32(c.ExecuteScalar());
            }


            return currentAccountTransactions.Id;
        }


        public void SetProduct(OpenCbsCommand c, CurrentAccountTransactions currentAccountTransactions)
{
c.AddParam("@fromAccount",currentAccountTransactions.FromAccount);
c.AddParam("@toAccount",currentAccountTransactions. ToAccount);
c.AddParam("@amount ",currentAccountTransactions. Amount);
c.AddParam("@transactionDate",currentAccountTransactions. TransactionDate);
c.AddParam("@transactionMode",currentAccountTransactions. TransactionMode);
c.AddParam("@transactionType ",currentAccountTransactions. TransactionType);
c.AddParam("@transactionFees ",currentAccountTransactions. TransactionFees);
c.AddParam("@maker",currentAccountTransactions. Maker);
c.AddParam("@checker",currentAccountTransactions. Checker);
}

        public CurrentAccountTransactions GetProduct(OpenCbsReader r)
{
    CurrentAccountTransactions currentAccountTransactions = new CurrentAccountTransactions();
currentAccountTransactions.Id = r.GetInt("id");
currentAccountTransactions.FromAccount = r.GetString("from_account");
currentAccountTransactions.ToAccount = r.GetString("to_account");
currentAccountTransactions.Amount = r.GetDecimal("amount");
currentAccountTransactions.TransactionDate = r.GetDateTime("transaction_date");
currentAccountTransactions.TransactionMode = r.GetString("transaction_mode");
currentAccountTransactions.TransactionType = r.GetString("transaction_type");
currentAccountTransactions.TransactionFees = r.GetDecimal("transaction_fees");
currentAccountTransactions.Maker = r.GetString("maker");
currentAccountTransactions.Checker = r.GetString("checker");

return currentAccountTransactions;
}
    }
}
