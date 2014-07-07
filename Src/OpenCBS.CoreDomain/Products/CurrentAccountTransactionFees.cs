using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Products
{
    public class CurrentAccountTransactionFees
    {
        public int Id { get; set; }
        public int CurrentAccountProductId { get; set; }
        public string TransactionType { get; set; }
        public string TransactionFeesType { get; set; }
        public OCurrency TransactionFees { get; set; }
        public OCurrency TransactionFeeMin { get; set; }
        public OCurrency TransactionFeeMax { get; set; }
        public string TransactionMode { get; set; }
    }
}
