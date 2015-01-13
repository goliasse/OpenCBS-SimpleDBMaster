namespace OpenCBS.GUI.Accounting
{
    partial class CurrencyAssetsForm
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
            this.assetDate = new System.Windows.Forms.DateTimePicker();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.tbAssetAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.tbAssetDescription = new System.Windows.Forms.TextBox();
            this.cbAssetCategory = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.assetFundedFrom = new System.Windows.Forms.ComboBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // assetDate
            // 
            this.assetDate.Location = new System.Drawing.Point(160, 22);
            this.assetDate.Name = "assetDate";
            this.assetDate.Size = new System.Drawing.Size(149, 20);
            this.assetDate.TabIndex = 73;
            // 
            // tbReference
            // 
            this.tbReference.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbReference.Location = new System.Drawing.Point(160, 147);
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(149, 22);
            this.tbReference.TabIndex = 72;
            // 
            // tbAssetAmount
            // 
            this.tbAssetAmount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbAssetAmount.Location = new System.Drawing.Point(160, 119);
            this.tbAssetAmount.Name = "tbAssetAmount";
            this.tbAssetAmount.Size = new System.Drawing.Size(149, 22);
            this.tbAssetAmount.TabIndex = 71;
            this.tbAssetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAssetAmount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(58, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Reference:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Asset Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Asset Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Asset Category:";
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddAsset.Location = new System.Drawing.Point(160, 275);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(149, 28);
            this.btnAddAsset.TabIndex = 66;
            this.btnAddAsset.Text = "Add Asset";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // tbAssetDescription
            // 
            this.tbAssetDescription.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbAssetDescription.Location = new System.Drawing.Point(160, 87);
            this.tbAssetDescription.Name = "tbAssetDescription";
            this.tbAssetDescription.Size = new System.Drawing.Size(149, 22);
            this.tbAssetDescription.TabIndex = 65;
            // 
            // cbAssetCategory
            // 
            this.cbAssetCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssetCategory.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbAssetCategory.FormattingEnabled = true;
            this.cbAssetCategory.Items.AddRange(new object[] {
            "Cash on hand",
            "Furniture & Fittings",
            "Pre-Payment",
            "IT",
            "AdvanceTo Holding Company",
            "Treasury Bills",
            "Equity Paid Up Capital"});
            this.cbAssetCategory.Location = new System.Drawing.Point(160, 55);
            this.cbAssetCategory.Name = "cbAssetCategory";
            this.cbAssetCategory.Size = new System.Drawing.Size(149, 24);
            this.cbAssetCategory.TabIndex = 64;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.amountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.amountLabel.Location = new System.Drawing.Point(51, 22);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(77, 16);
            this.amountLabel.TabIndex = 63;
            this.amountLabel.Text = "Asset Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(39, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Funded From:";
            // 
            // assetFundedFrom
            // 
            this.assetFundedFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assetFundedFrom.Font = new System.Drawing.Font("Arial", 9.75F);
            this.assetFundedFrom.FormattingEnabled = true;
            this.assetFundedFrom.Items.AddRange(new object[] {
            "Income Ledger",
            "Capital Ledger",
            "Liabilities Ledger"});
            this.assetFundedFrom.Location = new System.Drawing.Point(160, 177);
            this.assetFundedFrom.Name = "assetFundedFrom";
            this.assetFundedFrom.Size = new System.Drawing.Size(149, 24);
            this.assetFundedFrom.TabIndex = 75;
            this.assetFundedFrom.SelectedIndexChanged += new System.EventHandler(this.assetFundedFrom_SelectedIndexChanged);
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(160, 212);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(149, 24);
            this.cbCurrency.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(64, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "Currency:";
            // 
            // cbBranch
            // 
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(160, 245);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(149, 24);
            this.cbBranch.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(75, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Branch:";
            // 
            // CurrencyAssetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 318);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.assetFundedFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.assetDate);
            this.Controls.Add(this.tbReference);
            this.Controls.Add(this.tbAssetAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAsset);
            this.Controls.Add(this.tbAssetDescription);
            this.Controls.Add(this.cbAssetCategory);
            this.Controls.Add(this.amountLabel);
            this.Name = "CurrencyAssetsForm";
            this.Text = "Currency Assets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker assetDate;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.TextBox tbAssetAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.TextBox tbAssetDescription;
        private System.Windows.Forms.ComboBox cbAssetCategory;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox assetFundedFrom;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.Label label7;

    }
}