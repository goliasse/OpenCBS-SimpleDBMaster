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
    public partial class AddedIncome : Form
    {
        public AddedIncome()
        {
            InitializeComponent();
            InitializeIncomeList();
        }

        public void InitializeIncomeList()
        {

            lvIncome.Items.Clear();
            IncomeService incomeService = ServicesProvider.GetInstance().GetIncomeService();
            List<Income> incomeList = incomeService.FetchAll();
            if (incomeList != null)
            {
                foreach (Income income in incomeList)
                {


                    var item = new ListViewItem(new[] {
                    income.Id.ToString(),
                    income.IncomeDate.ToShortDateString(),
                    income.IncomeCategory,
                    income.IncomeDescription,
                    income.IncomeAmount.GetFormatedValue(false),
                    income.Reference

                });
                    lvIncome.Items.Add(item);

                }
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome(this);
            addIncome.Show();
        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            try
            {

                int i = lvIncome.SelectedIndices[0];
                ListViewItem item = lvIncome.Items[i];
                string selectedId = item.SubItems[0].Text;
                string selectedCategory = item.SubItems[2].Text;

                IncomeService incomeService = ServicesProvider.GetInstance().GetIncomeService();
                
                int ret = incomeService.DeleteIncome(Convert.ToInt32(selectedId));

                if (ret == 1)
                {
                    MessageBox.Show("Income Deleted Successfully.");
                   
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().DeleteCOATranByDesc(selectedCategory + " " + selectedId);
                    InitializeIncomeList();
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
