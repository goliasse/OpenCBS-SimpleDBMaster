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






        public List<IFixedDepositProduct> SelectProducts(bool showAlsoDeleted, OClientTypes clientType)
        {
            List<IFixedDepositProduct> fixedDepositProductList = new List<IFixedDepositProduct>();

            string q = @"SELECT
            [product_name]
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
            else
                q += " WHERE deleted = 1";
           

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return new List<IFixedDepositProduct>();
                    while (r.Read())
                    {
                        IFixedDepositProduct pack;

                      
                    }
                }
            }
           
            return fixedDepositProductList;
        }


    }
}
