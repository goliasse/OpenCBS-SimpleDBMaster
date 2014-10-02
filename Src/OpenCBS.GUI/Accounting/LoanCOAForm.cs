using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.Services;
using OpenCBS.Services.Accounting;

namespace OpenCBS.GUI.Accounting
{
    public partial class LoanCOAForm : Form
    {
        public LoanCOAForm()
        {
            InitializeComponent();


            ChartOfAccountsServices  chartOfAccountsServices  = ServicesProvider.GetInstance().GetChartOfAccountsServices();
            
           //Interest accrued on loan
            lblLoanInterestAccrued.Text = chartOfAccountsServices.SearchChartOfAccount("L","Interest","Debit") .ToString();

            //Total loan disbursement done
            lblLoanDisburse.Text = chartOfAccountsServices.SearchChartOfAccount("L","Loan","Credit").ToString();

            //Total loan principal repayment done

            lblLoanRepayment.Text =  chartOfAccountsServices.SearchChartOfAccount("L","Loan","Debit") .ToString();

            //Fee accrued on Loan accounts
            lblLoanFeeAccrued.Text =  chartOfAccountsServices.SearchChartOfAccount("L","Fee","Debit") .ToString();

            //Fee accrued on Saving accounts
            lblSavingAccountFeeAccrued.Text =  chartOfAccountsServices.SearchChartOfAccount("S","Fee","Debit") .ToString();

            //Fee accrued on Current accounts 
            lblCurrentAccountFeeAccrued.Text =  chartOfAccountsServices.SearchChartOfAccount("C","Fee","Debit") .ToString();

            //Fee accrued on Fixed Deposit
            lblFixedDepositFeeAccrued.Text = chartOfAccountsServices.SearchChartOfAccount("F","Fee","Debit") .ToString();

        }
    }
}
