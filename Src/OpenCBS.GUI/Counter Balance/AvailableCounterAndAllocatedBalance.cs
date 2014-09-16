using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain;
using OpenCBS.GUI.Counter;
using OpenCBS.Services;

namespace OpenCBS.GUI.Counter_Balance
{
    public partial class AvailableCounterAndAllocatedBalance : Form
    {
        public AvailableCounterAndAllocatedBalance()
        {
            InitializeComponent();
            InitializeAllocatedCounters();
            InitializeBranchCounters();
        }


        private void InitializeAllocatedCounters()
        {
            lvAllocatedBalance.Items.Clear();
            CounterBalanceService _counterBalanceService = ServicesProvider.GetInstance().GetCounterBalanceService();
            List<CounterBalance> counterBalanceList = _counterBalanceService.FetchCounterBalance("Default", DateTime.Today.ToShortDateString());

            if (counterBalanceList != null)
            {
                foreach (CounterBalance counterBalance in counterBalanceList)
                {
                    

                    var item = new ListViewItem(new[] {
                    counterBalance.Branch,
                    counterBalance.CashierId,
                    counterBalance.CounterId,
                    counterBalance.AllocationDate.ToShortDateString(),
                    counterBalance.Amount.GetFormatedValue(false),
                    counterBalance.Type
                    
                });
                    lvAllocatedBalance.Items.Add(item);

                }

            }


        }


        private void InitializeBranchCounters()
        {
            lvCounters.Items.Clear();
            CounterBalanceService _counterBalanceService = ServicesProvider.GetInstance().GetCounterBalanceService();
            List<BranchCounter> branchCounterList = _counterBalanceService.FetchCounters("Default");

            if (branchCounterList != null)
            {
                foreach (BranchCounter branchCounter in branchCounterList)
                {


                    var item = new ListViewItem(new[] {
                    branchCounter.Branch,
                    branchCounter.CounterId,
                    branchCounter.Description
                    
                });
                    lvCounters.Items.Add(item);

                }

            }


        }

        private void lvFixedAsset_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddFixedAsset_Click(object sender, EventArgs e)
        {
            AllocateCounter allocateCounter = new AllocateCounter();
            allocateCounter.Show();
        }

        private void btnAddCounter_Click(object sender, EventArgs e)
        {
            AddCounter addCounter = new AddCounter();
            addCounter.Show();
        }
    }
}
