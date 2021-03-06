﻿namespace OpenCBS.GUI.FixedAssetRegister
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
            this.lblDisAmtTran = new System.Windows.Forms.Label();
            this.txtDisAmtTranNum = new System.Windows.Forms.TextBox();
            this.cmbDisAmtTranMethod = new System.Windows.Forms.ComboBox();
            this.lblDisAmtTransMethod = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAcquisitionDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisDate = new System.Windows.Forms.TextBox();
            this.lblDisDate = new System.Windows.Forms.Label();
            this.txtNetBookValue = new System.Windows.Forms.TextBox();
            this.lblNetBookValue = new System.Windows.Forms.Label();
            this.txtAccDepCharge = new System.Windows.Forms.TextBox();
            this.lblAccDepCharge = new System.Windows.Forms.Label();
            this.lblProfitLoss = new System.Windows.Forms.Label();
            this.txtProfitLoss = new System.Windows.Forms.TextBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAssetDescription
            // 
            this.txtAssetDescription.Location = new System.Drawing.Point(268, 60);
            this.txtAssetDescription.Name = "txtAssetDescription";
            this.txtAssetDescription.Size = new System.Drawing.Size(183, 20);
            this.txtAssetDescription.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAmount.Location = new System.Drawing.Point(102, 64);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(115, 16);
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
            this.cmbBranch.TabIndex = 0;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBranch.Location = new System.Drawing.Point(164, 24);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(53, 16);
            this.lblBranch.TabIndex = 22;
            this.lblBranch.Text = "Branch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(140, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Asset Type:";
            // 
            // cmbAssetType
            // 
            this.cmbAssetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetType.FormattingEnabled = true;
            this.cmbAssetType.Location = new System.Drawing.Point(268, 98);
            this.cmbAssetType.Name = "cmbAssetType";
            this.cmbAssetType.Size = new System.Drawing.Size(183, 21);
            this.cmbAssetType.TabIndex = 2;
            // 
            // txtNoOfAssets
            // 
            this.txtNoOfAssets.Location = new System.Drawing.Point(268, 138);
            this.txtNoOfAssets.Name = "txtNoOfAssets";
            this.txtNoOfAssets.Size = new System.Drawing.Size(183, 20);
            this.txtNoOfAssets.TabIndex = 3;
            this.txtNoOfAssets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfAssets_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(128, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "No Of Assets:";
            // 
            // txtOriginalCost
            // 
            this.txtOriginalCost.Location = new System.Drawing.Point(268, 174);
            this.txtOriginalCost.Name = "txtOriginalCost";
            this.txtOriginalCost.Size = new System.Drawing.Size(183, 20);
            this.txtOriginalCost.TabIndex = 4;
            this.txtOriginalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfAssets_KeyPress);
            // 
            // txtDepreciationRate
            // 
            this.txtDepreciationRate.Location = new System.Drawing.Point(268, 213);
            this.txtDepreciationRate.Name = "txtDepreciationRate";
            this.txtDepreciationRate.Size = new System.Drawing.Size(183, 20);
            this.txtDepreciationRate.TabIndex = 5;
            this.txtDepreciationRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfAssets_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(57, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Annual Depreciation Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(-1, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Acquisition Capital Finance Method:";
            // 
            // cmbAcqCapFinMethod
            // 
            this.cmbAcqCapFinMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcqCapFinMethod.FormattingEnabled = true;
            this.cmbAcqCapFinMethod.Location = new System.Drawing.Point(268, 273);
            this.cmbAcqCapFinMethod.Name = "cmbAcqCapFinMethod";
            this.cmbAcqCapFinMethod.Size = new System.Drawing.Size(183, 21);
            this.cmbAcqCapFinMethod.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(21, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Acquisition Capital Transaction:";
            // 
            // txtAcqCapTranNum
            // 
            this.txtAcqCapTranNum.Location = new System.Drawing.Point(268, 310);
            this.txtAcqCapTranNum.Name = "txtAcqCapTranNum";
            this.txtAcqCapTranNum.Size = new System.Drawing.Size(183, 20);
            this.txtAcqCapTranNum.TabIndex = 8;
            // 
            // lblDisAmtTran
            // 
            this.lblDisAmtTran.AutoSize = true;
            this.lblDisAmtTran.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDisAmtTran.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDisAmtTran.Location = new System.Drawing.Point(31, 375);
            this.lblDisAmtTran.Name = "lblDisAmtTran";
            this.lblDisAmtTran.Size = new System.Drawing.Size(181, 16);
            this.lblDisAmtTran.TabIndex = 41;
            this.lblDisAmtTran.Text = "Disposal Amount Transaction:";
            this.lblDisAmtTran.Visible = false;
            // 
            // txtDisAmtTranNum
            // 
            this.txtDisAmtTranNum.Location = new System.Drawing.Point(268, 375);
            this.txtDisAmtTranNum.Name = "txtDisAmtTranNum";
            this.txtDisAmtTranNum.Size = new System.Drawing.Size(183, 20);
            this.txtDisAmtTranNum.TabIndex = 10;
            this.txtDisAmtTranNum.Visible = false;
            // 
            // cmbDisAmtTranMethod
            // 
            this.cmbDisAmtTranMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisAmtTranMethod.FormattingEnabled = true;
            this.cmbDisAmtTranMethod.Location = new System.Drawing.Point(268, 338);
            this.cmbDisAmtTranMethod.Name = "cmbDisAmtTranMethod";
            this.cmbDisAmtTranMethod.Size = new System.Drawing.Size(183, 21);
            this.cmbDisAmtTranMethod.TabIndex = 9;
            this.cmbDisAmtTranMethod.Visible = false;
            // 
            // lblDisAmtTransMethod
            // 
            this.lblDisAmtTransMethod.AutoSize = true;
            this.lblDisAmtTransMethod.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDisAmtTransMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDisAmtTransMethod.Location = new System.Drawing.Point(9, 339);
            this.lblDisAmtTransMethod.Name = "lblDisAmtTransMethod";
            this.lblDisAmtTransMethod.Size = new System.Drawing.Size(207, 16);
            this.lblDisAmtTransMethod.TabIndex = 38;
            this.lblDisAmtTransMethod.Text = "Disposal Amount Transfer Method:";
            this.lblDisAmtTransMethod.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(268, 566);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Dispose";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(105, 566);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(57, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Original Cost (Per Asset) :";
            // 
            // txtAcquisitionDate
            // 
            this.txtAcquisitionDate.Location = new System.Drawing.Point(268, 245);
            this.txtAcquisitionDate.Name = "txtAcquisitionDate";
            this.txtAcquisitionDate.Size = new System.Drawing.Size(183, 20);
            this.txtAcquisitionDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(110, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Acquisition Date:";
            // 
            // txtDisDate
            // 
            this.txtDisDate.Location = new System.Drawing.Point(268, 405);
            this.txtDisDate.Name = "txtDisDate";
            this.txtDisDate.Size = new System.Drawing.Size(183, 20);
            this.txtDisDate.TabIndex = 11;
            this.txtDisDate.Visible = false;
            this.txtDisDate.TextChanged += new System.EventHandler(this.txtDisDate_TextChanged);
            // 
            // lblDisDate
            // 
            this.lblDisDate.AutoSize = true;
            this.lblDisDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDisDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDisDate.Location = new System.Drawing.Point(119, 407);
            this.lblDisDate.Name = "lblDisDate";
            this.lblDisDate.Size = new System.Drawing.Size(93, 16);
            this.lblDisDate.TabIndex = 58;
            this.lblDisDate.Text = "Disposal Date:";
            this.lblDisDate.Visible = false;
            // 
            // txtNetBookValue
            // 
            this.txtNetBookValue.Location = new System.Drawing.Point(268, 435);
            this.txtNetBookValue.Name = "txtNetBookValue";
            this.txtNetBookValue.Size = new System.Drawing.Size(183, 20);
            this.txtNetBookValue.TabIndex = 12;
            this.txtNetBookValue.Visible = false;
            // 
            // lblNetBookValue
            // 
            this.lblNetBookValue.AutoSize = true;
            this.lblNetBookValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblNetBookValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNetBookValue.Location = new System.Drawing.Point(110, 439);
            this.lblNetBookValue.Name = "lblNetBookValue";
            this.lblNetBookValue.Size = new System.Drawing.Size(102, 16);
            this.lblNetBookValue.TabIndex = 60;
            this.lblNetBookValue.Text = "Net Book Value:";
            this.lblNetBookValue.Visible = false;
            // 
            // txtAccDepCharge
            // 
            this.txtAccDepCharge.Location = new System.Drawing.Point(268, 466);
            this.txtAccDepCharge.Name = "txtAccDepCharge";
            this.txtAccDepCharge.Size = new System.Drawing.Size(183, 20);
            this.txtAccDepCharge.TabIndex = 13;
            this.txtAccDepCharge.Visible = false;
            // 
            // lblAccDepCharge
            // 
            this.lblAccDepCharge.AutoSize = true;
            this.lblAccDepCharge.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblAccDepCharge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAccDepCharge.Location = new System.Drawing.Point(3, 466);
            this.lblAccDepCharge.Name = "lblAccDepCharge";
            this.lblAccDepCharge.Size = new System.Drawing.Size(209, 16);
            this.lblAccDepCharge.TabIndex = 62;
            this.lblAccDepCharge.Text = "Accumulated Depreciation Charge:";
            this.lblAccDepCharge.Visible = false;
            // 
            // lblProfitLoss
            // 
            this.lblProfitLoss.AutoSize = true;
            this.lblProfitLoss.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblProfitLoss.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProfitLoss.Location = new System.Drawing.Point(63, 498);
            this.lblProfitLoss.Name = "lblProfitLoss";
            this.lblProfitLoss.Size = new System.Drawing.Size(149, 16);
            this.lblProfitLoss.TabIndex = 64;
            this.lblProfitLoss.Text = "Profit\\Loss On Disposal:";
            this.lblProfitLoss.Visible = false;
            // 
            // txtProfitLoss
            // 
            this.txtProfitLoss.Location = new System.Drawing.Point(268, 498);
            this.txtProfitLoss.Name = "txtProfitLoss";
            this.txtProfitLoss.Size = new System.Drawing.Size(183, 20);
            this.txtProfitLoss.TabIndex = 14;
            this.txtProfitLoss.Visible = false;
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(268, 528);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(183, 21);
            this.cbCurrency.TabIndex = 15;
            this.cbCurrency.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(148, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Currency:";
            this.label7.Visible = false;
            // 
            // AddFixedAsset
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 617);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProfitLoss);
            this.Controls.Add(this.lblProfitLoss);
            this.Controls.Add(this.txtAccDepCharge);
            this.Controls.Add(this.lblAccDepCharge);
            this.Controls.Add(this.txtNetBookValue);
            this.Controls.Add(this.lblNetBookValue);
            this.Controls.Add(this.txtDisDate);
            this.Controls.Add(this.lblDisDate);
            this.Controls.Add(this.txtAcquisitionDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDisAmtTran);
            this.Controls.Add(this.txtDisAmtTranNum);
            this.Controls.Add(this.cmbDisAmtTranMethod);
            this.Controls.Add(this.lblDisAmtTransMethod);
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
        private System.Windows.Forms.Label lblDisAmtTran;
        private System.Windows.Forms.TextBox txtDisAmtTranNum;
        private System.Windows.Forms.ComboBox cmbDisAmtTranMethod;
        private System.Windows.Forms.Label lblDisAmtTransMethod;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAcquisitionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisDate;
        private System.Windows.Forms.Label lblDisDate;
        private System.Windows.Forms.TextBox txtNetBookValue;
        private System.Windows.Forms.Label lblNetBookValue;
        private System.Windows.Forms.TextBox txtAccDepCharge;
        private System.Windows.Forms.Label lblAccDepCharge;
        private System.Windows.Forms.Label lblProfitLoss;
        private System.Windows.Forms.TextBox txtProfitLoss;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label label7;
    }
}