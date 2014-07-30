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



namespace OpenCBS.GUI.Products
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FrmAvailableFixedDepositProducts : Form
    {
        private int _idPackage;
        private LoanProduct _package;
        public FrmAvailableFixedDepositProducts()
        {
            
            InitializeComponent();
            _package = new LoanProduct();
            InitializeFixedDepositProductList(false);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int PackageFormId
        {
            set { _idPackage = value; }
            get { return _idPackage; }
        }
        private bool _showDeletedPackage = false;
        private void InitializeFixedDepositProductList(bool showAsDeleted)
        {
            lvFixedDepositProducts.Items.Clear();
            FixedDepositProductService _fixedDepositProductService = ServicesProvider.GetInstance().GetFixedDepositProductService();
            List<IFixedDepositProduct> fixedDepositProductList = _fixedDepositProductService.FetchProduct(showAsDeleted);
            if (fixedDepositProductList != null)
            {
                foreach (FixedDepositProduct fixedDepositProduct in fixedDepositProductList)
                {
                    string deleted = "";
                    if(fixedDepositProduct.Delete == 0)
                        deleted = "Active";
                    else
                           deleted = "Deleted";
                    var item = new ListViewItem(new[] {
                    fixedDepositProduct.Id.ToString(),
                    deleted,
                    fixedDepositProduct.Name,
                    fixedDepositProduct.Code,                    
		            fixedDepositProduct.ClientType,
                    fixedDepositProduct.Currency.Name.ToString()


                    
                });
                    lvFixedDepositProducts.Items.Add(item);

                }
            }

          
        }

        private string _CreateHtmlForShowingPackage(LoanProduct pPackage)
        {
           

            return "text";
        }

        private void buttonAddProduct_Click(object sender, System.EventArgs e)
        {
            FrmAddFixedDepositProduct _frmAddFixedDepositProduct = new FrmAddFixedDepositProduct();
            _frmAddFixedDepositProduct.Show();
        }

        private void buttonEditProduct_Click(object sender, System.EventArgs e)
        {
            try{
            int i = lvFixedDepositProducts.SelectedIndices[0];
            string selectedProductId = lvFixedDepositProducts.Items[i].Text;

            FrmAddFixedDepositProduct _frmAddFixedDepositProduct = new FrmAddFixedDepositProduct(Convert.ToInt32(selectedProductId),true);
            _frmAddFixedDepositProduct.Show();

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
            if(checkBoxShowDeletedProduct.Checked == true)
                InitializeFixedDepositProductList(true);
            else
                InitializeFixedDepositProductList(false);
        }

        private void lvFixedDepositProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try{
            int i = lvFixedDepositProducts.SelectedIndices[0];
            string selectedProductId = lvFixedDepositProducts.Items[i].Text;

            FixedDepositProductService _fixedDepositProductService = ServicesProvider.GetInstance().GetFixedDepositProductService();
            _fixedDepositProductService.DeleteFixedDepositProduct(Convert.ToInt32(selectedProductId));
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
            int i = lvFixedDepositProducts.SelectedIndices[0];
            string selectedProductId = lvFixedDepositProducts.Items[i].Text;

            FrmAddFixedDepositProduct _frmAddFixedDepositProduct = new FrmAddFixedDepositProduct(Convert.ToInt32(selectedProductId),false);
            _frmAddFixedDepositProduct.Show();

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

    }
}
