using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Accounting
{
    public class COATransaction
    {
      
      public int Id { get; set; }
      public string DebitAccount { get; set; }
      public OCurrency Amount { get; set; }
      public DateTime TransactionDate { get; set; }
      public string Description { get; set; }
      public string CreditAccount { get; set; }
      public string Currency { get; set; }
      public string Branch { get; set; }
      public string EventCode { get; set; }

    }
}
