using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Products
{
    public interface ICurrentAccountProduct
    {

        int CurrentAccountProductId { get; set; }
        int Delete { get; set; }
        string CurrentAccountProductName { get; set; }
        string CurrentAccountProductCode { get; set; }
        string ClientType { get; set; }
        string Currency { get; set; }
        double InitialAmountMin { get; set; }
        double InitialAmountMax { get; set; }
        double BalanceMin { get; set; }
        double BalanceMax { get; set; }
        string EntryFeesType { get; set; }
        string ReopenFeesType { get; set; }
        string ClosingFeesType { get; set; }
        string ManagementFeesType { get; set; }
        string OverdraftType { get; set; }
        double EntryFeesMin { get; set; }
        double ReopenFeesMin { get; set; }
        double ClosingFeesMin { get; set; }
        double ManagementFeesMin { get; set; }
        double OverdraftMin { get; set; }
        double EntryFeesMax { get; set; }
        double ReopenFeesMax { get; set; }
        double ClosingFeesMax { get; set; }
        double ManagementFeesMax { get; set; }
        double OverdraftMax { get; set; }
        double EntryFeesValue { get; set; }
        double ReopenFeesValue { get; set; }
        double ClosingFeesValue { get; set; }
        double ManagementFeesValue { get; set; }
        double OverdraftValue { get; set; }
        string ManagementFeesFrequency { get; set; }
    }
}
