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
    public partial class StatementViewer : Form
    {

        ReportDocument rpt = new ReportDocument();

        public StatementViewer()
        {
            InitializeComponent();
        }

        public StatementViewer(List<TransactionSearchResult> dt)
        {
            InitializeComponent();

           
           
                rpt.Load(@"H:\OpenCBS-SimpleDB\Src\OpenCBS.GUI\Clients\CrystalReport1.rpt");


                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();


                DataSet1 ds = new DataSet1();
                DataTable t = ds.Tables.Add("Items");
                t.Columns.Add("Account", Type.GetType("System.String"));
                t.Columns.Add("Date", Type.GetType("System.String"));
                t.Columns.Add("Amount", Type.GetType("System.String"));
                t.Columns.Add("Balance", Type.GetType("System.String"));
                t.Columns.Add("Description", Type.GetType("System.String"));
                DataRow r;
                int i = 0;


                foreach (TransactionSearchResult tsr in dt)
                {
                    r = t.NewRow();
                    r["Account"] = tsr.Account;
                    r["Date"] = tsr.TransactionDate.ToShortDateString();
                    r["Amount"] = tsr.Amount;
                    r["Balance"] = tsr.Balance;
                    r["Description"] = tsr.Description;
                    t.Rows.Add(r);
                }


                CrystalReport1 objRpt = new CrystalReport1();
                objRpt.SetDataSource(ds.Tables[1]);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();


         
        }
    }
}
