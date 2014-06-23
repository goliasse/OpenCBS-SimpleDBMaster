using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.GUI.UserControl;
namespace OpenCBS.GUI.Products
{
    public partial class FrmAvailableCurrentAccountProducts : SweetForm
    {
        public FrmAvailableCurrentAccountProducts()
        {
            InitializeComponent();
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
            FrmAddCurrentAccountProduct _frmAddCurrentAccountProduct = new FrmAddCurrentAccountProduct();
            _frmAddCurrentAccountProduct.Show();
        }
    }
}
