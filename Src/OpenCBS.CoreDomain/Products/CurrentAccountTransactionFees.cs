using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Products
{
    public class CurrentAccountTransactionFees
    {
        public int Id { get; set; }
        public int CurrentAccountProductId { get; set; }
        public string TransactionType { get; set; }
        public string TransactionFeesType { get; set; }
        public decimal TransactionFees { get; set; }
        public decimal TransactionFeeMin { get; set; }
        public decimal TransactionFeeMax { get; set; }
        public string TransactionMode { get; set; }
    }
}
