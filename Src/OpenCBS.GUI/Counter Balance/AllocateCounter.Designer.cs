namespace OpenCBS.GUI.Counter
{
    partial class AllocateCounter
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.rbtnClosingAmt = new System.Windows.Forms.RadioButton();
            this.rbtnOpeningAmt = new System.Windows.Forms.RadioButton();
            this.cmbCashier = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.lblTeller = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.rbtnTopUp = new System.Windows.Forms.RadioButton();
            this.cmbCounter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(216, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            // 
            // btnConfirm
            // 
            this.btnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirm.Location = new System.Drawing.Point(40, 262);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 23);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(129, 200);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(183, 20);
            this.tbxAmount.TabIndex = 21;
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAmount_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAmount.Location = new System.Drawing.Point(37, 200);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "Amount:";
            // 
            // rbtnClosingAmt
            // 
            this.rbtnClosingAmt.AutoSize = true;
            this.rbtnClosingAmt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnClosingAmt.Location = new System.Drawing.Point(129, 80);
            this.rbtnClosingAmt.Name = "rbtnClosingAmt";
            this.rbtnClosingAmt.Size = new System.Drawing.Size(98, 17);
            this.rbtnClosingAmt.TabIndex = 17;
            this.rbtnClosingAmt.Text = "Closing Amount";
            // 
            // rbtnOpeningAmt
            // 
            this.rbtnOpeningAmt.AutoSize = true;
            this.rbtnOpeningAmt.Checked = true;
            this.rbtnOpeningAmt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnOpeningAmt.Location = new System.Drawing.Point(129, 57);
            this.rbtnOpeningAmt.Name = "rbtnOpeningAmt";
            this.rbtnOpeningAmt.Size = new System.Drawing.Size(104, 17);
            this.rbtnOpeningAmt.TabIndex = 16;
            this.rbtnOpeningAmt.TabStop = true;
            this.rbtnOpeningAmt.Text = "Opening Amount";
            // 
            // cmbCashier
            // 
            this.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashier.FormattingEnabled = true;
            this.cmbCashier.Location = new System.Drawing.Point(129, 126);
            this.cmbCashier.Name = "cmbCashier";
            this.cmbCashier.Size = new System.Drawing.Size(183, 21);
            this.cmbCashier.TabIndex = 19;
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(129, 25);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(183, 21);
            this.cmbBranch.TabIndex = 15;
            // 
            // lblTeller
            // 
            this.lblTeller.AutoSize = true;
            this.lblTeller.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTeller.Location = new System.Drawing.Point(37, 126);
            this.lblTeller.Name = "lblTeller";
            this.lblTeller.Size = new System.Drawing.Size(45, 13);
            this.lblTeller.TabIndex = 18;
            this.lblTeller.Text = "Cashier:";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBranch.Location = new System.Drawing.Point(37, 28);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(44, 13);
            this.lblBranch.TabIndex = 14;
            this.lblBranch.Text = "Branch:";
            // 
            // rbtnTopUp
            // 
            this.rbtnTopUp.AutoSize = true;
            this.rbtnTopUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnTopUp.Location = new System.Drawing.Point(129, 103);
            this.rbtnTopUp.Name = "rbtnTopUp";
            this.rbtnTopUp.Size = new System.Drawing.Size(61, 17);
            this.rbtnTopUp.TabIndex = 26;
            this.rbtnTopUp.Text = "Top Up";
            // 
            // cmbCounter
            // 
            this.cmbCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCounter.FormattingEnabled = true;
            this.cmbCounter.Location = new System.Drawing.Point(129, 164);
            this.cmbCounter.Name = "cmbCounter";
            this.cmbCounter.Size = new System.Drawing.Size(183, 21);
            this.cmbCounter.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(37, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Counter:";
            // 
            // AllocateCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 320);
            this.Controls.Add(this.cmbCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnTopUp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.rbtnClosingAmt);
            this.Controls.Add(this.rbtnOpeningAmt);
            this.Controls.Add(this.cmbCashier);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.lblTeller);
            this.Controls.Add(this.lblBranch);
            this.Name = "AllocateCounter";
            this.Text = "Allocate Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.RadioButton rbtnClosingAmt;
        private System.Windows.Forms.RadioButton rbtnOpeningAmt;
        private System.Windows.Forms.ComboBox cmbCashier;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label lblTeller;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.RadioButton rbtnTopUp;
        private System.Windows.Forms.ComboBox cmbCounter;
        private System.Windows.Forms.Label label1;
    }
}