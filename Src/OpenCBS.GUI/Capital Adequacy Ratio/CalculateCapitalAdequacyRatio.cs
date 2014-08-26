using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.Services;

namespace OpenCBS.GUI.Capital_Adequacy_Ratio
{
    public partial class CalculateCapitalAdequacyRatio : Form
    {
        public CalculateCapitalAdequacyRatio()
        {
            InitializeComponent();
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

        private void txtPaidupcapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }

        private void btnCalculateCAR_Click(object sender, EventArgs e)
        {
            decimal? Paidupcapital = ServicesHelper.ConvertStringToNullableDecimal(txtPaidupcapital.Text);
            if(Paidupcapital == null)
                Paidupcapital = 0;
decimal? Statutoryreserves =  ServicesHelper.ConvertStringToNullableDecimal(txtStatutoryreserves.Text);

decimal? Retainedearnings =  ServicesHelper.ConvertStringToNullableDecimal(txtRetainedearnings.Text);
decimal? Goodwill =  ServicesHelper.ConvertStringToNullableDecimal(txtGoodwill.Text);

lblTotalTierOneCapital.Text = (Paidupcapital + Statutoryreserves + Retainedearnings + Goodwill).ToString();
decimal? Loanlossreserve =  ServicesHelper.ConvertStringToNullableDecimal(txtLoanlossreserve.Text);
decimal? Subordinateddebt =  ServicesHelper.ConvertStringToNullableDecimal(txtSubordinateddebt.Text);
decimal? Revaluationreserve =  ServicesHelper.ConvertStringToNullableDecimal(txtRevaluationreserve.Text);
decimal? Preferenceshares =  ServicesHelper.ConvertStringToNullableDecimal(txtPreferenceshares.Text);
lblTotalTierTwoCapital.Text = (Loanlossreserve + Subordinateddebt + Revaluationreserve + Preferenceshares).ToString();
decimal? Contractrelatedtransaction = ServicesHelper.ConvertStringToNullableDecimal(txtContractrelatedtransaction.Text);
decimal? Bidbond =  ServicesHelper.ConvertStringToNullableDecimal(txtBidbond.Text);
 decimal? Performancebond = ServicesHelper.ConvertStringToNullableDecimal(txtPerformancebond.Text);
decimal? Financialguarantee =  ServicesHelper.ConvertStringToNullableDecimal(txtFinancialguarantee.Text);
 decimal? Letterofcredit = ServicesHelper.ConvertStringToNullableDecimal(txtLetterofcredit.Text);
 decimal? Mortgageloan = ServicesHelper.ConvertStringToNullableDecimal(txtMortgageloan.Text);
 decimal? Otherloans = ServicesHelper.ConvertStringToNullableDecimal(txtOtherloans.Text);
 decimal? GovernmentLoans = ServicesHelper.ConvertStringToNullableDecimal(txtGovernmentLoans.Text);
decimal? Cash =  ServicesHelper.ConvertStringToNullableDecimal(txtCash.Text);
//lblTotalRWA.Text
//lblCAR.Text
        }
    }
}
