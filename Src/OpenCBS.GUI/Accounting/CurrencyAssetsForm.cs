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
    public partial class CurrencyAssetsForm : Form
    {
        AddedCurrencyAsset _adedCurrencyAsset = null;
        public CurrencyAssetsForm(AddedCurrencyAsset addedCurrencyAsset)
        {
            _adedCurrencyAsset = addedCurrencyAsset;
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

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try {
            CurrencyAssets currencyAssets = new CurrencyAssets();
            currencyAssets.AssetDate = assetDate.Value;
            currencyAssets.AssetCategory = cbAssetCategory.SelectedItem.ToString();
            currencyAssets.AssetDescription = tbAssetDescription.Text;
            currencyAssets.AssetAmount = Convert.ToDecimal(tbAssetAmount.Text);
            currencyAssets.Reference = tbReference.Text;
            currencyAssets.Currency = cbCurrency.SelectedItem.ToString();
            currencyAssets.Branch = cbBranch.SelectedItem.ToString();
            string fundedFrom = assetFundedFrom.SelectedItem.ToString();
            CurrencyAssetService currencyAssetService = ServicesProvider.GetInstance().GetCurrencyAssetService();
            int ret = currencyAssetService.SaveCurrencyAssets(currencyAssets);
            if (ret >= 1)
            {
                MessageBox.Show("Currency Asset added successfully!");
                _adedCurrencyAsset.InitializeCurrencyAssetList();
                if (fundedFrom == "Income Ledger")
                {
                    //Update chart of account
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().UpdateChartOfAccount("CMAIN", currencyAssets.AssetAmount.Value, currencyAssets.AssetCategory + " " + ret, currencyAssets.Currency, currencyAssets.Branch);
                    
                }
                else if (fundedFrom == "Capital Ledger")
                {
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().UpdateChartOfAccount("CMACA", currencyAssets.AssetAmount.Value, currencyAssets.AssetCategory + " " + ret, currencyAssets.Currency, currencyAssets.Branch);
                    
                }
                else if (fundedFrom == "Liabilities Ledger")
                {
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().UpdateChartOfAccount("CMALI", currencyAssets.AssetAmount.Value, currencyAssets.AssetCategory + " " + ret, currencyAssets.Currency, currencyAssets.Branch);
                    
                }
            }
            else
            {
                MessageBox.Show("Some error ocurred!");
            }

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

        private void tbAssetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void assetFundedFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
