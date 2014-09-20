using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;

namespace OpenCBS.Manager
{
    public class RWAPercentageManager : Manager
    {
        User _user;
        public RWAPercentageManager(User pUser) : base(pUser)
        {
            _user = pUser;
        }

        public RWAPercentageManager(string testDB)
            : base(testDB)
        {

        }

        public double FetchRWAPercentage (string RWA)
{
double percentage = 0;
string q = @"SELECT [risk_weighted_percentage]
FROM [dbo].[RiskWeightedAssetPercenatge]
WHERE [risk_weighted_asset] = @RWA";

using (SqlConnection conn = GetConnection())
using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
{
c.AddParam("@RWA", RWA);
using (OpenCbsReader r = c.ExecuteReader())
{
if (r == null || r.Empty) return 0;
r.Read();
percentage = r.GetDouble("risk_weighted_percentage");
}
}
return percentage;
}


public int SaveRWAPercentage(RWAPercentage RWAPercentage)
{
const string q = @"INSERT INTO [RiskWeightedAssetPercenatge]
([risk_weighted_asset],
[risk_weighted_percentage]
)
VALUES
(@RWA,
@percentage
)
SELECT SCOPE_IDENTITY()";
using (SqlConnection conn = GetConnection())
using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
{
c.AddParam("@RWA", RWAPercentage.RWA);
c.AddParam("@percentage", RWAPercentage.Percentage);
return Convert.ToInt32(c.ExecuteScalar());
}
}


public int UpdateRWAPercentage(RWAPercentage RWAPercentage)
{
    const string q = @"UPDATE [RiskWeightedAssetPercenatge]
SET [risk_weighted_percentage]=@risk_weighted_percentage
WHERE [risk_weighted_asset]=@RWA";
    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
        c.AddParam("@RWA", RWAPercentage.RWA);
        c.AddParam("@risk_weighted_percentage", RWAPercentage.Percentage);
        return Convert.ToInt32(c.ExecuteScalar());
    }
}


    }
}
