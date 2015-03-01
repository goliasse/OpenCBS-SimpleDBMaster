using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Office.Interop.Word;
using OpenCBS.CoreDomain.Clients;
using OpenCBS.CoreDomain.Products;
using OpenCBS.CoreDomain.SearchResult;
using OpenCBS.Services;

namespace OpenCBS.GUI.Clients
{
    public partial class SelectStatementPeriod : Form
    {
        string noticePath = "";
        int officeVersion = 0;
        string bankName = "";
        string bankRepresentative = "";

        ApplicationSettingsServices _applicationSettingsServices = ServicesProvider.GetInstance().GetApplicationSettingsServices();
        
        string _contractCode = "";
        string _type = "";
        IClient _client = null;
        public SelectStatementPeriod()
        {
            InitializeComponent();
            Init();
        }

        public SelectStatementPeriod(string contractCode, string type, IClient client)
        {
            
            InitializeComponent();
            Init();
            _contractCode = contractCode;
            _type = type;
            lblContractCode.Text = contractCode;
            _client = client;
          
            
        }

        private void Init()
        {
            noticePath = _applicationSettingsServices.SelectParameterValue("NOTICE_PATH").ToString();
            officeVersion = _applicationSettingsServices.GetOfficeVersion();
            bankName = _applicationSettingsServices.SelectParameterValue("BANK_NAME").ToString();
            bankRepresentative = _applicationSettingsServices.SelectParameterValue("BANK_REPRESENTATIVE").ToString();

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            btnGenerateReport.Text = "Creating Report...";
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            if (_type == "CA")
            {
                CurrentAccountProductHoldingServices currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
                CurrentAccountProductHoldings currentAccountProductHolding = currentAccountProductHoldingServices.FetchProduct(_contractCode);
                List<TransactionSearchResult> dt = currentAccountProductHoldingServices.GenerateCurrentAccountStatement(_contractCode, from, to);

                //StatementViewer statementViewer = new StatementViewer(dt);
                //statementViewer.Show();
                if (dt != null)
                {
                    String[] columnName = { "Date", "Description", "Mode", "Amount", "Balance" };
                    String[,] data = new String[dt.Count, 5];
                    int i = 0;
                    foreach (TransactionSearchResult tsr in dt)
                    {


                        data[i, 0] = tsr.TransactionDate.ToShortDateString();
                        data[i, 1] = tsr.Description;
                        data[i, 2] = tsr.Mode;
                        data[i, 3] = tsr.Amount.ToString();
                        data[i, 4] = tsr.Balance.ToString();
                        i++;

                    }

                    //Create an instance for word app
                    Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                    //Set animation status for word application
                    //winword.ShowAnimation = false;

                    //Set status for word application is to be visible or not.
                    winword.Visible = false;

                    //Create a missing variable for missing value
                    object missing = System.Reflection.Missing.Value;

                    //Create a new document
                    Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                    //Add header into the document
                    foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                    {
                        //Get the header range and add the header details.
                        Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                        headerRange.Font.Size = 10;
                        headerRange.Text = bankName;
                    }

                    //Add the footers into the document
                    foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                    {
                        //Get the footer range and add the footer details.
                        Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                        footerRange.Font.Size = 10;
                        footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        footerRange.Text = "Account Statement " + _contractCode;
                    }

                    //adding text to document

                    document.Content.SetRange(0, 0);

                    document.Content.Text = document.Content.Text + "Customer Name      : " + _client.Name;
                    document.Content.Text = document.Content.Text + "Current Account Contract Code : " + _contractCode;
                    document.Content.Text = document.Content.Text + "Statement Date     : " + DateTime.Today.ToShortDateString();
                    document.Content.Text = document.Content.Text + "Account Balance    : " + currentAccountProductHolding.Balance.GetFormatedValue(false);
                    document.Content.Text = document.Content.Text + "Contract Status    : " + currentAccountProductHolding.Status;
                    document.Content.Text = document.Content.Text + "Statement From Date: " + from.ToShortDateString();
                    document.Content.Text = document.Content.Text + "Statement To Date  : " + to.ToShortDateString();

                    document.Content.Text = document.Content.Text + "Subject: Account statement for contract code " + _contractCode;
                    document.Content.Text = document.Content.Text + "Dear Sir,";

                    document.Content.Text = document.Content.Text + "Thank you for continuing your banking relationship with us. It’s a secure way to protect your money and valuables.";

                    document.Content.Text = document.Content.Text + "Please find the your account statement for the contract code " + _contractCode + ".";

                    //Add paragraph with Heading 1 style
                    Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);

                    //Create a 5X5 table and insert some dummy record
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para1.Range, dt.Count + 1, 5, ref missing, ref missing);



                    firstTable.Borders.Enable = 1;
                    foreach (Row row in firstTable.Rows)
                    {
                        if (row.Index == 1)
                        {
                            foreach (Cell cell in row.Cells)
                            {     //Header row

                                cell.Range.Text = columnName[cell.ColumnIndex - 1];
                                cell.Range.Font.Bold = 1;
                                //other format properties goes here
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                                //Center alignment for the Header cells
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                            }
                        }

                        //Data row
                        if (row.Index != 1)
                        {
                            foreach (Cell cell in row.Cells)
                            {
                                cell.Range.Text = data[row.Index - 2, cell.ColumnIndex - 1];
                            }
                        }

                    }

                    //Add paragraph with Heading 2 style
                    Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                    para2.Range.Text = Environment.NewLine + "Should you have any questions or require additional information, please call the phone number that is listed on your loan statement.";

                    para2.Range.Text = para2.Range.Text + "We are proud to serve you. Thank you Sir/Mam.";
                    para2.Range.Text = para2.Range.Text + Environment.NewLine + "Regards,";
                    para2.Range.Text = para2.Range.Text + bankRepresentative;
                    para2.Range.Text = para2.Range.Text + bankName;
                    para2.Range.InsertParagraphAfter();

                    //Save the document
                    object filename = noticePath + _contractCode.Replace('/', '_') + "_Account Statement.docx";

                    if (officeVersion <= 2007)
                        document.SaveAs(ref filename);
                    else
                        document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;
                    MessageBox.Show("Document created successfully !");
                }
                else
                {
                    MessageBox.Show("No Charges for the selected account !");
                }
            }
            else if (_type == "FD")
            {
                CurrentAccountProductHoldingServices currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
                FixedDepositProductHoldingServices fixedDepositProductHoldingServices = ServicesProvider.GetInstance().GetFixedDepositProductHoldingServices();
                FixedDepositProductHoldings fixedDepositProductHolding = fixedDepositProductHoldingServices.FetchProduct(_contractCode);
                List<TransactionSearchResult> dt = currentAccountProductHoldingServices.GenerateCurrentAccountStatement(_contractCode, from, to);

                //StatementViewer statementViewer = new StatementViewer(dt);
                //statementViewer.Show();
                if (dt != null)
                {
                    String[] columnName = { "Date", "Description", "Mode", "Amount", "Balance" };
                    String[,] data = new String[dt.Count, 5];
                    int i = 0;
                    foreach (TransactionSearchResult tsr in dt)
                    {


                        data[i, 0] = tsr.TransactionDate.ToShortDateString();
                        data[i, 1] = tsr.Description;
                        data[i, 2] = tsr.Mode;
                        data[i, 3] = tsr.Amount.ToString();
                        data[i, 4] = tsr.Balance.ToString();
                        i++;

                    }

                    //Create an instance for word app
                    Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                    //Set animation status for word application
                    //winword.ShowAnimation = false;

                    //Set status for word application is to be visible or not.
                    winword.Visible = false;

                    //Create a missing variable for missing value
                    object missing = System.Reflection.Missing.Value;

                    //Create a new document
                    Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                    //Add header into the document
                    foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                    {
                        //Get the header range and add the header details.
                        Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                        headerRange.Font.Size = 10;
                        headerRange.Text = bankName;
                    }

                    //Add the footers into the document
                    foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                    {
                        //Get the footer range and add the footer details.
                        Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                        footerRange.Font.Size = 10;
                        footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        footerRange.Text = "Account Statement " + _contractCode;
                    }

                    //adding text to document

                    document.Content.SetRange(0, 0);

                    document.Content.Text = document.Content.Text + "Customer Name      : " + _client.Name;
                    document.Content.Text = document.Content.Text + "Contract Code : " + _contractCode;
                    document.Content.Text = document.Content.Text + "Open Date     : " + fixedDepositProductHolding.OpenDate.ToShortDateString();
                    document.Content.Text = document.Content.Text + "Initial Amount    : " + fixedDepositProductHolding.InitialAmount.GetFormatedValue(false);
                    document.Content.Text = document.Content.Text + "Interest Rate    : " + fixedDepositProductHolding.InterestRate + "% Yearly";
                    document.Content.Text = document.Content.Text + "Maturity Period    : " + fixedDepositProductHolding.MaturityPeriod + " Days";
                    document.Content.Text = document.Content.Text + "Interest Calculation Frequency : " + fixedDepositProductHolding.InterestCalculationFrequency + " Month";
                    if (fixedDepositProductHolding.Status!="Closed")
                    document.Content.Text = document.Content.Text + "Final Amount till date    : " + fixedDepositProductHoldingServices.CalculateFinalAmount(_contractCode).FinalAmount.GetFormatedValue(false);
                    else
                    document.Content.Text = document.Content.Text + "Final Amount on Closing    : " + fixedDepositProductHoldingServices.CalculateFinalAmount(_contractCode).FinalAmount.GetFormatedValue(false);
                    document.Content.Text = document.Content.Text + "Contract Status    : " + fixedDepositProductHolding.Status;
                    document.Content.Text = document.Content.Text + "Statement From Date: " + from.ToShortDateString();
                    document.Content.Text = document.Content.Text + "Statement To Date  : " + to.ToShortDateString();

                    document.Content.Text = document.Content.Text + "Subject: Account statement for contract code " + _contractCode;
                    document.Content.Text = document.Content.Text + "Dear Sir,";

                    document.Content.Text = document.Content.Text + "Thank you for continuing your banking relationship with us. It’s a secure way to protect your money and valuables.";

                    document.Content.Text = document.Content.Text + "Please find the your account statement for the contract code " + _contractCode + ".";

                    //Add paragraph with Heading 1 style
                    Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);

                    //Create a 5X5 table and insert some dummy record
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para1.Range, dt.Count + 1, 5, ref missing, ref missing);



                    firstTable.Borders.Enable = 1;
                    foreach (Row row in firstTable.Rows)
                    {
                        if (row.Index == 1)
                        {
                            foreach (Cell cell in row.Cells)
                            {     //Header row

                                cell.Range.Text = columnName[cell.ColumnIndex - 1];
                                cell.Range.Font.Bold = 1;
                                //other format properties goes here
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                                //Center alignment for the Header cells
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                            }
                        }

                        //Data row
                        if (row.Index != 1)
                        {
                            foreach (Cell cell in row.Cells)
                            {
                                cell.Range.Text = data[row.Index - 2, cell.ColumnIndex - 1];
                            }
                        }

                    }

                    //Add paragraph with Heading 2 style
                    Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                    para2.Range.Text = Environment.NewLine + "Should you have any questions or require additional information, please call the phone number that is listed on your loan statement.";

                    para2.Range.Text = para2.Range.Text + "We are proud to serve you. Thank you Sir/Mam.";
                    para2.Range.Text = para2.Range.Text + Environment.NewLine + "Regards,";
                    para2.Range.Text = para2.Range.Text + bankRepresentative;
                    para2.Range.Text = para2.Range.Text + bankName;
                    para2.Range.InsertParagraphAfter();

                    //Save the document
                    object filename = noticePath + _contractCode.Replace('/', '_') + "_Account Statement.docx";

                    if (officeVersion <= 2007)
                        document.SaveAs(ref filename);
                    else
                        document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;
                    MessageBox.Show("Document created successfully !");
                }
                else
                {
                    MessageBox.Show("No Charges for the selected account !");
                }
            }

            btnGenerateReport.Text = "Generate Report";
           
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
