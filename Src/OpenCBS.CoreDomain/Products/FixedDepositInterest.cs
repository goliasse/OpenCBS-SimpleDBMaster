using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Products
{
    public class FixedDepositInterest
    {
        

        public double EffectiveInterestRate { get; set; }
        public double EffectiveDepositPeriod { get; set; }
        public decimal InitialAmount { get; set; }
        public decimal FinalInterest { get; set; }
        public string PenaltyType { get; set; }
        public double Penalty { get; set; }
        public decimal FinalAmount { get; set; }
        public int PreMatured { get; set; }

    }
}
