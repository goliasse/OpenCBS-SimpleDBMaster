using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Services;
using OpenCBS.Services.Accounting;

namespace OpenCBS.GUI.Accounting
{
    public partial class AddedCurrencyAsset : Form
    {
        public AddedCurrencyAsset()
        {
            InitializeComponent();
            InitializeCurrencyAssetList();
        }


        public void InitializeCurrencyAssetList()
        {

            lvCurrencyAsset.Items.Clear();
            CurrencyAssetService currencyAssetService = ServicesProvider.GetInstance().GetCurrencyAssetService();
            List<CurrencyAssets> currencyAssetList = currencyAssetService.FetchAll();
            if (currencyAssetList != null)
            {
                foreach (CurrencyAssets currencyAsset in currencyAssetList)
                {
                   

                    var item = new ListViewItem(new[] {
                    currencyAsset.Id.ToString(),
                    currencyAsset.AssetDate.ToShortDateString(),
                    currencyAsset.AssetCategory,
                    currencyAsset.AssetDescription,
                    currencyAsset.AssetAmount.GetFormatedValue(false),
                    currencyAsset.Reference

                });
                    lvCurrencyAsset.Items.Add(item);

                }

            }


        }


        private void btnManageCounter_Click(object sender, EventArgs e)
        {
            CurrencyAssetsForm currencyAssetsForm = new CurrencyAssetsForm(this);
            currencyAssetsForm.Show();
        }

        private void btnDeleteCurrencyAsset_Click(object sender, EventArgs e)
        {
            try
            {

                int i = lvCurrencyAsset.SelectedIndices[0];
                ListViewItem item = lvCurrencyAsset.Items[i];
                string selectedId = item.SubItems[0].Text;
                string selectedCategory = item.SubItems[2].Text;
                
                CurrencyAssetService currencyAssetService = ServicesProvider.GetInstance().GetCurrencyAssetService();

                int ret = currencyAssetService.DeleteCurrencyAssets(Convert.ToInt32(selectedId));

                if (ret == 1)
                {
                    MessageBox.Show("Currency Asset Deleted Successfully.");
                   
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().DeleteCOATranByDesc(selectedCategory + " " + selectedId);
                    InitializeCurrencyAssetList();
                }
                else
                {
                    MessageBox.Show("Some Error Ocurred.");
                }

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
    }
}
