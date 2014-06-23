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
        public int CurrentAccountProductId { get; set; }
        public double InitialAmount { get; set; }
      
        public string OpeningAccountingOfficer { get; set; }
        public string ClosingAccountingOfficer { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Status { get; set; }
      
        public string Comment { get; set; }
      
        public double EntryFees { get; set; }
        public double ReopenFees { get; set; }
        public double ClosingFees { get; set; }
        public double ManagementFees { get; set; }
        public double OverdraftFees { get; set; }

        public string EntryFeesType { get; set; }
        public string ReopenFeesType { get; set; }
        public string ClosingFeesType { get; set; }
        public string ManagementFeesType { get; set; }
        public string OverdraftFeesType { get; set; }

        public string ManagementFeesFrequency { get; set; }
        public string InitialAmountPaymentMethod { get; set; }
    }
}
