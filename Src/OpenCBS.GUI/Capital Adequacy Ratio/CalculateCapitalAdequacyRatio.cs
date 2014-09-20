using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain;
using OpenCBS.Services;

namespace OpenCBS.GUI.Capital_Adequacy_Ratio
{
    public partial class CalculateCapitalAdequacyRatio : Form
    {
        public CalculateCapitalAdequacyRatio()
        {
            InitializeComponent();

            lblCapitalAdequacyRatio.Visible = false;
            lblTierOneCapital.Visible = false;
            lblTierTwoCapital.Visible = false;
            lblRWA.Visible = false;
            lblCapitalAdequacyRatio.Visible = false;

            RWAPercentageService _RWAPercentageService = ServicesProvider.GetInstance().GetRWAPercentageService();
            
            
            lblContractrelatedtransaction.Text = lblContractrelatedtransaction.Text + "(" + _RWAPercentageService.FetchRWAPercentage("Contract related transaction") + "%)";
            lblBidbond.Text = lblBidbond.Text + "(" + _RWAPercentageService.FetchRWAPercentage("Bid bond") + "%)";
            lblPerformancebond.Text = lblPerformancebond.Text + "(" + _RWAPercentageService.FetchRWAPercentage("performance bond") + "%)";
            lblFinancialguarantee.Text = lblFinancialguarantee.Text + "(" + _RWAPercentageService.FetchRWAPercentage("Financial guarantee") + "%)";
            lblLetterofcredit.Text = lblLetterofcredit.Text + "(" + _RWAPercentageService.FetchRWAPercentage("letter of credit") + "%)";
            lblMortgageloan.Text = lblMortgageloan.Text + "(" + _RWAPercentageService.FetchRWAPercentage("Mortgage loan") + "%)";
            lblOtherloans.Text = lblOtherloans.Text + "(" + _RWAPercentageService.FetchRWAPercentage("Other loans") + "%)";
            lblGovernmentLoans.Text = lblGovernmentLoans.Text + "(" + _RWAPercentageService.FetchRWAPercentage("Government Loans") + "%)";
            lblCash.Text = lblCash.Text + "(" + _RWAPercentageService.FetchRWAPercentage("Cash") + "%)";
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
            if (Paidupcapital == null)
                Paidupcapital = 0;

            decimal? Statutoryreserves = ServicesHelper.ConvertStringToNullableDecimal(txtStatutoryreserves.Text);
            if (Statutoryreserves == null)
                Statutoryreserves = 0;

            decimal? Retainedearnings = ServicesHelper.ConvertStringToNullableDecimal(txtRetainedearnings.Text);
            if (Retainedearnings == null)
                Retainedearnings = 0;


            decimal? Goodwill = ServicesHelper.ConvertStringToNullableDecimal(txtGoodwill.Text);
            if (Goodwill == null)
                Goodwill = 0;

            decimal tierOneCapital = (decimal)(Paidupcapital + Statutoryreserves + Retainedearnings + Goodwill); 
            lblTotalTierOneCapital.Text = (Paidupcapital + Statutoryreserves + Retainedearnings + Goodwill).ToString();

            decimal? Loanlossreserve = ServicesHelper.ConvertStringToNullableDecimal(txtLoanlossreserve.Text);
            if (Loanlossreserve == null)
                Loanlossreserve = 0;


            decimal? Subordinateddebt = ServicesHelper.ConvertStringToNullableDecimal(txtSubordinateddebt.Text);
            if (Subordinateddebt == null)
                Subordinateddebt = 0;


            decimal? Revaluationreserve = ServicesHelper.ConvertStringToNullableDecimal(txtRevaluationreserve.Text);
            if (Revaluationreserve == null)
                Revaluationreserve = 0;


            decimal? Preferenceshares = ServicesHelper.ConvertStringToNullableDecimal(txtPreferenceshares.Text);
            if (Preferenceshares == null)
                Preferenceshares = 0;

            decimal tierTwoCapital = (decimal)(Loanlossreserve + Subordinateddebt + Revaluationreserve + Preferenceshares);
            lblTotalTierTwoCapital.Text = (Loanlossreserve + Subordinateddebt + Revaluationreserve + Preferenceshares).ToString();


            decimal? Contractrelatedtransaction = ServicesHelper.ConvertStringToNullableDecimal(txtContractrelatedtransaction.Text);
            if (Contractrelatedtransaction == null)
                Contractrelatedtransaction = 0;


            decimal? Bidbond = ServicesHelper.ConvertStringToNullableDecimal(txtBidbond.Text);
            if (Bidbond == null)
                Bidbond = 0;


            decimal? Performancebond = ServicesHelper.ConvertStringToNullableDecimal(txtPerformancebond.Text);
            if (Performancebond == null)
                Performancebond = 0;


            decimal? Financialguarantee = ServicesHelper.ConvertStringToNullableDecimal(txtFinancialguarantee.Text);
            if (Financialguarantee == null)
                Financialguarantee = 0;


            decimal? Letterofcredit = ServicesHelper.ConvertStringToNullableDecimal(txtLetterofcredit.Text);
            if (Letterofcredit == null)
                Letterofcredit = 0;


            decimal? Mortgageloan = ServicesHelper.ConvertStringToNullableDecimal(txtMortgageloan.Text);
            if (Mortgageloan == null)
                Mortgageloan = 0;


            decimal? Otherloans = ServicesHelper.ConvertStringToNullableDecimal(txtOtherloans.Text);
            if (Otherloans == null)
                Otherloans = 0;


            decimal? GovernmentLoans = ServicesHelper.ConvertStringToNullableDecimal(txtGovernmentLoans.Text);
            if (GovernmentLoans == null)
                GovernmentLoans = 0;


            decimal? Cash = ServicesHelper.ConvertStringToNullableDecimal(txtCash.Text);
            if (Cash == null)
                Cash = 0;

            int ContractrelatedtransactionPercentage = FetchRWAPercentage(lblContractrelatedtransaction.Text);
            int BidbondPercentage = FetchRWAPercentage(lblBidbond.Text);
            int PerformancebondPercentage = FetchRWAPercentage(lblPerformancebond.Text);
            int FinancialguaranteePercentage = FetchRWAPercentage(lblFinancialguarantee.Text);
            int LetterofcreditPercentage = FetchRWAPercentage(lblLetterofcredit.Text);
            int MortgageloanPercentage = FetchRWAPercentage(lblMortgageloan.Text);
            int OtherloansPercentage = FetchRWAPercentage(lblOtherloans.Text);
            int GovernmentLoansPercentage = FetchRWAPercentage(lblGovernmentLoans.Text);
            int CashPercentage = FetchRWAPercentage(lblCash.Text);


            Contractrelatedtransaction = (Contractrelatedtransaction* ContractrelatedtransactionPercentage)/100;
            Bidbond = (Bidbond * BidbondPercentage)/100;
            Performancebond = (Performancebond * PerformancebondPercentage)/100;
            Financialguarantee = (Financialguarantee * FinancialguaranteePercentage)/100;
            Letterofcredit = (Letterofcredit * LetterofcreditPercentage)/100;
            Mortgageloan = (Mortgageloan * MortgageloanPercentage)/100;
            Otherloans = (Otherloans * OtherloansPercentage)/100;
            GovernmentLoans = (GovernmentLoans * GovernmentLoansPercentage)/100;
            Cash = (Cash * CashPercentage)/100;


            lblCapitalAdequacyRatio.Visible = true;
            lblTierOneCapital.Visible = true;
            lblTierTwoCapital.Visible = true;
            lblRWA.Visible = true;
            lblCapitalAdequacyRatio.Visible = true;

            decimal RWA = (decimal)(Contractrelatedtransaction + Bidbond + Performancebond + Financialguarantee + Letterofcredit + Mortgageloan + Otherloans + GovernmentLoans + Cash);
            lblTotalRWA.Text = (Contractrelatedtransaction + Bidbond + Performancebond + Financialguarantee + Letterofcredit + Mortgageloan + Otherloans + GovernmentLoans + Cash).ToString();
            double CAR = (double)((tierOneCapital + tierTwoCapital) / RWA);
            lblCAR.Text = CAR.ToString();

        }

        public static int FetchRWAPercentage(string RWA)
        {
        int len = RWA.IndexOf('%') - RWA.IndexOf('(');
        return Convert.ToInt32(RWA.Substring(RWA.IndexOf('(')+1, len-1));
        }
    }
}
