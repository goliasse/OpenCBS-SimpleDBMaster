using System;
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
        CurrentAccountProductHoldingManager currentAccountProductHoldingManager = null;
        public CurrentAccountTransactionManager(User pUser) : base(pUser)
        {
           // currentAccountProductHoldingManager = new  CurrentAccountProductHoldingManager(pUser);
        }

        public CurrentAccountTransactionManager(string testDB)
            : base(testDB)
        {
           // currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(testDB);
        }



        public int SaveCurrentAccountTransactions(CurrentAccountTransactions currentAccountTransactions, CurrentAccountTransactionFees currentAccountTransactionFees)
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
[checker],
[purpose_of_transfer]
)
                VALUES
(@fromAccount,
@toAccount,
@amount,
@transactionDate,
@transactionMode,
@transactionType,
@transactionFees,
@maker,
@checker,
@purposeOfTransfer
)
         
                SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {


                SetProduct(c, currentAccountTransactions);
                currentAccountTransactions.Id = Convert.ToInt32(c.ExecuteScalar());
                decimal transactionFee = CalculateTransactionFees(currentAccountTransactions, currentAccountTransactionFees);
                UpdateCurrentAccountTransactions(transactionFee, currentAccountTransactions.Id);
            }


            return currentAccountTransactions.Id;
        }


        public void SetProduct(OpenCbsCommand c, CurrentAccountTransactions currentAccountTransactions)
        {
        c.AddParam("@fromAccount",currentAccountTransactions.FromAccount);
        c.AddParam("@toAccount",currentAccountTransactions.ToAccount);
        c.AddParam("@amount ",currentAccountTransactions.Amount);
        c.AddParam("@transactionDate",currentAccountTransactions.TransactionDate);
        c.AddParam("@transactionMode",currentAccountTransactions.TransactionMode);
        c.AddParam("@transactionType ",currentAccountTransactions.TransactionType);
        c.AddParam("@transactionFees ", 0);
        c.AddParam("@maker",currentAccountTransactions.Maker);
        c.AddParam("@checker",currentAccountTransactions.Checker);
        c.AddParam("@purposeOfTransfer", currentAccountTransactions.PurposeOfTransfer);
            
        }

        public decimal CalculateTransactionFees(CurrentAccountTransactions currentAccountTransactions, CurrentAccountTransactionFees currentAccountTransactionFees)
        {
            CurrentAccountTransactions feeTransaction = new CurrentAccountTransactions();
            if (currentAccountTransactionFees == null)
                return 0;
            else
            {
                if (currentAccountTransactionFees.TransactionFeesType == "Flat")
                {
                    feeTransaction.Amount = currentAccountTransactionFees.TransactionFees;
                }
                else
                {
                    feeTransaction.Amount = currentAccountTransactionFees.TransactionFees * currentAccountTransactions.Amount / 100;
                }

                feeTransaction.Checker = "Fees";
                feeTransaction.FromAccount = currentAccountTransactions.FromAccount;
                feeTransaction.Maker = "Fees";
                feeTransaction.PurposeOfTransfer = "Transaction fee applied for " + currentAccountTransactions.Id;
                feeTransaction.ToAccount = FetchBranchAccountNumber(currentAccountTransactions.FromAccount);  
                feeTransaction.TransactionDate = DateTime.Today;
                feeTransaction.TransactionFees = -1;
                feeTransaction.TransactionMode = "Debit";
                feeTransaction.TransactionType = "Fee";
                DebitFeeTransaction(feeTransaction);

            }

            
          
            return feeTransaction.Amount.Value;
        }

        public string FetchBranchAccountNumber(string productCode)
        {
            string[] data = productCode.Split('/');
            string q = "SELECT branch_account_number from Branches where code = @branchCode";
            string branchAccountNumber = "";
            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@branchCode", data[0]);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    while (r.Read())
                    {

                        branchAccountNumber = r.GetString("branch_account_number");

                    }
                }
            }

            return branchAccountNumber;

        }

        public CurrentAccountTransactions GetProduct(OpenCbsReader r)
{
    CurrentAccountTransactions currentAccountTransactions = new CurrentAccountTransactions();
currentAccountTransactions.Id = r.GetInt("id");
currentAccountTransactions.FromAccount = r.GetString("from_account");
currentAccountTransactions.ToAccount = r.GetString("to_account");
currentAccountTransactions.Amount = r.GetNullDecimal("amount");
currentAccountTransactions.TransactionDate = r.GetDateTime("transaction_date");
currentAccountTransactions.TransactionMode = r.GetString("transaction_mode");
currentAccountTransactions.TransactionType = r.GetString("transaction_type");
currentAccountTransactions.TransactionFees = r.GetNullDecimal("transaction_fees");
currentAccountTransactions.Maker = r.GetString("maker");
currentAccountTransactions.Checker = r.GetString("checker");
currentAccountTransactions.PurposeOfTransfer = r.GetString("purpose_of_transfer");
currentAccountTransactions.FromBalance = r.GetDecimal("from_account_balance");
currentAccountTransactions.ToBalance = r.GetDecimal("to_account_balance");

return currentAccountTransactions;
}


        public void UpdateCurrentAccountTransactions(decimal transactionFee, int transactionId)
        {
            string q = @"UPDATE [CurrentAccountTransactions] SET 
           
 [transaction_fees] = @transactionFees
 WHERE  id = @transactionId ";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@transactionId", transactionId);
                c.AddParam("@transactionFees", transactionFee);
           
           
                c.ExecuteNonQuery();
            }
        }


public CurrentAccountTransactions FetchTransaction(int transactionId)
        {


            string q = @"SELECT
[id],
            [from_account],
[to_account],
[amount],
[transaction_date],
[transaction_mode],
[transaction_type],
[transaction_fees],
[maker],
[checker],
[purpose_of_transfer]

            FROM [dbo].[CurrentAccountTransactions]
            WHERE id = @transactionId";



            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@transactionId", transactionId);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return new CurrentAccountTransactions();
                    r.Read();

                    CurrentAccountTransactions currentAccountTransactions = new CurrentAccountTransactions ();

                    return (CurrentAccountTransactions)GetProduct(r);



                }
            }


        }

public CurrentAccountTransactions FetchMonthClosingBalance(int calculationMonth, string contractCode)
{
    CurrentAccountTransactions currentAccountTransactions = null;
    string q = @"select top (1) * from CurrentAccountTransactions Where (From_Account = @contractCode OR To_Account = @contractCode) AND DATEPART(mm, transaction_date) = @month order by Transaction_Date DESC";
    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
        c.AddParam("@contractCode", contractCode);
        c.AddParam("@month", calculationMonth);

        using (OpenCbsReader r = c.ExecuteReader())
        {

            while (r.Read())
            {
                currentAccountTransactions = GetProduct(r);
            }
        }
    }

    return currentAccountTransactions;
}


public List<CurrentAccountTransactions> FetchTransactions(string accountNumber)
        {
            List<CurrentAccountTransactions> currentAccountTransactionsList = new List<CurrentAccountTransactions>();


            string q = @"SELECT
[id],
            [from_account],
[to_account],
[amount],
[transaction_date],
[transaction_mode],
[transaction_type],
[transaction_fees],
[maker],
[checker],
[purpose_of_transfer]

            FROM [dbo].[CurrentAccountTransactions]
            WHERE from_account = @accountNumber OR to_account = @accountNumber";
          



            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
c.AddParam("@accountNumber", accountNumber);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return new List<CurrentAccountTransactions>();
                    while (r.Read())
                    {


                        CurrentAccountTransactions transaction = FetchTransaction(r.GetInt("id"));

                        currentAccountTransactionsList.Add(transaction);
                    }
                }
            }

            return currentAccountTransactionsList;
        }


public List<CurrentAccountTransactions> FetchFeeTransactions(string accountNumber, string maker)
{
    List<CurrentAccountTransactions> currentAccountTransactionsList = new List<CurrentAccountTransactions>();


    string q = @"SELECT
[id],
[from_account],
[to_account],
[amount],
[transaction_date],
[transaction_mode],
[transaction_type],
[transaction_fees],
[maker],
[checker],
[purpose_of_transfer]

FROM [dbo].[CurrentAccountTransactions]
WHERE from_account = @accountNumber OR to_account = @accountNumber
AND maker = @maker";




    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
        c.AddParam("@accountNumber", accountNumber);
        c.AddParam("@maker", maker);
        using (OpenCbsReader r = c.ExecuteReader())
        {
            if (r == null || r.Empty) return new List<CurrentAccountTransactions>();
            while (r.Read())
            {


                CurrentAccountTransactions transaction = FetchTransaction(r.GetInt("id"));

                currentAccountTransactionsList.Add(transaction);
            }
        }
    }

    return currentAccountTransactionsList;
}



        public int MakeATransaction(CurrentAccountTransactions currentAccountTransactions, CurrentAccountTransactionFees currentAccountTransactionFees)
        {
            int ret = -99;
            using (SqlConnection conn = GetConnection())
            {
                using (OpenCbsCommand command = new OpenCbsCommand("BalanceCalculation", conn).AsStoredProcedure())
                {
                    
                    command.AddParam("@transaction_mode",currentAccountTransactions.TransactionMode);
                    command.AddParam("@transaction_type",currentAccountTransactions.TransactionType);
                    command.AddParam("@to_account",currentAccountTransactions.ToAccount);
                    command.AddParam("@from_account",currentAccountTransactions.FromAccount);
                    command.AddParam("@amount",currentAccountTransactions.Amount);
                    command.AddParam("@transaction_date",currentAccountTransactions.TransactionDate);
                    command.AddParam("@transaction_fees",0);
                    command.AddParam("@maker",currentAccountTransactions.Maker);
                    command.AddParam("@checker",currentAccountTransactions.Checker);
                    command.AddParam("@purpose_of_transfer", currentAccountTransactions.PurposeOfTransfer);

                    ret = Convert.ToInt32(command.ExecuteScalar());
                    currentAccountTransactions.Id = ret;
                    decimal transactionFee = 0;
                    if(currentAccountTransactionFees!=null)
                    transactionFee = CalculateTransactionFees(currentAccountTransactions, currentAccountTransactionFees);
                    UpdateCurrentAccountTransactions(transactionFee, ret);

                            
                    
                }
            }

            return ret;
        }


public int DebitFeeTransaction(CurrentAccountTransactions currentAccountTransactions)
        {
            int ret = -99;
            using (SqlConnection conn = GetConnection())
            {
                using (OpenCbsCommand command = new OpenCbsCommand("DebitFeeTransaction", conn).AsStoredProcedure())
                {
                    command.AddParam("@transaction_mode", currentAccountTransactions.TransactionMode);
                    command.AddParam("@transaction_type", currentAccountTransactions.TransactionType);
                    command.AddParam("@to_account", currentAccountTransactions.ToAccount);
                    command.AddParam("@from_account", currentAccountTransactions.FromAccount);
                    command.AddParam("@amount", currentAccountTransactions.Amount);
                    command.AddParam("@transaction_date", currentAccountTransactions.TransactionDate);
                    command.AddParam("@transaction_fees", 0);
                    command.AddParam("@maker", currentAccountTransactions.Maker);
                    command.AddParam("@checker", currentAccountTransactions.Checker);
                    command.AddParam("@purpose_of_transfer", currentAccountTransactions.PurposeOfTransfer);

        



                    using (OpenCbsReader reader = command.ExecuteReader())
                    {
                        if (reader == null || reader.Empty) return 0;

                        while (reader.Read())
                        {
                            ret = reader.GetInt("ret");
                            
                        }
                        return ret;
                    }
                }
            }
        }

    }
}
