using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
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

public int CurrentAccountInterestBatch()
{
    return _batchManager.CurrentAccountInterestBatch();
}
public int ODFeesBatch()
{
    return _batchManager.ODFeesBatch();
}
public int CommitmentFeesBatch()
    {
        return _batchManager.CommitmentFeesBatch();
}
public int AccountDormantBatch()
    {
        return _batchManager.AccountDormantBatch();
}
public int CurrentAccountManagemntFeeBatch()
    {
        return _batchManager.CurrentAccountManagemntFeeBatch();
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



        
    }
}
