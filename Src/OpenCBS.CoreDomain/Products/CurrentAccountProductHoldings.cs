using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Products
{
    public class CurrentAccountProductHoldings
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientType { get; set; }
        public string CurrentAccountContractCode { get; set; }
        public CurrentAccountProduct CurrentAccountProduct { get; set; }
        public decimal InitialAmount { get; set; }
        public decimal OverdraftLimit { get; set; }
        public double InterestRate { get; set; }
        public int InterestCalculationFrequency { get; set; }
      
        public string OpeningAccountingOfficer { get; set; }
        public string ClosingAccountingOfficer { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Status { get; set; }
      
        public string Comment { get; set; }
      
        public decimal EntryFees { get; set; }
        public decimal ReopenFees { get; set; }
        public decimal ClosingFees { get; set; }
        public decimal ManagementFees { get; set; }
        public decimal OverdraftFees { get; set; }

        public string EntryFeesType { get; set; }
        public string ReopenFeesType { get; set; }
        public string ClosingFeesType { get; set; }
        public string ManagementFeesType { get; set; }
        public string OverdraftFeesType { get; set; }

        public string ManagementFeesFrequency { get; set; }
        public string InitialAmountPaymentMethod { get; set; }
        public string FirstName { get; set; }

        public string FinalAmountPaymentMethod { get; set; }
        public string FinalAmountAccountNumber { get; set; }
    }
}
