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
    public partial class FrmBatchResult : Form
    {
        BatchService batchService = ServicesProvider.GetInstance().GetBatchService();
        string batchDate = DateTime.Today.Month + "/" + DateTime.Today.Year;

        public FrmBatchResult()
        {
            InitializeComponent();
            List<BatchResults> batchResultsList = batchService.FetchBatchResults(batchDate);
            InitializeBatchResultList(batchResultsList);
        }

        public void InitializeBatchResultList(List<BatchResults> batchResultsList)
        {

            lvBatchResults.Items.Clear();
            int i = 0;
            
            if (batchResultsList != null)
            {
                foreach (BatchResults batchResult in batchResultsList)
                {
                    var item = new ListViewItem(new[] {
                    i++.ToString(),
                    batchResult.ContractCode,
                    batchResult.MonthYear,
                    batchResult.CurrentAccountInterestResult.ToString(),
                    batchResult.OverdraftInterestResult.ToString(),
                    batchResult.CommitmentFeeResult.ToString(),
                    batchResult.AccountManagementFeeResult.ToString(),
                    batchResult.FixedOverdraftFeeResult.ToString()
                 
                });
                    lvBatchResults.Items.Add(item);

                }
            }
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            DateTime batchResult = dtpSelectMonthYear.Value.Date;
            batchDate = batchResult.Month + "/" + batchResult.Year;
            string contractCode = txtContractCode.Text;
            if (contractCode == "")
            {
                List<BatchResults> batchResultsList = batchService.FetchBatchResults(batchDate);
                InitializeBatchResultList(batchResultsList);
            }
            else
            {
                List<BatchResults> batchResultsList = new List<BatchResults>();
                 batchResultsList.Add(batchService.FetchBatchResults(contractCode, batchDate));
                InitializeBatchResultList(batchResultsList); ;
            }


        }
    }
}
