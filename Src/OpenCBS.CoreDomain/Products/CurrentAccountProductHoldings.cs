using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Products
{
    public class CurrentAccountProductHoldings : IProductHolding
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientType { get; set; }
        public string CurrentAccountContractCode { get; set; }
        public CurrentAccountProduct CurrentAccountProduct { get; set; }
        public OCurrency InitialAmount { get; set; }
        public OCurrency Balance { get; set; }
        public OCurrency OverdraftLimit { get; set; }
        public double? InterestRate { get; set; }
        public int? InterestCalculationFrequency { get; set; }
      
        public string OpeningAccountingOfficer { get; set; }
        public string ClosingAccountingOfficer { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Status { get; set; }
      
        public string Comment { get; set; }
      
        public OCurrency EntryFees { get; set; }
        public OCurrency ReopenFees { get; set; }
        public OCurrency ClosingFees { get; set; }
        public OCurrency ManagementFees { get; set; }
        public OCurrency OverdraftFees { get; set; }

        public string EntryFeesType { get; set; }
        public string ReopenFeesType { get; set; }
        public string ClosingFeesType { get; set; }
        public string ManagementFeesType { get; set; }
        public string OverdraftFeesType { get; set; }

        public string ManagementFeesFrequency { get; set; }
        public string InitialAmountPaymentMethod { get; set; }
        public string InitialAmountAccountNumber { get; set; }
        public string FirstName { get; set; }

        public string FinalAmountPaymentMethod { get; set; }
        public string FinalAmountAccountNumber { get; set; }

        public double? OverdraftInterest { get; set; }
        public string OverdraftInterestType { get; set; }
        public string OverdraftCommitmentFeeType { get; set; }
        public double? OverdraftCommitmentFee { get; set; }
        public int? OverdraftApplied { get; set; }
        public DateTime OverdraftAppliedDate { get; set; }

        public OCurrency AllotedOverdraftLimit { get; set; }
    }
}
