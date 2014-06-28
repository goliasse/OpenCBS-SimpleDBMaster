using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Products
{
    public class CurrentAccountProduct : ICurrentAccountProduct
    {
public int Id { get; set; }
public int Delete { get; set; }
public string CurrentAccountProductName { get; set; }
public string CurrentAccountProductCode { get; set; }
public string ClientType { get; set; }
public string Currency { get; set; }
public decimal InitialAmountMin { get; set; }
public decimal InitialAmountMax { get; set; }
public decimal BalanceMin { get; set; }
public decimal BalanceMax { get; set; }
public string EntryFeesType { get; set; }
public string ReopenFeesType { get; set; }
public string ClosingFeesType { get; set; }
public string ManagementFeesType { get; set; }
public string OverdraftType { get; set; }
public decimal EntryFeesMin { get; set; }
public decimal ReopenFeesMin { get; set; }
public decimal ClosingFeesMin { get; set; }
public decimal ManagementFeesMin { get; set; }
public decimal OverdraftMin { get; set; }
public decimal EntryFeesMax { get; set; }
public decimal ReopenFeesMax { get; set; }
public decimal ClosingFeesMax { get; set; }
public decimal ManagementFeesMax { get; set; }
public decimal OverdraftMax { get; set; }
public decimal EntryFeesValue { get; set; }
public decimal ReopenFeesValue { get; set; }
public decimal ClosingFeesValue { get; set; }
public decimal ManagementFeesValue { get; set; }
public decimal OverdraftValue { get; set; }
public string ManagementFeesFrequency { get; set; }
    }
}
