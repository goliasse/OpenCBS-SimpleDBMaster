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
        public DateTime IssuingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ApplicantId { get; set; }
        public string BeneficiaryParty { get; set; }
        public string GuarnteeType { get; set; }
        double? FeePerPeriod { get; set; }
        public string FeePeriod { get; set; }
        public string InstrumentDetails { get; set; }
        public OCurrency Value { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
    }
}
