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

            public int CurrentAccountInterestBatch(DateTime calculationDate)
{
    return _batchManager.CurrentAccountInterestBatch(calculationDate);
}
            public int ODFeesBatch(DateTime calculationDate)
{
    return _batchManager.OverdraftInterestCalculationBatch(calculationDate);
}
            public int CommitmentFeesBatch(DateTime calculationDate)
    {
        return _batchManager.CommitmentFeesCalculationBatch(calculationDate);
}
            public int AccountDormantBatch(DateTime calculationDate)
    {
        return _batchManager.AccountDormantBatch(calculationDate);
}
            public int CurrentAccountManagemntFeeBatch(DateTime calculationDate)
    {
        return _batchManager.CurrentAccountManagemntFeeBatch(calculationDate);
}
            public int FixedOverdraftFeesBatch(DateTime calculationDate)
            {
                return _batchManager.FixedOverdraftFeesBatch(calculationDate);
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


        
    }
}
