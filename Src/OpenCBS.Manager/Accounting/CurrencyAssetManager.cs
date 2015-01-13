using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Accounting;

namespace OpenCBS.Manager.Accounting
{
    public class CurrencyAssetManager : Manager
    {

        User _user;
        public CurrencyAssetManager(User pUser)
            : base(pUser)
        {
            _user = pUser;
        }

        public CurrencyAssetManager(string testDB) : base(testDB) 
        {

        }

        private static CurrencyAssets GetCurrencyAssets(OpenCbsReader reader)
        {
            CurrencyAssets currencyAssets = new CurrencyAssets();


            currencyAssets.Id = reader.GetInt("id");
            currencyAssets.AssetCategory = reader.GetString("assetCategory");

            currencyAssets.AssetDescription = reader.GetString("assetDescription");
            currencyAssets.Reference = reader.GetString("reference");
            currencyAssets.AssetDate = reader.GetDateTime("assetDate");

            currencyAssets.AssetAmount = reader.GetMoney("assetAmount");
            return currencyAssets;

        }

        private static void SetCurrencyAssets(OpenCbsCommand c, CurrencyAssets currencyAssets)
        {
            c.AddParam("@assetCategory", currencyAssets.AssetCategory);
            c.AddParam("@assetDescription", currencyAssets.AssetDescription);
            c.AddParam("@reference", currencyAssets.Reference);
            c.AddParam("@assetDate", currencyAssets.AssetDate);
            c.AddParam("@assetAmount", currencyAssets.AssetAmount);

        }

        public void UpdateCurrencyAssets(CurrencyAssets currencyAssets)
        {

            const string q = @" UPDATE [dbo].[CurrencyAssets]
                           SET [assetDate] = @assetDate
                              ,[assetCategory] = @assetCategory
                              ,[assetDescription] = @assetDescription
                              ,[assetAmount] = @assetAmount
                              ,[reference] = @reference
                                     WHERE id = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetCurrencyAssets(c, currencyAssets);
                c.ExecuteNonQuery();
            }

        }

        public CurrencyAssets FetchCurrencyAssets(int id)
        {
            const string q = @"SELECT * FROM [dbo].[CurrencyAssets] WHERE [id] = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@id", id);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty)
                        return null;

                    r.Read();
                    return (CurrencyAssets)GetCurrencyAssets(r);
                }
            }

        }

        public List<CurrencyAssets> FetchAll()
        {
            List<CurrencyAssets> listCurrencyAssets = new List<CurrencyAssets>();
            const string q = @"SELECT * FROM [dbo].[CurrencyAssets]";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    while(r.Read())
                    {
                    
                    listCurrencyAssets.Add((CurrencyAssets)GetCurrencyAssets(r));
                    }
                    
                }
            }

            return listCurrencyAssets;

        }

        public int SaveCurrencyAssets(CurrencyAssets currencyAssets)
        {

            const string q = @"INSERT INTO [dbo].[CurrencyAssets]
           ([assetDate]
           ,[assetCategory]
           ,[assetDescription]
           ,[assetAmount]
           ,[reference])

        VALUES
                (@assetDate,
                @assetCategory,
                @assetDescription,
                @assetAmount,
                @reference)
                SELECT SCOPE_IDENTITY()";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetCurrencyAssets(c, currencyAssets);
                currencyAssets.Id = Convert.ToInt32(c.ExecuteScalar());
            }
            return currencyAssets.Id;
        }
        public int DeleteCurrencyAssets(int id)
        {

            const string q = @"DELETE FROM [dbo].[CurrencyAssets]
                                WHERE id = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@id", id);
                c.ExecuteNonQuery();
            }

            return 1;

        }
    }
}
