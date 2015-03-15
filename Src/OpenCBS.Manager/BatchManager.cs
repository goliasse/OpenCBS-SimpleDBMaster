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
using System.IO;

namespace OpenCBS.Manager
{
    public class BatchManager: Manager
    {
        User _user = new User();
        string noticePath = "";
        int officeVersion = 0;
        string bankName = "";
        string bankRepresentative = "";
        string logFilePath = "";
        ApplicationSettingsManager _applicationSettingsManager;
        EventManager _eventManager;
        CurrentAccountProductHoldingManager _currentAccountProductHoldingManager;
        public static StreamWriter LogWriter = null;

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
            logFilePath = _applicationSettingsManager.SelectParameterValue("BATCH_LOG_FILE_PATH").ToString();
        }

        public BatchManager(string testDB) : base(testDB) { }

        public int ScheduleABatch(ScheduledBatch scheduledBatches)
        {
            ScheduledBatch scheduledBatch = FetchScheduledBatches(scheduledBatches.BatchName, scheduledBatches.ScheduledDate);
            if (scheduledBatch == null)
            {
                const string q = @"INSERT INTO [ScheduledBatches]
           ([batchName]
           ,[scheduledDate]
           ,[batchResult]
           ,[batchuser]
           ,[logFilePath]
           ,[noOfRuns]
           ,[batchMode])
     
             VALUES(@batchName, 
                    @scheduledDate,
                    @batchResult,
                    @user, 
                    @logFilePath, 
                    @noOfRuns,
                    @batchMode
                    )
                    SELECT SCOPE_IDENTITY()";

                using (SqlConnection conn = GetConnection())
                using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
                {
                    SetScheduledBatch(c, scheduledBatches);
                    int id = Convert.ToInt32(c.ExecuteScalar());
                    UpdateScheduledBatches(id, logFilePath + id + ".txt");
                    return id;
                }
            }
            else
                return -1;
        }

        private static ScheduledBatch GetScheduledBatch(OpenCbsReader reader)
        {
            ScheduledBatch scheduledBatches = new ScheduledBatch();

            scheduledBatches.Id = reader.GetInt("id");
            scheduledBatches.BatchName = reader.GetString("batchName");
            scheduledBatches.ScheduledDate = reader.GetDateTime("scheduledDate");
            scheduledBatches.BatchResult = reader.GetInt("batchResult");
            scheduledBatches.User = reader.GetString("batchUser");
            scheduledBatches.LogFilePath = reader.GetString("logFilePath");
            scheduledBatches.NoOfRuns = reader.GetInt("noOfRuns");
            scheduledBatches.BatchMode = reader.GetString("batchMode").Trim();
            return scheduledBatches;

        }

        private static void SetScheduledBatch(OpenCbsCommand c, ScheduledBatch scheduledBatches)
        {
            c.AddParam("@batchName", scheduledBatches.BatchName);
            c.AddParam("@scheduledDate", scheduledBatches.ScheduledDate);
            c.AddParam("@batchResult", scheduledBatches.BatchResult);
            c.AddParam("@user", User.CurrentUser.UserName);
            c.AddParam("@logFilePath", scheduledBatches.LogFilePath);
            c.AddParam("@noOfRuns", scheduledBatches.NoOfRuns);
            c.AddParam("@batchMode", scheduledBatches.BatchMode);
        }

        public void UpdateScheduledBatches(int batchId, string logFilePath)
        {
            const string q = @"UPDATE [dbo].[ScheduledBatches]
               SET [logFilePath] = @logFilePath
                        WHERE id = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@logFilePath", logFilePath);
                c.AddParam("@id", batchId);
                c.ExecuteNonQuery();
            }

        }

        public void UpdateScheduledBatches(int batchId, int batchResult, int noOfRuns)
        {
            const string q = @"UPDATE [dbo].[ScheduledBatches]
               SET [batchResult] = @batchResult
                  ,[noOfRuns] = @noOfRuns
                        WHERE id = @id";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@batchResult", batchResult);
                c.AddParam("@noOfRuns", noOfRuns);
                c.AddParam("@id", batchId);
                c.ExecuteNonQuery();
            }

        }

        public ScheduledBatch FetchScheduledBatches(string batchName, DateTime scheduledDate)
        {
            const string q = @"SELECT * FROM [ScheduledBatches] WHERE [batchName] = @batchName AND [scheduledDate] = @scheduledDate";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@batchName", batchName);
                c.AddParam("@scheduledDate", scheduledDate);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (ScheduledBatch)GetScheduledBatch(r);
                }
            }

        }

        public ScheduledBatch FetchScheduledBatches(int id)
        {
            const string q = @"SELECT * FROM [ScheduledBatches] WHERE [id] = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@id", id);

                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    r.Read();
                    return (ScheduledBatch)GetScheduledBatch(r);
                }
            }

        }

        public List<ScheduledBatch> FetchAllScheduledBatches()
        {
            List<ScheduledBatch> scheduledBatchList = new List<ScheduledBatch>();
            const string q = @"SELECT * FROM [ScheduledBatches]";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return null;

                    while(r.Read())
                    {
                        scheduledBatchList.Add((ScheduledBatch)GetScheduledBatch(r));
                    }
                    
                }
            }
            return scheduledBatchList;

        }

        public List<ScheduledBatch> FetchAllScheduledBatches(DateTime scheduleBatchDate)
        {
            List<ScheduledBatch> scheduledBatchList = new List<ScheduledBatch>();
            const string q = @"SELECT * FROM [ScheduledBatches] WHERE [scheduledDate] = @scheduledDate";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@scheduledDate", scheduleBatchDate);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    
                    if (r == null || r.Empty) return null;

                    while (r.Read())
                    {
                        scheduledBatchList.Add((ScheduledBatch)GetScheduledBatch(r));
                    }

                }
            }
            return scheduledBatchList;

        }

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
            string month = calculationDate.Month + "/" + calculationDate.Year;
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
        public int CurrentAccountInterestBatch(DateTime calculationDate,int batchId)
        {
            int result = 1;
            OpenLog(batchId);
                List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
                foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
                {
                    if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "CurrentAccountInterestBatch", calculationDate) == 0)
                    {
                        try
                        {
                            _currentAccountProductHoldingManager.CurrentAccountInterestCalculation(calculationDate, _currentAccountProductHoldings);
                            UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "CurrentAccountInterestBatch", calculationDate);
                        }
                        catch(Exception e)
                        {
                            result = 0;
                            string msg = "Batch Id: " + batchId + LogWriter.NewLine + "Batch Date: " + calculationDate + LogWriter.NewLine + "Contract Code: " + _currentAccountProductHoldings.CurrentAccountContractCode + LogWriter.NewLine + "Exception Message:" + e.ToString() + LogWriter.NewLine + "Stack Trace:" + e.StackTrace + LogWriter.NewLine +LogWriter.NewLine ;
                            LogWriter.WriteLine(msg);
                        }
                    }
                }
                LogWriter.Close();
            return result;
        }

        //Monthly Batch
        public int OverdraftInterestCalculationBatch(DateTime calculationDate, int batchId)
        {
            int result = 1;
            OpenLog(batchId);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (_currentAccountProductHoldings.OverdraftApplied == 1)
                {
                    if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "OverdraftInterestCalculationBatch", calculationDate) == 0)
                    {
                          try
                        {
                        _currentAccountProductHoldingManager.CurrentAccountOverdraftInterestCalculation(calculationDate, _currentAccountProductHoldings);
                        UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "OverdraftInterestCalculationBatch", calculationDate);
                        }
                        catch(Exception e)
                        {
                            result = 0;
                            string msg = "Batch Id: " + batchId + LogWriter.NewLine + "Batch Date: " + calculationDate + LogWriter.NewLine + "Contract Code: " + _currentAccountProductHoldings.CurrentAccountContractCode + LogWriter.NewLine + "Exception Message:" + e.ToString() + LogWriter.NewLine + "Stack Trace:" + e.StackTrace + LogWriter.NewLine + LogWriter.NewLine;
                            LogWriter.WriteLine(msg);
                        }
                    }
                }
            }
            LogWriter.Close();
            return result;
        }

        //Monthly Batch
        public int CommitmentFeesCalculationBatch(DateTime calculationDate, int batchId)
        {
            int result = 1;
            OpenLog(batchId);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (_currentAccountProductHoldings.OverdraftApplied == 1)
                {
                    if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "OverdraftCommitmentFeeBatch", calculationDate) == 0)
                    {  
                        try
                        {
                        _currentAccountProductHoldingManager.CurrentAccountCommitmentFeeCalculation(calculationDate, _currentAccountProductHoldings);
                        UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "OverdraftCommitmentFeeBatch", calculationDate);
                        }
                        catch(Exception e)
                        {
                            result = 0;
                            string msg = "Batch Id: " + batchId + LogWriter.NewLine + "Batch Date: " + calculationDate + LogWriter.NewLine + "Contract Code: " + _currentAccountProductHoldings.CurrentAccountContractCode + LogWriter.NewLine + "Exception Message:" + e.ToString() + LogWriter.NewLine + "Stack Trace:" + e.StackTrace + LogWriter.NewLine + LogWriter.NewLine;
                            LogWriter.WriteLine(msg);
                        }
                    }
                }
            }
            LogWriter.Close();
            return result;
        }

        //Monthly Batch
        public int AccountDormantBatch(DateTime calculationDate, int batchId)
        {
            int result = 1;
            OpenLog(batchId);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
               try
                        {   
                    _currentAccountProductHoldingManager.GetDormantAccount(_currentAccountProductHoldings.CurrentAccountContractCode);
                    }
                        catch(Exception e)
                        {
                            result = 0;
                            string msg = "Batch Id: " + batchId + LogWriter.NewLine + "Batch Date: " + calculationDate + LogWriter.NewLine + "Contract Code: " + _currentAccountProductHoldings.CurrentAccountContractCode + LogWriter.NewLine + "Exception Message:" + e.ToString() + LogWriter.NewLine + "Stack Trace:" + e.StackTrace + LogWriter.NewLine + LogWriter.NewLine;
                            LogWriter.WriteLine(msg);
                        }
                
            }
            LogWriter.Close();
            return result;
        }

        //Monthly Batch
        public int CurrentAccountManagemntFeeBatch(DateTime calculationDate, int batchId)
        {
            int result = 1;
            OpenLog(batchId);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "AccountManagementFeeBatch", calculationDate) == 0)
                {
                      try
                        {
                    _currentAccountProductHoldingManager.CalculateManagementFees(calculationDate, _currentAccountProductHoldings);
                    UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "AccountManagementFeeBatch", calculationDate);
                        }
                        catch(Exception e)
                        {
                            result = 0;
                            string msg = "Batch Id: " + batchId + LogWriter.NewLine + "Batch Date: " + calculationDate + LogWriter.NewLine + "Contract Code: " + _currentAccountProductHoldings.CurrentAccountContractCode + LogWriter.NewLine + "Exception Message:" + e.ToString() + LogWriter.NewLine + "Stack Trace:" + e.StackTrace + LogWriter.NewLine + LogWriter.NewLine;
                            LogWriter.WriteLine(msg);
                        }
                }
            }
            LogWriter.Close();
            return result;
        }

        //Monthly Batch
        public int FixedOverdraftFeesBatch(DateTime calculationDate, int batchId)
        {
            int result = 1;
            OpenLog(batchId);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (_currentAccountProductHoldings.OverdraftApplied == 1)
                {
                    if (CheckIfBatchAlreadyExecutedForMonth(_currentAccountProductHoldings.CurrentAccountContractCode, "FixedOverdraftFeeBatch", calculationDate) == 0)
                    {
                        try
                        {
                        _currentAccountProductHoldingManager.CalculateFixedOverdraftFees(calculationDate, _currentAccountProductHoldings);
                        UpdateBatchStatus(_currentAccountProductHoldings.CurrentAccountContractCode, "FixedOverdraftFeeBatch", calculationDate);
                        }
                        catch(Exception e)
                        {
                            result = 0;
                            string msg = "Batch Id: " + batchId + LogWriter.NewLine + "Batch Date: " + calculationDate + LogWriter.NewLine + "Contract Code: " + _currentAccountProductHoldings.CurrentAccountContractCode + LogWriter.NewLine + "Exception Message:" + e.ToString() + LogWriter.NewLine + "Stack Trace:" + e.StackTrace + LogWriter.NewLine + LogWriter.NewLine;
                            LogWriter.WriteLine(msg);
                            
                        }
                    }
                }

            }
            LogWriter.Close();
            return result;
        }


       private void OpenLog(int batchId)
        {
            // Create log folder if it doesn't exist
            DirectoryInfo logFolder = new DirectoryInfo(logFilePath);

            if (!logFolder.Exists)
                logFolder.Create();

            // Create new log file
            string filePath = Path.Combine(logFilePath, batchId+".txt");

             if (!File.Exists(filePath))
            {
                LogWriter = File.CreateText(filePath);
                
            }
            else
            {
                LogWriter = File.AppendText(filePath);
            }
        }

        static private void CloseLog()
        {
            LogWriter.Close();
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
