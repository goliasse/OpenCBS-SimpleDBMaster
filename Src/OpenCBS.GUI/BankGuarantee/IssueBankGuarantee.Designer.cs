namespace OpenCBS.GUI.BankGuarantee
{
    partial class IssueBankGuarantee
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
            this.txtApplicantId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeneficiaryParty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGuaranteeType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFeePerPeriod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFeePeriod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInstrumentDetails = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtIssuingDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtValidity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtApplicantId
            // 
            this.txtApplicantId.Enabled = false;
            this.txtApplicantId.Location = new System.Drawing.Point(193, 27);
            this.txtApplicantId.Name = "txtApplicantId";
            this.txtApplicantId.Size = new System.Drawing.Size(183, 20);
            this.txtApplicantId.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Applicant ID:";
            // 
            // txtBeneficiaryParty
            // 
            this.txtBeneficiaryParty.Location = new System.Drawing.Point(193, 58);
            this.txtBeneficiaryParty.Name = "txtBeneficiaryParty";
            this.txtBeneficiaryParty.Size = new System.Drawing.Size(183, 20);
            this.txtBeneficiaryParty.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Beneficiary Party:";
            // 
            // cmbGuaranteeType
            // 
            this.cmbGuaranteeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuaranteeType.FormattingEnabled = true;
            this.cmbGuaranteeType.Location = new System.Drawing.Point(193, 88);
            this.cmbGuaranteeType.Name = "cmbGuaranteeType";
            this.cmbGuaranteeType.Size = new System.Drawing.Size(183, 21);
            this.cmbGuaranteeType.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(56, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Guarantee Type:";
            // 
            // txtFeePerPeriod
            // 
            this.txtFeePerPeriod.Location = new System.Drawing.Point(193, 168);
            this.txtFeePerPeriod.Name = "txtFeePerPeriod";
            this.txtFeePerPeriod.Size = new System.Drawing.Size(183, 20);
            this.txtFeePerPeriod.TabIndex = 65;
            this.txtFeePerPeriod.TextChanged += new System.EventHandler(this.txtFeePerPeriod_TextChanged);
            this.txtFeePerPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeePerPeriod_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(60, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Fee Per Period:";
            // 
            // cmbFeePeriod
            // 
            this.cmbFeePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeePeriod.FormattingEnabled = true;
            this.cmbFeePeriod.Location = new System.Drawing.Point(191, 141);
            this.cmbFeePeriod.Name = "cmbFeePeriod";
            this.cmbFeePeriod.Size = new System.Drawing.Size(183, 21);
            this.cmbFeePeriod.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(64, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Validity Period:";
            // 
            // txtInstrumentDetails
            // 
            this.txtInstrumentDetails.Location = new System.Drawing.Point(191, 198);
            this.txtInstrumentDetails.Name = "txtInstrumentDetails";
            this.txtInstrumentDetails.Size = new System.Drawing.Size(183, 20);
            this.txtInstrumentDetails.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(42, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Instrument Details:";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(191, 255);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(183, 21);
            this.cmbCurrency.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(93, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = "Currency:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(191, 224);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(183, 20);
            this.txtValue.TabIndex = 73;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeePerPeriod_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(113, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "Value:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(193, 444);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 23);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(52, 444);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 23);
            this.btnSubmit.TabIndex = 74;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtIssuingDate
            // 
            this.txtIssuingDate.Enabled = false;
            this.txtIssuingDate.Location = new System.Drawing.Point(191, 287);
            this.txtIssuingDate.Name = "txtIssuingDate";
            this.txtIssuingDate.Size = new System.Drawing.Size(183, 20);
            this.txtIssuingDate.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(73, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "Issuing Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(105, 399);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 78;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Visible = false;
            // 
            // txtValidity
            // 
            this.txtValidity.Location = new System.Drawing.Point(193, 115);
            this.txtValidity.Name = "txtValidity";
            this.txtValidity.Size = new System.Drawing.Size(183, 20);
            this.txtValidity.TabIndex = 81;
            this.txtValidity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeePerPeriod_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(105, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 80;
            this.label12.Text = "Validity:";
            // 
            // txtTotalFee
            // 
            this.txtTotalFee.Location = new System.Drawing.Point(191, 342);
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.Size = new System.Drawing.Size(183, 20);
            this.txtTotalFee.TabIndex = 83;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTotalFee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalFee.Location = new System.Drawing.Point(90, 346);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(65, 16);
            this.lblTotalFee.TabIndex = 82;
            this.lblTotalFee.Text = "Total Fee:";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(191, 368);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(183, 20);
            this.txtExpiryDate.TabIndex = 85;
            this.txtExpiryDate.Visible = false;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblExpiryDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExpiryDate.Location = new System.Drawing.Point(79, 372);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(80, 16);
            this.lblExpiryDate.TabIndex = 84;
            this.lblExpiryDate.Text = "Expiry Date:";
            this.lblExpiryDate.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(191, 394);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(183, 21);
            this.cmbStatus.TabIndex = 86;
            this.cmbStatus.Visible = false;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(191, 316);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(183, 20);
            this.txtAccountNumber.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(46, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Account Number:";
            // 
            // IssueBankGuarantee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 509);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.txtTotalFee);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.txtValidity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtIssuingDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInstrumentDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFeePeriod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFeePerPeriod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGuaranteeType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBeneficiaryParty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApplicantId);
            this.Controls.Add(this.label1);
            this.Name = "IssueBankGuarantee";
            this.Text = "Issue Bank Guarantee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApplicantId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBeneficiaryParty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGuaranteeType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFeePerPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFeePeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInstrumentDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtIssuingDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtValidity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label3;
    }
}