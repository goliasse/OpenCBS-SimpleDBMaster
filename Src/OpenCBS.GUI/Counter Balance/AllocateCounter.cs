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

namespace OpenCBS.GUI.Counter
{
    public partial class AllocateCounter : Form
    {
        public AllocateCounter()
        {
            InitializeComponent();
            InitializeBranch();
            InitializeCashiers();
            InitializeCounters();
        }

        private void InitializeCashiers()
        {
            cmbCashier.Items.Clear();
            cmbCashier.Items.Add("Select cashier..");
            CounterBalanceService _counterBalanceService = ServicesProvider.GetInstance().GetCounterBalanceService();
            List<string> cashiers = _counterBalanceService.FetchCashiers();
            foreach (string s in cashiers)
            {
                
                cmbCashier.Items.Add(s);
            }
            cmbCashier.SelectedIndex = 0;
        }

        private void InitializeCounters()
        {
            cmbCounter.Items.Clear();
            cmbCounter.Items.Add("Select counter..");
            CounterBalanceService _counterBalanceService = ServicesProvider.GetInstance().GetCounterBalanceService();
            List<BranchCounter> counters = _counterBalanceService.FetchCounters(cmbBranch.SelectedItem.ToString());
            foreach (BranchCounter branchCounter in counters)
            {
                
                cmbCounter.Items.Add(branchCounter.CounterId);
            }

            cmbCounter.SelectedIndex = 0;
        }


        private void InitializeBranch()
        {
            cmbBranch.ValueMember = "Code";
            cmbBranch.DisplayMember = "Code";
            cmbBranch.DataSource =
                ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted().OrderBy(item => item.Id).ToList();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CounterBalance counterBalance = new CounterBalance();

            
            counterBalance.Branch = cmbBranch.SelectedValue.ToString();
            counterBalance.CashierId = cmbCashier.SelectedItem.ToString();
            counterBalance.CounterId = cmbCounter.SelectedItem.ToString();
            counterBalance.Amount = ServicesHelper.ConvertStringToNullableDecimal(tbxAmount.Text);
            counterBalance.AllocationDate = DateTime.Today;

            if (rbtnOpeningAmt.Checked == true)
                counterBalance.Type = "Opening Amount";
            if (rbtnClosingAmt.Checked == true)
                counterBalance.Type = "Closing Amount";
            if (rbtnTopUp.Checked == true)
                counterBalance.Type = "TopUp Amount";

            CounterBalanceService _counterBalanceService = ServicesProvider.GetInstance().GetCounterBalanceService();
            int ret = _counterBalanceService.SaveCounterBalance(counterBalance);
            if (ret >= 1)
                MessageBox.Show("Counter Balance Successfully Updated.");
            else
                MessageBox.Show("Some Error Ocurred.");
            
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

        private void tbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressControl(e);
        }
    }
}
