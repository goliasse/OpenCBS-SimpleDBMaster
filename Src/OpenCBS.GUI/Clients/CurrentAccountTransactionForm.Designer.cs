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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // lblAmountTransferMethod
            // 
            this.lblAmountTransferMethod.AutoSize = true;
            this.lblAmountTransferMethod.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblAmountTransferMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAmountTransferMethod.Location = new System.Drawing.Point(66, 30);
            this.lblAmountTransferMethod.Name = "lblAmountTransferMethod";
            this.lblAmountTransferMethod.Size = new System.Drawing.Size(94, 16);
            this.lblAmountTransferMethod.TabIndex = 31;
            this.lblAmountTransferMethod.Text = "Transfer Mode:";
            this.lblAmountTransferMethod.Visible = false;
            // 
            // rbDebit
            // 
            this.rbDebit.AutoSize = true;
            this.rbDebit.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbDebit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDebit.Location = new System.Drawing.Point(327, 30);
            this.rbDebit.Name = "rbDebit";
            this.rbDebit.Size = new System.Drawing.Size(56, 20);
            this.rbDebit.TabIndex = 32;
            this.rbDebit.Text = "Debit";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(66, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Select From Account:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(66, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select To Account:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(66, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Amount:";
            this.label3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(68, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Transaction Maker";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(68, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Transaction Checker";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(66, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Transaction Fees:";
            this.label8.Visible = false;
            // 
            // tbTransactionFees
            // 
            this.tbTransactionFees.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbTransactionFees.Location = new System.Drawing.Point(252, 239);
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
            // 
            // cbFromAccount
            // 
            this.cbFromAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromAccount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbFromAccount.FormattingEnabled = true;
            this.cbFromAccount.Items.AddRange(new object[] {
            "Opened",
            "Closed"});
            this.cbFromAccount.Location = new System.Drawing.Point(252, 88);
            this.cbFromAccount.Name = "cbFromAccount";
            this.cbFromAccount.Size = new System.Drawing.Size(149, 24);
            this.cbFromAccount.TabIndex = 44;
            // 
            // cbToAccount
            // 
            this.cbToAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToAccount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbToAccount.FormattingEnabled = true;
            this.cbToAccount.Items.AddRange(new object[] {
            "Opened",
            "Closed"});
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
            this.cbMaker.Items.AddRange(new object[] {
            "Opened",
            "Closed"});
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
            this.cbChecker.Items.AddRange(new object[] {
            "Opened",
            "Closed"});
            this.cbChecker.Location = new System.Drawing.Point(252, 209);
            this.cbChecker.Name = "cbChecker";
            this.cbChecker.Size = new System.Drawing.Size(149, 24);
            this.cbChecker.TabIndex = 49;
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMakeTransaction.Location = new System.Drawing.Point(63, 273);
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
            this.btnClose.Location = new System.Drawing.Point(252, 273);
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
            "Opened",
            "Closed"});
            this.cbTransactionType.Location = new System.Drawing.Point(252, 56);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(149, 24);
            this.cbTransactionType.TabIndex = 53;
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
            this.label5.Visible = false;
            // 
            // CurrentAccountTransactionForm
            // 
            this.AcceptButton = this.btnMakeTransaction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(493, 348);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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
    }
}