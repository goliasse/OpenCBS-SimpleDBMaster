using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Products
{
    public class CurrentAccountProduct : ICurrentAccountProduct
    {
public int CurrentAccountProductId { get; set; }
public int Delete { get; set; }
public string CurrentAccountProductName { get; set; }
public string CurrentAccountProductCode { get; set; }
public string ClientType { get; set; }
public string Currency { get; set; }
public double InitialAmountMin { get; set; }
public double InitialAmountMax { get; set; }
public double BalanceMin { get; set; }
public double BalanceMax { get; set; }
public string EntryFeesType { get; set; }
public string ReopenFeesType { get; set; }
public string ClosingFeesType { get; set; }
public string ManagementFeesType { get; set; }
public string OverdraftType { get; set; }
public double EntryFeesMin { get; set; }
public double ReopenFeesMin { get; set; }
public double ClosingFeesMin { get; set; }
public double ManagementFeesMin { get; set; }
public double OverdraftMin { get; set; }
public double EntryFeesMax { get; set; }
public double ReopenFeesMax { get; set; }
public double ClosingFeesMax { get; set; }
public double ManagementFeesMax { get; set; }
public double OverdraftMax { get; set; }
public double EntryFeesValue { get; set; }
public double ReopenFeesValue { get; set; }
public double ClosingFeesValue { get; set; }
public double ManagementFeesValue { get; set; }
public double OverdraftValue { get; set; }
public string ManagementFeesFrequency { get; set; }
    }
}
