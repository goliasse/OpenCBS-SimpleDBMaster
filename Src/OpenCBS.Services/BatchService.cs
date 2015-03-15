using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Batch;
using OpenCBS.Manager;

namespace OpenCBS.Services
{
    public class BatchService : MarshalByRefObject
    {
        
            private readonly BatchManager _batchManager;
            private readonly User _user;

            public BatchService(User pUser)
            {
                _user = pUser;
                _batchManager = new BatchManager(pUser);
               
            }

            public BatchService(string pTestDb)
            {
                _batchManager = new BatchManager(pTestDb);
                
            }

            public int CurrentAccountInterestBatch(DateTime calculationDate, int batchId)
{
    return _batchManager.CurrentAccountInterestBatch(calculationDate,batchId);
}
            public int ODFeesBatch(DateTime calculationDate,int batchId)
{
    return _batchManager.OverdraftInterestCalculationBatch(calculationDate, batchId);
}
            public int CommitmentFeesBatch(DateTime calculationDate,int batchId)
    {
        return _batchManager.CommitmentFeesCalculationBatch(calculationDate, batchId);
}
            public int AccountDormantBatch(DateTime calculationDate, int batchId)
    {
        return _batchManager.AccountDormantBatch(calculationDate, batchId);
}
            public int CurrentAccountManagemntFeeBatch(DateTime calculationDate, int batchId)
    {
        return _batchManager.CurrentAccountManagemntFeeBatch(calculationDate, batchId);
}
            public int FixedOverdraftFeesBatch(DateTime calculationDate, int batchId)
            {
                return _batchManager.FixedOverdraftFeesBatch(calculationDate, batchId);
            }

public int LoanStatementBatch()
    {
        return _batchManager.LoanStatementBatch();
}
public int CurrentAccountStatementBatch()
    {
        return _batchManager.CurrentAccountStatementBatch();
}
public int SavingAccountStatementBatch()
    {
        return _batchManager.SavingAccountStatementBatch();
}
public int FixedDepositStatementBatch()
    {
        return _batchManager.FixedDepositStatementBatch();
}
public int LoanChargesNoticeBatch()
    {
        return _batchManager.LoanChargesNoticeBatch();
}
public int CurrentAccountChargesNoticeBatch()
    {
        return _batchManager.CurrentAccountChargesNoticeBatch();
}
public int SavingAccountChargesNoticeBatch()
    {
        return _batchManager.SavingAccountChargesNoticeBatch();
}
public int FixedDepositChargesNoticeBatch()
{
    return _batchManager.FixedDepositChargesNoticeBatch();
}


public List<BatchResults> FetchBatchResults(string monthYear)
{
    return _batchManager.FetchBatchResults(monthYear);
}

public BatchResults FetchBatchResults(string contractCode, string monthYear)
{
    return _batchManager.FetchBatchResults(contractCode, monthYear);
}

public int ScheduleABatch(ScheduledBatch scheduledBatches)
{
    return _batchManager.ScheduleABatch(scheduledBatches);
}


public void UpdateScheduledBatches(int batchId, int batchResult, int noOfRuns)
{
    _batchManager.UpdateScheduledBatches(batchId, batchResult, noOfRuns);
}
 
public ScheduledBatch FetchScheduledBatches(int id)
{
    return _batchManager.FetchScheduledBatches(id);
}
public List<ScheduledBatch> FetchAllScheduledBatches()
{
    return _batchManager.FetchAllScheduledBatches();
}

public List<ScheduledBatch> FetchAllScheduledBatches(DateTime scheduleBatchDate)
{
    return _batchManager.FetchAllScheduledBatches(scheduleBatchDate);
}
    }
}
