namespace OpenCBS.GUI.Accounting
{
    partial class AddCOARule
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
            this.cmbEventCode = new System.Windows.Forms.ComboBox();
            this.lbEventType = new System.Windows.Forms.Label();
            this.cmbCreditAccount = new System.Windows.Forms.ComboBox();
            this.cmbDebitAccount = new System.Windows.Forms.ComboBox();
            this.lbCreditAccount = new System.Windows.Forms.Label();
            this.lbDebitAccount = new System.Windows.Forms.Label();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cbBranches = new System.Windows.Forms.ComboBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEventCode
            // 
            this.cmbEventCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbEventCode.FormattingEnabled = true;
            this.cmbEventCode.Location = new System.Drawing.Point(124, 12);
            this.cmbEventCode.Name = "cmbEventCode";
            this.cmbEventCode.Size = new System.Drawing.Size(267, 21);
            this.cmbEventCode.TabIndex = 0;
            // 
            // lbEventType
            // 
            this.lbEventType.AutoSize = true;
            this.lbEventType.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbEventType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEventType.Location = new System.Drawing.Point(5, 14);
            this.lbEventType.Name = "lbEventType";
            this.lbEventType.Size = new System.Drawing.Size(69, 16);
            this.lbEventType.TabIndex = 10;
            this.lbEventType.Text = "Event type";
            // 
            // cmbCreditAccount
            // 
            this.cmbCreditAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbCreditAccount.FormattingEnabled = true;
            this.cmbCreditAccount.Location = new System.Drawing.Point(124, 96);
            this.cmbCreditAccount.Name = "cmbCreditAccount";
            this.cmbCreditAccount.Size = new System.Drawing.Size(267, 21);
            this.cmbCreditAccount.TabIndex = 3;
            // 
            // cmbDebitAccount
            // 
            this.cmbDebitAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebitAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbDebitAccount.FormattingEnabled = true;
            this.cmbDebitAccount.Location = new System.Drawing.Point(124, 69);
            this.cmbDebitAccount.Name = "cmbDebitAccount";
            this.cmbDebitAccount.Size = new System.Drawing.Size(267, 21);
            this.cmbDebitAccount.TabIndex = 2;
            // 
            // lbCreditAccount
            // 
            this.lbCreditAccount.AutoSize = true;
            this.lbCreditAccount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbCreditAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCreditAccount.Location = new System.Drawing.Point(5, 97);
            this.lbCreditAccount.Name = "lbCreditAccount";
            this.lbCreditAccount.Size = new System.Drawing.Size(92, 16);
            this.lbCreditAccount.TabIndex = 5;
            this.lbCreditAccount.Text = "Credit account";
            // 
            // lbDebitAccount
            // 
            this.lbDebitAccount.AutoSize = true;
            this.lbDebitAccount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbDebitAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDebitAccount.Location = new System.Drawing.Point(5, 69);
            this.lbDebitAccount.Name = "lbDebitAccount";
            this.lbDebitAccount.Size = new System.Drawing.Size(88, 16);
            this.lbDebitAccount.TabIndex = 6;
            this.lbDebitAccount.Text = "Debit account";
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCurrency.Location = new System.Drawing.Point(5, 42);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(60, 16);
            this.lbCurrency.TabIndex = 9;
            this.lbCurrency.Text = "Currency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(124, 42);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(267, 21);
            this.cmbCurrency.TabIndex = 1;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblBranch.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBranch.Location = new System.Drawing.Point(5, 121);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(49, 16);
            this.lblBranch.TabIndex = 72;
            this.lblBranch.Text = "Branch";
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
            this.cbBranches.Location = new System.Drawing.Point(124, 123);
            this.cbBranches.Name = "cbBranches";
            this.cbBranches.Size = new System.Drawing.Size(267, 24);
            this.cbBranches.TabIndex = 4;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRule.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAddRule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddRule.Location = new System.Drawing.Point(124, 164);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(125, 25);
            this.btnAddRule.TabIndex = 5;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // AddCOARule
            // 
            this.AcceptButton = this.btnAddRule;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 219);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.cbBranches);
            this.Controls.Add(this.cmbEventCode);
            this.Controls.Add(this.lbEventType);
            this.Controls.Add(this.cmbCreditAccount);
            this.Controls.Add(this.cmbDebitAccount);
            this.Controls.Add(this.lbCreditAccount);
            this.Controls.Add(this.lbDebitAccount);
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.cmbCurrency);
            this.Name = "AddCOARule";
            this.Text = "Add COA Rule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEventCode;
        private System.Windows.Forms.Label lbEventType;
        private System.Windows.Forms.ComboBox cmbCreditAccount;
        private System.Windows.Forms.ComboBox cmbDebitAccount;
        private System.Windows.Forms.Label lbCreditAccount;
        private System.Windows.Forms.Label lbDebitAccount;
        private System.Windows.Forms.Label lbCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cbBranches;
        private System.Windows.Forms.Button btnAddRule;
    }
}