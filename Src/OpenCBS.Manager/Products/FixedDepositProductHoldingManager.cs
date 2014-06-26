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



        public string SaveFixedDepositProductHolding(FixedDepositProductHoldings productName)
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
            ,[final_penalty]  
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
                ,@finalPenalty
                ,@initialAmountPaymentMethod
                ,@finalAmountPaymentMethod)
                SELECT SCOPE_IDENTITY()";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
               
                SetProduct(c, productName);
                productName.Id = Convert.ToInt32(c.ExecuteScalar());
                productName.FixedDepositContractCode = productName.FixedDepositContractCode + "/" + productName.Id;
                UpdateFixedDepositProductHolding(productName,productName.Id);
            }


            return productName.FixedDepositContractCode;
        }

        private static void SetProduct(OpenCbsCommand c, FixedDepositProductHoldings product)
        {
            c.AddParam("@clientId", product.ClientId);
            c.AddParam("@clientType", product.ClientType);
            c.AddParam("@fixedDepositContractCode", product.FixedDepositContractCode);

            c.AddParam("@initialAmount", product.InitialAmount);
            c.AddParam("@interestRate", product.InterestRate);

            c.AddParam("@maturityPeriod", product.MaturityPeriod);
            c.AddParam("@interestCalculationFrequency", product.InterestCalculationFrequency);

            c.AddParam("@penalityType", product.PenalityType);
            c.AddParam("@penality", product.Penality);

            c.AddParam("@openingAccountingOfficer", product.OpeningAccountingOfficer);
            c.AddParam("@closingAccountingOfficer", product.ClosingAccountingOfficer);

            c.AddParam("@openDate", product.OpenDate);
            c.AddParam("@closeDate", product.CloseDate);

            c.AddParam("@status", product.Status);

            c.AddParam("@preMatured", product.PreMatured);
            c.AddParam("@comment", product.Comment);
            c.AddParam("@fixedDepositProductId", product.FixedDepositProductId);
            c.AddParam("@effectiveInterestRate", product.EffectiveInterestRate);

            c.AddParam("@effectiveDepositPeriod", product.EffectiveDepositPeriod);
            c.AddParam("@finalAmount", product.FinalAmount);
            c.AddParam("@finalInterest", product.FinalInterest);
            c.AddParam("@finalPenalty", product.FinalPenality);

            c.AddParam("@initialAmountPaymentMethod", product.InitialAmountPaymentMethod);
            c.AddParam("@finalAmountPaymentMethod", product.FinalAmountPaymentMethod);

        }


        public void UpdateFixedDepositProductHolding(FixedDepositProductHoldings product, int productId)
        {
            string q = @"UPDATE [FixedDepositProductHoldings] SET 
            [client_id] = @clientId
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
            ,[final_penalty] = @finalPenalty
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
            ,[final_penalty]  
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


        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoClosed)
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
           ,[final_penalty]  
           ,[initial_amount_payment_method]
           ,[final_amount_payment_method]
           FROM [dbo].[FixedDepositProductHoldings]";


            if (!showAlsoClosed)
                q += " WHERE status = 'Opened'";
            


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

fixedDepositProductHoldings.Id = r.GetInt("id");

fixedDepositProductHoldings.ClientId = r.GetInt("client_id");
fixedDepositProductHoldings.ClientType = r.GetString("client_type");
fixedDepositProductHoldings.FixedDepositContractCode = r.GetString("fixed_deposit_contract_code");
fixedDepositProductHoldings.FixedDepositProductId = r.GetInt("fixed_deposit_product_id");

fixedDepositProductHoldings.InitialAmount = r.GetDecimal("initial_amount");
fixedDepositProductHoldings.InterestRate = r.GetDouble("interest_rate");
fixedDepositProductHoldings.MaturityPeriod = r.GetInt("maturity_period");
fixedDepositProductHoldings.InterestCalculationFrequency = r.GetString("interest_calculation_frequency");
fixedDepositProductHoldings.PenalityType = r.GetString("penality_type");
fixedDepositProductHoldings.Penality = r.GetDouble("penality");
fixedDepositProductHoldings.OpeningAccountingOfficer = r.GetString("opening_accounting_officer");
fixedDepositProductHoldings.ClosingAccountingOfficer = r.GetString("closing_accounting_officer");
fixedDepositProductHoldings.OpenDate = r.GetDateTime("open_date");
fixedDepositProductHoldings.CloseDate = r.GetDateTime("close_date");
fixedDepositProductHoldings.Status = r.GetString("status");
fixedDepositProductHoldings.PreMatured = r.GetInt("pre_matured");
fixedDepositProductHoldings.Comment = r.GetString("comment");
fixedDepositProductHoldings.EffectiveInterestRate = r.GetDouble("effective_interest_rate");
fixedDepositProductHoldings.EffectiveDepositPeriod = r.GetDouble("effective_deposit_period"); 

fixedDepositProductHoldings.FinalAmount = r.GetDecimal("final_amount");
fixedDepositProductHoldings.FinalInterest = r.GetDecimal("final_interest");

fixedDepositProductHoldings.FinalPenality = r.GetDouble("final_penalty");  
fixedDepositProductHoldings.InitialAmountPaymentMethod = r.GetString("initial_amount_payment_method");

fixedDepositProductHoldings.FinalAmountPaymentMethod = r.GetString("final_amount_payment_method");

return fixedDepositProductHoldings;
        }

    }
}
