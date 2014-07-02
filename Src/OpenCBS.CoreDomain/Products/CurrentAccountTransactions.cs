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

//       CurrenTAccountProduct  table fields
//Interest_min
//Interest_max
//Interest_type(Rate will be fixed)
//Interest_value
//Interest_frequency
//Overdraft_limit
//public double InterestMin { get; set; }
//public double InterestMax { get; set; }
//public string InterestType { get; set; }
//public double InterestValue { get; set; }
//public int InterestFrequency { get; set; }
//public decimal OverdraftLimt { get; set; }

//double InterestMin { get; set; }
//double InterestMax { get; set; }
//string InterestType { get; set; }
//double InterestValue { get; set; }
//int InterestFrequency { get; set; }
//decimal OverdraftLimt { get; set; }

//[interest_min],
//[interest_max],
//[interest_type],
//[interest_value],
//[interest_frequency],
//[overdraft_limit],

//@interestMin,
//@interestMax,
//@interestType,
//@interestValue,
//@interestFrequency,
//@overdraftLimt,

//SetProduct()
//{
//c.AddParam("@interestMin ",currentAccountTransactionFees.InterestMin);
//c.AddParam("@interestMax ",currentAccountTransactionFees.InterestMax);
//c.AddParam("@interestType",currentAccountTransactionFees.InterestType);
//c.AddParam("@interestValue ",currentAccountTransactionFees.InterestValue);
//c.AddParam("@interestFrequency ",currentAccountTransactionFees.InterestFrequency);
//c.AddParam("@overdraftLimt ",currentAccountTransactionFees.OverdraftLimt);
//}

//GetProduct()
//{
//currentAccountTransactionFees.InterestMin = r.GetDouble(“interest_min”);
//currentAccountTransactionFees.InterestMax = r.GetDouble(“interest_max”);
//currentAccountTransactionFees.InterestType = r.GetString(“interest_type”);
//currentAccountTransactionFees.InterestValue = r.GetDouble(“interest_value”);
//currentAccountTransactionFees.InterestFrequency = r.GetInt(“interest_frequency”);
//currentAccountTransactionFees.OverdraftLimt = r.GetDecimal(“overdraft_limit”);

//}

    }
}
