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
    public class FixedDepositProductHoldingManager : Manager
    {
        public FixedDepositProductHoldingManager(User pUser) : base(pUser)
        {
        }

        public FixedDepositProductHoldingManager(string testDB)
            : base(testDB)
        {
        }



        public int SaveFixedDepositProductHolding(FixedDepositProductHoldings productName)
        {
            
            const string q = @"INSERT INTO [FixedDepositProductHoldings]
           ([client_id]
           ,[client_type]
           ,[fixed_deposit_contract_code]
           ,[initial_amount]
           ,[interest_rate]
           ,[maturity_period]
           ,[interest_calculation_frequency]
           ,[penality_type]
           ,[penality]
           ,[opening_accounting_officer]
           ,[closing_accounting_officer]
           ,[open_date]
           ,[close_date]
           ,[status]
           ,[pre_matured]
           ,[comment]
           ,[fixed_deposit_product_id]
            ,[effective_interest_rate] 
            ,[effective_deposit_period] 
            ,[final_amount] 
            ,[final_interest]  
            ,[initial_amount_payment_method]
            ,[final_amount_payment_method] )
                VALUES
                (@clientId
                ,@clientType
                ,@fixedDepositContractCode
                ,@initialAmount
                ,@interestRate
                ,@maturityPeriod
                ,@interestCalculationFrequency
                ,@penalityType
                ,@penality
                ,@openingAccountingOfficer
                ,@closingAccountingOfficer
                ,@openDate
                ,@closeDate
                ,@status
                ,@preMatured
                ,@comment
                ,@fixedDepositProductId
                ,@effectiveInterestRate
                ,@effectiveDepositPeriod
                ,@finalAmount
                ,@finalInterest
                ,@initialAmountPaymentMethod
                ,@finalAmountPaymentMethod)
                SELECT SCOPE_IDENTITY()";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
               
                SetProduct(c, productName);
                productName.Id = Convert.ToInt32(c.ExecuteScalar());
            }


            return productName.Id;
        }

        private static void SetProduct(OpenCbsCommand c, FixedDepositProductHoldings product)
        {
            c.AddParam("@clientId", product.ClientId);
            c.AddParam("@client_type", product.ClientType);
            c.AddParam("@fixed_deposit_contract_code", product.FixedDepositContractCode);

            c.AddParam("@initial_amount", product.InitialAmount);
            c.AddParam("@interest_rate", product.InterestRate);

            c.AddParam("@maturity_period", product.MaturityPeriod);
            c.AddParam("@interest_calculation_frequency", product.InterestCalculationFrequency);

            c.AddParam("@penality_type", product.PenalityType);
            c.AddParam("@penality", product.Penality);

            c.AddParam("@opening_accounting_officer", product.OpeningAccountingOfficer);
            c.AddParam("@closing_accounting_officer", product.ClosingAccountingOfficer);

            c.AddParam("@open_date", product.OpenDate);
            c.AddParam("@close_date", product.CloseDate);

            c.AddParam("@status", product.Status);

            c.AddParam("@preMatured", product.PreMatured);
            c.AddParam("@comment", product.Comment);
            c.AddParam("@fixedDepositProductId", product.FixedDepositProductId);
            c.AddParam("@effectiveInterestRate", product.EffectiveInterestRate);

            c.AddParam("@effectiveDepositPeriod", product.EffectiveDepositPeriod);
            c.AddParam("@finalAmount", product.FinalAmount);
            c.AddParam("@finalInterest", product.FinalInterest);

            c.AddParam("@initialAmountPaymentMethod", product.InitialAmountPaymentMethod);
            c.AddParam("@finalAmountPaymentMethod", product.FinalAmountPaymentMethod);

        }


        public void UpdateFixedDepositProductHolding(FixedDepositProductHoldings product, int productId)
        {
            string q = @"UPDATE [FixedDepositProductHoldings] SET 
            [client_id] = @client_id
           ,[client_type] = @clientType
           ,[fixed_deposit_contract_code] = @fixedDepositContractCode
           ,[initial_amount] = @initialAmount
           ,[interest_rate] = @interestRate
           ,[maturity_period] = @maturityPeriod
           ,[interest_calculation_frequency] = @interestCalculationFrequency
           ,[penality_type] = @penalityType
           ,[penality] = @penality
           ,[opening_accounting_officer] = @openingAccountingOfficer
           ,[closing_accounting_officer] = @closingAccountingOfficer
           ,[open_date] = @openDate
           ,[close_date] = @closeDate
           ,[status] = @status
           ,[pre_matured] = @preMatured
           ,[comment] = @comment
           ,[fixed_deposit_product_id] = @fixedDepositProductId
            ,[effective_interest_rate] = @effectiveInterestRate
            ,[effective_deposit_period] = @effectiveDepositPeriod
            ,[final_amount] = @finalAmount
            ,[final_interest]  = @finalInterest
            ,[initial_amount_payment_method] = @initialAmountPaymentMethod
            ,[final_amount_payment_method] = @finalAmountPaymentMethod
            WHERE id = @productId";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productId", productId);
                SetProduct(c, product);
                c.ExecuteNonQuery();
            }
        }

        public FixedDepositProductHoldings FetchProduct(int productId)
        {
            string q = @"SELECT
            [client_id]
           ,[client_type]
           ,[fixed_deposit_contract_code]
           ,[initial_amount]
           ,[interest_rate]
           ,[maturity_period]
           ,[interest_calculation_frequency]
           ,[penality_type]
           ,[penality]
           ,[opening_accounting_officer]
           ,[closing_accounting_officer]
           ,[open_date]
           ,[close_date]
           ,[status]
           ,[pre_matured]
           ,[comment]
           ,[fixed_deposit_product_id]
            ,[effective_interest_rate] 
            ,[effective_deposit_period] 
            ,[final_amount] 
            ,[final_interest]  
            ,[initial_amount_payment_method]
            ,[final_amount_payment_method]
            FROM [dbo].[FixedDepositProductHoldings]
            WHERE id = @productId";

        

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productId", productId);

                using (OpenCbsReader r = c.ExecuteReader())
                {



                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (FixedDepositProductHoldings)GetProduct(r);
                }
            }


        }


        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoDeleted)
        {

            List<FixedDepositProductHoldings> fixedDepositProductHoldingList = new List<FixedDepositProductHoldings>();

            string q = @"SELECT
            [id]
           ,[client_id]
           ,[client_type]
           ,[fixed_deposit_contract_code]
           ,[initial_amount]
           ,[interest_rate]
           ,[maturity_period]
           ,[interest_calculation_frequency]
           ,[penality_type]
           ,[penality]
           ,[opening_accounting_officer]
           ,[closing_accounting_officer]
           ,[open_date]
           ,[close_date]
           ,[status]
           ,[pre_matured]
           ,[comment]
           ,[fixed_deposit_product_id]
           ,[effective_interest_rate] 
           ,[effective_deposit_period] 
           ,[final_amount] 
           ,[final_interest]  
           ,[initial_amount_payment_method]
           ,[final_amount_payment_method]
           FROM [dbo].[FixedDepositProductHoldings]";


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

                        FixedDepositProductHoldings product = FetchProduct(Convert.ToInt32(r.GetInt("id")));

                        fixedDepositProductHoldingList.Add(product);
                    }
                }
            }

            return fixedDepositProductHoldingList;
        }

        public FixedDepositProductHoldings GetProduct(OpenCbsReader r)
        {
           FixedDepositProductHoldings fixedDepositProductHoldings = new FixedDepositProductHoldings();

fixedDepositProductHoldings.Id = r.GetMoney("id");

fixedDepositProductHoldings.ClientId = r.GetMoney("client_id");
fixedDepositProductHoldings.ClientType = r.GetMoney("client_type");
fixedDepositProductHoldings.FixedDepositContractCode = r.GetMoney("fixed_deposit_contract_code");
fixedDepositProductHoldings.FixedDepositProductId = r.GetMoney("fixed_deposit_product_id");

fixedDepositProductHoldings.InitialAmount = r.GetMoney("initial_amount");
fixedDepositProductHoldings.InterestRate = r.GetMoney("interest_rate");
fixedDepositProductHoldings.MaturityPeriod = r.GetMoney("maturity_period");
fixedDepositProductHoldings.InterestCalculationFrequency = r.GetMoney("interest_calculation_frequency");
fixedDepositProductHoldings.PenalityType = r.GetMoney("penality_type");
fixedDepositProductHoldings.Penality = r.GetMoney("penality");
fixedDepositProductHoldings.OpeningAccountingOfficer = r.GetMoney("opening_accounting_officer");
fixedDepositProductHoldings.ClosingAccountingOfficer = r.GetMoney("closing_accounting_officer");
fixedDepositProductHoldings.OpenDate = r.GetMoney("open_date");
fixedDepositProductHoldings.CloseDate = r.GetMoney("close_date");
fixedDepositProductHoldings.Status = r.GetMoney("status");
fixedDepositProductHoldings.PreMatured = r.GetMoney("pre_matured");
fixedDepositProductHoldings.Comment = r.GetMoney("comment");
fixedDepositProductHoldings.EffectiveInterestRate = r.GetMoney("effective_interest_rate");
fixedDepositProductHoldings.EffectiveDepositPeriod = r.GetMoney("effective_deposit_period"); 

fixedDepositProductHoldings.FinalAmount = r.GetMoney("final_amount");
fixedDepositProductHoldings.FinalInterest = r.GetMoney("final_interest");  
//To be included into insert and fetch scripts
fixedDepositProductHoldings.FinalPenality = 
fixedDepositProductHoldings.InitialAmountPaymentMethod = r.GetMoney("initial_amount_payment_method");

fixedDepositProductHoldings.FinalAmountPaymentMethod = r.GetMoney("final_amount_payment_method");

return fixedDepositProductHoldings;
        }

    }
}
