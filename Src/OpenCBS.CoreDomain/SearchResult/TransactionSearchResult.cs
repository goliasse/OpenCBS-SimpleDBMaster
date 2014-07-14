using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.SearchResult
{
    public class TransactionSearchResult
    {
        public string Account { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
    }
}
