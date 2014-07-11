using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Products
{
    public class CurrentAccountProduct : ICurrentAccountProduct
    {
public int Id { get; set; }
public int? Delete { get; set; }
public string CurrentAccountProductName { get; set; }
public string CurrentAccountProductCode { get; set; }
public string ClientType { get; set; }
public Currency Currency { get; set; }
public OCurrency InitialAmountMin { get; set; }
public OCurrency InitialAmountMax { get; set; }
public OCurrency BalanceMin { get; set; }
public OCurrency BalanceMax { get; set; }
public string EntryFeesType { get; set; }
public string ReopenFeesType { get; set; }
public string ClosingFeesType { get; set; }
public string ManagementFeesType { get; set; }
public string OverdraftType { get; set; }
public OCurrency EntryFeesMin { get; set; }
public OCurrency ReopenFeesMin { get; set; }
public OCurrency ClosingFeesMin { get; set; }
public OCurrency ManagementFeesMin { get; set; }
public OCurrency OverdraftMin { get; set; }
public OCurrency EntryFeesMax { get; set; }
public OCurrency ReopenFeesMax { get; set; }
public OCurrency ClosingFeesMax { get; set; }
public OCurrency ManagementFeesMax { get; set; }
public OCurrency OverdraftMax { get; set; }
public OCurrency EntryFeesValue { get; set; }
public OCurrency ReopenFeesValue { get; set; }
public OCurrency ClosingFeesValue { get; set; }
public OCurrency ManagementFeesValue { get; set; }
public OCurrency OverdraftValue { get; set; }
public string ManagementFeesFrequency { get; set; }

public double? InterestMin { get; set; }
public double? InterestMax { get; set; }
public string InterestType { get; set; }
public double? InterestValue { get; set; }
public int? InterestFrequency { get; set; }
public OCurrency OverdraftLimit { get; set; }

public string OverdraftInterestType { get; set; }
public double? OverdraftInterestValue { get; set; }
public double? OverdraftInterestMin { get; set; }
public double? OverdraftInterestMax { get; set; }
public string CommitmentFeeType { get; set; }
public double? CommitmentFeeMin { get; set; }
public double? CommitmentFeeMax { get; set; }
public double? CommitmentFeeValue { get; set; }
public OCurrency OverdraftLimitMin { get; set; }
public OCurrency OverdraftLimitMax { get; set; }
    }
}
