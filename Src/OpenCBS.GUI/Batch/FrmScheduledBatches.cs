using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Batch;
using OpenCBS.Services;

namespace OpenCBS.GUI.Batch
{
    public partial class FrmScheduledBatches : Form
    {
        BatchService batchService = ServicesProvider.GetInstance().GetBatchService();

        public FrmScheduledBatches()
        {
            InitializeComponent();
            List<ScheduledBatch> scheduledBatchList = batchService.FetchAllScheduledBatches();
            InitializeScheduledBatchList(scheduledBatchList);
        }

        public void InitializeScheduledBatchList(List<ScheduledBatch> scheduledBatchList)
        {

            lvScheduledBatches.Items.Clear();
            int i = 1;

            if (scheduledBatchList != null)
            {
                foreach (ScheduledBatch scheduledBatch in scheduledBatchList)
                {
                    if (scheduledBatch != null)
                    {
                        var item = new ListViewItem(new[] {
                    scheduledBatch.Id.ToString(),
                    scheduledBatch.BatchName,
                    scheduledBatch.ScheduledDate.ToShortDateString(),
                    scheduledBatch.BatchResult.ToString(),
                    scheduledBatch.User,
                    scheduledBatch.LogFilePath,
                    scheduledBatch.NoOfRuns.ToString()
                 
                });
                        lvScheduledBatches.Items.Add(item);
                    }
                }
            }
        }

        private void btnScheduleABatch_Click(object sender, EventArgs e)
        {
            FrmScheduleABatch frmScheduleABatch = new FrmScheduleABatch();
            frmScheduleABatch.Show();

        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            DateTime scheduledBatchDate = dtpScheduledBatchDate.Value.Date;
            List<ScheduledBatch> scheduledBatchList = batchService.FetchAllScheduledBatches(scheduledBatchDate);
            InitializeScheduledBatchList(scheduledBatchList);
        }

        private void UpdateBatchStatus(int batchId, int batchResult, int noOfRuns)
        {
            batchService.UpdateScheduledBatches(batchId, batchResult, noOfRuns);
        }

        private void btnRunBatch_Click(object sender, EventArgs e)
        {
            DateTime calculationDate = DateTime.Today.Date;
            List<ScheduledBatch> scheduledBatchList = batchService.FetchAllScheduledBatches(calculationDate);
            if (scheduledBatchList != null)
            {
                foreach (ScheduledBatch scheduledBatch in scheduledBatchList)
                {
                    if (scheduledBatch != null)
                    {
                        if ((scheduledBatch.BatchMode == "Scheduled") && (scheduledBatch.BatchResult == 0))
                        {
                            int batchId = scheduledBatch.Id;

                            if (scheduledBatch.BatchName == "CurrentAccountInterestBatch")
                            {
                                int i = batchService.CurrentAccountInterestBatch(calculationDate, batchId);
                                if (i == 1)
                                {
                                    UpdateBatchStatus(batchId, 1, 1);
                                }
                                else
                                {                                 
                                    UpdateBatchStatus(batchId, 0, 1);
                                }
                            }

                            if (scheduledBatch.BatchName == "OverdraftInterestCalculationBatch")
                            {
                                int i = batchService.ODFeesBatch(calculationDate, batchId);
                                if (i == 1)
                                {
                                    UpdateBatchStatus(batchId, 1, 1);
                                }
                                else
                                {
                                    UpdateBatchStatus(batchId, 0, 1);
                                }
                            }

                            if (scheduledBatch.BatchName == "OverdraftCommitmentFeeBatch")
                            {
                                int i = batchService.CommitmentFeesBatch(calculationDate, batchId);
                                if (i == 1)
                                {
                                    UpdateBatchStatus(batchId, 1, 1);
                                }
                                else
                                {
                                    UpdateBatchStatus(batchId, 0, 1);
                                }
                            }

                            if (scheduledBatch.BatchName == "AccountManagementFeeBatch")
                            {
                                int i = batchService.CurrentAccountManagemntFeeBatch(calculationDate, batchId);
                                if (i == 1)
                                {
                                    UpdateBatchStatus(batchId, 1, 1);
                                }
                                else
                                {
                                    UpdateBatchStatus(batchId, 0, 1);
                                }
                            }

                            if (scheduledBatch.BatchName == "FixedOverdraftFeeBatch")
                            {
                                int i = batchService.FixedOverdraftFeesBatch(calculationDate, batchId);
                                if (i == 1)
                                {
                                    UpdateBatchStatus(batchId, 1, 1);
                                }
                                else
                                {
                                    UpdateBatchStatus(batchId, 0, 1);
                                }
                            }

                            if (scheduledBatch.BatchName == "AccountDormantBatch")
                            {
                                int i = batchService.AccountDormantBatch(calculationDate, batchId);
                                if (i == 1)
                                {
                                    UpdateBatchStatus(batchId, 1, 1);
                                }
                                else
                                {
                                    UpdateBatchStatus(batchId, 0, 1);
                                }
                            }
                        }

                    }
                }
            }

        }

        private void btnViewLogFile_Click(object sender, EventArgs e)
        {
            int i = lvScheduledBatches.SelectedIndices[0];
            ListViewItem item = lvScheduledBatches.Items[i];
            string logFilePath = item.SubItems[5].Text;
            Process.Start(logFilePath);
        }
    }
}
