using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Accounting
{
    [Serializable]
    public class Expense
    {
        public int Id { get; set; }
        public string ExpenseCategory { get; set; }
        public string ExpenseDescription { get; set; }
        public string Reference { get; set; }
        public DateTime ExpenseDate { get; set; }
        public OCurrency ExpenseAmount { get; set; }
    }
}
