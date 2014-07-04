using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Products;

namespace OpenCBS.GUI.Clients
{
    public partial class CurrentAccountTransactionForm : Form
    {

        CurrentAccountTransactions currentAccountTransactions = null;

        public CurrentAccountTransactionForm()
        {
            InitializeComponent();
        }

        void EnableCurrentAccountTransactionControl(bool enabled)
        {
            rbCredit.Enabled = enabled;
            rbDebit.Enabled = enabled;
            cbTransactionType.Enabled = enabled;
            cbFromAccount.Enabled = enabled;
            cbToAccount.Enabled = enabled;
            tbAmount.Enabled = enabled;
            cbMaker.Enabled = enabled;
            cbChecker.Enabled = enabled;
            tbTransactionFees.Enabled = enabled;
        }

        void InitializeCurrentAccountTransactionControl()
        {


        }

        private void btnExtendPeriod_Click(object sender, EventArgs e)
        {
            if(rbCredit.Checked == true)
                currentAccountTransactions.TransactionMode = "Credit";
            else
                currentAccountTransactions.TransactionMode = "Debit";
            
            currentAccountTransactions.TransactionType = cbTransactionType.SelectedItem.ToString();
            currentAccountTransactions.FromAccount = cbFromAccount.SelectedItem.ToString();
            currentAccountTransactions.ToAccount = cbToAccount.SelectedItem.ToString();
            currentAccountTransactions.Amount = Convert.ToDecimal(tbAmount.Text);
            currentAccountTransactions.Maker = cbMaker.SelectedItem.ToString();
            currentAccountTransactions.Checker = cbChecker.SelectedItem.ToString();
            currentAccountTransactions.TransactionDate = DateTime.Today;






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
