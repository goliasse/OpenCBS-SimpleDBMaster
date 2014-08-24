namespace OpenCBS.GUI.Fixed_Asset_Register
{
    partial class AddFixedAsset
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
            this.txtAssetDescription = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAssetType = new System.Windows.Forms.ComboBox();
            this.txtNoOfAssets = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOriginalCost = new System.Windows.Forms.TextBox();
            this.txtDepreciationRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAcqCapFinMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAcqCapTranNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDisAmtTranNum = new System.Windows.Forms.TextBox();
            this.cmbDisAmtTranMethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbAssetStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAssetDescription
            // 
            this.txtAssetDescription.Location = new System.Drawing.Point(268, 99);
            this.txtAssetDescription.Name = "txtAssetDescription";
            this.txtAssetDescription.Size = new System.Drawing.Size(183, 20);
            this.txtAssetDescription.TabIndex = 25;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAmount.Location = new System.Drawing.Point(128, 99);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(92, 13);
            this.lblAmount.TabIndex = 24;
            this.lblAmount.Text = "Asset Description:";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(268, 24);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(183, 21);
            this.cmbBranch.TabIndex = 23;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBranch.Location = new System.Drawing.Point(176, 24);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(44, 13);
            this.lblBranch.TabIndex = 22;
            this.lblBranch.Text = "Branch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(154, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Asset Type:";
            // 
            // cmbAssetType
            // 
            this.cmbAssetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetType.FormattingEnabled = true;
            this.cmbAssetType.Location = new System.Drawing.Point(268, 137);
            this.cmbAssetType.Name = "cmbAssetType";
            this.cmbAssetType.Size = new System.Drawing.Size(183, 21);
            this.cmbAssetType.TabIndex = 26;
            // 
            // txtNoOfAssets
            // 
            this.txtNoOfAssets.Location = new System.Drawing.Point(268, 177);
            this.txtNoOfAssets.Name = "txtNoOfAssets";
            this.txtNoOfAssets.Size = new System.Drawing.Size(183, 20);
            this.txtNoOfAssets.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(144, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "No Of Assets:";
            // 
            // txtOriginalCost
            // 
            this.txtOriginalCost.Location = new System.Drawing.Point(268, 213);
            this.txtOriginalCost.Name = "txtOriginalCost";
            this.txtOriginalCost.Size = new System.Drawing.Size(183, 20);
            this.txtOriginalCost.TabIndex = 31;
            // 
            // txtDepreciationRate
            // 
            this.txtDepreciationRate.Location = new System.Drawing.Point(268, 252);
            this.txtDepreciationRate.Name = "txtDepreciationRate";
            this.txtDepreciationRate.Size = new System.Drawing.Size(183, 20);
            this.txtDepreciationRate.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(85, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Annual Depreciation Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(41, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Acquisition Capital Finance Method:";
            // 
            // cmbAcqCapFinMethod
            // 
            this.cmbAcqCapFinMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcqCapFinMethod.FormattingEnabled = true;
            this.cmbAcqCapFinMethod.Location = new System.Drawing.Point(268, 286);
            this.cmbAcqCapFinMethod.Name = "cmbAcqCapFinMethod";
            this.cmbAcqCapFinMethod.Size = new System.Drawing.Size(183, 21);
            this.cmbAcqCapFinMethod.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(62, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Acquisition Capital Transaction:";
            // 
            // txtAcqCapTranNum
            // 
            this.txtAcqCapTranNum.Location = new System.Drawing.Point(268, 323);
            this.txtAcqCapTranNum.Name = "txtAcqCapTranNum";
            this.txtAcqCapTranNum.Size = new System.Drawing.Size(183, 20);
            this.txtAcqCapTranNum.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(68, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Disposal Amount Transaction:";
            // 
            // txtDisAmtTranNum
            // 
            this.txtDisAmtTranNum.Location = new System.Drawing.Point(268, 398);
            this.txtDisAmtTranNum.Name = "txtDisAmtTranNum";
            this.txtDisAmtTranNum.Size = new System.Drawing.Size(183, 20);
            this.txtDisAmtTranNum.TabIndex = 40;
            // 
            // cmbDisAmtTranMethod
            // 
            this.cmbDisAmtTranMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisAmtTranMethod.FormattingEnabled = true;
            this.cmbDisAmtTranMethod.Location = new System.Drawing.Point(268, 361);
            this.cmbDisAmtTranMethod.Name = "cmbDisAmtTranMethod";
            this.cmbDisAmtTranMethod.Size = new System.Drawing.Size(183, 21);
            this.cmbDisAmtTranMethod.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(41, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Disposal Amount Transfer Method:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(268, 435);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 23);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            // 
            // btnSubmit
            // 
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(110, 435);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 23);
            this.btnSubmit.TabIndex = 42;
            this.btnSubmit.Text = "Submit";
            // 
            // cmbAssetStatus
            // 
            this.cmbAssetStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetStatus.FormattingEnabled = true;
            this.cmbAssetStatus.Location = new System.Drawing.Point(268, 60);
            this.cmbAssetStatus.Name = "cmbAssetStatus";
            this.cmbAssetStatus.Size = new System.Drawing.Size(183, 21);
            this.cmbAssetStatus.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(176, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(90, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Original Cost (Per Asset) :";
            // 
            // AddFixedAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 535);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbAssetStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDisAmtTranNum);
            this.Controls.Add(this.cmbDisAmtTranMethod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAcqCapTranNum);
            this.Controls.Add(this.cmbAcqCapFinMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepreciationRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOriginalCost);
            this.Controls.Add(this.txtNoOfAssets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAssetType);
            this.Controls.Add(this.txtAssetDescription);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.lblBranch);
            this.Name = "AddFixedAsset";
            this.Text = "Add Fixed Asset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssetDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAssetType;
        private System.Windows.Forms.TextBox txtNoOfAssets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOriginalCost;
        private System.Windows.Forms.TextBox txtDepreciationRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAcqCapFinMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAcqCapTranNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDisAmtTranNum;
        private System.Windows.Forms.ComboBox cmbDisAmtTranMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbAssetStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}