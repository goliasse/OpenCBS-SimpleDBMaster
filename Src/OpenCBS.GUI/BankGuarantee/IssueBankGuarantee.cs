using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Enums;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Services;

namespace OpenCBS.GUI.BankGuarantee
{
    public partial class IssueBankGuarantee : Form
    {
        public IssueBankGuarantee()
        {
            InitializeComponent();
            InitializeBranch();
        }

        void InitializeManagementFeeFrequency()
        {
            cmbFeePeriod.Items.Clear();
            cmbFeePeriod.Items.Add(OCurrentAccount.SelectFrequencyDefault);
            cmbFeePeriod.Items.Add(OCurrentAccount.FeeTypeDaily);
            cmbFeePeriod.Items.Add(OCurrentAccount.FeeTypeMonthly);
            cmbFeePeriod.Items.Add(OCurrentAccount.FeeTypeQuarterly);
            cmbFeePeriod.Items.Add(OCurrentAccount.FeeTypeHalfYearly);
            cmbFeePeriod.Items.Add(OCurrentAccount.FeeTypeYearly);
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
            cmbBranch.ValueMember = "Code";
            cmbBranch.DisplayMember = "Name";
            cmbBranch.DataSource =
                ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted().OrderBy(item => item.Id).ToList();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void txtFeePerPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }
    }
}
