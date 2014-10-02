namespace OpenCBS.GUI.Configuration
{
    partial class SetLIBORRate
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
            this.txtLIBORRate = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSetLIBOR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInterestPeriod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLIBORRate
            // 
            this.txtLIBORRate.Location = new System.Drawing.Point(148, 41);
            this.txtLIBORRate.Name = "txtLIBORRate";
            this.txtLIBORRate.Size = new System.Drawing.Size(130, 20);
            this.txtLIBORRate.TabIndex = 39;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(37, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 16);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "LIBOR Rate:";
            // 
            // btnSetLIBOR
            // 
            this.btnSetLIBOR.Location = new System.Drawing.Point(105, 114);
            this.btnSetLIBOR.Name = "btnSetLIBOR";
            this.btnSetLIBOR.Size = new System.Drawing.Size(75, 23);
            this.btnSetLIBOR.TabIndex = 42;
            this.btnSetLIBOR.Text = "Set LIBOR";
            this.btnSetLIBOR.UseVisualStyleBackColor = true;
            this.btnSetLIBOR.Click += new System.EventHandler(this.btnSetLIBOR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Interest Period:";
            // 
            // cmbInterestPeriod
            // 
            this.cmbInterestPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterestPeriod.FormattingEnabled = true;
            this.cmbInterestPeriod.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Quarterly",
            "Half-Yearly",
            "Yearly"});
            this.cmbInterestPeriod.Location = new System.Drawing.Point(148, 74);
            this.cmbInterestPeriod.Name = "cmbInterestPeriod";
            this.cmbInterestPeriod.Size = new System.Drawing.Size(130, 21);
            this.cmbInterestPeriod.TabIndex = 68;
            // 
            // SetLIBORRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 262);
            this.Controls.Add(this.cmbInterestPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetLIBOR);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtLIBORRate);
            this.Name = "SetLIBORRate";
            this.Text = "SetLIBORRate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLIBORRate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSetLIBOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInterestPeriod;
    }
}