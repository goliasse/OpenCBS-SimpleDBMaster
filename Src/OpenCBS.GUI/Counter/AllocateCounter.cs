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
    }
}
