using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Accounting
{
    partial class FrmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.rbDebit = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.treeViewAccounts = new System.Windows.Forms.TreeView();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.labelLabel = new System.Windows.Forms.Label();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.labelParentValue = new System.Windows.Forms.Label();
            this.labelAccountType = new System.Windows.Forms.Label();
            this.tabPageSubCategory = new System.Windows.Forms.TabPage();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSubCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.btnSaving = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbaccountCategoryName = new System.Windows.Forms.Label();
            this.tbAccountCategory = new System.Windows.Forms.TextBox();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.textNumericNumber = new OpenCBS.GUI.UserControl.TextNumericUserControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.tabControlData.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            this.tabPageSubCategory.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBoxData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAction, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.tabControlData);
            resources.ApplyResources(this.groupBoxData, "groupBoxData");
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.TabStop = false;
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.tabPageAccount);
            this.tabControlData.Controls.Add(this.tabPageCategory);
            this.tabControlData.Controls.Add(this.tabPageSubCategory);
            resources.ApplyResources(this.tabControlData, "tabControlData");
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.SelectedIndexChanged += new System.EventHandler(this.tabControlData_SelectedIndexChanged);
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.rbDebit);
            this.tabPageAccount.Controls.Add(this.rbCredit);
            this.tabPageAccount.Controls.Add(this.treeViewAccounts);
            this.tabPageAccount.Controls.Add(this.textNumericNumber);
            this.tabPageAccount.Controls.Add(this.textBoxLabel);
            this.tabPageAccount.Controls.Add(this.labelLabel);
            this.tabPageAccount.Controls.Add(this.labelAccountNumber);
            this.tabPageAccount.Controls.Add(this.labelParentValue);
            this.tabPageAccount.Controls.Add(this.labelAccountType);
            resources.ApplyResources(this.tabPageAccount, "tabPageAccount");
            this.tabPageAccount.Name = "tabPageAccount";
            // 
            // rbDebit
            // 
            resources.ApplyResources(this.rbDebit, "rbDebit");
            this.rbDebit.Name = "rbDebit";
            // 
            // rbCredit
            // 
            resources.ApplyResources(this.rbCredit, "rbCredit");
            this.rbCredit.Checked = true;
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.TabStop = true;
            // 
            // treeViewAccounts
            // 
            this.treeViewAccounts.HideSelection = false;
            resources.ApplyResources(this.treeViewAccounts, "treeViewAccounts");
            this.treeViewAccounts.Name = "treeViewAccounts";
            this.treeViewAccounts.PathSeparator = " --> ";
            this.treeViewAccounts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAccounts_AfterSelect);
            // 
            // textBoxLabel
            // 
            resources.ApplyResources(this.textBoxLabel, "textBoxLabel");
            this.textBoxLabel.Name = "textBoxLabel";
            // 
            // labelLabel
            // 
            resources.ApplyResources(this.labelLabel, "labelLabel");
            this.labelLabel.Name = "labelLabel";
            // 
            // labelAccountNumber
            // 
            resources.ApplyResources(this.labelAccountNumber, "labelAccountNumber");
            this.labelAccountNumber.Name = "labelAccountNumber";
            // 
            // labelParentValue
            // 
            this.labelParentValue.AutoEllipsis = true;
            resources.ApplyResources(this.labelParentValue, "labelParentValue");
            this.labelParentValue.Name = "labelParentValue";
            // 
            // labelAccountType
            // 
            resources.ApplyResources(this.labelAccountType, "labelAccountType");
            this.labelAccountType.Name = "labelAccountType";
            // 
            // tabPageSubCategory
            // 
            this.tabPageSubCategory.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSubCategory.Controls.Add(this.cbBranch);
            this.tabPageSubCategory.Controls.Add(this.tbBalance);
            this.tabPageSubCategory.Controls.Add(this.label3);
            this.tabPageSubCategory.Controls.Add(this.label2);
            this.tabPageSubCategory.Controls.Add(this.cbCategory);
            this.tabPageSubCategory.Controls.Add(this.label6);
            this.tabPageSubCategory.Controls.Add(this.tbSubCategory);
            this.tabPageSubCategory.Controls.Add(this.label1);
            resources.ApplyResources(this.tabPageSubCategory, "tabPageSubCategory");
            this.tabPageSubCategory.Name = "tabPageSubCategory";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCategory, "cbCategory");
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Name = "cbCategory";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tbSubCategory
            // 
            resources.ApplyResources(this.tbSubCategory, "tbSubCategory");
            this.tbSubCategory.Name = "tbSubCategory";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.btnSaving);
            this.groupBoxAction.Controls.Add(this.btnClose);
            resources.ApplyResources(this.groupBoxAction, "groupBoxAction");
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.TabStop = false;
            // 
            // btnSaving
            // 
            resources.ApplyResources(this.btnSaving, "btnSaving");
            this.btnSaving.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Click += new System.EventHandler(this.btnSaving_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            // 
            // lbaccountCategoryName
            // 
            resources.ApplyResources(this.lbaccountCategoryName, "lbaccountCategoryName");
            this.lbaccountCategoryName.Name = "lbaccountCategoryName";
            // 
            // tbAccountCategory
            // 
            resources.ApplyResources(this.tbAccountCategory, "tbAccountCategory");
            this.tbAccountCategory.Name = "tbAccountCategory";
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.tbAccountCategory);
            this.tabPageCategory.Controls.Add(this.lbaccountCategoryName);
            resources.ApplyResources(this.tabPageCategory, "tabPageCategory");
            this.tabPageCategory.Name = "tabPageCategory";
            // 
            // textNumericNumber
            // 
            resources.ApplyResources(this.textNumericNumber, "textNumericNumber");
            this.textNumericNumber.Name = "textNumericNumber";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbBalance
            // 
            resources.ApplyResources(this.tbBalance, "tbBalance");
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBalance_KeyPress);
            // 
            // cbBranch
            // 
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbBranch, "cbBranch");
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Name = "cbBranch";
            // 
            // FrmAccount
            // 
            this.AcceptButton = this.btnSaving;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAccount";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.tabControlData.ResumeLayout(false);
            this.tabPageAccount.ResumeLayout(false);
            this.tabPageAccount.PerformLayout();
            this.tabPageSubCategory.ResumeLayout(false);
            this.tabPageSubCategory.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button btnSaving;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.TreeView treeViewAccounts;
        private OpenCBS.GUI.UserControl.TextNumericUserControl textNumericNumber;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Label labelParentValue;
        private System.Windows.Forms.Label labelAccountType;
        private System.Windows.Forms.RadioButton rbDebit;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.TabPage tabPageSubCategory;
        private System.Windows.Forms.TextBox tbSubCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TextBox tbAccountCategory;
        private System.Windows.Forms.Label lbaccountCategoryName;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBranch;
    }
}