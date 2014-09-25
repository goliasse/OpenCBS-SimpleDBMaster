﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain
{
    public class LetterOfCredit
    {

        public int Id { get; set; }
        public string LetterOfCreditCode { get; set; }
        public int ClientId { get; set; }
        public string Branch { get; set; }
        public DateTime IssuingDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public string InstrumentType { get; set; }
        public string InstrumentDescription { get; set; }
        public OCurrency Value { get; set; }

        public string Currency { get; set; }
        public string BeneficiaryParty { get; set; }
        double? FeePerPeriod { get; set; }

        public int FeePeriod { get; set; } //This data type is string in the entity BankGuarantees.
        public string Status { get; set; }

    }
}
