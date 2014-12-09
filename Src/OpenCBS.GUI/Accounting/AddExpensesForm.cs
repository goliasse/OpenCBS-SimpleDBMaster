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
    public partial class AddExpensesForm : Form
    {
        public AddExpensesForm()
        {
            InitializeComponent();
        }

        private void tbFDContractCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            DateTime expense = expenseDate.Value;
            string expenseCategory = cbExpenseCategory.SelectedItem.ToString();
            string expenseDescription = tbExpenseDescription.Text;
            string expenseAmount = tbExpenseAmount.Text;
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

        private void tbExpenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }
    }
}
