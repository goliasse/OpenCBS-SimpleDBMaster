namespace OpenCBS.GUI.Clients
{
    partial class StatementViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccountStatementCrystalReport1 = new OpenCBS.GUI.Clients.AccountStatementCrystalReport();
            this.AccountStatementCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // AccountStatementCrystalReportViewer
            // 
            this.AccountStatementCrystalReportViewer.ActiveViewIndex = -1;
            this.AccountStatementCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountStatementCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.AccountStatementCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountStatementCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.AccountStatementCrystalReportViewer.Name = "AccountStatementCrystalReportViewer";
            this.AccountStatementCrystalReportViewer.Size = new System.Drawing.Size(1022, 548);
            this.AccountStatementCrystalReportViewer.TabIndex = 0;
            // 
            // StatementViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 548);
            this.Controls.Add(this.AccountStatementCrystalReportViewer);
            this.Name = "StatementViewer";
            this.Text = "Statement Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private AccountStatementCrystalReport AccountStatementCrystalReport1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer AccountStatementCrystalReportViewer;
    }
}