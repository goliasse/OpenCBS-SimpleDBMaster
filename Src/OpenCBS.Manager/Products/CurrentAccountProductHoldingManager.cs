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
using OpenCBS.CoreDomain.SearchResult;
using OpenCBS.CoreDomain.Events.Products;
using OpenCBS.Manager.Events;

namespace OpenCBS.Manager.Products
{
    public class CurrentAccountProductHoldingManager : Manager
    {
        CurrentAccountProductManager currentAccountProductManager = null;
         CurrentAccountTransactionManager currentAccountTransactionManager = null;
         CurrentAccountEventManager currentAccountEventManager = null;
         public CurrentAccountProductHoldingManager(User pUser) : base(pUser)
        {
              currentAccountTransactionManager = new CurrentAccountTransactionManager(pUser);
              currentAccountProductManager = new CurrentAccountProductManager(pUser);
              currentAccountEventManager = new CurrentAccountEventManager(pUser);
        }

         public CurrentAccountProductHoldingManager(string testDB)
             : base(testDB)
        {
             currentAccountTransactionManager = new CurrentAccountTransactionManager(testDB);
             currentAccountProductManager = new CurrentAccountProductManager(testDB);
             currentAccountEventManager = new CurrentAccountEventManager(testDB);
        }


         public string SaveCurrentAccountPoductHolding(CurrentAccountProductHoldings productName)
         {
             //int identity;
             const string q = @"INSERT INTO [CurrentAccountProductHoldings]
          ( [client_id],
[client_type],
[current_account_contract_code],
[current_account_product_id],
[initial_amount],
[opening_accounting_officer],
[closing_accounting_officer],
[open_date],
[close_date],
[status],
[comment],
[entry_fees],
[reopen_fees],
[closing_fees],
[management_fees],
[overdraft_fees],
[entry_fees_type],
[reopen_fees_type],
[closing_fees_type],
[management_fees_type],
[overdraft_fees_type],
[management_fees_frequency],
[initial_amount_payment_method],
[overdraft_limit],
[interest_rate],
[interest_calculation_frequency],
[initial_amount_account_number],
[balance],
[overdraft_interest],
[overdraft_interest_type],
[overdraft_commitment_fee_type],
[overdraft_commitment_fee],
[overdraft_applied],
[overdraft_applied_date],
[alloted_overdraft_limit]
)
                VALUES
                (@clientId,
@clientType,
@currentAccountContractCode,
@currentAccountProductId,
@initialAmount,
@openingAccountingOfficer,
@closingAccountingOfficer,
@openDate,
@closeDate,
@status,
@comment,
@entryFees,
@reopenFees,
@closingFees,
@managementFees,
@overdraftFees,
@entryFeesType,
@reopenFeesType,
@closingFeesType,
@managementFeesType,
@overdraftFeesType,
@managementFeesFrequency,
@initialAmountPaymentMethod,
@overdraftLimit,
@interestRate,
@interestCalculationFrequency,
@initialAmountAccountNumber,
@balance,
@overdraftInterest,
@overdraftInterestType,
@overdraftCommitmentFeeType,
@overdraftCommitmentFee,
@overdraftApplied,
@overdraftAppliedDate,
@AllotedOverdraftLimit
)
                SELECT SCOPE_IDENTITY()";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 productName.Balance = 0;
                 SetProduct(c, productName);
                 
                 productName.Id = Convert.ToInt32(c.ExecuteScalar());
                 
                 productName.CurrentAccountContractCode = productName.CurrentAccountContractCode + "/" + productName.Id;
                 UpdateCurrentAccountProductHolding(productName, productName.Id);
                 TransferInitialAmount(productName);
                 productName.Balance = productName.InitialAmount - CalculateEntryFees(productName);
                 UpdateCurrentAccountProductHolding(productName, productName.Id);
                 
             }
             return productName.CurrentAccountContractCode;
         }

         private static void SetProduct(OpenCbsCommand c, CurrentAccountProductHoldings product)
         {
             c.AddParam("@clientId", product.ClientId);
             c.AddParam("@clientType", product.ClientType);
             c.AddParam("@currentAccountContractCode", product.CurrentAccountContractCode);
             c.AddParam("@currentAccountProductId", product.CurrentAccountProduct.Id);
             c.AddParam("@initialAmount", product.InitialAmount);
             c.AddParam("@openingAccountingOfficer", product.OpeningAccountingOfficer);
             c.AddParam("@closingAccountingOfficer", product.ClosingAccountingOfficer);
             c.AddParam("@openDate", product.OpenDate);
             c.AddParam("@closeDate", product.CloseDate);
             c.AddParam("@status", product.Status);
             c.AddParam("@comment", product.Comment);
             c.AddParam("@entryFees", product.EntryFees);
             c.AddParam("@reopenFees", product.ReopenFees);
             c.AddParam("@closingFees", product.ClosingFees);
             c.AddParam("@managementFees", product.ManagementFees);
             c.AddParam("@overdraftFees", product.OverdraftFees);
             c.AddParam("@entryFeesType", product.EntryFeesType);
             c.AddParam("@reopenFeesType", product.ReopenFeesType);
             c.AddParam("@closingFeesType", product.ClosingFeesType);
             c.AddParam("@managementFeesType", product.ManagementFeesType);
             c.AddParam("@overdraftFeesType", product.OverdraftFeesType);
             c.AddParam("@managementFeesFrequency", product.ManagementFeesFrequency);
             c.AddParam("@initialAmountPaymentMethod", product.InitialAmountPaymentMethod);
             c.AddParam("@finalAmountPaymentMethod", product.FinalAmountPaymentMethod);
             c.AddParam("@finalAmountAccountNumber", product.FinalAmountAccountNumber);
             c.AddParam("@overdraftLimit", product.OverdraftLimit);
             c.AddParam("@interestRate", product.InterestRate);
             c.AddParam("@interestCalculationFrequency", product.InterestCalculationFrequency);
             c.AddParam("@initialAmountAccountNumber", product.InitialAmountAccountNumber);

             //Calculate the balance after all the deductions
             c.AddParam("@balance", product.Balance);
             c.AddParam("@overdraftInterest", product.OverdraftInterest);
             c.AddParam("@overdraftInterestType", product.OverdraftInterestType);
             c.AddParam("@overdraftCommitmentFeeType", product.OverdraftCommitmentFeeType);
             c.AddParam("@overdraftCommitmentFee", product.OverdraftCommitmentFee);
             c.AddParam("@overdraftApplied", product.OverdraftApplied);
             c.AddParam("@overdraftAppliedDate", product.OverdraftAppliedDate);
             c.AddParam("@AllotedOverdraftLimit", product.OverdraftLimit);

             

         }


     


         public void UpdateCurrentAccountProductHolding(CurrentAccountProductHoldings product, int productId)
         {
             string q = @"UPDATE [CurrentAccountProductHoldings] SET 
[client_id] = @clientId,
[client_type] = @clientType,
[current_account_contract_code] = @currentAccountContractCode,
[current_account_product_id] = @currentAccountProductId,
[initial_amount] = @initialAmount,
[opening_accounting_officer] = @openingAccountingOfficer,
[closing_accounting_officer] = @closingAccountingOfficer,
[open_date] = @openDate,
[close_date] = @closeDate,
[status] = @status,
[comment] = @comment,
[entry_fees] = @entryFees,
[reopen_fees] = @reopenFees,
[closing_fees] = @closingFees,
[management_fees] = @managementFees,
[overdraft_fees] = @overdraftFees,
[entry_fees_type] = @entryFeesType,
[reopen_fees_type] = @reopenFeesType,
[closing_fees_type] = @closingFeesType,
[management_fees_type] = @managementFeesType,
[overdraft_fees_type] = @overdraftFeesType,
[management_fees_frequency] = @managementFeesFrequency,
[initial_amount_payment_method] = @initialAmountPaymentMethod,
[final_amount_payment_method] = @finalAmountPaymentMethod,
[final_amount_account_number] = @finalAmountAccountNumber,
[overdraft_limit] = @overdraftLimit,
[interest_rate] = @interestRate,
[interest_calculation_frequency] = @interestCalculationFrequency,
[balance] = @balance,
[overdraft_interest] = @overdraftInterest,
[overdraft_interest_type] = @overdraftInterestType,
[overdraft_commitment_fee_type] = @overdraftCommitmentFeeType,
[overdraft_commitment_fee] = @overdraftCommitmentFee,
[overdraft_applied] = @overdraftApplied,
[overdraft_applied_date] = @overdraftAppliedDate,
[alloted_overdraft_limit] = @AllotedOverdraftLimit
WHERE id = @productId";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 c.AddParam("@productId", productId);
                 SetProduct(c, product);
                 c.ExecuteNonQuery();
             }
         }


         public void UpdateCurrentAccountProductHolding(CurrentAccountProductHoldings product, string contractCode)
         {
             string q = @"UPDATE [CurrentAccountProductHoldings] SET 
[client_id] = @clientId,
[client_type] = @clientType,
[current_account_contract_code] = @currentAccountContractCode,
[current_account_product_id] = @currentAccountProductId,
[initial_amount] = @initialAmount,
[opening_accounting_officer] = @openingAccountingOfficer,
[closing_accounting_officer] = @closingAccountingOfficer,
[open_date] = @openDate,
[close_date] = @closeDate,
[status] = @status,
[comment] = @comment,
[entry_fees] = @entryFees,
[reopen_fees] = @reopenFees,
[closing_fees] = @closingFees,
[management_fees] = @managementFees,
[overdraft_fees] = @overdraftFees,
[entry_fees_type] = @entryFeesType,
[reopen_fees_type] = @reopenFeesType,
[closing_fees_type] = @closingFeesType,
[management_fees_type] = @managementFeesType,
[overdraft_fees_type] = @overdraftFeesType,
[management_fees_frequency] = @managementFeesFrequency,
[initial_amount_payment_method] = @initialAmountPaymentMethod,
[final_amount_payment_method] = @finalAmountPaymentMethod,
[final_amount_account_number] = @finalAmountAccountNumber,
[overdraft_limit] = @overdraftLimit,
[interest_rate] = @interestRate,
[interest_calculation_frequency] = @interestCalculationFrequency,
[balance] = @balance,
[overdraft_interest] = @overdraftInterest,
[overdraft_interest_type] = @overdraftInterestType,
[overdraft_commitment_fee_type] = @overdraftCommitmentFeeType,
[overdraft_commitment_fee] = @overdraftCommitmentFee,
[overdraft_applied] = @overdraftApplied,
[overdraft_applied_date] = @overdraftAppliedDate,
[alloted_overdraft_limit] = @AllotedOverdraftLimit
WHERE current_account_contract_code = @contractCode";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 c.AddParam("@contractCode", contractCode);
                 SetProduct(c, product);
                 c.ExecuteNonQuery();
             }
         }



         public void TransferInitialAmount(CurrentAccountProductHoldings productHolding)
         {

             

             CurrentAccountTransactions initialAmountTransaction = new CurrentAccountTransactions();
             initialAmountTransaction.Amount = productHolding.InitialAmount;
             initialAmountTransaction.Checker = "Initial Amount";
             if (productHolding.InitialAmountAccountNumber != null)
             initialAmountTransaction.FromAccount = productHolding.InitialAmountAccountNumber;
             else
                 initialAmountTransaction.FromAccount = productHolding.InitialAmountPaymentMethod;
                
             initialAmountTransaction.Maker = "Initial Amount";
             initialAmountTransaction.PurposeOfTransfer = "Initial amount paid for " + productHolding.CurrentAccountContractCode;
             initialAmountTransaction.ToAccount = productHolding.CurrentAccountContractCode; 
             initialAmountTransaction.TransactionDate = DateTime.Today;
             initialAmountTransaction.TransactionFees = 0;
             initialAmountTransaction.TransactionMode = "Credit";
             initialAmountTransaction.TransactionType = productHolding.InitialAmountPaymentMethod;
             currentAccountTransactionManager.MakeATransaction(initialAmountTransaction, null);
             
         }

         public void TransferFinalAmount(CurrentAccountProductHoldings productHolding)
         {
             CurrentAccountTransactions finalAmountTransaction = new CurrentAccountTransactions();
             finalAmountTransaction.Amount = productHolding.InitialAmount;
             finalAmountTransaction.Checker = "Final Amount";
             finalAmountTransaction.FromAccount = productHolding.CurrentAccountContractCode;
             finalAmountTransaction.Maker = "Final Amount";
             finalAmountTransaction.PurposeOfTransfer = "Final amount paid for " + productHolding.CurrentAccountContractCode;
             if (productHolding.FinalAmountAccountNumber != null)
                 finalAmountTransaction.ToAccount = productHolding.FinalAmountAccountNumber;
             else
                 finalAmountTransaction.ToAccount = productHolding.FinalAmountPaymentMethod;
             finalAmountTransaction.TransactionDate = DateTime.Today;
             finalAmountTransaction.TransactionFees = 0;
             finalAmountTransaction.TransactionMode = "Debit";
             finalAmountTransaction.TransactionType = productHolding.FinalAmountPaymentMethod;
             currentAccountTransactionManager.MakeATransaction(finalAmountTransaction, null);

         }


         public decimal CalculateClosingFees(CurrentAccountProductHoldings productHolding)
         {

             decimal closingFees = 0;

             if (productHolding.ManagementFeesType == "Flat")
             {
                 closingFees = productHolding.ClosingFees.Value;
             }
             else
                 return 0;

             CurrentAccountTransactions feeTransaction = new CurrentAccountTransactions();
             feeTransaction.Amount = closingFees;
             feeTransaction.Checker = "Fees";
             feeTransaction.FromAccount = productHolding.CurrentAccountContractCode;
             feeTransaction.Maker = "Fees";
             feeTransaction.PurposeOfTransfer = "Closing Fee applied for " + productHolding.CurrentAccountContractCode;
             feeTransaction.ToAccount = FetchBranchAccountNumber(productHolding.CurrentAccountContractCode); 
             feeTransaction.TransactionDate = DateTime.Today;
             feeTransaction.TransactionFees = -1;
             feeTransaction.TransactionMode = "Debit";
             feeTransaction.TransactionType = "Fee";
             int ret = currentAccountTransactionManager.DebitFeeTransaction(feeTransaction);
             if (ret > 0)
             {
                 CurrentAccountEvent currentAccountEvent = new CurrentAccountEvent();
                 currentAccountEvent.ContractCode = productHolding.CurrentAccountContractCode;
                 currentAccountEvent.EventCode = "CLFT";
                 currentAccountEvent.Description = "Closing Fee debit transaction #" + ret;
                 currentAccountEventManager.SaveCurrentAccountEvent(currentAccountEvent);
             }
             return closingFees;
         }


         public decimal CalculateReopenFees(CurrentAccountProductHoldings productHolding)
         {

             decimal reopenFees = 0;

             if (productHolding.ManagementFeesType == "Flat")
             {
                 reopenFees = productHolding.ReopenFees.Value;
             }
             else
                 return 0;

             CurrentAccountTransactions feeTransaction = new CurrentAccountTransactions();
             feeTransaction.Amount = reopenFees;
             feeTransaction.Checker = "Fees";
             feeTransaction.FromAccount = productHolding.CurrentAccountContractCode;
             feeTransaction.Maker = "Fees";
             feeTransaction.PurposeOfTransfer = "Reopen Fee applied for " + productHolding.CurrentAccountContractCode;
             feeTransaction.ToAccount = FetchBranchAccountNumber(productHolding.CurrentAccountContractCode);
             feeTransaction.TransactionDate = DateTime.Today;
             feeTransaction.TransactionFees = -1;
             feeTransaction.TransactionMode = "Debit";
             feeTransaction.TransactionType = "Fee";
             int ret = currentAccountTransactionManager.DebitFeeTransaction(feeTransaction);
             if (ret > 0)
             {
                 CurrentAccountEvent currentAccountEvent = new CurrentAccountEvent();
                 currentAccountEvent.ContractCode = productHolding.CurrentAccountContractCode;
                 currentAccountEvent.EventCode = "REFT";
                 currentAccountEvent.Description = "Reopen Fee debit transaction #" + ret;
                 currentAccountEventManager.SaveCurrentAccountEvent(currentAccountEvent);
             }
             return reopenFees;
         }

         public decimal CalculateEntryFees(CurrentAccountProductHoldings productHolding)
         {

             decimal entryFees = 0;

             if (productHolding.ManagementFeesType == "Flat")
             {
                entryFees = productHolding.EntryFees.Value;
             }
             else
                 return 0;

             CurrentAccountTransactions feeTransaction = new CurrentAccountTransactions();
             feeTransaction.Amount = entryFees;
             feeTransaction.Checker = "Fees";
             feeTransaction.FromAccount = productHolding.CurrentAccountContractCode;
             feeTransaction.Maker = "Fees";
             feeTransaction.PurposeOfTransfer = "Entry Fee applied for " + productHolding.CurrentAccountContractCode;
             feeTransaction.ToAccount = FetchBranchAccountNumber(productHolding.CurrentAccountContractCode); 
             feeTransaction.TransactionDate = DateTime.Today;
             feeTransaction.TransactionFees = -1;
             feeTransaction.TransactionMode = "Debit";
             feeTransaction.TransactionType = "Fee";
             int ret = currentAccountTransactionManager.DebitFeeTransaction(feeTransaction);
             if (ret > 0)
             {
                 CurrentAccountEvent currentAccountEvent = new CurrentAccountEvent();
                 currentAccountEvent.ContractCode = productHolding.CurrentAccountContractCode;
                 currentAccountEvent.EventCode = "ENFT";
                 currentAccountEvent.Description = "Entry Fee debit transaction #" + ret;
                 currentAccountEventManager.SaveCurrentAccountEvent(currentAccountEvent);
             }
             return entryFees;
         }


         public decimal CalculateManagementFees(DateTime calculationDate, CurrentAccountProductHoldings productHolding)
         {

             decimal managementFees = 0;

             if (productHolding.ManagementFeesType == "Flat")
             {
                 
                     if ((calculationDate.Month == productHolding.OpenDate.Month) &&
                         (calculationDate.Year == productHolding.OpenDate.Year))
                     {
                         managementFees = productHolding.ManagementFees.Value;
                         double effectiveDays = (calculationDate - productHolding.OpenDate).TotalDays;
                         managementFees = (managementFees / calculationDate.Day) * (decimal)effectiveDays;
                     }
                     else
                     {
                         managementFees = productHolding.ManagementFees.Value;
                     }
                
             }
             else
                 return 0;

             CurrentAccountTransactions feeTransaction = new CurrentAccountTransactions();
             feeTransaction.Amount = managementFees;
             feeTransaction.Checker = "Fees";
             feeTransaction.FromAccount = productHolding.CurrentAccountContractCode;
             feeTransaction.Maker = "Fees";
             feeTransaction.PurposeOfTransfer = "Management Fee applied for " + calculationDate.Month;
             feeTransaction.ToAccount = FetchBranchAccountNumber(productHolding.CurrentAccountContractCode);
             feeTransaction.TransactionDate = DateTime.Today;
             feeTransaction.TransactionFees = -1;
             feeTransaction.TransactionMode = "Debit";
             feeTransaction.TransactionType = "Fee";
             int ret = currentAccountTransactionManager.DebitFeeTransaction(feeTransaction);
             if (ret > 0)
             {
                 CurrentAccountEvent currentAccountEvent = new CurrentAccountEvent();
                 currentAccountEvent.ContractCode = productHolding.CurrentAccountContractCode;
                 currentAccountEvent.EventCode = "MGFT";
                 currentAccountEvent.Description = "Management Fee debit transaction #" + ret;
                 currentAccountEventManager.SaveCurrentAccountEvent(currentAccountEvent);
             }
             return managementFees;             
         }


         public decimal CalculateFixedOverdraftFees(DateTime calculationDate, CurrentAccountProductHoldings productHolding)
         {
             decimal fixedOverdraftFees = 0;

             if (productHolding.OverdraftFeesType == "Flat")
             {
                 if (productHolding.OverdraftApplied == 1)
                 {
                     if ((calculationDate.Month == productHolding.OverdraftAppliedDate.Month) &&
                         (calculationDate.Year == productHolding.OverdraftAppliedDate.Year))
                     {
                         fixedOverdraftFees = productHolding.OverdraftFees.Value;
                         double effectiveDays = (calculationDate - productHolding.OverdraftAppliedDate).TotalDays;
                         fixedOverdraftFees = (fixedOverdraftFees / calculationDate.Day) * (decimal)effectiveDays;
                     }
                     else
                     {
                         fixedOverdraftFees = productHolding.OverdraftFees.Value;
                     }
                 }
                 else
                     return 0;
             }
             else
                 return 0;

              CurrentAccountTransactions feeTransaction = new CurrentAccountTransactions();
              feeTransaction.Amount = fixedOverdraftFees;
                feeTransaction.Checker = "Fees";
                feeTransaction.FromAccount = productHolding.CurrentAccountContractCode;
                feeTransaction.Maker = "Fees";
                feeTransaction.PurposeOfTransfer = "Fixed Overdraft Fee applied for " + calculationDate.Month;
                feeTransaction.ToAccount = FetchBranchAccountNumber(productHolding.CurrentAccountContractCode); 
                feeTransaction.TransactionDate = DateTime.Today;
                feeTransaction.TransactionFees = -1;
                feeTransaction.TransactionMode = "Debit";
                feeTransaction.TransactionType = "Fee";
                int ret = currentAccountTransactionManager.DebitFeeTransaction(feeTransaction);
                if (ret > 0)
                {
                    CurrentAccountEvent currentAccountEvent = new CurrentAccountEvent();
                    currentAccountEvent.ContractCode = productHolding.CurrentAccountContractCode;
                    currentAccountEvent.EventCode = "ODFT";
                    currentAccountEvent.Description = "Fixed Overdraft Fee debit transaction #" + ret;
                    currentAccountEventManager.SaveCurrentAccountEvent(currentAccountEvent);
                }


                return fixedOverdraftFees;
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


         public List<CurrentAccountProductHoldings> FetchProduct(bool showAlsoClosed)
         {
             List<CurrentAccountProductHoldings> currentAccountProductHoldingsList = new List<CurrentAccountProductHoldings>();

             string q = @"SELECT 
[dbo].[CurrentAccountProductHoldings].[id], 
[dbo].[CurrentAccountProductHoldings].[client_id],
[dbo].[CurrentAccountProductHoldings].[client_type],
[dbo].[CurrentAccountProductHoldings].[current_account_contract_code],
[dbo].[CurrentAccountProductHoldings].[current_account_product_id],
[dbo].[CurrentAccountProductHoldings].[initial_amount],
[dbo].[CurrentAccountProductHoldings].[opening_accounting_officer],
[dbo].[CurrentAccountProductHoldings].[closing_accounting_officer],
[dbo].[CurrentAccountProductHoldings].[open_date],
[dbo].[CurrentAccountProductHoldings].[close_date],
[dbo].[CurrentAccountProductHoldings].[status],
[dbo].[CurrentAccountProductHoldings].[comment],
[dbo].[CurrentAccountProductHoldings].[entry_fees],
[dbo].[CurrentAccountProductHoldings].[reopen_fees],
[dbo].[CurrentAccountProductHoldings].[closing_fees],
[dbo].[CurrentAccountProductHoldings].[management_fees],
[dbo].[CurrentAccountProductHoldings].[overdraft_fees],
[dbo].[CurrentAccountProductHoldings].[entry_fees_type],
[dbo].[CurrentAccountProductHoldings].[reopen_fees_type],
[dbo].[CurrentAccountProductHoldings].[closing_fees_type],
[dbo].[CurrentAccountProductHoldings].[management_fees_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_fees_type],
[dbo].[CurrentAccountProductHoldings].[management_fees_frequency],
[dbo].[CurrentAccountProductHoldings].[initial_amount_payment_method],
[dbo].[CurrentAccountProductHoldings].[overdraft_limit],
[dbo].[CurrentAccountProductHoldings].[interest_rate],
[dbo].[CurrentAccountProductHoldings].[interest_calculation_frequency],
[dbo].[CurrentAccountProductHoldings].[initial_amount_account_number],
[dbo].[CurrentAccountProductHoldings].[final_amount_payment_method],
[dbo].[CurrentAccountProductHoldings].[final_amount_account_number],
[dbo].[CurrentAccountProductHoldings].[balance],
[dbo].[CurrentAccountProductHoldings].[overdraft_interest],
[dbo].[CurrentAccountProductHoldings].[overdraft_interest_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_commitment_fee_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_commitment_fee],
[dbo].[CurrentAccountProductHoldings].[overdraft_applied],
[dbo].[CurrentAccountProductHoldings].[overdraft_applied_date],
[dbo].[CurrentAccountProductHoldings].[alloted_overdraft_limit],
[dbo].[CurrentAccountProduct].[current_account_product_name],
[dbo].[CurrentAccountProduct].[current_account_product_code],
[dbo].[Persons].[first_name],
cur.id AS currency_id,
cur.name AS currency_name, 
cur.code AS currency_code,
cur.is_pivot AS currency_is_pivot, 
cur.is_swapped AS currency_is_swapped,
cur.use_cents AS currency_use_cents
FROM [dbo].[CurrentAccountProductHoldings] INNER JOIN [dbo].[CurrentAccountProduct] ON [dbo].CurrentAccountProduct.id = [dbo].CurrentAccountProductHoldings.current_account_product_id
JOIN [dbo].Persons ON [dbo].CurrentAccountProductHoldings.client_id = [dbo].Persons.id
JOIN [dbo].Currencies AS cur ON [dbo].CurrentAccountProduct.currency = cur.id
";

             if (!showAlsoClosed)
                  q += " WHERE [dbo].CurrentAccountProductHoldings.status <> 'Closed'";

             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {


                 using (OpenCbsReader r = c.ExecuteReader())
                 {
                     if (r == null || r.Empty) return null;

                     while (r.Read())
                     {

                         CurrentAccountProductHoldings product = FetchProduct(Convert.ToInt32(r.GetInt("id")));

                         currentAccountProductHoldingsList.Add(product);
                     }
                 }
             }

             return currentAccountProductHoldingsList;

         }



         public List<CurrentAccountProductHoldings> FetchProduct(int clientid, string clientType)
         {
             List<CurrentAccountProductHoldings> currentAccountProductHoldingsList = new List<CurrentAccountProductHoldings>();

             string q = @"SELECT 
[dbo].[CurrentAccountProductHoldings].[id], 
[dbo].[CurrentAccountProductHoldings].[client_id],
[dbo].[CurrentAccountProductHoldings].[client_type],
[dbo].[CurrentAccountProductHoldings].[current_account_contract_code],
[dbo].[CurrentAccountProductHoldings].[current_account_product_id],
[dbo].[CurrentAccountProductHoldings].[initial_amount],
[dbo].[CurrentAccountProductHoldings].[opening_accounting_officer],
[dbo].[CurrentAccountProductHoldings].[closing_accounting_officer],
[dbo].[CurrentAccountProductHoldings].[open_date],
[dbo].[CurrentAccountProductHoldings].[close_date],
[dbo].[CurrentAccountProductHoldings].[status],
[dbo].[CurrentAccountProductHoldings].[comment],
[dbo].[CurrentAccountProductHoldings].[entry_fees],
[dbo].[CurrentAccountProductHoldings].[reopen_fees],
[dbo].[CurrentAccountProductHoldings].[closing_fees],
[dbo].[CurrentAccountProductHoldings].[management_fees],
[dbo].[CurrentAccountProductHoldings].[overdraft_fees],
[dbo].[CurrentAccountProductHoldings].[entry_fees_type],
[dbo].[CurrentAccountProductHoldings].[reopen_fees_type],
[dbo].[CurrentAccountProductHoldings].[closing_fees_type],
[dbo].[CurrentAccountProductHoldings].[management_fees_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_fees_type],
[dbo].[CurrentAccountProductHoldings].[management_fees_frequency],
[dbo].[CurrentAccountProductHoldings].[initial_amount_payment_method],
[dbo].[CurrentAccountProductHoldings].[overdraft_limit],
[dbo].[CurrentAccountProductHoldings].[interest_rate],
[dbo].[CurrentAccountProductHoldings].[interest_calculation_frequency],
[dbo].[CurrentAccountProductHoldings].[initial_amount_account_number],
[dbo].[CurrentAccountProductHoldings].[final_amount_payment_method],
[dbo].[CurrentAccountProductHoldings].[final_amount_account_number],
[dbo].[CurrentAccountProductHoldings].[balance],
[dbo].[CurrentAccountProductHoldings].[overdraft_interest],
[dbo].[CurrentAccountProductHoldings].[overdraft_interest_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_commitment_fee_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_commitment_fee],
[dbo].[CurrentAccountProductHoldings].[overdraft_applied],
[dbo].[CurrentAccountProductHoldings].[overdraft_applied_date],
[dbo].[CurrentAccountProductHoldings].[alloted_overdraft_limit],
[dbo].[CurrentAccountProduct].[current_account_product_name],
[dbo].[CurrentAccountProduct].[current_account_product_code],
[dbo].[Persons].[first_name],
cur.id AS currency_id,
cur.name AS currency_name, 
cur.code AS currency_code,
cur.is_pivot AS currency_is_pivot, 
cur.is_swapped AS currency_is_swapped,
cur.use_cents AS currency_use_cents
FROM [dbo].[CurrentAccountProductHoldings] INNER JOIN [dbo].[CurrentAccountProduct] ON [dbo].CurrentAccountProduct.id = [dbo].CurrentAccountProductHoldings.current_account_product_id
JOIN [dbo].Persons ON [dbo].CurrentAccountProductHoldings.client_id = [dbo].Persons.id
JOIN [dbo].Currencies AS cur ON [dbo].CurrentAccountProduct.currency = cur.id
WHERE [dbo].[CurrentAccountProductHoldings].[client_id] = @ClientId AND [dbo].[CurrentAccountProductHoldings].[client_type] = @ClientType
";

            

             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 c.AddParam("@ClientId", clientid);
                 c.AddParam("@ClientType", clientType);

                 using (OpenCbsReader r = c.ExecuteReader())
                 {
                     if (r == null || r.Empty) return null;

                     while (r.Read())
                     {

                         CurrentAccountProductHoldings product = FetchProduct(Convert.ToInt32(r.GetInt("id")));

                         currentAccountProductHoldingsList.Add(product);
                     }
                 }
             }

             return currentAccountProductHoldingsList;

         }



         public CurrentAccountProductHoldings FetchProduct(int productId)
         {
             const string q = @"SELECT
[dbo].[CurrentAccountProductHoldings].[id], 
[dbo].[CurrentAccountProductHoldings].[client_id],
[dbo].[CurrentAccountProductHoldings].[client_type],
[dbo].[CurrentAccountProductHoldings].[current_account_contract_code],
[dbo].[CurrentAccountProductHoldings].[current_account_product_id],
[dbo].[CurrentAccountProductHoldings].[initial_amount],
[dbo].[CurrentAccountProductHoldings].[opening_accounting_officer],
[dbo].[CurrentAccountProductHoldings].[closing_accounting_officer],
[dbo].[CurrentAccountProductHoldings].[open_date],
[dbo].[CurrentAccountProductHoldings].[close_date],
[dbo].[CurrentAccountProductHoldings].[status],
[dbo].[CurrentAccountProductHoldings].[comment],
[dbo].[CurrentAccountProductHoldings].[entry_fees],
[dbo].[CurrentAccountProductHoldings].[reopen_fees],
[dbo].[CurrentAccountProductHoldings].[closing_fees],
[dbo].[CurrentAccountProductHoldings].[management_fees],
[dbo].[CurrentAccountProductHoldings].[overdraft_fees],
[dbo].[CurrentAccountProductHoldings].[entry_fees_type],
[dbo].[CurrentAccountProductHoldings].[reopen_fees_type],
[dbo].[CurrentAccountProductHoldings].[closing_fees_type],
[dbo].[CurrentAccountProductHoldings].[management_fees_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_fees_type],
[dbo].[CurrentAccountProductHoldings].[management_fees_frequency],
[dbo].[CurrentAccountProductHoldings].[initial_amount_payment_method],
[dbo].[CurrentAccountProductHoldings].[overdraft_limit],
[dbo].[CurrentAccountProductHoldings].[interest_rate],
[dbo].[CurrentAccountProductHoldings].[interest_calculation_frequency],
[dbo].[CurrentAccountProductHoldings].[initial_amount_account_number],
[dbo].[CurrentAccountProductHoldings].[final_amount_payment_method],
[dbo].[CurrentAccountProductHoldings].[final_amount_account_number],
[dbo].[CurrentAccountProductHoldings].[balance],
[dbo].[CurrentAccountProductHoldings].[overdraft_interest],
[dbo].[CurrentAccountProductHoldings].[overdraft_interest_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_commitment_fee_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_commitment_fee],
[dbo].[CurrentAccountProductHoldings].[overdraft_applied],
[dbo].[CurrentAccountProductHoldings].[overdraft_applied_date],
[dbo].[CurrentAccountProductHoldings].[alloted_overdraft_limit],
[dbo].[CurrentAccountProduct].[current_account_product_name],
[dbo].[CurrentAccountProduct].[current_account_product_code],
[dbo].[Persons].[first_name],
cur.id AS currency_id,
cur.name AS currency_name, 
cur.code AS currency_code,
cur.is_pivot AS currency_is_pivot, 
cur.is_swapped AS currency_is_swapped,
cur.use_cents AS currency_use_cents
FROM [dbo].[CurrentAccountProductHoldings] INNER JOIN [dbo].[CurrentAccountProduct] ON [dbo].CurrentAccountProduct.id = [dbo].CurrentAccountProductHoldings.current_account_product_id
JOIN [dbo].Persons ON [dbo].CurrentAccountProductHoldings.client_id = [dbo].Persons.id
JOIN [dbo].Currencies AS cur ON [dbo].CurrentAccountProduct.currency = cur.id
WHERE [dbo].[CurrentAccountProductHoldings].id = @id";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 c.AddParam("@id", productId);

                 using (OpenCbsReader r = c.ExecuteReader())
                 {
                     if (r == null || r.Empty) return null;

                     r.Read();
                     return (CurrentAccountProductHoldings)GetProduct(r);
                 }
             }
         }


         public CurrentAccountProductHoldings FetchProduct(string contractCode)
         {
             const string q = @"SELECT
[dbo].[CurrentAccountProductHoldings].[id], 
[dbo].[CurrentAccountProductHoldings].[client_id],
[dbo].[CurrentAccountProductHoldings].[client_type],
[dbo].[CurrentAccountProductHoldings].[current_account_contract_code],
[dbo].[CurrentAccountProductHoldings].[current_account_product_id],
[dbo].[CurrentAccountProductHoldings].[initial_amount],
[dbo].[CurrentAccountProductHoldings].[opening_accounting_officer],
[dbo].[CurrentAccountProductHoldings].[closing_accounting_officer],
[dbo].[CurrentAccountProductHoldings].[open_date],
[dbo].[CurrentAccountProductHoldings].[close_date],
[dbo].[CurrentAccountProductHoldings].[status],
[dbo].[CurrentAccountProductHoldings].[comment],
[dbo].[CurrentAccountProductHoldings].[entry_fees],
[dbo].[CurrentAccountProductHoldings].[reopen_fees],
[dbo].[CurrentAccountProductHoldings].[closing_fees],
[dbo].[CurrentAccountProductHoldings].[management_fees],
[dbo].[CurrentAccountProductHoldings].[overdraft_fees],
[dbo].[CurrentAccountProductHoldings].[entry_fees_type],
[dbo].[CurrentAccountProductHoldings].[reopen_fees_type],
[dbo].[CurrentAccountProductHoldings].[closing_fees_type],
[dbo].[CurrentAccountProductHoldings].[management_fees_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_fees_type],
[dbo].[CurrentAccountProductHoldings].[management_fees_frequency],
[dbo].[CurrentAccountProductHoldings].[initial_amount_payment_method],
[dbo].[CurrentAccountProductHoldings].[overdraft_limit],
[dbo].[CurrentAccountProductHoldings].[interest_rate],
[dbo].[CurrentAccountProductHoldings].[interest_calculation_frequency],
[dbo].[CurrentAccountProductHoldings].[initial_amount_account_number],
[dbo].[CurrentAccountProductHoldings].[final_amount_payment_method],
[dbo].[CurrentAccountProductHoldings].[final_amount_account_number],
[dbo].[CurrentAccountProductHoldings].[balance],
[dbo].[CurrentAccountProductHoldings].[overdraft_interest],
[dbo].[CurrentAccountProductHoldings].[overdraft_interest_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_commitment_fee_type],
[dbo].[CurrentAccountProductHoldings].[overdraft_commitment_fee],
[dbo].[CurrentAccountProductHoldings].[overdraft_applied],
[dbo].[CurrentAccountProductHoldings].[overdraft_applied_date],
[dbo].[CurrentAccountProductHoldings].[alloted_overdraft_limit],
[dbo].[CurrentAccountProduct].[current_account_product_name],
[dbo].[CurrentAccountProduct].[current_account_product_code],
[dbo].[Persons].[first_name],
cur.id AS currency_id,
cur.name AS currency_name, 
cur.code AS currency_code,
cur.is_pivot AS currency_is_pivot, 
cur.is_swapped AS currency_is_swapped,
cur.use_cents AS currency_use_cents
FROM [dbo].[CurrentAccountProductHoldings] INNER JOIN [dbo].[CurrentAccountProduct] ON [dbo].CurrentAccountProduct.id = [dbo].CurrentAccountProductHoldings.current_account_product_id
JOIN [dbo].Persons ON [dbo].CurrentAccountProductHoldings.client_id = [dbo].Persons.id
JOIN [dbo].Currencies AS cur ON [dbo].CurrentAccountProduct.currency = cur.id
WHERE [dbo].CurrentAccountProductHoldings.current_account_contract_code = @contractCode";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 c.AddParam("@contractCode", contractCode);

                 using (OpenCbsReader r = c.ExecuteReader())
                 {
                     if (r == null || r.Empty) return null;

                     r.Read();
                     return (CurrentAccountProductHoldings)GetProduct(r);
                 }
             }
         }

         public CurrentAccountProductHoldings GetProduct(OpenCbsReader r)
         {
             CurrentAccountProductHoldings currentAccountProductHolding = new CurrentAccountProductHoldings();
currentAccountProductHolding.Id =r.GetInt("id");

currentAccountProductHolding.ClientId =r.GetInt("client_id");

currentAccountProductHolding.ClientType =r.GetString("client_type");

currentAccountProductHolding.CurrentAccountContractCode =r.GetString("current_account_contract_code");

currentAccountProductHolding.CurrentAccountProduct = new CurrentAccountProduct();
currentAccountProductHolding.CurrentAccountProduct = currentAccountProductManager.FetchProduct(r.GetInt("current_account_product_id"));


currentAccountProductHolding.CurrentAccountProduct.Currency = new Currency()
{
    Id = r.GetInt("currency_id"),
    Code = r.GetString("currency_code"),
    Name = r.GetString("currency_name"),
    IsPivot = r.GetBool("currency_is_pivot"),
    IsSwapped = r.GetBool("currency_is_swapped"),
    UseCents = r.GetBool("currency_use_cents")
};
currentAccountProductHolding.InitialAmount =r.GetMoney("initial_amount");

currentAccountProductHolding.OpeningAccountingOfficer =r.GetString("opening_accounting_officer");

currentAccountProductHolding.ClosingAccountingOfficer =r.GetString("closing_accounting_officer");
currentAccountProductHolding.OpenDate=r.GetDateTime("open_date");

currentAccountProductHolding.CloseDate = r.GetDateTime("close_date");

currentAccountProductHolding.Status  =r.GetString("status");

currentAccountProductHolding.Comment =r.GetString("comment");

currentAccountProductHolding.EntryFees = r.GetMoney("entry_fees");

currentAccountProductHolding.ReopenFees = r.GetMoney("reopen_fees");
currentAccountProductHolding.ClosingFees = r.GetMoney("closing_fees");

currentAccountProductHolding.ManagementFees = r.GetMoney("management_fees");

currentAccountProductHolding.OverdraftFees = r.GetMoney("overdraft_fees");

currentAccountProductHolding.EntryFeesType =r.GetString("entry_fees_type");
currentAccountProductHolding.ReopenFeesType =r.GetString("reopen_fees_type");

currentAccountProductHolding.ClosingFeesType =r.GetString("closing_fees_type");

currentAccountProductHolding.ManagementFeesType =r.GetString("management_fees_type");

currentAccountProductHolding.OverdraftFeesType =r.GetString("overdraft_fees_type");

currentAccountProductHolding.ManagementFeesFrequency =r.GetString("management_fees_frequency");

currentAccountProductHolding.InitialAmountPaymentMethod =r.GetString("initial_amount_payment_method");
currentAccountProductHolding.FirstName = r.GetString("first_name");
currentAccountProductHolding.OverdraftLimit = r.GetMoney("overdraft_limit");
currentAccountProductHolding.InterestRate = r.GetNullDouble("interest_rate");
currentAccountProductHolding.InterestCalculationFrequency = r.GetNullInt("interest_calculation_frequency");
currentAccountProductHolding.InitialAmountAccountNumber = r.GetString("initial_amount_account_number");
currentAccountProductHolding.Balance = r.GetMoney("balance");

currentAccountProductHolding.FinalAmountPaymentMethod = r.GetString("final_amount_payment_method");
currentAccountProductHolding.FinalAmountAccountNumber = r.GetString("final_amount_account_number");

currentAccountProductHolding.OverdraftInterest = r.GetNullDouble("overdraft_interest");
 currentAccountProductHolding.OverdraftInterestType = r.GetString("overdraft_interest_type");
currentAccountProductHolding.OverdraftCommitmentFeeType = r.GetString("overdraft_commitment_fee_type");
 currentAccountProductHolding.OverdraftCommitmentFee = r.GetNullDouble("overdraft_commitment_fee");
 currentAccountProductHolding.OverdraftApplied = r.GetNullInt("overdraft_applied");
 currentAccountProductHolding.OverdraftAppliedDate = r.GetDateTime("overdraft_applied_date");
 currentAccountProductHolding.AllotedOverdraftLimit = r.GetNullDecimal("alloted_overdraft_limit");


return currentAccountProductHolding;
         }




         public TransactionSearchResult GetTransactionSearchResult(OpenCbsReader r)
         {
             TransactionSearchResult transactionSearchResult = new TransactionSearchResult();
             transactionSearchResult.Account = r.GetString("Account");
             transactionSearchResult.TransactionDate = r.GetDateTime("Transaction_Date");
             transactionSearchResult.Amount = r.GetDecimal("Amount");
             transactionSearchResult.Balance = r.GetDecimal("Balance");
             return transactionSearchResult;
         }

         public List<TransactionSearchResult> SearchTransaction(string q,DateTime calculationDate, string contractCode)
         {
             List<TransactionSearchResult> listTransaction = new List<TransactionSearchResult>();
             
             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 c.AddParam("@contractCode", contractCode);
                 c.AddParam("@month", calculationDate.Month);

                 using (OpenCbsReader r = c.ExecuteReader())
                 {

                     while (r.Read())
                     {

                         listTransaction.Add(GetTransactionSearchResult(r));
                     }
                 }
             }
             return listTransaction;
         }


        public decimal CurrentAccountOverdraftInterestCalculation(DateTime calculationDate, CurrentAccountProductHoldings productHolding)
        {
            if (productHolding.OverdraftApplied != 1)
                return 0;

            string contractCode = productHolding.CurrentAccountContractCode;

            string q = @" Select From_Account As Account, Transaction_Date, Amount, From_Account_Balance as Balance From CurrentAccountTransactions Where From_Account = @contractCode  And Month(Transaction_Date) = @month
                           UNION
                           Select To_Account As Account, Transaction_Date, Amount, To_Account_Balance as Balance From CurrentAccountTransactions Where To_Account = @contractCode And Month(Transaction_Date) = @month order By Transaction_Date";

            List<TransactionSearchResult> listTransaction = new List<TransactionSearchResult>();
            listTransaction = SearchTransaction(q, calculationDate, contractCode);

            //Fetch opening balance for the month

            CurrentAccountTransactions currentAccountTransactions = currentAccountTransactionManager.FetchMonthClosingBalance(calculationDate.Month - 1, contractCode);
            TransactionSearchResult openingBalanceTransaction = new TransactionSearchResult();

            decimal openingBalance = 0;
            if (currentAccountTransactions != null)
            {
                if (currentAccountTransactions.FromAccount == contractCode)
                    openingBalance = currentAccountTransactions.FromBalance.Value;

                else if (currentAccountTransactions.ToAccount == contractCode)
                    openingBalance = currentAccountTransactions.ToBalance.Value;

                openingBalanceTransaction.Amount = currentAccountTransactions.Amount.Value;
                openingBalanceTransaction.Account = contractCode;
                openingBalanceTransaction.Balance = openingBalance;
                

                if (openingBalance < 0)
                {
                    openingBalanceTransaction.TransactionDate = new DateTime(calculationDate.Year, calculationDate.Month, 1);
                    listTransaction.Insert(0, openingBalanceTransaction);
                }
            }

            //Fetch closing balance for the month
            currentAccountTransactions = currentAccountTransactionManager.FetchMonthClosingBalance(calculationDate.Month, contractCode);
            TransactionSearchResult closingBalanceTransaction = new TransactionSearchResult();

            decimal closingBalance = 0;
            if (currentAccountTransactions != null)
            {
                if (currentAccountTransactions.FromAccount == contractCode)
                    closingBalance = currentAccountTransactions.FromBalance.Value;

                else if (currentAccountTransactions.ToAccount == contractCode)
                    closingBalance = currentAccountTransactions.ToBalance.Value;

                closingBalanceTransaction.Amount = currentAccountTransactions.Amount.Value;
                closingBalanceTransaction.Account = contractCode;
                closingBalanceTransaction.Balance = closingBalance;
              

                if (closingBalance < 0)
                {

                    if ((productHolding.Status == "Closed") && (productHolding.CloseDate.Month == calculationDate.Month) && (productHolding.CloseDate.Year == calculationDate.Year))
                        closingBalanceTransaction.TransactionDate = productHolding.CloseDate;
                    else
                        closingBalanceTransaction.TransactionDate = new DateTime(calculationDate.Year, calculationDate.Month, DateTime.DaysInMonth(calculationDate.Year, calculationDate.Month));

                    listTransaction.Insert(listTransaction.Count, closingBalanceTransaction);
                }
            }




            decimal overdraftInterest = 0;

            for (int i = 0; i < listTransaction.Count-1; i++)
            {
                TransactionSearchResult firstTransaction = listTransaction[i];
                TransactionSearchResult secondTransaction = listTransaction[i + 1];
                if (firstTransaction.Balance < 0)
                {
                    double effectiveDays = (secondTransaction.TransactionDate - firstTransaction.TransactionDate).TotalDays;
                    decimal effectiveBalance = firstTransaction.Balance;
                    double overdraftInterestRate = productHolding.InterestRate.Value;
                    if (i != (listTransaction.Count - 2))
                        overdraftInterest = overdraftInterest + ((effectiveBalance * (decimal)overdraftInterestRate * (decimal)effectiveDays) / (100 * 365));
                    else
                        overdraftInterest = overdraftInterest + ((effectiveBalance * (decimal)overdraftInterestRate * ((decimal)effectiveDays + 1)) / (100 * 365));
                }
            }



            CurrentAccountTransactions interestTransaction = new CurrentAccountTransactions();
            interestTransaction.Amount = -overdraftInterest;
            interestTransaction.Checker = "Interest";
            interestTransaction.FromAccount = productHolding.CurrentAccountContractCode;
            interestTransaction.Maker = "Interest";
            interestTransaction.PurposeOfTransfer = "Overdraft interest debit for month " + calculationDate.Month;
            interestTransaction.ToAccount = FetchBranchAccountNumber(productHolding.CurrentAccountContractCode);
            interestTransaction.TransactionDate = calculationDate;
            interestTransaction.TransactionFees = -1;
            interestTransaction.TransactionMode = "Debit";
            interestTransaction.TransactionType = "Interest";

            int ret = currentAccountTransactionManager.DebitFeeTransaction(interestTransaction);
            if (ret > 0)
            {
                CurrentAccountEvent currentAccountEvent = new CurrentAccountEvent();
                currentAccountEvent.ContractCode = productHolding.CurrentAccountContractCode;
                currentAccountEvent.EventCode = "ODDT";
                currentAccountEvent.Description = "Overdraft Interest debit transaction #" + ret;
                currentAccountEventManager.SaveCurrentAccountEvent(currentAccountEvent);
            }
            return overdraftInterest;
        }

        public decimal CurrentAccountCommitmentFeeCalculation(DateTime calculationDate, CurrentAccountProductHoldings productHolding)
        {
            if (productHolding.OverdraftApplied != 1)
                return 0;
            
            string contractCode = productHolding.CurrentAccountContractCode;

            string q = @" Select From_Account As Account, Transaction_Date, Amount, From_Account_Balance as Balance From CurrentAccountTransactions Where From_Account = @contractCode  And Month(Transaction_Date) = @month
                           UNION
                           Select To_Account As Account, Transaction_Date, Amount, To_Account_Balance as Balance From CurrentAccountTransactions Where To_Account = @contractCode And Month(Transaction_Date) = @month order By Transaction_Date";

            List<TransactionSearchResult> listTransaction = new List<TransactionSearchResult>();
            listTransaction = SearchTransaction(q, calculationDate, contractCode);

            //Fetch opening balance for the month

            CurrentAccountTransactions currentAccountTransactions = currentAccountTransactionManager.FetchMonthClosingBalance(calculationDate.Month - 1, contractCode);
            TransactionSearchResult openingBalanceTransaction = new TransactionSearchResult();

            decimal openingBalance = 0;
            if (currentAccountTransactions != null)
            {
                if (currentAccountTransactions.FromAccount == contractCode)
                    openingBalance = currentAccountTransactions.FromBalance.Value;

                else if (currentAccountTransactions.ToAccount == contractCode)
                    openingBalance = currentAccountTransactions.ToBalance.Value;

                openingBalanceTransaction.Amount = currentAccountTransactions.Amount.Value;
                openingBalanceTransaction.Account = contractCode;
                openingBalanceTransaction.Balance = openingBalance;


                if (openingBalance < 0)
                {
                    openingBalanceTransaction.TransactionDate = new DateTime(calculationDate.Year, calculationDate.Month, 1);
                    listTransaction.Insert(0, openingBalanceTransaction);
                }
            }

            //Fetch closing balance for the month
            currentAccountTransactions = currentAccountTransactionManager.FetchMonthClosingBalance(calculationDate.Month, contractCode);
            TransactionSearchResult closingBalanceTransaction = new TransactionSearchResult();

            decimal closingBalance = 0;
            if (currentAccountTransactions != null)
            {
                if (currentAccountTransactions.FromAccount == contractCode)
                    closingBalance = currentAccountTransactions.FromBalance.Value;

                else if (currentAccountTransactions.ToAccount == contractCode)
                    closingBalance = currentAccountTransactions.ToBalance.Value;

                closingBalanceTransaction.Amount = currentAccountTransactions.Amount.Value;
                closingBalanceTransaction.Account = contractCode;
                closingBalanceTransaction.Balance = closingBalance;


                if (closingBalance < 0)
                {

                    if ((productHolding.Status == "Closed") && (productHolding.CloseDate.Month == calculationDate.Month) && (productHolding.CloseDate.Year == calculationDate.Year))
                        closingBalanceTransaction.TransactionDate = productHolding.CloseDate;
                    else
                        closingBalanceTransaction.TransactionDate = new DateTime(calculationDate.Year, calculationDate.Month, DateTime.DaysInMonth(calculationDate.Year, calculationDate.Month));

                    listTransaction.Insert(listTransaction.Count, closingBalanceTransaction);
                }
            }




            decimal commitmentFee = 0;

            for (int i = 0; i < listTransaction.Count - 1; i++)
            {
                TransactionSearchResult firstTransaction = listTransaction[i];
                TransactionSearchResult secondTransaction = listTransaction[i + 1];
                decimal effectiveBalance = 0;
                if (firstTransaction.Balance < 0)
                {
                    effectiveBalance = productHolding.AllotedOverdraftLimit.Value + firstTransaction.Balance;
                }
                else
                {
                    effectiveBalance = productHolding.AllotedOverdraftLimit.Value;
                }

                double effectiveDays = (secondTransaction.TransactionDate - firstTransaction.TransactionDate).TotalDays;

                double commitmentFeeInterestRate = productHolding.InterestRate.Value;
                if (i != (listTransaction.Count - 2))
                    commitmentFee = commitmentFee + ((effectiveBalance * (decimal)commitmentFeeInterestRate * (decimal)effectiveDays) / (100 * 365));
                else
                    commitmentFee = commitmentFee + ((effectiveBalance * (decimal)commitmentFeeInterestRate * ((decimal)effectiveDays + 1)) / (100 * 365));
            }



            CurrentAccountTransactions interestTransaction = new CurrentAccountTransactions();
            interestTransaction.Amount = commitmentFee;
            interestTransaction.Checker = "Fees";
            interestTransaction.FromAccount = productHolding.CurrentAccountContractCode;
            interestTransaction.Maker = "Fees";
            interestTransaction.PurposeOfTransfer = "Commitment Fees debit for month " + calculationDate.Month;
            interestTransaction.ToAccount = FetchBranchAccountNumber(productHolding.CurrentAccountContractCode);
            interestTransaction.TransactionDate = calculationDate;
            interestTransaction.TransactionFees = -1;
            interestTransaction.TransactionMode = "Debit";
            interestTransaction.TransactionType = "Fee";

            int ret = currentAccountTransactionManager.DebitFeeTransaction(interestTransaction);
            if (ret > 0)
            {
                CurrentAccountEvent currentAccountEvent = new CurrentAccountEvent();
                currentAccountEvent.ContractCode = productHolding.CurrentAccountContractCode;
                currentAccountEvent.EventCode = "CFDT";
                currentAccountEvent.Description = "Commitment Fee debit transaction #" + ret;
                currentAccountEventManager.SaveCurrentAccountEvent(currentAccountEvent);
            }

            return commitmentFee;
        }
        



         public decimal CurrentAccountInterestCalculation(DateTime calculationDate, CurrentAccountProductHoldings productHolding)
         {
             string contractCode = productHolding.CurrentAccountContractCode;

             string q = @" Select From_Account As Account, Transaction_Date, Amount, From_Account_Balance as Balance From CurrentAccountTransactions Where From_Account = @contractCode And Month(Transaction_Date) = @month
                           UNION
                           Select To_Account As Account, Transaction_Date, Amount, To_Account_Balance as Balance From CurrentAccountTransactions Where To_Account = @contractCode And Month(Transaction_Date) = @month order By Transaction_Date";

             List<TransactionSearchResult> listTransaction = new List<TransactionSearchResult>();
             listTransaction = SearchTransaction(q, calculationDate,contractCode);

            //Fetch opening balance for the month
             
             CurrentAccountTransactions currentAccountTransactions = currentAccountTransactionManager.FetchMonthClosingBalance(calculationDate.Month-1,contractCode);
             TransactionSearchResult openingBalanceTransaction = new TransactionSearchResult();

            decimal openingBalance = 0;
            if(currentAccountTransactions!=null)
            {
            if(currentAccountTransactions.FromAccount == contractCode)
                openingBalance = currentAccountTransactions.FromBalance.Value;

            else if(currentAccountTransactions.ToAccount == contractCode)
                openingBalance = currentAccountTransactions.ToBalance.Value;

            openingBalanceTransaction.Amount = currentAccountTransactions.Amount.Value;
            openingBalanceTransaction.Account = contractCode;
            openingBalanceTransaction.Balance = openingBalance;
            openingBalanceTransaction.TransactionDate = currentAccountTransactions.TransactionDate;

            if (openingBalance > 0)
            {
                openingBalanceTransaction.TransactionDate = new DateTime(calculationDate.Year, calculationDate.Month, 1);
                listTransaction.Insert(0, openingBalanceTransaction);
            }
            }
            
            //Fetch closing balance for the month
            currentAccountTransactions = currentAccountTransactionManager.FetchMonthClosingBalance(calculationDate.Month,contractCode);
            TransactionSearchResult closingBalanceTransaction = new TransactionSearchResult();

            decimal closingBalance = 0;
            if(currentAccountTransactions!=null)
            {
                if(currentAccountTransactions.FromAccount == contractCode)
                    closingBalance = currentAccountTransactions.FromBalance.Value;

                else if(currentAccountTransactions.ToAccount == contractCode)
                    closingBalance = currentAccountTransactions.ToBalance.Value;

                closingBalanceTransaction.Amount = currentAccountTransactions.Amount.Value;
                closingBalanceTransaction.Account = contractCode;
                closingBalanceTransaction.Balance = closingBalance;
                closingBalanceTransaction.TransactionDate = currentAccountTransactions.TransactionDate;

                if (closingBalance > 0)
                {
                    if ((productHolding.Status == "Closed") && (productHolding.CloseDate.Month == calculationDate.Month) && (productHolding.CloseDate.Year == calculationDate.Year))
                        closingBalanceTransaction.TransactionDate = productHolding.CloseDate;
                    else
                        closingBalanceTransaction.TransactionDate = new DateTime(calculationDate.Year, calculationDate.Month, DateTime.DaysInMonth(calculationDate.Year, calculationDate.Month));

                    listTransaction.Insert(listTransaction.Count, closingBalanceTransaction);
                }
            }

            decimal interest = 0;

            for (int i = 0; i < listTransaction.Count-1; i++) 
            {
                TransactionSearchResult firstTransaction = listTransaction[i];
                TransactionSearchResult secondTransaction = listTransaction[i+1];
                if (firstTransaction.Balance > 0)
                {
                    double effectiveDays = (secondTransaction.TransactionDate - firstTransaction.TransactionDate).TotalDays;
                    decimal effectiveBalance = firstTransaction.Balance;
                    double interestRate = productHolding.InterestRate.Value;
                    if (i != (listTransaction.Count - 2))
                        interest = interest + ((effectiveBalance * (decimal)interestRate * (decimal)effectiveDays) / (100 * 365));
                    else
                        interest = interest + ((effectiveBalance * (decimal)interestRate * ((decimal)effectiveDays + 1)) / (100 * 365));
                }
            }



            CurrentAccountTransactions interestTransaction = new CurrentAccountTransactions();
            interestTransaction.Amount = interest;
            interestTransaction.Checker = "Interest";
            interestTransaction.FromAccount = FetchBranchAccountNumber(productHolding.CurrentAccountContractCode);
            interestTransaction.Maker = "Interest";
            interestTransaction.PurposeOfTransfer = "Regular interest credit for month " + calculationDate.Month;
            interestTransaction.ToAccount = productHolding.CurrentAccountContractCode; 
            interestTransaction.TransactionDate = calculationDate;
            interestTransaction.TransactionFees = -1;
            interestTransaction.TransactionMode = "Credit";
            interestTransaction.TransactionType = "Interest";

            currentAccountTransactionManager.DebitFeeTransaction(interestTransaction);
             return interest;
}

             
         }


    }