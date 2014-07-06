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
    public class FixedDepositProductManager : Manager
    {

        public FixedDepositProductManager(User pUser) : base(pUser)
        {
        }

        public FixedDepositProductManager(string testDB) : base(testDB)
        {
        }

        public int SaveFixedDepositProduct(IFixedDepositProduct fixedDepositProduct)
        {
            //int identity;
            const string q = @"INSERT INTO [FixedDepositProducts]
           ([product_name]
           ,[product_code]
           ,[client_type]
           ,[product_currency]
           ,[initial_amount_min]
           ,[initial_amount_max]
           ,[interest_rate_min]
           ,[interest_rate_max]
           ,[maturity_period_min]
           ,[maturity_period_max]
           ,[interest_calculation_frequency]
           ,[penality_type]
           ,[penality_min]
           ,[penality_max]
           ,[deleted])
                VALUES
                (@productName
                ,@productCode
                ,@clientType
                ,@productCurrency
                ,@initialAmountMin
                ,@initialAmountMax
                ,@interestRateMin
                ,@interestRateMax
                ,@maturityPeriodMin
                ,@maturityPeriodMax
                ,@interestCalculationFrequency
                ,@penalityType
                ,@penalityMin
                ,@penalityMax
                ,@deleted)
                SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {


                SetProduct(c, fixedDepositProduct);
                fixedDepositProduct.Id = Convert.ToInt32(c.ExecuteScalar());
            }


            return fixedDepositProduct.Id;
        }


       
        private static void SetProduct(OpenCbsCommand c, IFixedDepositProduct fixedDepositProduct)
        {
            
            c.AddParam("@productName", fixedDepositProduct.Name);
            c.AddParam("@productCode", fixedDepositProduct.Code);
            c.AddParam("@clientType", fixedDepositProduct.ClientType);
            c.AddParam("@productCurrency", fixedDepositProduct.Currency);
            c.AddParam("@initialAmountMin", fixedDepositProduct.InitialAmountMin);
            c.AddParam("@initialAmountMax", fixedDepositProduct.InitialAmountMax);
            c.AddParam("@interestRateMin", fixedDepositProduct.InterestRateMin);
            c.AddParam("@interestRateMax", fixedDepositProduct.InterestRateMax);
            c.AddParam("@maturityPeriodMin", fixedDepositProduct.MaturityPeriodMin);
            c.AddParam("@maturityPeriodMax", fixedDepositProduct.MaturityPeriodMax);
            c.AddParam("@interestCalculationFrequency", fixedDepositProduct.InterestCalculationFrequency);
            c.AddParam("@penalityType", fixedDepositProduct.PenalityType);
            c.AddParam("@penalityMin", fixedDepositProduct.PenalityRateMin);
            c.AddParam("@penalityMax", fixedDepositProduct.PenalityRateMax);
            c.AddParam("@deleted", 0);
         }



        public int GetProductId(string productName, string productCode)
        {


            string q = @"SELECT
            [id]
           
            FROM [dbo].[FixedDepositProducts]
            WHERE product_name = @productName and product_code = @productCode";





            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productName", productName);
                c.AddParam("@productCode", productCode);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    return Convert.ToInt32(r.Read());



                }
            }


        }


        public IFixedDepositProduct FetchProduct(int productId)
        {
            

            string q = @"SELECT
            [id]
           ,[deleted]
           ,[product_name]
           ,[product_code]
           ,[client_type]
           ,[product_currency]
           ,[initial_amount_min]
           ,[initial_amount_max]
           ,[interest_rate_min]
           ,[interest_rate_max]
           ,[maturity_period_min]
           ,[maturity_period_max]
           ,[interest_calculation_frequency]
           ,[penality_type]
           ,[penality_min]
           ,[penality_max]
            FROM [dbo].[FixedDepositProducts]
            WHERE id = @productId";
                                      

            
           

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productId", productId);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return new FixedDepositProduct();
                    r.Read();
                    
                        FixedDepositProduct fixedDepositProduct = new FixedDepositProduct();
                        
                        return (FixedDepositProduct)GetProduct(r);
                        
                      
                    
                }
            }
           
            
        }


        public IFixedDepositProduct FetchProduct(string productName, string productCode)
        {


            string q = @"SELECT
            [id]
           ,[deleted]
           ,[product_name]
           ,[product_code]
           ,[client_type]
           ,[product_currency]
           ,[initial_amount_min]
           ,[initial_amount_max]
           ,[interest_rate_min]
           ,[interest_rate_max]
           ,[maturity_period_min]
           ,[maturity_period_max]
           ,[interest_calculation_frequency]
           ,[penality_type]
           ,[penality_min]
           ,[penality_max]
            FROM [dbo].[FixedDepositProducts]
            WHERE product_name = @productName AND product_code = @productCode";





            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productName", productName);
                c.AddParam("@productCode", productCode);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return new FixedDepositProduct();
                    r.Read();

                    FixedDepositProduct fixedDepositProduct = new FixedDepositProduct();

                    return (FixedDepositProduct)GetProduct(r);



                }
            }


        }




        public void UpdateFixedDepositProduct(IFixedDepositProduct product, int productId)
        {
            string q = @"UPDATE [FixedDepositProducts] SET 
            [product_name] = @productName
           ,[product_code] = @productCode
           ,[client_type] = @clientType
           ,[product_currency] = @productCurrency
           ,[initial_amount_min] = @initialAmountMin
           ,[initial_amount_max] = @initialAmountMax
           ,[interest_rate_min] = @interestRateMin
           ,[interest_rate_max] = @interestRateMax
           ,[maturity_period_min] = @maturityPeriodMin
           ,[maturity_period_max] = @maturityPeriodMax
           ,[interest_calculation_frequency] = @interestCalculationFrequency
           ,[penality_type] = @penalityType
           ,[penality_min] = @penalityMin
           ,[penality_max] = @penalityMax
           ,[deleted] = @deleted
WHERE id = @productId";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productId", productId);
                SetProduct(c, product);
                c.ExecuteNonQuery();
            }
        }

        public List<IFixedDepositProduct> FetchProduct(bool showAlsoDeleted)
        {
            List<IFixedDepositProduct> fixedDepositProductList = new List<IFixedDepositProduct>();


            string q = @"SELECT
            [id]
           ,[deleted]
           ,[product_name]
           ,[product_code]
           ,[client_type]
           ,[product_currency]
           ,[initial_amount_min]
           ,[initial_amount_max]
           ,[interest_rate_min]
           ,[interest_rate_max]
           ,[maturity_period_min]
           ,[maturity_period_max]
           ,[interest_calculation_frequency]
           ,[penality_type]
           ,[penality_min]
           ,[penality_max]
            FROM [dbo].[FixedDepositProducts]";


            if (!showAlsoDeleted)
                q += " WHERE deleted = 0";
          



            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return new List<IFixedDepositProduct>();
                    while (r.Read())
                    {


                        IFixedDepositProduct product = FetchProduct(Convert.ToInt32(r.GetInt("id")));

                        fixedDepositProductList.Add(product);
                    }
                }
            }

            return fixedDepositProductList;
        }

        public FixedDepositProduct GetProduct(OpenCbsReader r)
        {
           FixedDepositProduct fixedDepositProduct = new FixedDepositProduct();
fixedDepositProduct.Id = r.GetInt("id");
fixedDepositProduct.Delete = r.GetInt("deleted");


fixedDepositProduct.Name = r.GetString("product_name");
fixedDepositProduct.Code = r.GetString("product_code");

fixedDepositProduct.ClientType = r.GetString("client_type");

fixedDepositProduct.Currency = r.GetString("product_currency");

fixedDepositProduct.InitialAmountMin = r.GetNullDecimal("initial_amount_min");

fixedDepositProduct.InitialAmountMax = r.GetNullDecimal("initial_amount_max");

fixedDepositProduct.InterestCalculationFrequency = r.GetString("interest_calculation_frequency");

fixedDepositProduct.PenalityType = r.GetString("penality_type");

fixedDepositProduct.InterestRateMin = r.GetNullDouble("interest_rate_min");
fixedDepositProduct.InterestRateMax = r.GetNullDouble("interest_rate_max");

fixedDepositProduct.PenalityRateMin = r.GetNullDouble("penality_min");

fixedDepositProduct.PenalityRateMax = r.GetNullDouble("penality_max");

fixedDepositProduct.MaturityPeriodMin = r.GetNullInt("maturity_period_min");

fixedDepositProduct.MaturityPeriodMax = r.GetNullInt("maturity_period_max");


return fixedDepositProduct;
        }

        public void DeleteFixedDepositProduct(int pProductId)
        {
            const string q = "Update FixedDepositProducts Set Deleted = 1 Where id = @productId";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productId", pProductId);
                c.ExecuteNonQuery();
            }
        }


    }
}
