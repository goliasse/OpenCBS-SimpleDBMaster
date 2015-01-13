using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Accounting;

namespace OpenCBS.Manager
{
    public class IncomeManager : Manager
    {
        User _user;
        public IncomeManager(User pUser)
            : base(pUser)
        {
            _user = pUser;
        }

        public IncomeManager(string testDB) : base(testDB)
        {

        }

        public int SaveIncome(Income income)
        {
            const string q = @"INSERT INTO [dbo].[Income]
                   ([incomeDate]
                   ,[incomeCategory]
                   ,[incomeDescription]
                   ,[incomeAmount]
                   ,[reference]
                   ,[currency]
                   ,[branch])
             VALUES
                   (@incomeDate
                   ,@incomeCategory
                   ,@incomeDescription
                   ,@incomeAmount
                   ,@reference
                   ,@currency
                   ,@branch) 
                    SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetIncome(c, income);
                int id = Convert.ToInt32(c.ExecuteScalar());
                income.Id = id;
                return id;
            }
            
        }

        private static void SetIncome(OpenCbsCommand c, Income income)
        {

            c.AddParam("@incomeDate", income.IncomeDate);
            c.AddParam("@incomeCategory", income.IncomeCategory);
            c.AddParam("@incomeDescription", income.IncomeDescription);
            c.AddParam("@incomeAmount", income.IncomeAmount);
            c.AddParam("@reference", income.Reference);
            c.AddParam("@currency", income.Currency);
            c.AddParam("@branch", income.Branch);


        }

        public Income FetchIncome(int id)
        {
            const string q = @"SELECT * FROM [dbo].[Income] WHERE [id] = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@id", id);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (Income)GetIncome(r);
                }
            }
        }

        public List<Income> FetchAll()
        {
            List<Income> incomeList = new List<Income>();
            const string q = @"SELECT * FROM [dbo].[Income] ";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {


                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;
                    while (r.Read())
                    {
                        incomeList.Add((Income)GetIncome(r));
                    }
                }
            }
            return incomeList;
        }
        private static Income GetIncome(OpenCbsReader reader)
        {
            Income income = new Income();
            income.Id = reader.GetInt("id");
            income.IncomeCategory = reader.GetString("IncomeCategory");
            income.IncomeDescription = reader.GetString("IncomeDescription");

            income.Reference = reader.GetString("reference");

            income.IncomeDate = reader.GetDateTime("IncomeDate");
            income.IncomeAmount = reader.GetMoney("IncomeAmount");

            income.Currency = reader.GetString("currency");
            income.Branch = reader.GetString("branch");

            return income;


        }

        public int DeleteIncome(int id)
        {
            const string q = @"DELETE FROM [dbo].[Income] WHERE id = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@id", id);
                c.ExecuteNonQuery();
            }

            return 1;
        }

        public int UpdateIncome(Income income)
        {
            const string q = @"UPDATE [dbo].[Income]
               SET [IncomeDate] = @IncomeDate
                  ,[IncomeCategory] = @IncomeCategory
                  ,[IncomeDescription] = @IncomeDescription
                  ,[IncomeAmount] = @IncomeAmount
                  ,[reference] = @reference
                   ,[currency] = @currency
                   ,[branch] = @branch
                    WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetIncome(c, income);
                c.AddParam("@id", income.Id);

                c.ExecuteNonQuery();
            }

            return 1;

        }

    }
}
