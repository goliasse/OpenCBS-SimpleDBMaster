// Octopus MFS is an integrated suite for managing a Micro Finance Institution: 
// clients, contracts, accounting, reporting and risk
// Copyright © 2006,2007 OCTO Technology & OXUS Development Network
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Services;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Enums;
using OpenCBS.CoreDomain.Contracts.Savings;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Shared;
using OpenCBS.CoreDomain.Events.Saving;
using Microsoft.Office.Interop.Word;
using OpenCBS.ExceptionsHandler;

namespace OpenCBS.GUI.UserControl
{
    public partial class SavingsListUserControl : System.Windows.Forms.UserControl
    {
        public event EventHandler AddSelectedSaving;
        public event EventHandler ViewSelectedSaving;
        ListViewItem totalItem = new ListViewItem("");
        //private bool _alreadyActiveCompulosrySavings;

        public bool ButtonAddSavingsEnabled
        {
            get { return buttonAddSaving.Enabled; }
            set { buttonAddSaving.Enabled = value; }
        }

        public OClientTypes ClientType { get; set; }

        public SavingsListUserControl()
        {
            InitializeComponent();
        }

        public void DisplaySavings(IEnumerable<ISavingsContract> pSavings)
        {
            OCurrency totalBalance = 0;
            OCurrency totalBalanceInPivot = 0;
            ExchangeRate latestExchangeRate;
            bool usedCents = false;

            string currencyCodeHolder = null; // to detect, if credits are in different currencies
            bool multiCurrency = false;

            lvSavings.Items.Clear();
            //_alreadyActiveCompulosrySavings = false;
            foreach (ISavingsContract saving in pSavings)
            {
                // it will be done for the first credit
                if (currencyCodeHolder == null) currencyCodeHolder = saving.Product.Currency.Code;

                //if not the first
                if (saving.Product.Currency.Code != currencyCodeHolder) multiCurrency = true;
                currencyCodeHolder = saving.Product.Currency.Code;

                //In case, if there are contracts in different currencies, total value of Balance is displayed in pivot currency

                latestExchangeRate =
                    ServicesProvider.GetInstance().GetAccountingServices().FindLatestExchangeRate(TimeProvider.Today,
                                                                                            saving.Product.Currency);
                string status = MultiLanguageStrings.GetString(Ressource.ClientForm, "Savings" + saving.Status + ".Text");
                ListViewItem item = new ListViewItem(saving.Code) { Tag = saving };
                item.SubItems.Add(MultiLanguageStrings.GetString(Ressource.ClientForm,
                    saving is SavingBookContract ? "SavingsBook.Text" : "CompulsorySavings.Text"));
                item.SubItems.Add(saving.Product.Name);
                item.SubItems.Add(saving.GetFmtBalance(false));
                item.SubItems.Add(saving.Product.Currency.Code);
                item.SubItems.Add(saving.CreationDate.ToShortDateString());
                item.SubItems.Add((saving.Events.Count != 0) ? saving.Events[saving.Events.Count - 1].Date.ToShortDateString() : "");
                item.SubItems.Add(status);
                item.SubItems.Add(saving.ClosedDate.HasValue ? saving.ClosedDate.Value.ToShortDateString() : "");

                totalBalance += saving.GetBalance();
                totalBalanceInPivot += latestExchangeRate.Rate == 0
                                           ? 0
                                           : saving.GetBalance() / latestExchangeRate.Rate;

                lvSavings.Items.Add(item);

                if (saving.Product.Currency.UseCents)
                    usedCents = saving.Product.Currency.UseCents;

                //if (saving is CompulsorySavings && saving.Status == OSavingsStatus.Active)
                //    _alreadyActiveCompulosrySavings = true;
            }

            totalItem.Font = new System.Drawing.Font(totalItem.Font, FontStyle.Bold);
            totalItem.SubItems.Add("");
            totalItem.SubItems.Add("");

            if (multiCurrency)
            {
                totalItem.SubItems.Add(totalBalanceInPivot.GetFormatedValue(ServicesProvider.GetInstance().GetCurrencyServices().GetPivot().UseCents && usedCents));
                totalItem.SubItems.Add(ServicesProvider.GetInstance().GetCurrencyServices().GetPivot().Code);
            }
            else
            {
                totalItem.SubItems.Add(totalBalance.GetFormatedValue(usedCents));
                totalItem.SubItems.Add(currencyCodeHolder);
            }

            lvSavings.Items.Add(totalItem);
        }

        private void buttonAddSaving_Click(object sender, EventArgs e)
        {
            FillDropDownMenuWithSavings(contextMenuStripSaving);
            contextMenuStripSaving.Show(buttonAddSaving, 0 - contextMenuStripSaving.Size.Width, 0);
        }

        private void FillDropDownMenuWithSavings(ContextMenuStrip pContextMenu)
        {
            pContextMenu.Items.Clear();
            SavingProductServices products = ServicesProvider.GetInstance().GetSavingProductServices();
            List<ISavingProduct> datas = products.FindAllSavingsProducts(false, ClientType);
            foreach (ISavingProduct savingProduct in datas)
            {
                var item = new ToolStripMenuItem(savingProduct.Name) { Tag = savingProduct };
                item.Click += item_Click;
                //if (_alreadyActiveCompulosrySavings && savingProduct is CompulsorySavingsProduct)
                //    item.Enabled = false;
                pContextMenu.Items.Add(item);
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            if (AddSelectedSaving != null)
                AddSelectedSaving(((ToolStripMenuItem)sender).Tag, e);
        }

        private void listViewSavings_DoubleClick(object sender, EventArgs e)
        {
            if (lvSavings.SelectedItems.Count > 0 && ViewSelectedSaving != null && lvSavings.SelectedItems[0] != totalItem)
                ViewSelectedSaving(lvSavings.SelectedItems[0].Tag, e);
        }

        private void buttonViewSaving_Click(object sender, EventArgs e)
        {
            if (lvSavings.SelectedItems.Count > 0 && ViewSelectedSaving != null)
                ViewSelectedSaving(lvSavings.SelectedItems[0].Tag, e);
        }

        private void btnGenerateSavingStatement_Click(object sender, EventArgs e)
        {
            try
            {

                ISavingsContract pSaving = (ISavingsContract)lvSavings.SelectedItems[0].Tag;


                List<SavingEvent> events = pSaving.Events;

                bool useCents = pSaving.Product.Currency.UseCents;

                String[] columnName = { "Date", "Fee", "Debit", "Credit", "Method", "Description" };
                String[,] data = new String[events.Count, 6];
                int i = 0;
                foreach (SavingEvent eve in events)
                {
                    data[i, 0] = (eve.Date.ToString("dd/MM/yyyy"));
                    data[i, 1] = (eve.Fee.GetFormatedValue(useCents));
                    string amt = eve.Amount.GetFormatedValue(useCents);
                    data[i, 2] = (eve.IsDebit ? amt : string.Empty);
                    data[i, 3] = (eve.IsDebit ? string.Empty : amt);
                    
                    
                    data[i, 4] = (eve.SavingsMethod.HasValue ? new SweetBaseForm().GetString("SavingsOperationForm", eve.SavingsMethod + ".Text") : eve.ExtraInfo);


                    data[i, 5] = (eve.Description);


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
                    headerRange.Text = "<Bank Name>";
                }

                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "Account Statement";
                }

                //adding text to document

                document.Content.SetRange(0, 0);

                document.Content.Text = document.Content.Text + "Customer Name     : " + pSaving.Client.Name;
                document.Content.Text = document.Content.Text + "Saving Contract Code: " + pSaving.Code;
                document.Content.Text = document.Content.Text + "Statement Date    : " + DateTime.Today.ToShortDateString();
                document.Content.Text = document.Content.Text + "Interest Rate    : " + pSaving.InterestRate;
                document.Content.Text = document.Content.Text + "Account Open Date    : " + pSaving.CreationDate.ToShortDateString();
                document.Content.Text = document.Content.Text + "Account Status    : " + pSaving.Status;
                document.Content.Text = document.Content.Text + "Account Balance       : " + pSaving.GetBalance();
                
                document.Content.Text = document.Content.Text + Environment.NewLine;
                document.Content.Text = document.Content.Text + "Subject: Account statement for contract code " + pSaving.Code;
                document.Content.Text = document.Content.Text + "Dear Sir,";

                document.Content.Text = document.Content.Text + "Thank you for continuing your banking relationship with us. It’s a secure way to protect your money and valuables.";

                document.Content.Text = document.Content.Text + "Please find the your account statement for the contract code " + pSaving.Code + ".";

                //Add paragraph with Heading 1 style
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);

                //Create a 5X5 table and insert some dummy record
                Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para1.Range, events.Count + 1, 6, ref missing, ref missing);



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
                para2.Range.Text = para2.Range.Text + "Bank Representative";
                para2.Range.Text = para2.Range.Text + "Name of bank";
                para2.Range.InsertParagraphAfter();

                //Save the document
                object filename = @"E:\temp1.docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");


            }


            catch (Exception ex)
            {
                try
                {

                    throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FixedDepositProductSelectAProduct);
                }
                catch (Exception exc)
                {
                    new frmShowError(CustomExceptionHandler.ShowExceptionText(exc)).ShowDialog();
                }
            }

        }

        private void btnSAChargesNotice_Click(object sender, EventArgs e)
        {
            try
            {

                ISavingsContract pSaving = (ISavingsContract)lvSavings.SelectedItems[0].Tag;
                List<SavingEvent> events = pSaving.Events;
                bool useCents = pSaving.Product.Currency.UseCents;

                String[] columnName = { "Date", "Fee", "Description" };
                String[,] data = new String[events.Count, 3];
                int i = 0;
                decimal totalFees = 0;
                foreach (SavingEvent eve in events)
                {
                    if (eve.Fee.Value != 0)
                    {
                    data[i, 0] = (eve.Date.ToString("dd/MM/yyyy"));
                    data[i, 1] = (eve.Fee.GetFormatedValue(useCents));
                    data[i, 2] = (eve.Description);
                    totalFees = totalFees + eve.Fee.Value;
                    i++;
                    }
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
                    headerRange.Text = "<Bank Name>";
                }

                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "Charges Notice " + pSaving.Code;
                }

                //adding text to document

                document.Content.SetRange(0, 0);

                document.Content.Text = document.Content.Text + "Customer Name     : " + pSaving.Client.Name;
                document.Content.Text = document.Content.Text + "Saving Contract Code: " + pSaving.Code;
                document.Content.Text = document.Content.Text + "Notice Date    : " + DateTime.Today.ToShortDateString();
                document.Content.Text = document.Content.Text + "Interest Rate    : " + pSaving.InterestRate;
                document.Content.Text = document.Content.Text + "Account Open Date    : " + pSaving.CreationDate.ToShortDateString();
                document.Content.Text = document.Content.Text + "Account Status    : " + pSaving.Status;
                document.Content.Text = document.Content.Text + "Account Balance       : " + pSaving.GetBalance();
                document.Content.Text = document.Content.Text + "Total Fees       : " + totalFees;

                document.Content.Text = document.Content.Text + Environment.NewLine;
                document.Content.Text = document.Content.Text + "Subject: Charges notice for contract code " + pSaving.Code;
                document.Content.Text = document.Content.Text + "Dear Sir,";
                document.Content.Text = document.Content.Text + "Thank you for continuing your banking relationship with us. It’s a secure way to protect your money and valuables.";

                document.Content.Text = document.Content.Text + "Your account has been charged for the following items.";

                //Add paragraph with Heading 1 style
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);

                //Create a 5X5 table and insert some dummy record
                Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para1.Range, events.Count + 1, 3, ref missing, ref missing);



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
                para2.Range.Text = para2.Range.Text + "Bank Representative";
                para2.Range.Text = para2.Range.Text + "Name of bank";
                para2.Range.InsertParagraphAfter();

                //Save the document
                object filename = @"E:\temp1.docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");


            }


            catch (Exception ex)
            {
                try
                {

                    throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FixedDepositProductSelectAProduct);
                }
                catch (Exception exc)
                {
                    new frmShowError(CustomExceptionHandler.ShowExceptionText(exc)).ShowDialog();
                }
            }
        }
    }
}

