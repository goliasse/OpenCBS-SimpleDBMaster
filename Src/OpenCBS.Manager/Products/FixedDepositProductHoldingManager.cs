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

        FixedDepositProductManager fixedDepositProductManager = null;
        public FixedDepositProductHoldingManager(User pUser) : base(pUser)
        {
            fixedDepositProductManager = new FixedDepositProductManager(pUser);
        }

        public FixedDepositProductHoldingManager(string testDB)
            : base(testDB)
        {
            fixedDepositProductManager = new FixedDepositProductManager(testDB);
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
            ,[final_amount_payment_method]
            ,[final_cheque_account_number])
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
                ,@finalAmountPaymentMethod
                ,@finalChequeAccountNumber)
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
            c.AddParam("@fixedDepositProductId", product.FixedDepositProduct.Id);
            c.AddParam("@effectiveInterestRate", product.EffectiveInterestRate);

            c.AddParam("@effectiveDepositPeriod", product.EffectiveDepositPeriod);
            c.AddParam("@finalAmount", product.FinalAmount);
            c.AddParam("@finalInterest", product.FinalInterest);
            c.AddParam("@finalPenalty", product.FinalPenality);

            c.AddParam("@initialAmountPaymentMethod", product.InitialAmountPaymentMethod);
            c.AddParam("@finalAmountPaymentMethod", product.FinalAmountPaymentMethod);
            c.AddParam("@finalChequeAccountNumber", product.FinalAmountChequeAccount);
            
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
            ,[final_cheque_account_number] = @finalChequeAccountNumber
            WHERE id = @productId";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productId", productId);
                SetProduct(c, product);
                c.ExecuteNonQuery();
            }
        }


        public void UpdateFixedDepositProductHolding(FixedDepositProductHoldings product, string productContractCode)
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
            ,[final_cheque_account_number] = @finalChequeAccountNumber
            WHERE fixed_deposit_contract_code = @productContractCode";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productContractCode", productContractCode);
                SetProduct(c, product);
                c.ExecuteNonQuery();
            }
        }


        public FixedDepositProductHoldings FetchProduct(int productId)
        {
            string q = @"SELECT
            [dbo].[FixedDepositProductHoldings].[id]
           ,[dbo].[FixedDepositProductHoldings].[client_id]
           ,[dbo].[FixedDepositProductHoldings].[client_type]
           ,[dbo].[FixedDepositProductHoldings].[fixed_deposit_contract_code]
           ,[dbo].[FixedDepositProductHoldings].[initial_amount]
           ,[dbo].[FixedDepositProductHoldings].[interest_rate]
           ,[dbo].[FixedDepositProductHoldings].[maturity_period]
           ,[dbo].[FixedDepositProductHoldings].[interest_calculation_frequency]
           ,[dbo].[FixedDepositProductHoldings].[penality_type]
           ,[dbo].[FixedDepositProductHoldings].[penality]
           ,[dbo].[FixedDepositProductHoldings].[opening_accounting_officer]
           ,[dbo].[FixedDepositProductHoldings].[closing_accounting_officer]
           ,[dbo].[FixedDepositProductHoldings].[open_date]
           ,[dbo].[FixedDepositProductHoldings].[close_date]
           ,[dbo].[FixedDepositProductHoldings].[status]
           ,[dbo].[FixedDepositProductHoldings].[pre_matured]
           ,[dbo].[FixedDepositProductHoldings].[comment]
           ,[dbo].[FixedDepositProductHoldings].[fixed_deposit_product_id]
           ,[dbo].[FixedDepositProductHoldings].[effective_interest_rate] 
           ,[dbo].[FixedDepositProductHoldings].[effective_deposit_period] 
           ,[dbo].[FixedDepositProductHoldings].[final_amount] 
           ,[dbo].[FixedDepositProductHoldings].[final_interest]
           ,[dbo].[FixedDepositProductHoldings].[final_penalty]  
           ,[dbo].[FixedDepositProductHoldings].[initial_amount_payment_method]
           ,[dbo].[FixedDepositProductHoldings].[final_amount_payment_method]
           ,[dbo].[FixedDepositProductHoldings].[final_cheque_account_number]
           ,[dbo].[FixedDepositProducts].[product_name]
           ,[dbo].[FixedDepositProducts].[product_code]
           ,[dbo].[FixedDepositProducts].[product_currency]
           ,[dbo].[Persons].[first_name]
            ,cur.id AS currency_id
            ,cur.name AS currency_name 
            ,cur.code AS currency_code
            ,cur.is_pivot AS currency_is_pivot
            ,cur.is_swapped AS currency_is_swapped
            ,cur.use_cents AS currency_use_cents
            FROM [dbo].[FixedDepositProductHoldings] INNER JOIN [dbo].[FixedDepositProducts] ON [dbo].FixedDepositProducts.id = [dbo].FixedDepositProductHoldings.fixed_deposit_product_id
            JOIN [dbo].Persons ON [dbo].FixedDepositProductHoldings.client_id = [dbo].Persons.id
            JOIN Currencies AS cur ON [dbo].[FixedDepositProducts].product_currency = cur.id
            WHERE [dbo].[FixedDepositProductHoldings].[id] = @productId";

        

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



        public FixedDepositProductHoldings FetchProduct(string productContractCode)
        {
            string q = @"SELECT
             [dbo].[FixedDepositProductHoldings].[id]
           ,[dbo].[FixedDepositProductHoldings].[client_id]
           ,[dbo].[FixedDepositProductHoldings].[client_type]
           ,[dbo].[FixedDepositProductHoldings].[fixed_deposit_contract_code]
           ,[dbo].[FixedDepositProductHoldings].[initial_amount]
           ,[dbo].[FixedDepositProductHoldings].[interest_rate]
           ,[dbo].[FixedDepositProductHoldings].[maturity_period]
           ,[dbo].[FixedDepositProductHoldings].[interest_calculation_frequency]
           ,[dbo].[FixedDepositProductHoldings].[penality_type]
           ,[dbo].[FixedDepositProductHoldings].[penality]
           ,[dbo].[FixedDepositProductHoldings].[opening_accounting_officer]
           ,[dbo].[FixedDepositProductHoldings].[closing_accounting_officer]
           ,[dbo].[FixedDepositProductHoldings].[open_date]
           ,[dbo].[FixedDepositProductHoldings].[close_date]
           ,[dbo].[FixedDepositProductHoldings].[status]
           ,[dbo].[FixedDepositProductHoldings].[pre_matured]
           ,[dbo].[FixedDepositProductHoldings].[comment]
           ,[dbo].[FixedDepositProductHoldings].[fixed_deposit_product_id]
           ,[dbo].[FixedDepositProductHoldings].[effective_interest_rate] 
           ,[dbo].[FixedDepositProductHoldings].[effective_deposit_period] 
           ,[dbo].[FixedDepositProductHoldings].[final_amount] 
           ,[dbo].[FixedDepositProductHoldings].[final_interest]
           ,[dbo].[FixedDepositProductHoldings].[final_penalty]  
           ,[dbo].[FixedDepositProductHoldings].[initial_amount_payment_method]
           ,[dbo].[FixedDepositProductHoldings].[final_amount_payment_method]
           ,[dbo].[FixedDepositProductHoldings].[final_cheque_account_number]
           ,[dbo].[FixedDepositProducts].[product_name]
           ,[dbo].[FixedDepositProducts].[product_code]
           ,[dbo].[FixedDepositProducts].[product_currency]
           ,[dbo].[Persons].[first_name]
            ,cur.id AS currency_id
            ,cur.name AS currency_name 
            ,cur.code AS currency_code
            ,cur.is_pivot AS currency_is_pivot
            ,cur.is_swapped AS currency_is_swapped
            ,cur.use_cents AS currency_use_cents
            FROM [dbo].[FixedDepositProductHoldings] INNER JOIN [dbo].[FixedDepositProducts] ON [dbo].FixedDepositProducts.id = [dbo].FixedDepositProductHoldings.fixed_deposit_product_id
             JOIN [dbo].Persons ON [dbo].FixedDepositProductHoldings.client_id = [dbo].Persons.id
            JOIN Currencies AS cur ON [dbo].[FixedDepositProducts].product_currency = cur.id
            WHERE [dbo].[FixedDepositProductHoldings].fixed_deposit_contract_code = @productContractCode";



            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@productContractCode", productContractCode);

                using (OpenCbsReader r = c.ExecuteReader())
                {



                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (FixedDepositProductHoldings)GetProduct(r);
                }
            }


        }



        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoClosed, int clientid, string clientType)
        {
            List<FixedDepositProductHoldings> fixedDepositProductHoldingList = new List<FixedDepositProductHoldings>();

            string q = @"SELECT
            [dbo].[FixedDepositProductHoldings].[id]
           ,[dbo].[FixedDepositProductHoldings].[client_id]
           ,[dbo].[FixedDepositProductHoldings].[client_type]
           ,[dbo].[FixedDepositProductHoldings].[fixed_deposit_contract_code]
           ,[dbo].[FixedDepositProductHoldings].[initial_amount]
           ,[dbo].[FixedDepositProductHoldings].[interest_rate]
           ,[dbo].[FixedDepositProductHoldings].[maturity_period]
           ,[dbo].[FixedDepositProductHoldings].[interest_calculation_frequency]
           ,[dbo].[FixedDepositProductHoldings].[penality_type]
           ,[dbo].[FixedDepositProductHoldings].[penality]
           ,[dbo].[FixedDepositProductHoldings].[opening_accounting_officer]
           ,[dbo].[FixedDepositProductHoldings].[closing_accounting_officer]
           ,[dbo].[FixedDepositProductHoldings].[open_date]
           ,[dbo].[FixedDepositProductHoldings].[close_date]
           ,[dbo].[FixedDepositProductHoldings].[status]
           ,[dbo].[FixedDepositProductHoldings].[pre_matured]
           ,[dbo].[FixedDepositProductHoldings].[comment]
           ,[dbo].[FixedDepositProductHoldings].[fixed_deposit_product_id]
           ,[dbo].[FixedDepositProductHoldings].[effective_interest_rate] 
           ,[dbo].[FixedDepositProductHoldings].[effective_deposit_period] 
           ,[dbo].[FixedDepositProductHoldings].[final_amount] 
           ,[dbo].[FixedDepositProductHoldings].[final_interest]
           ,[dbo].[FixedDepositProductHoldings].[final_penalty]  
           ,[dbo].[FixedDepositProductHoldings].[initial_amount_payment_method]
           ,[dbo].[FixedDepositProductHoldings].[final_amount_payment_method]
           ,[dbo].[FixedDepositProductHoldings].[final_cheque_account_number]
           ,[dbo].[FixedDepositProducts].[product_name]
           ,[dbo].[FixedDepositProducts].[product_code]
           ,[dbo].[FixedDepositProducts].[product_currency]
            ,[dbo].[Persons].[first_name]
            ,cur.id AS currency_id
            ,cur.name AS currency_name 
            ,cur.code AS currency_code
            ,cur.is_pivot AS currency_is_pivot
            ,cur.is_swapped AS currency_is_swapped
            ,cur.use_cents AS currency_use_cents            
            FROM [dbo].[FixedDepositProductHoldings] INNER JOIN [dbo].[FixedDepositProducts] ON [dbo].FixedDepositProducts.id = [dbo].FixedDepositProductHoldings.fixed_deposit_product_id
            JOIN [dbo].Persons ON [dbo].FixedDepositProductHoldings.client_id = [dbo].Persons.id
            JOIN Currencies AS cur ON [dbo].[FixedDepositProducts].product_currency = cur.id
            WHERE [dbo].[FixedDepositProductHoldings].[client_id] = @ClientId AND [dbo].[FixedDepositProductHoldings].[client_type] = @ClientType
           ";


            if (!showAlsoClosed)
                q += " WHERE status = 'Opened'";



            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@ClientId",clientid);
                c.AddParam("@ClientType", clientType);

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


        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoClosed)
        {

            List<FixedDepositProductHoldings> fixedDepositProductHoldingList = new List<FixedDepositProductHoldings>();

            string q = @"SELECT
            [dbo].[FixedDepositProductHoldings].[id]
           ,[dbo].[FixedDepositProductHoldings].[client_id]
           ,[dbo].[FixedDepositProductHoldings].[client_type]
           ,[dbo].[FixedDepositProductHoldings].[fixed_deposit_contract_code]
           ,[dbo].[FixedDepositProductHoldings].[initial_amount]
           ,[dbo].[FixedDepositProductHoldings].[interest_rate]
           ,[dbo].[FixedDepositProductHoldings].[maturity_period]
           ,[dbo].[FixedDepositProductHoldings].[interest_calculation_frequency]
           ,[dbo].[FixedDepositProductHoldings].[penality_type]
           ,[dbo].[FixedDepositProductHoldings].[penality]
           ,[dbo].[FixedDepositProductHoldings].[opening_accounting_officer]
           ,[dbo].[FixedDepositProductHoldings].[closing_accounting_officer]
           ,[dbo].[FixedDepositProductHoldings].[open_date]
           ,[dbo].[FixedDepositProductHoldings].[close_date]
           ,[dbo].[FixedDepositProductHoldings].[status]
           ,[dbo].[FixedDepositProductHoldings].[pre_matured]
           ,[dbo].[FixedDepositProductHoldings].[comment]
           ,[dbo].[FixedDepositProductHoldings].[fixed_deposit_product_id]
           ,[dbo].[FixedDepositProductHoldings].[effective_interest_rate] 
           ,[dbo].[FixedDepositProductHoldings].[effective_deposit_period] 
           ,[dbo].[FixedDepositProductHoldings].[final_amount] 
           ,[dbo].[FixedDepositProductHoldings].[final_interest]
           ,[dbo].[FixedDepositProductHoldings].[final_penalty]  
           ,[dbo].[FixedDepositProductHoldings].[initial_amount_payment_method]
           ,[dbo].[FixedDepositProductHoldings].[final_amount_payment_method]
           ,[dbo].[FixedDepositProductHoldings].[final_cheque_account_number]
           ,[dbo].[FixedDepositProducts].[product_name]
           ,[dbo].[FixedDepositProducts].[product_code]
           ,[dbo].[FixedDepositProducts].[product_currency]
           ,[dbo].[Persons].[first_name]
            ,cur.id AS currency_id
            ,cur.name AS currency_name 
            ,cur.code AS currency_code
            ,cur.is_pivot AS currency_is_pivot
            ,cur.is_swapped AS currency_is_swapped
            ,cur.use_cents AS currency_use_cents
            FROM [dbo].[FixedDepositProductHoldings] INNER JOIN [dbo].[FixedDepositProducts] ON [dbo].FixedDepositProducts.id = [dbo].FixedDepositProductHoldings.fixed_deposit_product_id
            JOIN [dbo].Persons ON [dbo].FixedDepositProductHoldings.client_id = [dbo].Persons.id
            JOIN Currencies AS cur ON [dbo].[FixedDepositProducts].product_currency = cur.id
           ";


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
fixedDepositProductHoldings.FixedDepositProduct = new FixedDepositProduct();
fixedDepositProductHoldings.FixedDepositProduct.Id = r.GetInt("fixed_deposit_product_id");
fixedDepositProductHoldings.FixedDepositProduct.Name = r.GetString("product_name");
fixedDepositProductHoldings.FixedDepositProduct.Code = r.GetString("product_code");

fixedDepositProductHoldings.FixedDepositProduct.Currency = new Currency()
{
    Id = r.GetInt("currency_id"),
    Code = r.GetString("currency_code"),
    Name = r.GetString("currency_name"),
    IsPivot = r.GetBool("currency_is_pivot"),
    IsSwapped = r.GetBool("currency_is_swapped"),
    UseCents = r.GetBool("currency_use_cents")
};

fixedDepositProductHoldings.InitialAmount = r.GetMoney("initial_amount");
fixedDepositProductHoldings.InterestRate = r.GetNullDouble("interest_rate");
fixedDepositProductHoldings.MaturityPeriod = r.GetNullInt("maturity_period");
fixedDepositProductHoldings.InterestCalculationFrequency = r.GetString("interest_calculation_frequency");
fixedDepositProductHoldings.PenalityType = r.GetString("penality_type");
fixedDepositProductHoldings.Penality = r.GetNullDouble("penality");
fixedDepositProductHoldings.OpeningAccountingOfficer = r.GetString("opening_accounting_officer");
fixedDepositProductHoldings.ClosingAccountingOfficer = r.GetString("closing_accounting_officer");
fixedDepositProductHoldings.OpenDate = r.GetDateTime("open_date");
fixedDepositProductHoldings.CloseDate = r.GetDateTime("close_date");
fixedDepositProductHoldings.Status = r.GetString("status");
fixedDepositProductHoldings.PreMatured = r.GetNullInt("pre_matured");
fixedDepositProductHoldings.Comment = r.GetString("comment");
fixedDepositProductHoldings.EffectiveInterestRate = r.GetNullDouble("effective_interest_rate");
fixedDepositProductHoldings.EffectiveDepositPeriod = r.GetNullDouble("effective_deposit_period"); 

fixedDepositProductHoldings.FinalAmount = r.GetMoney("final_amount");
fixedDepositProductHoldings.FinalInterest = r.GetMoney("final_interest");

fixedDepositProductHoldings.FinalPenality = r.GetNullDouble("final_penalty");  
fixedDepositProductHoldings.InitialAmountPaymentMethod = r.GetString("initial_amount_payment_method");

fixedDepositProductHoldings.FinalAmountPaymentMethod = r.GetString("final_amount_payment_method");
fixedDepositProductHoldings.FinalAmountChequeAccount = r.GetString("final_cheque_account_number");
fixedDepositProductHoldings.FirstName = r.GetString("first_name");

            

return fixedDepositProductHoldings;
        }



        static double CalculateInterest(double? principal,
   double? interestRate,
   double? years,
   int? timesPerYear)
        {
            
            // (1 + r/n)
            double body = (double)(1 + (interestRate / (timesPerYear*100)));

            // nt
            double exponent = (double)(timesPerYear * years);

            // P(1 + r/n)^nt
            return (double)principal * Math.Pow(body, exponent);
        }
        public FixedDepositInterest CalculateFinalAmount(string fdContractCode)
        {

            double? effectiveInterestRate = 0.0;
          
            double? finalAmount;
            
            int? prematured = 0;

           FixedDepositProductHoldings _fixedDepositProductHoldings = FetchProduct(fdContractCode);

          
             
             int? maturityPeriod = _fixedDepositProductHoldings.MaturityPeriod;
            string penalityType = _fixedDepositProductHoldings.PenalityType;
            DateTime openingDate = _fixedDepositProductHoldings.OpenDate.Date;
            DateTime maturityDate = openingDate.AddMonths((int)maturityPeriod);
            double? interestRate = _fixedDepositProductHoldings.InterestRate;
             string interestCalculationFrequency = _fixedDepositProductHoldings.InterestCalculationFrequency;
             double? initialAmount = Convert.ToDouble(_fixedDepositProductHoldings.InitialAmount);

             int? frequency = Convert.ToInt32(interestCalculationFrequency);

            

            Currency productCurrency = _fixedDepositProductHoldings.FixedDepositProduct.Currency;
                        double? penaltyRate = _fixedDepositProductHoldings.Penality;

            double? effectiveDepositPeriod = 0;

            if(productCurrency.Name == "USD")
                effectiveDepositPeriod = Convert.ToDouble(((DateTime.Now.Date - openingDate).TotalDays) / 360);
            else
                effectiveDepositPeriod = Convert.ToDouble(((DateTime.Now.Date - openingDate).TotalDays) / 365);

                       
            
                        if (DateTime.Now.Date >= maturityDate)
                        {
                            effectiveInterestRate = interestRate;
                            finalAmount = CalculateInterest(initialAmount, effectiveInterestRate, effectiveDepositPeriod , frequency);
                        }
                        else
                        {
                            prematured = 1;
                            if (penalityType == "Rate")
                            {
                                effectiveInterestRate = interestRate - penaltyRate;
                                finalAmount = CalculateInterest(initialAmount, effectiveInterestRate, effectiveDepositPeriod, frequency);
                               

                            }
                            else
                            {
                                finalAmount = CalculateInterest(initialAmount, effectiveInterestRate, effectiveDepositPeriod, frequency);
                                finalAmount = finalAmount - penaltyRate;
                                if ((finalAmount - initialAmount) > penaltyRate)
                                {
                                    finalAmount = finalAmount - penaltyRate;
                                }
                                else
                                {
                                    finalAmount = initialAmount;
                                }
                               
                            }
                            
                            
                        }

                        FixedDepositInterest _fixedDepositInterest = new FixedDepositInterest();
                        _fixedDepositInterest.EffectiveDepositPeriod = effectiveDepositPeriod;
                        _fixedDepositInterest.EffectiveInterestRate = effectiveInterestRate;
                        _fixedDepositInterest.FinalAmount = Convert.ToDecimal(finalAmount);
                        _fixedDepositInterest.FinalInterest = Convert.ToDecimal(finalAmount - initialAmount);
                        _fixedDepositInterest.InitialAmount = Convert.ToDecimal(initialAmount);
                        _fixedDepositInterest.Penalty = penaltyRate;
                        _fixedDepositInterest.PenaltyType = penalityType;
                        _fixedDepositInterest.PreMatured = prematured;



                        return _fixedDepositInterest;

                    }
             


            
        }


    }

