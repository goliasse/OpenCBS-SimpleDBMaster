namespace OpenCBS.GUI.BankGuarantee
{
    partial class IssuedBankGuarantee
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvBankGuarantee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddFixedAsset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewFixedAsset = new System.Windows.Forms.Button();
            this.buttonEditFixedAsset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(921, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Bank Guarantees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvBankGuarantee
            // 
            this.lvBankGuarantee.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvBankGuarantee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvBankGuarantee.FullRowSelect = true;
            this.lvBankGuarantee.GridLines = true;
            this.lvBankGuarantee.Location = new System.Drawing.Point(1, 39);
            this.lvBankGuarantee.Name = "lvBankGuarantee";
            this.lvBankGuarantee.Size = new System.Drawing.Size(765, 339);
            this.lvBankGuarantee.TabIndex = 27;
            this.lvBankGuarantee.UseCompatibleStateImageBehavior = false;
            this.lvBankGuarantee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bank Guarntee Code";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Issuing Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Expiry Date";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Applicant ID";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Beneficiary Party";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Currency";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 87;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Status";
            this.columnHeader8.Width = 145;
            // 
            // buttonAddFixedAsset
            // 
            this.buttonAddFixedAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFixedAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonAddFixedAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAddFixedAsset.Location = new System.Drawing.Point(771, 58);
            this.buttonAddFixedAsset.Name = "buttonAddFixedAsset";
            this.buttonAddFixedAsset.Size = new System.Drawing.Size(140, 28);
            this.buttonAddFixedAsset.TabIndex = 7;
            this.buttonAddFixedAsset.Text = "Add Fixed Asset";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lvBankGuarantee);
            this.groupBox1.Controls.Add(this.btnViewFixedAsset);
            this.groupBox1.Controls.Add(this.buttonEditFixedAsset);
            this.groupBox1.Controls.Add(this.buttonAddFixedAsset);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 487);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btnViewFixedAsset
            // 
            this.btnViewFixedAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewFixedAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.btnViewFixedAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewFixedAsset.Location = new System.Drawing.Point(771, 123);
            this.btnViewFixedAsset.Name = "btnViewFixedAsset";
            this.btnViewFixedAsset.Size = new System.Drawing.Size(140, 28);
            this.btnViewFixedAsset.TabIndex = 10;
            this.btnViewFixedAsset.Text = "View Fixed Asset";
            // 
            // buttonEditFixedAsset
            // 
            this.buttonEditFixedAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditFixedAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonEditFixedAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEditFixedAsset.Location = new System.Drawing.Point(771, 89);
            this.buttonEditFixedAsset.Name = "buttonEditFixedAsset";
            this.buttonEditFixedAsset.Size = new System.Drawing.Size(140, 28);
            this.buttonEditFixedAsset.TabIndex = 9;
            this.buttonEditFixedAsset.Text = "Dispose Fixed Asset";
            // 
            // IssuedBankGuarantee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "IssuedBankGuarantee";
            this.Text = "IssuedBankGuarantee";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvBankGuarantee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonAddFixedAsset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewFixedAsset;
        private System.Windows.Forms.Button buttonEditFixedAsset;
    }
}