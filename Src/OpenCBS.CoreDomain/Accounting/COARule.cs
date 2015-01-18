using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Accounting
{
    public class COARule
    {
        public int Id { get; set; }
        public string EventType { get; set; }
        public string Currency { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public string Branch { get; set; }

    }
}
