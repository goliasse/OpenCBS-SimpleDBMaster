namespace OpenCBS.GUI.Accounting
{
    partial class BalanceSheet
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvBalanceSheet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalEquity = new System.Windows.Forms.Label();
            this.lblTotalLiabilities = new System.Windows.Forms.Label();
            this.lblTotalAssets = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTillDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cbBranches = new System.Windows.Forms.ComboBox();
            this.cbCurrencies = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(907, 36);
            this.label1.TabIndex = 54;
            this.label1.Text = "Balance Sheet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvBalanceSheet
            // 
            this.lvBalanceSheet.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvBalanceSheet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvBalanceSheet.FullRowSelect = true;
            this.lvBalanceSheet.GridLines = true;
            this.lvBalanceSheet.Location = new System.Drawing.Point(5, 48);
            this.lvBalanceSheet.Name = "lvBalanceSheet";
            this.lvBalanceSheet.Size = new System.Drawing.Size(464, 492);
            this.lvBalanceSheet.TabIndex = 53;
            this.lvBalanceSheet.UseCompatibleStateImageBehavior = false;
            this.lvBalanceSheet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S. No.";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Account";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 206;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Balance";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 166;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalEquity);
            this.groupBox1.Controls.Add(this.lblTotalLiabilities);
            this.groupBox1.Controls.Add(this.lblTotalAssets);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerTillDate);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.lblBranch);
            this.groupBox1.Controls.Add(this.lblCurrency);
            this.groupBox1.Controls.Add(this.cbBranches);
            this.groupBox1.Controls.Add(this.cbCurrencies);
            this.groupBox1.Location = new System.Drawing.Point(630, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 234);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalEquity
            // 
            this.lblTotalEquity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEquity.AutoSize = true;
            this.lblTotalEquity.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTotalEquity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalEquity.Location = new System.Drawing.Point(138, 204);
            this.lblTotalEquity.Name = "lblTotalEquity";
            this.lblTotalEquity.Size = new System.Drawing.Size(87, 16);
            this.lblTotalEquity.TabIndex = 80;
            this.lblTotalEquity.Text = "Total Assets :";
            // 
            // lblTotalLiabilities
            // 
            this.lblTotalLiabilities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLiabilities.AutoSize = true;
            this.lblTotalLiabilities.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTotalLiabilities.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalLiabilities.Location = new System.Drawing.Point(138, 179);
            this.lblTotalLiabilities.Name = "lblTotalLiabilities";
            this.lblTotalLiabilities.Size = new System.Drawing.Size(87, 16);
            this.lblTotalLiabilities.TabIndex = 79;
            this.lblTotalLiabilities.Text = "Total Assets :";
            // 
            // lblTotalAssets
            // 
            this.lblTotalAssets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAssets.AutoSize = true;
            this.lblTotalAssets.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTotalAssets.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalAssets.Location = new System.Drawing.Point(138, 153);
            this.lblTotalAssets.Name = "lblTotalAssets";
            this.lblTotalAssets.Size = new System.Drawing.Size(87, 16);
            this.lblTotalAssets.TabIndex = 78;
            this.lblTotalAssets.Text = "Total Assets :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(32, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Total Equity :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(32, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Total Liabilities :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(32, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Total Assets :";
            // 
            // dateTimePickerTillDate
            // 
            this.dateTimePickerTillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTillDate.Location = new System.Drawing.Point(113, 80);
            this.dateTimePickerTillDate.Name = "dateTimePickerTillDate";
            this.dateTimePickerTillDate.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerTillDate.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEndDate.Location = new System.Drawing.Point(27, 80);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 16);
            this.lblEndDate.TabIndex = 73;
            this.lblEndDate.Text = "Till Date";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnView.Location = new System.Drawing.Point(30, 116);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(236, 25);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblBranch.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBranch.Location = new System.Drawing.Point(27, 49);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(49, 16);
            this.lblBranch.TabIndex = 70;
            this.lblBranch.Text = "Branch";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCurrency.Location = new System.Drawing.Point(27, 19);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(60, 16);
            this.lblCurrency.TabIndex = 71;
            this.lblCurrency.Text = "Currency";
            // 
            // cbBranches
            // 
            this.cbBranches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBranches.DisplayMember = "Currency.Name";
            this.cbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranches.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBranches.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.cbBranches.FormattingEnabled = true;
            this.cbBranches.Location = new System.Drawing.Point(110, 49);
            this.cbBranches.Name = "cbBranches";
            this.cbBranches.Size = new System.Drawing.Size(156, 24);
            this.cbBranches.TabIndex = 1;
            // 
            // cbCurrencies
            // 
            this.cbCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCurrencies.DisplayMember = "Currency.Name";
            this.cbCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCurrencies.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.cbCurrencies.FormattingEnabled = true;
            this.cbCurrencies.Location = new System.Drawing.Point(110, 19);
            this.cbCurrencies.Name = "cbCurrencies";
            this.cbCurrencies.Size = new System.Drawing.Size(156, 24);
            this.cbCurrencies.TabIndex = 0;
            // 
            // BalanceSheet
            // 
            this.AcceptButton = this.btnView;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBalanceSheet);
            this.Name = "BalanceSheet";
            this.Text = "Balance Sheet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvBalanceSheet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalEquity;
        private System.Windows.Forms.Label lblTotalLiabilities;
        private System.Windows.Forms.Label lblTotalAssets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTillDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cbBranches;
        private System.Windows.Forms.ComboBox cbCurrencies;


    }
}