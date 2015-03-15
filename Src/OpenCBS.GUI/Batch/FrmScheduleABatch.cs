using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Batch;
using OpenCBS.Services;

namespace OpenCBS.GUI.Batch
{
    public partial class FrmScheduleABatch : Form
    {
        BatchService batchService = ServicesProvider.GetInstance().GetBatchService();

        public FrmScheduleABatch()
        {
            InitializeComponent();
        }

        private void btnScheduleBatch_Click(object sender, EventArgs e)
        {
            ScheduledBatch scheduledBatches = new ScheduledBatch();
            scheduledBatches.BatchName = cmbBatches.SelectedItem.ToString();
            scheduledBatches.ScheduledDate = dtpBatchDate.Value.Date;
            scheduledBatches.BatchResult = 0;
            scheduledBatches.LogFilePath = "";
            scheduledBatches.NoOfRuns = 0;
            scheduledBatches.BatchMode = "Scheduled";
            int ret = batchService.ScheduleABatch(scheduledBatches);
            if (ret >= 1)
                MessageBox.Show("Batch has been scheduled successfully. Batch Id is "+ret);
            else if(ret == -1)
                MessageBox.Show("Duplicate Batch.");
            else
                MessageBox.Show("Some error ocurred.");
            

        }
    }
}
