using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenCBS.GUI.UserControl;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.CoreDomain.Products;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Services;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Enums;

namespace OpenCBS.GUI.Products
{
    public partial class FrmAddFixedDepositProduct : SweetBaseForm
    {


        private IFixedDepositProduct _fixedDepositProduct;

        public FrmAddFixedDepositProduct()
        {
            InitializeComponent();
            InitializeComboBoxCurrencies();
            InitializeInterestCalculationFrequency();
        }



        public FrmAddFixedDepositProduct(int productId, bool enabled)
        {
            InitializeComponent();
            InitializeComboBoxCurrencies();
            InitializeInterestCalculationFrequency();


            if (enabled == true)
            {
                btnUpdate.Visible = true;
                btnSave.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
            }

            FixedDepositProductService _fixedDepositProductService = ServicesProvider.GetInstance().GetFixedDepositProductService();
            _fixedDepositProduct = _fixedDepositProductService.FetchProduct(productId);
            tbFrequencyMonths.Text = _fixedDepositProduct.InterestCalculationFrequency;
            
           
            cbCurrency.SelectedItem = _fixedDepositProduct.Currency.Name;
            
            tbCodeFixedDepositProduct.Text = _fixedDepositProduct.Code;
            tbName.Text = _fixedDepositProduct.Name;
            tbInitialAmountMax.Text = _fixedDepositProduct.InitialAmountMax.GetFormatedValue(true);
            tbInitialAmountMin.Text = _fixedDepositProduct.InitialAmountMin.GetFormatedValue(true);
            tbInterestRateMax.Text = _fixedDepositProduct.InterestRateMax.ToString();
            tbInterestRateMin.Text = _fixedDepositProduct.InterestRateMin.ToString();
            if (_fixedDepositProduct.PenalityValue.HasValue)
            {
                tbPenaltyValue.Text = _fixedDepositProduct.PenalityValue.ToString();
            }
            else
            {
                tbPenalityMax.Text = _fixedDepositProduct.PenalityRateMax.ToString();
                tbPenalityMin.Text = _fixedDepositProduct.PenalityRateMin.ToString();
            }
            tbMinMaturityPeriod.Text = _fixedDepositProduct.MaturityPeriodMin.ToString();
            tbMaxMaturityPeriod.Text = _fixedDepositProduct.MaturityPeriodMax.ToString();

            if (_fixedDepositProduct.PenalityType == "Rate")
                rbPenalityTypeRate.Checked = true;
            else
                rbPenalityTypeFlat.Checked = false;


            string []clientType = _fixedDepositProduct.ClientType.Split(',');

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
            
            
            
            FixedDepositControl(enabled);
            tbCodeFixedDepositProduct.Enabled = false;
            tbName.Enabled = false;
        }


        void FixedDepositControl(bool enabled)
        {
            tbFrequencyMonths.Enabled = enabled;
            cbCurrency.Enabled = enabled;
            tbCodeFixedDepositProduct.Enabled = enabled;
            tbName.Enabled = enabled;
            tbInitialAmountMax.Enabled = enabled;
            tbInitialAmountMin.Enabled = enabled;
            tbInterestRateMax.Enabled = enabled;
            tbInterestRateMin.Enabled = enabled;
            tbPenalityMax.Enabled = enabled;
            tbPenalityMin.Enabled = enabled;
            tbMinMaturityPeriod.Enabled = enabled;
            tbMaxMaturityPeriod.Enabled = enabled;
            rbPenalityTypeRate.Enabled = enabled;
            rbPenalityTypeFlat.Enabled = enabled;

            clientTypeCorpCheckBox.Enabled = enabled;
            clientTypeIndivCheckBox.Enabled = enabled;
            clientTypeVillageCheckBox.Enabled = enabled;
            clientTypeGroupCheckBox.Enabled = enabled;
            clientTypeAllCheckBox.Enabled = enabled;
            tbPenaltyValue.Enabled = enabled;
        }

        private void lbCalculAmount_Click(object sender, EventArgs e)
        {

        }

        private void InitializeInterestCalculationFrequency()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try{

            _fixedDepositProduct = new FixedDepositProduct();
            InitializeFixedDepositProduct();
            FixedDepositProductService _fixedDepositProductService = ServicesProvider.GetInstance().GetFixedDepositProductService();
           int ret = _fixedDepositProductService.SaveFixedDepositProduct(_fixedDepositProduct);
           if (ret >= 1)
               MessageBox.Show("Fixed Deposit Product Successfully Added.");

             }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
        }

        void InitializeFixedDepositProduct()
        {
            string InterestCalculationFrequency = tbFrequencyMonths.Text;
            
            bool clientTypeCorp = clientTypeCorpCheckBox.Checked;
            bool clientTypeIndiv = clientTypeIndivCheckBox.Checked;
            bool clientTypeVillage = clientTypeVillageCheckBox.Checked;
            bool clientTypeGroup = clientTypeGroupCheckBox.Checked;
            bool clientTypeAll = clientTypeAllCheckBox.Checked;
            string CodeFixedDepositProduct = "";
            if(_fixedDepositProduct.Id!=0)
                CodeFixedDepositProduct =  tbCodeFixedDepositProduct.Text;
            else
                CodeFixedDepositProduct = tbCodeFixedDepositProduct.Text + "-FD";
            string Name = tbName.Text;
            
            decimal? InitialAmountMax = ServicesHelper.ConvertStringToNullableDecimal(tbInitialAmountMax.Text);
            decimal? InitialAmountMin = ServicesHelper.ConvertStringToNullableDecimal(tbInitialAmountMin.Text);
            double? InterestRateMax = ServicesHelper.ConvertStringToNullableDouble(tbInterestRateMax.Text, false);
            double? InterestRateMin = ServicesHelper.ConvertStringToNullableDouble(tbInterestRateMin.Text, false);
            bool PenalityTypeRate = rbPenalityTypeRate.Checked;
            bool PenalityTypeFlat = rbPenalityTypeFlat.Checked;
            double? PenalityMax = ServicesHelper.ConvertStringToNullableDouble(tbPenalityMax.Text, false);
            double? PenalityMin = ServicesHelper.ConvertStringToNullableDouble(tbPenalityMin.Text, false);
            int? MaturityPeriodMin = ServicesHelper.ConvertStringToNullableInt32(tbMinMaturityPeriod.Text);
            int? MaturityPeriodMax = ServicesHelper.ConvertStringToNullableInt32(tbMaxMaturityPeriod.Text);
            
            _fixedDepositProduct.InterestCalculationFrequency = InterestCalculationFrequency;
            List<Currency> currencies = ServicesProvider.GetInstance().GetCurrencyServices().FindAllCurrencies();
            foreach (Currency cur in currencies)
            {
                if ((cbCurrency.SelectedItem.ToString() == cur.Name) && (cbCurrency.SelectedItem.ToString() != OCurrentAccount.SelectCurrencyDefault))
                    _fixedDepositProduct.Currency = cur;

            }
            _fixedDepositProduct.Code = CodeFixedDepositProduct;
            _fixedDepositProduct.Name = Name;
            _fixedDepositProduct.InitialAmountMax = InitialAmountMax;
            _fixedDepositProduct.InitialAmountMin = InitialAmountMin;
            _fixedDepositProduct.InterestRateMax = InterestRateMax;
            _fixedDepositProduct.InterestRateMin = InterestRateMin;
            _fixedDepositProduct.PenalityRateMax = PenalityMax;
            _fixedDepositProduct.PenalityRateMin = PenalityMin;
            _fixedDepositProduct.PenalityValue = ServicesHelper.ConvertStringToNullableDouble(tbPenaltyValue.Text, false);

            if (PenalityTypeRate == true)
                _fixedDepositProduct.PenalityType = "Rate";
            else
                _fixedDepositProduct.PenalityType = "Flat";

            _fixedDepositProduct.MaturityPeriodMin = MaturityPeriodMin;
            _fixedDepositProduct.MaturityPeriodMax = MaturityPeriodMax;



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


                if (clientType.Length > 0)
                clientType = clientType.Substring(0, clientType.Length - 1);
            }


            _fixedDepositProduct.ClientType = clientType;

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

        private void rbPenalityTypeFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPenalityTypeFlat.Checked == true)
            {
                rbPenalityTypeRate.Checked = false;
            }
            else
            {
                rbPenalityTypeRate.Checked = true;
            }
        }

        private void rbPenalityTypeRate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPenalityTypeRate.Checked == true)
            {
                rbPenalityTypeFlat.Checked = false;
            }
            else
            {
                rbPenalityTypeFlat.Checked = true;
            }
        }


        

        private void clientTypeGroupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabControlSaving_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageMainParameters_Click(object sender, EventArgs e)
        {

        }

        private void lbNameSavingProduct_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbMaxMaturityPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMinMaturityPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPenalityMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPenalityMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbFrequency_Enter(object sender, EventArgs e)
        {

        }

        private void lbAccrual_Click(object sender, EventArgs e)
        {

        }

        private void cbInterestCalculationFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxCurrency_Enter(object sender, EventArgs e)
        {

        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCodeSavingProduct_Click(object sender, EventArgs e)
        {

        }

        private void gbClientType_Enter(object sender, EventArgs e)
        {

        }

        private void clientTypeCorpCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clientTypeIndivCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clientTypeVillageCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clientTypeGroupCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void tbCodeFixedDepositProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbInitialAmount_Enter(object sender, EventArgs e)
        {

        }

        private void tbInitialAmountMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInitialAmountMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbInitialAmonutMax_Click(object sender, EventArgs e)
        {

        }

        private void lbInitialAmountMin_Click(object sender, EventArgs e)
        {

        }

        private void gbInterestRate_Enter(object sender, EventArgs e)
        {

        }

        private void lbYearlyInterestRateMax_Click(object sender, EventArgs e)
        {

        }

        private void lbYearlyInterestRateMin_Click(object sender, EventArgs e)
        {

        }

        private void tbInterestRateMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInterestRateMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbInterestRateMax_Click(object sender, EventArgs e)
        {

        }

        private void lbInterestRateMin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btSavingProduct_Click(object sender, EventArgs e)
        {

        }

        private void bClose_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try{
            InitializeFixedDepositProduct();

            FixedDepositProductService _fixedDepositProductService = ServicesProvider.GetInstance().GetFixedDepositProductService();
            _fixedDepositProductService.UpdateFixedDepositProduct(_fixedDepositProduct, _fixedDepositProduct.Id);
            
                MessageBox.Show("Fixed Deposit Product Successfully Updated.");
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

        private void tbInitialAmountMin_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }
    }
}
