using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Products
{
    public class FixedDepositInterest
    {
        

        public double? EffectiveInterestRate { get; set; }
        public double? EffectiveDepositPeriod { get; set; }
        public OCurrency InitialAmount { get; set; }
        public OCurrency FinalInterest { get; set; }
        public string PenaltyType { get; set; }
        public double? Penalty { get; set; }
        public OCurrency FinalAmount { get; set; }
        public int? PreMatured { get; set; }

    }
}
