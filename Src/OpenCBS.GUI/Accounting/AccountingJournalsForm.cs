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
    public partial class AccountingJournalsForm : Form
    {
        public AccountingJournalsForm()
        {
            InitializeComponent();
            InitializeComboBoxBranches();
            InitializeComboBoxCurrencies();
            ChartOfAccountsServices coaService = ServicesProvider.GetInstance().GetChartOfAccountsServices();
            List<COATransaction> COATransactionList = coaService.FetchCOATransactions("All", DateTime.Today.Date);
            InitializeCOATransactionList(COATransactionList);
        }

        public void InitializeCOATransactionList(List<COATransaction> COATransactionList)
        {

            lvAccountingJournal.Items.Clear();


            if (COATransactionList != null)
            {
                foreach (COATransaction coaTransaction in COATransactionList)
                {
                    var item = new ListViewItem(new[] {
                    coaTransaction.Id.ToString(),
                    "Debit",
                    coaTransaction.DebitAccount,
                    coaTransaction.Amount.GetFormatedValue(true),
                    "",
                    coaTransaction.Branch,
                    coaTransaction.Currency,
                    coaTransaction.Description,
                    coaTransaction.TransactionDate.ToShortDateString(),
                    coaTransaction.EventCode

                });
                    lvAccountingJournal.Items.Add(item);

                    var item1 = new ListViewItem(new[] {
                    coaTransaction.Id.ToString(),
                    "Credit",
                    coaTransaction.CreditAccount,
                    "",
                    coaTransaction.Amount.GetFormatedValue(true),
                    coaTransaction.Branch,
                    coaTransaction.Currency,
                    coaTransaction.Description,
                    coaTransaction.TransactionDate.ToShortDateString(),
                    coaTransaction.EventCode

                });
                    lvAccountingJournal.Items.Add(item1);

                }
            }
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
            ChartOfAccountsServices coaService = ServicesProvider.GetInstance().GetChartOfAccountsServices();
            List<COATransaction> COATransactionList = coaService.FetchCOATransactions(branch, tillDate);
            InitializeCOATransactionList(COATransactionList);
        }
    }
}
