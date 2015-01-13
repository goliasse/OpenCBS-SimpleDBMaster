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

namespace OpenCBS.GUI.Accounting
{
    public partial class AccountsReceivable : Form
    {
        public AccountsReceivable()
        {
            InitializeComponent();
            InitializeComboBoxBranches();
            InitializeComboBoxCurrencies();
        }

        private void InitializeComboBoxBranches()
        {
            List<Branch> branches = ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted();
            cbBranches.Items.Clear();
            cbBranches.ValueMember = "Id";
            cbBranches.DisplayMember = "";
            cbBranches.DataSource = branches;
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
    }

}
