using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Products;
using OpenCBS.CoreDomain;
using OpenCBS.Services;

namespace OpenCBS.GUI.Clients
{
    public partial class CurrentAccountTransactionForm : Form
    {

        CurrentAccountTransactions currentAccountTransactions = null;

        public CurrentAccountTransactionForm()
        {
            InitializeComponent();
            InitializeMakerAndChecker();
            InitializeFromAndToAccount();
            btnMakeTransaction.Visible = true;
        }

        public CurrentAccountTransactionForm(int transactionId)
        {
            InitializeComponent();
            InitializeMakerAndChecker();
            InitializeFromAndToAccount();
            
            CurrentAccountTransactionService _currentAccountTransactionService = ServicesProvider.GetInstance().GetCurrentAccountTransactionService();
            CurrentAccountTransactions currentAccountTransactions = _currentAccountTransactionService.FetchTransaction(transactionId);
            btnMakeTransaction.Visible = false;

            if (currentAccountTransactions != null)
            {
                

                if (currentAccountTransactions.TransactionMode == "Credit")
                    
                    rbCredit.Checked = true;
                else
                    rbDebit.Checked = true;

                cbTransactionType.SelectedItem = currentAccountTransactions.TransactionType;
                if (currentAccountTransactions.FromAccount == "Cash" || currentAccountTransactions.FromAccount == "Cheque")
                    cbFromAccount.Text = currentAccountTransactions.FromAccount;
                else
                    cbFromAccount.SelectedItem = currentAccountTransactions.FromAccount;

                if (currentAccountTransactions.ToAccount == "Cash" || currentAccountTransactions.ToAccount == "Cheque")
                    cbToAccount.Text = currentAccountTransactions.ToAccount;
                else
                    cbToAccount.SelectedItem = currentAccountTransactions.ToAccount;
                tbAmount.Text = currentAccountTransactions.Amount.ToString();
                cbMaker.SelectedItem = currentAccountTransactions.Maker;
                cbChecker.SelectedItem = currentAccountTransactions.Checker;
                
                tbPurpose.Text = currentAccountTransactions.PurposeOfTransfer;
                tbTransactionDate.Text = currentAccountTransactions.TransactionDate.ToShortDateString();
                tbTransactionFees.Text = currentAccountTransactions.TransactionFees.ToString();


                lblTransactionDate.Visible = true;
                tbTransactionDate.Visible = true;
                tbTransactionFees.Visible = true;
                lblTransactionFees.Visible = true;

                EnableCurrentAccountTransactionControl(false);
            }
        }


        private void InitializeFromAndToAccount()
        {
            cbFromAccount.Items.Clear();
            cbToAccount.Items.Clear();
            FixedDepositProductHoldingServices _fixedDepositProductHoldingServices = ServicesProvider.GetInstance().GetFixedDepositProductHoldingServices();
            List<FixedDepositProductHoldings> fixedDepositProductHoldingsList = _fixedDepositProductHoldingServices.FetchProduct(true);
            if (fixedDepositProductHoldingsList != null)
            {
                foreach (FixedDepositProductHoldings fixedDepositProductHoldings in fixedDepositProductHoldingsList)
                {
                    cbFromAccount.Items.Add(fixedDepositProductHoldings.FixedDepositContractCode);
                    // cbToAccount.Items.Add(fixedDepositProductHoldings.FixedDepositContractCode);
                }
            }


            CurrentAccountProductHoldingServices _currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
            List<CurrentAccountProductHoldings> currentAccountProductHoldingsList = _currentAccountProductHoldingServices.FetchProduct(true);
            if (currentAccountProductHoldingsList != null)
            {
                foreach (CurrentAccountProductHoldings currentAccountProductHoldings in currentAccountProductHoldingsList)
                {
                    cbFromAccount.Items.Add(currentAccountProductHoldings.CurrentAccountContractCode);
                    cbToAccount.Items.Add(currentAccountProductHoldings.CurrentAccountContractCode);
                }
            }
        }

        private void InitializeMakerAndChecker()
        {
            List<User> users = ServicesProvider.GetInstance().GetUserServices().FindAll(true);
            cbMaker.ValueMember = "Name";
            cbMaker.DisplayMember = "";
            cbMaker.DataSource = users;

            cbChecker.ValueMember = "Name";
            cbChecker.DisplayMember = "";
            cbChecker.DataSource = users;


        }


        void EnableCurrentAccountTransactionControl(bool enabled)
        {
            rbCredit.Enabled = enabled;
            rbDebit.Enabled = enabled;
            cbTransactionType.Enabled = enabled;
            cbFromAccount.Enabled = enabled;
            cbToAccount.Enabled = enabled;
            tbAmount.Enabled = enabled;
            cbMaker.Enabled = enabled;
            cbChecker.Enabled = enabled;
            tbTransactionFees.Enabled = enabled;
            tbPurpose.Enabled = enabled;
            tbTransactionDate.Enabled = enabled;
        }

        void InitializeCurrentAccountTransactionControl()
        {


        }

        private void btnExtendPeriod_Click(object sender, EventArgs e)
        {
            currentAccountTransactions = new CurrentAccountTransactions();

            if (rbCredit.Checked == true)
                currentAccountTransactions.TransactionMode = "Credit";
            else
                currentAccountTransactions.TransactionMode = "Debit";

            currentAccountTransactions.TransactionType = cbTransactionType.SelectedItem.ToString();
            
            currentAccountTransactions.FromAccount = cbFromAccount.Text;
           
            currentAccountTransactions.ToAccount = cbToAccount.Text;

            currentAccountTransactions.Amount = Convert.ToDecimal(tbAmount.Text);
            currentAccountTransactions.Maker = cbMaker.SelectedItem.ToString();
            currentAccountTransactions.Checker = cbChecker.SelectedItem.ToString();
            currentAccountTransactions.TransactionDate = DateTime.Today;
            currentAccountTransactions.PurposeOfTransfer = tbPurpose.Text;
            
            CurrentAccountTransactionService _currentAccountTransactionService = ServicesProvider.GetInstance().GetCurrentAccountTransactionService();

            int ret = _currentAccountTransactionService.SaveCurrentAccountTransactions(currentAccountTransactions);
            if (ret >= 1)
                MessageBox.Show("Transaction Successful.");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        void InitializeControls()
        {
           
            cbFromAccount.Text = "";
            cbToAccount.Text = "";
            lblFromAccount.Text = "Select From Account:";
            lblToAccount.Text = "Select To Account:";
            if (cbTransactionType.SelectedItem != null)
            {
                string transactionType = cbTransactionType.SelectedItem.ToString();

                if (rbCredit.Checked == true)
                {
                    if (transactionType == "Cash")
                    {
                        cbFromAccount.Text = "Cash";
                    }
                    if (transactionType == "Cheque")
                    {
                        lblFromAccount.Text = "From Cheque Number:";
                    }

                }
                else if (rbDebit.Checked == true)
                {
                    if (transactionType == "Cash")
                    {
                        cbToAccount.Text = "Cash";
                    }
                    if (transactionType == "Cheque")
                    {
                        lblToAccount.Text = "To Cheque Number:";
                    }
                }
            }
        }


        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            InitializeControls();
        }

        private void rbDebit_CheckedChanged(object sender, EventArgs e)
        {
            InitializeControls();
        }

        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeControls();
        }
    }
}