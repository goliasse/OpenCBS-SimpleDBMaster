using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OpenCBS.CoreDomain.Products
{
    public class FixedDepositProductHoldings
    {
        
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientType { get; set; }
        public string FixedDepositContractCode { get; set; }
        public int FixedDepositProductId { get; set; }
        public double InitialAmount { get; set; }
        public double InterestRate { get; set; }
        public int MaturityPeriod { get; set; }
        public string InterestCalculationFrequency { get; set; }
        public string PenalityType { get; set; }
        public double Penality { get; set; }
        public string OpeningAccountingOfficer { get; set; }
        public string ClosingAccountingOfficer { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Status { get; set; }
        public int PreMatured { get; set; }
        public string Comment { get; set; }
        public double EffectiveInterestRate { get; set; }
        public double EffectiveDepositPeriod { get; set; }
        public double FinalAmount { get; set; }
        public double finalInterest { get; set; }
        public double FinalPenality { get; set; }
        public string InitialAmountPaymentMethod { get; set; }
        public string FinalAmountPaymentMethod { get; set; }
    }
}
