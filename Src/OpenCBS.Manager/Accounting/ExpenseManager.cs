﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using System.Data.SqlClient;
using OpenCBS.CoreDomain.Accounting;

namespace OpenCBS.Manager
{
    public class ExpenseManager : Manager
    {
        User _user;
        public ExpenseManager(User pUser)
            : base(pUser)
        {
            _user = pUser;
        }

        public ExpenseManager(string testDB) : base(testDB) { }

        public int AddExpense(Expense expense)
        {
            const string q = @"INSERT INTO [dbo].[Expenses]
                   ([expenseDate]
                   ,[expenseCategory]
                   ,[expenseDescription]
                   ,[expenseAmount]
                   ,[reference])
             VALUES
                   (@expenseDate
                   ,@expenseCategory
                   ,@expenseDescription
                   ,@expenseAmount
                   ,@reference) 
SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetExpense(c, expense);
                int id = Convert.ToInt32(c.ExecuteScalar());
                expense.Id = id;
                return id;
            }
        }

        private static void SetExpense(OpenCbsCommand c, Expense expense)
        {

            c.AddParam("@expenseDate", expense.ExpenseDate);
            c.AddParam("@expenseCategory", expense.ExpenseCategory);
            c.AddParam("@expenseDescription", expense.ExpenseDescription);
            c.AddParam("@expenseAmount", expense.ExpenseAmount);
            c.AddParam("@reference", expense.Reference);


        }

        

        private static Expense GetExpense(OpenCbsReader reader)
        {
            Expense expense = new Expense();
            expense.Id = reader.GetInt("id");
            expense.ExpenseCategory = reader.GetString("expenseCategory");
            expense.ExpenseDescription = reader.GetString("expenseDescription");

            expense.Reference = reader.GetString("reference");

            expense.ExpenseDate = reader.GetDateTime("expenseDate");
            expense.ExpenseAmount = reader.GetMoney("expenseAmount");

            return expense;


        }

        public List<Expense> FetchExpenses()
        {
            List<Expense> listExpesne = new List<Expense>();
            const string q = @"SELECT * FROM [dbo].[Expenses]";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
               

                using (OpenCbsReader r = c.ExecuteReader())
                {

                    if (r == null || r.Empty) return null;

                    while (r.Read())
                    {

                        Expense expense = GetExpense(r);

                        listExpesne.Add(expense);
                    }
                }
            }

            return listExpesne;


        }

        public int UpdateExpense(Expense expense)
        {
            const string q = @"UPDATE [dbo].[Expenses]
               SET [expenseDate] = @expenseDate
                  ,[expenseCategory] = @expenseCategory
                  ,[expenseDescription] = @expenseDescription
                  ,[expenseAmount] = @expenseAmount
                  ,[reference] = @reference
                    WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetExpense(c, expense);
                c.AddParam("@id", expense.Id);

                c.ExecuteNonQuery();
            }

            return 1;

        }


        public int DeleteExpense(int Id)
        {
            const string q = @"DELETE FROM [dbo].[Expenses] WHERE id = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {

                c.AddParam("@id", Id);
                c.ExecuteNonQuery();
            }

            return 1;
        }

    }
}