using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain
{
    public class FixedAssetRegister
    {
        public int Id { get; set; }
        public int UpdaterId { get; set; }
        public string Branch { get; set; }
        public string AssetId { get; set; }
        public string Description { get; set; }
        public string AssetType { get; set; }
        public int NoOfAssets { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public OCurrency OriginalCost { get; set; }
        double? AnnualDepreciationRate { get; set; }
        public OCurrency AccumulatedDepreciationCharge { get; set; }
        public OCurrency NetBookValue { get; set; }
        public DateTime DisposalDate { get; set; }
        public int ProfitLossDisposal { get; set; }
        public string AcquisitionCapitalFinance { get; set; }
        public string AcquisitionCapitalTransaction { get; set; }
        public string DisposalAmountTransfer { get; set; }
        public string DisposalAmountTransaction { get; set; }

    }
}
