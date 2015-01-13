using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.CoreDomain.Clients;
using OpenCBS.Enums;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Services;
using OpenCBS.CoreDomain.Contracts.Loans;
using OpenCBS.CoreDomain.Contracts.Savings;
using OpenCBS.ExceptionsHandler;

namespace OpenCBS.GUI.BankGuarantee
{
    public partial class IssueBankGuarantee : Form
    {
        Client _client = null;
        public IssueBankGuarantee(Client client)
        {
            _client = client;
            InitializeComponent();
            InitializeBranch();
            InitializeBankGuaranteeFeePeriod();
            InitializeGuaranteeType();
            InitializeComboBoxCurrencies();
            txtApplicantId.Text = client.Id.ToString();
            txtIssuingDate.Text = DateTime.Today.ToShortDateString();
            btnUpdate.Visible = false;
        }

        BankGuarantees bankGuarantees = new BankGuarantees();
        public IssueBankGuarantee(string bankGuaranteeCode, bool flag)
        {
            
            InitializeComponent();
            InitializeBranch();
            InitializeBankGuaranteeFeePeriod();
            InitializeGuaranteeType();
            InitializeComboBoxCurrencies();
            InitializeControls(flag);
            InitializeBankGuaranteeStatus();
            BankGuaranteesService _bankGuaranteeService = ServicesProvider.GetInstance().GetBankGuaranteesService();
            bankGuarantees = _bankGuaranteeService.FetchBankGuarantee(bankGuaranteeCode);

            txtIssuingDate.Text = bankGuarantees.IssuingDate.ToShortDateString();
            txtExpiryDate.Text = bankGuarantees.ExpiryDate.ToShortDateString();
            txtApplicantId.Text = bankGuarantees.ApplicantId.ToString();
            txtBeneficiaryParty.Text = bankGuarantees.BeneficiaryParty;
            cmbGuaranteeType.SelectedItem = bankGuarantees.GuarnteeType;
            txtFeePerPeriod.Text = bankGuarantees.FeePerPeriod.GetFormatedValue(false);
            cmbFeePeriod.SelectedItem = bankGuarantees.FeePeriod;
            txtInstrumentDetails.Text = bankGuarantees.InstrumentDetails;
            txtValue.Text = bankGuarantees.Value.GetFormatedValue(false);
            cmbCurrency.SelectedItem = bankGuarantees.Currency;
            cmbStatus.SelectedItem = bankGuarantees.Status;
            txtTransactionNumber.Text = bankGuarantees.FeeTransactionNumber;
            txtValidity.Text = GetValidity(bankGuarantees.IssuingDate, bankGuarantees.ExpiryDate, bankGuarantees.FeePeriod).ToString();
            txtTotalFee.Text = (GetValidity(bankGuarantees.IssuingDate, bankGuarantees.ExpiryDate, bankGuarantees.FeePeriod) * Convert.ToInt32(txtFeePerPeriod.Text)).ToString();
        }


        void InitializeBankGuaranteeStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Issued");
            cmbStatus.Items.Add("Availed");
            

        }

        void InitializeBankGuaranteeFeePeriod()
        {
            cmbFeePeriod.Items.Clear();
            cmbFeePeriod.Items.Add("Days");
            cmbFeePeriod.Items.Add("Months");
            cmbFeePeriod.Items.Add("Quarters");
            cmbFeePeriod.Items.Add("Bi-Annuals");
            cmbFeePeriod.Items.Add("Years");
            
            cmbFeePeriod.SelectedIndex = 0;

        }

        private void InitializeGuaranteeType()
        {
            cmbGuaranteeType.Items.Clear();
            cmbGuaranteeType.Items.Add(OBankGuarantee.SelectGuaranteeTypeDefault);
            cmbGuaranteeType.Items.Add("Bid Bond");
            cmbGuaranteeType.Items.Add("Performance Bond");
            cmbGuaranteeType.Items.Add("Financial Guarantee");
            cmbGuaranteeType.SelectedIndex = 0;
        }

        private void InitializeBranch()
        {
            //cmbBranch.ValueMember = "Code";
            //cmbBranch.DisplayMember = "Name";
            //cmbBranch.DataSource =
            //    ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted().OrderBy(item => item.Id).ToList();
        }

        private void InitializeComboBoxCurrencies()
        {
            cmbCurrency.Items.Clear();
            cmbCurrency.Text = MultiLanguageStrings.GetString(Ressource.FrmAddLoanProduct, "Currency.Text");
            List<Currency> currencies = ServicesProvider.GetInstance().GetCurrencyServices().FindAllCurrencies();
            Currency line = new Currency { Name = MultiLanguageStrings.GetString(Ressource.FrmAddLoanProduct, "Currency.Text"), Id = 0 };
            cmbCurrency.Items.Add(line);

            foreach (Currency cur in currencies)
            {
                cmbCurrency.Items.Add(cur.Name);
            }



            bool oneCurrency = 2 == cmbCurrency.Items.Count;
            cmbCurrency.SelectedIndex = oneCurrency ? 1 : 0;
            cmbCurrency.Enabled = !oneCurrency;
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


        

        private void InitializeControls(bool flag)
        {
            if (flag == true)
            {
                txtExpiryDate.Enabled = !flag;
                txtApplicantId.Enabled = !flag;
                txtBeneficiaryParty.Enabled = !flag;
                cmbGuaranteeType.Enabled = !flag;
                txtFeePerPeriod.Enabled = !flag;
                cmbFeePeriod.Enabled = !flag;
                txtInstrumentDetails.Enabled = !flag;
                cmbCurrency.Enabled = !flag;
                txtValue.Enabled = !flag;
                btnUpdate.Enabled = flag;
                btnSubmit.Enabled = !flag;
                cmbStatus.Enabled = flag;
                txtTotalFee.Enabled = !flag;
                txtExpiryDate.Enabled = !flag;
                txtValidity.Enabled = !flag;
                txtTransactionNumber.Enabled = !flag;
                btnSubmit.Visible = !flag;
                lblStatus.Visible = flag;
                lblTotalFee.Visible = flag;
                lblExpiryDate.Visible = flag;
                cmbStatus.Visible = flag;
                txtTotalFee.Visible = flag;
                txtExpiryDate.Visible = flag;
            }
            else
            {
                txtExpiryDate.Enabled = flag;
                txtApplicantId.Enabled = flag;
                txtBeneficiaryParty.Enabled = flag;
                cmbGuaranteeType.Enabled = flag;
                txtFeePerPeriod.Enabled = flag;
                cmbFeePeriod.Enabled = flag;
                txtInstrumentDetails.Enabled = flag;
                cmbCurrency.Enabled = flag;
                txtValue.Enabled = flag;
                btnSubmit.Enabled = flag;
                cmbStatus.Enabled = flag;
                txtTotalFee.Enabled = flag;
                txtExpiryDate.Enabled = flag;
                txtValidity.Enabled = flag;
                txtTransactionNumber.Enabled = flag;
                btnUpdate.Visible = flag;
                btnSubmit.Visible = flag;
                lblStatus.Visible = !flag;
                lblTotalFee.Visible = !flag;
                lblExpiryDate.Visible = !flag;
                cmbStatus.Visible = !flag;
                txtTotalFee.Visible = !flag;
                txtExpiryDate.Visible = !flag;
            }
        }

        
        public static DateTime CalculateExpiryDate(int validity, string validityPeriod)
        {
            DateTime issuingDate = DateTime.Today;
            DateTime expiryDate = DateTime.Today;

            if (validityPeriod == "Days")
                return expiryDate = issuingDate.AddDays(validity);

            else if (validityPeriod == "Months")
                return expiryDate = issuingDate.AddMonths(validity);

            else if (validityPeriod == "Quarters")
                return expiryDate = issuingDate.AddMonths(validity * 3);

            else if (validityPeriod == "Bi-Annuals")
                return expiryDate = issuingDate.AddMonths(validity * 6);

            else if (validityPeriod == "Years")
                return expiryDate = issuingDate.AddMonths(validity * 12);

            else
                return expiryDate;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        { try{
            BankGuaranteesService _bankGuaranteeService = ServicesProvider.GetInstance().GetBankGuaranteesService();
            bankGuarantees.Status = cmbStatus.SelectedItem.ToString();
            _bankGuaranteeService.UpdateBankGuarantee(bankGuarantees);
            MessageBox.Show("Bank Guarantee " + bankGuarantees.BankGuaranteeCode + " Successfully Updated!");

            //Update chart of account
            ServicesProvider.GetInstance().GetChartOfAccountsServices().UpdateChartOfAccount("Debit", bankGuarantees.Value.Value, "BalanceSheetLiabilities", "OtherLiabilities", "Bank Guarantees Ref. " + bankGuarantees.BankGuaranteeCode, bankGuarantees.Currency, bankGuarantees.Branch);

            btnUpdate.Enabled = false;
        }
        catch (Exception ex)
        {
            new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
        }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try{

                BankGuarantees bankGuarantees = new BankGuarantees();
           
                bankGuarantees.Branch = _client.Branch.Code;
            
           
                bankGuarantees.IssuingDate = DateTime.Today;
                bankGuarantees.ExpiryDate = CalculateExpiryDate(Convert.ToInt32(txtValidity.Text), cmbFeePeriod.SelectedItem.ToString());
                bankGuarantees.ApplicantId = _client.Id;
                bankGuarantees.BeneficiaryParty = txtBeneficiaryParty.Text;
                bankGuarantees.GuarnteeType = cmbGuaranteeType.SelectedItem.ToString();
                bankGuarantees.FeePerPeriod = ServicesHelper.ConvertStringToNullableDecimal(txtFeePerPeriod.Text);
                bankGuarantees.FeePeriod = cmbFeePeriod.SelectedItem.ToString();
                bankGuarantees.InstrumentDetails = txtInstrumentDetails.Text;
                bankGuarantees.Value = ServicesHelper.ConvertStringToNullableDecimal(txtValue.Text);
                bankGuarantees.Currency = cmbCurrency.SelectedItem.ToString();
                bankGuarantees.Status = "Issued";
                bankGuarantees.FeeTransactionNumber = txtTransactionNumber.Text;
                bankGuarantees.TotalFee = Convert.ToInt32(txtValidity.Text) * ServicesHelper.ConvertStringToNullableDecimal(txtFeePerPeriod.Text);

                BankGuaranteesService _bankGuaranteeService = ServicesProvider.GetInstance().GetBankGuaranteesService();
                string ret = _bankGuaranteeService.SaveBankGuarantee(bankGuarantees);
                if (ret != "")
                {
                    MessageBox.Show("Bank Guarantee Successfully Issued. Code is " + ret);
                    //Update chart of account
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().UpdateChartOfAccount("Credit", bankGuarantees.TotalFee.Value, "ProfitAndLossIncome", "OtherIncome", "Bank Guarantees Ref. " + ret, bankGuarantees.Currency, bankGuarantees.Branch);
                }
                else
                {
                    MessageBox.Show("Some Error Ocurred.");
                }

                
            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
        }

        private void txtFeePerPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        public static double GetValidity(DateTime IssuingDate, DateTime ExpiryDate, string ValidityPeriod)
        {
            if (ValidityPeriod == "Days")
            {
                return ExpiryDate.Subtract(IssuingDate).TotalDays;
            }
            else if (ValidityPeriod == "Months")
            {
                return GetMonthsBetween(IssuingDate, ExpiryDate);
            }
            else if (ValidityPeriod == "Quarters")
            {
                return GetMonthsBetween(IssuingDate, ExpiryDate) / 3;
            }
            else if (ValidityPeriod == "Bi-Annuals")
            {
                return GetMonthsBetween(IssuingDate, ExpiryDate) / 6;
            }
            else if (ValidityPeriod == "Years")
            {
                return GetMonthsBetween(IssuingDate, ExpiryDate) / 12;
            }
            else
                return -1;
        }

        public static int GetMonthsBetween(DateTime from, DateTime to)
        {
            if (from > to) return GetMonthsBetween(to, from);

            var monthDiff = Math.Abs((to.Year * 12 + (to.Month - 1)) - (from.Year * 12 + (from.Month - 1)));

            if (from.AddMonths(monthDiff) > to || to.Day < from.Day)
            {
                return monthDiff - 1;
            }
            else
            {
                return monthDiff;
            }
        }

        private void txtFeePerPeriod_TextChanged(object sender, EventArgs e)
        {
            if (_client != null)
            {
                txtTotalFee.Text = (Convert.ToInt32(txtValidity.Text) * ServicesHelper.ConvertStringToNullableDecimal(txtFeePerPeriod.Text)).ToString();
                txtTotalFee.Enabled = false;
            }
        }
    }
}
