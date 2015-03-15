using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.CoreDomain.Batch
{
   
        public class ScheduledBatch
        {
            public int Id { get; set; }
            public string BatchName { get; set; }
            public DateTime ScheduledDate { get; set; }
            public int BatchResult { get; set; }
            public string User { get; set; }
            public string LogFilePath { get; set; }
            public int NoOfRuns { get; set; }
            public string BatchMode { get; set; }
        }
    
}
