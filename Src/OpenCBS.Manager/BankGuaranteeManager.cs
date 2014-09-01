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
    class BankGuaranteesManager : Manager
    {
        public BankGuaranteesManager(User pUser) : base(pUser) { 
        }

        public BankGuaranteesManager(string testDB) : base(testDB) { 
        }
       

        // Your definition is FetchBankGuarantee(string branch) but there is no branch field in the table. 
        private static BankGuarantees GetBankGuarantee(OpenCbsReader reader)
        {
            return new BankGuarantees
            {
                Id = reader.GetInt("id"),
                BankGuaranteeCode = reader.GetString("bankGuaranteeCode"),
                IssuingDate = reader.GetDateTime("issuingDate"),
                ExpiryDate = reader.GetDateTime("expiryDate"),
                ApplicantId = reader.GetString("applicantId"),
                BeneficiaryParty = reader.GetString("beneficiaryParty"),
                GuarnteeType = reader.GetString("guarnteeType"),
                FeePerPeriod = reader.GetMoney("feePerPeriod"),
                FeePeriod = reader.GetString("feePeriod"),
                InstrumentDetails = reader.GetString("instrumentDetails"),
                Value = reader.GetMoney("value"),
                Currency = reader.GetString("currency"),
                Status = reader.GetString("status"),

            };
        }

        private static void SetBankGuarantee(OpenCbsCommand c, BankGuarantees bankGuarantee)
        {
            c.AddParam("@bankGuaranteeCode", bankGuarantee.BankGuaranteeCode);
            c.AddParam("@issuingDate", bankGuarantee.IssuingDate);
            c.AddParam("@expiryDate", bankGuarantee.ExpiryDate);
            c.AddParam("@applicantId", bankGuarantee.ApplicantId);
            c.AddParam("@beneficiaryParty", bankGuarantee.BeneficiaryParty);
            c.AddParam("@guarnteeType", bankGuarantee.GuarnteeType);

            c.AddParam("@feePerPeriod", bankGuarantee.FeePerPeriod);
            c.AddParam("@feePeriod", bankGuarantee.FeePeriod);
            c.AddParam("@instrumentDetails", bankGuarantee.InstrumentDetails);
            c.AddParam("@value", bankGuarantee.Value);
            c.AddParam("@currency", bankGuarantee.Currency);
            c.AddParam("@status", bankGuarantee.Status);

        }

        public void UpdateBankGuarantee(BankGuarantees bankGuarantee)
        {
            const string q = @"UPDATE [Test].[dbo].[BankGuarantees]
               SET [bankGuaranteeCode] = @bankGuaranteeCode
                  ,[issuingDate] = @issuingDate
                  ,[expiryDate] = @expiryDate
                  ,[applicantId] = @applicantId
                  ,[beneficiaryParty] = @beneficiaryParty
                  ,[guarnteeType] = @guarnteeType
                  ,[feePerPeriod] = @feePerPeriod
                  ,[feePeriod] = @feePeriod
                  ,[instrumentDetails] = @instrumentDetails
                  ,[value] = @value
                  ,[currency] = @currency
                  ,[status] = @status
                                     WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetBankGuarantee(c, bankGuarantee);
                c.ExecuteNonQuery();
            }

        }

        public BankGuarantees FetchBankGuarantee(string bankGuaranteeCode)
        {
            const string q = @"SELECT * FROM [BankGuarantees] WHERE [bankGuaranteeCode] = @bankGuaranteeCode";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@bankGuaranteeCode", bankGuaranteeCode);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (BankGuarantees)GetBankGuarantee(r);
                }
            }

        }

        public BankGuarantees FetchAll()
        {
            const string q = @"SELECT * FROM [BankGuarantees]";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (BankGuarantees)GetBankGuarantee(r);
                }
            }

        }
        public int SaveBankGuarantee(BankGuarantees bankGuarantee)
        {

            const string q = @"INSERT INTO [Test].[dbo].[BankGuarantees]
           ([bankGuaranteeCode]
           ,[issuingDate]
           ,[expiryDate]
           ,[applicantId]
           ,[beneficiaryParty]
           ,[guarnteeType]
           ,[feePerPeriod]
           ,[feePeriod]
           ,[instrumentDetails]
           ,[value]
           ,[currency]
           ,[status])
        VALUES
                (@bankGuaranteeCode,
                @issuingDate,
                @expiryDate,
                @applicantId,
                @beneficiaryParty,
                @guarnteeType,
                @feePerPeriod,
                @feePeriod,
                @instrumentDetails,
                @value,
                @currency,
                @status
                )
                SELECT SCOPE_IDENTITY()";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetBankGuarantee(c, bankGuarantee);
                bankGuarantee.Id = Convert.ToInt32(c.ExecuteScalar());

            }
            return bankGuarantee.Id;
        }
    }
}