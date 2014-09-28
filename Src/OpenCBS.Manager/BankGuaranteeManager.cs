using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Manager.Currencies;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain.Events.Products;
using OpenCBS.Manager.Events;
using OpenCBS.Shared;

namespace OpenCBS.Manager
{
    public class BankGuaranteesManager : Manager
    {
        CurrentAccountTransactionManager currentAccountTransactionManager = null;
        CurrentAccountEventManager currentAccountEventManager = null;
        public BankGuaranteesManager(User pUser) : base(pUser) {
            currentAccountTransactionManager = new CurrentAccountTransactionManager(pUser);
            currentAccountEventManager = new CurrentAccountEventManager(pUser);
        }

        public BankGuaranteesManager(string testDB) : base(testDB) {
            currentAccountTransactionManager = new CurrentAccountTransactionManager(testDB);
            currentAccountEventManager = new CurrentAccountEventManager(testDB);
        }
       

        
        private static BankGuarantees GetBankGuarantee(OpenCbsReader reader)
        {
            BankGuarantees bankGuarantees = new BankGuarantees();

            bankGuarantees.Id = reader.GetInt("id");
            bankGuarantees.BankGuaranteeCode = reader.GetString("bankGuaranteeCode");
            bankGuarantees.IssuingDate = reader.GetDateTime("issuingDate");
            bankGuarantees.ExpiryDate = reader.GetDateTime("expiryDate");
            bankGuarantees.ApplicantId = reader.GetInt("applicantId");
            bankGuarantees.BeneficiaryParty = reader.GetString("beneficiaryParty");
            bankGuarantees.GuarnteeType = reader.GetString("guarnteeType");
            bankGuarantees.FeePerPeriod = reader.GetMoney("feePerPeriod");
            bankGuarantees.FeePeriod = reader.GetString("feePeriod");
            bankGuarantees.InstrumentDetails = reader.GetString("instrumentDetails");
            bankGuarantees.Value = reader.GetMoney("value");
            bankGuarantees.Currency = reader.GetString("currency");
            bankGuarantees.Status = reader.GetString("status");
            bankGuarantees.Branch = reader.GetString("branch");
            bankGuarantees.FeeTransactionNumber = reader.GetString("feeTransactionNumber");

                return bankGuarantees;
            
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
            c.AddParam("@branch", bankGuarantee.Branch);
            c.AddParam("@feeTransactionNumber", bankGuarantee.FeeTransactionNumber);
            

        }


        public void UpdateBankGuaranteeCode(BankGuarantees bankGuarantee)
        {
            const string q = @"UPDATE [Test].[dbo].[BankGuarantees]
               SET [bankGuaranteeCode] = @bankGuaranteeCode
                  WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@bankGuaranteeCode", bankGuarantee.BankGuaranteeCode);
                c.AddParam("@id", bankGuarantee.Id);
                
                c.ExecuteNonQuery();
            }

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
                  ,[branch] = @branch
                                     WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetBankGuarantee(c, bankGuarantee);
                c.AddParam("@id", bankGuarantee.Id);
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

        public List<BankGuarantees> FetchBranchAllBankGuarantee(int clientID)
        {
            List<BankGuarantees> listBankGuarantees = new List<BankGuarantees>();
            const string q = @"SELECT * FROM [BankGuarantees] WHERE applicantId = @clientId";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@clientId", clientID);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    
                    if (r == null || r.Empty) return new List<BankGuarantees>();

                    while (r.Read())
                    {
                        listBankGuarantees.Add((BankGuarantees)GetBankGuarantee(r));
                    }
                    return listBankGuarantees;
                }
            }

        }


        public string SaveBankGuarantee(BankGuarantees bankGuarantee)
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
           ,[status]
           ,[branch]
           ,[feeTransactionNumber]
            )
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
                @status,
                @branch,
                @feeTransactionNumber
                )
                SELECT SCOPE_IDENTITY()";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                SetBankGuarantee(c, bankGuarantee);
                bankGuarantee.Id = Convert.ToInt32(c.ExecuteScalar());
                bankGuarantee.BankGuaranteeCode = bankGuarantee.Branch + "/BG/" + bankGuarantee.Id;
                UpdateBankGuaranteeCode(bankGuarantee);
                MakeBankGuaranteeFeeTransaction(bankGuarantee);

            }
            return bankGuarantee.Branch + "/BG/" + bankGuarantee.Id;
        }

        public string GetChartOfAccountNumber(string COA)
        {
            string ret = "";
            using (SqlConnection conn = GetConnection())
            {
                using (OpenCbsCommand command = new OpenCbsCommand("GetChartOfAccounts", conn).AsStoredProcedure())
                {

                    command.AddParam("@name", COA);


                    ret = Convert.ToString(command.ExecuteScalar());

                }
            }

            return ret;
        }

        private OCurrency MakeBankGuaranteeFeeTransaction(BankGuarantees bankGuarantee)
        {

            CurrentAccountTransactions feeTransaction = new CurrentAccountTransactions();
          
                feeTransaction.Amount = bankGuarantee.TotalFee;


                feeTransaction.Checker = "Fees";
                feeTransaction.FromAccount = bankGuarantee.FeeTransactionNumber;
                feeTransaction.Maker = "Fees";
                feeTransaction.PurposeOfTransfer = "Bank Guarantee fee paid for " + bankGuarantee.BankGuaranteeCode;
                feeTransaction.ToAccount = GetChartOfAccountNumber("ProfitAndLossIncome");
                feeTransaction.TransactionDate = DateTime.Today;
                feeTransaction.TransactionFees = -1;
                feeTransaction.TransactionMode = "Debit";
                feeTransaction.TransactionType = "Fee";
                int ret = currentAccountTransactionManager.DebitFeeTransaction(feeTransaction);
                if (ret > 0)
                {
                    CurrentAccountEvent currentAccountEvent = new CurrentAccountEvent();
                    currentAccountEvent.ContractCode = bankGuarantee.FeeTransactionNumber;
                    currentAccountEvent.EventCode = "TRFT";
                    currentAccountEvent.Description = "Bank Guarantee Fee debit transaction #" + ret;
                    currentAccountEventManager.SaveCurrentAccountEvent(currentAccountEvent);
                }

            return bankGuarantee.TotalFee.Value;
            }



            

        }
            
    }