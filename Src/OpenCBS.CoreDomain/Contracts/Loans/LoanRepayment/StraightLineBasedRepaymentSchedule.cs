using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Contracts.Loans.LoanRepayment
{
    public class StraightLineBasedRepaymentSchedule
    {
        
        public double MonthlyInterest { get; set; }
        public double RemainingPrincipal { get; set; }
        public double MonthlyInstallment { get; set; }
        public DateTime RepaymentDate { get; set; }

    }
}
