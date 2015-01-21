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
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Services;
using OpenCBS.Services.Accounting;

namespace OpenCBS.GUI.Accounting
{
    public partial class ProfitAndLossStatement : Form
    {
        public ProfitAndLossStatement()
        {
            InitializeComponent();
            InitializeComboBoxBranches();
            InitializeComboBoxCurrencies();
            InitializeProfitAndLoseStatement("DEF", DateTime.Today.Date);
        }

        private void InitializeProfitAndLoseStatement(string branch, DateTime tillDate)
        {
            lvProfitAndLossStatement.Items.Clear();
            ChartOfAccountsServices coaService = ServicesProvider.GetInstance().GetChartOfAccountsServices();
            List<Account> listAccount = coaService.SelectAllAccounts("ProfitAndLossIncome");
            int i = 0;
            decimal income = 0;
            foreach (Account account in listAccount)
            {

                decimal balance = coaService.CalculateCOABalance(branch, tillDate, account.Number + " : " + account.Label);
                var item = new ListViewItem(new[] {
                    i++.ToString(),
                    account.Number+" : "+account.Label,
                    balance.ToString()
                    
                });
                lvProfitAndLossStatement.Items.Add(item);
                income = income + balance;
            }


            listAccount = coaService.SelectAllAccounts("ProfitAndLossExpense");
            i = 0;
            decimal expense = 0;
            foreach (Account account in listAccount)
            {

                decimal balance = coaService.CalculateCOABalance(branch, tillDate, account.Number + " : " + account.Label);
                var item = new ListViewItem(new[] {
                    i++.ToString(),
                    account.Number+" : "+account.Label,
                    balance.ToString()
                    
                });
                lvProfitAndLossStatement.Items.Add(item);
                expense = expense + balance;
            }

            lblTotalIncome.Text = income.ToString();
            lblTotalExpense.Text = expense.ToString();
            lblNetProfit.Text = (income - expense).ToString();

        }

        private void InitializeComboBoxBranches()
        {
            List<Branch> branches = ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted();
            cbBranches.Items.Clear();
            
            foreach (Branch branch in branches)
            {
                cbBranches.Items.Add(branch.Code);
            }
            cbBranches.SelectedIndex = 0;
        }

        private void InitializeComboBoxCurrencies()
        {
            cbCurrencies.Items.Clear();
            cbCurrencies.Text = MultiLanguageStrings.GetString(Ressource.FrmAddLoanProduct, "Currency.Text");
            List<Currency> currencies = ServicesProvider.GetInstance().GetCurrencyServices().FindAllCurrencies();
            Currency line = new Currency { Name = MultiLanguageStrings.GetString(Ressource.FrmAddLoanProduct, "Currency.Text"), Id = 0 };

            foreach (Currency cur in currencies)
            {
                cbCurrencies.Items.Add(cur.Name);
            }
            cbCurrencies.SelectedIndex = 0;

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string branch = cbBranches.SelectedItem.ToString();
            DateTime tillDate = dateTimePickerTillDate.Value.Date;
            InitializeProfitAndLoseStatement(branch, tillDate);
        }
    }
}
