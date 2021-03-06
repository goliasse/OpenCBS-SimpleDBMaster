﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;


namespace OpenCBS.CoreDomain.Products
{
    public class FixedDepositProductHoldings : IProductHolding
    {
        
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientType { get; set; }
        public string FixedDepositContractCode { get; set; }

        public IFixedDepositProduct FixedDepositProduct { get; set; }
        public OCurrency InitialAmount { get; set; }
        public double? InterestRate { get; set; }
        public int? MaturityPeriod { get; set; }
        public string InterestCalculationFrequency { get; set; }
        public string PenalityType { get; set; }
        public double? Penality { get; set; }
        public string OpeningAccountingOfficer { get; set; }
        public string ClosingAccountingOfficer { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Status { get; set; }
        public int? PreMatured { get; set; }
        public string Comment { get; set; }

        public double? EffectiveInterestRate { get; set; }
        public double? EffectiveDepositPeriod { get; set; }
        public OCurrency FinalAmount { get; set; }
        public OCurrency FinalInterest { get; set; }
        public double? FinalPenality { get; set; }
        public string InitialAmountPaymentMethod { get; set; }
        public string InitialAmountChequeAccount { get; set; }
        public string FinalAmountPaymentMethod { get; set; }

        public string FinalAmountChequeAccount { get; set; }
        public string FirstName { get; set; }
    }
}
