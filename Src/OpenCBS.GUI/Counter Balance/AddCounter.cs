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

namespace OpenCBS.GUI.Counter_Balance
{
    public partial class AddCounter : Form
    {
        public AddCounter()
        {
            InitializeComponent();
            InitializeBranch();
        }


        private void InitializeBranch()
        {
            
            cmbBranch.ValueMember = "Code";
            cmbBranch.DisplayMember = "Code";
            cmbBranch.DataSource =
                ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted().OrderBy(item => item.Id).ToList();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BranchCounter branchCounter = new BranchCounter();
            branchCounter.Branch = cmbBranch.SelectedItem.ToString();
            branchCounter.Description = txtDescription.Text;
            CounterBalanceService _counterBalanceService = ServicesProvider.GetInstance().GetCounterBalanceService();
            int ret = _counterBalanceService.SaveBranchCounter(branchCounter);
            if(ret >= 1)
            MessageBox.Show("Branch Counter Successfully Added.");
            else
            MessageBox.Show("Some Error Ocurred.");

        }
    }
}
