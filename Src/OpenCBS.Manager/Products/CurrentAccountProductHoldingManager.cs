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


         public int SaveCurrentAccountPoductHolding(CurrentAccountProductHoldings productName)
         {
             //int identity;
             const string q = @"INSERT INTO [CurrentAccountProductHoldings]
          ( [client_id],
[client_type],
[current_account_contract_code],
[current_account_productId],
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
[initial_amount_payment_method])
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
@initialAmountPaymentMethod)
                SELECT SCOPE_IDENTITY()";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 SetProduct(c, productName);
                 productName.Id = Convert.ToInt32(c.ExecuteScalar());
             }
             return productName.Id;
         }

         private static void SetProduct(OpenCbsCommand c, CurrentAccountProductHoldings product)
         {
             c.AddParam("@clientId", product.ClientId);
             c.AddParam("@clientType", product.ClientType);
             c.AddParam("@currentAccountContractCode", product.CurrentAccountContractCode);
             c.AddParam("@currentAccountProductId", product.CurrentAccountProductId);
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
         }

         public void UpdateCurrentAccountProductHolding(CurrentAccountProductHoldings product, int productId)
         {
             string q = @"UPDATE [CurrentAccountProductHoldings] SET 
[client_id] = @clientId,
[client_type] = @clientType,
[current_account_contract_code] = @currentAccountContractCode,
[current_account_productId] = @currentAccounPproductId,
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
[initial_amount_payment_method] = @initialAmountPaymentMethod
WHERE id = @productId";


             using (SqlConnection conn = GetConnection())
             using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
             {
                 c.AddParam("@productId", productId);
                 SetProduct(c, product);
                 c.ExecuteNonQuery();
             }
         }


         public List<CurrentAccountProductHoldings> FetchProduct(bool showAlsoDeleted, int productId)
         {
             List<CurrentAccountProductHoldings> currentAccountProductHoldingsList = new List<CurrentAccountProductHoldings>();

             string q = @"SELECT 
[id], 
[client_id],
[client_type],
[current_account_contract_code],
[current_account_productId],
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
[initial_amount_payment_method]
 FROM CurrentAccountProductHolding";

             if (!showAlsoDeleted)
                 q += " WHERE deleted = 0";
             else
                 q += " WHERE deleted = 1";

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
         public CurrentAccountProductHoldings FetchProduct(int productId)
         {
             const string q = @"SELECT
[id], 
[client_id],
[client_type],
[current_account_contract_code],
[current_account_productId],
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
[initial_amount_payment_method]
 FROM CurrentAccountProductHolding WHERE id = @id";


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

         public CurrentAccountProductHoldings GetProduct(OpenCbsReader r)
         {
             CurrentAccountProductHoldings currentAccountProductHolding = new CurrentAccountProductHoldings();
currentAccountProductHolding.Id =r.GetInt("id");

currentAccountProductHolding.ClientId =r.GetInt("client_id");

currentAccountProductHolding.ClientType =r.GetString("client_type");

currentAccountProductHolding.CurrentAccountContractCode =r.GetMoney("current_account_contract_code");

currentAccountProductHolding.CurrentAccountProductId =r.GetMoney("current_account_productId");

currentAccountProductHolding.InitialAmount =r.GetMoney("initial_amount");

currentAccountProductHolding.OpeningAccountingOfficer =r.GetMoney("opening_accounting_officer");

currentAccountProductHolding.ClosingAccountingOfficer =r.GetMoney("closing_accounting_officer");
currentAccountProductHolding.OpenDate=r.GetMoney("open_date");

currentAccountProductHolding.CloseDate =r.GetMoney("close_date");

currentAccountProductHolding.Status  =r.GetMoney("status");

currentAccountProductHolding.Comment =r.GetMoney("comment");

currentAccountProductHolding.EntryFees =r.GetMoney("entry_fees");

currentAccountProductHolding.ReopenFees =r.GetMoney("reopen_fees");
currentAccountProductHolding.ClosingFees =r.GetMoney("closing_fees");

currentAccountProductHolding.ManagementFees =r.GetMoney("management_fees");

currentAccountProductHolding.OverdraftFees =r.GetMoney("overdraft_fees");

currentAccountProductHolding.EntryFeesType =r.GetMoney("entry_fees_type");
currentAccountProductHolding.ReopenFeesType =r.GetMoney("reopen_fees_type");

currentAccountProductHolding.ClosingFeesType =r.GetMoney("closing_fees_type");

currentAccountProductHolding.ManagementFeesType =r.GetMoney("management_fees_type");

currentAccountProductHolding.OverdraftFeesType =r.GetMoney("overdraft_fees_type");

currentAccountProductHolding.ManagementFeesFrequency =r.GetMoney("management_fees_frequency");

currentAccountProductHolding.InitialAmountPaymentMethod =r.GetMoney("initial_amount_payment_method");

return currentAccountProductHolding;
         }


    }
}
