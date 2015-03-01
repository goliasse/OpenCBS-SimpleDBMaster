using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.Services;

namespace OpenCBS.GUI.Batch
{
    public partial class RunABatchForm : Form
    {
        BatchService batchService = ServicesProvider.GetInstance().GetBatchService();

        public RunABatchForm()
        {
            InitializeComponent();
        }

        private void RunABatchForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRunAllBatches_Click(object sender, EventArgs e)
        {
            
                batchService.CurrentAccountInterestBatch();
            
                batchService.ODFeesBatch();
            
                batchService.CommitmentFeesBatch();
            
                batchService.AccountDormantBatch();
            
                batchService.CurrentAccountManagemntFeeBatch();
            
                batchService.LoanStatementBatch();
            
                batchService.FixedDepositStatementBatch();
            
                batchService.CurrentAccountStatementBatch();
            
                batchService.SavingAccountStatementBatch();
            
                batchService.SavingAccountStatementBatch();
            
                batchService.CurrentAccountChargesNoticeBatch();
            
                batchService.LoanChargesNoticeBatch();
            
                batchService.FixedDepositChargesNoticeBatch();
            
        }

        private void btnRunSelectedBatches_Click(object sender, EventArgs e)
        {

        if(cbCurrentAccountInterest.Checked)
        {
            batchService.CurrentAccountInterestBatch();
        }

        if(cbOverdraftFees.Checked)
            {
            batchService.ODFeesBatch();
        }

        if(cbCommitmentFees.Checked)
            {
            batchService.CommitmentFeesBatch();
        }

        if(cbDormantAccount.Checked)
            {
            batchService.AccountDormantBatch();
        }

        if(cbCurrentAccMgmtFees.Checked)
            {
            batchService.CurrentAccountManagemntFeeBatch();
        }

        if(cbLoanStatement.Checked)
            {
            batchService.LoanStatementBatch();
        }

        if (cbFixedDepositStatement.Checked)
        {
            batchService.FixedDepositStatementBatch();
        }

        if (cbCurrentAccountStatement.Checked)
        {
            batchService.CurrentAccountStatementBatch();
        }

        if (cbSavingAccountStatement.Checked)
        {
            batchService.SavingAccountStatementBatch();
        }

        if(cbSavingAccountChargesNotice.Checked)
        {
            batchService.SavingAccountStatementBatch();
        }

        if(cbCurrentAccountChargesNotice.Checked)
        {
            batchService.CurrentAccountChargesNoticeBatch();
        }

        if(cbLoanChargesNotice.Checked)
        {
            batchService.LoanChargesNoticeBatch();
        }
        
        if(cbFixedDepositChargesNotice.Checked)
        {
            batchService.FixedDepositChargesNoticeBatch();
        }

        }

        private void btnCurrentAccountInterest_Click(object sender, EventArgs e)
        {
            batchService.CurrentAccountInterestBatch();
        }

        private void btnOverdraftFees_Click(object sender, EventArgs e)
        {
            batchService.ODFeesBatch();
        }

        private void btnCommitmentFees_Click(object sender, EventArgs e)
        {
            batchService.CommitmentFeesBatch();
        }

        private void btnDormantAccount_Click(object sender, EventArgs e)
        {
            batchService.AccountDormantBatch();
        }

        private void btnAccountManagementFees_Click(object sender, EventArgs e)
        {
            batchService.CurrentAccountManagemntFeeBatch();
        }

        private void btnLoanStatement_Click(object sender, EventArgs e)
        {
            batchService.LoanStatementBatch();
        }

        private void btnSavingAccountStatement_Click(object sender, EventArgs e)
        {
            batchService.SavingAccountStatementBatch();
        }

        private void btnCurrentAccountStatement_Click(object sender, EventArgs e)
        {
            batchService.CurrentAccountStatementBatch();
        }

        private void btnFixedDepositStatement_Click(object sender, EventArgs e)
        {
            batchService.FixedDepositStatementBatch();
        }

        private void btnLoanChargesNotice_Click(object sender, EventArgs e)
        {
            batchService.LoanChargesNoticeBatch();
        }

        private void btnCurrentAccountChargesNotice_Click(object sender, EventArgs e)
        {
            batchService.CurrentAccountChargesNoticeBatch();
        }

        private void btnSavingAccountChargesNotice_Click(object sender, EventArgs e)
        {
            batchService.SavingAccountChargesNoticeBatch();
        }

        private void btnFixedDepositChargesNotice_Click(object sender, EventArgs e)
        {
            batchService.FixedDepositChargesNoticeBatch();
        }
    }
}
