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
        public CounterBalanceManager(User pUser) : base(pUser)
        {
            _user = pUser;
        }

        public CounterBalanceManager(string testDB) : base(testDB)
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

        public int UpdateCounterBalance(CounterBalance counterBalance)
        {
            int ret = -99;
            using (SqlConnection conn = GetConnection())
            {
                using (OpenCbsCommand c = new OpenCbsCommand("UpdateCounterBalance", conn).AsStoredProcedure())
                {
                    c.AddParam("@allocaterId", _user.Id);
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
            counterBalance.AllocaterId = r.GetInt("allocater_id");
            counterBalance.Branch = r.GetString("branch");
            counterBalance.CashierId = r.GetInt("cashier_id");
            counterBalance.CounterId = r.GetInt("counter_id");
            counterBalance.AllocationDate = r.GetDateTime("allocation_date");
            counterBalance.Amount = r.GetMoney("amount");
            counterBalance.Type = r.GetString("type");
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
    }
}
