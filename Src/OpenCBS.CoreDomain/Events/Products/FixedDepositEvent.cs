using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Events.Products
{
    public class FixedDepositEvent
    {
        public int Id { get; set; }
        public string ContractCode { get; set; }
        public string EventCode { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
