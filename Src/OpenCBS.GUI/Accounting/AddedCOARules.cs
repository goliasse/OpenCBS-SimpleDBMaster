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
    public partial class AddedCOARules : Form
    {
        public AddedCOARules()
        {
            InitializeComponent();
            InitializeCOARuleList();
        }



        public void InitializeCOARuleList()
        {

            lvCOARules.Items.Clear();

            ChartOfAccountsServices coaService = ServicesProvider.GetInstance().GetChartOfAccountsServices();
            List<COARule> COARuleList = coaService.FetchCOARule();
            if (COARuleList != null)
            {
                foreach (COARule coaRule in COARuleList)
                {


                    var item = new ListViewItem(new[] {
                    coaRule.Id.ToString(),
                    coaRule.EventType,
                    coaRule.DebitAccount,
                    coaRule.CreditAccount,
                    coaRule.Branch,
                    coaRule.Currency

                });
                    lvCOARules.Items.Add(item);

                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AddCOARule addCOARule = new AddCOARule(this);
            addCOARule.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int i = lvCOARules.SelectedIndices[0];
                ListViewItem item = lvCOARules.Items[i];
                string selectedId = item.SubItems[0].Text;
                ChartOfAccountsServices coaService = ServicesProvider.GetInstance().GetChartOfAccountsServices();
                int ret = coaService.DeleteCOARule(selectedId);

                if (ret == 1)
                {
                    MessageBox.Show("COA Rule Deleted Successfully.");
                    InitializeCOARuleList();
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
