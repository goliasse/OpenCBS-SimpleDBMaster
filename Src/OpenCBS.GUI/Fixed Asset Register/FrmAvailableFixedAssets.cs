using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.GUI.UserControl;


using System.IO;

using OpenCBS.CoreDomain.Products;
using OpenCBS.Enums;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Services;
using System.Security.Permissions;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Shared.Settings;
using OpenCBS.CoreDomain;



namespace OpenCBS.GUI.FixedAssetRegister
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FrmAvailableFixedAssets : Form
    {
        
        
        public FrmAvailableFixedAssets()
        {
            
            InitializeComponent();
            
            InitializeFixedAssetList(false);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void InitializeFixedAssetList(bool showAsDeleted)
        {
            lvFixedAsset.Items.Clear();
            FixedAssetRegisterService _fixedAssetRegisterService = ServicesProvider.GetInstance().GetFixedAssetRegisterService();
            List<OpenCBS.CoreDomain.FixedAssetRegister> fixedAssetList = _fixedAssetRegisterService.FetchFixedAssetRegister("Default");
            if (fixedAssetList != null)
            {
                foreach (OpenCBS.CoreDomain.FixedAssetRegister fixedAsset in fixedAssetList)
                {
                    string status = "";
                    DateTime disposalDate = fixedAsset.DisposalDate.AddSeconds(-1).AddDays(1);
                    int  days = (int)disposalDate.Subtract(DateTime.MaxValue.Date).TotalDays;
                    if (days == 0)
                        status = "Acquired";
                    else
                        status = "Disposed";

                    var item = new ListViewItem(new[] {
                    fixedAsset.AssetId,
                    fixedAsset.Branch,
                    fixedAsset.Description,
                    fixedAsset.AssetType,
                    fixedAsset.NoOfAssets.ToString(),
                    fixedAsset.AcquisitionDate.ToShortDateString(),
                    fixedAsset.OriginalCost.GetFormatedValue(false),
                    fixedAsset.AnnualDepreciationRate.ToString(),
                    status
                    
                });
                    lvFixedAsset.Items.Add(item);

                }

            }

          
        }

        private string _CreateHtmlForShowingPackage(LoanProduct pPackage)
        {
           

            return "text";
        }

        private void buttonAddProduct_Click(object sender, System.EventArgs e)
        {
            AddFixedAsset _frmAddFixedAsset = new AddFixedAsset();
            _frmAddFixedAsset.Show();
        }

        private void buttonEditProduct_Click(object sender, System.EventArgs e)
        {
            try{
            int i = lvFixedAsset.SelectedIndices[0];
            string selectedFixedAssetId = lvFixedAsset.Items[i].Text;

            AddFixedAsset _frmAddFixedAsset = new AddFixedAsset(selectedFixedAssetId, true);
            _frmAddFixedAsset.Show();

            }
            catch (Exception ex)
            {
                try
                {

                    throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FixedDepositProductSelectAProduct);
                }
                catch (Exception exc)
                {
                    new frmShowError(CustomExceptionHandler.ShowExceptionText(exc)).ShowDialog();
                }
            }
        }

        private void checkBoxShowDeletedProduct_CheckedChanged(object sender, System.EventArgs e)
        {
           
        }

        private void lvFixedDepositProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try{
            int i = lvFixedAsset.SelectedIndices[0];
            string selectedFixedAssetId = lvFixedAsset.Items[i].Text;

            FixedDepositProductService _fixedDepositProductService = ServicesProvider.GetInstance().GetFixedDepositProductService();
            _fixedDepositProductService.DeleteFixedDepositProduct(Convert.ToInt32(selectedFixedAssetId));
            MessageBox.Show("Fixed Deposit Product Successfully Deleted.");


            }
            catch (Exception ex)
            {
                try
                {

                    throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FixedDepositProductSelectAProduct);
                }
                catch (Exception exc)
                {
                    new frmShowError(CustomExceptionHandler.ShowExceptionText(exc)).ShowDialog();
                }
            }
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            try{
            int i = lvFixedAsset.SelectedIndices[0];
            string selectedProductId = lvFixedAsset.Items[i].Text;

            AddFixedAsset _frmAddFixedAsset = new AddFixedAsset(selectedProductId, false);
            _frmAddFixedAsset.Show();

            }
            catch (Exception ex)
            {
                try
                {

                    throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FixedDepositProductSelectAProduct);
                }
                catch (Exception exc)
                {
                    new frmShowError(CustomExceptionHandler.ShowExceptionText(exc)).ShowDialog();
                }
            }
        }

        private void lvFixedDepositProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnGenerateFAR_Click(object sender, EventArgs e)
        {

        }

    }
}
