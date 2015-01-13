using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Accounting
{
 public class Income
    {
        public int Id { get; set; }
        public string IncomeCategory { get; set; }
        public string IncomeDescription { get; set; }
        public string Reference { get; set; }
        public DateTime IncomeDate { get; set; }
        public OCurrency IncomeAmount { get; set; }
        public string Currency { get; set; }
        public string Branch { get; set; }

    }
}
