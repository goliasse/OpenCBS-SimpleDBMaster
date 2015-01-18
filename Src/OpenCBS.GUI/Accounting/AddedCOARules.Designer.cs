namespace OpenCBS.GUI.Accounting
{
    partial class AddedCOARules
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
            this.btnView = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCOARules = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnView.Location = new System.Drawing.Point(17, 19);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(236, 25);
            this.btnView.TabIndex = 72;
            this.btnView.Text = "Add Rule";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteRule);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Location = new System.Drawing.Point(622, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 158);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRule.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnDeleteRule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteRule.Location = new System.Drawing.Point(17, 67);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(236, 25);
            this.btnDeleteRule.TabIndex = 73;
            this.btnDeleteRule.Text = "Delete Rule";
            this.btnDeleteRule.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 36);
            this.label1.TabIndex = 72;
            this.label1.Text = "Chart Of Account Rules";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Currency";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Branch";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Credit Account";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Debit Account";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 85;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S. No.";
            this.columnHeader1.Width = 86;
            // 
            // lvCOARules
            // 
            this.lvCOARules.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvCOARules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCOARules.FullRowSelect = true;
            this.lvCOARules.GridLines = true;
            this.lvCOARules.Location = new System.Drawing.Point(3, 37);
            this.lvCOARules.Name = "lvCOARules";
            this.lvCOARules.Size = new System.Drawing.Size(613, 458);
            this.lvCOARules.TabIndex = 71;
            this.lvCOARules.UseCompatibleStateImageBehavior = false;
            this.lvCOARules.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Event Code";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddedCOARules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvCOARules);
            this.Name = "AddedCOARules";
            this.Text = "Added COA Rules";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvCOARules;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDeleteRule;
    }
}