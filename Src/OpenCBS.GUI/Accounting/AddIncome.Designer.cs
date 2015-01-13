namespace OpenCBS.GUI.Accounting
{
    partial class AddIncome
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
            this.incomeDate = new System.Windows.Forms.DateTimePicker();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.tbIncomeAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.tbIncomeDescription = new System.Windows.Forms.TextBox();
            this.cbIncomeCategory = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incomeDate
            // 
            this.incomeDate.Location = new System.Drawing.Point(159, 25);
            this.incomeDate.Name = "incomeDate";
            this.incomeDate.Size = new System.Drawing.Size(149, 20);
            this.incomeDate.TabIndex = 73;
            // 
            // tbReference
            // 
            this.tbReference.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbReference.Location = new System.Drawing.Point(159, 150);
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(149, 22);
            this.tbReference.TabIndex = 72;
            // 
            // tbIncomeAmount
            // 
            this.tbIncomeAmount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbIncomeAmount.Location = new System.Drawing.Point(159, 122);
            this.tbIncomeAmount.Name = "tbIncomeAmount";
            this.tbIncomeAmount.Size = new System.Drawing.Size(149, 22);
            this.tbIncomeAmount.TabIndex = 71;
            this.tbIncomeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIncomeAmount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(65, 153);
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
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Income Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Income Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Income Category:";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddExpense.Location = new System.Drawing.Point(159, 251);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(149, 28);
            this.btnAddExpense.TabIndex = 66;
            this.btnAddExpense.Text = "Add Income";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // tbIncomeDescription
            // 
            this.tbIncomeDescription.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbIncomeDescription.Location = new System.Drawing.Point(159, 90);
            this.tbIncomeDescription.Name = "tbIncomeDescription";
            this.tbIncomeDescription.Size = new System.Drawing.Size(149, 22);
            this.tbIncomeDescription.TabIndex = 65;
            // 
            // cbIncomeCategory
            // 
            this.cbIncomeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIncomeCategory.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbIncomeCategory.FormattingEnabled = true;
            this.cbIncomeCategory.Items.AddRange(new object[] {
            "Rent Income",
            "Other Income"});
            this.cbIncomeCategory.Location = new System.Drawing.Point(159, 58);
            this.cbIncomeCategory.Name = "cbIncomeCategory";
            this.cbIncomeCategory.Size = new System.Drawing.Size(149, 24);
            this.cbIncomeCategory.TabIndex = 64;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.amountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.amountLabel.Location = new System.Drawing.Point(50, 25);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(85, 16);
            this.amountLabel.TabIndex = 63;
            this.amountLabel.Text = "Income Date:";
            // 
            // cbBranch
            // 
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Items.AddRange(new object[] {
            "Income Ledger",
            "Capital Ledger",
            "Liabilities Ledger"});
            this.cbBranch.Location = new System.Drawing.Point(159, 214);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(149, 24);
            this.cbBranch.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(82, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 86;
            this.label7.Text = "Branch:";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "Income Ledger",
            "Capital Ledger",
            "Liabilities Ledger"});
            this.cbCurrency.Location = new System.Drawing.Point(159, 181);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(149, 24);
            this.cbCurrency.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(71, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 84;
            this.label6.Text = "Currency:";
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 291);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.incomeDate);
            this.Controls.Add(this.tbReference);
            this.Controls.Add(this.tbIncomeAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.tbIncomeDescription);
            this.Controls.Add(this.cbIncomeCategory);
            this.Controls.Add(this.amountLabel);
            this.Name = "AddIncome";
            this.Text = "Add Income";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker incomeDate;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.TextBox tbIncomeAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.TextBox tbIncomeDescription;
        private System.Windows.Forms.ComboBox cbIncomeCategory;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label label6;
    }
}