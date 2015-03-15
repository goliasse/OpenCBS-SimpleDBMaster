namespace OpenCBS.GUI.Batch
{
    partial class FrmScheduleABatch
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExcludedCurrentContractCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnScheduleBatch = new System.Windows.Forms.Button();
            this.dtpBatchDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBatches = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Select A batch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Select A Date";
            // 
            // tbExcludedCurrentContractCode
            // 
            this.tbExcludedCurrentContractCode.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbExcludedCurrentContractCode.Location = new System.Drawing.Point(12, 105);
            this.tbExcludedCurrentContractCode.Multiline = true;
            this.tbExcludedCurrentContractCode.Name = "tbExcludedCurrentContractCode";
            this.tbExcludedCurrentContractCode.Size = new System.Drawing.Size(366, 58);
            this.tbExcludedCurrentContractCode.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "List of Current Account contract code excluded from batch run";
            // 
            // btnScheduleBatch
            // 
            this.btnScheduleBatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnScheduleBatch.Location = new System.Drawing.Point(123, 194);
            this.btnScheduleBatch.Name = "btnScheduleBatch";
            this.btnScheduleBatch.Size = new System.Drawing.Size(125, 26);
            this.btnScheduleBatch.TabIndex = 41;
            this.btnScheduleBatch.Text = "Schedule Batch";
            this.btnScheduleBatch.Click += new System.EventHandler(this.btnScheduleBatch_Click);
            // 
            // dtpBatchDate
            // 
            this.dtpBatchDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatchDate.Location = new System.Drawing.Point(123, 53);
            this.dtpBatchDate.Name = "dtpBatchDate";
            this.dtpBatchDate.Size = new System.Drawing.Size(183, 20);
            this.dtpBatchDate.TabIndex = 46;
            // 
            // cmbBatches
            // 
            this.cmbBatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatches.FormattingEnabled = true;
            this.cmbBatches.Items.AddRange(new object[] {
            "CurrentAccountInterestBatch",
            "OverdraftInterestCalculationBatch",
            "OverdraftCommitmentFeeBatch",
            "AccountManagementFeeBatch",
            "FixedOverdraftFeeBatch",
            "AccountDormantBatch"});
            this.cmbBatches.Location = new System.Drawing.Point(123, 22);
            this.cmbBatches.Name = "cmbBatches";
            this.cmbBatches.Size = new System.Drawing.Size(183, 21);
            this.cmbBatches.TabIndex = 47;
            // 
            // FrmScheduleABatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 242);
            this.Controls.Add(this.cmbBatches);
            this.Controls.Add(this.dtpBatchDate);
            this.Controls.Add(this.btnScheduleBatch);
            this.Controls.Add(this.tbExcludedCurrentContractCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ScheduleABatch";
            this.Text = "Schedule A Batch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExcludedCurrentContractCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnScheduleBatch;
        private System.Windows.Forms.DateTimePicker dtpBatchDate;
        private System.Windows.Forms.ComboBox cmbBatches;
    }
}