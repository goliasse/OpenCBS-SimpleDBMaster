using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;

namespace OpenCBS.Manager
{
    public class BatchManager: Manager
    {
        private User _user = new User();

        public BatchManager(User pUser) : base(pUser)
        {
            _user = pUser;
        }

        public BatchManager(string testDB) : base(testDB) { }

        public int CurrentAccountInterestBatch()
        {
            int result = 0;
            return result;
        }
        public int ODFeesBatch()
        {
            int result = 0;
            return result;
        }
        public int CommitmentFeesBatch()
        {
            int result = 0;
            return result;
        }
        public int AccountDormantBatch()
        {
            int result = 0;
            return result;
        }
        public int CurrentAccountManagemntFeeBatch()
        {
            int result = 0;
            return result;
        }
        public int LoanStatementBatch()
        {
            int result = 0;
            return result;
        }
        public int CurrentAccountStatementBatch()
        {
            int result = 0;
            return result;
        }
        public int SavingAccountStatementBatch()
        {
            int result = 0;
            return result;
        }
        public int FixedDepositStatementBatch()
        {
            int result = 0;
            return result;
        }
        public int LoanChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }
        public int CurrentAccountChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }
        public int SavingAccountChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }
        public int FixedDepositChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }
    }
}
