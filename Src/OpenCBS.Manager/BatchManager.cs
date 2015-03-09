using System;
using System.Collections.Generic;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Contracts.Loans;
using OpenCBS.CoreDomain.Events.Loan;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Manager.Products;

using Microsoft.Office.Interop.Word;
using OpenCBS.CoreDomain.Events;
using System.Windows.Forms;
using OpenCBS.Manager.Database;
using OpenCBS.Manager.Events;
using System.Data.SqlClient;
using OpenCBS.CoreDomain.Batch;

namespace OpenCBS.Manager
{
    public class BatchManager: Manager
    {
        private User _user = new User();
        string noticePath = "";
        int officeVersion = 0;
        string bankName = "";
        string bankRepresentative = "";
        ApplicationSettingsManager _applicationSettingsManager;
        EventManager _eventManager;
        CurrentAccountProductHoldingManager _currentAccountProductHoldingManager;

        public BatchManager(User pUser) : base(pUser)
        {
            _user = pUser;
            _applicationSettingsManager = new ApplicationSettingsManager(pUser);
            _eventManager = new EventManager(pUser);
            _currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(_user);
            noticePath = _applicationSettingsManager.SelectParameterValue("NOTICE_PATH").ToString();
            officeVersion = _applicationSettingsManager.GetOfficeVersion();
            bankName = _applicationSettingsManager.SelectParameterValue("BANK_NAME").ToString();
            bankRepresentative = _applicationSettingsManager.SelectParameterValue("BANK_REPRESENTATIVE").ToString();
        }

        public BatchManager(string testDB) : base(testDB) { }

        public int CheckIfBatchAlreadyExecutedForMonth(string contractCode, string batchName, DateTime calculationDate)
        {
            string month = calculationDate + "/" + calculationDate.Year;
            int result = 0;
            string q = "";
            if (batchName == "CurrentAccountInterestBatch")
            q = @"SELECT * FROM [BatchResults] WHERE [contractCode] = @contractCode AND [month] = @month AND [currentAccountInterestResult] = 1";
            if (batchName == "OverdraftInterestCalculationBatch")
            q = @"SELECT * FROM [BatchResults] WHERE [contractCode] = @contractCode AND [month] = @month AND [overdraftInterestResult] = 1";
            if (batchName == "OverdraftCommitmentFeeBatch")
            q = @"SELECT * FROM [BatchResults] WHERE [contractCode] = @contractCode AND [month] = @month AND [commitmentFeeResult] = 1";
            if (batchName == "AccountManagementFeeBatch")
            q = @"SELECT * FROM [BatchResults] WHERE [contractCode] = @contractCode AND [month] = @month AND [accountManagementFeeResult] = 1";
            if (batchName == "FixedOverdraftFeeBatch")
            q = @"SELECT * FROM [BatchResults] WHERE [contractCode] = @contractCode AND [month] = @month AND [OverdraftFeeResult] = 1";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@contractCode", contractCode);
                c.AddParam("@month", month);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) 
                        result = 0;

                    if (r.Read())
                        result = 1;
                }
            }

            return result;
        }

        public int UpdateBatchStatus(string contractCode, string batchName, DateTime calculationDate)
        {
            string month = calculationDate + "/" + calculationDate.Year;
               string q = @"SELECT * FROM [BatchResults] WHERE [contractCode] = @contractCode AND [month] = @month";

                using (SqlConnection conn = GetConnection())
                using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
                {
                    c.AddParam("@contractCode", contractCode);
                    c.AddParam("@month", month);

                    using (OpenCbsReader r = c.ExecuteReader())
                    {
                        if (r == null || r.Empty)
                        {
                            if (batchName == "CurrentAccountInterestBatch")
                                q = @"INSERT INTO [BatchResults] ([contractCode],[month],[currentAccountInterestResult],[overdraftInterestResult],[commitmentFeeResult]
                                ,[accountManagementFeeResult],[OverdraftFeeResult])VALUES(@contractCode,@month,1,0,0,0,0)SELECT SCOPE_IDENTITY()";
                            if (batchName == "OverdraftInterestCalculationBatch")
                                q = @"INSERT INTO [BatchResults] ([contractCode],[month],[currentAccountInterestResult],[overdraftInterestResult],[commitmentFeeResult]
                                ,[accountManagementFeeResult],[OverdraftFeeResult])VALUES(@contractCode,@month,0,1,0,0,0)SELECT SCOPE_IDENTITY()";
                            if (batchName == "OverdraftCommitmentFeeBatch")
                                q = @"INSERT INTO [BatchResults] ([contractCode],[month],[currentAccountInterestResult],[overdraftInterestResult],[commitmentFeeResult]
                                ,[accountManagementFeeResult],[OverdraftFeeResult])VALUES(@contractCode,@month,0,0,1,0,0)SELECT SCOPE_IDENTITY()";
                            if (batchName == "AccountManagementFeeBatch")
                                q = @"INSERT INTO [BatchResults] ([contractCode],[month],[currentAccountInterestResult],[overdraftInterestResult],[commitmentFeeResult]
                                ,[accountManagementFeeResult],[OverdraftFeeResult])VALUES(@contractCode,@month,0,0,0,1,0)SELECT SCOPE_IDENTITY()";
                            if (batchName == "FixedOverdraftFeeBatch")
                                q = @"INSERT INTO [BatchResults] ([contractCode],[month],[currentAccountInterestResult],[overdraftInterestResult],[commitmentFeeResult]
                                ,[accountManagementFeeResult],[OverdraftFeeResult])VALUES(@contractCode,@month,0,0,0,0,1)SELECT SCOPE_IDENTITY()";

                            
                        }

                        if (r.Read())
                        {
                            if (batchName == "CurrentAccountInterestBatch")
                                q = @"UPDATE [BatchResults] SET [currentAccountInterestResult] = 1  WHERE [contractCode] = @contractCode AND [month] = @month";
                            if (batchName == "OverdraftInterestCalculationBatch")
                                q = @"UPDATE [BatchResults] SET [overdraftInterestResult] = 1 WHERE [contractCode] = @contractCode AND [month] = @month";
                            if (batchName == "OverdraftCommitmentFeeBatch")
                                q = @"UPDATE [BatchResults] SET [commitmentFeeResult] = 1 WHERE [contractCode] = @contractCode AND [month] = @month";
                            if (batchName == "AccountManagementFeeBatch")
                                q = @"UPDATE [BatchResults] SET [accountManagementFeeResult] = 1 WHERE [contractCode] = @contractCode AND [month] = @month";
                            if (batchName == "FixedOverdraftFeeBatch")
                                q = @"UPDATE [BatchResults] SET [OverdraftFeeResult] = 1 WHERE [contractCode] = @contractCode AND [month] = @month";

                        }
                            
                    }
                }

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@contractCode", contractCode);
                c.AddParam("@month", month);
                return c.ExecuteNonQuery();
            }
        }


        public BatchResults FetchBatchResults(string contractCode, string monthYear)
        {
            const string q = @"SELECT * FROM [BatchResults] WHERE [contractCode] = @contractCode AND [month] = @monthYear";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@contractCode", contractCode);
                c.AddParam("@monthYear", monthYear);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (BatchResults)GetBatchResults(r);
                }
            }

        }

        public List<BatchResults> FetchBatchResults(string monthYear)
        {
            List<BatchResults> batchResultsList = new List<BatchResults>();
            const string q = @"SELECT * FROM [BatchResults] WHERE [month] = @monthYear";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@monthYear", monthYear);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    while (r.Read())
                    {
                        batchResultsList.Add((BatchResults)GetBatchResults(r));
                    }
                }
            }

            return batchResultsList;

        }

        private static BatchResults GetBatchResults(OpenCbsReader reader)
        {
            BatchResults batchResults = new BatchResults();

            batchResults.ContractCode = reader.GetString("ContractCode");
            batchResults.MonthYear = reader.GetString("month");
            batchResults.CurrentAccountInterestResult = reader.GetInt("currentAccountInterestResult");
            batchResults.OverdraftInterestResult = reader.GetInt("overdraftInterestResult");
            batchResults.CommitmentFeeResult = reader.GetInt("commitmentFeeResult");
            batchResults.AccountManagementFeeResult = reader.GetInt("accountManagementFeeResult");
            batchResults.FixedOverdraftFeeResult = reader.GetInt("OverdraftFeeResult");
            return batchResults;

        }

        //Monthly Batch
        public int CurrentAccountInterestBatch(DateTime calculationDate)
        {
            int result = 0;
            
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings =  _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "CurrentAccountInterestBatch", calculationDate) == 0)
                {
                    _currentAccountProductHoldingManager.CurrentAccountInterestCalculation(calculationDate, _currentAccountProductHoldings);
                    UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "CurrentAccountInterestBatch", calculationDate);
                }
            }
            return result;
        }

        //Monthly Batch
        public int OverdraftInterestCalculationBatch(DateTime calculationDate)
        {
            int result = 0;
           
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (_currentAccountProductHoldings.OverdraftApplied == 1)
                {
                    if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "OverdraftInterestCalculationBatch", calculationDate) == 0)
                    {
                        _currentAccountProductHoldingManager.CurrentAccountOverdraftInterestCalculation(calculationDate, _currentAccountProductHoldings);
                        UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "OverdraftInterestCalculationBatch", calculationDate);
                    }
                }
            }
            return result;
        }

        //Monthly Batch
        public int CommitmentFeesCalculationBatch(DateTime calculationDate)
        {
            int result = 0;

            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (_currentAccountProductHoldings.OverdraftApplied == 1)
                {
                    if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "OverdraftCommitmentFeeBatch", calculationDate) == 0)
                    {
                        _currentAccountProductHoldingManager.CurrentAccountCommitmentFeeCalculation(calculationDate, _currentAccountProductHoldings);
                        UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "OverdraftCommitmentFeeBatch", calculationDate);
                    }
                }
            }
            return result;
        }

        //Monthly Batch
        public int AccountDormantBatch(DateTime calculationDate)
        {
            int result = 0;

            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                
                    _currentAccountProductHoldingManager.GetDormantAccount(_currentAccountProductHoldings.CurrentAccountContractCode);
                    
                
            }
            return result;
        }

        //Monthly Batch
        public int CurrentAccountManagemntFeeBatch(DateTime calculationDate)
        {
            int result = 0;

            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "AccountManagementFeeBatch", calculationDate) == 0)
                {
                    _currentAccountProductHoldingManager.CalculateManagementFees(calculationDate, _currentAccountProductHoldings);
                    UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "AccountManagementFeeBatch", calculationDate);
                }
            }
            return result;
        }

        //Monthly Batch
        public int FixedOverdraftFeesBatch(DateTime calculationDate)
        {
            int result = 0;

            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (_currentAccountProductHoldings.OverdraftApplied == 1)
                {
                    if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "FixedOverdraftFeeBatch", calculationDate) == 0)
                    {
                        _currentAccountProductHoldingManager.CalculateFixedOverdraftFees(calculationDate, _currentAccountProductHoldings);
                        UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "FixedOverdraftFeeBatch", calculationDate);
                    }
                }

            }
            return result;
        }

        //Monthly Batch
        public int LoanStatementBatch()
        {
            int result = 0;

            
            
            return result;
        }

        //Monthly Batch
        public int CurrentAccountStatementBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int SavingAccountStatementBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int FixedDepositStatementBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int LoanChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int CurrentAccountChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int SavingAccountChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int FixedDepositChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }
    }
}
