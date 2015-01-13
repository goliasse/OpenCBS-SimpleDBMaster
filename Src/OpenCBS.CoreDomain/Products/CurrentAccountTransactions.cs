using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Products
{
   public class CurrentAccountTransactions
    {
        public int Id { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public OCurrency Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionMode { get; set; }
        public string TransactionType { get; set; }
        public OCurrency TransactionFees { get; set; }
        public string Maker { get; set; }
        public string Checker { get; set; }
        public string PurposeOfTransfer { get; set; }
        public OCurrency FromBalance { get; set; }
        public OCurrency ToBalance { get; set; }
        public CurrentAccountProductHoldings toCAAccount { get; set; }
        public CurrentAccountProductHoldings fromCAAccount { get; set; }
        public FixedDepositProductHoldings toFDAccount { get; set; }
        public FixedDepositProductHoldings fromFDAccount { get; set; }


    }
}
