namespace OpenCBS.GUI.Products
{
    partial class FrmAvailableFixedDepositProducts
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
            this.lvFixedDepositProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.checkBoxShowDeletedProduct = new System.Windows.Forms.CheckBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.label1.Text = "Fixed Deposit Products";
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
            this.groupBox1.Controls.Add(this.lvFixedDepositProducts);
            this.groupBox1.Controls.Add(this.btnViewProduct);
            this.groupBox1.Controls.Add(this.buttonEditProduct);
            this.groupBox1.Controls.Add(this.checkBoxShowDeletedProduct);
            this.groupBox1.Controls.Add(this.buttonAddProduct);
            this.groupBox1.Controls.Add(this.buttonDeleteProduct);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 486);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // lvFixedDepositProducts
            // 
            this.lvFixedDepositProducts.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvFixedDepositProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvFixedDepositProducts.FullRowSelect = true;
            this.lvFixedDepositProducts.GridLines = true;
            this.lvFixedDepositProducts.Location = new System.Drawing.Point(0, 0);
            this.lvFixedDepositProducts.Name = "lvFixedDepositProducts";
            this.lvFixedDepositProducts.Size = new System.Drawing.Size(765, 339);
            this.lvFixedDepositProducts.TabIndex = 27;
            this.lvFixedDepositProducts.UseCompatibleStateImageBehavior = false;
            this.lvFixedDepositProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ID";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product Code";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Client Type";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Currency";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 86;
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProduct.Font = new System.Drawing.Font("Arial", 9F);
            this.btnViewProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewProduct.Location = new System.Drawing.Point(771, 135);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(140, 28);
            this.btnViewProduct.TabIndex = 10;
            this.btnViewProduct.Text = "View product";
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditProduct.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonEditProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEditProduct.Location = new System.Drawing.Point(771, 70);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(140, 28);
            this.buttonEditProduct.TabIndex = 9;
            this.buttonEditProduct.Text = "Edit product";
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // checkBoxShowDeletedProduct
            // 
            this.checkBoxShowDeletedProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowDeletedProduct.AutoSize = true;
            this.checkBoxShowDeletedProduct.Font = new System.Drawing.Font("Arial", 9.75F);
            this.checkBoxShowDeletedProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowDeletedProduct.Location = new System.Drawing.Point(771, 16);
            this.checkBoxShowDeletedProduct.Name = "checkBoxShowDeletedProduct";
            this.checkBoxShowDeletedProduct.Size = new System.Drawing.Size(125, 20);
            this.checkBoxShowDeletedProduct.TabIndex = 8;
            this.checkBoxShowDeletedProduct.Text = "Deleted products";
            this.checkBoxShowDeletedProduct.CheckedChanged += new System.EventHandler(this.checkBoxShowDeletedProduct_CheckedChanged);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProduct.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonAddProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAddProduct.Location = new System.Drawing.Point(771, 39);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(140, 28);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Text = "Add product";
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonDeleteProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(771, 101);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(140, 28);
            this.buttonDeleteProduct.TabIndex = 6;
            this.buttonDeleteProduct.Text = "Delete product";
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(774, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 28);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            // 
            // FrmAvailableFixedDepositProducts
            // 
            this.AcceptButton = this.buttonAddProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(926, 572);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlSavingsProducts);
            this.Controls.Add(this.label1);
            this.Name = "FrmAvailableFixedDepositProducts";
            this.Text = "Fixed Deposit Products";
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
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.CheckBox checkBoxShowDeletedProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.ListView lvFixedDepositProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnClose;


    }
}