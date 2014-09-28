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

namespace OpenCBS.GUI.LetterOfCredit
{
    public partial class IssueALetterOfCredit : Form
    {


        Client _client = null;
        OpenCBS.CoreDomain.LetterOfCredit letterOfCredit = new OpenCBS.CoreDomain.LetterOfCredit();
        public IssueALetterOfCredit(Client client)
        {
            _client = client;
            InitializeComponent();
            InitializeLetterOfCreditFeePeriod();
            InitializeGuaranteeType();
            InitializeComboBoxCurrencies();
            InitializeLetterOfCreditStatus();

            txtApplicantId.Text = client.Id.ToString();
            txtIssuingDate.Text = DateTime.Today.ToShortDateString();

        }


        public IssueALetterOfCredit(string letterOfCreditCode, bool flag)
        {
           
            InitializeComponent();
            InitializeLetterOfCreditFeePeriod();
            InitializeGuaranteeType();
            InitializeComboBoxCurrencies();
            InitializeLetterOfCreditStatus();
            InitializeControls(flag);
            

            LetterOfCreditService _LetterOfCreditervice = ServicesProvider.GetInstance().GetLetterOfCreditService();
            letterOfCredit = _LetterOfCreditervice.FetchLetterOfCredit(letterOfCreditCode);

            txtIssuingDate.Text = letterOfCredit.IssuingDate.ToShortDateString();
            txtExpiryDate.Text = letterOfCredit.ExpiryDate.ToShortDateString();
            txtApplicantId.Text = letterOfCredit.ClientId.ToString();
            txtBeneficiaryParty.Text = letterOfCredit.BeneficiaryParty;
            cmbInstrumentType.SelectedItem = letterOfCredit.InstrumentType;
            txtFeePerPeriod.Text = letterOfCredit.FeePerPeriod.Value.ToString();
            cmbFeePeriod.SelectedItem = letterOfCredit.FeePeriod;
            txtInstrumentDescription.Text = letterOfCredit.InstrumentDescription;
            txtValue.Text = letterOfCredit.Value.GetFormatedValue(false);
            cmbCurrency.SelectedItem = letterOfCredit.Currency;
            cmbStatus.SelectedItem = letterOfCredit.Status;
            txtValidity.Text = GetValidity(letterOfCredit.IssuingDate, letterOfCredit.ExpiryDate, letterOfCredit.FeePeriod).ToString();
            txtTotalFee.Text = (Convert.ToDecimal(txtValidity.Text) * letterOfCredit.FeePerPeriod.Value).ToString();
            txtTransactionNumber.Text = letterOfCredit.FeeTransactionNumber;
        }



        private void InitializeControls(bool flag)
        {
            cmbCurrency.Enabled = false;
            if (flag == true)
            {
                txtExpiryDate.Enabled = !flag;
                txtApplicantId.Enabled = !flag;
                txtBeneficiaryParty.Enabled = !flag;
                cmbInstrumentType.Enabled = !flag;
                txtFeePerPeriod.Enabled = !flag;
                cmbFeePeriod.Enabled = !flag;

                txtInstrumentDescription.Enabled = !flag;
                
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
                cmbInstrumentType.Enabled = flag;
                txtFeePerPeriod.Enabled = flag;
                cmbFeePeriod.Enabled = flag;
                txtInstrumentDescription.Enabled = flag;
              
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


        void InitializeLetterOfCreditStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Issued");
            cmbStatus.Items.Add("Availed");


        }

        void InitializeLetterOfCreditFeePeriod()
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
            cmbInstrumentType.Items.Clear();
            cmbInstrumentType.Items.Add(OLetterOfCredit.SelectGuaranteeTypeDefault);
            cmbInstrumentType.Items.Add("Bid Bond");
            cmbInstrumentType.Items.Add("Performance Bond");
            cmbInstrumentType.Items.Add("Financial Guarantee");
            cmbInstrumentType.SelectedIndex = 0;
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            letterOfCredit.ClientId = _client.Id;
            letterOfCredit.Branch = _client.Branch.Code;
            letterOfCredit.FeeTransactionNumber = txtTransactionNumber.Text;
            letterOfCredit.Status = "Issued";
            letterOfCredit.ExpiryDate = CalculateExpiryDate(Convert.ToInt32(txtValidity.Text), cmbFeePeriod.SelectedItem.ToString());
            letterOfCredit.TotalFee =  Convert.ToInt32(txtValidity.Text) * ServicesHelper.ConvertStringToNullableDecimal(txtFeePerPeriod.Text);
            letterOfCredit.IssuingDate = DateTime.Today;
            letterOfCredit.Value = ServicesHelper.ConvertStringToNullableDecimal(txtValue.Text);
            letterOfCredit.Currency = cmbCurrency.SelectedItem.ToString();
            letterOfCredit.InstrumentDescription = txtInstrumentDescription.Text;
            letterOfCredit.FeePeriod = cmbFeePeriod.SelectedItem.ToString();
            letterOfCredit.FeePerPeriod = ServicesHelper.ConvertStringToNullableDecimal(txtFeePerPeriod.Text);
            letterOfCredit.InstrumentType = cmbInstrumentType.SelectedItem.ToString();
            letterOfCredit.BeneficiaryParty = txtBeneficiaryParty.Text.ToString();

            LetterOfCreditService _LetterOfCreditervice = ServicesProvider.GetInstance().GetLetterOfCreditService();
            string ret = _LetterOfCreditervice.SaveLetterOfCredit(letterOfCredit);
            if (ret != "")
            {
                MessageBox.Show("Letter Of Credit Successfully Issued. Code is " + ret);
            }
            else
            {
                MessageBox.Show("Some Error Ocurred.");
            }

        }

        private void txtApplicantId_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LetterOfCreditService _letterOfCreditService = ServicesProvider.GetInstance().GetLetterOfCreditService();
            letterOfCredit.Status = cmbStatus.SelectedItem.ToString();
            _letterOfCreditService.UpdateLetterOfCredit(letterOfCredit);
            MessageBox.Show("Letter Of Credit " + letterOfCredit.LetterOfCreditCode + " Successfully Updated!");
            btnUpdate.Enabled = false;
        }

        private void txtTotalFee_TextChanged(object sender, EventArgs e)
        {
            
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
