using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using OpenCBS.CoreDomain.SearchResult;
using OpenCBS.Services;

namespace OpenCBS.GUI.Clients
{
    public partial class SelectStatementPeriod : Form
    {

        string _contractCode = "";
        string _type = "";
        
        public SelectStatementPeriod()
        {
            InitializeComponent();
        }

        public SelectStatementPeriod(string contractCode, string type)
        {
            
            InitializeComponent();
            _contractCode = contractCode;
            _type = type;
            lblContractCode.Text = contractCode;
          
          
            
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            CurrentAccountProductHoldingServices CurrentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
            List<TransactionSearchResult> dt = CurrentAccountProductHoldingServices.GenerateCurrentAccountStatement(_contractCode, from, to);
            StatementViewer statementViewer = new StatementViewer(dt);
            statementViewer.Show();
           
        }

        private void tbToDate_Click(object sender, EventArgs e)
        {
            
        }

        private void tbFromDate_Click(object sender, EventArgs e)
        {
            
        }

        private void mcFrom_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void SelectStatementPeriod_Load(object sender, EventArgs e)
        {

        }
    }
}
