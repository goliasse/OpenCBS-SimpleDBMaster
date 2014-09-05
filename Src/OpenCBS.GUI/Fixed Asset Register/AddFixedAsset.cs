using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.Enums;
using OpenCBS.Services;
using OpenCBS.CoreDomain;

namespace OpenCBS.GUI.FixedAssetRegister
{
    public partial class AddFixedAsset : Form
    {
        public AddFixedAsset()
        {
            InitializeComponent();
            InitializeBranch();
            InitializeFixedAssetStatus();
            InitializeFixedAssetType();
            InitializeFinanceMethod(cmbAcqCapFinMethod);
            InitializeFinanceMethod(cmbDisAmtTranMethod);
            txtAcquisitionDate.Text = DateTime.Today.ToShortDateString();
        }

        OpenCBS.CoreDomain.FixedAssetRegister fixedAssetRegister = null;
        public AddFixedAsset(string assetId, bool flag)
        {
            InitializeComponent();
            InitializeBranch();
            InitializeFixedAssetStatus();
            InitializeFixedAssetType();
            InitializeFinanceMethod(cmbAcqCapFinMethod);
            InitializeFinanceMethod(cmbDisAmtTranMethod);
            InitializeControls(flag);

            FixedAssetRegisterService _fixedAssetRegisterService = ServicesProvider.GetInstance().GetFixedAssetRegisterService();
            fixedAssetRegister = _fixedAssetRegisterService.FetchFixedAssetRecord(assetId);

            txtAssetDescription.Text  = fixedAssetRegister.Description;
            cmbBranch.SelectedItem =  fixedAssetRegister.Branch;
            cmbAssetType.SelectedItem  = fixedAssetRegister.AssetType ;
            txtNoOfAssets.Text  = fixedAssetRegister.NoOfAssets.ToString();
            txtOriginalCost.Text = fixedAssetRegister.OriginalCost.GetFormatedValue(false);
            txtDepreciationRate.Text  = fixedAssetRegister.AnnualDepreciationRate.Value.ToString();
            cmbAcqCapFinMethod.SelectedItem  = fixedAssetRegister.AcquisitionCapitalFinance;
            txtAcqCapTranNum.Text  = fixedAssetRegister.AcquisitionCapitalTransaction;
            txtDisAmtTranNum.Text  = fixedAssetRegister.DisposalAmountTransaction;
            cmbDisAmtTranMethod.SelectedItem  =fixedAssetRegister.DisposalAmountTransfer;
            
            txtAcquisitionDate.Text  = fixedAssetRegister.AcquisitionDate.ToShortDateString();
            txtDisDate.Text = DateTime.Today.ToShortDateString();
            int depChargePerAsset = CalculateAccumulatedDepriciation(fixedAssetRegister.AnnualDepreciationRate.Value, 
            fixedAssetRegister.OriginalCost.Value, fixedAssetRegister.AcquisitionDate, DateTime.Today);
            txtAccDepCharge.Text = depChargePerAsset.ToString();
            txtNetBookValue.Text = ((fixedAssetRegister.OriginalCost.Value - depChargePerAsset)*fixedAssetRegister.NoOfAssets).ToString();

            if (depChargePerAsset > 0)
                txtProfitLoss.Text = "Loss";
            if (depChargePerAsset < 0 )
                txtProfitLoss.Text = "Profit";
            if (depChargePerAsset == 0)
                txtProfitLoss.Text = "No Profit No Loss";
        }

        private void InitializeControls(bool flag)
        {
            lblDisAmtTransMethod.Visible = flag;
            cmbDisAmtTranMethod.Visible = flag;
            lblDisAmtTran.Visible = flag;
            txtDisAmtTranNum.Visible = flag;
            btnSubmit.Visible = !flag;
            btnUpdate.Visible = flag;
            lblDisDate.Visible = flag;
            txtDisDate.Visible = flag;
            lblNetBookValue.Visible = flag;
            txtNetBookValue.Visible = flag;
            lblAccDepCharge.Visible = flag;
            txtAccDepCharge.Visible = flag;
            txtProfitLoss.Visible = flag;
            lblProfitLoss.Visible = flag;

        }

        private void InitializeFinanceMethod(ComboBox cmbFinMethod)
        {
            cmbFinMethod.Items.Clear();
            cmbFinMethod.Items.Add(OFixedAssetRegister.SelectFinanceMethodDefault);
            cmbFinMethod.Items.Add(OFixedAssetRegister.FinanceMethodDeCash);
            cmbFinMethod.Items.Add(OFixedAssetRegister.FinanceMethodDeCheque);
            cmbFinMethod.Items.Add(OFixedAssetRegister.FinanceMethodDeTransfer);
            cmbFinMethod.SelectedIndex = 0;

        }

        private void InitializeFixedAssetStatus()
        {
           
           
        }

        private void InitializeFixedAssetType()
        {
            cmbAssetType.Items.Clear();
            cmbAssetType.Items.Add(OFixedAssetRegister.SelectAssetTypeDefault);
            cmbAssetType.Items.Add("Computer");
            cmbAssetType.Items.Add("Furniture");
            cmbAssetType.Items.Add("Fittings");
            cmbAssetType.Items.Add("Renovation works");
            cmbAssetType.Items.Add("Building and land lease");
            cmbAssetType.SelectedIndex = 0;
        }

        private void InitializeBranch()
        {
            cmbBranch.ValueMember = "Code";
            cmbBranch.DisplayMember = "Name";
            cmbBranch.DataSource =
                ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted().OrderBy(item => item.Id).ToList();
        }

        private void lblAmount_Click(object sender, EventArgs e)
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
                (e.KeyChar.ToString() == System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtNoOfAssets_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            OpenCBS.CoreDomain.FixedAssetRegister fixedAssetRegister = new OpenCBS.CoreDomain.FixedAssetRegister();
            fixedAssetRegister.Description = txtAssetDescription.Text;
            fixedAssetRegister.Branch = cmbBranch.SelectedValue.ToString();
            fixedAssetRegister.AssetType = cmbAssetType.SelectedItem.ToString();
            fixedAssetRegister.NoOfAssets = ServicesHelper.ConvertStringToNullableInt32(txtNoOfAssets.Text);
            fixedAssetRegister.OriginalCost = ServicesHelper.ConvertStringToNullableDecimal(txtOriginalCost.Text);
            fixedAssetRegister.AnnualDepreciationRate = ServicesHelper.ConvertStringToNullableDouble(txtDepreciationRate.Text, false);
            fixedAssetRegister.AcquisitionCapitalFinance = cmbAcqCapFinMethod.SelectedItem.ToString();
            fixedAssetRegister.AcquisitionCapitalTransaction = txtAcqCapTranNum.Text;
            //fixedAssetRegister.DisposalAmountTransaction = txtDisAmtTranNum.Text;
            //fixedAssetRegister.DisposalAmountTransfer = cmbDisAmtTranMethod.SelectedItem.ToString();

            fixedAssetRegister.AcquisitionDate = DateTime.Today;
            fixedAssetRegister.DisposalDate = DateTime.MaxValue;

            FixedAssetRegisterService _fixedAssetRegisterService = ServicesProvider.GetInstance().GetFixedAssetRegisterService();

            int ret = _fixedAssetRegisterService.InsertFixedAssetRecord(fixedAssetRegister);

            if(ret >= 1)
                MessageBox.Show("Fixed Asset Added Successfully.");
            else
                MessageBox.Show("Some error ocurred.");

        }

        static int CalculateAccumulatedDepriciation(double depreciationRate, decimal originalCost, DateTime acquiredDate, DateTime disposalDate)
        {
            double days = disposalDate.Subtract(acquiredDate).TotalDays;
            int totalDepreciation = (int)((double)originalCost * depreciationRate * days) / (100 * 360);
            return totalDepreciation;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            fixedAssetRegister.Description = txtAssetDescription.Text;
            fixedAssetRegister.Branch = cmbBranch.SelectedValue.ToString();
            fixedAssetRegister.AssetType = cmbAssetType.SelectedItem.ToString();
            fixedAssetRegister.NoOfAssets = ServicesHelper.ConvertStringToNullableInt32(txtNoOfAssets.Text);
            fixedAssetRegister.OriginalCost = ServicesHelper.ConvertStringToNullableDecimal(txtOriginalCost.Text);
            fixedAssetRegister.AnnualDepreciationRate = ServicesHelper.ConvertStringToNullableDouble(txtDepreciationRate.Text, false);
            fixedAssetRegister.AcquisitionCapitalFinance = cmbAcqCapFinMethod.SelectedItem.ToString();
            fixedAssetRegister.AcquisitionCapitalTransaction = txtAcqCapTranNum.Text;
            fixedAssetRegister.DisposalAmountTransaction = txtDisAmtTranNum.Text;
            fixedAssetRegister.DisposalAmountTransfer = cmbDisAmtTranMethod.SelectedItem.ToString();

            //Need to update
            fixedAssetRegister.AcquisitionDate = DateTime.Today;
            //Need to update
            fixedAssetRegister.DisposalDate = DateTime.Today;
            int depChargePerAsset = CalculateAccumulatedDepriciation(fixedAssetRegister.AnnualDepreciationRate.Value,
           fixedAssetRegister.OriginalCost.Value, fixedAssetRegister.AcquisitionDate, fixedAssetRegister.DisposalDate);
            fixedAssetRegister.NetBookValue = depChargePerAsset;
            fixedAssetRegister.AccumulatedDepreciationCharge = ((fixedAssetRegister.OriginalCost.Value - depChargePerAsset) * fixedAssetRegister.NoOfAssets);
            string ProfitLoss=  txtProfitLoss.Text.ToString();

            if (ProfitLoss == "Loss")
                fixedAssetRegister.ProfitLossDisposal = -1;
            if (ProfitLoss == "Profit")
                fixedAssetRegister.ProfitLossDisposal = 1;
            if (ProfitLoss == "No Profit No Loss")
                fixedAssetRegister.ProfitLossDisposal = 0;
            

            FixedAssetRegisterService _fixedAssetRegisterService = ServicesProvider.GetInstance().GetFixedAssetRegisterService();

            int ret = _fixedAssetRegisterService.UpdateFixedAssetRegister(fixedAssetRegister);

            if (ret >= 1)
                MessageBox.Show("Fixed Asset Updated Successfully.");
            else
                MessageBox.Show("Some error ocurred.");
        }

        private void txtDisDate_TextChanged(object sender, EventArgs e)
        {
            //Need to update Disposal Date
            int depChargePerAsset = CalculateAccumulatedDepriciation(fixedAssetRegister.AnnualDepreciationRate.Value,
            fixedAssetRegister.OriginalCost.Value, fixedAssetRegister.AcquisitionDate, DateTime.Today);
            txtAccDepCharge.Text = depChargePerAsset.ToString();
            txtNetBookValue.Text = ((fixedAssetRegister.OriginalCost.Value - depChargePerAsset) * fixedAssetRegister.NoOfAssets).ToString();
        }
    }
}
