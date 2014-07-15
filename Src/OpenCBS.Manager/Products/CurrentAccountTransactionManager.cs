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
       
        public CurrentAccountTransactionManager(User pUser) : base(pUser)
        {
           
        }

        public CurrentAccountTransactionManager(string testDB)
            : base(testDB)
        {
            
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


                SetProduct(c, currentAccountTransactions, currentAccountTransactionFees);
                currentAccountTransactions.Id = Convert.ToInt32(c.ExecuteScalar());
                decimal transactionFee = CalculateTransactionFees(currentAccountTransactions, currentAccountTransactionFees);
                UpdateCurrentAccountTransactions(transactionFee, currentAccountTransactions.Id);
            }


            return currentAccountTransactions.Id;
        }


        public void SetProduct(OpenCbsCommand c, CurrentAccountTransactions currentAccountTransactions, CurrentAccountTransactionFees currentAccountTransactionFees)
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
                feeTransaction.ToAccount = "DEF/Test1-CA/1/24"; // TODO: Fetch To_branch_account_number from From_Account 
                feeTransaction.TransactionDate = DateTime.Today;
                feeTransaction.TransactionFees = -1;
                feeTransaction.TransactionMode = "Debit";
                feeTransaction.TransactionType = "Fee";
                // TODO: Debit Transaction Fee

            }

            
            //If Transaction_Fee_Type is Flat then
            //Fetch Transaction_Fee
            //Fee_Transaction_Amount = Transaction_Fee
            //    Else
            //        Fetch Transaction_Fee
            //        Fee_Transaction_Amount = Transaction Fee * Transaction_Amount/100
            //        Fee_From_Account = Transaction_From_Account	
            //        Fetch From_Branch from Transaction_From_Account
            //        Fetch From_Branch_Account_Number from Branch table
            //        Fee_To_Account = From_Branch_Account_Number
            //        Fee_Purpose Of Transfer = Transaction fee applied for <Transaction ID>
            //        Fee_Transaction_Date = Today’s Date
            //        Fee_Transaction_Maker = Batch Process
            //        Fee_Transaction_Checker = Batch Process
            //        Fee_Transaction_Type = Fee
            //        Fee_Transaction_Mode = Debit
            //        Debit Transaction fee
            //    End If
            //End If
            return feeTransaction.Amount.Value;
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
    string q = @"select top (1) * from CurrentAccountTransactions Where (From_Acount = @contractCode OR To_Account = @contractCode) AND DATEPART(mm, transaction_date) = (@month-1) order by Transaction_Date DESC";
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

    }
}
