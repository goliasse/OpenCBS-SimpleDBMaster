namespace OpenCBS.GUI.Products
{
    partial class FrmAddFixedDepositProduct
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
            this.tabControlSaving = new System.Windows.Forms.TabControl();
            this.tabPageMainParameters = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxMaturityPeriod = new System.Windows.Forms.TextBox();
            this.tbMinMaturityPeriod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPenaltyValue = new System.Windows.Forms.TextBox();
            this.lbEntryFeesValue = new System.Windows.Forms.Label();
            this.rbPenalityTypeRate = new System.Windows.Forms.RadioButton();
            this.rbPenalityTypeFlat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPenalityMax = new System.Windows.Forms.TextBox();
            this.tbPenalityMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbFrequency = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFrequencyMonths = new System.Windows.Forms.TextBox();
            this.lbAccrual = new System.Windows.Forms.Label();
            this.groupBoxCurrency = new System.Windows.Forms.GroupBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.lbCodeSavingProduct = new System.Windows.Forms.Label();
            this.lbNameSavingProduct = new System.Windows.Forms.Label();
            this.gbClientType = new System.Windows.Forms.GroupBox();
            this.clientTypeCorpCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeIndivCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeVillageCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeAllCheckBox = new System.Windows.Forms.CheckBox();
            this.tbCodeFixedDepositProduct = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbInitialAmount = new System.Windows.Forms.GroupBox();
            this.tbInitialAmountMax = new System.Windows.Forms.TextBox();
            this.tbInitialAmountMin = new System.Windows.Forms.TextBox();
            this.lbInitialAmonutMax = new System.Windows.Forms.Label();
            this.lbInitialAmountMin = new System.Windows.Forms.Label();
            this.gbInterestRate = new System.Windows.Forms.GroupBox();
            this.lbYearlyInterestRateMax = new System.Windows.Forms.Label();
            this.lbYearlyInterestRateMin = new System.Windows.Forms.Label();
            this.tbInterestRateMax = new System.Windows.Forms.TextBox();
            this.tbInterestRateMin = new System.Windows.Forms.TextBox();
            this.lbInterestRateMax = new System.Windows.Forms.Label();
            this.lbInterestRateMin = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSavingProduct = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.tabControlSaving.SuspendLayout();
            this.tabPageMainParameters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbFrequency.SuspendLayout();
            this.groupBoxCurrency.SuspendLayout();
            this.gbClientType.SuspendLayout();
            this.gbInitialAmount.SuspendLayout();
            this.gbInterestRate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSaving
            // 
            this.tabControlSaving.Controls.Add(this.tabPageMainParameters);
            this.tabControlSaving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControlSaving.ItemSize = new System.Drawing.Size(91, 32);
            this.tabControlSaving.Location = new System.Drawing.Point(0, 0);
            this.tabControlSaving.Name = "tabControlSaving";
            this.tabControlSaving.SelectedIndex = 0;
            this.tabControlSaving.Size = new System.Drawing.Size(677, 664);
            this.tabControlSaving.TabIndex = 16;
            this.tabControlSaving.SelectedIndexChanged += new System.EventHandler(this.tabControlSaving_SelectedIndexChanged);
            // 
            // tabPageMainParameters
            // 
            this.tabPageMainParameters.Controls.Add(this.groupBox1);
            this.tabPageMainParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabPageMainParameters.Location = new System.Drawing.Point(4, 36);
            this.tabPageMainParameters.Name = "tabPageMainParameters";
            this.tabPageMainParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainParameters.Size = new System.Drawing.Size(669, 624);
            this.tabPageMainParameters.TabIndex = 0;
            this.tabPageMainParameters.Text = "Main Parameters";
            this.tabPageMainParameters.Click += new System.EventHandler(this.tabPageMainParameters_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.gbFrequency);
            this.groupBox1.Controls.Add(this.groupBoxCurrency);
            this.groupBox1.Controls.Add(this.lbCodeSavingProduct);
            this.groupBox1.Controls.Add(this.lbNameSavingProduct);
            this.groupBox1.Controls.Add(this.gbClientType);
            this.groupBox1.Controls.Add(this.tbCodeFixedDepositProduct);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.gbInitialAmount);
            this.groupBox1.Controls.Add(this.gbInterestRate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 618);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.25F);
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(196, 573);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 25);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbMaxMaturityPeriod);
            this.groupBox4.Controls.Add(this.tbMinMaturityPeriod);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(326, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 99);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Maturity Period";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(184, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Months";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(184, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Months";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbMaxMaturityPeriod
            // 
            this.tbMaxMaturityPeriod.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbMaxMaturityPeriod.Location = new System.Drawing.Point(78, 54);
            this.tbMaxMaturityPeriod.Name = "tbMaxMaturityPeriod";
            this.tbMaxMaturityPeriod.Size = new System.Drawing.Size(100, 22);
            this.tbMaxMaturityPeriod.TabIndex = 7;
            this.tbMaxMaturityPeriod.TextChanged += new System.EventHandler(this.tbMaxMaturityPeriod_TextChanged);
            this.tbMaxMaturityPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // tbMinMaturityPeriod
            // 
            this.tbMinMaturityPeriod.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbMinMaturityPeriod.Location = new System.Drawing.Point(78, 22);
            this.tbMinMaturityPeriod.Name = "tbMinMaturityPeriod";
            this.tbMinMaturityPeriod.Size = new System.Drawing.Size(100, 22);
            this.tbMinMaturityPeriod.TabIndex = 6;
            this.tbMinMaturityPeriod.TextChanged += new System.EventHandler(this.tbMinMaturityPeriod_TextChanged);
            this.tbMinMaturityPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(14, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Min:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPenaltyValue);
            this.groupBox3.Controls.Add(this.lbEntryFeesValue);
            this.groupBox3.Controls.Add(this.rbPenalityTypeRate);
            this.groupBox3.Controls.Add(this.rbPenalityTypeFlat);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbPenalityMax);
            this.groupBox3.Controls.Add(this.tbPenalityMin);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(11, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 116);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Penalty If Withdrawn Before Maturity";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tbPenaltyValue
            // 
            this.tbPenaltyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPenaltyValue.Location = new System.Drawing.Point(393, 54);
            this.tbPenaltyValue.Name = "tbPenaltyValue";
            this.tbPenaltyValue.Size = new System.Drawing.Size(100, 22);
            this.tbPenaltyValue.TabIndex = 21;
            // 
            // lbEntryFeesValue
            // 
            this.lbEntryFeesValue.AutoSize = true;
            this.lbEntryFeesValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbEntryFeesValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEntryFeesValue.Location = new System.Drawing.Point(329, 57);
            this.lbEntryFeesValue.Name = "lbEntryFeesValue";
            this.lbEntryFeesValue.Size = new System.Drawing.Size(56, 16);
            this.lbEntryFeesValue.TabIndex = 20;
            this.lbEntryFeesValue.Text = "or value:";
            // 
            // rbPenalityTypeRate
            // 
            this.rbPenalityTypeRate.AutoSize = true;
            this.rbPenalityTypeRate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbPenalityTypeRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbPenalityTypeRate.Location = new System.Drawing.Point(133, 22);
            this.rbPenalityTypeRate.Name = "rbPenalityTypeRate";
            this.rbPenalityTypeRate.Size = new System.Drawing.Size(53, 20);
            this.rbPenalityTypeRate.TabIndex = 18;
            this.rbPenalityTypeRate.Text = "Rate";
            this.rbPenalityTypeRate.CheckedChanged += new System.EventHandler(this.rbPenalityTypeRate_CheckedChanged);
            // 
            // rbPenalityTypeFlat
            // 
            this.rbPenalityTypeFlat.AutoSize = true;
            this.rbPenalityTypeFlat.Checked = true;
            this.rbPenalityTypeFlat.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbPenalityTypeFlat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbPenalityTypeFlat.Location = new System.Drawing.Point(79, 22);
            this.rbPenalityTypeFlat.Name = "rbPenalityTypeFlat";
            this.rbPenalityTypeFlat.Size = new System.Drawing.Size(48, 20);
            this.rbPenalityTypeFlat.TabIndex = 19;
            this.rbPenalityTypeFlat.TabStop = true;
            this.rbPenalityTypeFlat.Text = "Flat";
            this.rbPenalityTypeFlat.CheckedChanged += new System.EventHandler(this.rbPenalityTypeFlat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPenalityMax
            // 
            this.tbPenalityMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPenalityMax.Location = new System.Drawing.Point(78, 80);
            this.tbPenalityMax.Name = "tbPenalityMax";
            this.tbPenalityMax.Size = new System.Drawing.Size(100, 22);
            this.tbPenalityMax.TabIndex = 7;
            this.tbPenalityMax.TextChanged += new System.EventHandler(this.tbPenalityMax_TextChanged);
            this.tbPenalityMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // tbPenalityMin
            // 
            this.tbPenalityMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPenalityMin.Location = new System.Drawing.Point(78, 51);
            this.tbPenalityMin.Name = "tbPenalityMin";
            this.tbPenalityMin.Size = new System.Drawing.Size(100, 22);
            this.tbPenalityMin.TabIndex = 6;
            this.tbPenalityMin.TextChanged += new System.EventHandler(this.tbPenalityMin_TextChanged);
            this.tbPenalityMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.25F);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(356, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 25);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.25F);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(519, 573);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 25);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbFrequency
            // 
            this.gbFrequency.Controls.Add(this.label8);
            this.gbFrequency.Controls.Add(this.tbFrequencyMonths);
            this.gbFrequency.Controls.Add(this.lbAccrual);
            this.gbFrequency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gbFrequency.Location = new System.Drawing.Point(9, 321);
            this.gbFrequency.Name = "gbFrequency";
            this.gbFrequency.Size = new System.Drawing.Size(638, 94);
            this.gbFrequency.TabIndex = 10;
            this.gbFrequency.TabStop = false;
            this.gbFrequency.Text = "Interest Calculation Frequency";
            this.gbFrequency.Enter += new System.EventHandler(this.gbFrequency_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(266, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Months";
            // 
            // tbFrequencyMonths
            // 
            this.tbFrequencyMonths.Location = new System.Drawing.Point(135, 26);
            this.tbFrequencyMonths.Name = "tbFrequencyMonths";
            this.tbFrequencyMonths.Size = new System.Drawing.Size(100, 22);
            this.tbFrequencyMonths.TabIndex = 3;
            this.tbFrequencyMonths.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // lbAccrual
            // 
            this.lbAccrual.AutoSize = true;
            this.lbAccrual.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbAccrual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbAccrual.Location = new System.Drawing.Point(18, 26);
            this.lbAccrual.Name = "lbAccrual";
            this.lbAccrual.Size = new System.Drawing.Size(73, 16);
            this.lbAccrual.TabIndex = 2;
            this.lbAccrual.Text = "Frequency:";
            this.lbAccrual.Click += new System.EventHandler(this.lbAccrual_Click);
            // 
            // groupBoxCurrency
            // 
            this.groupBoxCurrency.Controls.Add(this.cbCurrency);
            this.groupBoxCurrency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.groupBoxCurrency.Location = new System.Drawing.Point(435, 42);
            this.groupBoxCurrency.Name = "groupBoxCurrency";
            this.groupBoxCurrency.Size = new System.Drawing.Size(212, 74);
            this.groupBoxCurrency.TabIndex = 4;
            this.groupBoxCurrency.TabStop = false;
            this.groupBoxCurrency.Text = "Attach product to currency";
            this.groupBoxCurrency.Enter += new System.EventHandler(this.groupBoxCurrency_Enter);
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(26, 33);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(155, 24);
            this.cbCurrency.TabIndex = 0;
            this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
            // 
            // lbCodeSavingProduct
            // 
            this.lbCodeSavingProduct.AutoSize = true;
            this.lbCodeSavingProduct.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbCodeSavingProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodeSavingProduct.Location = new System.Drawing.Point(275, 16);
            this.lbCodeSavingProduct.Name = "lbCodeSavingProduct";
            this.lbCodeSavingProduct.Size = new System.Drawing.Size(38, 16);
            this.lbCodeSavingProduct.TabIndex = 0;
            this.lbCodeSavingProduct.Text = "Code";
            this.lbCodeSavingProduct.Click += new System.EventHandler(this.lbCodeSavingProduct_Click);
            // 
            // lbNameSavingProduct
            // 
            this.lbNameSavingProduct.AutoSize = true;
            this.lbNameSavingProduct.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbNameSavingProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNameSavingProduct.Location = new System.Drawing.Point(8, 16);
            this.lbNameSavingProduct.Name = "lbNameSavingProduct";
            this.lbNameSavingProduct.Size = new System.Drawing.Size(42, 16);
            this.lbNameSavingProduct.TabIndex = 0;
            this.lbNameSavingProduct.Text = "Name";
            this.lbNameSavingProduct.Click += new System.EventHandler(this.lbNameSavingProduct_Click);
            // 
            // gbClientType
            // 
            this.gbClientType.Controls.Add(this.clientTypeCorpCheckBox);
            this.gbClientType.Controls.Add(this.clientTypeIndivCheckBox);
            this.gbClientType.Controls.Add(this.clientTypeVillageCheckBox);
            this.gbClientType.Controls.Add(this.clientTypeGroupCheckBox);
            this.gbClientType.Controls.Add(this.clientTypeAllCheckBox);
            this.gbClientType.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gbClientType.Location = new System.Drawing.Point(9, 42);
            this.gbClientType.Name = "gbClientType";
            this.gbClientType.Size = new System.Drawing.Size(420, 75);
            this.gbClientType.TabIndex = 3;
            this.gbClientType.TabStop = false;
            this.gbClientType.Text = "Attach product to a specific client type";
            this.gbClientType.Enter += new System.EventHandler(this.gbClientType_Enter);
            // 
            // clientTypeCorpCheckBox
            // 
            this.clientTypeCorpCheckBox.AutoSize = true;
            this.clientTypeCorpCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.clientTypeCorpCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientTypeCorpCheckBox.Location = new System.Drawing.Point(215, 32);
            this.clientTypeCorpCheckBox.Name = "clientTypeCorpCheckBox";
            this.clientTypeCorpCheckBox.Size = new System.Drawing.Size(58, 20);
            this.clientTypeCorpCheckBox.TabIndex = 6;
            this.clientTypeCorpCheckBox.Text = "Corp.";
            this.clientTypeCorpCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeCorpCheckBox_CheckedChanged);
            // 
            // clientTypeIndivCheckBox
            // 
            this.clientTypeIndivCheckBox.AutoSize = true;
            this.clientTypeIndivCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.clientTypeIndivCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientTypeIndivCheckBox.Location = new System.Drawing.Point(161, 32);
            this.clientTypeIndivCheckBox.Name = "clientTypeIndivCheckBox";
            this.clientTypeIndivCheckBox.Size = new System.Drawing.Size(48, 20);
            this.clientTypeIndivCheckBox.TabIndex = 6;
            this.clientTypeIndivCheckBox.Text = "Ind.";
            this.clientTypeIndivCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeIndivCheckBox_CheckedChanged);
            // 
            // clientTypeVillageCheckBox
            // 
            this.clientTypeVillageCheckBox.AutoSize = true;
            this.clientTypeVillageCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.clientTypeVillageCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientTypeVillageCheckBox.Location = new System.Drawing.Point(280, 32);
            this.clientTypeVillageCheckBox.Name = "clientTypeVillageCheckBox";
            this.clientTypeVillageCheckBox.Size = new System.Drawing.Size(111, 20);
            this.clientTypeVillageCheckBox.TabIndex = 6;
            this.clientTypeVillageCheckBox.Text = "Non sol. group";
            this.clientTypeVillageCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeVillageCheckBox_CheckedChanged);
            // 
            // clientTypeGroupCheckBox
            // 
            this.clientTypeGroupCheckBox.AutoSize = true;
            this.clientTypeGroupCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.clientTypeGroupCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientTypeGroupCheckBox.Location = new System.Drawing.Point(67, 32);
            this.clientTypeGroupCheckBox.Name = "clientTypeGroupCheckBox";
            this.clientTypeGroupCheckBox.Size = new System.Drawing.Size(86, 20);
            this.clientTypeGroupCheckBox.TabIndex = 6;
            this.clientTypeGroupCheckBox.Text = "Sol. group";
            this.clientTypeGroupCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeGroupCheckBox_CheckedChanged_1);
            // 
            // clientTypeAllCheckBox
            // 
            this.clientTypeAllCheckBox.AutoSize = true;
            this.clientTypeAllCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.clientTypeAllCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientTypeAllCheckBox.Location = new System.Drawing.Point(12, 32);
            this.clientTypeAllCheckBox.Name = "clientTypeAllCheckBox";
            this.clientTypeAllCheckBox.Size = new System.Drawing.Size(42, 20);
            this.clientTypeAllCheckBox.TabIndex = 6;
            this.clientTypeAllCheckBox.Text = "All";
            this.clientTypeAllCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeAllCheckBox_CheckedChanged);
            // 
            // tbCodeFixedDepositProduct
            // 
            this.tbCodeFixedDepositProduct.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbCodeFixedDepositProduct.Location = new System.Drawing.Point(326, 16);
            this.tbCodeFixedDepositProduct.Name = "tbCodeFixedDepositProduct";
            this.tbCodeFixedDepositProduct.Size = new System.Drawing.Size(175, 22);
            this.tbCodeFixedDepositProduct.TabIndex = 2;
            this.tbCodeFixedDepositProduct.TextChanged += new System.EventHandler(this.tbCodeFixedDepositProduct_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbName.Location = new System.Drawing.Point(59, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(175, 22);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // gbInitialAmount
            // 
            this.gbInitialAmount.Controls.Add(this.tbInitialAmountMax);
            this.gbInitialAmount.Controls.Add(this.tbInitialAmountMin);
            this.gbInitialAmount.Controls.Add(this.lbInitialAmonutMax);
            this.gbInitialAmount.Controls.Add(this.lbInitialAmountMin);
            this.gbInitialAmount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gbInitialAmount.Location = new System.Drawing.Point(9, 123);
            this.gbInitialAmount.Name = "gbInitialAmount";
            this.gbInitialAmount.Size = new System.Drawing.Size(200, 86);
            this.gbInitialAmount.TabIndex = 5;
            this.gbInitialAmount.TabStop = false;
            this.gbInitialAmount.Text = "Initial amount";
            this.gbInitialAmount.Enter += new System.EventHandler(this.gbInitialAmount_Enter);
            // 
            // tbInitialAmountMax
            // 
            this.tbInitialAmountMax.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbInitialAmountMax.Location = new System.Drawing.Point(80, 52);
            this.tbInitialAmountMax.Name = "tbInitialAmountMax";
            this.tbInitialAmountMax.Size = new System.Drawing.Size(100, 22);
            this.tbInitialAmountMax.TabIndex = 1;
            this.tbInitialAmountMax.TextChanged += new System.EventHandler(this.tbInitialAmountMax_TextChanged);
            this.tbInitialAmountMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // tbInitialAmountMin
            // 
            this.tbInitialAmountMin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbInitialAmountMin.Location = new System.Drawing.Point(80, 22);
            this.tbInitialAmountMin.Name = "tbInitialAmountMin";
            this.tbInitialAmountMin.Size = new System.Drawing.Size(100, 22);
            this.tbInitialAmountMin.TabIndex = 0;
            this.tbInitialAmountMin.TextChanged += new System.EventHandler(this.tbInitialAmountMin_TextChanged);
            this.tbInitialAmountMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // lbInitialAmonutMax
            // 
            this.lbInitialAmonutMax.AutoSize = true;
            this.lbInitialAmonutMax.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbInitialAmonutMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInitialAmonutMax.Location = new System.Drawing.Point(17, 55);
            this.lbInitialAmonutMax.Name = "lbInitialAmonutMax";
            this.lbInitialAmonutMax.Size = new System.Drawing.Size(37, 16);
            this.lbInitialAmonutMax.TabIndex = 1;
            this.lbInitialAmonutMax.Text = "Max:";
            this.lbInitialAmonutMax.Click += new System.EventHandler(this.lbInitialAmonutMax_Click);
            // 
            // lbInitialAmountMin
            // 
            this.lbInitialAmountMin.AutoSize = true;
            this.lbInitialAmountMin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbInitialAmountMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInitialAmountMin.Location = new System.Drawing.Point(17, 25);
            this.lbInitialAmountMin.Name = "lbInitialAmountMin";
            this.lbInitialAmountMin.Size = new System.Drawing.Size(33, 16);
            this.lbInitialAmountMin.TabIndex = 0;
            this.lbInitialAmountMin.Text = "Min:";
            this.lbInitialAmountMin.Click += new System.EventHandler(this.lbInitialAmountMin_Click);
            // 
            // gbInterestRate
            // 
            this.gbInterestRate.Controls.Add(this.lbYearlyInterestRateMax);
            this.gbInterestRate.Controls.Add(this.lbYearlyInterestRateMin);
            this.gbInterestRate.Controls.Add(this.tbInterestRateMax);
            this.gbInterestRate.Controls.Add(this.tbInterestRateMin);
            this.gbInterestRate.Controls.Add(this.lbInterestRateMax);
            this.gbInterestRate.Controls.Add(this.lbInterestRateMin);
            this.gbInterestRate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gbInterestRate.Location = new System.Drawing.Point(9, 216);
            this.gbInterestRate.Name = "gbInterestRate";
            this.gbInterestRate.Size = new System.Drawing.Size(273, 100);
            this.gbInterestRate.TabIndex = 8;
            this.gbInterestRate.TabStop = false;
            this.gbInterestRate.Text = "Interest rate";
            this.gbInterestRate.Enter += new System.EventHandler(this.gbInterestRate_Enter);
            // 
            // lbYearlyInterestRateMax
            // 
            this.lbYearlyInterestRateMax.AutoSize = true;
            this.lbYearlyInterestRateMax.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbYearlyInterestRateMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbYearlyInterestRateMax.Location = new System.Drawing.Point(184, 54);
            this.lbYearlyInterestRateMax.Name = "lbYearlyInterestRateMax";
            this.lbYearlyInterestRateMax.Size = new System.Drawing.Size(71, 16);
            this.lbYearlyInterestRateMax.TabIndex = 14;
            this.lbYearlyInterestRateMax.Text = "...% yearly";
            this.lbYearlyInterestRateMax.Click += new System.EventHandler(this.lbYearlyInterestRateMax_Click);
            // 
            // lbYearlyInterestRateMin
            // 
            this.lbYearlyInterestRateMin.AutoSize = true;
            this.lbYearlyInterestRateMin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbYearlyInterestRateMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbYearlyInterestRateMin.Location = new System.Drawing.Point(184, 25);
            this.lbYearlyInterestRateMin.Name = "lbYearlyInterestRateMin";
            this.lbYearlyInterestRateMin.Size = new System.Drawing.Size(71, 16);
            this.lbYearlyInterestRateMin.TabIndex = 13;
            this.lbYearlyInterestRateMin.Text = "...% yearly";
            this.lbYearlyInterestRateMin.Click += new System.EventHandler(this.lbYearlyInterestRateMin_Click);
            // 
            // tbInterestRateMax
            // 
            this.tbInterestRateMax.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbInterestRateMax.Location = new System.Drawing.Point(78, 51);
            this.tbInterestRateMax.Name = "tbInterestRateMax";
            this.tbInterestRateMax.Size = new System.Drawing.Size(100, 22);
            this.tbInterestRateMax.TabIndex = 7;
            this.tbInterestRateMax.TextChanged += new System.EventHandler(this.tbInterestRateMax_TextChanged);
            this.tbInterestRateMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // tbInterestRateMin
            // 
            this.tbInterestRateMin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbInterestRateMin.Location = new System.Drawing.Point(78, 22);
            this.tbInterestRateMin.Name = "tbInterestRateMin";
            this.tbInterestRateMin.Size = new System.Drawing.Size(100, 22);
            this.tbInterestRateMin.TabIndex = 6;
            this.tbInterestRateMin.TextChanged += new System.EventHandler(this.tbInterestRateMin_TextChanged);
            this.tbInterestRateMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialAmountMin_KeyPress);
            // 
            // lbInterestRateMax
            // 
            this.lbInterestRateMax.AutoSize = true;
            this.lbInterestRateMax.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbInterestRateMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInterestRateMax.Location = new System.Drawing.Point(15, 54);
            this.lbInterestRateMax.Name = "lbInterestRateMax";
            this.lbInterestRateMax.Size = new System.Drawing.Size(37, 16);
            this.lbInterestRateMax.TabIndex = 5;
            this.lbInterestRateMax.Text = "Max:";
            this.lbInterestRateMax.Click += new System.EventHandler(this.lbInterestRateMax_Click);
            // 
            // lbInterestRateMin
            // 
            this.lbInterestRateMin.AutoSize = true;
            this.lbInterestRateMin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbInterestRateMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInterestRateMin.Location = new System.Drawing.Point(14, 25);
            this.lbInterestRateMin.Name = "lbInterestRateMin";
            this.lbInterestRateMin.Size = new System.Drawing.Size(33, 16);
            this.lbInterestRateMin.TabIndex = 4;
            this.lbInterestRateMin.Text = "Min:";
            this.lbInterestRateMin.Click += new System.EventHandler(this.lbInterestRateMin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSavingProduct);
            this.groupBox2.Controls.Add(this.bClose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 664);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btSavingProduct
            // 
            this.btSavingProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSavingProduct.Font = new System.Drawing.Font("Arial", 9.25F);
            this.btSavingProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSavingProduct.Location = new System.Drawing.Point(403, 26);
            this.btSavingProduct.Name = "btSavingProduct";
            this.btSavingProduct.Size = new System.Drawing.Size(128, 25);
            this.btSavingProduct.TabIndex = 9;
            this.btSavingProduct.Text = "Save";
            this.btSavingProduct.Click += new System.EventHandler(this.btSavingProduct_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Font = new System.Drawing.Font("Arial", 9.25F);
            this.bClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bClose.Location = new System.Drawing.Point(537, 26);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(128, 25);
            this.bClose.TabIndex = 11;
            this.bClose.Text = "Close";
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // FrmAddFixedDepositProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 664);
            this.Controls.Add(this.tabControlSaving);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddFixedDepositProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixed Deposit Product";
            this.tabControlSaving.ResumeLayout(false);
            this.tabPageMainParameters.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbFrequency.ResumeLayout(false);
            this.gbFrequency.PerformLayout();
            this.groupBoxCurrency.ResumeLayout(false);
            this.gbClientType.ResumeLayout(false);
            this.gbClientType.PerformLayout();
            this.gbInitialAmount.ResumeLayout(false);
            this.gbInitialAmount.PerformLayout();
            this.gbInterestRate.ResumeLayout(false);
            this.gbInterestRate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSaving;
        private System.Windows.Forms.TabPage tabPageMainParameters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFrequency;
        private System.Windows.Forms.Label lbAccrual;
        private System.Windows.Forms.GroupBox groupBoxCurrency;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label lbCodeSavingProduct;
        private System.Windows.Forms.Label lbNameSavingProduct;
        private System.Windows.Forms.GroupBox gbClientType;
        private System.Windows.Forms.CheckBox clientTypeCorpCheckBox;
        private System.Windows.Forms.CheckBox clientTypeIndivCheckBox;
        private System.Windows.Forms.CheckBox clientTypeVillageCheckBox;
        private System.Windows.Forms.CheckBox clientTypeGroupCheckBox;
        private System.Windows.Forms.CheckBox clientTypeAllCheckBox;
        private System.Windows.Forms.TextBox tbCodeFixedDepositProduct;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbInitialAmount;
        private System.Windows.Forms.TextBox tbInitialAmountMax;
        private System.Windows.Forms.TextBox tbInitialAmountMin;
        private System.Windows.Forms.Label lbInitialAmonutMax;
        private System.Windows.Forms.Label lbInitialAmountMin;
        private System.Windows.Forms.GroupBox gbInterestRate;
        private System.Windows.Forms.Label lbYearlyInterestRateMax;
        private System.Windows.Forms.Label lbYearlyInterestRateMin;
        private System.Windows.Forms.TextBox tbInterestRateMax;
        private System.Windows.Forms.TextBox tbInterestRateMin;
        private System.Windows.Forms.Label lbInterestRateMax;
        private System.Windows.Forms.Label lbInterestRateMin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSavingProduct;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPenalityTypeRate;
        private System.Windows.Forms.RadioButton rbPenalityTypeFlat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPenalityMax;
        private System.Windows.Forms.TextBox tbPenalityMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxMaturityPeriod;
        private System.Windows.Forms.TextBox tbMinMaturityPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFrequencyMonths;
        private System.Windows.Forms.TextBox tbPenaltyValue;
        private System.Windows.Forms.Label lbEntryFeesValue;
    }
}