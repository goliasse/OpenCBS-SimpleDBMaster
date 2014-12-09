using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenCBS.GUI.Accounting
{
    public partial class CurrencyAssetsForm : Form
    {
        public CurrencyAssetsForm()
        {
            InitializeComponent();
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            DateTime asset = assetDate.Value;
            string assetCategory = cbAssetCategory.SelectedItem.ToString();
            string assetDescription = tbAssetDescription.Text;
            string assetAmount = tbAssetAmount.Text;
            string reference = tbReference.Text;

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
    }
}
