using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Services;

namespace OpenCBS.GUI.Capital_Adequacy_Ratio
{
    public partial class DefineRiskWeightedAssetPercentage : Form
    {
        public DefineRiskWeightedAssetPercentage()
        {
            InitializeComponent();

            RWAPercentageService _RWAPercentageService = ServicesProvider.GetInstance().GetRWAPercentageService();

            txtContractrelatedtransaction.Text = _RWAPercentageService.FetchRWAPercentage("Contract related transaction").ToString();
            txtBidbond.Text = _RWAPercentageService.FetchRWAPercentage("Bid bond").ToString();
            txtPerformancebond.Text = _RWAPercentageService.FetchRWAPercentage("performance bond").ToString();
            txtFinancialguarantee.Text = _RWAPercentageService.FetchRWAPercentage("Financial guarantee").ToString();
            txtLetterofcredit.Text = _RWAPercentageService.FetchRWAPercentage("letter of credit").ToString();
            txtMortgageloan.Text = _RWAPercentageService.FetchRWAPercentage("Mortgage loan").ToString();
            txtOtherloans.Text = _RWAPercentageService.FetchRWAPercentage("Other loans").ToString();
            txtGovernmentLoans.Text = _RWAPercentageService.FetchRWAPercentage("Government Loans").ToString();
            txtCash.Text = _RWAPercentageService.FetchRWAPercentage("Cash").ToString();
                  

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

        private void txtContractrelatedtransaction_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             try{

                RWAPercentageService _RWAPercentageService = ServicesProvider.GetInstance().GetRWAPercentageService();
                RWAPercentage rwa = new RWAPercentage();
                rwa.RWA = "Contract related transaction";
                rwa.Percentage = Convert.ToDouble(txtContractrelatedtransaction.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);
                rwa.RWA = "performance bond";
                rwa.Percentage = Convert.ToDouble(txtPerformancebond.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);
                rwa.RWA = "Financial guarantee";
                rwa.Percentage = Convert.ToDouble(txtFinancialguarantee.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);
                rwa.RWA = "letter of credit";
                rwa.Percentage = Convert.ToDouble(txtLetterofcredit.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);
                rwa.RWA = "Bid bond";
                rwa.Percentage = Convert.ToDouble(txtBidbond.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);
                rwa.RWA = "Mortgage loan";
                rwa.Percentage = Convert.ToDouble(txtMortgageloan.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);
                rwa.RWA = "Other loans";
                rwa.Percentage = Convert.ToDouble(txtOtherloans.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);
                rwa.RWA = "Government Loans";
                rwa.Percentage = Convert.ToDouble(txtGovernmentLoans.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);
                rwa.RWA = "Cash";
                rwa.Percentage = Convert.ToDouble(txtCash.Text);
                _RWAPercentageService.UpdateRWAPercentage(rwa);

                MessageBox.Show("RWA Percentage Successfully Updated.");

             }
             catch (Exception ex)
             {
                 new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
             }
        }
    }
}