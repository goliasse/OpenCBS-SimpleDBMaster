using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain
{
    public class RWAPercentage
    {
        public OCurrency Contractrelatedtransaction { get; set; }
        public OCurrency Bidbond { get; set; }
        public OCurrency Performancebond { get; set; }
        public OCurrency Financialguarantee { get; set; }
        public OCurrency Letterofcredit { get; set; }
        public OCurrency Mortgageloan { get; set; }
        public OCurrency Otherloans { get; set; }
        public OCurrency GovernmentLoans { get; set; }
        public OCurrency Cash { get; set; } 
    }
}