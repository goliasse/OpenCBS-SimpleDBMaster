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
    public partial class BalanceSheet : Form
    {
        public BalanceSheet()
        {
            InitializeComponent();
            InitializeComboBoxBranches();
            InitializeComboBoxCurrencies();
            
            InitializeBalanceSheet("All", DateTime.Today.Date);
        }

        private void InitializeBalanceSheet(string branch, DateTime tillDate)
        {
            lvBalanceSheet.Items.Clear();
            ChartOfAccountsServices coaService = ServicesProvider.GetInstance().GetChartOfAccountsServices();
            List<Account> listAccount = coaService.FindAllAccounts().OrderBy(item => item.Number).ToList();
            
            int i = 0;
            foreach (Account account in listAccount)
            {

                decimal balance = coaService.CalculateCOABalance(branch, tillDate, account.Number + " : " + account.Label);
                var item = new ListViewItem(new[] {
                    i++.ToString(),
                    account.Number+" : "+account.Label,
                    balance.ToString()
                    
                    
                });
                lvBalanceSheet.Items.Add(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InitializeComboBoxBranches()
        {

            List<Branch> branches = ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted();
            cbBranches.Items.Clear();
            cbBranches.Items.Add("All");
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
            InitializeBalanceSheet(branch, tillDate);
            
        }
    }
}
