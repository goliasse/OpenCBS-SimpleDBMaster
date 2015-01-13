using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Accounting
{
    [Serializable]
    public class CurrencyAssets
    {
        public int Id { get; set; }
        public string AssetCategory { get; set; }
        public string AssetDescription { get; set; }
        public string Reference { get; set; }
        public DateTime AssetDate { get; set; }
        public OCurrency AssetAmount { get; set; }
        public string Currency { get; set; }
        public string Branch { get; set; }
    }
}
