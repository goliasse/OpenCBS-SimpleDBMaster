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
    public class CurrentAccountProductManager : Manager
    {

        public CurrentAccountProductManager(User pUser) : base(pUser)
        {
        }

        public CurrentAccountProductManager(string testDB) : base(testDB)
        {
        }


        public int SaveCurrentAccountProduct(ICurrentAccountProduct currentAccountProduct)
        {
            
            const string q = @"INSERT INTO [CurrentAccountProduct]
           ([deleted],
[current_account_product_name],
[current_account_product_code], 
[client_type],
[currency],
[initial_amount_min], 
[initial_amount_max], 
[balance_min], 
[balance_max], 
[entry_fees_type], 
[reopen_fees_type],
[closing_fees_type], 
[management_fees_type],
[overdraft_type],
[entry_fees_min], 
[reopen_fees_min], 
[closing_fees_min], 
[management_fees_min],
[overdraft_min], 
[entry_fees_max], 
[reopen_fees_max],
[closing_fees_max], 
[management_fees_max],
[overdraft_max], 
[entry_fees_value], 
[reopen_fees_value], 
[closing_fees_value], 
[management_fees_value], 
[overdraft_value], 
[management_fees_frequency],
[interest_min],
[interest_max],
[interest_type],
[interest_value],
[interest_frequency],
[overdraft_limit],
[overdraft_interest_type],
[overdraft_interest_value],
[overdraft_interest_min],
[overdraft_interest_max],
[commitment_fee_type],
[commitment_fee_min],
[commitment_fee_max],
[commitment_fee_value],
[overdraft_limit_min],
[overdraft_limit_max]
)
                VALUES
                (@delete,
@currentAccountProductName,
@currentAccountProductCode,
@clientType,
@currency,
@initialAmountMin,
@initialAmountMax,
@balanceMin,
@balanceMax,
@entryFeesType,
@reopenFeesType,
@closingFeesType,
@managementFeesType,
@overdraftType,
@entryFeesMin,
@reopenFeesMin,
@closingFeesMin,
@managementFeesMin,
@overdraftMin,
@entryFeesMax,
@reopenFeesMax,
@closingFeesMax,
@managementFeesMax,
@overdraftMax,
@entryFeesValue,
@reopenFeesValue,
@closingFeesValue,
@managementFeesValue,
@overdraftValue,
@managementFeesFrequency,
@interestMin,
@interestMax,
@interestType,
@interestValue,
@interestFrequency,
@overdraftLimt,
@overdraftInterestType,
@overdraftInterestValue,
@overdraftInterestMin,
@overdraftInterestMax,
@commitmentFeeType,
@commitmentFeeMin,
@commitmentFeeMax,
@commitmentFeeValue,
@overdraftLimitMin,
@overdraftLimitMax
)
                SELECT SCOPE_IDENTITY()";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetProduct(c, currentAccountProduct);
                currentAccountProduct.Id = Convert.ToInt32(c.ExecuteScalar());
                
            }
            return currentAccountProduct.Id;
        }



        public static void SetProduct(OpenCbsCommand c, ICurrentAccountProduct product)
        {
            c.AddParam("@delete", product.Delete);
            c.AddParam("@currentAccountProductName", product.CurrentAccountProductName);
            c.AddParam("@currentAccountProductCode", product.CurrentAccountProductCode);
            c.AddParam("@clientType", product.ClientType);
            c.AddParam("@currency", product.Currency);
            c.AddParam("@initialAmountMin", product.InitialAmountMin);
            c.AddParam("@initialAmountMax", product.InitialAmountMax);
            c.AddParam("@balanceMin", product.BalanceMin);
            c.AddParam("@balanceMax", product.BalanceMax);
            c.AddParam("@entryFeesType", product.EntryFeesType);
            c.AddParam("@reopenFeesType", product.ReopenFeesType);
            c.AddParam("@closingFeesType", product.ClosingFeesType);
            c.AddParam("@managementFeesType", product.ManagementFeesType);
            c.AddParam("@overdraftType", product.OverdraftType);
            c.AddParam("@entryFeesMin", product.EntryFeesMin);
            c.AddParam("@reopenFeesMin", product.ReopenFeesMin);
            c.AddParam("@closingFeesMin", product.ClosingFeesMin);
            c.AddParam("@managementFeesMin", product.ManagementFeesMin);
            c.AddParam("@overdraftMin", product.OverdraftMin);
            c.AddParam("@entryFeesMax", product.EntryFeesMax);
            c.AddParam("@reopenFeesMax", product.ReopenFeesMax);
            c.AddParam("@closingFeesMax", product.ClosingFeesMax);
            c.AddParam("@managementFeesMax", product.ManagementFeesMax);
            c.AddParam("@overdraftMax", product.OverdraftMax);
            c.AddParam("@entryFeesValue", product.EntryFeesValue);
            c.AddParam("@reopenFeesValue", product.ReopenFeesValue);
            c.AddParam("@closingFeesValue", product.ClosingFeesValue);
            c.AddParam("@managementFeesValue", product.ManagementFeesValue);
            c.AddParam("@overdraftValue", product.OverdraftValue);
            c.AddParam("@managementFeesFrequency", product.ManagementFeesFrequency);
            c.AddParam("@interestMin ", product.InterestMin);
            c.AddParam("@interestMax ", product.InterestMax);
            c.AddParam("@interestType", product.InterestType);
            c.AddParam("@interestValue ", product.InterestValue);
            c.AddParam("@interestFrequency ", product.InterestFrequency);
            c.AddParam("@overdraftLimt ", product.OverdraftLimit);
            c.AddParam("@overdraftInterestType", product.OverdraftInterestType);
c.AddParam("@overdraftInterestValue", product.OverdraftInterestValue);
c.AddParam("@overdraftInterestMin", product.OverdraftInterestMin);
c.AddParam("@overdraftInterestMax", product.OverdraftInterestMax);
c.AddParam("@commitmentFeeType", product.CommitmentFeeType);
c.AddParam("@commitmentFeeMin", product.CommitmentFeeMin);
c.AddParam("@commitmentFeeMax", product.CommitmentFeeMax);
c.AddParam("@commitmentFeeValue", product.CommitmentFeeValue);
c.AddParam("@overdraftLimitMin", product.OverdraftLimitMin);
c.AddParam("@overdraftLimitMax", product.OverdraftLimitMax);
        }

        public void UpdateCurrentAccountProduct(ICurrentAccountProduct product, int productId)
        {
            string q = @"UPDATE [CurrentAccountProduct] SET 
[current_account_product_name] = @currentAccountProductName,
[current_account_product_code] = @currentAccountProductCode, 
[client_type] = @clientType,
[currency] = @currency,
[initial_amount_min] = @initialAmountMin, 
[initial_amount_max] = @initialAmountMax, 
[balance_min] = @balanceMin, 
[balance_max] = @balanceMax, 
[entry_fees_type] = @entryFeesType, 
[reopen_fees_type] = @reopenFeesType,
[closing_fees_type] = @closingFeesType, 
[management_fees_type] = @managementFeesType,
[overdraft_type] = @overdraftType,
[entry_fees_min] = @entryFeesMin, 
[reopen_fees_min] = @reopenFeesMin, 
[closing_fees_min] = @closingFeesMin, 
[management_fees_min] = @managementFeesMin,
[overdraft_min] = @overdraftMin, 
[entry_fees_max] = @entryFeesMax, 
[reopen_fees_max] = @reopenFeesMax,
[closing_fees_max] = @closingFeesMax, 
[management_fees_max] = @managementFeesMax,
[overdraft_max] = @overdraftMax, 
[entry_fees_value] = @entryFeesValue, 
[reopen_fees_value] = @reopenFeesValue, 
[closing_fees_value] = @closingFeesValue, 
[management_fees_value] = @managementFeesValue, 
[overdraft_value] = @overdraftValue, 
[management_fees_frequency] = @managementFeesFrequency,
[interest_min] = @interestMin,
[interest_max] = @interestMax,
[interest_type] = @interestType,
[interest_value] = @interestValue,
[interest_frequency] = @interestFrequency,
[overdraft_limit] = @overdraftLimt,
[overdraft_interest_type] = @overdraftInterestType,
[overdraft_interest_value] = @overdraftInterestValue,
[overdraft_interest_min] = @overdraftInterestMin,
[overdraft_interest_max] = @overdraftInterestMax,
[commitment_fee_type]= @commitmentFeeType,
[commitment_fee_min] = @commitmentFeeMin,
[commitment_fee_max] = @commitmentFeeMax,
[commitment_fee_value] = @commitmentFeeValue,
[overdraft_limit_min] = @overdraftLimitMin,
[overdraft_limit_max] = @overdraftLimitMax
WHERE id = @productId";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productId", productId);
                SetProduct(c, product);
                c.ExecuteNonQuery();
            }
        }


        public CurrentAccountProduct FetchProduct(int currentAccountProductId)
        {
            const string q = @"SELECT 
[id],
[deleted],
[current_account_product_name],
[current_account_product_code], 
[client_type],
[currency],
[initial_amount_min], 
[initial_amount_max], 
[balance_min], 
[balance_max], 
[entry_fees_type], 
[reopen_fees_type],
[closing_fees_type], 
[management_fees_type],
[overdraft_type],
[entry_fees_min], 
[reopen_fees_min], 
[closing_fees_min], 
[management_fees_min],
[overdraft_min], 
[entry_fees_max], 
[reopen_fees_max],
[closing_fees_max], 
[management_fees_max],
[overdraft_max], 
[entry_fees_value], 
[reopen_fees_value], 
[closing_fees_value], 
[management_fees_value], 
[overdraft_value], 
[management_fees_frequency],
[interest_min],
[interest_max],
[interest_type],
[interest_value],
[interest_frequency],
[overdraft_limit],
[overdraft_interest_type],
[overdraft_interest_value],
[overdraft_interest_min],
[overdraft_interest_max],
[commitment_fee_type],
[commitment_fee_min],
[commitment_fee_max],
[commitment_fee_value],
[overdraft_limit_min],
[overdraft_limit_max] 
FROM CurrentAccountProduct WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@id", currentAccountProductId);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (CurrentAccountProduct)GetProduct(r);
                }
            }
        }



        public CurrentAccountProduct FetchProduct(string productName, string productCode)
        {
            const string q = @"SELECT 
[id],
[deleted],
[current_account_product_name],
[current_account_product_code], 
[client_type],
[currency],
[initial_amount_min], 
[initial_amount_max], 
[balance_min], 
[balance_max], 
[entry_fees_type], 
[reopen_fees_type],
[closing_fees_type], 
[management_fees_type],
[overdraft_type],
[entry_fees_min], 
[reopen_fees_min], 
[closing_fees_min], 
[management_fees_min],
[overdraft_min], 
[entry_fees_max], 
[reopen_fees_max],
[closing_fees_max], 
[management_fees_max],
[overdraft_max], 
[entry_fees_value], 
[reopen_fees_value], 
[closing_fees_value], 
[management_fees_value], 
[overdraft_value], 
[management_fees_frequency],
[interest_min],
[interest_max],
[interest_type],
[interest_value],
[interest_frequency],
[overdraft_limit],
[overdraft_interest_type],
[overdraft_interest_value],
[overdraft_interest_min],
[overdraft_interest_max],
[commitment_fee_type],
[commitment_fee_min],
[commitment_fee_max],
[commitment_fee_value],
[overdraft_limit_min],
[overdraft_limit_max] 
FROM CurrentAccountProduct 
WHERE current_account_product_name = @productName and current_account_product_code = @productCode";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productName", productName);
                c.AddParam("@productCode", productCode);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (CurrentAccountProduct)GetProduct(r);
                }
            }
        }



        public List<ICurrentAccountProduct> FetchProduct(bool showAlsoDeleted)
        {
            List<ICurrentAccountProduct> currentAccountProductList = new List<ICurrentAccountProduct>();

            string q = @"SELECT 
[id],
[deleted],
[current_account_product_name],
[current_account_product_code], 
[client_type],
[currency],
[initial_amount_min], 
[initial_amount_max], 
[balance_min], 
[balance_max], 
[entry_fees_type], 
[reopen_fees_type],
[closing_fees_type], 
[management_fees_type],
[overdraft_type],
[entry_fees_min], 
[reopen_fees_min], 
[closing_fees_min], 
[management_fees_min],
[overdraft_min], 
[entry_fees_max], 
[reopen_fees_max],
[closing_fees_max], 
[management_fees_max],
[overdraft_max], 
[entry_fees_value], 
[reopen_fees_value], 
[closing_fees_value], 
[management_fees_value], 
[overdraft_value], 
[management_fees_frequency],
[interest_min],
[interest_max],
[interest_type],
[interest_value],
[interest_frequency],
[overdraft_limit],
[overdraft_interest_type],
[overdraft_interest_value],
[overdraft_interest_min],
[overdraft_interest_max],
[commitment_fee_type],
[commitment_fee_min],
[commitment_fee_max],
[commitment_fee_value],
[overdraft_limit_min],
[overdraft_limit_max]
FROM CurrentAccountProduct";

            if (!showAlsoDeleted)
                q += " WHERE deleted = 0";
            

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    while (r.Read())
                    {

                        CurrentAccountProduct product = FetchProduct(Convert.ToInt32(r.GetNullInt("id")));

                        currentAccountProductList.Add(product);
                    }
                }
            }

            return currentAccountProductList;

        }



        




        public CurrentAccountProduct GetProduct(OpenCbsReader r)
{
CurrentAccountProduct currentAccountProduct = new CurrentAccountProduct();
currentAccountProduct.Id = r.GetInt("id"); 
currentAccountProduct.Delete = r.GetNullInt("deleted");
currentAccountProduct.CurrentAccountProductName = r.GetString("current_account_product_name");
currentAccountProduct.CurrentAccountProductCode = r.GetString ("current_account_product_code");
currentAccountProduct.ClientType = r.GetString ("client_type");
currentAccountProduct.Currency = r.GetString ("currency");

currentAccountProduct.InitialAmountMin = r.GetNullDecimal("initial_amount_min");

currentAccountProduct.InitialAmountMax = r.GetNullDecimal("initial_amount_max");

currentAccountProduct.BalanceMin = r.GetNullDecimal("balance_min");

currentAccountProduct.BalanceMax = r.GetNullDecimal("balance_max");
currentAccountProduct.EntryFeesType =	r.GetString("entry_fees_type");

currentAccountProduct.ReopenFeesType = r.GetString("reopen_fees_type");

currentAccountProduct.ClosingFeesType = r.GetString("closing_fees_type");

currentAccountProduct.ManagementFeesType = r.GetString("management_fees_type");

currentAccountProduct.OverdraftType = r.GetString("overdraft_type");

currentAccountProduct.EntryFeesMin = r.GetNullDecimal("entry_fees_min");

currentAccountProduct.ReopenFeesMin = r.GetNullDecimal("reopen_fees_min");

currentAccountProduct.ClosingFeesMin = r.GetNullDecimal("closing_fees_min");

currentAccountProduct.ManagementFeesMin = r.GetNullDecimal("management_fees_min");

currentAccountProduct.OverdraftMin = r.GetNullDecimal("overdraft_min");

currentAccountProduct.EntryFeesMax = r.GetNullDecimal("entry_fees_max");

currentAccountProduct.ReopenFeesMax = r.GetNullDecimal("reopen_fees_max");

currentAccountProduct.ClosingFeesMax = r.GetNullDecimal("closing_fees_max");
currentAccountProduct.ManagementFeesMax = r.GetNullDecimal("management_fees_max");

currentAccountProduct.OverdraftMax = r.GetNullDecimal("overdraft_max");
currentAccountProduct.EntryFeesValue = r.GetNullDecimal("entry_fees_value");

currentAccountProduct.ReopenFeesValue = r.GetNullDecimal("reopen_fees_value");

currentAccountProduct.ClosingFeesValue = r.GetNullDecimal("closing_fees_value");

currentAccountProduct.ManagementFeesValue = r.GetNullDecimal("management_fees_value");

currentAccountProduct.OverdraftValue = r.GetNullDecimal("overdraft_value");
currentAccountProduct.ManagementFeesFrequency = r.GetString("management_fees_frequency");

currentAccountProduct.InterestMin = r.GetNullDouble("interest_min");
currentAccountProduct.InterestMax = r.GetNullDouble("interest_max");
currentAccountProduct.InterestType = r.GetString("interest_type");
currentAccountProduct.InterestValue = r.GetNullDouble("interest_value");
currentAccountProduct.InterestFrequency = r.GetNullInt("interest_frequency");
currentAccountProduct.OverdraftLimit = r.GetNullDecimal("overdraft_limit");
currentAccountProduct.OverdraftInterestType = r.GetString("overdraft_interest_type");
currentAccountProduct.OverdraftInterestValue = r.GetNullDouble("overdraft_interest_value");
currentAccountProduct.OverdraftInterestMin = r.GetNullDouble("overdraft_interest_min");
currentAccountProduct.OverdraftInterestMax = r.GetNullDouble("overdraft_interest_max");
currentAccountProduct.CommitmentFeeType = r.GetString("commitment_fee_type");
currentAccountProduct.CommitmentFeeMin = r.GetNullDouble("commitment_fee_min");
currentAccountProduct.CommitmentFeeMax = r.GetNullDouble("commitment_fee_max");
currentAccountProduct.CommitmentFeeValue = r.GetNullDouble("commitment_fee_value");
currentAccountProduct.OverdraftLimitMin = r.GetNullDecimal("overdraft_limit_min");
currentAccountProduct.OverdraftLimitMax = r.GetNullDecimal("overdraft_limit_max");

return currentAccountProduct;
}

        public void DeleteCurrentAccountProduct(int pProductId)
        {
            const string q = "Update CurrentAccountProducts Set Deleted = 1 Where id = @productId";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productId", pProductId);
                c.ExecuteNonQuery();
            }
        }



        public int SaveCurrentAccountTransactionFees(CurrentAccountTransactionFees currentAccountTransactionFees)
{
 const string q = @"INSERT INTO [CurrentAccountTransactionFees]
           ([current_account_product_id],
		[transaction_type],
		[transaction_fees_type],
		[transaction_fees],
		[transaction_fees_min],
		[transaction_fees_max],
		[transaction_mode])
                VALUES
                (@currentAccountProductId
                ,@transactionType
                ,@transactionFeesType
                ,@transactionFees
                ,@transactionFeeMin
                ,@transactionFeeMax
                ,@transactionMode)
         
                SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {


                SetTransactionFee(c, currentAccountTransactionFees);
                currentAccountTransactionFees.Id = Convert.ToInt32(c.ExecuteScalar());
            }


            return currentAccountTransactionFees.Id;
}


        public void SetTransactionFee(OpenCbsCommand c, CurrentAccountTransactionFees currentAccountTransactionFees)
{
c.AddParam("@currentAccountProductId",currentAccountTransactionFees.CurrentAccountProductId);
c.AddParam("@transactionType",currentAccountTransactionFees. TransactionType);
c.AddParam("@transactionFeesType",currentAccountTransactionFees. TransactionFeesType);
c.AddParam("@transactionFees",currentAccountTransactionFees. TransactionFees);
c.AddParam("@transactionFeesMin",currentAccountTransactionFees. TransactionFeeMin);
c.AddParam("@transactionFeesMax",currentAccountTransactionFees. TransactionFeeMax);
c.AddParam("@transactionMode",currentAccountTransactionFees. TransactionMode);
}

public CurrentAccountTransactionFees GetTransactionFee(OpenCbsReader r)
{
    CurrentAccountTransactionFees currentAccountTransactionFees = new CurrentAccountTransactionFees();
currentAccountTransactionFees.Id = r.GetInt("id");
currentAccountTransactionFees.CurrentAccountProductId = r.GetInt("current_account_product_id");
currentAccountTransactionFees.TransactionType = r.GetString("transaction_type");
currentAccountTransactionFees.TransactionFeesType= r.GetString("transaction_fees_type");
currentAccountTransactionFees.TransactionFees= r.GetNullDecimal("transaction_fees");
currentAccountTransactionFees.TransactionFeeMin= r.GetNullDecimal("transaction_fees_min");
currentAccountTransactionFees.TransactionFeeMax= r.GetNullDecimal("transaction_fees_max");
currentAccountTransactionFees.TransactionMode= r.GetString("transaction_mode");

    return currentAccountTransactionFees;
}


public List<CurrentAccountTransactionFees> FetchTransactionFee(int productId)
{

    List<CurrentAccountTransactionFees> currentAccountTransactionFeesList = new List<CurrentAccountTransactionFees>();
    string q = @"SELECT
		[id],
	        [current_account_product_id],
		[transaction_type],
		[transaction_fees_type],
		[transaction_fees],
		[transaction_fees_min],
		[transaction_fees_max],
		[transaction_mode] FROM [dbo].[CurrentAccountTransactionFees]
            WHERE current_account_product_id = @productId";





    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
        using (OpenCbsReader r = c.ExecuteReader())
        {
            c.AddParam("@productId", productId);
            if (r == null || r.Empty) return new List<CurrentAccountTransactionFees>();
            while (r.Read())
            {
                CurrentAccountTransactionFees product = FetchTransaction(Convert.ToInt32(r.GetNullInt("id")));

                currentAccountTransactionFeesList.Add(product);
            }
        }
    }

    return currentAccountTransactionFeesList;


}



public CurrentAccountTransactionFees FetchTransaction(int transactionId)
{

    
    string q = @"SELECT
		[id],
	        [current_account_product_id],
		[transaction_type],
		[transaction_fees_type],
		[transaction_fees],
		[transaction_fees_min],
		[transaction_fees_max],
		[transaction_mode] FROM [dbo].[CurrentAccountTransactionFees]
            WHERE id = @transactionId";





    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
        c.AddParam("@transactionId", transactionId);
        
        using (OpenCbsReader r = c.ExecuteReader())
        {
            if (r == null || r.Empty) return null;

            r.Read();
            return (CurrentAccountTransactionFees)GetTransactionFee(r);
        }
    }

}


public CurrentAccountTransactionFees FetchTransaction(string transactionType, string transactionMode, int productId)
{


    string q = @"SELECT
		[id],
	        [current_account_product_id],
		[transaction_type],
		[transaction_fees_type],
		[transaction_fees],
		[transaction_fees_min],
		[transaction_fees_max],
		[transaction_mode] FROM [dbo].[CurrentAccountTransactionFees]
            WHERE transaction_type = @transactionType AND transaction_mode  = @transactionMode AND current_account_product_id = @productId";





    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
        c.AddParam("@transactionMode", transactionMode);
        c.AddParam("@transactionType", transactionType);
        c.AddParam("@productId", productId);

        using (OpenCbsReader r = c.ExecuteReader())
        {
            if (r == null || r.Empty) return null;

            r.Read();
            return (CurrentAccountTransactionFees)GetTransactionFee(r);
        }
    }

}


public void UpdateCurrentAccountTransactionFees(CurrentAccountTransactionFees transactionFees, string transactionType, string transactionMode, int productId)
{
    string q = @"UPDATE [CurrentAccountTransactionFees] SET 
            
[transaction_fees_type] = @transactionFeesType,
[transaction_fees] = @transactionFees,
[transaction_fees_min] = @transactionFeesMin,
[transaction_fees_max] = @transactionFeesMax

WHERE transaction_type = @transactionType AND transaction_mode  = @transactionMode AND current_account_product_id = @productId";


    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
        
        c.AddParam("@productId", productId);

        SetTransactionFee(c, transactionFees);
        c.ExecuteNonQuery();
    }
}



    }
}
