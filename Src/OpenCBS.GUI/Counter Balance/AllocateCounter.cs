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
        }

        private void InitializeBranch()
        {
            cmbBranch.ValueMember = "Name";
            cmbBranch.DisplayMember = "";
            cmbBranch.DataSource =
                ServicesProvider.GetInstance().GetBranchService().FindAllNonDeletedWithVault().OrderBy(item => item.Id).ToList();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CounterBalance counterBalance = new CounterBalance();

            
            counterBalance.Branch = cmbBranch.SelectedItem.ToString();
            counterBalance.CashierId = Convert.ToInt32(cmbCashier.SelectedValue);
            counterBalance.CounterId = Convert.ToInt32(cmbCounter.SelectedValue);
            counterBalance.Amount = ServicesHelper.ConvertStringToNullableDecimal(tbxAmount.Text);
            counterBalance.AllocationDate = DateTime.Today;
            
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
