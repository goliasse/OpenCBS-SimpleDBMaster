using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Shared;
using OpenCBS.ma

namespace OpenCBS.CoreDomain
{
    public class CounterBalance
    {
        public int Id { get; set; }
        public int AllocaterId { get; set; }
        public string Branch { get; set; }
        public int CashierId { get; set; }
        public int CounterId { get; set; }
        public DateTime AllocationDate { get; set; }
        public OCurrency Amount { get; set; }
        public string Type { get; set; }
    }
}