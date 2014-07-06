using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Products
{
   public class CurrentAccountTransactions
    {
        public int Id { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionMode { get; set; }
        public string TransactionType { get; set; }
        public decimal TransactionFees { get; set; }
        public string Maker { get; set; }
        public string Checker { get; set; }
        public string PurposeOfTransfer { get; set; }



    }
}
