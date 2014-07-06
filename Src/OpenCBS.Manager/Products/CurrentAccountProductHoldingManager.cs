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
    public class CurrentAccountProductHoldingManager : Manager
    {
         public CurrentAccountProductHoldingManager(User pUser) : base(pUser)
        {
        }

         public CurrentAccountProductHoldingManager(string testDB)
             : base(testDB)
        {
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
[balance]
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
@balance
)
                SELECT SCOPE_IDENTITY()";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 SetProduct(c, productName);
                 productName.Id = Convert.ToInt32(c.ExecuteScalar());
                 productName.CurrentAccountContractCode = productName.CurrentAccountContractCode + "/" + productName.Id;
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
[balance] = @balance
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
[balance] = @balance
WHERE current_account_contract_code = @contractCode";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 c.AddParam("@contractCode", contractCode);
                 SetProduct(c, product);
                 c.ExecuteNonQuery();
             }
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
[dbo].[CurrentAccountProduct].[current_account_product_name],
[dbo].[CurrentAccountProduct].[current_account_product_code],
[dbo].[Persons].[first_name]
FROM [dbo].[CurrentAccountProductHoldings] INNER JOIN [dbo].[CurrentAccountProduct] ON [dbo].CurrentAccountProduct.id = [dbo].CurrentAccountProductHoldings.current_account_product_id
JOIN [dbo].Persons ON [dbo].CurrentAccountProductHoldings.client_id = [dbo].Persons.id
";

             if (!showAlsoClosed)
                  q += " WHERE [dbo].CurrentAccountProductHoldings.status = 'Opened'";

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
[dbo].[CurrentAccountProduct].[current_account_product_name],
[dbo].[CurrentAccountProduct].[current_account_product_code],
[dbo].[Persons].[first_name]
FROM [dbo].[CurrentAccountProductHoldings] INNER JOIN [dbo].[CurrentAccountProduct] ON [dbo].CurrentAccountProduct.id = [dbo].CurrentAccountProductHoldings.current_account_product_id
JOIN [dbo].Persons ON [dbo].CurrentAccountProductHoldings.client_id = [dbo].Persons.id
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
[dbo].[CurrentAccountProduct].[current_account_product_name],
[dbo].[CurrentAccountProduct].[current_account_product_code],
[dbo].[Persons].[first_name]
FROM [dbo].[CurrentAccountProductHoldings] INNER JOIN [dbo].[CurrentAccountProduct] ON [dbo].CurrentAccountProduct.id = [dbo].CurrentAccountProductHoldings.current_account_product_id
JOIN [dbo].Persons ON [dbo].CurrentAccountProductHoldings.client_id = [dbo].Persons.id
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
[dbo].[CurrentAccountProduct].[current_account_product_name],
[dbo].[CurrentAccountProduct].[current_account_product_code],
[dbo].[Persons].[first_name]
FROM [dbo].[CurrentAccountProductHoldings] INNER JOIN [dbo].[CurrentAccountProduct] ON [dbo].CurrentAccountProduct.id = [dbo].CurrentAccountProductHoldings.current_account_product_id
JOIN [dbo].Persons ON [dbo].CurrentAccountProductHoldings.client_id = [dbo].Persons.id
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
currentAccountProductHolding.CurrentAccountProduct.Id = r.GetInt("current_account_product_id");
currentAccountProductHolding.CurrentAccountProduct.CurrentAccountProductName = r.GetString("current_account_product_name");
currentAccountProductHolding.CurrentAccountProduct.CurrentAccountProductCode = r.GetString("current_account_product_code");

currentAccountProductHolding.InitialAmount =r.GetDecimal("initial_amount");

currentAccountProductHolding.OpeningAccountingOfficer =r.GetString("opening_accounting_officer");

currentAccountProductHolding.ClosingAccountingOfficer =r.GetString("closing_accounting_officer");
currentAccountProductHolding.OpenDate=r.GetDateTime("open_date");

currentAccountProductHolding.CloseDate = r.GetDateTime("close_date");

currentAccountProductHolding.Status  =r.GetString("status");

currentAccountProductHolding.Comment =r.GetString("comment");

currentAccountProductHolding.EntryFees = r.GetDecimal("entry_fees");

currentAccountProductHolding.ReopenFees = r.GetDecimal("reopen_fees");
currentAccountProductHolding.ClosingFees = r.GetDecimal("closing_fees");

currentAccountProductHolding.ManagementFees = r.GetDecimal("management_fees");

currentAccountProductHolding.OverdraftFees = r.GetDecimal("overdraft_fees");

currentAccountProductHolding.EntryFeesType =r.GetString("entry_fees_type");
currentAccountProductHolding.ReopenFeesType =r.GetString("reopen_fees_type");

currentAccountProductHolding.ClosingFeesType =r.GetString("closing_fees_type");

currentAccountProductHolding.ManagementFeesType =r.GetString("management_fees_type");

currentAccountProductHolding.OverdraftFeesType =r.GetString("overdraft_fees_type");

currentAccountProductHolding.ManagementFeesFrequency =r.GetString("management_fees_frequency");

currentAccountProductHolding.InitialAmountPaymentMethod =r.GetString("initial_amount_payment_method");
currentAccountProductHolding.FirstName = r.GetString("first_name");
currentAccountProductHolding.OverdraftLimit = r.GetDecimal("overdraft_limit");
currentAccountProductHolding.InterestRate = r.GetDouble("interest_rate");
currentAccountProductHolding.InterestCalculationFrequency = r.GetInt("interest_calculation_frequency");
currentAccountProductHolding.InitialAmountAccountNumber = r.GetString("initial_amount_account_number");
currentAccountProductHolding.Balance = r.GetDecimal("balance");

currentAccountProductHolding.FinalAmountPaymentMethod = r.GetString("final_amount_payment_method");
currentAccountProductHolding.FinalAmountAccountNumber = r.GetString("final_amount_account_number");

return currentAccountProductHolding;
         }


    }
}
