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
using System.Globalization;

namespace OpenCBS.GUI.Products
{
    public partial class FrmAddCurrentAccountProduct : SweetBaseForm
    {
        ICurrentAccountProduct _currentAccountProduct = null;
        CurrentAccountTransactionFees _currentAccountTransactionFees = null;

        public FrmAddCurrentAccountProduct()
        {
           
            InitializeComponent();
            InitializeComboBoxCurrencies();
           

           
        }

        public FrmAddCurrentAccountProduct(int productId,bool enabled)
        {
            InitializeComponent();
            InitializeComboBoxCurrencies();

            if (enabled == true)
            {
                btnUpdate.Visible = true;
                btnCurrentAccountProduct.Visible = false;
                btnUpdateTran.Visible = true;
                btnSaveTranFee.Visible = false;
            }
            else
            {
                btnUpdateTran.Visible = false;
                btnSaveTranFee.Visible = false;
            }

              CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
              _currentAccountProduct = _currentAccountProductService.FetchProduct(productId);


          
            cbCurrency.SelectedItem = _currentAccountProduct.Currency;
            bool clientTypeCorp = clientTypeCorpCheckBox.Checked;
            bool clientTypeIndiv = clientTypeIndivCheckBox.Checked;
            bool clientTypeVillage = clientTypeVillageCheckBox.Checked;
            bool clientTypeGroup = clientTypeGroupCheckBox.Checked;
            bool clientTypeAll = clientTypeAllCheckBox.Checked;
            tbCodeCurrentAccountProduct.Text = _currentAccountProduct.CurrentAccountProductCode;
            tbName.Text = _currentAccountProduct.CurrentAccountProductName;
            

            if(_currentAccountProduct.EntryFeesType == "Flat")
            {
               rbFlatEntryFees.Checked = true;

            }
            else
            {
               rbRateEntryFees.Checked = false;
   
            }

            if(_currentAccountProduct.ReopenFeesType == "Flat")
            {
               rbFlatReopenFees.Checked = true;
            }
            else
            {
               rbRateReopenFees.Checked = true;

            }

            if(_currentAccountProduct.ClosingFeesType == "Flat")
            {
            rbFlatCloseFees.Checked = true;
            }
            else
            {
            rbFlatCloseFees.Checked = true;
            }

            if(_currentAccountProduct.ManagementFeesType == "Flat")
            {
               rbFlatManagementFees.Checked = true ;
            }
            else
            {
               rbRateManagementFees.Checked = true ;
            }

            if(_currentAccountProduct.OverdraftType == "Flat")
            {
            rbFlatOverdraftFees.Checked = true;
            }
            else
            {
            rbRateOverdraftFees.Checked = true;
            }
            cbManagementFeeFreq.SelectedItem = _currentAccountProduct.ManagementFeesFrequency;
            tbInitialAmountMin.Text = _currentAccountProduct.InitialAmountMin.ToString();
            tbInitialAmountMax.Text =_currentAccountProduct.InitialAmountMax.ToString();
            tbBalanceMin.Text =_currentAccountProduct.BalanceMin.ToString();
            tbBalanceMax.Text =_currentAccountProduct.BalanceMax.ToString();
            tbEntryFeesMin.Text =_currentAccountProduct.EntryFeesMin.ToString();
            tbEntryFeesMax.Text =_currentAccountProduct.EntryFeesMax.ToString();
            tbReopenFeesMin.Text =_currentAccountProduct.ReopenFeesMin.ToString();
            tbReopenFeesMax.Text =_currentAccountProduct.ReopenFeesMax.ToString();
            tbCloseFeesMin.Text =_currentAccountProduct.ClosingFeesMin.ToString();
            tbCloseFeesMax.Text =_currentAccountProduct.ClosingFeesMax.ToString();
            tbManagementFeesMin.Text =_currentAccountProduct.ManagementFeesMin.ToString();
            tbManagementFeesMax.Text =_currentAccountProduct.ManagementFeesMax.ToString();
            tbOverdraftFeesMin.Text =_currentAccountProduct.OverdraftMin.ToString();
            tbOverdraftFeesMax.Text =_currentAccountProduct.OverdraftMax.ToString();
            tbEntryFees.Text =_currentAccountProduct.EntryFeesValue.ToString();
            tbReopenFees.Text =_currentAccountProduct.ReopenFeesValue.ToString();
            tbCloseFees.Text =_currentAccountProduct.ClosingFeesValue.ToString();
            tbManagementFees.Text =_currentAccountProduct.ManagementFeesValue.ToString();

            tbOverdraftFees.Text =_currentAccountProduct.OverdraftValue.ToString();

            tbInterestRateMin.Text = _currentAccountProduct.InterestMin.ToString();
            tbInterestRateMax.Text = _currentAccountProduct.InterestMax.ToString();
            tbInterestValue.Text = _currentAccountProduct.InterestValue.ToString();
            tbInterestCalculationFrequency.Text = _currentAccountProduct.InterestFrequency.ToString();
            tbOverdraftLimit.Text = _currentAccountProduct.OverdraftLimit.ToString();

            string[] clientType = _currentAccountProduct.ClientType.Split(',');

            if (clientType[0] == "All")
                clientTypeAllCheckBox.Checked = true;
            else
            {
                for (int i = 0; i < clientType.Length; i++)
                {
                    if (clientType[i] == "Corporate")
                        clientTypeCorpCheckBox.Checked = true;
                    if (clientType[i] == "Person")
                        clientTypeIndivCheckBox.Checked = true;
                    if (clientType[i] == "Village")
                        clientTypeVillageCheckBox.Checked = true;
                    if (clientType[i] == "Group")
                        clientTypeGroupCheckBox.Checked = true;
                }

            }

            CurrentAccountControl(enabled);
            tbCodeCurrentAccountProduct.Enabled = false;
            tbName.Enabled = false;

            cbTransactionType.Enabled = true;
            rbCredit.Enabled = true;
            rbDebit.Enabled = true;

        }

            void CurrentAccountControl(bool enabled)
            {
            cbCurrency.Enabled = enabled;
            clientTypeCorpCheckBox.Enabled = enabled;
            clientTypeIndivCheckBox.Enabled = enabled;
            clientTypeVillageCheckBox.Enabled = enabled;
            clientTypeGroupCheckBox.Enabled = enabled;
            clientTypeAllCheckBox.Enabled = enabled;
            tbCodeCurrentAccountProduct.Enabled = enabled;
            tbName.Enabled = enabled;
            rbFlatEntryFees.Enabled = enabled;
            rbRateEntryFees.Enabled = enabled;
            rbFlatReopenFees.Enabled = enabled;
            rbRateReopenFees.Enabled = enabled;
            rbFlatCloseFees.Enabled = enabled;
            rbRateCloseFees.Enabled = enabled;
            rbFlatManagementFees.Enabled = enabled;
            rbRateManagementFees.Enabled = enabled;
            rbFlatOverdraftFees.Enabled = enabled;
            rbRateOverdraftFees.Enabled = enabled;
            cbManagementFeeFreq.Enabled = enabled;
            tbInitialAmountMin.Enabled = enabled;
            tbInitialAmountMax.Enabled = enabled;
            tbBalanceMin.Enabled = enabled;
            tbBalanceMax.Enabled = enabled;
            tbEntryFeesMin.Enabled = enabled;
            tbEntryFeesMax.Enabled = enabled;
            tbReopenFeesMin.Enabled = enabled;
            tbReopenFeesMax.Enabled = enabled;
            tbCloseFeesMin.Enabled = enabled;
            tbCloseFeesMax.Enabled = enabled;
            tbManagementFeesMin.Enabled = enabled;
            tbManagementFeesMax.Enabled = enabled;
            tbOverdraftFeesMin.Enabled = enabled;
            tbOverdraftFeesMax.Enabled = enabled;
            tbEntryFees.Enabled = enabled;
            tbReopenFees.Enabled = enabled;
            tbCloseFees.Enabled = enabled;
            tbManagementFees.Enabled = enabled;
            tbOverdraftFees.Enabled = enabled;

            tbInterestRateMin.Enabled = enabled;
            tbInterestRateMax.Enabled = enabled;
            tbInterestValue.Enabled = enabled;
            tbInterestCalculationFrequency.Enabled = enabled;
            tbOverdraftLimit.Enabled = enabled;

            cbTransactionType.Enabled = enabled;
            rbTranFeeFlat.Enabled = enabled;
            rbTranFeeRate.Enabled = enabled;
            tbTranFeeValue.Enabled = enabled;
            tbTranFeeMin.Enabled = enabled;
            tbTranFeeMax.Enabled = enabled;
            
            btnSaveTranFee.Enabled = enabled;
            rbCredit.Enabled = enabled;
            rbDebit.Enabled = enabled;

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

        void InitializeCurrentAccountProduct()
        {
            string Currency = cbCurrency.SelectedItem.ToString();
            bool clientTypeCorp = clientTypeCorpCheckBox.Checked;
            bool clientTypeIndiv = clientTypeIndivCheckBox.Checked;
            bool clientTypeVillage = clientTypeVillageCheckBox.Checked;
            bool clientTypeGroup = clientTypeGroupCheckBox.Checked;
            bool clientTypeAll = clientTypeAllCheckBox.Checked;
            string CodeFixedDepositProduct ="";
            if (_currentAccountProduct.Id != 0)
                CodeFixedDepositProduct = tbCodeCurrentAccountProduct.Text;
            else
                CodeFixedDepositProduct = tbCodeCurrentAccountProduct.Text + "-CA";
            string Name = tbName.Text;

            string clientType = "";

            if (clientTypeAll == true)
                clientType = "All";
            else
            {
                if (clientTypeCorp == true)
                    clientType = clientType + "Corporate,";
                if (clientTypeIndiv == true)
                    clientType = clientType + "Person,";
                if (clientTypeVillage == true)
                    clientType = clientType + "Village,";
                if (clientTypeGroup == true)
                    clientType = clientType + "Group,";
                clientType = clientType.Substring(0, clientType.Length - 1);
            }



            if (rbFlatEntryFees.Checked)
            {
                _currentAccountProduct.EntryFeesType = "Flat";
            }
            else
            {
                _currentAccountProduct.EntryFeesType = "Rate";
            }
            if (rbFlatReopenFees.Checked)
            {
                _currentAccountProduct.ReopenFeesType = "Flat";
            }
            else
            {
                _currentAccountProduct.ReopenFeesType = "Rate";
            }
            if (rbFlatCloseFees.Checked)
            {
                _currentAccountProduct.ClosingFeesType = "Flat";
            }
            else
            {
                _currentAccountProduct.ClosingFeesType = "Rate";
            }
            if (rbFlatManagementFees.Checked)
            {
                _currentAccountProduct.ManagementFeesType = "Flat";
            }
            else
            {
                _currentAccountProduct.ManagementFeesType = "Rate";
            }
            if (rbFlatOverdraftFees.Checked)
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

            _currentAccountProduct.InterestMin = Convert.ToDouble(tbInterestRateMin.Text);
            _currentAccountProduct.InterestMax = Convert.ToDouble(tbInterestRateMax.Text);
            _currentAccountProduct.InterestValue = Convert.ToDouble(tbInterestValue.Text);
            _currentAccountProduct.InterestFrequency = Convert.ToInt32(tbInterestCalculationFrequency.Text);
            _currentAccountProduct.OverdraftLimit = Convert.ToDecimal(tbOverdraftLimit.Text);
            _currentAccountProduct.InterestType = "Rate";
        }


        private void btSavingProduct_Click(object sender, EventArgs e)
        {

            try
            {
                _currentAccountProduct = new CurrentAccountProduct();

                InitializeCurrentAccountProduct();

                CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
                int ret = _currentAccountProductService.SaveCurrentAccountProduct(_currentAccountProduct);

                if (ret >= 1)
                    MessageBox.Show("Current Account Product Successfully Added.");

                tabControlSaving.TabPages.Remove(tabPageTransactions);
                tabControlSaving.TabPages.Add(tabPageTransactions);
                tabControlSaving.SelectedTab = tabPageTransactions;

                _currentAccountTransactionFees = new CurrentAccountTransactionFees();
                _currentAccountTransactionFees.CurrentAccountProductId = ret;
            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InitializeCurrentAccountProduct();

            CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
            _currentAccountProductService.UpdateCurrentAccountProduct(_currentAccountProduct, _currentAccountProduct.Id);
            MessageBox.Show("Current Account Product Successfully Updated.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void InitializeCurrentAccountTransactionFees()
        {
            _currentAccountTransactionFees.TransactionType = cbTransactionType.SelectedItem.ToString();
            if(rbTranFeeFlat.Checked == true)
            _currentAccountTransactionFees.TransactionFeesType = "Flat";
            else
                _currentAccountTransactionFees.TransactionFeesType = "Rate";
            if(rbCredit.Checked == true)
                _currentAccountTransactionFees.TransactionMode = "Credit";
            else
                _currentAccountTransactionFees.TransactionMode = "Debit";
            _currentAccountTransactionFees.TransactionFees = Convert.ToDecimal(tbTranFeeValue.Text);
            _currentAccountTransactionFees.TransactionFeeMin = Convert.ToDecimal(tbTranFeeMin.Text);
            _currentAccountTransactionFees.TransactionFeeMax = Convert.ToDecimal(tbTranFeeMax.Text);
            
        }


        private void btnSaveTranFee_Click(object sender, EventArgs e)
        {
            
            InitializeCurrentAccountTransactionFees();


            CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
            int ret = _currentAccountProductService.SaveCurrentAccountTransactionFees(_currentAccountTransactionFees);

            if (ret >= 1)
                MessageBox.Show("Transaction Fee Successfully Specified.");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string transactionType = cbTransactionType.SelectedItem.ToString();
            string transactionMode = "";
              if(rbCredit.Checked == true)
                transactionMode = "Credit";
            else
                transactionMode = "Debit";
            


            CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
            _currentAccountTransactionFees =_currentAccountProductService.FetchTransaction(transactionType, transactionMode, _currentAccountProduct.Id);

            if (_currentAccountTransactionFees != null)
            {
                if (_currentAccountTransactionFees.TransactionFeesType == "Flat")
                    rbTranFeeFlat.Checked = true;
                else
                    rbTranFeeRate.Checked = true;



                tbTranFeeValue.Text = _currentAccountTransactionFees.TransactionFees.ToString();
                tbTranFeeMin.Text = _currentAccountTransactionFees.TransactionFeeMin.ToString();
                tbTranFeeMax.Text = _currentAccountTransactionFees.TransactionFeeMax.ToString();
            }
             

        }

        private void btnUpdateTran_Click(object sender, EventArgs e)
        {
          
            InitializeCurrentAccountTransactionFees();


            CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
            _currentAccountProductService.UpdateCurrentAccountTransactionFees(_currentAccountTransactionFees, _currentAccountTransactionFees.TransactionFeesType, _currentAccountTransactionFees.TransactionMode, _currentAccountTransactionFees.CurrentAccountProductId);

           
                MessageBox.Show("Transaction Fee Successfully Updated.");


        }

        private void tbInitialAmountMin_TextChanged(object sender, EventArgs e)
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
                (e.KeyChar.ToString() == NumberFormatInfo.CurrentInfo.NumberDecimalSeparator))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void tbInitialAmountMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbInitialAmountMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbBalanceMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbBalanceMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbInterestRateMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbInterestRateMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbInterestValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbInterestCalculationFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbOverdraftFeesMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbOverdraftFeesMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbOverdraftFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbOverdraftLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbEntryFeesMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void tbTranFeeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

       
    }
}
