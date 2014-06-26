using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
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
            //int identity;
            const string q = @"INSERT INTO [CurrentAccountProduct]
           ([current_account_product_name],
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
[management_fees_frequency]  )
                VALUES
                (@currentAccountProductName,
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
@managementFeesFrequency)
                SELECT SCOPE_IDENTITY()";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetProduct(c, currentAccountProduct);
                currentAccountProduct.CurrentAccountProductId = Convert.ToInt32(c.ExecuteScalar());
            }
            return currentAccountProduct.CurrentAccountProductId;
        }



        public static void SetProduct(OpenCbsCommand c, ICurrentAccountProduct product)
        {
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
        }

        public void UpdateCurrentAccountProduct(CurrentAccountProduct product, int productId)
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
[management_fees_frequency] = @managementFeesFrequency
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
[management_fees_frequency] FROM CurrentAccountProduct WHERE id = @id";


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



        public List<CurrentAccountProduct> FetchProduct(bool showAlsoDeleted, int currentAccountProductId)
        {
            List<CurrentAccountProduct> currentAccountProductList = new List<CurrentAccountProduct>();

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
[management_fees_frequency] FROM CurrentAccountProduct";

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

                        CurrentAccountProduct product = FetchProduct(Convert.ToInt32(r.GetInt("id")));

                        currentAccountProductList.Add(product);
                    }
                }
            }

            return currentAccountProductList;

        }


        public CurrentAccountProduct GetProduct(OpenCbsReader r)
{
CurrentAccountProduct currentAccountProduct = new CurrentAccountProduct();
currentAccountProduct.CurrentAccountProductId = r.GetInt("id"); 
currentAccountProduct.Delete = r.GetInt("deleted");
currentAccountProduct.CurrentAccountProductName = r.GetString("current_account_product_name");
currentAccountProduct.CurrentAccountProductCode = r.GetString ("current_account_product_code");
currentAccountProduct.ClientType = r.GetString ("client_type");
currentAccountProduct.Currency = r.GetString ("currency");

currentAccountProduct.InitialAmountMin = r.GetDouble("initial_amount_min");

currentAccountProduct.InitialAmountMax = r.GetDouble ("initial_amount_max");
	
currentAccountProduct.BalanceMin = r.GetDouble("balance_min");

currentAccountProduct.BalanceMax = r.GetDouble("balance_max");
currentAccountProduct.EntryFeesType =	r.GetString("entry_fees_type");

currentAccountProduct.ReopenFeesType = r.GetString("reopen_fees_type");

currentAccountProduct.ClosingFeesType = r.GetString("closing_fees_type");

currentAccountProduct.ManagementFeesType = r.GetString("management_fees_type");

currentAccountProduct.OverdraftType = r.GetString("overdraft_type");

currentAccountProduct.EntryFeesMin = r.GetDouble("entry_fees_min");

currentAccountProduct.ReopenFeesMin = r.GetDouble("reopen_fees_min");

currentAccountProduct.ClosingFeesMin = r.GetDouble("closing_fees_min");

currentAccountProduct.ManagementFeesMin = r.GetDouble("management_fees_min");

currentAccountProduct.OverdraftMin = r.GetDouble("overdraft_min");

currentAccountProduct.EntryFeesMax = r.GetDouble("entry_fees_max");

currentAccountProduct.ReopenFeesMax = r.GetDouble("reopen_fees_max");

currentAccountProduct.ClosingFeesMax = r.GetDouble("closing_fees_max");
currentAccountProduct.ManagementFeesMax = r.GetDouble("management_fees_max");

currentAccountProduct.OverdraftMax = r.GetDouble("overdraft_max");
currentAccountProduct.EntryFeesValue = r.GetDouble("entry_fees_value");

currentAccountProduct.ReopenFeesValue = r.GetDouble("reopen_fees_value");

currentAccountProduct.ClosingFeesValue = r.GetDouble("closing_fees_value");

currentAccountProduct.ManagementFeesValue = r.GetDouble("management_fees_value");

currentAccountProduct.OverdraftValue = r.GetDouble("overdraft_value");
currentAccountProduct.ManagementFeesFrequency = r.GetString("management_fees_frequency");

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

    }
}
