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
    public partial class AddExpensesForm : Form
    {
        AddedExpense _addedExpense = null;
        public AddExpensesForm(AddedExpense addedExpense)
        {
            _addedExpense = addedExpense;
            InitializeComponent();
            InitializeComboBoxCurrencies();
            InitializeComboBoxBranches();
        }

        private void tbFDContractCode_TextChanged(object sender, EventArgs e)
        {

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

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            try {
            Expense expense = new Expense();
            expense.ExpenseDate = expenseDate.Value;
            expense.ExpenseCategory = cbExpenseCategory.SelectedItem.ToString();
            expense.ExpenseDescription = tbExpenseDescription.Text;
            expense.ExpenseAmount = Convert.ToDecimal(tbExpenseAmount.Text);
            expense.Reference = tbReference.Text;
            expense.Currency = cbCurrency.SelectedItem.ToString();
            expense.Branch = cbBranch.SelectedItem.ToString();

            ExpenseService expenseService = ServicesProvider.GetInstance().GetExpenseService();
            int ret = expenseService.AddExpense(expense);
            if (ret >= 1)
            {
                MessageBox.Show("Expense added successfully.");
                _addedExpense.InitializeExpenseList();
                //Update chart of account
                ServicesProvider.GetInstance().GetChartOfAccountsServices().UpdateChartOfAccount("CMIEX", expense.ExpenseAmount.Value, expense.ExpenseCategory + " " + ret, expense.Currency, expense.Branch);
               
            }
            else
                MessageBox.Show("Some error ocurred.");
              }
            catch (Exception ex)
            {
               new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
                
            }

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

        private void tbExpenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }
    }
}
