namespace OpenCBS.GUI.Accounting
{
    partial class AddedCurrencyAsset
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
            this.lvCurrencyAsset = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCurrencyAsset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCurrencyAsset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 36);
            this.label1.TabIndex = 34;
            this.label1.Text = "Added Curremcy Asset";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvCurrencyAsset
            // 
            this.lvCurrencyAsset.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvCurrencyAsset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvCurrencyAsset.FullRowSelect = true;
            this.lvCurrencyAsset.GridLines = true;
            this.lvCurrencyAsset.Location = new System.Drawing.Point(77, 48);
            this.lvCurrencyAsset.Name = "lvCurrencyAsset";
            this.lvCurrencyAsset.Size = new System.Drawing.Size(733, 232);
            this.lvCurrencyAsset.TabIndex = 27;
            this.lvCurrencyAsset.UseCompatibleStateImageBehavior = false;
            this.lvCurrencyAsset.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S.No.";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Asset Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asset Category";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Asset Description";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 166;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Asset Amount";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 172;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Reference";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 122;
            // 
            // btnAddCurrencyAsset
            // 
            this.btnAddCurrencyAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCurrencyAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAddCurrencyAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddCurrencyAsset.Location = new System.Drawing.Point(812, 48);
            this.btnAddCurrencyAsset.Name = "btnAddCurrencyAsset";
            this.btnAddCurrencyAsset.Size = new System.Drawing.Size(140, 28);
            this.btnAddCurrencyAsset.TabIndex = 7;
            this.btnAddCurrencyAsset.Text = "Add Currency Asset";
            this.btnAddCurrencyAsset.Click += new System.EventHandler(this.btnManageCounter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnDeleteCurrencyAsset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lvCurrencyAsset);
            this.groupBox1.Controls.Add(this.btnAddCurrencyAsset);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(-76, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 528);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // btnDeleteCurrencyAsset
            // 
            this.btnDeleteCurrencyAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCurrencyAsset.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDeleteCurrencyAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteCurrencyAsset.Location = new System.Drawing.Point(812, 82);
            this.btnDeleteCurrencyAsset.Name = "btnDeleteCurrencyAsset";
            this.btnDeleteCurrencyAsset.Size = new System.Drawing.Size(140, 28);
            this.btnDeleteCurrencyAsset.TabIndex = 35;
            this.btnDeleteCurrencyAsset.Text = "Delete Currency Asset";
            this.btnDeleteCurrencyAsset.Click += new System.EventHandler(this.btnDeleteCurrencyAsset_Click);
            // 
            // AddedCurrencyAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 528);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddedCurrencyAsset";
            this.Text = "Added Currency Asset";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCurrencyAsset;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAddCurrencyAsset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteCurrencyAsset;
    }
}