using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain
{
    public class RWAPercentage
    {
        public int Contractrelatedtransaction { get; set; }
        public int Bidbond { get; set; }
        public int Performancebond { get; set; }
        public int Financialguarantee { get; set; }
        public int Letterofcredit { get; set; }
        public int Mortgageloan { get; set; }
        public int Otherloans { get; set; }
        public int GovernmentLoans { get; set; }
        public int Cash { get; set; } 
    }
}