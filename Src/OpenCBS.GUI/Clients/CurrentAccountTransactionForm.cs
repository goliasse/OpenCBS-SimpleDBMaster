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
using OpenCBS.Enums;
using OpenCBS.ExceptionsHandler;

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

            InitializeTransactionType();
        }


        void InitializeTransactionType()
        {
            cbTransactionType.Items.Clear();
            cbTransactionType.Items.Add(OCurrentAccount.SelectPaymentMethodDefault);
            cbTransactionType.Items.Add("Cash");
            cbTransactionType.Items.Add("Cheque");
            cbTransactionType.Items.Add("Transfer");
            cbTransactionType.Items.Add("Fee");
            cbTransactionType.SelectedIndex = 0;



        }

        public CurrentAccountTransactionForm(int transactionId)
        {
            InitializeComponent();
            InitializeMakerAndChecker();
            InitializeFromAndToAccount();
            InitializeTransactionType();

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
            List<FixedDepositProductHoldings> fixedDepositProductHoldingsList = _fixedDepositProductHoldingServices.FetchProduct(false);
            if (fixedDepositProductHoldingsList != null)
            {
                foreach (FixedDepositProductHoldings fixedDepositProductHoldings in fixedDepositProductHoldingsList)
                {
                    cbFromAccount.Items.Add(fixedDepositProductHoldings.FixedDepositContractCode);
                    // cbToAccount.Items.Add(fixedDepositProductHoldings.FixedDepositContractCode);
                }
            }


            CurrentAccountProductHoldingServices _currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
            List<CurrentAccountProductHoldings> currentAccountProductHoldingsList = _currentAccountProductHoldingServices.FetchProduct(false);
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
            try{
            currentAccountTransactions = new CurrentAccountTransactions();

            if (rbCredit.Checked == true)
                currentAccountTransactions.TransactionMode = "Credit";
            else
                currentAccountTransactions.TransactionMode = "Debit";

            currentAccountTransactions.TransactionType = cbTransactionType.SelectedItem.ToString();
            
            currentAccountTransactions.FromAccount = cbFromAccount.Text;
           
            currentAccountTransactions.ToAccount = cbToAccount.Text;

            currentAccountTransactions.Amount = ServicesHelper.ConvertStringToNullableDecimal(tbAmount.Text);
            currentAccountTransactions.Maker = cbMaker.SelectedItem.ToString();
            currentAccountTransactions.Checker = cbChecker.SelectedItem.ToString();
            currentAccountTransactions.TransactionDate = DateTime.Today;
            currentAccountTransactions.PurposeOfTransfer = tbPurpose.Text;
            string[] data = null;
            string productCode = "";
            CurrentAccountProductHoldingServices _currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
            CurrentAccountProductHoldings currentAccountProductHoldings = null;
            if (currentAccountTransactions.TransactionType == "Transfer")
            {
                if (currentAccountTransactions.FromAccount != "")
                {
                    data = currentAccountTransactions.FromAccount.Split('/');
                    productCode = data[1];
                    
                    currentAccountProductHoldings = _currentAccountProductHoldingServices.FetchProduct(currentAccountTransactions.FromAccount);
                }
            }
            else
            {
                if (currentAccountTransactions.TransactionMode == "Debit")
                {
                    currentAccountProductHoldings = _currentAccountProductHoldingServices.FetchProduct(currentAccountTransactions.FromAccount);
                }
                if (currentAccountTransactions.ToAccount != "")
                {
                    data = currentAccountTransactions.ToAccount.Split('/');
                    productCode = data[1];
                }
            }

            if (string.IsNullOrEmpty(currentAccountTransactions.FromAccount))
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.FromAccountNotSelected);

            if (string.IsNullOrEmpty(currentAccountTransactions.ToAccount))
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.ToAccountNotSelected);

            CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
            CurrentAccountProduct _currentAccountProduct = _currentAccountProductService.FetchProduct(productCode);

            if (currentAccountTransactions.TransactionType == OCurrentAccount.SelectPaymentMethodDefault)
                throw new OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum.CATSelectATransactionType);

            CurrentAccountTransactionFees _currentAccountTransactionFees = _currentAccountProductService.FetchTransactionFee(currentAccountTransactions.TransactionType, currentAccountTransactions.TransactionMode, _currentAccountProduct.Id);
            CurrentAccountTransactionService _currentAccountTransactionService = ServicesProvider.GetInstance().GetCurrentAccountTransactionService();

            int ret = _currentAccountTransactionService.MakeATransaction(currentAccountTransactions, _currentAccountTransactionFees, _currentAccountProduct, currentAccountProductHoldings);
            if (ret >= 1)
                MessageBox.Show("Transaction Successfull.");
            
            else if (ret == -1)
                MessageBox.Show("Balance is less than amount to be withdrawn and account does not have Overdraft facility enabled.");

            
                
            


            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }


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

        void KeyPressControl(KeyPressEventArgs e)
        {
            int keyCode = e.KeyChar;

            if (
                (keyCode >= 48 && keyCode <= 57) ||
                (keyCode == 8) ||
                (Char.IsControl(e.KeyChar) && e.KeyChar != ((char)Keys.V | (char)Keys.ControlKey))
                ||
                (Char.IsControl(e.KeyChar) && e.KeyChar != ((char)Keys.C | (char)Keys.ControlKey))
                ||
                (e.KeyChar.ToString() == System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }
    }
}