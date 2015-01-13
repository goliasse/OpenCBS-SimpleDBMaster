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
    public partial class AddedExpense : Form
    {
        public AddedExpense()
        {
            InitializeComponent();
            InitializeExpenseList();
        }

        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
           
           
        }

        public void InitializeExpenseList()
        {

            lvExpense.Items.Clear();
            ExpenseService expenseService = ServicesProvider.GetInstance().GetExpenseService();
            List<Expense> expenseList = expenseService.FetchExpenses();
            if (expenseList != null)
            {
                foreach (Expense expense in expenseList)
                {


                    var item = new ListViewItem(new[] {
                    expense.Id.ToString(),
                    expense.ExpenseDate.ToShortDateString(),
                    expense.ExpenseCategory,
                    expense.ExpenseDescription,
                    expense.ExpenseAmount.GetFormatedValue(false),
                    expense.Reference

                });
                    lvExpense.Items.Add(item);

                }
            }
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            

            try
            {

                int i = lvExpense.SelectedIndices[0];

                ListViewItem item = lvExpense.Items[i];
                string selectedId = item.SubItems[0].Text;
                string selectedCategory = item.SubItems[2].Text;

                ExpenseService expenseService = ServicesProvider.GetInstance().GetExpenseService();

                int ret = expenseService.DeleteExpense(Convert.ToInt32(selectedId));

                if (ret == 1)
                {
                    MessageBox.Show("Expense Deleted Successfully.");
                   
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().DeleteCOATranByDesc(selectedCategory + " " + selectedId);
                    InitializeExpenseList();
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

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddExpensesForm addExpenseForm = new AddExpensesForm(this);
            addExpenseForm.Show();
        }
    }
}
