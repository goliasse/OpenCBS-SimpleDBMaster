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
        }

        public AddFixedAsset(string assetId, bool flag)
        {
            InitializeComponent();
            InitializeBranch();
            InitializeFixedAssetStatus();
            InitializeFixedAssetType();
            InitializeFinanceMethod(cmbAcqCapFinMethod);
            InitializeFinanceMethod(cmbDisAmtTranMethod);
        }


        private void InitializeFinanceMethod(ComboBox cmbFinMethod)
        {
            cmbFinMethod.Items.Clear();
            cmbFinMethod.Items.Add(OFixedAssetRegister.SelectFinanceMethodDefault);
            cmbFinMethod.Items.Add(OFixedAssetRegister.FinanceMethodDeCash);
            cmbFinMethod.Items.Add(OFixedAssetRegister.FinanceMethodDeCheque);
            cmbFinMethod.Items.Add(OFixedAssetRegister.FinanceMethodDeTransfer);
            

        }

        private void InitializeFixedAssetStatus()
        {
            cmbAssetStatus.Items.Clear();
            cmbAssetStatus.Items.Add(OFixedAssetRegister.SelectAssetTypeDefault);
            cmbAssetStatus.Items.Add("Computer");
            cmbAssetStatus.Items.Add("Furniture");
            cmbAssetStatus.Items.Add("Fittings");
            cmbAssetStatus.Items.Add("Renovation works");
            cmbAssetStatus.Items.Add("Building and land lease");
           
        }

        private void InitializeFixedAssetType()
        {
            cmbAssetType.Items.Clear();
            cmbAssetType.Items.Add(OFixedAssetRegister.SelectFixedAssetStatus);
            cmbAssetType.Items.Add(OFixedAssetRegister.FixedAssetAcquiredStatus);
            cmbAssetType.Items.Add(OFixedAssetRegister.FixedAssetDisposedStatus);
        }

        private void InitializeBranch()
        {
            cmbBranch.ValueMember = "Name";
            cmbBranch.DisplayMember = "";
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

        }
    }
}
