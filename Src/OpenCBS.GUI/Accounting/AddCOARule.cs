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
    public partial class AddCOARule : Form
    {

        AddedCOARules addedCOARules = null;
        public AddCOARule()
        {
            InitializeComponent();
            InitializeDebitCreditAccounts();
            InitializeComboBoxBranches();
            InitializeComboBoxCurrencies();
            InitializeCOAEventCode();
        }

        public AddCOARule(AddedCOARules _addedCOARules)
        {
            InitializeComponent();
            InitializeDebitCreditAccounts();
            InitializeComboBoxBranches();
            InitializeComboBoxCurrencies();
            InitializeCOAEventCode();
            addedCOARules = _addedCOARules;
        }

        private void InitializeCOAEventCode()
        {
            cmbEventCode.Items.Clear();
            ChartOfAccountsServices coaService = ServicesProvider.GetInstance().GetChartOfAccountsServices();
            List<string> listCOAEvents = coaService.FetchCOAEvents();

            foreach (string code in listCOAEvents)
            {
                cmbEventCode.Items.Add(code);
            }

            cmbEventCode.SelectedIndex = 0;
        }

        private void InitializeDebitCreditAccounts()
        {
            cmbDebitAccount.ValueMember = "Number";
            cmbDebitAccount.DisplayMember = "";
            cmbDebitAccount.DataSource = ServicesProvider.GetInstance().GetChartOfAccountsServices().FindAllAccounts().OrderBy(item => item.Number).ToList();

            cmbCreditAccount.ValueMember = "Number";
            cmbCreditAccount.DisplayMember = "";
            cmbCreditAccount.DataSource = ServicesProvider.GetInstance().GetChartOfAccountsServices().FindAllAccounts().OrderBy(item => item.Number).ToList();
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
            cmbCurrency.Items.Clear();
            cmbCurrency.Text = MultiLanguageStrings.GetString(Ressource.FrmAddLoanProduct, "Currency.Text");
            List<Currency> currencies = ServicesProvider.GetInstance().GetCurrencyServices().FindAllCurrencies();
            Currency line = new Currency { Name = MultiLanguageStrings.GetString(Ressource.FrmAddLoanProduct, "Currency.Text"), Id = 0 };
            cmbCurrency.Items.Add("All");
            foreach (Currency cur in currencies)
            {
                cmbCurrency.Items.Add(cur.Name);
            }
            cmbCurrency.SelectedIndex = 0;

        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            COARule coaRule = new COARule();

            coaRule.EventType = cmbEventCode.SelectedItem.ToString().Split('-')[0];
            coaRule.CreditAccount = cmbCreditAccount.SelectedItem.ToString();
            coaRule.DebitAccount = cmbDebitAccount.SelectedItem.ToString();
            coaRule.Currency = cmbCurrency.SelectedItem.ToString();
            coaRule.Branch = cbBranches.SelectedItem.ToString();

            ChartOfAccountsServices coaService = ServicesProvider.GetInstance().GetChartOfAccountsServices();
            int ret = coaService.AddCOARule(coaRule);

           if (ret >= 1)
           {
               MessageBox.Show("COA Rule added successfully.");
               addedCOARules.InitializeCOARuleList();
           }
           else
               MessageBox.Show("Some error ocurred.");
       
        }
    }
}
