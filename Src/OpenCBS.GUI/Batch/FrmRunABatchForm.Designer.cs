namespace OpenCBS.GUI.Batch
{
    partial class FrmRunABatchForm
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
            this.btnRunAllBatches = new System.Windows.Forms.Button();
            this.btnAccountManagementFees = new System.Windows.Forms.Button();
            this.btnDormantAccount = new System.Windows.Forms.Button();
            this.btnCommitmentFees = new System.Windows.Forms.Button();
            this.btnOverdraftFees = new System.Windows.Forms.Button();
            this.btnCurrentAccountInterest = new System.Windows.Forms.Button();
            this.btnRunSelectedBatches = new System.Windows.Forms.Button();
            this.cbCurrentAccountInterest = new System.Windows.Forms.CheckBox();
            this.cbOverdraftFees = new System.Windows.Forms.CheckBox();
            this.cbCommitmentFees = new System.Windows.Forms.CheckBox();
            this.cbDormantAccount = new System.Windows.Forms.CheckBox();
            this.cbCurrentAccMgmtFees = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExcludedCurrentContractCode = new System.Windows.Forms.TextBox();
            this.cbFixedODFees = new System.Windows.Forms.CheckBox();
            this.btnFixedODFees = new System.Windows.Forms.Button();
            this.dtpAllBatches = new System.Windows.Forms.DateTimePicker();
            this.dtpSelectedBatchs = new System.Windows.Forms.DateTimePicker();
            this.dtpCAIBatch = new System.Windows.Forms.DateTimePicker();
            this.dtpFODFBatch = new System.Windows.Forms.DateTimePicker();
            this.dtpCFCBatch = new System.Windows.Forms.DateTimePicker();
            this.dtpODICBatch = new System.Windows.Forms.DateTimePicker();
            this.dtpAMFCBatch = new System.Windows.Forms.DateTimePicker();
            this.dtpDABatch = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAllBatchDate = new System.Windows.Forms.CheckBox();
            this.cbSelectedBatch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRunAllBatches
            // 
            this.btnRunAllBatches.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRunAllBatches.Location = new System.Drawing.Point(82, 63);
            this.btnRunAllBatches.Name = "btnRunAllBatches";
            this.btnRunAllBatches.Size = new System.Drawing.Size(182, 26);
            this.btnRunAllBatches.TabIndex = 0;
            this.btnRunAllBatches.Text = "Run All Batches";
            this.btnRunAllBatches.Click += new System.EventHandler(this.btnRunAllBatches_Click);
            // 
            // btnAccountManagementFees
            // 
            this.btnAccountManagementFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccountManagementFees.Location = new System.Drawing.Point(82, 287);
            this.btnAccountManagementFees.Name = "btnAccountManagementFees";
            this.btnAccountManagementFees.Size = new System.Drawing.Size(182, 26);
            this.btnAccountManagementFees.TabIndex = 13;
            this.btnAccountManagementFees.Text = "Account Management Fees";
            this.btnAccountManagementFees.Click += new System.EventHandler(this.btnAccountManagementFees_Click);
            // 
            // btnDormantAccount
            // 
            this.btnDormantAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDormantAccount.Location = new System.Drawing.Point(82, 255);
            this.btnDormantAccount.Name = "btnDormantAccount";
            this.btnDormantAccount.Size = new System.Drawing.Size(182, 26);
            this.btnDormantAccount.TabIndex = 11;
            this.btnDormantAccount.Text = "Dormant Account";
            this.btnDormantAccount.Click += new System.EventHandler(this.btnDormantAccount_Click);
            // 
            // btnCommitmentFees
            // 
            this.btnCommitmentFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCommitmentFees.Location = new System.Drawing.Point(82, 191);
            this.btnCommitmentFees.Name = "btnCommitmentFees";
            this.btnCommitmentFees.Size = new System.Drawing.Size(182, 26);
            this.btnCommitmentFees.TabIndex = 7;
            this.btnCommitmentFees.Text = "Commitment Fees";
            this.btnCommitmentFees.Click += new System.EventHandler(this.btnCommitmentFees_Click);
            // 
            // btnOverdraftFees
            // 
            this.btnOverdraftFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOverdraftFees.Location = new System.Drawing.Point(82, 159);
            this.btnOverdraftFees.Name = "btnOverdraftFees";
            this.btnOverdraftFees.Size = new System.Drawing.Size(182, 26);
            this.btnOverdraftFees.TabIndex = 5;
            this.btnOverdraftFees.Text = "Overdraft Interest";
            this.btnOverdraftFees.Click += new System.EventHandler(this.btnOverdraftFees_Click);
            // 
            // btnCurrentAccountInterest
            // 
            this.btnCurrentAccountInterest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCurrentAccountInterest.Location = new System.Drawing.Point(82, 127);
            this.btnCurrentAccountInterest.Name = "btnCurrentAccountInterest";
            this.btnCurrentAccountInterest.Size = new System.Drawing.Size(182, 26);
            this.btnCurrentAccountInterest.TabIndex = 3;
            this.btnCurrentAccountInterest.Text = "Current Account Interest";
            this.btnCurrentAccountInterest.Click += new System.EventHandler(this.btnCurrentAccountInterest_Click);
            // 
            // btnRunSelectedBatches
            // 
            this.btnRunSelectedBatches.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRunSelectedBatches.Location = new System.Drawing.Point(82, 95);
            this.btnRunSelectedBatches.Name = "btnRunSelectedBatches";
            this.btnRunSelectedBatches.Size = new System.Drawing.Size(182, 26);
            this.btnRunSelectedBatches.TabIndex = 1;
            this.btnRunSelectedBatches.Text = "Run Selected Batches";
            this.btnRunSelectedBatches.Click += new System.EventHandler(this.btnRunSelectedBatches_Click);
            // 
            // cbCurrentAccountInterest
            // 
            this.cbCurrentAccountInterest.AutoSize = true;
            this.cbCurrentAccountInterest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCurrentAccountInterest.Location = new System.Drawing.Point(37, 127);
            this.cbCurrentAccountInterest.Name = "cbCurrentAccountInterest";
            this.cbCurrentAccountInterest.Size = new System.Drawing.Size(15, 14);
            this.cbCurrentAccountInterest.TabIndex = 2;
            this.cbCurrentAccountInterest.UseVisualStyleBackColor = true;
            // 
            // cbOverdraftFees
            // 
            this.cbOverdraftFees.AutoSize = true;
            this.cbOverdraftFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbOverdraftFees.Location = new System.Drawing.Point(37, 159);
            this.cbOverdraftFees.Name = "cbOverdraftFees";
            this.cbOverdraftFees.Size = new System.Drawing.Size(15, 14);
            this.cbOverdraftFees.TabIndex = 4;
            this.cbOverdraftFees.UseVisualStyleBackColor = true;
            // 
            // cbCommitmentFees
            // 
            this.cbCommitmentFees.AutoSize = true;
            this.cbCommitmentFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCommitmentFees.Location = new System.Drawing.Point(37, 191);
            this.cbCommitmentFees.Name = "cbCommitmentFees";
            this.cbCommitmentFees.Size = new System.Drawing.Size(15, 14);
            this.cbCommitmentFees.TabIndex = 6;
            this.cbCommitmentFees.UseVisualStyleBackColor = true;
            // 
            // cbDormantAccount
            // 
            this.cbDormantAccount.AutoSize = true;
            this.cbDormantAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDormantAccount.Location = new System.Drawing.Point(37, 255);
            this.cbDormantAccount.Name = "cbDormantAccount";
            this.cbDormantAccount.Size = new System.Drawing.Size(15, 14);
            this.cbDormantAccount.TabIndex = 10;
            this.cbDormantAccount.UseVisualStyleBackColor = true;
            // 
            // cbCurrentAccMgmtFees
            // 
            this.cbCurrentAccMgmtFees.AutoSize = true;
            this.cbCurrentAccMgmtFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCurrentAccMgmtFees.Location = new System.Drawing.Point(37, 287);
            this.cbCurrentAccMgmtFees.Name = "cbCurrentAccMgmtFees";
            this.cbCurrentAccMgmtFees.Size = new System.Drawing.Size(15, 14);
            this.cbCurrentAccMgmtFees.TabIndex = 12;
            this.cbCurrentAccMgmtFees.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(34, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "List of Current Account contract code excluded from batch run";
            // 
            // tbExcludedCurrentContractCode
            // 
            this.tbExcludedCurrentContractCode.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbExcludedCurrentContractCode.Location = new System.Drawing.Point(34, 357);
            this.tbExcludedCurrentContractCode.Multiline = true;
            this.tbExcludedCurrentContractCode.Name = "tbExcludedCurrentContractCode";
            this.tbExcludedCurrentContractCode.Size = new System.Drawing.Size(366, 58);
            this.tbExcludedCurrentContractCode.TabIndex = 32;
            // 
            // cbFixedODFees
            // 
            this.cbFixedODFees.AutoSize = true;
            this.cbFixedODFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFixedODFees.Location = new System.Drawing.Point(37, 223);
            this.cbFixedODFees.Name = "cbFixedODFees";
            this.cbFixedODFees.Size = new System.Drawing.Size(15, 14);
            this.cbFixedODFees.TabIndex = 8;
            this.cbFixedODFees.UseVisualStyleBackColor = true;
            // 
            // btnFixedODFees
            // 
            this.btnFixedODFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFixedODFees.Location = new System.Drawing.Point(82, 223);
            this.btnFixedODFees.Name = "btnFixedODFees";
            this.btnFixedODFees.Size = new System.Drawing.Size(182, 26);
            this.btnFixedODFees.TabIndex = 9;
            this.btnFixedODFees.Text = "Fixed Overdraft Fees";
            this.btnFixedODFees.Click += new System.EventHandler(this.btnFixedODFees_Click);
            // 
            // dtpAllBatches
            // 
            this.dtpAllBatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAllBatches.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAllBatches.Location = new System.Drawing.Point(279, 69);
            this.dtpAllBatches.Name = "dtpAllBatches";
            this.dtpAllBatches.Size = new System.Drawing.Size(40, 20);
            this.dtpAllBatches.TabIndex = 38;
            // 
            // dtpSelectedBatchs
            // 
            this.dtpSelectedBatchs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSelectedBatchs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectedBatchs.Location = new System.Drawing.Point(279, 101);
            this.dtpSelectedBatchs.Name = "dtpSelectedBatchs";
            this.dtpSelectedBatchs.Size = new System.Drawing.Size(40, 20);
            this.dtpSelectedBatchs.TabIndex = 39;
            // 
            // dtpCAIBatch
            // 
            this.dtpCAIBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCAIBatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCAIBatch.Location = new System.Drawing.Point(279, 133);
            this.dtpCAIBatch.Name = "dtpCAIBatch";
            this.dtpCAIBatch.Size = new System.Drawing.Size(40, 20);
            this.dtpCAIBatch.TabIndex = 40;
            // 
            // dtpFODFBatch
            // 
            this.dtpFODFBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFODFBatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFODFBatch.Location = new System.Drawing.Point(279, 229);
            this.dtpFODFBatch.Name = "dtpFODFBatch";
            this.dtpFODFBatch.Size = new System.Drawing.Size(40, 20);
            this.dtpFODFBatch.TabIndex = 43;
            // 
            // dtpCFCBatch
            // 
            this.dtpCFCBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCFCBatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCFCBatch.Location = new System.Drawing.Point(279, 197);
            this.dtpCFCBatch.Name = "dtpCFCBatch";
            this.dtpCFCBatch.Size = new System.Drawing.Size(40, 20);
            this.dtpCFCBatch.TabIndex = 42;
            // 
            // dtpODICBatch
            // 
            this.dtpODICBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpODICBatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpODICBatch.Location = new System.Drawing.Point(279, 164);
            this.dtpODICBatch.Name = "dtpODICBatch";
            this.dtpODICBatch.Size = new System.Drawing.Size(40, 20);
            this.dtpODICBatch.TabIndex = 41;
            // 
            // dtpAMFCBatch
            // 
            this.dtpAMFCBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAMFCBatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAMFCBatch.Location = new System.Drawing.Point(279, 293);
            this.dtpAMFCBatch.Name = "dtpAMFCBatch";
            this.dtpAMFCBatch.Size = new System.Drawing.Size(40, 20);
            this.dtpAMFCBatch.TabIndex = 45;
            // 
            // dtpDABatch
            // 
            this.dtpDABatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDABatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDABatch.Location = new System.Drawing.Point(279, 261);
            this.dtpDABatch.Name = "dtpDABatch";
            this.dtpDABatch.Size = new System.Drawing.Size(40, 20);
            this.dtpDABatch.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(920, 36);
            this.label5.TabIndex = 55;
            this.label5.Text = "Run A Batch";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAllBatchDate
            // 
            this.cbAllBatchDate.AutoSize = true;
            this.cbAllBatchDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAllBatchDate.Location = new System.Drawing.Point(520, 74);
            this.cbAllBatchDate.Name = "cbAllBatchDate";
            this.cbAllBatchDate.Size = new System.Drawing.Size(145, 17);
            this.cbAllBatchDate.TabIndex = 56;
            this.cbAllBatchDate.Text = "All Batches On This Date";
            this.cbAllBatchDate.UseVisualStyleBackColor = true;
            // 
            // cbSelectedBatch
            // 
            this.cbSelectedBatch.AutoSize = true;
            this.cbSelectedBatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSelectedBatch.Location = new System.Drawing.Point(520, 106);
            this.cbSelectedBatch.Name = "cbSelectedBatch";
            this.cbSelectedBatch.Size = new System.Drawing.Size(176, 17);
            this.cbSelectedBatch.TabIndex = 57;
            this.cbSelectedBatch.Text = "Selected Batches On This Date";
            this.cbSelectedBatch.UseVisualStyleBackColor = true;
            // 
            // RunABatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 678);
            this.Controls.Add(this.cbSelectedBatch);
            this.Controls.Add(this.cbAllBatchDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpAMFCBatch);
            this.Controls.Add(this.dtpDABatch);
            this.Controls.Add(this.dtpFODFBatch);
            this.Controls.Add(this.dtpCFCBatch);
            this.Controls.Add(this.dtpODICBatch);
            this.Controls.Add(this.dtpCAIBatch);
            this.Controls.Add(this.dtpSelectedBatchs);
            this.Controls.Add(this.dtpAllBatches);
            this.Controls.Add(this.cbFixedODFees);
            this.Controls.Add(this.btnFixedODFees);
            this.Controls.Add(this.tbExcludedCurrentContractCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCurrentAccMgmtFees);
            this.Controls.Add(this.cbDormantAccount);
            this.Controls.Add(this.cbCommitmentFees);
            this.Controls.Add(this.cbOverdraftFees);
            this.Controls.Add(this.cbCurrentAccountInterest);
            this.Controls.Add(this.btnRunSelectedBatches);
            this.Controls.Add(this.btnCurrentAccountInterest);
            this.Controls.Add(this.btnOverdraftFees);
            this.Controls.Add(this.btnCommitmentFees);
            this.Controls.Add(this.btnDormantAccount);
            this.Controls.Add(this.btnAccountManagementFees);
            this.Controls.Add(this.btnRunAllBatches);
            this.Name = "RunABatchForm";
            this.Text = "Run A Batch";
            this.Load += new System.EventHandler(this.RunABatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunAllBatches;
        private System.Windows.Forms.Button btnAccountManagementFees;
        private System.Windows.Forms.Button btnDormantAccount;
        private System.Windows.Forms.Button btnCommitmentFees;
        private System.Windows.Forms.Button btnOverdraftFees;
        private System.Windows.Forms.Button btnCurrentAccountInterest;
        private System.Windows.Forms.Button btnRunSelectedBatches;
        private System.Windows.Forms.CheckBox cbCurrentAccountInterest;
        private System.Windows.Forms.CheckBox cbOverdraftFees;
        private System.Windows.Forms.CheckBox cbCommitmentFees;
        private System.Windows.Forms.CheckBox cbDormantAccount;
        private System.Windows.Forms.CheckBox cbCurrentAccMgmtFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbExcludedCurrentContractCode;
        private System.Windows.Forms.CheckBox cbFixedODFees;
        private System.Windows.Forms.Button btnFixedODFees;
        private System.Windows.Forms.DateTimePicker dtpAllBatches;
        private System.Windows.Forms.DateTimePicker dtpSelectedBatchs;
        private System.Windows.Forms.DateTimePicker dtpCAIBatch;
        private System.Windows.Forms.DateTimePicker dtpFODFBatch;
        private System.Windows.Forms.DateTimePicker dtpCFCBatch;
        private System.Windows.Forms.DateTimePicker dtpODICBatch;
        private System.Windows.Forms.DateTimePicker dtpAMFCBatch;
        private System.Windows.Forms.DateTimePicker dtpDABatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbAllBatchDate;
        private System.Windows.Forms.CheckBox cbSelectedBatch;
    }
}