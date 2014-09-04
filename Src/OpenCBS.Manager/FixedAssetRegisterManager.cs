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
        User _user;
        public FixedAssetRegisterManager(User pUser) : base(pUser) {
            _user = pUser;
        }

        public FixedAssetRegisterManager(string testDB) : base(testDB) { }

        private static FixedAssetRegister GetProduct(OpenCbsReader reader)
        {
            FixedAssetRegister fixedAssetRegister = new FixedAssetRegister();
            fixedAssetRegister.Id = reader.GetInt("id");
            fixedAssetRegister.UpdaterId = reader.GetInt("updater_id");
            fixedAssetRegister.Branch = reader.GetString("branch");
            fixedAssetRegister.AssetId = reader.GetString("Asset_id");

            fixedAssetRegister.Description = reader.GetString("Description");
            fixedAssetRegister.AssetType = reader.GetString("Asset_type");
            fixedAssetRegister.NoOfAssets = reader.GetInt("No_of_assets");
            fixedAssetRegister.AcquisitionDate = reader.GetDateTime("Acquisition_date");
            fixedAssetRegister.OriginalCost = reader.GetMoney("Original_cost");
            fixedAssetRegister.AnnualDepreciationRate = reader.GetDouble("Annual_depreciation_rate");
            fixedAssetRegister.AccumulatedDepreciationCharge = reader.GetMoney("Accumulated_depreciation_charge");
            fixedAssetRegister.NetBookValue = reader.GetMoney("Net_book_value");
            fixedAssetRegister.DisposalDate = reader.GetDateTime("Disposal_date");
            fixedAssetRegister.ProfitLossDisposal = reader.GetNullInt("Profit_loss_disposal");
            fixedAssetRegister.AcquisitionCapitalFinance = reader.GetString("Acquisition_capital_finance");

            fixedAssetRegister.AcquisitionCapitalTransaction = reader.GetString("Acquisition_capital_transaction");
            fixedAssetRegister.DisposalAmountTransfer = reader.GetString("Disposal_amount_transfer");
            fixedAssetRegister.DisposalAmountTransaction = reader.GetString("Disposal_amount_transaction");
            return fixedAssetRegister;

            
        }

        private static void SetProduct(OpenCbsCommand c, FixedAssetRegister fixedAssetRegister)
        {
            c.AddParam("@updaterId", User.CurrentUser.Id);
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
            const string q = @"INSERT INTO [FixedAssetRegister]
           ([updater_id]
           ,[branch]
           ,[Asset_id]
           ,[Description]
           ,[Asset_type]
           ,[No_of_assets]
           ,[Acquisition_date]
           ,[Disposal_date]
           ,[Original_cost]
           ,[Annual_depreciation_rate]
           ,[Acquisition_capital_finance]
           ,[Acquisition_capital_transaction])
     
             VALUES(@updaterId, 
                    @branch,
                    @assetId,
                    @Description, 
                    @assetType, 
                    @noOfAssets,
                    @acquisitionDate,
                    @disposalDate, 
                    @originalCost, 
                    @annualDepreciationRate,
                    @acquisitionCapitalFinance,
                    @acquisitionCapitalTransaction)
                    SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetProduct(c, fixedAssetRegister);
                int id = Convert.ToInt32(c.ExecuteScalar());
                fixedAssetRegister.Id = id;
                fixedAssetRegister.AssetId = fixedAssetRegister.Branch + "/" + "FAR" + "/" +id;
                UpdateAssetId(fixedAssetRegister);
                return id;
            }
        }


        public void UpdateAssetId(FixedAssetRegister fixedAssetRegister)
        {
            const string q = @"UPDATE [FixedAssetRegister]
       SET 
      [Asset_id] = @assetId
      
        WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                
                c.AddParam("@id", fixedAssetRegister.Id);
                c.AddParam("@assetId", fixedAssetRegister.AssetId);

                c.ExecuteNonQuery();
            }

        }

        public int UpdateFixedAssetRegister(FixedAssetRegister fixedAssetRegister)
        {
            const string q = @"UPDATE [FixedAssetRegister]
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

            return 1;

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
                c.AddParam("@branch", branch);

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
