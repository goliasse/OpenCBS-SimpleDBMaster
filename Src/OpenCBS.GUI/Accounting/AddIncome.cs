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
using OpenCBS.ExceptionsHandler;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Services;
using OpenCBS.Services.Accounting;

namespace OpenCBS.GUI.Accounting
{
    public partial class AddIncome : Form
    {
        AddedIncome _addedIncome = null;
        public AddIncome(AddedIncome addedIncome)
        {
            _addedIncome = addedIncome;
            InitializeComponent();
            InitializeComboBoxCurrencies();
            InitializeComboBoxBranches();
        }

        private void InitializeComboBoxCurrencies()
        {
            cbCurrency.Items.Clear();
            cbCurrency.Text = MultiLanguageStrings.GetString(Ressource.FrmAddLoanProduct, "Currency.Text");

            List<Currency> currencies = ServicesProvider.GetInstance().GetCurrencyServices().FindAllCurrencies();
            Currency line = new Currency { Name = MultiLanguageStrings.GetString(Ressource.FrmAddLoanProduct, "Currency.Text"), Id = 0 };
            cbCurrency.Items.Add(line);

            foreach (Currency cur in currencies)
            {
                cbCurrency.Items.Add(cur.Name);
            }
            cbCurrency.SelectedIndex = 0;
            //bool oneCurrency = 2 == cbCurrency.Items.Count;
            //cbCurrency.SelectedIndex = oneCurrency ? 1 : 0;
            //cbCurrency.Enabled = !oneCurrency;
        }

        private void InitializeComboBoxBranches()
        {
            cbBranch.Items.Clear();
            List<Branch> branches = ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted();
            cbBranch.ValueMember = "Id";
            cbBranch.DisplayMember = "";
            cbBranch.DataSource = branches;
        }

        private void cbIncomeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            
        }

        private void tbIncomeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            try
            {
                Income income = new Income();
                income.IncomeDate = incomeDate.Value;
                income.IncomeCategory = cbIncomeCategory.SelectedItem.ToString();
                income.IncomeDescription = tbIncomeDescription.Text;
                income.IncomeAmount = Convert.ToDecimal(tbIncomeAmount.Text);
                income.Reference = tbReference.Text;
                income.Currency = cbCurrency.SelectedItem.ToString();
                income.Branch = cbBranch.SelectedItem.ToString();

                IncomeService incomeService = ServicesProvider.GetInstance().GetIncomeService();
                int ret = incomeService.SaveIncome(income);
                if (ret >= 1)
                {
                    MessageBox.Show("Income added successfully.");
                    _addedIncome.InitializeIncomeList();
                    //Update chart of account
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().UpdateChartOfAccount("Credit", income.IncomeAmount.Value, "ProfitAndLossIncome", "OtherIncome", income.IncomeCategory + " " + ret, income.Currency, income.Branch);
                }
                else
                    MessageBox.Show("Some error ocurred.");

            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();

            }
        }
    }
}
