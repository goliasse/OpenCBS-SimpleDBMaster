namespace OpenCBS.GUI.Accounting
{
    partial class AddExpensesForm
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
            this.amountLabel = new System.Windows.Forms.Label();
            this.cbExpenseCategory = new System.Windows.Forms.ComboBox();
            this.tbExpenseDescription = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExpenseAmount = new System.Windows.Forms.TextBox();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.expenseDate = new System.Windows.Forms.DateTimePicker();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.amountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.amountLabel.Location = new System.Drawing.Point(50, 41);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(94, 16);
            this.amountLabel.TabIndex = 14;
            this.amountLabel.Text = "Expense Date:";
            // 
            // cbExpenseCategory
            // 
            this.cbExpenseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExpenseCategory.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbExpenseCategory.FormattingEnabled = true;
            this.cbExpenseCategory.Items.AddRange(new object[] {
            "Advertising",
            "Furniture Depreciation",
            "IT Depreciation",
            "Utilities Expense",
            "Travel & Accommodation",
            "Staff Amenities",
            "Sundry Expense",
            "Building Maintenance",
            "Property Rental",
            "Printing & Stationary",
            "Postage Freight Courier",
            "Upkeep of Motor Vehicle",
            "Legal Fee",
            "Interest Expenses",
            "Insurance General",
            "Permit, Visa & Misc Fee",
            "Fund Raising Expenses",
            "Computer Expenses",
            "Auditor Remuneration",
            "Bank Charges",
            "Telephone & Broadband",
            "Meal Allowance",
            "Housing Allowance",
            "Cost of Living Allowances",
            "Salary"});
            this.cbExpenseCategory.Location = new System.Drawing.Point(159, 74);
            this.cbExpenseCategory.Name = "cbExpenseCategory";
            this.cbExpenseCategory.Size = new System.Drawing.Size(149, 24);
            this.cbExpenseCategory.TabIndex = 1;
            // 
            // tbExpenseDescription
            // 
            this.tbExpenseDescription.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbExpenseDescription.Location = new System.Drawing.Point(159, 106);
            this.tbExpenseDescription.Name = "tbExpenseDescription";
            this.tbExpenseDescription.Size = new System.Drawing.Size(149, 22);
            this.tbExpenseDescription.TabIndex = 2;
            this.tbExpenseDescription.TextChanged += new System.EventHandler(this.tbFDContractCode_TextChanged);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddExpense.Location = new System.Drawing.Point(159, 267);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(149, 28);
            this.btnAddExpense.TabIndex = 7;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Expense Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Expense Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(33, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Expense Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(74, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Reference:";
            // 
            // tbExpenseAmount
            // 
            this.tbExpenseAmount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbExpenseAmount.Location = new System.Drawing.Point(159, 138);
            this.tbExpenseAmount.Name = "tbExpenseAmount";
            this.tbExpenseAmount.Size = new System.Drawing.Size(149, 22);
            this.tbExpenseAmount.TabIndex = 3;
            this.tbExpenseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExpenseAmount_KeyPress);
            // 
            // tbReference
            // 
            this.tbReference.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbReference.Location = new System.Drawing.Point(159, 166);
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(149, 22);
            this.tbReference.TabIndex = 4;
            // 
            // expenseDate
            // 
            this.expenseDate.Location = new System.Drawing.Point(159, 41);
            this.expenseDate.Name = "expenseDate";
            this.expenseDate.Size = new System.Drawing.Size(149, 20);
            this.expenseDate.TabIndex = 0;
            // 
            // cbBranch
            // 
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(159, 227);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(149, 24);
            this.cbBranch.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(91, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Branch:";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(159, 194);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(149, 24);
            this.cbCurrency.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(80, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Currency:";
            // 
            // AddExpensesForm
            // 
            this.AcceptButton = this.btnAddExpense;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 331);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expenseDate);
            this.Controls.Add(this.tbReference);
            this.Controls.Add(this.tbExpenseAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.tbExpenseDescription);
            this.Controls.Add(this.cbExpenseCategory);
            this.Controls.Add(this.amountLabel);
            this.Name = "AddExpensesForm";
            this.Text = "Add Expenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ComboBox cbExpenseCategory;
        private System.Windows.Forms.TextBox tbExpenseDescription;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExpenseAmount;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.DateTimePicker expenseDate;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label label6;
    }
}