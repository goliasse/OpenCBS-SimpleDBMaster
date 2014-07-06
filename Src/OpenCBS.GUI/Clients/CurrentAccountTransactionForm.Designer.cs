namespace OpenCBS.GUI.Clients
{
    partial class CurrentAccountTransactionForm
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
            this.lblAmountTransferMethod = new System.Windows.Forms.Label();
            this.rbDebit = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTransactionFees = new System.Windows.Forms.Label();
            this.tbTransactionFees = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.cbFromAccount = new System.Windows.Forms.ComboBox();
            this.cbToAccount = new System.Windows.Forms.ComboBox();
            this.cbMaker = new System.Windows.Forms.ComboBox();
            this.cbChecker = new System.Windows.Forms.ComboBox();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbTransactionType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.tbTransactionDate = new System.Windows.Forms.TextBox();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmountTransferMethod
            // 
            this.lblAmountTransferMethod.AutoSize = true;
            this.lblAmountTransferMethod.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblAmountTransferMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAmountTransferMethod.Location = new System.Drawing.Point(66, 32);
            this.lblAmountTransferMethod.Name = "lblAmountTransferMethod";
            this.lblAmountTransferMethod.Size = new System.Drawing.Size(94, 16);
            this.lblAmountTransferMethod.TabIndex = 31;
            this.lblAmountTransferMethod.Text = "Transfer Mode:";
            // 
            // rbDebit
            // 
            this.rbDebit.AutoSize = true;
            this.rbDebit.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbDebit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDebit.Location = new System.Drawing.Point(345, 30);
            this.rbDebit.Name = "rbDebit";
            this.rbDebit.Size = new System.Drawing.Size(56, 20);
            this.rbDebit.TabIndex = 32;
            this.rbDebit.Text = "Debit";
            this.rbDebit.CheckedChanged += new System.EventHandler(this.rbDebit_CheckedChanged);
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Checked = true;
            this.rbCredit.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbCredit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbCredit.Location = new System.Drawing.Point(252, 30);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(60, 20);
            this.rbCredit.TabIndex = 33;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit";
            this.rbCredit.CheckedChanged += new System.EventHandler(this.rbCredit_CheckedChanged);
            // 
            // lblFromAccount
            // 
            this.lblFromAccount.AutoSize = true;
            this.lblFromAccount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblFromAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFromAccount.Location = new System.Drawing.Point(66, 88);
            this.lblFromAccount.Name = "lblFromAccount";
            this.lblFromAccount.Size = new System.Drawing.Size(134, 16);
            this.lblFromAccount.TabIndex = 34;
            this.lblFromAccount.Text = "Select From Account:";
            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblToAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblToAccount.Location = new System.Drawing.Point(66, 118);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(117, 16);
            this.lblToAccount.TabIndex = 35;
            this.lblToAccount.Text = "Select To Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(66, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(66, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Transaction Maker";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(66, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Transaction Checker";
            // 
            // lblTransactionFees
            // 
            this.lblTransactionFees.AutoSize = true;
            this.lblTransactionFees.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTransactionFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTransactionFees.Location = new System.Drawing.Point(66, 270);
            this.lblTransactionFees.Name = "lblTransactionFees";
            this.lblTransactionFees.Size = new System.Drawing.Size(112, 16);
            this.lblTransactionFees.TabIndex = 41;
            this.lblTransactionFees.Text = "Transaction Fees:";
            this.lblTransactionFees.Visible = false;
            // 
            // tbTransactionFees
            // 
            this.tbTransactionFees.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbTransactionFees.Location = new System.Drawing.Point(252, 267);
            this.tbTransactionFees.Name = "tbTransactionFees";
            this.tbTransactionFees.Size = new System.Drawing.Size(149, 22);
            this.tbTransactionFees.TabIndex = 42;
            this.tbTransactionFees.Visible = false;
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbAmount.Location = new System.Drawing.Point(252, 148);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(149, 22);
            this.tbAmount.TabIndex = 43;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // cbFromAccount
            // 
            this.cbFromAccount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbFromAccount.FormattingEnabled = true;
            this.cbFromAccount.Location = new System.Drawing.Point(252, 88);
            this.cbFromAccount.Name = "cbFromAccount";
            this.cbFromAccount.Size = new System.Drawing.Size(149, 24);
            this.cbFromAccount.TabIndex = 44;
            // 
            // cbToAccount
            // 
            this.cbToAccount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbToAccount.FormattingEnabled = true;
            this.cbToAccount.Location = new System.Drawing.Point(252, 118);
            this.cbToAccount.Name = "cbToAccount";
            this.cbToAccount.Size = new System.Drawing.Size(149, 24);
            this.cbToAccount.TabIndex = 45;
            // 
            // cbMaker
            // 
            this.cbMaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaker.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbMaker.FormattingEnabled = true;
            this.cbMaker.Location = new System.Drawing.Point(252, 179);
            this.cbMaker.Name = "cbMaker";
            this.cbMaker.Size = new System.Drawing.Size(149, 24);
            this.cbMaker.TabIndex = 48;
            // 
            // cbChecker
            // 
            this.cbChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChecker.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbChecker.FormattingEnabled = true;
            this.cbChecker.Location = new System.Drawing.Point(252, 209);
            this.cbChecker.Name = "cbChecker";
            this.cbChecker.Size = new System.Drawing.Size(149, 24);
            this.cbChecker.TabIndex = 49;
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMakeTransaction.Location = new System.Drawing.Point(66, 321);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(115, 28);
            this.btnMakeTransaction.TabIndex = 50;
            this.btnMakeTransaction.Text = "Make Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnExtendPeriod_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(252, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 28);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransactionType.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Transfer"});
            this.cbTransactionType.Location = new System.Drawing.Point(252, 56);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(149, 24);
            this.cbTransactionType.TabIndex = 53;
            this.cbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cbTransactionType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(66, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Amount Transfer Method:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(66, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Purpose Of Transfer";
            // 
            // tbPurpose
            // 
            this.tbPurpose.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbPurpose.Location = new System.Drawing.Point(252, 238);
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.Size = new System.Drawing.Size(149, 22);
            this.tbPurpose.TabIndex = 55;
            this.tbPurpose.Text = "Default";
            // 
            // tbTransactionDate
            // 
            this.tbTransactionDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbTransactionDate.Location = new System.Drawing.Point(252, 293);
            this.tbTransactionDate.Name = "tbTransactionDate";
            this.tbTransactionDate.Size = new System.Drawing.Size(149, 22);
            this.tbTransactionDate.TabIndex = 57;
            this.tbTransactionDate.Visible = false;
            this.tbTransactionDate.WordWrap = false;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTransactionDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTransactionDate.Location = new System.Drawing.Point(66, 299);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(110, 16);
            this.lblTransactionDate.TabIndex = 56;
            this.lblTransactionDate.Text = "Transaction Date:";
            this.lblTransactionDate.Visible = false;
            // 
            // CurrentAccountTransactionForm
            // 
            this.AcceptButton = this.btnMakeTransaction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(493, 378);
            this.Controls.Add(this.tbTransactionDate);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.tbPurpose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTransactionType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMakeTransaction);
            this.Controls.Add(this.cbChecker);
            this.Controls.Add(this.cbMaker);
            this.Controls.Add(this.cbToAccount);
            this.Controls.Add(this.cbFromAccount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbTransactionFees);
            this.Controls.Add(this.lblTransactionFees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToAccount);
            this.Controls.Add(this.lblFromAccount);
            this.Controls.Add(this.rbDebit);
            this.Controls.Add(this.rbCredit);
            this.Controls.Add(this.lblAmountTransferMethod);
            this.Name = "CurrentAccountTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Current Account Transaction";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmountTransferMethod;
        private System.Windows.Forms.RadioButton rbDebit;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.Label lblFromAccount;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTransactionFees;
        private System.Windows.Forms.TextBox tbTransactionFees;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ComboBox cbFromAccount;
        private System.Windows.Forms.ComboBox cbToAccount;
        private System.Windows.Forms.ComboBox cbMaker;
        private System.Windows.Forms.ComboBox cbChecker;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbTransactionType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.TextBox tbTransactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
    }
}