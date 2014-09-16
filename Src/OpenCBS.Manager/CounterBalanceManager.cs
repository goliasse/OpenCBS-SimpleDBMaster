using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;

namespace OpenCBS.Manager
{
    public class CounterBalanceManager : Manager
    {
        User _user;
        public CounterBalanceManager(User pUser)
            : base(pUser)
        {
            _user = pUser;
        }

        public CounterBalanceManager(string testDB)
            : base(testDB)
        {
        }

        public int UpdateCounterBalance(CounterBalance counterBalance)
        {
            int ret = -99;
            using (SqlConnection conn = GetConnection())
            {
                using (OpenCbsCommand c = new OpenCbsCommand("UpdateCounterBalance", conn).AsStoredProcedure())
                {
                    c.AddParam("@allocaterId", counterBalance.AllocaterId);
                    c.AddParam("@branch", counterBalance.Branch);
                    c.AddParam("@cashierId", counterBalance.CashierId);
                    c.AddParam("@counterId", counterBalance.CounterId);
                    c.AddParam("@allocationDate", counterBalance.AllocationDate);
                    c.AddParam("@amount", counterBalance.Amount);
                    c.AddParam("@type", counterBalance.Type);
                    ret = Convert.ToInt32(c.ExecuteScalar());

                }
            }
            return ret;
        }



        public int SaveCounterBalance(CounterBalance counterBalance)
        {
            const string q = @"INSERT INTO [CounterBalance]
            (
            [allocater_id],
            [branch],
            [cashier_id],
            [counter_id],
            [allocation_date],
            [amount],
            [type])

            VALUES
            (
            @allocaterId,
            @branch,
            @cashierId,
            @counterId,
            @allocationDate,
            @amount,
            @type)

            SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {

                SetCounterBalance(c, counterBalance);
                counterBalance.Id = Convert.ToInt32(c.ExecuteScalar());

            }

            return counterBalance.Id;
        }

        public void SetCounterBalance(OpenCbsCommand c, CounterBalance counterBalance)
        {
            c.AddParam("@allocaterId", _user.Id);
            c.AddParam("@branch", counterBalance.Branch);
            c.AddParam("@cashierId", counterBalance.CashierId);
            c.AddParam("@counterId", counterBalance.CounterId);
            c.AddParam("@allocationDate", counterBalance.AllocationDate);
            c.AddParam("@amount", counterBalance.Amount);
            c.AddParam("@type", counterBalance.Type);
        }

        public CounterBalance GetCounterBalance(OpenCbsReader r)
        {
            CounterBalance counterBalance = new CounterBalance();
            counterBalance.Id = r.GetInt("id");
            
            counterBalance.Branch = r.GetString("branch");
            counterBalance.CashierId = r.GetString("cashier_id");
            counterBalance.CounterId = r.GetString("counter_id");
            counterBalance.AllocationDate = r.GetDateTime("allocation_date");
            counterBalance.Amount = r.GetMoney("amount");
            counterBalance.Type = r.GetString("type");
            counterBalance.AllocaterId = r.GetInt("allocater_id");
            return counterBalance;
        }

        public List<CounterBalance> FetchCounterBalance(string branch, string allocationDate)
        {
            List<CounterBalance> counterBalanceList = new List<CounterBalance>();
            string q = @"SELECT
            [id],
            [allocater_id],
            [branch],
            [cashier_id],
            [counter_id],
            [allocation_date],
            [amount],
            [type]
            FROM [dbo].[CounterBalance]
            WHERE branch = @branch AND allocation_date = @allocationDate";
            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@allocationDate", allocationDate);
                c.AddParam("@branch", branch);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return new List<CounterBalance>();
                    while (r.Read())
                    {
                        CounterBalance counterBalance = GetCounterBalance(r);
                        counterBalanceList.Add(counterBalance);
                    }
                }
            }
            return counterBalanceList;
        }


        
    public List<BranchCounter> FetchCounters(string branch)
    {
    List<BranchCounter> branchCounterList = new List<BranchCounter>();
    string q = @"SELECT *
    FROM [dbo].[BranchCounter]
    WHERE branch = @branch";

    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
    c.AddParam("@branch", branch);
        using (OpenCbsReader r = c.ExecuteReader())
        {
        if (r == null || r.Empty) return new List<BranchCounter>();
            while (r.Read())
            {
                BranchCounter branchCounter = new BranchCounter();
                branchCounter.Branch = r.GetString("branch");
                branchCounter.CounterId =  r.GetString("counterid");
                branchCounter.Description =  r.GetString("description");
                branchCounterList.Add(branchCounter);
            }
        }
    }
    return branchCounterList;
    }

    public List<string> FetchCashiers()
    {
        List<string> CashierList = new List<string>();
        string q = @"SELECT user_name
    FROM [dbo].[Users]
    WHERE role_code = 'CASHI'";

        using (SqlConnection conn = GetConnection())
        using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
        {
            
            using (OpenCbsReader r = c.ExecuteReader())
            {
                if (r == null || r.Empty) return new List<string>();
                while (r.Read())
                {
                    
                    CashierList.Add(r.GetString("user_name"));
                    
                }
            }
        }
        return CashierList;
    }



    public int SaveBranchCounter(BranchCounter branchCounter)
    {
    const string q = @"INSERT INTO [BranchCounter]
    ([Branch],
    [description]
    )
    VALUES
    (@branch,
    @description
    )
    SELECT SCOPE_IDENTITY()";
    using (SqlConnection conn = GetConnection())
    using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
    {
        c.AddParam("@branch", branchCounter.Branch);
        c.AddParam("@description", branchCounter.Description);
        branchCounter.Id = Convert.ToInt32(c.ExecuteScalar());

        UpdateBranchCounter(branchCounter);
    }
    return branchCounter.Id;
    }


    public void UpdateBranchCounter(BranchCounter branchCounter)
    {
    const string q = @"UPDATE [BranchCounter]
    SET [counterId] = @counterId WHERE id = @id";

    using (SqlConnection conn = GetConnection())
        using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
        {
        c.AddParam("@counterId", branchCounter.Branch + "/Counter/" + branchCounter.Id);
        c.AddParam("@id", branchCounter.Id);
        c.ExecuteScalar();

        }
    }

    }
}