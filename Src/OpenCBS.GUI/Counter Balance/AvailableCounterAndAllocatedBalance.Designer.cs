namespace OpenCBS.GUI.Counter_Balance
{
    partial class AvailableCounterAndAllocatedBalance
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
            this.btnManageCounter = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAllocatedBalance = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSavingsProducts = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvCounters = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCounter = new System.Windows.Forms.Button();
            this.pnlSavingsProducts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageCounter
            // 
            this.btnManageCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageCounter.Font = new System.Drawing.Font("Arial", 9F);
            this.btnManageCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManageCounter.Location = new System.Drawing.Point(863, 38);
            this.btnManageCounter.Name = "btnManageCounter";
            this.btnManageCounter.Size = new System.Drawing.Size(140, 28);
            this.btnManageCounter.TabIndex = 7;
            this.btnManageCounter.Text = "Manage Counters";
            this.btnManageCounter.Click += new System.EventHandler(this.buttonAddFixedAsset_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Allocation Date";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cashier";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 85;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Branch";
            this.columnHeader1.Width = 86;
            // 
            // lvAllocatedBalance
            // 
            this.lvAllocatedBalance.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvAllocatedBalance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvAllocatedBalance.FullRowSelect = true;
            this.lvAllocatedBalance.GridLines = true;
            this.lvAllocatedBalance.Location = new System.Drawing.Point(127, 0);
            this.lvAllocatedBalance.Name = "lvAllocatedBalance";
            this.lvAllocatedBalance.Size = new System.Drawing.Size(733, 232);
            this.lvAllocatedBalance.TabIndex = 27;
            this.lvAllocatedBalance.UseCompatibleStateImageBehavior = false;
            this.lvAllocatedBalance.View = System.Windows.Forms.View.Details;
            this.lvAllocatedBalance.SelectedIndexChanged += new System.EventHandler(this.lvFixedAsset_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Counter";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 102;
            // 
            // pnlSavingsProducts
            // 
            this.pnlSavingsProducts.Controls.Add(this.groupBox1);
            this.pnlSavingsProducts.Location = new System.Drawing.Point(-30, 40);
            this.pnlSavingsProducts.Name = "pnlSavingsProducts";
            this.pnlSavingsProducts.Size = new System.Drawing.Size(917, 486);
            this.pnlSavingsProducts.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddCounter);
            this.groupBox1.Controls.Add(this.lvCounters);
            this.groupBox1.Controls.Add(this.lvAllocatedBalance);
            this.groupBox1.Controls.Add(this.btnManageCounter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(-97, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 486);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Today\'s Allocated Counter Balance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(884, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "Available Counters";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvCounters
            // 
            this.lvCounters.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvCounters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvCounters.FullRowSelect = true;
            this.lvCounters.GridLines = true;
            this.lvCounters.Location = new System.Drawing.Point(127, 274);
            this.lvCounters.Name = "lvCounters";
            this.lvCounters.Size = new System.Drawing.Size(733, 232);
            this.lvCounters.TabIndex = 28;
            this.lvCounters.UseCompatibleStateImageBehavior = false;
            this.lvCounters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Branch";
            this.columnHeader7.Width = 163;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Counter ID";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 203;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Description";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 266;
            // 
            // btnAddCounter
            // 
            this.btnAddCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCounter.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAddCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddCounter.Location = new System.Drawing.Point(863, 304);
            this.btnAddCounter.Name = "btnAddCounter";
            this.btnAddCounter.Size = new System.Drawing.Size(140, 28);
            this.btnAddCounter.TabIndex = 29;
            this.btnAddCounter.Text = "Add Counter";
            this.btnAddCounter.Click += new System.EventHandler(this.btnAddCounter_Click);
            // 
            // AvailableCounterAndAllocatedBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 543);
            this.Controls.Add(this.pnlSavingsProducts);
            this.Controls.Add(this.label1);
            this.Name = "AvailableCounterAndAllocatedBalance";
            this.Text = "Available Counters And Allocated Balance";
            this.pnlSavingsProducts.ResumeLayout(false);
            this.pnlSavingsProducts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageCounter;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvAllocatedBalance;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel pnlSavingsProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCounter;
        private System.Windows.Forms.ListView lvCounters;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}