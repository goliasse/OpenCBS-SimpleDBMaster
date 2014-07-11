using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Products
{
    public interface ICurrentAccountProduct
    {

        int Id { get; set; }
        int? Delete { get; set; }
        string CurrentAccountProductName { get; set; }
        string CurrentAccountProductCode { get; set; }
        string ClientType { get; set; }
        Currency Currency { get; set; }
        OCurrency InitialAmountMin { get; set; }
        OCurrency InitialAmountMax { get; set; }
        OCurrency BalanceMin { get; set; }
        OCurrency BalanceMax { get; set; }
        string EntryFeesType { get; set; }
        string ReopenFeesType { get; set; }
        string ClosingFeesType { get; set; }
        string ManagementFeesType { get; set; }
        string OverdraftType { get; set; }
        OCurrency EntryFeesMin { get; set; }
        OCurrency ReopenFeesMin { get; set; }
        OCurrency ClosingFeesMin { get; set; }
        OCurrency ManagementFeesMin { get; set; }
        OCurrency OverdraftMin { get; set; }
        OCurrency EntryFeesMax { get; set; }
        OCurrency ReopenFeesMax { get; set; }
        OCurrency ClosingFeesMax { get; set; }
        OCurrency ManagementFeesMax { get; set; }
        OCurrency OverdraftMax { get; set; }
        OCurrency EntryFeesValue { get; set; }
        OCurrency ReopenFeesValue { get; set; }
        OCurrency ClosingFeesValue { get; set; }
        OCurrency ManagementFeesValue { get; set; }
        OCurrency OverdraftValue { get; set; }
        string ManagementFeesFrequency { get; set; }

        double? InterestMin { get; set; }
        double? InterestMax { get; set; }
        string InterestType { get; set; }
        double? InterestValue { get; set; }
        int? InterestFrequency { get; set; }
        OCurrency OverdraftLimit { get; set; }

        string OverdraftInterestType { get; set; }
double? OverdraftInterestValue { get; set; }
double? OverdraftInterestMin { get; set; }
double? OverdraftInterestMax { get; set; }
string CommitmentFeeType { get; set; }
double? CommitmentFeeMin { get; set; }
double? CommitmentFeeMax { get; set; }
double? CommitmentFeeValue { get; set; }
OCurrency OverdraftLimitMin { get; set; }
OCurrency OverdraftLimitMax { get; set; }
    }
}
