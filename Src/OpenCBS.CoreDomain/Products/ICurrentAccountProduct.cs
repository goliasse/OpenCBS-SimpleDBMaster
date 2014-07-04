using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Products
{
    public interface ICurrentAccountProduct
    {

        int Id { get; set; }
        int Delete { get; set; }
        string CurrentAccountProductName { get; set; }
        string CurrentAccountProductCode { get; set; }
        string ClientType { get; set; }
        string Currency { get; set; }
        decimal InitialAmountMin { get; set; }
        decimal InitialAmountMax { get; set; }
        decimal BalanceMin { get; set; }
        decimal BalanceMax { get; set; }
        string EntryFeesType { get; set; }
        string ReopenFeesType { get; set; }
        string ClosingFeesType { get; set; }
        string ManagementFeesType { get; set; }
        string OverdraftType { get; set; }
        decimal EntryFeesMin { get; set; }
        decimal ReopenFeesMin { get; set; }
        decimal ClosingFeesMin { get; set; }
        decimal ManagementFeesMin { get; set; }
        decimal OverdraftMin { get; set; }
        decimal EntryFeesMax { get; set; }
        decimal ReopenFeesMax { get; set; }
        decimal ClosingFeesMax { get; set; }
        decimal ManagementFeesMax { get; set; }
        decimal OverdraftMax { get; set; }
        decimal EntryFeesValue { get; set; }
        decimal ReopenFeesValue { get; set; }
        decimal ClosingFeesValue { get; set; }
        decimal ManagementFeesValue { get; set; }
        decimal OverdraftValue { get; set; }
        string ManagementFeesFrequency { get; set; }

        double InterestMin { get; set; }
        double InterestMax { get; set; }
        string InterestType { get; set; }
        double InterestValue { get; set; }
        int InterestFrequency { get; set; }
        decimal OverdraftLimit { get; set; }
    }
}
