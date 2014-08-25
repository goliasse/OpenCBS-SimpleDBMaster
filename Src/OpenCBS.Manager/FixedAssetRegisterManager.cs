using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;

namespace OpenCBS.Manager
{
    public class FixedAssetRegisterManager : Manager
    {
        public FixedAssetRegisterManager(User pUser) : base(pUser) { }

        public FixedAssetRegisterManager(string testDB) : base(testDB) { }

        private static FixedAssetRegister GetProduct(OpenCbsReader reader)
        {
            return new FixedAssetRegister
            {
                Id = reader.GetInt("id"),
                UpdaterId = reader.GetInt("updater_id"),
                Branch = reader.GetString("branch"),
                AssetId = reader.GetString("Asset_id"),

                Description = reader.GetString("Description"),
                AssetType = reader.GetString("Asset_type"),
                NoOfAssets = reader.GetInt("No_of_assets"),
                AcquisitionDate = reader.GetDateTime("Acquisition_date"),
                OriginalCost = reader.GetMoney("Original_cost"),
                AnnualDepreciationRate = reader.GetDouble("Annual_depreciation_rate"),
                AccumulatedDepreciationCharge = reader.GetMoney("Accumulated_depreciation_charge"),
                NetBookValue = reader.GetMoney("Net_book_value"),
                DisposalDate = reader.GetDateTime("Disposal_date"),
                ProfitLossDisposal = reader.GetInt("Profit_loss_disposal"),
                AcquisitionCapitalFinance = reader.GetString("Acquisition_capital_finance"),

                AcquisitionCapitalTransaction = reader.GetString("Acquisition_capital_transaction"),
                DisposalAmountTransfer = reader.GetString("Disposal_amount_transfer"),
                DisposalAmountTransaction = reader.GetString("Disposal_amount_transaction"),

            };
        }

        private static void SetProduct(OpenCbsCommand c, FixedAssetRegister fixedAssetRegister)
        {
            c.AddParam("@updaterId", fixedAssetRegister.UpdaterId);
            c.AddParam("@branch", fixedAssetRegister.Branch);
            c.AddParam("@assetId", fixedAssetRegister.AssetId);
            c.AddParam("@Description", fixedAssetRegister.Description);
            c.AddParam("@assetType", fixedAssetRegister.AssetType);
            c.AddParam("@noOfAssets", fixedAssetRegister.NoOfAssets);

            c.AddParam("@acquisitionDate", fixedAssetRegister.AcquisitionDate);
            c.AddParam("@originalCost", fixedAssetRegister.OriginalCost);
            c.AddParam("@annualDepreciationRate", fixedAssetRegister.AnnualDepreciationRate);
            c.AddParam("@accumulatedDepreciationCharge", fixedAssetRegister.AccumulatedDepreciationCharge);
            c.AddParam("@netBookValue", fixedAssetRegister.NetBookValue);
            c.AddParam("@disposalDate", fixedAssetRegister.DisposalDate);

            c.AddParam("@profitLossDisposal", fixedAssetRegister.ProfitLossDisposal);
            c.AddParam("@acquisitionCapitalFinance", fixedAssetRegister.AcquisitionCapitalFinance);
            c.AddParam("@acquisitionCapitalTransaction", fixedAssetRegister.AcquisitionCapitalTransaction);
            c.AddParam("@disposalAmountTransfer", fixedAssetRegister.DisposalAmountTransfer);
            c.AddParam("@disposalAmountTransaction", fixedAssetRegister.DisposalAmountTransaction);

        }


        public int InsertFixedAssetRecord(FixedAssetRegister fixedAssetRegister)
        {
            const string q = @"INSERT INTO [Test].[dbo].[FixedAssetRegister]
           ([updater_id]
           ,[branch]
           ,[Asset_id]
           ,[Description]
           ,[Asset_type]
           ,[No_of_assets]
           ,[Acquisition_date]
           ,[Original_cost]
           ,[Annual_depreciation_rate]
           ,[Accumulated_depreciation_charge]
           ,[Net_book_value]
           ,[Disposal_date]
           ,[Profit_loss_disposal]
           ,[Acquisition_capital_finance]
           ,[Acquisition_capital_transaction]
           ,[Disposal_amount_transfer]
           ,[Disposal_amount_transaction])
     
             VALUES(@updaterId, 
                    @branch,
                    @assetId,
                    @Description, 
                    @assetType, 
                    @noOfAssets,
                    @acquisitionDate, 
                    @originalCost, 
                    @annualDepreciationRate, 
                    @accumulatedDepreciationCharge,
                    @netBookValue, 
                    @disposalDate, 
                    @profitLossDisposal,
                    @acquisitionCapitalFinance,
                    @acquisitionCapitalTransaction,
                    @disposalAmountTransfer, 
                    @disposalAmountTransaction )";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetProduct(c, fixedAssetRegister);
                return int.Parse(c.ExecuteScalar().ToString());
            }
        }

        public void UpdateFixedAssetRegister(FixedAssetRegister fixedAssetRegister)
        {
            const string q = @"UPDATE [Test].[dbo].[FixedAssetRegister]
       SET [updater_id] = @updaterId
      ,[branch] = @branch
      ,[Asset_id] = @assetId
      ,[Description] = @Description
      ,[Asset_type] = @assetType
      ,[No_of_assets] = @noOfAssets
      ,[Acquisition_date] = @acquisitionDate
      ,[Original_cost] = @originalCost
      ,[Annual_depreciation_rate] = @annualDepreciationRate
      ,[Accumulated_depreciation_charge] = @accumulatedDepreciationCharge
      ,[Net_book_value] = @netBookValue
      ,[Disposal_date] = @disposalDate
      ,[Profit_loss_disposal] = @profitLossDisposal
      ,[Acquisition_capital_finance] = @acquisitionCapitalFinance
      ,[Acquisition_capital_transaction] = @acquisitionCapitalTransaction
      ,[Disposal_amount_transfer] = @disposalAmountTransfer
      ,[Disposal_amount_transaction] = @disposalAmountTransfer
        WHERE Asset_id = @Asset_id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetProduct(c, fixedAssetRegister);
                c.AddParam("@Asset_id", fixedAssetRegister.AssetId);
        
                c.ExecuteNonQuery();
            }

        }
        public FixedAssetRegister FetchFixedAssetRecord(string assetId)
        {
            const string q = @"SELECT * FROM [FixedAssetRegister] WHERE [Asset_id] = @Asset_id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@Asset_id", assetId);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (FixedAssetRegister)GetProduct(r);
                }
            }
        }

        public List<FixedAssetRegister> FetchFixedAssetRegister(string branch)
        {
            List<FixedAssetRegister> listFixedAssetRegister = new List<FixedAssetRegister>();
            const string q = @"SELECT * FROM [FixedAssetRegister] WHERE [branch] = @branch";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {


                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    while (r.Read())
                    {

                        FixedAssetRegister product = FetchFixedAssetRecord(r.GetString("Asset_id"));

                        listFixedAssetRegister.Add(product);
                    }
                }
            }

            return listFixedAssetRegister;

            
        }
    }
}
