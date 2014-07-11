using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.GUI.UserControl;
using OpenCBS.Services;
using OpenCBS.CoreDomain.Products;
using System.Security.Permissions;

namespace OpenCBS.GUI.Products
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FrmAvailableCurrentAccountProducts : SweetForm
    {
        public FrmAvailableCurrentAccountProducts()
        {
            InitializeComponent();
            InitializeCurrentAccountProductList(false);
        }


        private void InitializeCurrentAccountProductList(bool showAsDeleted)
        {
            lvCurrentAccountProducts.Items.Clear();
            CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
            List<ICurrentAccountProduct> currentAccountProductList = _currentAccountProductService.FetchProduct(showAsDeleted);
            if (currentAccountProductList != null)
            {
                foreach (CurrentAccountProduct currentAccountProduct in currentAccountProductList)
                {

                    string deleted = "";
                    if (currentAccountProduct.Delete == 0)
                        deleted = "Active";
                    else
                        deleted = "Deleted";

                    var item = new ListViewItem(new[] {
                  currentAccountProduct.Id.ToString(),
                  deleted,
                  currentAccountProduct.CurrentAccountProductName,
                  currentAccountProduct.CurrentAccountProductCode,
                  currentAccountProduct.ClientType,
                  currentAccountProduct.Currency.Name


                    
                });
                    lvCurrentAccountProducts.Items.Add(item);

                }
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddCurrentAccountProduct _frmAddCurrentAccountProduct = new FrmAddCurrentAccountProduct();
            _frmAddCurrentAccountProduct.Show();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {

            int i = lvCurrentAccountProducts.SelectedIndices[0];
            string selectedProductId = lvCurrentAccountProducts.Items[i].Text;



            FrmAddCurrentAccountProduct _frmAddCurrentAccountProduct = new FrmAddCurrentAccountProduct(Convert.ToInt32(selectedProductId),true);
            _frmAddCurrentAccountProduct.Show();
        }

        private void checkBoxShowDeletedProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowDeletedProduct.Checked == true)
                InitializeCurrentAccountProductList(true);
            else
                InitializeCurrentAccountProductList(false);
        }

        private void lvCurrentAccountProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int i = lvCurrentAccountProducts.SelectedIndices[0];
            string selectedProductId = lvCurrentAccountProducts.Items[i].Text;

            CurrentAccountProductService _currentAccountProductService = ServicesProvider.GetInstance().GetCurrentAccountProductService();
            _currentAccountProductService.DeleteCurrentAccountProduct(Convert.ToInt32(selectedProductId));
            MessageBox.Show("Current Account Product Successfully Deleted.");

        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            int i = lvCurrentAccountProducts.SelectedIndices[0];
            string selectedProductId = lvCurrentAccountProducts.Items[i].Text;



            FrmAddCurrentAccountProduct _frmAddCurrentAccountProduct = new FrmAddCurrentAccountProduct(Convert.ToInt32(selectedProductId),false);
            _frmAddCurrentAccountProduct.Show();
        }
    }
}
