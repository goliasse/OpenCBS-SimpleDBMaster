using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Products
{
    partial class FrmAddCurrentAccountProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCurrentAccountProduct));
            this.btnCurrentAccountProduct = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlSaving = new System.Windows.Forms.TabControl();
            this.tabPageMainParameters = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gtOverdraftFees = new System.Windows.Forms.GroupBox();
            this.tbOverdraftLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRateOverdraftFees = new System.Windows.Forms.RadioButton();
            this.rbFlatOverdraftFees = new System.Windows.Forms.RadioButton();
            this.lbOverdraftFeesType = new System.Windows.Forms.Label();
            this.tbOverdraftFees = new System.Windows.Forms.TextBox();
            this.lbOverdraftFeesValue = new System.Windows.Forms.Label();
            this.tbOverdraftFeesMax = new System.Windows.Forms.TextBox();
            this.tbOverdraftFeesMin = new System.Windows.Forms.TextBox();
            this.lbOverdraftFeesMax = new System.Windows.Forms.Label();
            this.lbOverdraftFeesMin = new System.Windows.Forms.Label();
            this.gbFrequency = new System.Windows.Forms.GroupBox();
            this.lbAccrual = new System.Windows.Forms.Label();
            this.cbInterestCalculationFrequency = new System.Windows.Forms.ComboBox();
            this.gbInterestRate = new System.Windows.Forms.GroupBox();
            this.lbYearlyInterestRateMax = new System.Windows.Forms.Label();
            this.lbYearlyInterestRateMin = new System.Windows.Forms.Label();
            this.tbInterestRateMax = new System.Windows.Forms.TextBox();
            this.tbInterestRateMin = new System.Windows.Forms.TextBox();
            this.lbInterestRateMax = new System.Windows.Forms.Label();
            this.lbInterestRateMin = new System.Windows.Forms.Label();
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
            this.tbCodeCurrentAccountProduct = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbInitialAmount = new System.Windows.Forms.GroupBox();
            this.tbInitialAmountMax = new System.Windows.Forms.TextBox();
            this.tbInitialAmountMin = new System.Windows.Forms.TextBox();
            this.lbInitialAmonutMax = new System.Windows.Forms.Label();
            this.lbInitialAmountMin = new System.Windows.Forms.Label();
            this.gbBalance = new System.Windows.Forms.GroupBox();
            this.tbBalanceMax = new System.Windows.Forms.TextBox();
            this.tbBalanceMin = new System.Windows.Forms.TextBox();
            this.lbBalanceMax = new System.Windows.Forms.Label();
            this.lbBalanceMin = new System.Windows.Forms.Label();
            this.tabPageManagement = new System.Windows.Forms.TabPage();
            this.gbReopenFees = new System.Windows.Forms.GroupBox();
            this.rbRateReopenFees = new System.Windows.Forms.RadioButton();
            this.rbFlatReopenFees = new System.Windows.Forms.RadioButton();
            this.lbReopenFeesType = new System.Windows.Forms.Label();
            this.tbReopenFees = new System.Windows.Forms.TextBox();
            this.lbReopenFeesValue = new System.Windows.Forms.Label();
            this.tbReopenFeesMax = new System.Windows.Forms.TextBox();
            this.tbReopenFeesMin = new System.Windows.Forms.TextBox();
            this.lbReopenFeesMax = new System.Windows.Forms.Label();
            this.lbReopenFeesMin = new System.Windows.Forms.Label();
            this.gtManagementFees = new System.Windows.Forms.GroupBox();
            this.cbManagementFeeFreq = new System.Windows.Forms.ComboBox();
            this.rbRateManagementFees = new System.Windows.Forms.RadioButton();
            this.rbFlatManagementFees = new System.Windows.Forms.RadioButton();
            this.lbManagementFeesType = new System.Windows.Forms.Label();
            this.tbManagementFees = new System.Windows.Forms.TextBox();
            this.lbManagementFees = new System.Windows.Forms.Label();
            this.tbManagementFeesMax = new System.Windows.Forms.TextBox();
            this.tbManagementFeesMin = new System.Windows.Forms.TextBox();
            this.lbManagementFeesMax = new System.Windows.Forms.Label();
            this.lbManagementFeesMin = new System.Windows.Forms.Label();
            this.gtCloseFees = new System.Windows.Forms.GroupBox();
            this.rbRateCloseFees = new System.Windows.Forms.RadioButton();
            this.rbFlatCloseFees = new System.Windows.Forms.RadioButton();
            this.lbCloseFeesType = new System.Windows.Forms.Label();
            this.tbCloseFees = new System.Windows.Forms.TextBox();
            this.lbCloseFees = new System.Windows.Forms.Label();
            this.tbCloseFeesMax = new System.Windows.Forms.TextBox();
            this.tbCloseFeesMin = new System.Windows.Forms.TextBox();
            this.lbCloseFeesMax = new System.Windows.Forms.Label();
            this.lbCloseFeesMin = new System.Windows.Forms.Label();
            this.gbEntryFees = new System.Windows.Forms.GroupBox();
            this.rbRateEntryFees = new System.Windows.Forms.RadioButton();
            this.rbFlatEntryFees = new System.Windows.Forms.RadioButton();
            this.lbEntryFeesType = new System.Windows.Forms.Label();
            this.tbEntryFees = new System.Windows.Forms.TextBox();
            this.lbEntryFeesValue = new System.Windows.Forms.Label();
            this.tbEntryFeesMax = new System.Windows.Forms.TextBox();
            this.tbEntryFeesMin = new System.Windows.Forms.TextBox();
            this.lbEntryFeesMax = new System.Windows.Forms.Label();
            this.lbEntryFeesMin = new System.Windows.Forms.Label();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlSaving.SuspendLayout();
            this.tabPageMainParameters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gtOverdraftFees.SuspendLayout();
            this.gbFrequency.SuspendLayout();
            this.gbInterestRate.SuspendLayout();
            this.groupBoxCurrency.SuspendLayout();
            this.gbClientType.SuspendLayout();
            this.gbInitialAmount.SuspendLayout();
            this.gbBalance.SuspendLayout();
            this.tabPageManagement.SuspendLayout();
            this.gbReopenFees.SuspendLayout();
            this.gtManagementFees.SuspendLayout();
            this.gtCloseFees.SuspendLayout();
            this.gbEntryFees.SuspendLayout();
            this.tabPageTransactions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCurrentAccountProduct
            // 
            resources.ApplyResources(this.btnCurrentAccountProduct, "btnCurrentAccountProduct");
            this.btnCurrentAccountProduct.Name = "btnCurrentAccountProduct";
            this.btnCurrentAccountProduct.Click += new System.EventHandler(this.btSavingProduct_Click);
            // 
            // bClose
            // 
            resources.ApplyResources(this.bClose, "bClose");
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Name = "bClose";
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlSaving);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            // 
            // tabControlSaving
            // 
            this.tabControlSaving.Controls.Add(this.tabPageMainParameters);
            this.tabControlSaving.Controls.Add(this.tabPageManagement);
            this.tabControlSaving.Controls.Add(this.tabPageTransactions);
            resources.ApplyResources(this.tabControlSaving, "tabControlSaving");
            this.tabControlSaving.Name = "tabControlSaving";
            this.tabControlSaving.SelectedIndex = 0;
            // 
            // tabPageMainParameters
            // 
            this.tabPageMainParameters.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPageMainParameters, "tabPageMainParameters");
            this.tabPageMainParameters.Name = "tabPageMainParameters";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gtOverdraftFees);
            this.groupBox1.Controls.Add(this.gbFrequency);
            this.groupBox1.Controls.Add(this.gbInterestRate);
            this.groupBox1.Controls.Add(this.groupBoxCurrency);
            this.groupBox1.Controls.Add(this.lbCodeSavingProduct);
            this.groupBox1.Controls.Add(this.lbNameSavingProduct);
            this.groupBox1.Controls.Add(this.gbClientType);
            this.groupBox1.Controls.Add(this.tbCodeCurrentAccountProduct);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.gbInitialAmount);
            this.groupBox1.Controls.Add(this.gbBalance);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // gtOverdraftFees
            // 
            this.gtOverdraftFees.Controls.Add(this.tbOverdraftLimit);
            this.gtOverdraftFees.Controls.Add(this.label1);
            this.gtOverdraftFees.Controls.Add(this.rbRateOverdraftFees);
            this.gtOverdraftFees.Controls.Add(this.rbFlatOverdraftFees);
            this.gtOverdraftFees.Controls.Add(this.lbOverdraftFeesType);
            this.gtOverdraftFees.Controls.Add(this.tbOverdraftFees);
            this.gtOverdraftFees.Controls.Add(this.lbOverdraftFeesValue);
            this.gtOverdraftFees.Controls.Add(this.tbOverdraftFeesMax);
            this.gtOverdraftFees.Controls.Add(this.tbOverdraftFeesMin);
            this.gtOverdraftFees.Controls.Add(this.lbOverdraftFeesMax);
            this.gtOverdraftFees.Controls.Add(this.lbOverdraftFeesMin);
            resources.ApplyResources(this.gtOverdraftFees, "gtOverdraftFees");
            this.gtOverdraftFees.Name = "gtOverdraftFees";
            this.gtOverdraftFees.TabStop = false;
            // 
            // tbOverdraftLimit
            // 
            resources.ApplyResources(this.tbOverdraftLimit, "tbOverdraftLimit");
            this.tbOverdraftLimit.Name = "tbOverdraftLimit";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rbRateOverdraftFees
            // 
            resources.ApplyResources(this.rbRateOverdraftFees, "rbRateOverdraftFees");
            this.rbRateOverdraftFees.Name = "rbRateOverdraftFees";
            // 
            // rbFlatOverdraftFees
            // 
            resources.ApplyResources(this.rbFlatOverdraftFees, "rbFlatOverdraftFees");
            this.rbFlatOverdraftFees.Checked = true;
            this.rbFlatOverdraftFees.Name = "rbFlatOverdraftFees";
            this.rbFlatOverdraftFees.TabStop = true;
            // 
            // lbOverdraftFeesType
            // 
            resources.ApplyResources(this.lbOverdraftFeesType, "lbOverdraftFeesType");
            this.lbOverdraftFeesType.Name = "lbOverdraftFeesType";
            // 
            // tbOverdraftFees
            // 
            resources.ApplyResources(this.tbOverdraftFees, "tbOverdraftFees");
            this.tbOverdraftFees.Name = "tbOverdraftFees";
            // 
            // lbOverdraftFeesValue
            // 
            resources.ApplyResources(this.lbOverdraftFeesValue, "lbOverdraftFeesValue");
            this.lbOverdraftFeesValue.Name = "lbOverdraftFeesValue";
            // 
            // tbOverdraftFeesMax
            // 
            resources.ApplyResources(this.tbOverdraftFeesMax, "tbOverdraftFeesMax");
            this.tbOverdraftFeesMax.Name = "tbOverdraftFeesMax";
            // 
            // tbOverdraftFeesMin
            // 
            resources.ApplyResources(this.tbOverdraftFeesMin, "tbOverdraftFeesMin");
            this.tbOverdraftFeesMin.Name = "tbOverdraftFeesMin";
            // 
            // lbOverdraftFeesMax
            // 
            resources.ApplyResources(this.lbOverdraftFeesMax, "lbOverdraftFeesMax");
            this.lbOverdraftFeesMax.Name = "lbOverdraftFeesMax";
            // 
            // lbOverdraftFeesMin
            // 
            resources.ApplyResources(this.lbOverdraftFeesMin, "lbOverdraftFeesMin");
            this.lbOverdraftFeesMin.Name = "lbOverdraftFeesMin";
            // 
            // gbFrequency
            // 
            this.gbFrequency.Controls.Add(this.lbAccrual);
            this.gbFrequency.Controls.Add(this.cbInterestCalculationFrequency);
            resources.ApplyResources(this.gbFrequency, "gbFrequency");
            this.gbFrequency.Name = "gbFrequency";
            this.gbFrequency.TabStop = false;
            // 
            // lbAccrual
            // 
            resources.ApplyResources(this.lbAccrual, "lbAccrual");
            this.lbAccrual.Name = "lbAccrual";
            // 
            // cbInterestCalculationFrequency
            // 
            this.cbInterestCalculationFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbInterestCalculationFrequency, "cbInterestCalculationFrequency");
            this.cbInterestCalculationFrequency.FormattingEnabled = true;
            this.cbInterestCalculationFrequency.Name = "cbInterestCalculationFrequency";
            // 
            // gbInterestRate
            // 
            this.gbInterestRate.Controls.Add(this.lbYearlyInterestRateMax);
            this.gbInterestRate.Controls.Add(this.lbYearlyInterestRateMin);
            this.gbInterestRate.Controls.Add(this.tbInterestRateMax);
            this.gbInterestRate.Controls.Add(this.tbInterestRateMin);
            this.gbInterestRate.Controls.Add(this.lbInterestRateMax);
            this.gbInterestRate.Controls.Add(this.lbInterestRateMin);
            resources.ApplyResources(this.gbInterestRate, "gbInterestRate");
            this.gbInterestRate.Name = "gbInterestRate";
            this.gbInterestRate.TabStop = false;
            // 
            // lbYearlyInterestRateMax
            // 
            resources.ApplyResources(this.lbYearlyInterestRateMax, "lbYearlyInterestRateMax");
            this.lbYearlyInterestRateMax.Name = "lbYearlyInterestRateMax";
            // 
            // lbYearlyInterestRateMin
            // 
            resources.ApplyResources(this.lbYearlyInterestRateMin, "lbYearlyInterestRateMin");
            this.lbYearlyInterestRateMin.Name = "lbYearlyInterestRateMin";
            // 
            // tbInterestRateMax
            // 
            resources.ApplyResources(this.tbInterestRateMax, "tbInterestRateMax");
            this.tbInterestRateMax.Name = "tbInterestRateMax";
            // 
            // tbInterestRateMin
            // 
            resources.ApplyResources(this.tbInterestRateMin, "tbInterestRateMin");
            this.tbInterestRateMin.Name = "tbInterestRateMin";
            // 
            // lbInterestRateMax
            // 
            resources.ApplyResources(this.lbInterestRateMax, "lbInterestRateMax");
            this.lbInterestRateMax.Name = "lbInterestRateMax";
            // 
            // lbInterestRateMin
            // 
            resources.ApplyResources(this.lbInterestRateMin, "lbInterestRateMin");
            this.lbInterestRateMin.Name = "lbInterestRateMin";
            // 
            // groupBoxCurrency
            // 
            this.groupBoxCurrency.Controls.Add(this.cbCurrency);
            resources.ApplyResources(this.groupBoxCurrency, "groupBoxCurrency");
            this.groupBoxCurrency.Name = "groupBoxCurrency";
            this.groupBoxCurrency.TabStop = false;
            // 
            // cbCurrency
            // 
            this.cbCurrency.DisplayMember = "Currency.Name";
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCurrency, "cbCurrency");
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Name = "cbCurrency";
            // 
            // lbCodeSavingProduct
            // 
            resources.ApplyResources(this.lbCodeSavingProduct, "lbCodeSavingProduct");
            this.lbCodeSavingProduct.Name = "lbCodeSavingProduct";
            // 
            // lbNameSavingProduct
            // 
            resources.ApplyResources(this.lbNameSavingProduct, "lbNameSavingProduct");
            this.lbNameSavingProduct.Name = "lbNameSavingProduct";
            // 
            // gbClientType
            // 
            this.gbClientType.Controls.Add(this.clientTypeCorpCheckBox);
            this.gbClientType.Controls.Add(this.clientTypeIndivCheckBox);
            this.gbClientType.Controls.Add(this.clientTypeVillageCheckBox);
            this.gbClientType.Controls.Add(this.clientTypeGroupCheckBox);
            this.gbClientType.Controls.Add(this.clientTypeAllCheckBox);
            resources.ApplyResources(this.gbClientType, "gbClientType");
            this.gbClientType.Name = "gbClientType";
            this.gbClientType.TabStop = false;
            // 
            // clientTypeCorpCheckBox
            // 
            resources.ApplyResources(this.clientTypeCorpCheckBox, "clientTypeCorpCheckBox");
            this.clientTypeCorpCheckBox.Name = "clientTypeCorpCheckBox";
            // 
            // clientTypeIndivCheckBox
            // 
            resources.ApplyResources(this.clientTypeIndivCheckBox, "clientTypeIndivCheckBox");
            this.clientTypeIndivCheckBox.Name = "clientTypeIndivCheckBox";
            // 
            // clientTypeVillageCheckBox
            // 
            resources.ApplyResources(this.clientTypeVillageCheckBox, "clientTypeVillageCheckBox");
            this.clientTypeVillageCheckBox.Name = "clientTypeVillageCheckBox";
            // 
            // clientTypeGroupCheckBox
            // 
            resources.ApplyResources(this.clientTypeGroupCheckBox, "clientTypeGroupCheckBox");
            this.clientTypeGroupCheckBox.Name = "clientTypeGroupCheckBox";
            // 
            // clientTypeAllCheckBox
            // 
            resources.ApplyResources(this.clientTypeAllCheckBox, "clientTypeAllCheckBox");
            this.clientTypeAllCheckBox.Name = "clientTypeAllCheckBox";
            this.clientTypeAllCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeAllCheckBox_CheckedChanged);
            // 
            // tbCodeCurrentAccountProduct
            // 
            resources.ApplyResources(this.tbCodeCurrentAccountProduct, "tbCodeCurrentAccountProduct");
            this.tbCodeCurrentAccountProduct.Name = "tbCodeCurrentAccountProduct";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // gbInitialAmount
            // 
            this.gbInitialAmount.Controls.Add(this.tbInitialAmountMax);
            this.gbInitialAmount.Controls.Add(this.tbInitialAmountMin);
            this.gbInitialAmount.Controls.Add(this.lbInitialAmonutMax);
            this.gbInitialAmount.Controls.Add(this.lbInitialAmountMin);
            resources.ApplyResources(this.gbInitialAmount, "gbInitialAmount");
            this.gbInitialAmount.Name = "gbInitialAmount";
            this.gbInitialAmount.TabStop = false;
            // 
            // tbInitialAmountMax
            // 
            resources.ApplyResources(this.tbInitialAmountMax, "tbInitialAmountMax");
            this.tbInitialAmountMax.Name = "tbInitialAmountMax";
            // 
            // tbInitialAmountMin
            // 
            resources.ApplyResources(this.tbInitialAmountMin, "tbInitialAmountMin");
            this.tbInitialAmountMin.Name = "tbInitialAmountMin";
            // 
            // lbInitialAmonutMax
            // 
            resources.ApplyResources(this.lbInitialAmonutMax, "lbInitialAmonutMax");
            this.lbInitialAmonutMax.Name = "lbInitialAmonutMax";
            // 
            // lbInitialAmountMin
            // 
            resources.ApplyResources(this.lbInitialAmountMin, "lbInitialAmountMin");
            this.lbInitialAmountMin.Name = "lbInitialAmountMin";
            // 
            // gbBalance
            // 
            this.gbBalance.Controls.Add(this.tbBalanceMax);
            this.gbBalance.Controls.Add(this.tbBalanceMin);
            this.gbBalance.Controls.Add(this.lbBalanceMax);
            this.gbBalance.Controls.Add(this.lbBalanceMin);
            resources.ApplyResources(this.gbBalance, "gbBalance");
            this.gbBalance.Name = "gbBalance";
            this.gbBalance.TabStop = false;
            // 
            // tbBalanceMax
            // 
            resources.ApplyResources(this.tbBalanceMax, "tbBalanceMax");
            this.tbBalanceMax.Name = "tbBalanceMax";
            // 
            // tbBalanceMin
            // 
            resources.ApplyResources(this.tbBalanceMin, "tbBalanceMin");
            this.tbBalanceMin.Name = "tbBalanceMin";
            // 
            // lbBalanceMax
            // 
            resources.ApplyResources(this.lbBalanceMax, "lbBalanceMax");
            this.lbBalanceMax.Name = "lbBalanceMax";
            // 
            // lbBalanceMin
            // 
            resources.ApplyResources(this.lbBalanceMin, "lbBalanceMin");
            this.lbBalanceMin.Name = "lbBalanceMin";
            // 
            // tabPageManagement
            // 
            this.tabPageManagement.Controls.Add(this.gbReopenFees);
            this.tabPageManagement.Controls.Add(this.gtManagementFees);
            this.tabPageManagement.Controls.Add(this.gtCloseFees);
            this.tabPageManagement.Controls.Add(this.gbEntryFees);
            resources.ApplyResources(this.tabPageManagement, "tabPageManagement");
            this.tabPageManagement.Name = "tabPageManagement";
            // 
            // gbReopenFees
            // 
            this.gbReopenFees.Controls.Add(this.rbRateReopenFees);
            this.gbReopenFees.Controls.Add(this.rbFlatReopenFees);
            this.gbReopenFees.Controls.Add(this.lbReopenFeesType);
            this.gbReopenFees.Controls.Add(this.tbReopenFees);
            this.gbReopenFees.Controls.Add(this.lbReopenFeesValue);
            this.gbReopenFees.Controls.Add(this.tbReopenFeesMax);
            this.gbReopenFees.Controls.Add(this.tbReopenFeesMin);
            this.gbReopenFees.Controls.Add(this.lbReopenFeesMax);
            this.gbReopenFees.Controls.Add(this.lbReopenFeesMin);
            resources.ApplyResources(this.gbReopenFees, "gbReopenFees");
            this.gbReopenFees.Name = "gbReopenFees";
            this.gbReopenFees.TabStop = false;
            // 
            // rbRateReopenFees
            // 
            resources.ApplyResources(this.rbRateReopenFees, "rbRateReopenFees");
            this.rbRateReopenFees.Name = "rbRateReopenFees";
            // 
            // rbFlatReopenFees
            // 
            resources.ApplyResources(this.rbFlatReopenFees, "rbFlatReopenFees");
            this.rbFlatReopenFees.Checked = true;
            this.rbFlatReopenFees.Name = "rbFlatReopenFees";
            this.rbFlatReopenFees.TabStop = true;
            // 
            // lbReopenFeesType
            // 
            resources.ApplyResources(this.lbReopenFeesType, "lbReopenFeesType");
            this.lbReopenFeesType.Name = "lbReopenFeesType";
            // 
            // tbReopenFees
            // 
            resources.ApplyResources(this.tbReopenFees, "tbReopenFees");
            this.tbReopenFees.Name = "tbReopenFees";
            // 
            // lbReopenFeesValue
            // 
            resources.ApplyResources(this.lbReopenFeesValue, "lbReopenFeesValue");
            this.lbReopenFeesValue.Name = "lbReopenFeesValue";
            // 
            // tbReopenFeesMax
            // 
            resources.ApplyResources(this.tbReopenFeesMax, "tbReopenFeesMax");
            this.tbReopenFeesMax.Name = "tbReopenFeesMax";
            // 
            // tbReopenFeesMin
            // 
            resources.ApplyResources(this.tbReopenFeesMin, "tbReopenFeesMin");
            this.tbReopenFeesMin.Name = "tbReopenFeesMin";
            // 
            // lbReopenFeesMax
            // 
            resources.ApplyResources(this.lbReopenFeesMax, "lbReopenFeesMax");
            this.lbReopenFeesMax.Name = "lbReopenFeesMax";
            // 
            // lbReopenFeesMin
            // 
            resources.ApplyResources(this.lbReopenFeesMin, "lbReopenFeesMin");
            this.lbReopenFeesMin.Name = "lbReopenFeesMin";
            // 
            // gtManagementFees
            // 
            this.gtManagementFees.Controls.Add(this.cbManagementFeeFreq);
            this.gtManagementFees.Controls.Add(this.rbRateManagementFees);
            this.gtManagementFees.Controls.Add(this.rbFlatManagementFees);
            this.gtManagementFees.Controls.Add(this.lbManagementFeesType);
            this.gtManagementFees.Controls.Add(this.tbManagementFees);
            this.gtManagementFees.Controls.Add(this.lbManagementFees);
            this.gtManagementFees.Controls.Add(this.tbManagementFeesMax);
            this.gtManagementFees.Controls.Add(this.tbManagementFeesMin);
            this.gtManagementFees.Controls.Add(this.lbManagementFeesMax);
            this.gtManagementFees.Controls.Add(this.lbManagementFeesMin);
            resources.ApplyResources(this.gtManagementFees, "gtManagementFees");
            this.gtManagementFees.Name = "gtManagementFees";
            this.gtManagementFees.TabStop = false;
            // 
            // cbManagementFeeFreq
            // 
            this.cbManagementFeeFreq.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cbManagementFeeFreq.AutoCompleteCustomSource"),
            resources.GetString("cbManagementFeeFreq.AutoCompleteCustomSource1"),
            resources.GetString("cbManagementFeeFreq.AutoCompleteCustomSource2"),
            resources.GetString("cbManagementFeeFreq.AutoCompleteCustomSource3")});
            this.cbManagementFeeFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbManagementFeeFreq, "cbManagementFeeFreq");
            this.cbManagementFeeFreq.FormattingEnabled = true;
            this.cbManagementFeeFreq.Items.AddRange(new object[] {
            resources.GetString("cbManagementFeeFreq.Items"),
            resources.GetString("cbManagementFeeFreq.Items1"),
            resources.GetString("cbManagementFeeFreq.Items2"),
            resources.GetString("cbManagementFeeFreq.Items3")});
            this.cbManagementFeeFreq.Name = "cbManagementFeeFreq";
            // 
            // rbRateManagementFees
            // 
            resources.ApplyResources(this.rbRateManagementFees, "rbRateManagementFees");
            this.rbRateManagementFees.Name = "rbRateManagementFees";
            // 
            // rbFlatManagementFees
            // 
            resources.ApplyResources(this.rbFlatManagementFees, "rbFlatManagementFees");
            this.rbFlatManagementFees.Checked = true;
            this.rbFlatManagementFees.Name = "rbFlatManagementFees";
            this.rbFlatManagementFees.TabStop = true;
            // 
            // lbManagementFeesType
            // 
            resources.ApplyResources(this.lbManagementFeesType, "lbManagementFeesType");
            this.lbManagementFeesType.Name = "lbManagementFeesType";
            // 
            // tbManagementFees
            // 
            resources.ApplyResources(this.tbManagementFees, "tbManagementFees");
            this.tbManagementFees.Name = "tbManagementFees";
            // 
            // lbManagementFees
            // 
            resources.ApplyResources(this.lbManagementFees, "lbManagementFees");
            this.lbManagementFees.Name = "lbManagementFees";
            // 
            // tbManagementFeesMax
            // 
            resources.ApplyResources(this.tbManagementFeesMax, "tbManagementFeesMax");
            this.tbManagementFeesMax.Name = "tbManagementFeesMax";
            // 
            // tbManagementFeesMin
            // 
            resources.ApplyResources(this.tbManagementFeesMin, "tbManagementFeesMin");
            this.tbManagementFeesMin.Name = "tbManagementFeesMin";
            // 
            // lbManagementFeesMax
            // 
            resources.ApplyResources(this.lbManagementFeesMax, "lbManagementFeesMax");
            this.lbManagementFeesMax.Name = "lbManagementFeesMax";
            // 
            // lbManagementFeesMin
            // 
            resources.ApplyResources(this.lbManagementFeesMin, "lbManagementFeesMin");
            this.lbManagementFeesMin.Name = "lbManagementFeesMin";
            // 
            // gtCloseFees
            // 
            this.gtCloseFees.Controls.Add(this.rbRateCloseFees);
            this.gtCloseFees.Controls.Add(this.rbFlatCloseFees);
            this.gtCloseFees.Controls.Add(this.lbCloseFeesType);
            this.gtCloseFees.Controls.Add(this.tbCloseFees);
            this.gtCloseFees.Controls.Add(this.lbCloseFees);
            this.gtCloseFees.Controls.Add(this.tbCloseFeesMax);
            this.gtCloseFees.Controls.Add(this.tbCloseFeesMin);
            this.gtCloseFees.Controls.Add(this.lbCloseFeesMax);
            this.gtCloseFees.Controls.Add(this.lbCloseFeesMin);
            resources.ApplyResources(this.gtCloseFees, "gtCloseFees");
            this.gtCloseFees.Name = "gtCloseFees";
            this.gtCloseFees.TabStop = false;
            // 
            // rbRateCloseFees
            // 
            resources.ApplyResources(this.rbRateCloseFees, "rbRateCloseFees");
            this.rbRateCloseFees.Name = "rbRateCloseFees";
            // 
            // rbFlatCloseFees
            // 
            resources.ApplyResources(this.rbFlatCloseFees, "rbFlatCloseFees");
            this.rbFlatCloseFees.Checked = true;
            this.rbFlatCloseFees.Name = "rbFlatCloseFees";
            this.rbFlatCloseFees.TabStop = true;
            // 
            // lbCloseFeesType
            // 
            resources.ApplyResources(this.lbCloseFeesType, "lbCloseFeesType");
            this.lbCloseFeesType.Name = "lbCloseFeesType";
            // 
            // tbCloseFees
            // 
            resources.ApplyResources(this.tbCloseFees, "tbCloseFees");
            this.tbCloseFees.Name = "tbCloseFees";
            // 
            // lbCloseFees
            // 
            resources.ApplyResources(this.lbCloseFees, "lbCloseFees");
            this.lbCloseFees.Name = "lbCloseFees";
            // 
            // tbCloseFeesMax
            // 
            resources.ApplyResources(this.tbCloseFeesMax, "tbCloseFeesMax");
            this.tbCloseFeesMax.Name = "tbCloseFeesMax";
            // 
            // tbCloseFeesMin
            // 
            resources.ApplyResources(this.tbCloseFeesMin, "tbCloseFeesMin");
            this.tbCloseFeesMin.Name = "tbCloseFeesMin";
            // 
            // lbCloseFeesMax
            // 
            resources.ApplyResources(this.lbCloseFeesMax, "lbCloseFeesMax");
            this.lbCloseFeesMax.Name = "lbCloseFeesMax";
            // 
            // lbCloseFeesMin
            // 
            resources.ApplyResources(this.lbCloseFeesMin, "lbCloseFeesMin");
            this.lbCloseFeesMin.Name = "lbCloseFeesMin";
            // 
            // gbEntryFees
            // 
            this.gbEntryFees.Controls.Add(this.rbRateEntryFees);
            this.gbEntryFees.Controls.Add(this.rbFlatEntryFees);
            this.gbEntryFees.Controls.Add(this.lbEntryFeesType);
            this.gbEntryFees.Controls.Add(this.tbEntryFees);
            this.gbEntryFees.Controls.Add(this.lbEntryFeesValue);
            this.gbEntryFees.Controls.Add(this.tbEntryFeesMax);
            this.gbEntryFees.Controls.Add(this.tbEntryFeesMin);
            this.gbEntryFees.Controls.Add(this.lbEntryFeesMax);
            this.gbEntryFees.Controls.Add(this.lbEntryFeesMin);
            resources.ApplyResources(this.gbEntryFees, "gbEntryFees");
            this.gbEntryFees.Name = "gbEntryFees";
            this.gbEntryFees.TabStop = false;
            // 
            // rbRateEntryFees
            // 
            resources.ApplyResources(this.rbRateEntryFees, "rbRateEntryFees");
            this.rbRateEntryFees.Name = "rbRateEntryFees";
            // 
            // rbFlatEntryFees
            // 
            resources.ApplyResources(this.rbFlatEntryFees, "rbFlatEntryFees");
            this.rbFlatEntryFees.Checked = true;
            this.rbFlatEntryFees.Name = "rbFlatEntryFees";
            this.rbFlatEntryFees.TabStop = true;
            // 
            // lbEntryFeesType
            // 
            resources.ApplyResources(this.lbEntryFeesType, "lbEntryFeesType");
            this.lbEntryFeesType.Name = "lbEntryFeesType";
            // 
            // tbEntryFees
            // 
            resources.ApplyResources(this.tbEntryFees, "tbEntryFees");
            this.tbEntryFees.Name = "tbEntryFees";
            // 
            // lbEntryFeesValue
            // 
            resources.ApplyResources(this.lbEntryFeesValue, "lbEntryFeesValue");
            this.lbEntryFeesValue.Name = "lbEntryFeesValue";
            // 
            // tbEntryFeesMax
            // 
            resources.ApplyResources(this.tbEntryFeesMax, "tbEntryFeesMax");
            this.tbEntryFeesMax.Name = "tbEntryFeesMax";
            // 
            // tbEntryFeesMin
            // 
            resources.ApplyResources(this.tbEntryFeesMin, "tbEntryFeesMin");
            this.tbEntryFeesMin.Name = "tbEntryFeesMin";
            // 
            // lbEntryFeesMax
            // 
            resources.ApplyResources(this.lbEntryFeesMax, "lbEntryFeesMax");
            this.lbEntryFeesMax.Name = "lbEntryFeesMax";
            // 
            // lbEntryFeesMin
            // 
            resources.ApplyResources(this.lbEntryFeesMin, "lbEntryFeesMin");
            this.lbEntryFeesMin.Name = "lbEntryFeesMin";
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.button1);
            this.tabPageTransactions.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPageTransactions, "tabPageTransactions");
            this.tabPageTransactions.Name = "tabPageTransactions";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Checked = true;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnCurrentAccountProduct);
            this.groupBox2.Controls.Add(this.bClose);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmAddCurrentAccountProduct
            // 
            this.AcceptButton = this.btnCurrentAccountProduct;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddCurrentAccountProduct";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlSaving.ResumeLayout(false);
            this.tabPageMainParameters.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gtOverdraftFees.ResumeLayout(false);
            this.gtOverdraftFees.PerformLayout();
            this.gbFrequency.ResumeLayout(false);
            this.gbFrequency.PerformLayout();
            this.gbInterestRate.ResumeLayout(false);
            this.gbInterestRate.PerformLayout();
            this.groupBoxCurrency.ResumeLayout(false);
            this.gbClientType.ResumeLayout(false);
            this.gbClientType.PerformLayout();
            this.gbInitialAmount.ResumeLayout(false);
            this.gbInitialAmount.PerformLayout();
            this.gbBalance.ResumeLayout(false);
            this.gbBalance.PerformLayout();
            this.tabPageManagement.ResumeLayout(false);
            this.gbReopenFees.ResumeLayout(false);
            this.gbReopenFees.PerformLayout();
            this.gtManagementFees.ResumeLayout(false);
            this.gtManagementFees.PerformLayout();
            this.gtCloseFees.ResumeLayout(false);
            this.gtCloseFees.PerformLayout();
            this.gbEntryFees.ResumeLayout(false);
            this.gbEntryFees.PerformLayout();
            this.tabPageTransactions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNameSavingProduct;
        private System.Windows.Forms.GroupBox gbClientType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbInitialAmount;
        private System.Windows.Forms.GroupBox gbBalance;
        private System.Windows.Forms.TextBox tbInitialAmountMax;
        private System.Windows.Forms.TextBox tbInitialAmountMin;
        private System.Windows.Forms.Label lbInitialAmonutMax;
        private System.Windows.Forms.Label lbInitialAmountMin;
        private System.Windows.Forms.TextBox tbBalanceMax;
        private System.Windows.Forms.TextBox tbBalanceMin;
        private System.Windows.Forms.Label lbBalanceMax;
        private System.Windows.Forms.Label lbBalanceMin;
        private System.Windows.Forms.Button btnCurrentAccountProduct;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxCurrency;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.TabControl tabControlSaving;
        private System.Windows.Forms.TabPage tabPageMainParameters;
        private System.Windows.Forms.Label lbCodeSavingProduct;
        private System.Windows.Forms.TextBox tbCodeCurrentAccountProduct;
        private System.Windows.Forms.TabPage tabPageManagement;
        private System.Windows.Forms.GroupBox gbEntryFees;
        private System.Windows.Forms.TextBox tbEntryFees;
        private System.Windows.Forms.Label lbEntryFeesValue;
        private System.Windows.Forms.TextBox tbEntryFeesMax;
        private System.Windows.Forms.TextBox tbEntryFeesMin;
        private System.Windows.Forms.Label lbEntryFeesMax;
        private System.Windows.Forms.Label lbEntryFeesMin;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private System.Windows.Forms.GroupBox gtCloseFees;
        private System.Windows.Forms.TextBox tbCloseFees;
        private System.Windows.Forms.Label lbCloseFees;
        private System.Windows.Forms.TextBox tbCloseFeesMax;
        private System.Windows.Forms.TextBox tbCloseFeesMin;
        private System.Windows.Forms.Label lbCloseFeesMax;
        private System.Windows.Forms.Label lbCloseFeesMin;
        private System.Windows.Forms.RadioButton rbRateCloseFees;
        private System.Windows.Forms.RadioButton rbFlatCloseFees;
        private System.Windows.Forms.Label lbCloseFeesType;
        private System.Windows.Forms.RadioButton rbRateEntryFees;
        private System.Windows.Forms.RadioButton rbFlatEntryFees;
        private System.Windows.Forms.Label lbEntryFeesType;
        private System.Windows.Forms.GroupBox gtManagementFees;
        private System.Windows.Forms.RadioButton rbRateManagementFees;
        private System.Windows.Forms.RadioButton rbFlatManagementFees;
        private System.Windows.Forms.Label lbManagementFeesType;
        private System.Windows.Forms.TextBox tbManagementFees;
        private System.Windows.Forms.Label lbManagementFees;
        private System.Windows.Forms.TextBox tbManagementFeesMax;
        private System.Windows.Forms.TextBox tbManagementFeesMin;
        private System.Windows.Forms.Label lbManagementFeesMax;
        private System.Windows.Forms.Label lbManagementFeesMin;
        private System.Windows.Forms.CheckBox clientTypeCorpCheckBox;
        private System.Windows.Forms.CheckBox clientTypeIndivCheckBox;
        private System.Windows.Forms.CheckBox clientTypeGroupCheckBox;
        private System.Windows.Forms.CheckBox clientTypeAllCheckBox;
        private System.Windows.Forms.ComboBox cbManagementFeeFreq;
        private System.Windows.Forms.CheckBox clientTypeVillageCheckBox;
        private System.Windows.Forms.GroupBox gbReopenFees;
        private System.Windows.Forms.RadioButton rbRateReopenFees;
        private System.Windows.Forms.RadioButton rbFlatReopenFees;
        private System.Windows.Forms.Label lbReopenFeesType;
        private System.Windows.Forms.TextBox tbReopenFees;
        private System.Windows.Forms.Label lbReopenFeesValue;
        private System.Windows.Forms.TextBox tbReopenFeesMax;
        private System.Windows.Forms.TextBox tbReopenFeesMin;
        private System.Windows.Forms.Label lbReopenFeesMax;
        private System.Windows.Forms.Label lbReopenFeesMin;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbFrequency;
        private System.Windows.Forms.Label lbAccrual;
        private System.Windows.Forms.ComboBox cbInterestCalculationFrequency;
        private System.Windows.Forms.GroupBox gbInterestRate;
        private System.Windows.Forms.Label lbYearlyInterestRateMax;
        private System.Windows.Forms.Label lbYearlyInterestRateMin;
        private System.Windows.Forms.TextBox tbInterestRateMax;
        private System.Windows.Forms.TextBox tbInterestRateMin;
        private System.Windows.Forms.Label lbInterestRateMax;
        private System.Windows.Forms.Label lbInterestRateMin;
        private System.Windows.Forms.GroupBox gtOverdraftFees;
        private System.Windows.Forms.TextBox tbOverdraftLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRateOverdraftFees;
        private System.Windows.Forms.RadioButton rbFlatOverdraftFees;
        private System.Windows.Forms.Label lbOverdraftFeesType;
        private System.Windows.Forms.TextBox tbOverdraftFees;
        private System.Windows.Forms.Label lbOverdraftFeesValue;
        private System.Windows.Forms.TextBox tbOverdraftFeesMax;
        private System.Windows.Forms.TextBox tbOverdraftFeesMin;
        private System.Windows.Forms.Label lbOverdraftFeesMax;
        private System.Windows.Forms.Label lbOverdraftFeesMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}