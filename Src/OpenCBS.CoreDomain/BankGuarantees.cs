using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain
{
    public class BankGuarantees
    {

        public int Id { get; set; }
        public string BankGuaranteeCode { get; set; }
        public string Branch { get; set; }
        public DateTime IssuingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ApplicantId { get; set; }
        public string BeneficiaryParty { get; set; }
        public string GuarnteeType { get; set; }
        public OCurrency FeePerPeriod { get; set; }
        public string FeePeriod { get; set; }
        public string InstrumentDetails { get; set; }
        public OCurrency Value { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string FeeTransactionNumber { get; set; }
        public OCurrency TotalFee { get; set; }
    }
}
