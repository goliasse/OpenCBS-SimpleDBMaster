using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Manager.Currencies;

namespace OpenCBS.Manager
{
    public class LetterOfCreditManager : Manager
    {
        public LetterOfCreditManager(User pUser)
            : base(pUser)
        {

        }

        public LetterOfCreditManager(string testDB)
            : base(testDB)
        {

        }


        private static LetterOfCredit GetLetterOfCredit(OpenCbsReader reader)
        {
            LetterOfCredit letterOfCredit = new LetterOfCredit();

            letterOfCredit.Id = reader.GetInt("id");

            letterOfCredit.LetterOfCreditCode = reader.GetString("letterOfCreditCode");
            letterOfCredit.IssuingDate = reader.GetDateTime("issuingDate");
            letterOfCredit.ExpiryDate = reader.GetDateTime("expiryDate");
            letterOfCredit.ClientId = reader.GetInt("clientId");
            letterOfCredit.BeneficiaryParty = reader.GetString("beneficiaryParty");
            letterOfCredit.InstrumentType = reader.GetString("instrumentType");
            letterOfCredit.InstrumentDescription = reader.GetString("instrumentDescription");
            letterOfCredit.FeePerPeriod = reader.GetMoney("feePerPeriod");
            letterOfCredit.FeePeriod = reader.GetString("feePeriod");
            letterOfCredit.InstrumentDescription = reader.GetString("instrumentDescription");
            letterOfCredit.Value = reader.GetMoney("value");
            letterOfCredit.Currency = reader.GetString("currency");
            letterOfCredit.Status = reader.GetString("status");
            letterOfCredit.Branch = reader.GetString("branch");
            letterOfCredit.FeeTransactionNumber = reader.GetString("feeTransactionNumber");
            return letterOfCredit;
        }

        private static void SetLetterOfCredit(OpenCbsCommand c, LetterOfCredit letterOfCredit)
        {
            c.AddParam("@letterOfCreditCode", letterOfCredit.LetterOfCreditCode);
            c.AddParam("@issuingDate", letterOfCredit.IssuingDate);
            c.AddParam("@expiryDate", letterOfCredit.ExpiryDate);

            c.AddParam("@clientId", letterOfCredit.ClientId);
            c.AddParam("@beneficiaryParty", letterOfCredit.BeneficiaryParty);
            c.AddParam("@instrumentType", letterOfCredit.InstrumentType);

            c.AddParam("@feePerPeriod", letterOfCredit.FeePerPeriod);
            c.AddParam("@feePeriod", letterOfCredit.FeePeriod);
            c.AddParam("@instrumentDescription", letterOfCredit.InstrumentDescription);
            c.AddParam("@value", letterOfCredit.Value);
            c.AddParam("@currency", letterOfCredit.Currency);
            c.AddParam("@status", letterOfCredit.Status);
            c.AddParam("@branch", letterOfCredit.Branch);
            c.AddParam("@feeTransactionNumber", letterOfCredit.FeeTransactionNumber);

        }
        public void UpdateLetterOfCredit(LetterOfCredit letterOfCredit)
        {
            const string q = @"UPDATE [dbo].[LetterOfCredit]
                       SET [letterOfCreditCode] = @letterOfCreditCode
                          ,[clientId] = @clientId
                          ,[branch] = @branch
                          ,[issuingDate] = @issuingDate
                          ,[expiryDate] = @expiryDate
                          ,[instrumentType] = @instrumentType
                          ,[instrumentDescription] = @instrumentDescription
                          ,[value] = @value
                          ,[currency] = @currency
                          ,[beneficiaryParty] = @beneficiaryParty
                          ,[feePerPeriod] = @feePerPeriod
                          ,[feePeriod] = @feePeriod
                          ,[status] = @status
                                     WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetLetterOfCredit(c, letterOfCredit);
                c.AddParam("@id", letterOfCredit.Id);
                c.ExecuteNonQuery();
            }

        }

        public LetterOfCredit FetchLetterOfCredit(string letterOfCreditCode)
        {
            const string q = @"SELECT * FROM [LetterOfCredit] WHERE [letterOfCreditCode] = @letterOfCreditCode";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@letterOfCreditCode", letterOfCreditCode);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (LetterOfCredit)GetLetterOfCredit(r);
                }
            }

        }

        public List<LetterOfCredit> FetchAllLetterOfCredit()// no parameters to be specified here?
        {
            List<LetterOfCredit> listLetterOfCredit = new List<LetterOfCredit>();
            const string q = @"SELECT * FROM [LetterOfCredit]";// WHERE applicantId = @clientId";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                // c.AddParam("@clientId", clientID);
                using (OpenCbsReader r = c.ExecuteReader())
                {

                    if (r == null || r.Empty) return new List<LetterOfCredit>();

                    while (r.Read())
                    {
                        listLetterOfCredit.Add((LetterOfCredit)GetLetterOfCredit(r));
                    }
                    return listLetterOfCredit;
                }
            }

        }


        public List<LetterOfCredit> FetchClientLetterOfCredit(int applicantId)
        {
            List<LetterOfCredit> listLetterOfCredit = new List<LetterOfCredit>();
            const string q = @"SELECT * FROM [LetterOfCredit] WHERE clientId = @clientId";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@clientId", applicantId);
                using (OpenCbsReader r = c.ExecuteReader())
                {

                    if (r == null || r.Empty) return new List<LetterOfCredit>();

                    while (r.Read())
                    {
                        listLetterOfCredit.Add((LetterOfCredit)GetLetterOfCredit(r));
                    }
                    return listLetterOfCredit;
                }
            }

        }


        public string SaveLetterOfCredit(LetterOfCredit letterOfCredit)
        {

            const string q = @"INSERT INTO [dbo].[LetterOfCredit]
           (
            [clientId]
           ,[branch]
           ,[issuingDate]
           ,[expiryDate]
           ,[instrumentType]
           ,[instrumentDescription]
           ,[value]
           ,[currency]
           ,[beneficiaryParty]
           ,[feePerPeriod]
           ,[feePeriod]
           ,[status]
           ,[feeTransactionNumber])
     VALUES
           (
            @clientId
           ,@branch
           ,@issuingDate
           ,@expiryDate
           ,@instrumentType
           ,@instrumentDescription
           ,@value
           ,@currency
           ,@beneficiaryParty
           ,@feePerPeriod
           ,@feePeriod
           ,@status
           ,@feeTransactionNumber)
                SELECT SCOPE_IDENTITY()";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetLetterOfCredit(c, letterOfCredit);
                letterOfCredit.Id = Convert.ToInt32(c.ExecuteScalar());
                letterOfCredit.LetterOfCreditCode = letterOfCredit.Branch + "/LC/" + letterOfCredit.Id;
                UpdateLetterOfCreditCode(letterOfCredit);
                //check the above statements

            }
            return letterOfCredit.Branch + "/LC/" + letterOfCredit.Id;
        }


        public void UpdateLetterOfCreditCode(LetterOfCredit letterOfCredit)
        {
            const string q = @"UPDATE [dbo].[LetterOfCredit]
                       SET [letterOfCreditCode] = @letterOfCreditCode
                                     WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@letterOfCreditCode", letterOfCredit.LetterOfCreditCode);
                c.AddParam("@id", letterOfCredit.Id);
                c.ExecuteNonQuery();
            }

        }


    }
}