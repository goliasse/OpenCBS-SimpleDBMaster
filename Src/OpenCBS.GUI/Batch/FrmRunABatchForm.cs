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
    public partial class FrmRunABatchForm : Form
    {
        BatchService batchService = ServicesProvider.GetInstance().GetBatchService();
        DateTime calculationDate = DateTime.Today.Date;
        string batchIsRunning = "Batch Is Running...";

        public FrmRunABatchForm()
        {
            InitializeComponent();
            dtpAllBatches.CustomFormat = "MM/yyyy";
            dtpSelectedBatchs.CustomFormat = "MM/yyyy";
            dtpCAIBatch.CustomFormat = "MM/yyyy";
            dtpFODFBatch.CustomFormat = "MM/yyyy";
            dtpCFCBatch.CustomFormat = "MM/yyyy";
            dtpODICBatch.CustomFormat = "MM/yyyy";
            dtpAMFCBatch.CustomFormat = "MM/yyyy";
            dtpDABatch.CustomFormat = "MM/yyyy";
        }

        private void RunABatchForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void btnRunAllBatches_Click(object sender, EventArgs e)
        {
            string old = btnRunAllBatches.Text;

            btnRunAllBatches.Text = batchIsRunning;
            if (cbAllBatchDate.Checked)
            {
                calculationDate = dtpAllBatches.Value.Date;
                batchService.CurrentAccountInterestBatch(calculationDate);

                batchService.ODFeesBatch(calculationDate);

                batchService.CommitmentFeesBatch(calculationDate);

                batchService.AccountDormantBatch(calculationDate);

                batchService.CurrentAccountManagemntFeeBatch(calculationDate);

                batchService.FixedOverdraftFeesBatch(calculationDate);
            }

            else
            {

                calculationDate = dtpCAIBatch.Value.Date;
                batchService.CurrentAccountInterestBatch(calculationDate);

                calculationDate = dtpODICBatch.Value.Date;
                batchService.ODFeesBatch(calculationDate);

                calculationDate = dtpCFCBatch.Value.Date;
                batchService.CommitmentFeesBatch(calculationDate);

                calculationDate = dtpDABatch.Value.Date;
                batchService.AccountDormantBatch(calculationDate);

                calculationDate = dtpAMFCBatch.Value.Date;
                batchService.CurrentAccountManagemntFeeBatch(calculationDate);

                calculationDate = dtpFODFBatch.Value.Date;
                batchService.FixedOverdraftFeesBatch(calculationDate);

                //batchService.LoanStatementBatch();

                //batchService.FixedDepositStatementBatch();

                //batchService.CurrentAccountStatementBatch();

                //batchService.SavingAccountStatementBatch();

                //batchService.SavingAccountStatementBatch();

                //batchService.CurrentAccountChargesNoticeBatch();

                //batchService.LoanChargesNoticeBatch();

                //batchService.FixedDepositChargesNoticeBatch();

            }   

                btnRunAllBatches.Text = old;
        }

        private void btnRunSelectedBatches_Click(object sender, EventArgs e)
        {
            string old = btnRunSelectedBatches.Text;
            btnRunSelectedBatches.Text = batchIsRunning;
            if (cbSelectedBatch.Checked)
            {
                calculationDate = dtpSelectedBatchs.Value.Date;
                if (cbCurrentAccountInterest.Checked)
                {
                    batchService.CurrentAccountInterestBatch(calculationDate);
                }

                if (cbOverdraftFees.Checked)
                {
                    batchService.ODFeesBatch(calculationDate);
                }

                if (cbCommitmentFees.Checked)
                {
                    batchService.CommitmentFeesBatch(calculationDate);
                }

                if (cbDormantAccount.Checked)
                {
                    batchService.AccountDormantBatch(calculationDate);
                }

                if (cbCurrentAccMgmtFees.Checked)
                {
                    batchService.CurrentAccountManagemntFeeBatch(calculationDate);
                }


                if (cbFixedODFees.Checked)
                {
                    batchService.FixedOverdraftFeesBatch(calculationDate);
                }
                
            }
            else {
                if (cbCurrentAccountInterest.Checked)
                {
                    calculationDate = dtpCAIBatch.Value.Date;
                    batchService.CurrentAccountInterestBatch(calculationDate);
                }

                if (cbOverdraftFees.Checked)
                {
                    calculationDate = dtpODICBatch.Value.Date;
                    batchService.ODFeesBatch(calculationDate);
                }

                if (cbCommitmentFees.Checked)
                {
                    calculationDate = dtpCFCBatch.Value.Date;
                    batchService.CommitmentFeesBatch(calculationDate);
                }

                if (cbDormantAccount.Checked)
                {
                    calculationDate = dtpDABatch.Value.Date;
                    batchService.AccountDormantBatch(calculationDate);
                }

                if (cbCurrentAccMgmtFees.Checked)
                {
                    calculationDate = dtpAMFCBatch.Value.Date;
                    batchService.CurrentAccountManagemntFeeBatch(calculationDate);
                }


                if (cbFixedODFees.Checked)
                {
                    calculationDate = dtpFODFBatch.Value.Date;
                    batchService.FixedOverdraftFeesBatch(calculationDate);
                }
                
            }

        //if(cbLoanStatement.Checked)
        //    {
        //    batchService.LoanStatementBatch();
        //}

        //if (cbFixedDepositStatement.Checked)
        //{
        //    batchService.FixedDepositStatementBatch();
        //}

        //if (cbCurrentAccountStatement.Checked)
        //{
        //    batchService.CurrentAccountStatementBatch();
        //}

        //if (cbSavingAccountStatement.Checked)
        //{
        //    batchService.SavingAccountStatementBatch();
        //}

        //if(cbSavingAccountChargesNotice.Checked)
        //{
        //    batchService.SavingAccountStatementBatch();
        //}

        //if(cbCurrentAccountChargesNotice.Checked)
        //{
        //    batchService.CurrentAccountChargesNoticeBatch();
        //}

        //if(cbLoanChargesNotice.Checked)
        //{
        //    batchService.LoanChargesNoticeBatch();
        //}
        
        //if(cbFixedDepositChargesNotice.Checked)
        //{
        //    batchService.FixedDepositChargesNoticeBatch();
        //}

        btnRunSelectedBatches.Text = old;

        }

        private void btnCurrentAccountInterest_Click(object sender, EventArgs e)
        {
            string old = btnCurrentAccountInterest.Text;
            btnCurrentAccountInterest.Text = batchIsRunning;
            calculationDate = dtpCAIBatch.Value.Date;
            batchService.CurrentAccountInterestBatch(calculationDate);
            btnCurrentAccountInterest.Text = old;
        }

        private void btnOverdraftFees_Click(object sender, EventArgs e)
        {
            string old = btnOverdraftFees.Text;
            btnOverdraftFees.Text = batchIsRunning;
            calculationDate = dtpODICBatch.Value.Date;
            batchService.ODFeesBatch(calculationDate);
            btnOverdraftFees.Text = old;
        }

        private void btnCommitmentFees_Click(object sender, EventArgs e)
        {
            string old = btnCommitmentFees.Text;
            btnCommitmentFees.Text = batchIsRunning;
            calculationDate = dtpCFCBatch.Value.Date;
            batchService.CommitmentFeesBatch(calculationDate);
            btnCommitmentFees.Text = old;
        }

        private void btnDormantAccount_Click(object sender, EventArgs e)
        {
            string old = btnDormantAccount.Text;
            btnDormantAccount.Text = batchIsRunning;
            calculationDate = dtpDABatch.Value.Date;
            batchService.AccountDormantBatch(calculationDate);
            btnDormantAccount.Text = old;
        }

        private void btnAccountManagementFees_Click(object sender, EventArgs e)
        {
            string old = btnAccountManagementFees.Text;
            btnAccountManagementFees.Text = batchIsRunning;
            calculationDate = dtpAMFCBatch.Value.Date;
            batchService.CurrentAccountManagemntFeeBatch(calculationDate);
            btnAccountManagementFees.Text = old;
        }

        private void btnFixedODFees_Click(object sender, EventArgs e)
        {
            string old = btnFixedODFees.Text;
            btnFixedODFees.Text = batchIsRunning;
            calculationDate = dtpFODFBatch.Value.Date;
            batchService.FixedOverdraftFeesBatch(calculationDate);
            btnFixedODFees.Text = old;
        }

        //private void btnLoanStatement_Click(object sender, EventArgs e)
        //{
        //    string old = btnLoanStatement.Text;
        //    btnLoanStatement.Text = batchIsRunning;
        //    batchService.LoanStatementBatch();
        //    btnLoanStatement.Text = old;
        //}

        //private void btnSavingAccountStatement_Click(object sender, EventArgs e)
        //{
        //    string old = btnSavingAccountStatement.Text;
        //    btnSavingAccountStatement.Text = batchIsRunning;
        //    batchService.SavingAccountStatementBatch();
        //    btnSavingAccountStatement.Text = old;
        //}

        //private void btnCurrentAccountStatement_Click(object sender, EventArgs e)
        //{
        //    string old = btnCurrentAccountStatement.Text;
        //    btnCurrentAccountStatement.Text = batchIsRunning;
        //    batchService.CurrentAccountStatementBatch();
        //    btnCurrentAccountStatement.Text = old;
        //}

        //private void btnFixedDepositStatement_Click(object sender, EventArgs e)
        //{
        //    string old = btnFixedDepositStatement.Text;
        //    btnFixedDepositStatement.Text = batchIsRunning;
        //    batchService.FixedDepositStatementBatch();
        //    btnFixedDepositStatement.Text = old;
        //}

        //private void btnLoanChargesNotice_Click(object sender, EventArgs e)
        //{
        //    string old = btnLoanChargesNotice.Text;
        //    btnLoanChargesNotice.Text = batchIsRunning;
        //    batchService.LoanChargesNoticeBatch();
        //    btnLoanChargesNotice.Text = old;
        //}

        //private void btnCurrentAccountChargesNotice_Click(object sender, EventArgs e)
        //{
        //    string old = btnCurrentAccountChargesNotice.Text;
        //    btnCurrentAccountChargesNotice.Text = batchIsRunning;
        //    batchService.CurrentAccountChargesNoticeBatch();
        //    btnCurrentAccountChargesNotice.Text = old;
        //}

        //private void btnSavingAccountChargesNotice_Click(object sender, EventArgs e)
        //{
        //    string old = btnSavingAccountChargesNotice.Text;
        //    btnSavingAccountChargesNotice.Text = batchIsRunning;
        //    batchService.SavingAccountChargesNoticeBatch();
        //    btnSavingAccountChargesNotice.Text = old;
        //}

        //private void btnFixedDepositChargesNotice_Click(object sender, EventArgs e)
        //{
        //    string old = btnFixedDepositChargesNotice.Text;
        //    btnFixedDepositChargesNotice.Text = batchIsRunning;
        //    batchService.FixedDepositChargesNoticeBatch();
        //    btnFixedDepositChargesNotice.Text = old;
        //}

        
    }
}
