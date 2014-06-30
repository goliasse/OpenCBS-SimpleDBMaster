// Octopus MFS is an integrated suite for managing a Micro Finance Institution: 
// clients, contracts, accounting, reporting and risk
// Copyright © 2006,2007 OCTO Technology & OXUS Development Network
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.CoreDomain.Contracts.Loans.Installments;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Enums;
using OpenCBS.ExceptionsHandler;
using OpenCBS.GUI.UserControl;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Services;
using OpenCBS.Shared;
using OpenCBS.GUI.Tools;

namespace OpenCBS.GUI.Products
{
    public partial class FrmAddCurrentAccountProduct : SweetBaseForm
    {
        

        public FrmAddCurrentAccountProduct()
        {
           
            InitializeComponent();
            InitializeComboBoxCurrencies();
           
        }

        public FrmAddCurrentAccountProduct(int productId)
        {
            InitializeComponent();
            

              
              CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
              ICurrentAccountProduct _currentAccountProduct = _currentAccountProductService.FetchProduct(productId);


cbCurrency.SelectedItem = _currentAccountProduct.Currency;
cbCurrency.Enabled = true;
            bool clientTypeCorp = clientTypeCorpCheckBox.Checked;
            bool clientTypeIndiv = clientTypeIndivCheckBox.Checked;
            bool clientTypeVillage = clientTypeVillageCheckBox.Checked;
            bool clientTypeGroup = clientTypeGroupCheckBox.Checked;
            bool clientTypeAll = clientTypeAllCheckBox.Checked;
clientTypeCorpCheckBox.Enabled = true;
clientTypeIndivCheckBox.Enabled = true;
clientTypeVillageCheckBox.Enabled = true;
clientTypeGroupCheckBox.Enabled = true;
clientTypeAllCheckBox.Enabled = true;
tbCodeCurrentAccountProduct.Text = _currentAccountProduct.CurrentAccountProductCode;
tbCodeCurrentAccountProduct.Enabled = true;
tbName.Text = _currentAccountProduct.CurrentAccountProductName;
tbName.Enabled = true;
            
rbFlatEntryFees.Enabled = true;
rbRateEntryFees.Enabled = true;

if(_currentAccountProduct.EntryFeesType == "Flat")
{
   rbFlatEntryFees.Checked = true;
}
else
{
   rbRateEntryFees.Checked = false;
}
rbFlatReopenFees.Enabled = true;
rbRateReopenFees.Enabled = true;

if(_currentAccountProduct.ReopenFeesType == "Flat")
{
   rbFlatReopenFees.Checked = true;
}
else
{
   rbRateReopenFees.Checked = true;
}
rbFlatCloseFees.Enabled = true;
rbFlatCloseFees.Enabled = true;

if(_currentAccountProduct.ClosingFeesType == "Flat")
{
rbFlatCloseFees.Checked = true;
}
else
{
rbFlatCloseFees.Checked = true;
}
rbFlatManagementFees.Enabled = true;
rbRateManagementFees.Enabled = true;
if(_currentAccountProduct.ManagementFeesType == "Flat")
{
   rbFlatManagementFees.Checked = true;
}
else
{
   rbRateManagementFees.Checked = true;
}
rbFlatOverdraftFees.Enabled = true;
rbRateOverdraftFees.Enabled = true;
if(_currentAccountProduct.OverdraftType == "Flat")
{
rbFlatOverdraftFees.Checked = true;
}
else
{
rbRateOverdraftFees.Checked = true;
}
cbManagementFeeFreq.SelectedItem = _currentAccountProduct.ManagementFeesFrequency;
cbManagementFeeFreq.Enabled = true;
tbInitialAmountMin.Text = _currentAccountProduct.InitialAmountMin.ToString();
tbInitialAmountMin.Enabled = true;
tbInitialAmountMax.Text =_currentAccountProduct.InitialAmountMax.ToString();
tbInitialAmountMax.Enabled = true;
tbBalanceMin.Text =_currentAccountProduct.BalanceMin.ToString();
tbBalanceMin.Enabled = true;
tbBalanceMax.Text =_currentAccountProduct.BalanceMax.ToString();
tbBalanceMax.Enabled = true;
tbEntryFeesMin.Text =_currentAccountProduct.EntryFeesMin.ToString();
tbEntryFeesMin.Enabled = true;
tbEntryFeesMax.Text =_currentAccountProduct.EntryFeesMax.ToString();
tbEntryFeesMax.Enabled = true;
tbReopenFeesMin.Text =_currentAccountProduct.ReopenFeesMin.ToString();
tbReopenFeesMin.Enabled = true;
tbReopenFeesMax.Text =_currentAccountProduct.ReopenFeesMax.ToString();
tbReopenFeesMax.Enabled = true;
tbCloseFeesMin.Text =_currentAccountProduct.ClosingFeesMin.ToString();
tbCloseFeesMin.Enabled = true;
tbCloseFeesMax.Text =_currentAccountProduct.ClosingFeesMax.ToString();
tbCloseFeesMax.Enabled = true;
tbManagementFeesMin.Text =_currentAccountProduct.ManagementFeesMin.ToString();
tbManagementFeesMin.Enabled = true;
tbManagementFeesMax.Text =_currentAccountProduct.ManagementFeesMax.ToString();
tbManagementFeesMax.Enabled = true;
tbOverdraftFeesMin.Text =_currentAccountProduct.OverdraftMin.ToString();
tbOverdraftFeesMin.Enabled = true;
tbOverdraftFeesMax.Text =_currentAccountProduct.OverdraftMax.ToString();
tbOverdraftFeesMax.Enabled = true;
tbEntryFees.Text =_currentAccountProduct.EntryFeesValue.ToString();
tbEntryFees.Enabled = true;
tbReopenFees.Text =_currentAccountProduct.ReopenFeesValue.ToString();
tbReopenFees.Enabled = true;
tbCloseFees.Text =_currentAccountProduct.ClosingFeesValue.ToString();
tbCloseFees.Enabled = true;
tbManagementFees.Text =_currentAccountProduct.ManagementFeesValue.ToString();
tbManagementFees.Enabled = true;
tbOverdraftFees.Text =_currentAccountProduct.OverdraftValue.ToString();
tbOverdraftFees.Enabled = true;
          
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
                cbCurrency.Items.Add(cur);
            }

            bool oneCurrency = 2 == cbCurrency.Items.Count;
            cbCurrency.SelectedIndex = oneCurrency ? 1 : 0;
            cbCurrency.Enabled = !oneCurrency;
        }

        private void btSavingProduct_Click(object sender, EventArgs e)
        {
            CurrentAccountProduct _currentAccountProduct = new CurrentAccountProduct();

            string Currency = cbCurrency.SelectedItem.ToString();
            bool clientTypeCorp = clientTypeCorpCheckBox.Checked;
            bool clientTypeIndiv = clientTypeIndivCheckBox.Checked;
            bool clientTypeVillage = clientTypeVillageCheckBox.Checked;
            bool clientTypeGroup = clientTypeGroupCheckBox.Checked;
            bool clientTypeAll = clientTypeAllCheckBox.Checked;
            string CodeFixedDepositProduct = tbCodeCurrentAccountProduct.Text + "-CA";
            string Name = tbName.Text;

            string clientType = "";

            if (clientTypeAll == true)
                clientType = "All";
            if (clientTypeCorp == true)
                clientType = clientType + "Corporate";
            if (clientTypeIndiv == true)
                clientType = clientType + "Person";
            if (clientTypeVillage == true)
                clientType = clientType + "Village";
            if (clientTypeGroup == true)
                clientType = clientType + "Group";

           
if(rbFlatEntryFees.Checked)
{
    _currentAccountProduct.EntryFeesType = "Flat";
}
else
{
    _currentAccountProduct.EntryFeesType = "Rate";
}
if(rbFlatReopenFees.Checked)
{
    _currentAccountProduct.ReopenFeesType = "Flat";
}
else
{
     _currentAccountProduct.ReopenFeesType = "Rate";
}
if(rbFlatCloseFees.Checked)
{
    _currentAccountProduct.ClosingFeesType = "Flat";
}
else
{
    _currentAccountProduct.ClosingFeesType = "Rate";
}
if(rbFlatManagementFees.Checked)
{
    _currentAccountProduct.ManagementFeesType = "Flat";
}
else
{
    _currentAccountProduct.ManagementFeesType = "Rate";
}
if(rbFlatOverdraftFees.Checked)
{
    _currentAccountProduct.OverdraftType = "Flat";
}
else
{
    _currentAccountProduct.OverdraftType = "Rate";
}
decimal InitialAmountMin = Convert.ToDecimal(tbInitialAmountMin.Text);
decimal InitialAmountMax = Convert.ToDecimal(tbInitialAmountMax.Text);
decimal BalanceMin = Convert.ToDecimal(tbBalanceMin.Text);
decimal BalanceMax = Convert.ToDecimal(tbBalanceMax.Text);
decimal EntryFeesMin = Convert.ToDecimal(tbEntryFeesMin.Text);
decimal EntryFeesMax = Convert.ToDecimal(tbEntryFeesMax.Text);
decimal ReopenFeesMin = Convert.ToDecimal(tbReopenFeesMin.Text);
decimal ReopenFeesMax = Convert.ToDecimal(tbReopenFeesMax.Text);
decimal CloseFeesMin = Convert.ToDecimal(tbCloseFeesMin.Text);
decimal CloseFeesMax = Convert.ToDecimal(tbCloseFeesMax.Text);
decimal ManagementFeesMin = Convert.ToDecimal(tbManagementFeesMin.Text);
decimal ManagementFeesMax = Convert.ToDecimal(tbManagementFeesMax.Text);
decimal OverdraftFeesMin = Convert.ToDecimal(tbOverdraftFeesMin.Text);
decimal OverdraftFeesMax = Convert.ToDecimal(tbOverdraftFeesMax.Text);
decimal EntryFees = Convert.ToDecimal(tbEntryFees.Text);
decimal ReopenFees = Convert.ToDecimal(tbReopenFees.Text);
decimal CloseFees = Convert.ToDecimal(tbCloseFees.Text);
decimal ManagementFees = Convert.ToDecimal(tbManagementFees.Text);
decimal OverdraftFees = Convert.ToDecimal(tbOverdraftFees.Text);
_currentAccountProduct.ManagementFeesFrequency = cbManagementFeeFreq.SelectedItem.ToString();
_currentAccountProduct.CurrentAccountProductName = Name;
_currentAccountProduct.CurrentAccountProductCode = CodeFixedDepositProduct;
_currentAccountProduct.ClientType = clientType;
_currentAccountProduct.Currency = Currency;
_currentAccountProduct.InitialAmountMin = InitialAmountMin;
_currentAccountProduct.InitialAmountMax = InitialAmountMax;
_currentAccountProduct.BalanceMin = BalanceMin;
_currentAccountProduct.BalanceMax = BalanceMax;
_currentAccountProduct.EntryFeesMin = EntryFeesMin;
_currentAccountProduct.EntryFeesMax = EntryFeesMax;
_currentAccountProduct.ReopenFeesMin = ReopenFeesMin;
_currentAccountProduct.ReopenFeesMax = ReopenFeesMax;
_currentAccountProduct.ClosingFeesMin = CloseFeesMin;
_currentAccountProduct.ClosingFeesMax = CloseFeesMax;
_currentAccountProduct.ManagementFeesMin = ManagementFeesMin;
_currentAccountProduct.ManagementFeesMax = ManagementFeesMax;
_currentAccountProduct.OverdraftMin = OverdraftFeesMin;
_currentAccountProduct.OverdraftMax = OverdraftFeesMax;
_currentAccountProduct.EntryFeesValue = EntryFees;
_currentAccountProduct.ReopenFeesValue = ReopenFees;
_currentAccountProduct.ClosingFeesValue = CloseFees;
_currentAccountProduct.ManagementFeesValue = ManagementFees;
_currentAccountProduct.OverdraftValue = OverdraftFees;
_currentAccountProduct.Delete = 0;


CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
int ret =_currentAccountProductService.SaveCurrentAccountProduct(_currentAccountProduct);

if (ret >= 1)
    MessageBox.Show("Current Account Product Successfully Added.");

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientTypeAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (clientTypeAllCheckBox.Checked == true)
            {
                clientTypeCorpCheckBox.Checked = true;
                clientTypeIndivCheckBox.Checked = true;
                clientTypeVillageCheckBox.Checked = true;
                clientTypeGroupCheckBox.Checked = true;
                clientTypeCorpCheckBox.Enabled = false;
                clientTypeIndivCheckBox.Enabled = false;
                clientTypeVillageCheckBox.Enabled = false;
                clientTypeGroupCheckBox.Enabled = false;
            }
            else
            {
                clientTypeCorpCheckBox.Checked = false;
                clientTypeIndivCheckBox.Checked = false;
                clientTypeVillageCheckBox.Checked = false;
                clientTypeGroupCheckBox.Checked = false;

                clientTypeCorpCheckBox.Enabled = true;
                clientTypeIndivCheckBox.Enabled = true;
                clientTypeVillageCheckBox.Enabled = true;
                clientTypeGroupCheckBox.Enabled = true;

            }
        }

       
    }
}
