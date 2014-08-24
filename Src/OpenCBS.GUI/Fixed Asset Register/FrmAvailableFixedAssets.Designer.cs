namespace OpenCBS.GUI.Products
{
    partial class FrmAvailableFixedAssets
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
            this.pnlSavingsProducts = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvFixedAsset = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewFixedAsset = new System.Windows.Forms.Button();
            this.buttonEditFixedAsset = new System.Windows.Forms.Button();
            this.checkBoxShowDeletedProduct = new System.Windows.Forms.CheckBox();
            this.buttonAddFixedAsset = new System.Windows.Forms.Button();
            this.buttonDeleteFixedAsset = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSavingsProducts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(921, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fixed Assets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSavingsProducts
            // 
            this.pnlSavingsProducts.Controls.Add(this.groupBox1);
            this.pnlSavingsProducts.Location = new System.Drawing.Point(8, 39);
            this.pnlSavingsProducts.Name = "pnlSavingsProducts";
            this.pnlSavingsProducts.Size = new System.Drawing.Size(917, 486);
            this.pnlSavingsProducts.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lvFixedAsset);
            this.groupBox1.Controls.Add(this.btnViewFixedAsset);
            this.groupBox1.Controls.Add(this.buttonEditFixedAsset);
            this.groupBox1.Controls.Add(this.checkBoxShowDeletedProduct);
            this.groupBox1.Controls.Add(this.buttonAddFixedAsset);
            this.groupBox1.Controls.Add(this.buttonDeleteFixedAsset);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 486);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // lvFixedAsset
            // 
            this.lvFixedAsset.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvFixedAsset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvFixedAsset.FullRowSelect = true;
            this.lvFixedAsset.GridLines = true;
            this.lvFixedAsset.Location = new System.Drawing.Point(0, 0);
            this.lvFixedAsset.Name = "lvFixedAsset";
            this.lvFixedAsset.Size = new System.Drawing.Size(765, 339);
            this.lvFixedAsset.TabIndex = 27;
            this.lvFixedAsset.UseCompatibleStateImageBehavior = false;
            this.lvFixedAsset.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Asset Id";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Branch";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asset Description";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Asset Type";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No Of Assets";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Acquisition Date";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 114;
            // 
            // btnViewFixedAsset
            // 
            this.btnViewFixedAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewFixedAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.btnViewFixedAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewFixedAsset.Location = new System.Drawing.Point(771, 135);
            this.btnViewFixedAsset.Name = "btnViewFixedAsset";
            this.btnViewFixedAsset.Size = new System.Drawing.Size(140, 28);
            this.btnViewFixedAsset.TabIndex = 10;
            this.btnViewFixedAsset.Text = "View Fixed Asset";
            this.btnViewFixedAsset.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // buttonEditFixedAsset
            // 
            this.buttonEditFixedAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditFixedAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonEditFixedAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEditFixedAsset.Location = new System.Drawing.Point(771, 70);
            this.buttonEditFixedAsset.Name = "buttonEditFixedAsset";
            this.buttonEditFixedAsset.Size = new System.Drawing.Size(140, 28);
            this.buttonEditFixedAsset.TabIndex = 9;
            this.buttonEditFixedAsset.Text = "Edit Fixed Asset";
            this.buttonEditFixedAsset.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // checkBoxShowDeletedProduct
            // 
            this.checkBoxShowDeletedProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowDeletedProduct.AutoSize = true;
            this.checkBoxShowDeletedProduct.Font = new System.Drawing.Font("Arial", 9.75F);
            this.checkBoxShowDeletedProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowDeletedProduct.Location = new System.Drawing.Point(782, 16);
            this.checkBoxShowDeletedProduct.Name = "checkBoxShowDeletedProduct";
            this.checkBoxShowDeletedProduct.Size = new System.Drawing.Size(114, 20);
            this.checkBoxShowDeletedProduct.TabIndex = 8;
            this.checkBoxShowDeletedProduct.Text = "Deleted assets";
            this.checkBoxShowDeletedProduct.CheckedChanged += new System.EventHandler(this.checkBoxShowDeletedProduct_CheckedChanged);
            // 
            // buttonAddFixedAsset
            // 
            this.buttonAddFixedAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFixedAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonAddFixedAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAddFixedAsset.Location = new System.Drawing.Point(771, 39);
            this.buttonAddFixedAsset.Name = "buttonAddFixedAsset";
            this.buttonAddFixedAsset.Size = new System.Drawing.Size(140, 28);
            this.buttonAddFixedAsset.TabIndex = 7;
            this.buttonAddFixedAsset.Text = "Add Fixed Asset";
            this.buttonAddFixedAsset.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteFixedAsset
            // 
            this.buttonDeleteFixedAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteFixedAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonDeleteFixedAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteFixedAsset.Location = new System.Drawing.Point(771, 101);
            this.buttonDeleteFixedAsset.Name = "buttonDeleteFixedAsset";
            this.buttonDeleteFixedAsset.Size = new System.Drawing.Size(140, 28);
            this.buttonDeleteFixedAsset.TabIndex = 6;
            this.buttonDeleteFixedAsset.Text = "Delete Fixed Asset";
            this.buttonDeleteFixedAsset.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Original Cost";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 87;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Annual Depreciation Rate";
            this.columnHeader8.Width = 145;
            // 
            // FrmAvailableFixedAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 572);
            this.Controls.Add(this.pnlSavingsProducts);
            this.Controls.Add(this.label1);
            this.Name = "FrmAvailableFixedAssets";
            this.Text = "Fixed Assets";
            this.pnlSavingsProducts.ResumeLayout(false);
            this.pnlSavingsProducts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSavingsProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEditFixedAsset;
        private System.Windows.Forms.CheckBox checkBoxShowDeletedProduct;
        private System.Windows.Forms.Button buttonAddFixedAsset;
        private System.Windows.Forms.Button buttonDeleteFixedAsset;
        private System.Windows.Forms.Button btnViewFixedAsset;
        private System.Windows.Forms.ListView lvFixedAsset;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;


    }
}