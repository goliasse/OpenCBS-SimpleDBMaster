using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Batch
{
    public class BatchResults
    {
        public string ContractCode { get; set; }
        public string MonthYear { get; set; }
        public int CurrentAccountInterestResult { get; set; }
        public int OverdraftInterestResult { get; set; }
        public int CommitmentFeeResult { get; set; }
        public int AccountManagementFeeResult { get; set; }
        public int FixedOverdraftFeeResult { get; set; }
        public int BatchId { get; set; }

    }
}
