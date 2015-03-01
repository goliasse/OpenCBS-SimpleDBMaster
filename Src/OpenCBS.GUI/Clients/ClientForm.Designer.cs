

using System.Globalization;
using System.Windows.Forms;
using OpenCBS.CoreDomain.FundingLines;
using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Clients
{
    public partial class ClientForm
    {
        private TabControl tabControlPerson;
        private TabPage tabPageDetails;
        private TabPage tabPageProject;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxProjectDetails;
        private Label labelProjectName;
        private TextBox textBoxProjectName;
        private Label labelProjectCode;
        private TextBox textBoxProjectCode;
        private Label labelFirstProjectName;
        private TextBox textBoxProjectAim;
        private Panel panel1;
        private System.Windows.Forms.Button buttonProjectSave;
        private System.Windows.Forms.Button buttonProjectViewContract;
        private System.Windows.Forms.Button buttonProjectAddContract;
        private ListView lvContracts;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderAmount;
        private ColumnHeader columnHeaderInterestRate;
        private ColumnHeader columnHeaderInstallmentType;
        private ColumnHeader columnHeaderNbOfInstallments;
        private ColumnHeader columnHeaderCreationDate;
        private ColumnHeader columnHeaderStartDate;
        private ColumnHeader columnHeaderCloseDate;
        private SplitContainer splitContainer3;
        private Panel panelUserControl;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelTitleRepayment;
        private Button buttonPrintSchedule;
        private Button buttonReschedule;
        private Button buttonRepay;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderType;
        private ColumnHeader columnHeaderPrincipal;
        private ColumnHeader columnHeaderInterest;
        private ColumnHeader columnHeaderFees;
        private ColumnHeader columnHeader10;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonLoanDisbursement;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer6;
        private Label labelExchangeRate;
        private TabPage tabPageLoansDetails;
        private GroupBox gbxLoanDetails;
        private ComboBox comboBoxLoanFundingLine;
        private Label lbLoanInterestRateMinMax;
        private Label labelLoanAmountMinMax;
        private ComboBox cmbLoanOfficer;
        private Label labelLoanLoanOfficer;
        private Label labelLoanFundingLine;
        private NumericUpDown numericUpDownLoanGracePeriod;
        private Label labelLoanGracePeriod;
        private Label labelLoanStartDate;
        private DateTimePicker dateLoanStart;
        private Label labelLoanAmount;
        private Label labelLoanInterestRate;
        private Label labelLoanInstallmentType;
        private ComboBox comboBoxLoanInstallmentType;
        private Label labelLoanNbOfInstallments;
        private NumericUpDown nudLoanNbOfInstallments;
        private System.Windows.Forms.Button buttonLoanPreview;
        private System.Windows.Forms.Button btnSaveLoan;
        private System.Windows.Forms.Button buttonLoanDisbursment;
        private ContextMenuStrip contextMenuStripPackage;
        private System.ComponentModel.IContainer components;
        private TabPage tabPageLoanRepayment;
        private Label lblLoanStatus;
        private RichTextBox richTextBoxStatus;
        private ImageList imageListTab;

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.numericUpDownProjectJobs = new System.Windows.Forms.NumericUpDown();
            this.gBProjectFinancialPlan = new System.Windows.Forms.GroupBox();
            this.lProjectFinancialPlanType = new System.Windows.Forms.Label();
            this.lProjectFinancialPlanAmount = new System.Windows.Forms.Label();
            this.tBProjectFinancialPlanTotal = new System.Windows.Forms.TextBox();
            this.tBProjectFinancialPlanAmount = new System.Windows.Forms.TextBox();
            this.cBProjectFinancialPlanType = new System.Windows.Forms.ComboBox();
            this.lProjectFinancialPlanTotalAmount = new System.Windows.Forms.Label();
            this.lProjectNbOfNewJobs = new System.Windows.Forms.Label();
            this.tBProjectCA = new System.Windows.Forms.TextBox();
            this.lProjectCA = new System.Windows.Forms.Label();
            this.lProjectCorporateName = new System.Windows.Forms.Label();
            this.cBProjectAffiliation = new System.Windows.Forms.ComboBox();
            this.cBProjectFiscalStatus = new System.Windows.Forms.ComboBox();
            this.tBProjectCorporateName = new System.Windows.Forms.TextBox();
            this.cBProjectJuridicStatus = new System.Windows.Forms.ComboBox();
            this.lProjectCorporateSIRET = new System.Windows.Forms.Label();
            this.lProjectJuridicStatus = new System.Windows.Forms.Label();
            this.tBProjectCorporateSIRET = new System.Windows.Forms.TextBox();
            this.lProjectAffiliation = new System.Windows.Forms.Label();
            this.lProjectFiscalStatus = new System.Windows.Forms.Label();
            this.gBProjectAddress = new System.Windows.Forms.GroupBox();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.listViewProjectFollowUp = new System.Windows.Forms.ListView();
            this.columnHeaderProjectYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectJobs1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectJobs2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectCA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderprojectPersonalSituation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectActivity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBProjectFollowUp = new System.Windows.Forms.GroupBox();
            this.buttonProjectAddFollowUp = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewGuarantors = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlGuarantorButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSelectAGarantors = new System.Windows.Forms.Button();
            this.buttonModifyAGarantors = new System.Windows.Forms.Button();
            this.buttonViewAGarantors = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.lblCreditCurrency = new System.Windows.Forms.Label();
            this.lblGuarantorsList = new System.Windows.Forms.Label();
            this.listViewCollaterals = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderColDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlCollateralButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddCollateral = new System.Windows.Forms.Button();
            this.buttonModifyCollateral = new System.Windows.Forms.Button();
            this.buttonViewCollateral = new System.Windows.Forms.Button();
            this.buttonDelCollateral = new System.Windows.Forms.Button();
            this.lblCollaterals = new System.Windows.Forms.Label();
            this.splitContainerContracts = new System.Windows.Forms.SplitContainer();
            this.panelLoansContracts = new System.Windows.Forms.Panel();
            this.labelLoansContracts = new System.Windows.Forms.Label();
            this.panelSavingsContracts = new System.Windows.Forms.Panel();
            this.labelSavingsContracts = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.tabControlPerson = new System.Windows.Forms.TabControl();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.tabPageProject = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxProjectDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePickerProjectBeginDate = new System.Windows.Forms.DateTimePicker();
            this.labelProjectDate = new System.Windows.Forms.Label();
            this.buttonProjectSelectPurpose = new System.Windows.Forms.Button();
            this.textBoxProjectPurpose = new System.Windows.Forms.TextBox();
            this.labelProjectPurpose = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectCode = new System.Windows.Forms.Label();
            this.textBoxProjectCode = new System.Windows.Forms.TextBox();
            this.labelFirstProjectName = new System.Windows.Forms.Label();
            this.textBoxProjectAim = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProjectSave = new System.Windows.Forms.Button();
            this.tabControlProject = new System.Windows.Forms.TabControl();
            this.tabPageProjectLoans = new System.Windows.Forms.TabPage();
            this.pnlLoans = new System.Windows.Forms.Panel();
            this.lvContracts = new System.Windows.Forms.ListView();
            this.columnProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOLB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCurrency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInterestRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstallmentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNbOfInstallments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCloseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoanCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonProjectAddContract = new System.Windows.Forms.Button();
            this.buttonProjectViewContract = new System.Windows.Forms.Button();
            this.btnGenerateLoanStatement = new System.Windows.Forms.Button();
            this.btnCurrentChargesNotice = new System.Windows.Forms.Button();
            this.tabPageProjectAnalyses = new System.Windows.Forms.TabPage();
            this.textBoxProjectConcurrence = new System.Windows.Forms.TextBox();
            this.textBoxProjectMarket = new System.Windows.Forms.TextBox();
            this.labelProjectConcurrence = new System.Windows.Forms.Label();
            this.labelProjectMarket = new System.Windows.Forms.Label();
            this.textBoxProjectAbilities = new System.Windows.Forms.TextBox();
            this.textBoxProjectExperience = new System.Windows.Forms.TextBox();
            this.labelProjectExperience = new System.Windows.Forms.Label();
            this.labelProjectAbilities = new System.Windows.Forms.Label();
            this.tabPageCorporate = new System.Windows.Forms.TabPage();
            this.tabPageFollowUp = new System.Windows.Forms.TabPage();
            this.tabPageLoansDetails = new System.Windows.Forms.TabPage();
            this.tclLoanDetails = new System.Windows.Forms.TabControl();
            this.tabPageInstallments = new System.Windows.Forms.TabPage();
            this.listViewLoanInstallments = new OpenCBS.GUI.UserControl.ListViewEx();
            this.columnHeaderLoanN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoanDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoanIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoanPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoanInstallmentTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoanOLB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanDetailsButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveLoan = new System.Windows.Forms.Button();
            this.buttonLoanPreview = new System.Windows.Forms.Button();
            this.buttonLoanDisbursment = new System.Windows.Forms.Button();
            this.btnLoanShares = new System.Windows.Forms.Button();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.gbxLoanDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEconomicActivity = new System.Windows.Forms.Label();
            this.labelDateOffirstInstallment = new System.Windows.Forms.Label();
            this.labelLoanAmountMinMax = new System.Windows.Forms.Label();
            this.labelLoanNbOfInstallmentsMinMax = new System.Windows.Forms.Label();
            this.dtpDateOfFirstInstallment = new System.Windows.Forms.DateTimePicker();
            this.labelLoanGracePeriodMinMax = new System.Windows.Forms.Label();
            this.labelLoanContractCode = new System.Windows.Forms.Label();
            this.textBoxLoanContractCode = new System.Windows.Forms.TextBox();
            this.labelLoanAmount = new System.Windows.Forms.Label();
            this.labelLoanInterestRate = new System.Windows.Forms.Label();
            this.dateLoanStart = new System.Windows.Forms.DateTimePicker();
            this.labelLoanNbOfInstallments = new System.Windows.Forms.Label();
            this.labelLoanStartDate = new System.Windows.Forms.Label();
            this.lbLoanInterestRateMinMax = new System.Windows.Forms.Label();
            this.labelLoanGracePeriod = new System.Windows.Forms.Label();
            this.numericUpDownLoanGracePeriod = new System.Windows.Forms.NumericUpDown();
            this.nudLoanNbOfInstallments = new System.Windows.Forms.NumericUpDown();
            this.lblDay = new System.Windows.Forms.Label();
            this.cmbLoanOfficer = new System.Windows.Forms.ComboBox();
            this.labelLoanLoanOfficer = new System.Windows.Forms.Label();
            this.labelLoanInstallmentType = new System.Windows.Forms.Label();
            this.comboBoxLoanInstallmentType = new System.Windows.Forms.ComboBox();
            this.labelLoanFundingLine = new System.Windows.Forms.Label();
            this.comboBoxLoanFundingLine = new System.Windows.Forms.ComboBox();
            this.labelLoanPurpose = new System.Windows.Forms.Label();
            this.textBoxLoanPurpose = new System.Windows.Forms.TextBox();
            this.nudLoanAmount = new System.Windows.Forms.NumericUpDown();
            this.nudInterestRate = new System.Windows.Forms.NumericUpDown();
            this.rbAmortisationSchedule = new System.Windows.Forms.RadioButton();
            this.rbStraightSchedule = new System.Windows.Forms.RadioButton();
            this.tabPageAdvancedSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxAnticipatedRepaymentPenalties = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEarlyPartialRepaimentBase = new System.Windows.Forms.Label();
            this.lblEarlyTotalRepaimentBase = new System.Windows.Forms.Label();
            this.lblLoanAnticipatedPartialFeesMinMax = new System.Windows.Forms.Label();
            this.lbATR = new System.Windows.Forms.Label();
            this.tbLoanAnticipatedPartialFees = new System.Windows.Forms.TextBox();
            this.textBoxLoanAnticipatedTotalFees = new System.Windows.Forms.TextBox();
            this.lbAPR = new System.Windows.Forms.Label();
            this.labelLoanAnticipatedTotalFeesMinMax = new System.Windows.Forms.Label();
            this.groupBoxLoanLateFees = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLoanLateFeesOnOverduePrincipalMinMax = new System.Windows.Forms.Label();
            this.labelLoanLateFeesOnAmountMinMax = new System.Windows.Forms.Label();
            this.labelLoanLateFeesOnAmount = new System.Windows.Forms.Label();
            this.textBoxLoanLateFeesOnAmount = new System.Windows.Forms.TextBox();
            this.textBoxLoanLateFeesOnOverduePrincipal = new System.Windows.Forms.TextBox();
            this.labelLoanLateFeesOnOverduePrincipal = new System.Windows.Forms.Label();
            this.labelLoanLateFeesOnOLB = new System.Windows.Forms.Label();
            this.textBoxLoanLateFeesOnOLB = new System.Windows.Forms.TextBox();
            this.labelLoanLateFeesOnOLBMinMax = new System.Windows.Forms.Label();
            this.labelLoanLateFeesOnOverdueInterest = new System.Windows.Forms.Label();
            this.textBoxLoanLateFeesOnOverdueInterest = new System.Windows.Forms.TextBox();
            this.labelLoanLateFeesOnOverdueInterestMinMax = new System.Windows.Forms.Label();
            this.groupBoxEntryFees = new System.Windows.Forms.GroupBox();
            this.lvEntryFees = new OpenCBS.GUI.UserControl.ListViewEx();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMinMaxEntryFees = new System.Windows.Forms.Label();
            this.numEntryFees = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCompulsorySavingsAmount = new System.Windows.Forms.Label();
            this.lbCompulsorySavings = new System.Windows.Forms.Label();
            this.numCompulsoryAmountPercent = new System.Windows.Forms.NumericUpDown();
            this.cmbCompulsorySaving = new System.Windows.Forms.ComboBox();
            this.linkCompulsorySavings = new System.Windows.Forms.LinkLabel();
            this.lbCompAmountPercentMinMax = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLocAmount = new System.Windows.Forms.Label();
            this.tbLocAmount = new System.Windows.Forms.TextBox();
            this.labelLocMin = new System.Windows.Forms.Label();
            this.labelLocMax = new System.Windows.Forms.Label();
            this.labelLocMinAmount = new System.Windows.Forms.Label();
            this.labelLocMaxAmount = new System.Windows.Forms.Label();
            this.lblInsuranceMin = new System.Windows.Forms.Label();
            this.lblInsuranceMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInsurance = new System.Windows.Forms.TextBox();
            this.lblCreditInsurance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLocCurrencyMin = new System.Windows.Forms.Label();
            this.lblLocCurrencyMax = new System.Windows.Forms.Label();
            this.tabPageCreditCommitee = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCreditCommiteeSaveDecision = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCCStatus = new System.Windows.Forms.Label();
            this.pnlCCStatus = new System.Windows.Forms.Panel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbContractStatus = new System.Windows.Forms.ComboBox();
            this.labelCreditCommiteeDate = new System.Windows.Forms.Label();
            this.dateTimePickerCreditCommitee = new System.Windows.Forms.DateTimePicker();
            this.labelCreditCommiteeComment = new System.Windows.Forms.Label();
            this.labelCreditCommiteeCode = new System.Windows.Forms.Label();
            this.textBoxCreditCommiteeComment = new System.Windows.Forms.TextBox();
            this.tBCreditCommitteeCode = new System.Windows.Forms.TextBox();
            this.tabPageLoanRepayment = new System.Windows.Forms.TabPage();
            this.tabControlRepayments = new System.Windows.Forms.TabControl();
            this.tabPageRepayments = new System.Windows.Forms.TabPage();
            this.lvLoansRepayments = new OpenCBS.GUI.UserControl.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLateDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoanRepaymentRepay = new System.Windows.Forms.Button();
            this.buttonLoanReschedule = new System.Windows.Forms.Button();
            this.buttonManualSchedule = new System.Windows.Forms.Button();
            this.buttonAddTranche = new System.Windows.Forms.Button();
            this.btnWriteOff = new System.Windows.Forms.Button();
            this.btnRepaymentNotice = new System.Windows.Forms.Button();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.lvEvents = new OpenCBS.GUI.UserControl.ListViewEx();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommissions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPenalties = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOverduePrincipal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOverdueDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExportedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaymentMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCancelDate1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsDeleted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWaiveFee = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.lblLoanStatus = new System.Windows.Forms.Label();
            this.tabPageLoanGuarantees = new System.Windows.Forms.TabPage();
            this.tabPageSavingDetails = new System.Windows.Forms.TabPage();
            this.tabControlSavingsDetails = new System.Windows.Forms.TabControl();
            this.tabPageSavingsAmountsAndFees = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxSavingBalance = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.lbBalanceMaxValue = new System.Windows.Forms.Label();
            this.lbBalanceMin = new System.Windows.Forms.Label();
            this.lbBalanceMinValue = new System.Windows.Forms.Label();
            this.lbBalanceMax = new System.Windows.Forms.Label();
            this.groupBoxSavingDeposit = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDepositMaxValue = new System.Windows.Forms.Label();
            this.lbDepositMin = new System.Windows.Forms.Label();
            this.lbDepositMinValue = new System.Windows.Forms.Label();
            this.lbDepositmax = new System.Windows.Forms.Label();
            this.groupBoxSavingWithdraw = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.lbWithdrawMaxValue = new System.Windows.Forms.Label();
            this.lbWithdrawMin = new System.Windows.Forms.Label();
            this.lbWithdrawMinValue = new System.Windows.Forms.Label();
            this.lbWithdrawMax = new System.Windows.Forms.Label();
            this.groupBoxSavingTransfer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSavingTransferMaxValue = new System.Windows.Forms.Label();
            this.labelSavingTransferMin = new System.Windows.Forms.Label();
            this.labelSavingTransferMinValue = new System.Windows.Forms.Label();
            this.labelSavingTransferMax = new System.Windows.Forms.Label();
            this.gbInterest = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.lbInterestBasedOnValue = new System.Windows.Forms.Label();
            this.lbInterestAccrual = new System.Windows.Forms.Label();
            this.lbInterestPostingValue = new System.Windows.Forms.Label();
            this.lbInterestBasedOn = new System.Windows.Forms.Label();
            this.lbInterestAccrualValue = new System.Windows.Forms.Label();
            this.lbInterestPosting = new System.Windows.Forms.Label();
            this.gbDepositInterest = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.lbPeriodicityValue = new System.Windows.Forms.Label();
            this.lbAccrualDeposit = new System.Windows.Forms.Label();
            this.lbAccrualDepositValue = new System.Windows.Forms.Label();
            this.lbPeriodicity = new System.Windows.Forms.Label();
            this.tlpSBDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblIbtFeeMinMax = new System.Windows.Forms.Label();
            this.lbTransferFees = new System.Windows.Forms.Label();
            this.nudIbtFee = new System.Windows.Forms.NumericUpDown();
            this.lbDepositFees = new System.Windows.Forms.Label();
            this.nudTransferFees = new System.Windows.Forms.NumericUpDown();
            this.lbReopenFeesMinMax = new System.Windows.Forms.Label();
            this.lbTransferFeesMinMax = new System.Windows.Forms.Label();
            this.nudReopenFees = new System.Windows.Forms.NumericUpDown();
            this.lbReopenFees = new System.Windows.Forms.Label();
            this.lbDepositFeesMinMax = new System.Windows.Forms.Label();
            this.lbAgioFeesMinMax = new System.Windows.Forms.Label();
            this.lbChequeDepositFees = new System.Windows.Forms.Label();
            this.nudAgioFees = new System.Windows.Forms.NumericUpDown();
            this.nudChequeDepositFees = new System.Windows.Forms.NumericUpDown();
            this.lbAgioFees = new System.Windows.Forms.Label();
            this.lbOverdraftFeesMinMax = new System.Windows.Forms.Label();
            this.lblChequeDepositFeesMinMax = new System.Windows.Forms.Label();
            this.lbCloseFees = new System.Windows.Forms.Label();
            this.nudOverdraftFees = new System.Windows.Forms.NumericUpDown();
            this.nudCloseFees = new System.Windows.Forms.NumericUpDown();
            this.lbOverdraftFees = new System.Windows.Forms.Label();
            this.lbCloseFeesMinMax = new System.Windows.Forms.Label();
            this.lbManagementFeesMinMax = new System.Windows.Forms.Label();
            this.lbManagementFees = new System.Windows.Forms.Label();
            this.nudManagementFees = new System.Windows.Forms.NumericUpDown();
            this.nudDepositFees = new System.Windows.Forms.NumericUpDown();
            this.lblInterBranchTransfer = new System.Windows.Forms.Label();
            this.tabPageSavingsEvents = new System.Windows.Forms.TabPage();
            this.lvSavingEvent = new System.Windows.Forms.ListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCancelDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageLoans = new System.Windows.Forms.TabPage();
            this.olvLoans = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnContractCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnOLB = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCreationDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStratDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCloseDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tpTermDeposit = new System.Windows.Forms.TabPage();
            this.tlpTermDeposit = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumberOfPeriods = new System.Windows.Forms.Label();
            this.nudNumberOfPeriods = new System.Windows.Forms.NumericUpDown();
            this.lblLimitOfTermDepositPeriod = new System.Windows.Forms.Label();
            this.tbTargetAccount2 = new System.Windows.Forms.TextBox();
            this.cmbRollover2 = new System.Windows.Forms.ComboBox();
            this.lbRollover2 = new System.Windows.Forms.Label();
            this.btSearchContract2 = new System.Windows.Forms.Button();
            this.lblTermTransferToAccount = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.btSavingsUpdate = new System.Windows.Forms.Button();
            this.buttonSaveSaving = new System.Windows.Forms.Button();
            this.buttonFirstDeposit = new System.Windows.Forms.Button();
            this.buttonCloseSaving = new System.Windows.Forms.Button();
            this.buttonReopenSaving = new System.Windows.Forms.Button();
            this.pnlSavingsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSavingsOperations = new System.Windows.Forms.Button();
            this.btCancelLastSavingEvent = new System.Windows.Forms.Button();
            this.groupBoxSaving = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbSavingAvBalanceValue = new System.Windows.Forms.Label();
            this.lBSavingAvBalance = new System.Windows.Forms.Label();
            this.lbEntryFeesMinMax = new System.Windows.Forms.Label();
            this.lbInitialAmountMinMax = new System.Windows.Forms.Label();
            this.lbEntryFees = new System.Windows.Forms.Label();
            this.labelInitialAmount = new System.Windows.Forms.Label();
            this.nudEntryFees = new System.Windows.Forms.NumericUpDown();
            this.nudDownInitialAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSavingBalanceValue = new System.Windows.Forms.Label();
            this.lBSavingBalance = new System.Windows.Forms.Label();
            this.tBSavingCode = new System.Windows.Forms.TextBox();
            this.cmbSavingsOfficer = new System.Windows.Forms.ComboBox();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.lbWithdrawFees = new System.Windows.Forms.Label();
            this.nudWithdrawFees = new System.Windows.Forms.NumericUpDown();
            this.lbInterestRateMinMax = new System.Windows.Forms.Label();
            this.lbWithdrawFeesMinMax = new System.Windows.Forms.Label();
            this.nudDownInterestRate = new System.Windows.Forms.NumericUpDown();
            this.tabPageContracts = new System.Windows.Forms.TabPage();
            this.tabPageFPCAContracts = new System.Windows.Forms.TabPage();
            this.lvFixedDeposits = new System.Windows.Forms.ListView();
            this.ContractCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InitialAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InterestRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaturityPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenAccountingOfficer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCurrentAccountProducts = new System.Windows.Forms.ListView();
            this.chContractCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOpenedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOpenAO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFDChargesNotice = new System.Windows.Forms.Button();
            this.btnCAGenerateStatement = new System.Windows.Forms.Button();
            this.btnViewCurrentAccount = new System.Windows.Forms.Button();
            this.btnAddCurrentAccount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCAChargesNotice = new System.Windows.Forms.Button();
            this.btnGenerateFDStatement = new System.Windows.Forms.Button();
            this.btnViewFixedDeposit = new System.Windows.Forms.Button();
            this.btnAddFixedDeposit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageFixedDeposit = new System.Windows.Forms.TabPage();
            this.tbTransferNumberForm = new System.Windows.Forms.GroupBox();
            this.gbFDInitialPayment = new System.Windows.Forms.GroupBox();
            this.cbInitialAmountPaymentMethod = new System.Windows.Forms.ComboBox();
            this.tbFDInitialAmountNumber = new System.Windows.Forms.TextBox();
            this.lblFDInitialAccount = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cbAccountStatus = new System.Windows.Forms.ComboBox();
            this.tbOpenedDate = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbFDContractCode = new System.Windows.Forms.TextBox();
            this.lblProductContractCode = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExtendPeriod = new System.Windows.Forms.Button();
            this.btnCloseFDContract = new System.Windows.Forms.Button();
            this.gbInterestCalculation = new System.Windows.Forms.GroupBox();
            this.tbTransferNumber = new System.Windows.Forms.TextBox();
            this.lblChequeNumber = new System.Windows.Forms.Label();
            this.cbAmountTransferMethod = new System.Windows.Forms.ComboBox();
            this.lblAmountTransferMethod = new System.Windows.Forms.Label();
            this.lblPreMatured = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.lbEffectivePenalty = new System.Windows.Forms.Label();
            this.lbEffectiveDepositPeriod = new System.Windows.Forms.Label();
            this.lbEffectiveInterest = new System.Windows.Forms.Label();
            this.lbEffectiveInterestRate = new System.Windows.Forms.Label();
            this.lblEffectiveInterestRate = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbAccountingOfficer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddFixedDepositProduct = new System.Windows.Forms.Button();
            this.cbFixedDepositProduct = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFDMaturityMinMax = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaturityPeriod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblFDPenaltyMinMax = new System.Windows.Forms.Label();
            this.rbPenalityTypeRate = new System.Windows.Forms.RadioButton();
            this.rbPenalityTypeFlat = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPenality = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbFrequency = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbFrequencyMonths = new System.Windows.Forms.TextBox();
            this.lbAccrual = new System.Windows.Forms.Label();
            this.lbNameSavingProduct = new System.Windows.Forms.Label();
            this.gbInitialAmount = new System.Windows.Forms.GroupBox();
            this.lblFDInitialAmountMinMax = new System.Windows.Forms.Label();
            this.tbInitialAmount = new System.Windows.Forms.TextBox();
            this.lbInitialAmountMin = new System.Windows.Forms.Label();
            this.gbInterestRate = new System.Windows.Forms.GroupBox();
            this.cbFDLibor = new System.Windows.Forms.CheckBox();
            this.lblFDLIBOR = new System.Windows.Forms.Label();
            this.lblFDInterestMinMax = new System.Windows.Forms.Label();
            this.lbYearlyInterestRateMin = new System.Windows.Forms.Label();
            this.tbInterestRate = new System.Windows.Forms.TextBox();
            this.lbInterestRateMin = new System.Windows.Forms.Label();
            this.tabPageCurrentAccount = new System.Windows.Forms.TabPage();
            this.lblLIBOR = new System.Windows.Forms.Label();
            this.cbLIBOR = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCAInterestRateMinMax = new System.Windows.Forms.Label();
            this.lblCAInitialAmountMinMax = new System.Windows.Forms.Label();
            this.checkBoxOverdraftApplied = new System.Windows.Forms.CheckBox();
            this.tbCurrentInitialAmount = new System.Windows.Forms.TextBox();
            this.tbCalculationFrequency = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tabControlCurrentAccount = new System.Windows.Forms.TabControl();
            this.tabPageFees = new System.Windows.Forms.TabPage();
            this.gbEntryFees = new System.Windows.Forms.GroupBox();
            this.lblCAEntryFeesMinMax = new System.Windows.Forms.Label();
            this.rbRateEntryFees = new System.Windows.Forms.RadioButton();
            this.rbFlatEntryFees = new System.Windows.Forms.RadioButton();
            this.lbEntryFeesType = new System.Windows.Forms.Label();
            this.tbEntryFees = new System.Windows.Forms.TextBox();
            this.lbEntryFeesMin = new System.Windows.Forms.Label();
            this.gtManagementFees = new System.Windows.Forms.GroupBox();
            this.lblCAManagementFeesMinMax = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.rbRateManagementFees = new System.Windows.Forms.RadioButton();
            this.rbFlatManagementFees = new System.Windows.Forms.RadioButton();
            this.lbManagementFeesType = new System.Windows.Forms.Label();
            this.tbManagementFees = new System.Windows.Forms.TextBox();
            this.lbManagementFeesMin = new System.Windows.Forms.Label();
            this.tabPageOverdraft = new System.Windows.Forms.TabPage();
            this.tbOverdraftDate = new System.Windows.Forms.TextBox();
            this.lblOverdraftAppliedDate = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCACommitmentFeesMinMax = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.rbODCommitmentTypeRate = new System.Windows.Forms.RadioButton();
            this.rbODCommitmentTypeFlat = new System.Windows.Forms.RadioButton();
            this.label42 = new System.Windows.Forms.Label();
            this.tbCAODCommitmentFee = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCAODInterestMinMax = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.rbODInterestTypeRate = new System.Windows.Forms.RadioButton();
            this.rbODInterestTypeFlat = new System.Windows.Forms.RadioButton();
            this.label39 = new System.Windows.Forms.Label();
            this.tbCAODInterestRate = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tbOverdraftAmount = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.gtOverdraftFees = new System.Windows.Forms.GroupBox();
            this.lblCAOverdraftFeesMinMax = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.rbRateOverdraftFees = new System.Windows.Forms.RadioButton();
            this.rbFlatOverdraftFees = new System.Windows.Forms.RadioButton();
            this.lbOverdraftFeesType = new System.Windows.Forms.Label();
            this.tbOverdraftFees = new System.Windows.Forms.TextBox();
            this.lbOverdraftFeesMin = new System.Windows.Forms.Label();
            this.tabPageCloseAccount = new System.Windows.Forms.TabPage();
            this.gbCloseFees = new System.Windows.Forms.GroupBox();
            this.lblCACloseFeesMinMax = new System.Windows.Forms.Label();
            this.rbRateCloseFees = new System.Windows.Forms.RadioButton();
            this.rbFlatCloseFees = new System.Windows.Forms.RadioButton();
            this.lbCloseFeesType = new System.Windows.Forms.Label();
            this.tbCloseFees = new System.Windows.Forms.TextBox();
            this.lbCloseFeesMin = new System.Windows.Forms.Label();
            this.tabPageReopenAccount = new System.Windows.Forms.TabPage();
            this.gbReopenFees = new System.Windows.Forms.GroupBox();
            this.lblCAReopenFeesMinMax = new System.Windows.Forms.Label();
            this.rbRateReopenFees = new System.Windows.Forms.RadioButton();
            this.rbFlatReopenFees = new System.Windows.Forms.RadioButton();
            this.lbReopenFeesType = new System.Windows.Forms.Label();
            this.tbReopenFees = new System.Windows.Forms.TextBox();
            this.lbReopenFeesMin = new System.Windows.Forms.Label();
            this.tabPageFeesTransactions = new System.Windows.Forms.TabPage();
            this.listViewFeeTransactions = new System.Windows.Forms.ListView();
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFeeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPurposeOfTransfer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTransactionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFeesBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvCAEvents = new System.Windows.Forms.ListView();
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCAInterestRate = new System.Windows.Forms.TextBox();
            this.tbCABalanceAmount = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.btnOverdraft = new System.Windows.Forms.Button();
            this.gbInitialPayment = new System.Windows.Forms.GroupBox();
            this.cbCAInitialAmountMethod = new System.Windows.Forms.ComboBox();
            this.tbInitialPaymentNumber = new System.Windows.Forms.TextBox();
            this.lblInitialChequeNumber = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gbAmount = new System.Windows.Forms.GroupBox();
            this.tbCAChequeAccount = new System.Windows.Forms.TextBox();
            this.lblCAChequeNumber = new System.Windows.Forms.Label();
            this.cbCAPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.tbCAClosedDate = new System.Windows.Forms.TextBox();
            this.lblCAClosedDate = new System.Windows.Forms.Label();
            this.btnCAPrint = new System.Windows.Forms.Button();
            this.btnCloseAccount = new System.Windows.Forms.Button();
            this.cbCAAccountStatus = new System.Windows.Forms.ComboBox();
            this.lblCAAcountStatus = new System.Windows.Forms.Label();
            this.tbCAOpenedDate = new System.Windows.Forms.TextBox();
            this.lblCAOpenedDate = new System.Windows.Forms.Label();
            this.tbCAProductCode = new System.Windows.Forms.TextBox();
            this.lblCAProductCode = new System.Windows.Forms.Label();
            this.btnAddCurrentAccountProduct = new System.Windows.Forms.Button();
            this.tbCurrentAccountComment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbCurrentAccountingOfficer = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCurrentAccountProductCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbCurrentAccountProducts = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvTransactions = new System.Windows.Forms.ListView();
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label44 = new System.Windows.Forms.Label();
            this.tabPageBGLC = new System.Windows.Forms.TabPage();
            this.btnGenerateLOCLetter = new System.Windows.Forms.Button();
            this.btnGenerateBGLetter = new System.Windows.Forms.Button();
            this.btnViewLetterOfCredit = new System.Windows.Forms.Button();
            this.btnUpdateLetterOfCredit = new System.Windows.Forms.Button();
            this.btnAddLetterOfCredit = new System.Windows.Forms.Button();
            this.lvLetterOfCredit = new System.Windows.Forms.ListView();
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader57 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader58 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader59 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader60 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label46 = new System.Windows.Forms.Label();
            this.btnViewBankGuarantee = new System.Windows.Forms.Button();
            this.btnUpdateBankGuarantee = new System.Windows.Forms.Button();
            this.btnAddBankGuarantee = new System.Windows.Forms.Button();
            this.lvBankGuarantee = new System.Windows.Forms.ListView();
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label22 = new System.Windows.Forms.Label();
            this.menuBtnAddSavingOperation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.savingDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingWithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olvColumnSACExportedBalance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLACExportedBalance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleRepayment = new System.Windows.Forms.Label();
            this.buttonPrintSchedule = new System.Windows.Forms.Button();
            this.buttonReschedule = new System.Windows.Forms.Button();
            this.buttonRepay = new System.Windows.Forms.Button();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrincipal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInterest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLoanDisbursement = new System.Windows.Forms.Button();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.contextMenuStripPackage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparatorCopy = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemEditComment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancelPending = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConfirmPending = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCollateralProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPendingSavingEvents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemConfirmPendingSavingEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCancelPendingSavingEvent = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProjectJobs)).BeginInit();
            this.gBProjectFinancialPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            this.gBProjectFollowUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlGuarantorButtons.SuspendLayout();
            this.pnlCollateralButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContracts)).BeginInit();
            this.splitContainerContracts.Panel1.SuspendLayout();
            this.splitContainerContracts.Panel2.SuspendLayout();
            this.splitContainerContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.SuspendLayout();
            this.tabControlPerson.SuspendLayout();
            this.tabPageProject.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxProjectDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlProject.SuspendLayout();
            this.tabPageProjectLoans.SuspendLayout();
            this.pnlLoans.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPageProjectAnalyses.SuspendLayout();
            this.tabPageCorporate.SuspendLayout();
            this.tabPageFollowUp.SuspendLayout();
            this.tabPageLoansDetails.SuspendLayout();
            this.tclLoanDetails.SuspendLayout();
            this.tabPageInstallments.SuspendLayout();
            this.loanDetailsButtonsPanel.SuspendLayout();
            this.gbxLoanDetails.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoanGracePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanNbOfInstallments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).BeginInit();
            this.tabPageAdvancedSettings.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBoxAnticipatedRepaymentPenalties.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBoxLoanLateFees.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBoxEntryFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEntryFees)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompulsoryAmountPercent)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.tabPageCreditCommitee.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.pnlCCStatus.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.tabPageLoanRepayment.SuspendLayout();
            this.tabControlRepayments.SuspendLayout();
            this.tabPageRepayments.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageLoanGuarantees.SuspendLayout();
            this.tabPageSavingDetails.SuspendLayout();
            this.tabControlSavingsDetails.SuspendLayout();
            this.tabPageSavingsAmountsAndFees.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.groupBoxSavingBalance.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.groupBoxSavingDeposit.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.groupBoxSavingWithdraw.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.groupBoxSavingTransfer.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.gbInterest.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.gbDepositInterest.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tlpSBDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIbtFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReopenFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgioFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChequeDepositFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverdraftFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCloseFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManagementFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositFees)).BeginInit();
            this.tabPageSavingsEvents.SuspendLayout();
            this.tabPageLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvLoans)).BeginInit();
            this.tpTermDeposit.SuspendLayout();
            this.tlpTermDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeriods)).BeginInit();
            this.flowLayoutPanel9.SuspendLayout();
            this.pnlSavingsButtons.SuspendLayout();
            this.groupBoxSaving.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntryFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownInitialAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownInterestRate)).BeginInit();
            this.tabPageContracts.SuspendLayout();
            this.tabPageFPCAContracts.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageFixedDeposit.SuspendLayout();
            this.tbTransferNumberForm.SuspendLayout();
            this.gbFDInitialPayment.SuspendLayout();
            this.gbInterestCalculation.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbFrequency.SuspendLayout();
            this.gbInitialAmount.SuspendLayout();
            this.gbInterestRate.SuspendLayout();
            this.tabPageCurrentAccount.SuspendLayout();
            this.tabControlCurrentAccount.SuspendLayout();
            this.tabPageFees.SuspendLayout();
            this.gbEntryFees.SuspendLayout();
            this.gtManagementFees.SuspendLayout();
            this.tabPageOverdraft.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gtOverdraftFees.SuspendLayout();
            this.tabPageCloseAccount.SuspendLayout();
            this.gbCloseFees.SuspendLayout();
            this.tabPageReopenAccount.SuspendLayout();
            this.gbReopenFees.SuspendLayout();
            this.tabPageFeesTransactions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbInitialPayment.SuspendLayout();
            this.gbAmount.SuspendLayout();
            this.tabPageTransactions.SuspendLayout();
            this.tabPageBGLC.SuspendLayout();
            this.menuBtnAddSavingOperation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuPendingSavingEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer10
            // 
            resources.ApplyResources(this.splitContainer10, "splitContainer10");
            this.splitContainer10.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer10.Name = "splitContainer10";
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.numericUpDownProjectJobs);
            this.splitContainer10.Panel1.Controls.Add(this.gBProjectFinancialPlan);
            this.splitContainer10.Panel1.Controls.Add(this.lProjectNbOfNewJobs);
            this.splitContainer10.Panel1.Controls.Add(this.tBProjectCA);
            this.splitContainer10.Panel1.Controls.Add(this.lProjectCA);
            this.splitContainer10.Panel1.Controls.Add(this.lProjectCorporateName);
            this.splitContainer10.Panel1.Controls.Add(this.cBProjectAffiliation);
            this.splitContainer10.Panel1.Controls.Add(this.cBProjectFiscalStatus);
            this.splitContainer10.Panel1.Controls.Add(this.tBProjectCorporateName);
            this.splitContainer10.Panel1.Controls.Add(this.cBProjectJuridicStatus);
            this.splitContainer10.Panel1.Controls.Add(this.lProjectCorporateSIRET);
            this.splitContainer10.Panel1.Controls.Add(this.lProjectJuridicStatus);
            this.splitContainer10.Panel1.Controls.Add(this.tBProjectCorporateSIRET);
            this.splitContainer10.Panel1.Controls.Add(this.lProjectAffiliation);
            this.splitContainer10.Panel1.Controls.Add(this.lProjectFiscalStatus);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.gBProjectAddress);
            // 
            // numericUpDownProjectJobs
            // 
            resources.ApplyResources(this.numericUpDownProjectJobs, "numericUpDownProjectJobs");
            this.numericUpDownProjectJobs.Name = "numericUpDownProjectJobs";
            // 
            // gBProjectFinancialPlan
            // 
            this.gBProjectFinancialPlan.Controls.Add(this.lProjectFinancialPlanType);
            this.gBProjectFinancialPlan.Controls.Add(this.lProjectFinancialPlanAmount);
            this.gBProjectFinancialPlan.Controls.Add(this.tBProjectFinancialPlanTotal);
            this.gBProjectFinancialPlan.Controls.Add(this.tBProjectFinancialPlanAmount);
            this.gBProjectFinancialPlan.Controls.Add(this.cBProjectFinancialPlanType);
            this.gBProjectFinancialPlan.Controls.Add(this.lProjectFinancialPlanTotalAmount);
            resources.ApplyResources(this.gBProjectFinancialPlan, "gBProjectFinancialPlan");
            this.gBProjectFinancialPlan.Name = "gBProjectFinancialPlan";
            this.gBProjectFinancialPlan.TabStop = false;
            // 
            // lProjectFinancialPlanType
            // 
            resources.ApplyResources(this.lProjectFinancialPlanType, "lProjectFinancialPlanType");
            this.lProjectFinancialPlanType.Name = "lProjectFinancialPlanType";
            // 
            // lProjectFinancialPlanAmount
            // 
            resources.ApplyResources(this.lProjectFinancialPlanAmount, "lProjectFinancialPlanAmount");
            this.lProjectFinancialPlanAmount.Name = "lProjectFinancialPlanAmount";
            // 
            // tBProjectFinancialPlanTotal
            // 
            this.tBProjectFinancialPlanTotal.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tBProjectFinancialPlanTotal, "tBProjectFinancialPlanTotal");
            this.tBProjectFinancialPlanTotal.Name = "tBProjectFinancialPlanTotal";
            // 
            // tBProjectFinancialPlanAmount
            // 
            this.tBProjectFinancialPlanAmount.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tBProjectFinancialPlanAmount, "tBProjectFinancialPlanAmount");
            this.tBProjectFinancialPlanAmount.Name = "tBProjectFinancialPlanAmount";
            // 
            // cBProjectFinancialPlanType
            // 
            this.cBProjectFinancialPlanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBProjectFinancialPlanType.FormattingEnabled = true;
            resources.ApplyResources(this.cBProjectFinancialPlanType, "cBProjectFinancialPlanType");
            this.cBProjectFinancialPlanType.Name = "cBProjectFinancialPlanType";
            // 
            // lProjectFinancialPlanTotalAmount
            // 
            resources.ApplyResources(this.lProjectFinancialPlanTotalAmount, "lProjectFinancialPlanTotalAmount");
            this.lProjectFinancialPlanTotalAmount.Name = "lProjectFinancialPlanTotalAmount";
            // 
            // lProjectNbOfNewJobs
            // 
            resources.ApplyResources(this.lProjectNbOfNewJobs, "lProjectNbOfNewJobs");
            this.lProjectNbOfNewJobs.Name = "lProjectNbOfNewJobs";
            // 
            // tBProjectCA
            // 
            this.tBProjectCA.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tBProjectCA, "tBProjectCA");
            this.tBProjectCA.Name = "tBProjectCA";
            // 
            // lProjectCA
            // 
            resources.ApplyResources(this.lProjectCA, "lProjectCA");
            this.lProjectCA.Name = "lProjectCA";
            // 
            // lProjectCorporateName
            // 
            resources.ApplyResources(this.lProjectCorporateName, "lProjectCorporateName");
            this.lProjectCorporateName.Name = "lProjectCorporateName";
            // 
            // cBProjectAffiliation
            // 
            this.cBProjectAffiliation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBProjectAffiliation.FormattingEnabled = true;
            resources.ApplyResources(this.cBProjectAffiliation, "cBProjectAffiliation");
            this.cBProjectAffiliation.Name = "cBProjectAffiliation";
            // 
            // cBProjectFiscalStatus
            // 
            this.cBProjectFiscalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBProjectFiscalStatus.FormattingEnabled = true;
            resources.ApplyResources(this.cBProjectFiscalStatus, "cBProjectFiscalStatus");
            this.cBProjectFiscalStatus.Name = "cBProjectFiscalStatus";
            // 
            // tBProjectCorporateName
            // 
            this.tBProjectCorporateName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tBProjectCorporateName, "tBProjectCorporateName");
            this.tBProjectCorporateName.Name = "tBProjectCorporateName";
            // 
            // cBProjectJuridicStatus
            // 
            this.cBProjectJuridicStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBProjectJuridicStatus.FormattingEnabled = true;
            resources.ApplyResources(this.cBProjectJuridicStatus, "cBProjectJuridicStatus");
            this.cBProjectJuridicStatus.Name = "cBProjectJuridicStatus";
            // 
            // lProjectCorporateSIRET
            // 
            resources.ApplyResources(this.lProjectCorporateSIRET, "lProjectCorporateSIRET");
            this.lProjectCorporateSIRET.Name = "lProjectCorporateSIRET";
            // 
            // lProjectJuridicStatus
            // 
            resources.ApplyResources(this.lProjectJuridicStatus, "lProjectJuridicStatus");
            this.lProjectJuridicStatus.Name = "lProjectJuridicStatus";
            // 
            // tBProjectCorporateSIRET
            // 
            this.tBProjectCorporateSIRET.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tBProjectCorporateSIRET, "tBProjectCorporateSIRET");
            this.tBProjectCorporateSIRET.Name = "tBProjectCorporateSIRET";
            // 
            // lProjectAffiliation
            // 
            resources.ApplyResources(this.lProjectAffiliation, "lProjectAffiliation");
            this.lProjectAffiliation.Name = "lProjectAffiliation";
            // 
            // lProjectFiscalStatus
            // 
            resources.ApplyResources(this.lProjectFiscalStatus, "lProjectFiscalStatus");
            this.lProjectFiscalStatus.Name = "lProjectFiscalStatus";
            // 
            // gBProjectAddress
            // 
            resources.ApplyResources(this.gBProjectAddress, "gBProjectAddress");
            this.gBProjectAddress.Name = "gBProjectAddress";
            this.gBProjectAddress.TabStop = false;
            // 
            // splitContainer11
            // 
            resources.ApplyResources(this.splitContainer11, "splitContainer11");
            this.splitContainer11.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.listViewProjectFollowUp);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.gBProjectFollowUp);
            // 
            // listViewProjectFollowUp
            // 
            this.listViewProjectFollowUp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProjectYear,
            this.columnHeaderProjectJobs1,
            this.columnHeaderProjectJobs2,
            this.columnHeaderProjectCA,
            this.columnHeaderprojectPersonalSituation,
            this.columnHeaderProjectActivity,
            this.columnHeaderProjectComment});
            resources.ApplyResources(this.listViewProjectFollowUp, "listViewProjectFollowUp");
            this.listViewProjectFollowUp.FullRowSelect = true;
            this.listViewProjectFollowUp.GridLines = true;
            this.listViewProjectFollowUp.Name = "listViewProjectFollowUp";
            this.listViewProjectFollowUp.UseCompatibleStateImageBehavior = false;
            this.listViewProjectFollowUp.View = System.Windows.Forms.View.Details;
            this.listViewProjectFollowUp.DoubleClick += new System.EventHandler(this.listViewProjectFollowUp_DoubleClick);
            // 
            // columnHeaderProjectYear
            // 
            resources.ApplyResources(this.columnHeaderProjectYear, "columnHeaderProjectYear");
            // 
            // columnHeaderProjectJobs1
            // 
            resources.ApplyResources(this.columnHeaderProjectJobs1, "columnHeaderProjectJobs1");
            // 
            // columnHeaderProjectJobs2
            // 
            resources.ApplyResources(this.columnHeaderProjectJobs2, "columnHeaderProjectJobs2");
            // 
            // columnHeaderProjectCA
            // 
            resources.ApplyResources(this.columnHeaderProjectCA, "columnHeaderProjectCA");
            // 
            // columnHeaderprojectPersonalSituation
            // 
            resources.ApplyResources(this.columnHeaderprojectPersonalSituation, "columnHeaderprojectPersonalSituation");
            // 
            // columnHeaderProjectActivity
            // 
            resources.ApplyResources(this.columnHeaderProjectActivity, "columnHeaderProjectActivity");
            // 
            // columnHeaderProjectComment
            // 
            resources.ApplyResources(this.columnHeaderProjectComment, "columnHeaderProjectComment");
            // 
            // gBProjectFollowUp
            // 
            this.gBProjectFollowUp.Controls.Add(this.buttonProjectAddFollowUp);
            resources.ApplyResources(this.gBProjectFollowUp, "gBProjectFollowUp");
            this.gBProjectFollowUp.Name = "gBProjectFollowUp";
            this.gBProjectFollowUp.TabStop = false;
            // 
            // buttonProjectAddFollowUp
            // 
            resources.ApplyResources(this.buttonProjectAddFollowUp, "buttonProjectAddFollowUp");
            this.buttonProjectAddFollowUp.Name = "buttonProjectAddFollowUp";
            this.buttonProjectAddFollowUp.Click += new System.EventHandler(this.buttonProjectAddFollowUp_Click);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewGuarantors);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.lblGuarantorsList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewCollaterals);
            this.splitContainer1.Panel2.Controls.Add(this.pnlCollateralButtons);
            this.splitContainer1.Panel2.Controls.Add(this.lblCollaterals);
            // 
            // listViewGuarantors
            // 
            this.listViewGuarantors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeader17,
            this.columnHeaderPercentage,
            this.columnHeaderDesc});
            resources.ApplyResources(this.listViewGuarantors, "listViewGuarantors");
            this.listViewGuarantors.FullRowSelect = true;
            this.listViewGuarantors.GridLines = true;
            this.listViewGuarantors.MultiSelect = false;
            this.listViewGuarantors.Name = "listViewGuarantors";
            this.listViewGuarantors.UseCompatibleStateImageBehavior = false;
            this.listViewGuarantors.View = System.Windows.Forms.View.Details;
            this.listViewGuarantors.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewGuarantors_DrawColumnHeader);
            this.listViewGuarantors.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewGuarantors_DrawSubItem);
            // 
            // columnHeaderName
            // 
            resources.ApplyResources(this.columnHeaderName, "columnHeaderName");
            // 
            // columnHeader17
            // 
            resources.ApplyResources(this.columnHeader17, "columnHeader17");
            // 
            // columnHeaderPercentage
            // 
            resources.ApplyResources(this.columnHeaderPercentage, "columnHeaderPercentage");
            // 
            // columnHeaderDesc
            // 
            resources.ApplyResources(this.columnHeaderDesc, "columnHeaderDesc");
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.pnlGuarantorButtons);
            this.panel3.Name = "panel3";
            // 
            // pnlGuarantorButtons
            // 
            resources.ApplyResources(this.pnlGuarantorButtons, "pnlGuarantorButtons");
            this.pnlGuarantorButtons.Controls.Add(this.buttonSelectAGarantors);
            this.pnlGuarantorButtons.Controls.Add(this.buttonModifyAGarantors);
            this.pnlGuarantorButtons.Controls.Add(this.buttonViewAGarantors);
            this.pnlGuarantorButtons.Controls.Add(this.buttonDelete);
            this.pnlGuarantorButtons.Controls.Add(this.lblCreditCurrency);
            this.pnlGuarantorButtons.Name = "pnlGuarantorButtons";
            // 
            // buttonSelectAGarantors
            // 
            resources.ApplyResources(this.buttonSelectAGarantors, "buttonSelectAGarantors");
            this.buttonSelectAGarantors.Name = "buttonSelectAGarantors";
            this.buttonSelectAGarantors.Click += new System.EventHandler(this.buttonSelectAGarantors_Click);
            // 
            // buttonModifyAGarantors
            // 
            resources.ApplyResources(this.buttonModifyAGarantors, "buttonModifyAGarantors");
            this.buttonModifyAGarantors.Name = "buttonModifyAGarantors";
            this.buttonModifyAGarantors.Click += new System.EventHandler(this.buttonModifyAGarantors_Click);
            // 
            // buttonViewAGarantors
            // 
            resources.ApplyResources(this.buttonViewAGarantors, "buttonViewAGarantors");
            this.buttonViewAGarantors.Name = "buttonViewAGarantors";
            this.buttonViewAGarantors.Click += new System.EventHandler(this.buttonViewAGarantors_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // lblCreditCurrency
            // 
            resources.ApplyResources(this.lblCreditCurrency, "lblCreditCurrency");
            this.lblCreditCurrency.Name = "lblCreditCurrency";
            // 
            // lblGuarantorsList
            // 
            this.lblGuarantorsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.lblGuarantorsList, "lblGuarantorsList");
            this.lblGuarantorsList.ForeColor = System.Drawing.Color.White;
            this.lblGuarantorsList.Name = "lblGuarantorsList";
            // 
            // listViewCollaterals
            // 
            this.listViewCollaterals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader25,
            this.columnHeaderColDesc});
            resources.ApplyResources(this.listViewCollaterals, "listViewCollaterals");
            this.listViewCollaterals.FullRowSelect = true;
            this.listViewCollaterals.GridLines = true;
            this.listViewCollaterals.MultiSelect = false;
            this.listViewCollaterals.Name = "listViewCollaterals";
            this.listViewCollaterals.UseCompatibleStateImageBehavior = false;
            this.listViewCollaterals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader19
            // 
            resources.ApplyResources(this.columnHeader19, "columnHeader19");
            // 
            // columnHeader20
            // 
            resources.ApplyResources(this.columnHeader20, "columnHeader20");
            // 
            // columnHeader25
            // 
            resources.ApplyResources(this.columnHeader25, "columnHeader25");
            // 
            // columnHeaderColDesc
            // 
            resources.ApplyResources(this.columnHeaderColDesc, "columnHeaderColDesc");
            // 
            // pnlCollateralButtons
            // 
            resources.ApplyResources(this.pnlCollateralButtons, "pnlCollateralButtons");
            this.pnlCollateralButtons.Controls.Add(this.buttonAddCollateral);
            this.pnlCollateralButtons.Controls.Add(this.buttonModifyCollateral);
            this.pnlCollateralButtons.Controls.Add(this.buttonViewCollateral);
            this.pnlCollateralButtons.Controls.Add(this.buttonDelCollateral);
            this.pnlCollateralButtons.Name = "pnlCollateralButtons";
            // 
            // buttonAddCollateral
            // 
            resources.ApplyResources(this.buttonAddCollateral, "buttonAddCollateral");
            this.buttonAddCollateral.Name = "buttonAddCollateral";
            this.buttonAddCollateral.Click += new System.EventHandler(this.buttonAddCollateral_Click);
            // 
            // buttonModifyCollateral
            // 
            resources.ApplyResources(this.buttonModifyCollateral, "buttonModifyCollateral");
            this.buttonModifyCollateral.Name = "buttonModifyCollateral";
            this.buttonModifyCollateral.Click += new System.EventHandler(this.buttonModifyCollateral_Click);
            // 
            // buttonViewCollateral
            // 
            resources.ApplyResources(this.buttonViewCollateral, "buttonViewCollateral");
            this.buttonViewCollateral.Name = "buttonViewCollateral";
            this.buttonViewCollateral.Click += new System.EventHandler(this.buttonViewCollateral_Click);
            // 
            // buttonDelCollateral
            // 
            resources.ApplyResources(this.buttonDelCollateral, "buttonDelCollateral");
            this.buttonDelCollateral.Name = "buttonDelCollateral";
            this.buttonDelCollateral.Click += new System.EventHandler(this.buttonDelCollateral_Click);
            // 
            // lblCollaterals
            // 
            this.lblCollaterals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.lblCollaterals, "lblCollaterals");
            this.lblCollaterals.ForeColor = System.Drawing.Color.White;
            this.lblCollaterals.Name = "lblCollaterals";
            // 
            // splitContainerContracts
            // 
            resources.ApplyResources(this.splitContainerContracts, "splitContainerContracts");
            this.splitContainerContracts.Name = "splitContainerContracts";
            // 
            // splitContainerContracts.Panel1
            // 
            this.splitContainerContracts.Panel1.Controls.Add(this.panelLoansContracts);
            this.splitContainerContracts.Panel1.Controls.Add(this.labelLoansContracts);
            // 
            // splitContainerContracts.Panel2
            // 
            this.splitContainerContracts.Panel2.Controls.Add(this.panelSavingsContracts);
            this.splitContainerContracts.Panel2.Controls.Add(this.labelSavingsContracts);
            // 
            // panelLoansContracts
            // 
            resources.ApplyResources(this.panelLoansContracts, "panelLoansContracts");
            this.panelLoansContracts.Name = "panelLoansContracts";
            // 
            // labelLoansContracts
            // 
            this.labelLoansContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.labelLoansContracts, "labelLoansContracts");
            this.labelLoansContracts.ForeColor = System.Drawing.Color.White;
            this.labelLoansContracts.Name = "labelLoansContracts";
            // 
            // panelSavingsContracts
            // 
            resources.ApplyResources(this.panelSavingsContracts, "panelSavingsContracts");
            this.panelSavingsContracts.Name = "panelSavingsContracts";
            // 
            // labelSavingsContracts
            // 
            this.labelSavingsContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.labelSavingsContracts, "labelSavingsContracts");
            this.labelSavingsContracts.ForeColor = System.Drawing.Color.White;
            this.labelSavingsContracts.Name = "labelSavingsContracts";
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panelUserControl);
            // 
            // panelUserControl
            // 
            resources.ApplyResources(this.panelUserControl, "panelUserControl");
            this.panelUserControl.Name = "panelUserControl";
            // 
            // splitContainer4
            // 
            resources.ApplyResources(this.splitContainer4, "splitContainer4");
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer6
            // 
            resources.ApplyResources(this.splitContainer6, "splitContainer6");
            this.splitContainer6.Name = "splitContainer6";
            // 
            // tabControlPerson
            // 
            this.tabControlPerson.Controls.Add(this.tabPageDetails);
            this.tabControlPerson.Controls.Add(this.tabPageProject);
            this.tabControlPerson.Controls.Add(this.tabPageLoansDetails);
            this.tabControlPerson.Controls.Add(this.tabPageAdvancedSettings);
            this.tabControlPerson.Controls.Add(this.tabPageCreditCommitee);
            this.tabControlPerson.Controls.Add(this.tabPageLoanRepayment);
            this.tabControlPerson.Controls.Add(this.tabPageLoanGuarantees);
            this.tabControlPerson.Controls.Add(this.tabPageSavingDetails);
            this.tabControlPerson.Controls.Add(this.tabPageContracts);
            this.tabControlPerson.Controls.Add(this.tabPageFPCAContracts);
            this.tabControlPerson.Controls.Add(this.tabPageFixedDeposit);
            this.tabControlPerson.Controls.Add(this.tabPageCurrentAccount);
            this.tabControlPerson.Controls.Add(this.tabPageTransactions);
            this.tabControlPerson.Controls.Add(this.tabPageBGLC);
            resources.ApplyResources(this.tabControlPerson, "tabControlPerson");
            this.tabControlPerson.ImageList = this.imageListTab;
            this.tabControlPerson.Multiline = true;
            this.tabControlPerson.Name = "tabControlPerson";
            this.tabControlPerson.SelectedIndex = 0;
            this.tabControlPerson.SelectedIndexChanged += new System.EventHandler(this.tabControlPerson_SelectedIndexChanged);
            // 
            // tabPageDetails
            // 
            resources.ApplyResources(this.tabPageDetails, "tabPageDetails");
            this.tabPageDetails.Name = "tabPageDetails";
            // 
            // tabPageProject
            // 
            this.tabPageProject.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.tabPageProject, "tabPageProject");
            this.tabPageProject.Name = "tabPageProject";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBoxProjectDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControlProject, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBoxProjectDetails
            // 
            this.groupBoxProjectDetails.Controls.Add(this.dateTimePickerProjectBeginDate);
            this.groupBoxProjectDetails.Controls.Add(this.labelProjectDate);
            this.groupBoxProjectDetails.Controls.Add(this.buttonProjectSelectPurpose);
            this.groupBoxProjectDetails.Controls.Add(this.textBoxProjectPurpose);
            this.groupBoxProjectDetails.Controls.Add(this.labelProjectPurpose);
            this.groupBoxProjectDetails.Controls.Add(this.labelProjectName);
            this.groupBoxProjectDetails.Controls.Add(this.textBoxProjectName);
            this.groupBoxProjectDetails.Controls.Add(this.labelProjectCode);
            this.groupBoxProjectDetails.Controls.Add(this.textBoxProjectCode);
            this.groupBoxProjectDetails.Controls.Add(this.labelFirstProjectName);
            this.groupBoxProjectDetails.Controls.Add(this.textBoxProjectAim);
            resources.ApplyResources(this.groupBoxProjectDetails, "groupBoxProjectDetails");
            this.groupBoxProjectDetails.Name = "groupBoxProjectDetails";
            this.groupBoxProjectDetails.TabStop = false;
            // 
            // dateTimePickerProjectBeginDate
            // 
            this.dateTimePickerProjectBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePickerProjectBeginDate, "dateTimePickerProjectBeginDate");
            this.dateTimePickerProjectBeginDate.Name = "dateTimePickerProjectBeginDate";
            // 
            // labelProjectDate
            // 
            resources.ApplyResources(this.labelProjectDate, "labelProjectDate");
            this.labelProjectDate.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectDate.Name = "labelProjectDate";
            // 
            // buttonProjectSelectPurpose
            // 
            resources.ApplyResources(this.buttonProjectSelectPurpose, "buttonProjectSelectPurpose");
            this.buttonProjectSelectPurpose.Name = "buttonProjectSelectPurpose";
            this.buttonProjectSelectPurpose.Click += new System.EventHandler(this.buttonProjectSelectPurpose_Click);
            // 
            // textBoxProjectPurpose
            // 
            this.textBoxProjectPurpose.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textBoxProjectPurpose, "textBoxProjectPurpose");
            this.textBoxProjectPurpose.Name = "textBoxProjectPurpose";
            this.textBoxProjectPurpose.ReadOnly = true;
            // 
            // labelProjectPurpose
            // 
            resources.ApplyResources(this.labelProjectPurpose, "labelProjectPurpose");
            this.labelProjectPurpose.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectPurpose.Name = "labelProjectPurpose";
            // 
            // labelProjectName
            // 
            resources.ApplyResources(this.labelProjectName, "labelProjectName");
            this.labelProjectName.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectName.Name = "labelProjectName";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxProjectName, "textBoxProjectName");
            this.textBoxProjectName.Name = "textBoxProjectName";
            // 
            // labelProjectCode
            // 
            resources.ApplyResources(this.labelProjectCode, "labelProjectCode");
            this.labelProjectCode.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectCode.Name = "labelProjectCode";
            // 
            // textBoxProjectCode
            // 
            this.textBoxProjectCode.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.textBoxProjectCode, "textBoxProjectCode");
            this.textBoxProjectCode.Name = "textBoxProjectCode";
            this.textBoxProjectCode.ReadOnly = true;
            // 
            // labelFirstProjectName
            // 
            resources.ApplyResources(this.labelFirstProjectName, "labelFirstProjectName");
            this.labelFirstProjectName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstProjectName.Name = "labelFirstProjectName";
            // 
            // textBoxProjectAim
            // 
            this.textBoxProjectAim.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxProjectAim, "textBoxProjectAim");
            this.textBoxProjectAim.Name = "textBoxProjectAim";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonProjectSave);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonProjectSave
            // 
            resources.ApplyResources(this.buttonProjectSave, "buttonProjectSave");
            this.buttonProjectSave.Name = "buttonProjectSave";
            this.buttonProjectSave.Click += new System.EventHandler(this.buttonSaveProject_Click);
            // 
            // tabControlProject
            // 
            this.tabControlProject.Controls.Add(this.tabPageProjectLoans);
            this.tabControlProject.Controls.Add(this.tabPageProjectAnalyses);
            this.tabControlProject.Controls.Add(this.tabPageCorporate);
            this.tabControlProject.Controls.Add(this.tabPageFollowUp);
            resources.ApplyResources(this.tabControlProject, "tabControlProject");
            this.tabControlProject.Name = "tabControlProject";
            this.tabControlProject.SelectedIndex = 0;
            // 
            // tabPageProjectLoans
            // 
            this.tabPageProjectLoans.Controls.Add(this.pnlLoans);
            resources.ApplyResources(this.tabPageProjectLoans, "tabPageProjectLoans");
            this.tabPageProjectLoans.Name = "tabPageProjectLoans";
            // 
            // pnlLoans
            // 
            this.pnlLoans.Controls.Add(this.lvContracts);
            this.pnlLoans.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.pnlLoans, "pnlLoans");
            this.pnlLoans.Name = "pnlLoans";
            // 
            // lvContracts
            // 
            this.lvContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductType,
            this.columnHeaderId,
            this.columnHeaderStatus,
            this.columnHeaderAmount,
            this.columnHeaderOLB,
            this.columnHeaderCurrency,
            this.columnHeaderInterestRate,
            this.columnHeaderInstallmentType,
            this.columnHeaderNbOfInstallments,
            this.columnHeaderCreationDate,
            this.columnHeaderStartDate,
            this.columnHeaderCloseDate,
            this.columnHeaderLoanCategory});
            resources.ApplyResources(this.lvContracts, "lvContracts");
            this.lvContracts.FullRowSelect = true;
            this.lvContracts.GridLines = true;
            this.lvContracts.MultiSelect = false;
            this.lvContracts.Name = "lvContracts";
            this.lvContracts.UseCompatibleStateImageBehavior = false;
            this.lvContracts.View = System.Windows.Forms.View.Details;
            this.lvContracts.SelectedIndexChanged += new System.EventHandler(this.lvContracts_SelectedIndexChanged);
            this.lvContracts.DoubleClick += new System.EventHandler(this.listViewContracts_DoubleClick);
            // 
            // columnProductType
            // 
            resources.ApplyResources(this.columnProductType, "columnProductType");
            // 
            // columnHeaderId
            // 
            resources.ApplyResources(this.columnHeaderId, "columnHeaderId");
            // 
            // columnHeaderStatus
            // 
            resources.ApplyResources(this.columnHeaderStatus, "columnHeaderStatus");
            // 
            // columnHeaderAmount
            // 
            resources.ApplyResources(this.columnHeaderAmount, "columnHeaderAmount");
            // 
            // columnHeaderOLB
            // 
            resources.ApplyResources(this.columnHeaderOLB, "columnHeaderOLB");
            // 
            // columnHeaderCurrency
            // 
            resources.ApplyResources(this.columnHeaderCurrency, "columnHeaderCurrency");
            // 
            // columnHeaderInterestRate
            // 
            resources.ApplyResources(this.columnHeaderInterestRate, "columnHeaderInterestRate");
            // 
            // columnHeaderInstallmentType
            // 
            resources.ApplyResources(this.columnHeaderInstallmentType, "columnHeaderInstallmentType");
            // 
            // columnHeaderNbOfInstallments
            // 
            resources.ApplyResources(this.columnHeaderNbOfInstallments, "columnHeaderNbOfInstallments");
            // 
            // columnHeaderCreationDate
            // 
            resources.ApplyResources(this.columnHeaderCreationDate, "columnHeaderCreationDate");
            // 
            // columnHeaderStartDate
            // 
            resources.ApplyResources(this.columnHeaderStartDate, "columnHeaderStartDate");
            // 
            // columnHeaderCloseDate
            // 
            resources.ApplyResources(this.columnHeaderCloseDate, "columnHeaderCloseDate");
            // 
            // columnHeaderLoanCategory
            // 
            resources.ApplyResources(this.columnHeaderLoanCategory, "columnHeaderLoanCategory");
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.buttonProjectAddContract);
            this.flowLayoutPanel1.Controls.Add(this.buttonProjectViewContract);
            this.flowLayoutPanel1.Controls.Add(this.btnGenerateLoanStatement);
            this.flowLayoutPanel1.Controls.Add(this.btnCurrentChargesNotice);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // buttonProjectAddContract
            // 
            resources.ApplyResources(this.buttonProjectAddContract, "buttonProjectAddContract");
            this.buttonProjectAddContract.Name = "buttonProjectAddContract";
            this.buttonProjectAddContract.Click += new System.EventHandler(this.buttonAddContract_Click);
            // 
            // buttonProjectViewContract
            // 
            resources.ApplyResources(this.buttonProjectViewContract, "buttonProjectViewContract");
            this.buttonProjectViewContract.Name = "buttonProjectViewContract";
            this.buttonProjectViewContract.Click += new System.EventHandler(this.buttonProjectViewContract_Click);
            // 
            // btnGenerateLoanStatement
            // 
            resources.ApplyResources(this.btnGenerateLoanStatement, "btnGenerateLoanStatement");
            this.btnGenerateLoanStatement.Name = "btnGenerateLoanStatement";
            this.btnGenerateLoanStatement.Click += new System.EventHandler(this.btnGenerateLoanStatement_Click);
            // 
            // btnCurrentChargesNotice
            // 
            resources.ApplyResources(this.btnCurrentChargesNotice, "btnCurrentChargesNotice");
            this.btnCurrentChargesNotice.Name = "btnCurrentChargesNotice";
            this.btnCurrentChargesNotice.Click += new System.EventHandler(this.btnCurrentChargesNotice_Click);
            // 
            // tabPageProjectAnalyses
            // 
            this.tabPageProjectAnalyses.Controls.Add(this.textBoxProjectConcurrence);
            this.tabPageProjectAnalyses.Controls.Add(this.textBoxProjectMarket);
            this.tabPageProjectAnalyses.Controls.Add(this.labelProjectConcurrence);
            this.tabPageProjectAnalyses.Controls.Add(this.labelProjectMarket);
            this.tabPageProjectAnalyses.Controls.Add(this.textBoxProjectAbilities);
            this.tabPageProjectAnalyses.Controls.Add(this.textBoxProjectExperience);
            this.tabPageProjectAnalyses.Controls.Add(this.labelProjectExperience);
            this.tabPageProjectAnalyses.Controls.Add(this.labelProjectAbilities);
            resources.ApplyResources(this.tabPageProjectAnalyses, "tabPageProjectAnalyses");
            this.tabPageProjectAnalyses.Name = "tabPageProjectAnalyses";
            // 
            // textBoxProjectConcurrence
            // 
            resources.ApplyResources(this.textBoxProjectConcurrence, "textBoxProjectConcurrence");
            this.textBoxProjectConcurrence.Name = "textBoxProjectConcurrence";
            // 
            // textBoxProjectMarket
            // 
            resources.ApplyResources(this.textBoxProjectMarket, "textBoxProjectMarket");
            this.textBoxProjectMarket.Name = "textBoxProjectMarket";
            // 
            // labelProjectConcurrence
            // 
            resources.ApplyResources(this.labelProjectConcurrence, "labelProjectConcurrence");
            this.labelProjectConcurrence.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectConcurrence.Name = "labelProjectConcurrence";
            // 
            // labelProjectMarket
            // 
            resources.ApplyResources(this.labelProjectMarket, "labelProjectMarket");
            this.labelProjectMarket.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectMarket.Name = "labelProjectMarket";
            // 
            // textBoxProjectAbilities
            // 
            resources.ApplyResources(this.textBoxProjectAbilities, "textBoxProjectAbilities");
            this.textBoxProjectAbilities.Name = "textBoxProjectAbilities";
            // 
            // textBoxProjectExperience
            // 
            resources.ApplyResources(this.textBoxProjectExperience, "textBoxProjectExperience");
            this.textBoxProjectExperience.Name = "textBoxProjectExperience";
            // 
            // labelProjectExperience
            // 
            resources.ApplyResources(this.labelProjectExperience, "labelProjectExperience");
            this.labelProjectExperience.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectExperience.Name = "labelProjectExperience";
            // 
            // labelProjectAbilities
            // 
            resources.ApplyResources(this.labelProjectAbilities, "labelProjectAbilities");
            this.labelProjectAbilities.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectAbilities.Name = "labelProjectAbilities";
            // 
            // tabPageCorporate
            // 
            this.tabPageCorporate.Controls.Add(this.splitContainer10);
            resources.ApplyResources(this.tabPageCorporate, "tabPageCorporate");
            this.tabPageCorporate.Name = "tabPageCorporate";
            // 
            // tabPageFollowUp
            // 
            this.tabPageFollowUp.Controls.Add(this.splitContainer11);
            resources.ApplyResources(this.tabPageFollowUp, "tabPageFollowUp");
            this.tabPageFollowUp.Name = "tabPageFollowUp";
            // 
            // tabPageLoansDetails
            // 
            this.tabPageLoansDetails.Controls.Add(this.tclLoanDetails);
            this.tabPageLoansDetails.Controls.Add(this.loanDetailsButtonsPanel);
            this.tabPageLoansDetails.Controls.Add(this.gbxLoanDetails);
            resources.ApplyResources(this.tabPageLoansDetails, "tabPageLoansDetails");
            this.tabPageLoansDetails.Name = "tabPageLoansDetails";
            // 
            // tclLoanDetails
            // 
            this.tclLoanDetails.Controls.Add(this.tabPageInstallments);
            resources.ApplyResources(this.tclLoanDetails, "tclLoanDetails");
            this.tclLoanDetails.Name = "tclLoanDetails";
            this.tclLoanDetails.SelectedIndex = 0;
            // 
            // tabPageInstallments
            // 
            this.tabPageInstallments.Controls.Add(this.listViewLoanInstallments);
            resources.ApplyResources(this.tabPageInstallments, "tabPageInstallments");
            this.tabPageInstallments.Name = "tabPageInstallments";
            // 
            // listViewLoanInstallments
            // 
            this.listViewLoanInstallments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLoanN,
            this.columnHeaderLoanDate,
            this.columnHeaderLoanIP,
            this.columnHeaderLoanPR,
            this.columnHeaderLoanInstallmentTotal,
            this.columnHeaderLoanOLB});
            resources.ApplyResources(this.listViewLoanInstallments, "listViewLoanInstallments");
            this.listViewLoanInstallments.DoubleClickActivation = false;
            this.listViewLoanInstallments.GridLines = true;
            this.listViewLoanInstallments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewLoanInstallments.Name = "listViewLoanInstallments";
            this.listViewLoanInstallments.UseCompatibleStateImageBehavior = false;
            this.listViewLoanInstallments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLoanN
            // 
            resources.ApplyResources(this.columnHeaderLoanN, "columnHeaderLoanN");
            // 
            // columnHeaderLoanDate
            // 
            resources.ApplyResources(this.columnHeaderLoanDate, "columnHeaderLoanDate");
            // 
            // columnHeaderLoanIP
            // 
            resources.ApplyResources(this.columnHeaderLoanIP, "columnHeaderLoanIP");
            // 
            // columnHeaderLoanPR
            // 
            resources.ApplyResources(this.columnHeaderLoanPR, "columnHeaderLoanPR");
            // 
            // columnHeaderLoanInstallmentTotal
            // 
            resources.ApplyResources(this.columnHeaderLoanInstallmentTotal, "columnHeaderLoanInstallmentTotal");
            // 
            // columnHeaderLoanOLB
            // 
            resources.ApplyResources(this.columnHeaderLoanOLB, "columnHeaderLoanOLB");
            // 
            // loanDetailsButtonsPanel
            // 
            resources.ApplyResources(this.loanDetailsButtonsPanel, "loanDetailsButtonsPanel");
            this.loanDetailsButtonsPanel.Controls.Add(this.btnSaveLoan);
            this.loanDetailsButtonsPanel.Controls.Add(this.buttonLoanPreview);
            this.loanDetailsButtonsPanel.Controls.Add(this.buttonLoanDisbursment);
            this.loanDetailsButtonsPanel.Controls.Add(this.btnLoanShares);
            this.loanDetailsButtonsPanel.Controls.Add(this.btnEditSchedule);
            this.loanDetailsButtonsPanel.Name = "loanDetailsButtonsPanel";
            // 
            // btnSaveLoan
            // 
            resources.ApplyResources(this.btnSaveLoan, "btnSaveLoan");
            this.btnSaveLoan.Name = "btnSaveLoan";
            this.btnSaveLoan.Click += new System.EventHandler(this.buttonLoanSave_Click);
            // 
            // buttonLoanPreview
            // 
            resources.ApplyResources(this.buttonLoanPreview, "buttonLoanPreview");
            this.buttonLoanPreview.Name = "buttonLoanPreview";
            this.buttonLoanPreview.Click += new System.EventHandler(this.buttonLoanPreview_Click);
            // 
            // buttonLoanDisbursment
            // 
            resources.ApplyResources(this.buttonLoanDisbursment, "buttonLoanDisbursment");
            this.buttonLoanDisbursment.Name = "buttonLoanDisbursment";
            this.buttonLoanDisbursment.Tag = true;
            this.buttonLoanDisbursment.Click += new System.EventHandler(this.buttonLoanDisbursment_Click);
            // 
            // btnLoanShares
            // 
            resources.ApplyResources(this.btnLoanShares, "btnLoanShares");
            this.btnLoanShares.Name = "btnLoanShares";
            this.btnLoanShares.Click += new System.EventHandler(this.btnLoanShares_Click);
            // 
            // btnEditSchedule
            // 
            resources.ApplyResources(this.btnEditSchedule, "btnEditSchedule");
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // gbxLoanDetails
            // 
            resources.ApplyResources(this.gbxLoanDetails, "gbxLoanDetails");
            this.gbxLoanDetails.Controls.Add(this.tableLayoutPanel4);
            this.gbxLoanDetails.Name = "gbxLoanDetails";
            this.gbxLoanDetails.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.lblEconomicActivity, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.labelDateOffirstInstallment, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanAmountMinMax, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanNbOfInstallmentsMinMax, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.dtpDateOfFirstInstallment, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanGracePeriodMinMax, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanContractCode, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxLoanContractCode, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanAmount, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanInterestRate, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.dateLoanStart, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanNbOfInstallments, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanStartDate, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbLoanInterestRateMinMax, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanGracePeriod, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownLoanGracePeriod, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.nudLoanNbOfInstallments, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblDay, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbLoanOfficer, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanLoanOfficer, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanInstallmentType, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxLoanInstallmentType, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanFundingLine, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxLoanFundingLine, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelLoanPurpose, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBoxLoanPurpose, 4, 4);
            this.tableLayoutPanel4.Controls.Add(this.nudLoanAmount, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.nudInterestRate, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.rbAmortisationSchedule, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.rbStraightSchedule, 3, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // lblEconomicActivity
            // 
            resources.ApplyResources(this.lblEconomicActivity, "lblEconomicActivity");
            this.lblEconomicActivity.BackColor = System.Drawing.Color.Transparent;
            this.lblEconomicActivity.Name = "lblEconomicActivity";
            // 
            // labelDateOffirstInstallment
            // 
            resources.ApplyResources(this.labelDateOffirstInstallment, "labelDateOffirstInstallment");
            this.labelDateOffirstInstallment.BackColor = System.Drawing.Color.Transparent;
            this.labelDateOffirstInstallment.Name = "labelDateOffirstInstallment";
            // 
            // labelLoanAmountMinMax
            // 
            resources.ApplyResources(this.labelLoanAmountMinMax, "labelLoanAmountMinMax");
            this.labelLoanAmountMinMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanAmountMinMax.Name = "labelLoanAmountMinMax";
            // 
            // labelLoanNbOfInstallmentsMinMax
            // 
            resources.ApplyResources(this.labelLoanNbOfInstallmentsMinMax, "labelLoanNbOfInstallmentsMinMax");
            this.labelLoanNbOfInstallmentsMinMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanNbOfInstallmentsMinMax.Name = "labelLoanNbOfInstallmentsMinMax";
            // 
            // dtpDateOfFirstInstallment
            // 
            resources.ApplyResources(this.dtpDateOfFirstInstallment, "dtpDateOfFirstInstallment");
            this.dtpDateOfFirstInstallment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfFirstInstallment.Name = "dtpDateOfFirstInstallment";
            // 
            // labelLoanGracePeriodMinMax
            // 
            resources.ApplyResources(this.labelLoanGracePeriodMinMax, "labelLoanGracePeriodMinMax");
            this.labelLoanGracePeriodMinMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanGracePeriodMinMax.Name = "labelLoanGracePeriodMinMax";
            // 
            // labelLoanContractCode
            // 
            resources.ApplyResources(this.labelLoanContractCode, "labelLoanContractCode");
            this.labelLoanContractCode.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanContractCode.Name = "labelLoanContractCode";
            // 
            // textBoxLoanContractCode
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.textBoxLoanContractCode, 2);
            resources.ApplyResources(this.textBoxLoanContractCode, "textBoxLoanContractCode");
            this.textBoxLoanContractCode.Name = "textBoxLoanContractCode";
            this.textBoxLoanContractCode.ReadOnly = true;
            // 
            // labelLoanAmount
            // 
            resources.ApplyResources(this.labelLoanAmount, "labelLoanAmount");
            this.labelLoanAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanAmount.Name = "labelLoanAmount";
            // 
            // labelLoanInterestRate
            // 
            resources.ApplyResources(this.labelLoanInterestRate, "labelLoanInterestRate");
            this.labelLoanInterestRate.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanInterestRate.Name = "labelLoanInterestRate";
            // 
            // dateLoanStart
            // 
            resources.ApplyResources(this.dateLoanStart, "dateLoanStart");
            this.dateLoanStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLoanStart.Name = "dateLoanStart";
            this.dateLoanStart.ValueChanged += new System.EventHandler(this.dateLoanStart_ValueChanged);
            // 
            // labelLoanNbOfInstallments
            // 
            resources.ApplyResources(this.labelLoanNbOfInstallments, "labelLoanNbOfInstallments");
            this.labelLoanNbOfInstallments.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanNbOfInstallments.Name = "labelLoanNbOfInstallments";
            // 
            // labelLoanStartDate
            // 
            resources.ApplyResources(this.labelLoanStartDate, "labelLoanStartDate");
            this.labelLoanStartDate.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanStartDate.Name = "labelLoanStartDate";
            // 
            // lbLoanInterestRateMinMax
            // 
            resources.ApplyResources(this.lbLoanInterestRateMinMax, "lbLoanInterestRateMinMax");
            this.lbLoanInterestRateMinMax.Name = "lbLoanInterestRateMinMax";
            // 
            // labelLoanGracePeriod
            // 
            resources.ApplyResources(this.labelLoanGracePeriod, "labelLoanGracePeriod");
            this.labelLoanGracePeriod.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanGracePeriod.Name = "labelLoanGracePeriod";
            // 
            // numericUpDownLoanGracePeriod
            // 
            resources.ApplyResources(this.numericUpDownLoanGracePeriod, "numericUpDownLoanGracePeriod");
            this.numericUpDownLoanGracePeriod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownLoanGracePeriod.Name = "numericUpDownLoanGracePeriod";
            this.numericUpDownLoanGracePeriod.ValueChanged += new System.EventHandler(this.numericUpDownLoanGracePeriod_ValueChanged);
            // 
            // nudLoanNbOfInstallments
            // 
            resources.ApplyResources(this.nudLoanNbOfInstallments, "nudLoanNbOfInstallments");
            this.nudLoanNbOfInstallments.Name = "nudLoanNbOfInstallments";
            this.nudLoanNbOfInstallments.ValueChanged += new System.EventHandler(this.nudLoanNbOfInstallments_ValueChanged);
            // 
            // lblDay
            // 
            resources.ApplyResources(this.lblDay, "lblDay");
            this.lblDay.Name = "lblDay";
            // 
            // cmbLoanOfficer
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.cmbLoanOfficer, 2);
            this.cmbLoanOfficer.DisplayMember = "Name";
            this.cmbLoanOfficer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanOfficer.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.cmbLoanOfficer, "cmbLoanOfficer");
            this.cmbLoanOfficer.Name = "cmbLoanOfficer";
            this.cmbLoanOfficer.ValueMember = "Id";
            this.cmbLoanOfficer.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoanOfficer_SelectedIndexChanged);
            // 
            // labelLoanLoanOfficer
            // 
            resources.ApplyResources(this.labelLoanLoanOfficer, "labelLoanLoanOfficer");
            this.labelLoanLoanOfficer.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLoanOfficer.Name = "labelLoanLoanOfficer";
            // 
            // labelLoanInstallmentType
            // 
            resources.ApplyResources(this.labelLoanInstallmentType, "labelLoanInstallmentType");
            this.labelLoanInstallmentType.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanInstallmentType.Name = "labelLoanInstallmentType";
            // 
            // comboBoxLoanInstallmentType
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.comboBoxLoanInstallmentType, 2);
            this.comboBoxLoanInstallmentType.DisplayMember = "installmentType.Name";
            this.comboBoxLoanInstallmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxLoanInstallmentType, "comboBoxLoanInstallmentType");
            this.comboBoxLoanInstallmentType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxLoanInstallmentType.Name = "comboBoxLoanInstallmentType";
            this.comboBoxLoanInstallmentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoanInstallmentType_SelectedIndexChanged);
            // 
            // labelLoanFundingLine
            // 
            resources.ApplyResources(this.labelLoanFundingLine, "labelLoanFundingLine");
            this.labelLoanFundingLine.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanFundingLine.Name = "labelLoanFundingLine";
            // 
            // comboBoxLoanFundingLine
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.comboBoxLoanFundingLine, 2);
            this.comboBoxLoanFundingLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoanFundingLine.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.comboBoxLoanFundingLine, "comboBoxLoanFundingLine");
            this.comboBoxLoanFundingLine.Name = "comboBoxLoanFundingLine";
            this.comboBoxLoanFundingLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoanFundingLine_SelectedIndexChanged);
            // 
            // labelLoanPurpose
            // 
            resources.ApplyResources(this.labelLoanPurpose, "labelLoanPurpose");
            this.labelLoanPurpose.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanPurpose.Name = "labelLoanPurpose";
            // 
            // textBoxLoanPurpose
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.textBoxLoanPurpose, 3);
            resources.ApplyResources(this.textBoxLoanPurpose, "textBoxLoanPurpose");
            this.textBoxLoanPurpose.Name = "textBoxLoanPurpose";
            this.tableLayoutPanel4.SetRowSpan(this.textBoxLoanPurpose, 3);
            // 
            // nudLoanAmount
            // 
            resources.ApplyResources(this.nudLoanAmount, "nudLoanAmount");
            this.nudLoanAmount.Name = "nudLoanAmount";
            this.nudLoanAmount.ValueChanged += new System.EventHandler(this.nudLoanAmount_ValueChanged);
            this.nudLoanAmount.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            this.nudLoanAmount.Leave += new System.EventHandler(this.nudLoanAmount_Leave);
            // 
            // nudInterestRate
            // 
            this.nudInterestRate.DecimalPlaces = 10;
            this.nudInterestRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.nudInterestRate, "nudInterestRate");
            this.nudInterestRate.Name = "nudInterestRate";
            this.nudInterestRate.ValueChanged += new System.EventHandler(this.nudInterestRate_ValueChanged);
            this.nudInterestRate.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            // 
            // rbAmortisationSchedule
            // 
            resources.ApplyResources(this.rbAmortisationSchedule, "rbAmortisationSchedule");
            this.rbAmortisationSchedule.Checked = true;
            this.rbAmortisationSchedule.Name = "rbAmortisationSchedule";
            this.rbAmortisationSchedule.TabStop = true;
            this.rbAmortisationSchedule.UseVisualStyleBackColor = true;
            // 
            // rbStraightSchedule
            // 
            resources.ApplyResources(this.rbStraightSchedule, "rbStraightSchedule");
            this.rbStraightSchedule.Name = "rbStraightSchedule";
            this.rbStraightSchedule.UseVisualStyleBackColor = true;
            // 
            // tabPageAdvancedSettings
            // 
            this.tabPageAdvancedSettings.Controls.Add(this.tableLayoutPanel6);
            this.tabPageAdvancedSettings.Controls.Add(this.tableLayoutPanel9);
            resources.ApplyResources(this.tabPageAdvancedSettings, "tabPageAdvancedSettings");
            this.tabPageAdvancedSettings.Name = "tabPageAdvancedSettings";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBoxEntryFees, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnUpdateSettings, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.groupBox2, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.labelComments, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.textBoxComments, 1, 6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.tableLayoutPanel6.SetColumnSpan(this.flowLayoutPanel5, 5);
            this.flowLayoutPanel5.Controls.Add(this.groupBoxAnticipatedRepaymentPenalties);
            this.flowLayoutPanel5.Controls.Add(this.groupBoxLoanLateFees);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // groupBoxAnticipatedRepaymentPenalties
            // 
            resources.ApplyResources(this.groupBoxAnticipatedRepaymentPenalties, "groupBoxAnticipatedRepaymentPenalties");
            this.groupBoxAnticipatedRepaymentPenalties.Controls.Add(this.tableLayoutPanel7);
            this.groupBoxAnticipatedRepaymentPenalties.Name = "groupBoxAnticipatedRepaymentPenalties";
            this.groupBoxAnticipatedRepaymentPenalties.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.lblEarlyPartialRepaimentBase, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblEarlyTotalRepaimentBase, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblLoanAnticipatedPartialFeesMinMax, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.lbATR, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tbLoanAnticipatedPartialFees, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBoxLoanAnticipatedTotalFees, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbAPR, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.labelLoanAnticipatedTotalFeesMinMax, 2, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // lblEarlyPartialRepaimentBase
            // 
            resources.ApplyResources(this.lblEarlyPartialRepaimentBase, "lblEarlyPartialRepaimentBase");
            this.lblEarlyPartialRepaimentBase.BackColor = System.Drawing.Color.Transparent;
            this.lblEarlyPartialRepaimentBase.Name = "lblEarlyPartialRepaimentBase";
            // 
            // lblEarlyTotalRepaimentBase
            // 
            resources.ApplyResources(this.lblEarlyTotalRepaimentBase, "lblEarlyTotalRepaimentBase");
            this.lblEarlyTotalRepaimentBase.BackColor = System.Drawing.Color.Transparent;
            this.lblEarlyTotalRepaimentBase.Name = "lblEarlyTotalRepaimentBase";
            // 
            // lblLoanAnticipatedPartialFeesMinMax
            // 
            resources.ApplyResources(this.lblLoanAnticipatedPartialFeesMinMax, "lblLoanAnticipatedPartialFeesMinMax");
            this.lblLoanAnticipatedPartialFeesMinMax.BackColor = System.Drawing.Color.Transparent;
            this.lblLoanAnticipatedPartialFeesMinMax.Name = "lblLoanAnticipatedPartialFeesMinMax";
            // 
            // lbATR
            // 
            resources.ApplyResources(this.lbATR, "lbATR");
            this.lbATR.Name = "lbATR";
            // 
            // tbLoanAnticipatedPartialFees
            // 
            resources.ApplyResources(this.tbLoanAnticipatedPartialFees, "tbLoanAnticipatedPartialFees");
            this.tbLoanAnticipatedPartialFees.Name = "tbLoanAnticipatedPartialFees";
            this.tbLoanAnticipatedPartialFees.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            this.tbLoanAnticipatedPartialFees.TextChanged += new System.EventHandler(this.textBoxLoanAnticipatedPartialFees_TextChanged);
            this.tbLoanAnticipatedPartialFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocAmount_KeyPress);
            this.tbLoanAnticipatedPartialFees.Leave += new System.EventHandler(this.textBoxLoanAnticipatedPartialFees_Leave);
            // 
            // textBoxLoanAnticipatedTotalFees
            // 
            resources.ApplyResources(this.textBoxLoanAnticipatedTotalFees, "textBoxLoanAnticipatedTotalFees");
            this.textBoxLoanAnticipatedTotalFees.Name = "textBoxLoanAnticipatedTotalFees";
            this.textBoxLoanAnticipatedTotalFees.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            this.textBoxLoanAnticipatedTotalFees.TextChanged += new System.EventHandler(this.textBoxLoanAnticipatedTotalFees_TextChanged);
            this.textBoxLoanAnticipatedTotalFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocAmount_KeyPress);
            this.textBoxLoanAnticipatedTotalFees.Leave += new System.EventHandler(this.textBoxLoanAnticipatedFees_Leave);
            // 
            // lbAPR
            // 
            resources.ApplyResources(this.lbAPR, "lbAPR");
            this.lbAPR.Name = "lbAPR";
            // 
            // labelLoanAnticipatedTotalFeesMinMax
            // 
            resources.ApplyResources(this.labelLoanAnticipatedTotalFeesMinMax, "labelLoanAnticipatedTotalFeesMinMax");
            this.labelLoanAnticipatedTotalFeesMinMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanAnticipatedTotalFeesMinMax.Name = "labelLoanAnticipatedTotalFeesMinMax";
            // 
            // groupBoxLoanLateFees
            // 
            resources.ApplyResources(this.groupBoxLoanLateFees, "groupBoxLoanLateFees");
            this.groupBoxLoanLateFees.Controls.Add(this.tableLayoutPanel8);
            this.groupBoxLoanLateFees.Name = "groupBoxLoanLateFees";
            this.groupBoxLoanLateFees.TabStop = false;
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.labelLoanLateFeesOnOverduePrincipalMinMax, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelLoanLateFeesOnAmountMinMax, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelLoanLateFeesOnAmount, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBoxLoanLateFeesOnAmount, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBoxLoanLateFeesOnOverduePrincipal, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelLoanLateFeesOnOverduePrincipal, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelLoanLateFeesOnOLB, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBoxLoanLateFeesOnOLB, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelLoanLateFeesOnOLBMinMax, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelLoanLateFeesOnOverdueInterest, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.textBoxLoanLateFeesOnOverdueInterest, 4, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelLoanLateFeesOnOverdueInterestMinMax, 5, 1);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // labelLoanLateFeesOnOverduePrincipalMinMax
            // 
            resources.ApplyResources(this.labelLoanLateFeesOnOverduePrincipalMinMax, "labelLoanLateFeesOnOverduePrincipalMinMax");
            this.labelLoanLateFeesOnOverduePrincipalMinMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLateFeesOnOverduePrincipalMinMax.Name = "labelLoanLateFeesOnOverduePrincipalMinMax";
            // 
            // labelLoanLateFeesOnAmountMinMax
            // 
            resources.ApplyResources(this.labelLoanLateFeesOnAmountMinMax, "labelLoanLateFeesOnAmountMinMax");
            this.labelLoanLateFeesOnAmountMinMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLateFeesOnAmountMinMax.Name = "labelLoanLateFeesOnAmountMinMax";
            // 
            // labelLoanLateFeesOnAmount
            // 
            resources.ApplyResources(this.labelLoanLateFeesOnAmount, "labelLoanLateFeesOnAmount");
            this.labelLoanLateFeesOnAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLateFeesOnAmount.Name = "labelLoanLateFeesOnAmount";
            // 
            // textBoxLoanLateFeesOnAmount
            // 
            resources.ApplyResources(this.textBoxLoanLateFeesOnAmount, "textBoxLoanLateFeesOnAmount");
            this.textBoxLoanLateFeesOnAmount.Name = "textBoxLoanLateFeesOnAmount";
            this.textBoxLoanLateFeesOnAmount.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            this.textBoxLoanLateFeesOnAmount.TextChanged += new System.EventHandler(this.textBoxLoanLateFeesOnAmount_TextChanged);
            this.textBoxLoanLateFeesOnAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocAmount_KeyPress);
            this.textBoxLoanLateFeesOnAmount.Leave += new System.EventHandler(this.textBoxLoanLateFeesOnAmount_Leave);
            // 
            // textBoxLoanLateFeesOnOverduePrincipal
            // 
            resources.ApplyResources(this.textBoxLoanLateFeesOnOverduePrincipal, "textBoxLoanLateFeesOnOverduePrincipal");
            this.textBoxLoanLateFeesOnOverduePrincipal.Name = "textBoxLoanLateFeesOnOverduePrincipal";
            this.textBoxLoanLateFeesOnOverduePrincipal.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            this.textBoxLoanLateFeesOnOverduePrincipal.TextChanged += new System.EventHandler(this.textBoxLoanLateFeesOnOverduePrincipal_TextChanged);
            this.textBoxLoanLateFeesOnOverduePrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocAmount_KeyPress);
            this.textBoxLoanLateFeesOnOverduePrincipal.Leave += new System.EventHandler(this.textBoxLoanLateFeesOnOverduePrincipal_Leave);
            // 
            // labelLoanLateFeesOnOverduePrincipal
            // 
            resources.ApplyResources(this.labelLoanLateFeesOnOverduePrincipal, "labelLoanLateFeesOnOverduePrincipal");
            this.labelLoanLateFeesOnOverduePrincipal.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLateFeesOnOverduePrincipal.Name = "labelLoanLateFeesOnOverduePrincipal";
            // 
            // labelLoanLateFeesOnOLB
            // 
            resources.ApplyResources(this.labelLoanLateFeesOnOLB, "labelLoanLateFeesOnOLB");
            this.labelLoanLateFeesOnOLB.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLateFeesOnOLB.Name = "labelLoanLateFeesOnOLB";
            this.labelLoanLateFeesOnOLB.Tag = "";
            // 
            // textBoxLoanLateFeesOnOLB
            // 
            resources.ApplyResources(this.textBoxLoanLateFeesOnOLB, "textBoxLoanLateFeesOnOLB");
            this.textBoxLoanLateFeesOnOLB.Name = "textBoxLoanLateFeesOnOLB";
            this.textBoxLoanLateFeesOnOLB.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            this.textBoxLoanLateFeesOnOLB.TextChanged += new System.EventHandler(this.textBoxLoanLateFeesOnOLB_TextChanged);
            this.textBoxLoanLateFeesOnOLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocAmount_KeyPress);
            this.textBoxLoanLateFeesOnOLB.Leave += new System.EventHandler(this.textBoxLoanLateFeesOnOLB_Leave);
            // 
            // labelLoanLateFeesOnOLBMinMax
            // 
            resources.ApplyResources(this.labelLoanLateFeesOnOLBMinMax, "labelLoanLateFeesOnOLBMinMax");
            this.labelLoanLateFeesOnOLBMinMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLateFeesOnOLBMinMax.Name = "labelLoanLateFeesOnOLBMinMax";
            // 
            // labelLoanLateFeesOnOverdueInterest
            // 
            resources.ApplyResources(this.labelLoanLateFeesOnOverdueInterest, "labelLoanLateFeesOnOverdueInterest");
            this.labelLoanLateFeesOnOverdueInterest.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLateFeesOnOverdueInterest.Name = "labelLoanLateFeesOnOverdueInterest";
            // 
            // textBoxLoanLateFeesOnOverdueInterest
            // 
            resources.ApplyResources(this.textBoxLoanLateFeesOnOverdueInterest, "textBoxLoanLateFeesOnOverdueInterest");
            this.textBoxLoanLateFeesOnOverdueInterest.Name = "textBoxLoanLateFeesOnOverdueInterest";
            this.textBoxLoanLateFeesOnOverdueInterest.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            this.textBoxLoanLateFeesOnOverdueInterest.TextChanged += new System.EventHandler(this.textBoxLoanLateFeesOnOverdueInterest_TextChanged);
            this.textBoxLoanLateFeesOnOverdueInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocAmount_KeyPress);
            this.textBoxLoanLateFeesOnOverdueInterest.Leave += new System.EventHandler(this.textBoxLoanLateFeesOnOverdueInterest_Leave);
            // 
            // labelLoanLateFeesOnOverdueInterestMinMax
            // 
            resources.ApplyResources(this.labelLoanLateFeesOnOverdueInterestMinMax, "labelLoanLateFeesOnOverdueInterestMinMax");
            this.labelLoanLateFeesOnOverdueInterestMinMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanLateFeesOnOverdueInterestMinMax.Name = "labelLoanLateFeesOnOverdueInterestMinMax";
            // 
            // groupBoxEntryFees
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.groupBoxEntryFees, 5);
            this.groupBoxEntryFees.Controls.Add(this.lvEntryFees);
            this.groupBoxEntryFees.Controls.Add(this.lblMinMaxEntryFees);
            this.groupBoxEntryFees.Controls.Add(this.numEntryFees);
            resources.ApplyResources(this.groupBoxEntryFees, "groupBoxEntryFees");
            this.groupBoxEntryFees.Name = "groupBoxEntryFees";
            this.groupBoxEntryFees.TabStop = false;
            // 
            // lvEntryFees
            // 
            this.lvEntryFees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colValue,
            this.colType,
            this.colAmount});
            resources.ApplyResources(this.lvEntryFees, "lvEntryFees");
            this.lvEntryFees.DoubleClickActivation = true;
            this.lvEntryFees.FullRowSelect = true;
            this.lvEntryFees.GridLines = true;
            this.lvEntryFees.Name = "lvEntryFees";
            this.lvEntryFees.UseCompatibleStateImageBehavior = false;
            this.lvEntryFees.View = System.Windows.Forms.View.Details;
            this.lvEntryFees.SubItemClicked += new OpenCBS.GUI.UserControl.SubItemEventHandler(this.lvEntryFees_SubItemClicked);
            this.lvEntryFees.SubItemEndEditing += new OpenCBS.GUI.UserControl.SubItemEndEditingEventHandler(this.lvEntryFees_SubItemEndEditing);
            this.lvEntryFees.Click += new System.EventHandler(this.lvEntryFees_Click);
            // 
            // colName
            // 
            resources.ApplyResources(this.colName, "colName");
            // 
            // colValue
            // 
            resources.ApplyResources(this.colValue, "colValue");
            // 
            // colType
            // 
            resources.ApplyResources(this.colType, "colType");
            // 
            // colAmount
            // 
            resources.ApplyResources(this.colAmount, "colAmount");
            // 
            // lblMinMaxEntryFees
            // 
            resources.ApplyResources(this.lblMinMaxEntryFees, "lblMinMaxEntryFees");
            this.lblMinMaxEntryFees.Name = "lblMinMaxEntryFees";
            this.lblMinMaxEntryFees.TextChanged += new System.EventHandler(this.lbCompAmountPercentMinMax_TextChanged);
            // 
            // numEntryFees
            // 
            resources.ApplyResources(this.numEntryFees, "numEntryFees");
            this.numEntryFees.Name = "numEntryFees";
            // 
            // btnUpdateSettings
            // 
            resources.ApplyResources(this.btnUpdateSettings, "btnUpdateSettings");
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Click += new System.EventHandler(this.buttonLoanSave_Click);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.groupBox2, 5);
            this.groupBox2.Controls.Add(this.tableLayoutPanel10);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            resources.ApplyResources(this.tableLayoutPanel10, "tableLayoutPanel10");
            this.tableLayoutPanel10.Controls.Add(this.lbCompulsorySavingsAmount, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.lbCompulsorySavings, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.numCompulsoryAmountPercent, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.cmbCompulsorySaving, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.linkCompulsorySavings, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.lbCompAmountPercentMinMax, 2, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            // 
            // lbCompulsorySavingsAmount
            // 
            resources.ApplyResources(this.lbCompulsorySavingsAmount, "lbCompulsorySavingsAmount");
            this.lbCompulsorySavingsAmount.Name = "lbCompulsorySavingsAmount";
            // 
            // lbCompulsorySavings
            // 
            resources.ApplyResources(this.lbCompulsorySavings, "lbCompulsorySavings");
            this.lbCompulsorySavings.Name = "lbCompulsorySavings";
            // 
            // numCompulsoryAmountPercent
            // 
            resources.ApplyResources(this.numCompulsoryAmountPercent, "numCompulsoryAmountPercent");
            this.numCompulsoryAmountPercent.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCompulsoryAmountPercent.Name = "numCompulsoryAmountPercent";
            // 
            // cmbCompulsorySaving
            // 
            this.cmbCompulsorySaving.DisplayMember = "Value";
            this.cmbCompulsorySaving.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompulsorySaving.FormattingEnabled = true;
            resources.ApplyResources(this.cmbCompulsorySaving, "cmbCompulsorySaving");
            this.cmbCompulsorySaving.Name = "cmbCompulsorySaving";
            this.cmbCompulsorySaving.ValueMember = "Key";
            this.cmbCompulsorySaving.SelectedIndexChanged += new System.EventHandler(this.cmbCompulsorySaving_SelectedIndexChanged);
            // 
            // linkCompulsorySavings
            // 
            this.linkCompulsorySavings.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.linkCompulsorySavings, "linkCompulsorySavings");
            this.linkCompulsorySavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.linkCompulsorySavings.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.linkCompulsorySavings.Name = "linkCompulsorySavings";
            this.linkCompulsorySavings.TabStop = true;
            this.linkCompulsorySavings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCompulsorySavings_LinkClicked);
            // 
            // lbCompAmountPercentMinMax
            // 
            resources.ApplyResources(this.lbCompAmountPercentMinMax, "lbCompAmountPercentMinMax");
            this.lbCompAmountPercentMinMax.Name = "lbCompAmountPercentMinMax";
            this.lbCompAmountPercentMinMax.TextChanged += new System.EventHandler(this.lbCompAmountPercentMinMax_TextChanged);
            // 
            // labelComments
            // 
            resources.ApplyResources(this.labelComments, "labelComments");
            this.labelComments.Name = "labelComments";
            // 
            // textBoxComments
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.textBoxComments, 3);
            resources.ApplyResources(this.textBoxComments, "textBoxComments");
            this.textBoxComments.Name = "textBoxComments";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.labelLocAmount, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tbLocAmount, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.labelLocMin, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.labelLocMax, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.labelLocMinAmount, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.labelLocMaxAmount, 3, 1);
            this.tableLayoutPanel9.Controls.Add(this.lblInsuranceMin, 8, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblInsuranceMax, 8, 1);
            this.tableLayoutPanel9.Controls.Add(this.label5, 7, 1);
            this.tableLayoutPanel9.Controls.Add(this.label4, 7, 0);
            this.tableLayoutPanel9.Controls.Add(this.tbInsurance, 6, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblCreditInsurance, 5, 0);
            this.tableLayoutPanel9.Controls.Add(this.label6, 9, 0);
            this.tableLayoutPanel9.Controls.Add(this.label7, 9, 1);
            this.tableLayoutPanel9.Controls.Add(this.lblLocCurrencyMin, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblLocCurrencyMax, 4, 1);
            this.tableLayoutPanel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // labelLocAmount
            // 
            resources.ApplyResources(this.labelLocAmount, "labelLocAmount");
            this.labelLocAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelLocAmount.Name = "labelLocAmount";
            this.tableLayoutPanel9.SetRowSpan(this.labelLocAmount, 2);
            // 
            // tbLocAmount
            // 
            resources.ApplyResources(this.tbLocAmount, "tbLocAmount");
            this.tbLocAmount.Name = "tbLocAmount";
            this.tableLayoutPanel9.SetRowSpan(this.tbLocAmount, 2);
            this.tbLocAmount.EnabledChanged += new System.EventHandler(this.nudLoanAmount_EnabledChanged);
            this.tbLocAmount.TextChanged += new System.EventHandler(this.textBoxLocAmount_TextChanged);
            this.tbLocAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocAmount_KeyPress);
            this.tbLocAmount.Leave += new System.EventHandler(this.textBoxLocAmount_Leave);
            // 
            // labelLocMin
            // 
            resources.ApplyResources(this.labelLocMin, "labelLocMin");
            this.labelLocMin.BackColor = System.Drawing.Color.Transparent;
            this.labelLocMin.Name = "labelLocMin";
            // 
            // labelLocMax
            // 
            resources.ApplyResources(this.labelLocMax, "labelLocMax");
            this.labelLocMax.BackColor = System.Drawing.Color.Transparent;
            this.labelLocMax.Name = "labelLocMax";
            // 
            // labelLocMinAmount
            // 
            resources.ApplyResources(this.labelLocMinAmount, "labelLocMinAmount");
            this.labelLocMinAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelLocMinAmount.Name = "labelLocMinAmount";
            // 
            // labelLocMaxAmount
            // 
            resources.ApplyResources(this.labelLocMaxAmount, "labelLocMaxAmount");
            this.labelLocMaxAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelLocMaxAmount.Name = "labelLocMaxAmount";
            // 
            // lblInsuranceMin
            // 
            resources.ApplyResources(this.lblInsuranceMin, "lblInsuranceMin");
            this.lblInsuranceMin.Name = "lblInsuranceMin";
            // 
            // lblInsuranceMax
            // 
            resources.ApplyResources(this.lblInsuranceMax, "lblInsuranceMax");
            this.lblInsuranceMax.Name = "lblInsuranceMax";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbInsurance
            // 
            resources.ApplyResources(this.tbInsurance, "tbInsurance");
            this.tbInsurance.Name = "tbInsurance";
            this.tableLayoutPanel9.SetRowSpan(this.tbInsurance, 2);
            this.tbInsurance.TextChanged += new System.EventHandler(this.tbInsurance_TextChanged);
            this.tbInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocAmount_KeyPress);
            this.tbInsurance.Leave += new System.EventHandler(this.tbInsurance_Leave);
            // 
            // lblCreditInsurance
            // 
            resources.ApplyResources(this.lblCreditInsurance, "lblCreditInsurance");
            this.lblCreditInsurance.Name = "lblCreditInsurance";
            this.tableLayoutPanel9.SetRowSpan(this.lblCreditInsurance, 2);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblLocCurrencyMin
            // 
            resources.ApplyResources(this.lblLocCurrencyMin, "lblLocCurrencyMin");
            this.lblLocCurrencyMin.BackColor = System.Drawing.Color.Transparent;
            this.lblLocCurrencyMin.Name = "lblLocCurrencyMin";
            // 
            // lblLocCurrencyMax
            // 
            resources.ApplyResources(this.lblLocCurrencyMax, "lblLocCurrencyMax");
            this.lblLocCurrencyMax.BackColor = System.Drawing.Color.Transparent;
            this.lblLocCurrencyMax.Name = "lblLocCurrencyMax";
            // 
            // tabPageCreditCommitee
            // 
            this.tabPageCreditCommitee.Controls.Add(this.flowLayoutPanel7);
            this.tabPageCreditCommitee.Controls.Add(this.tableLayoutPanel11);
            resources.ApplyResources(this.tabPageCreditCommitee, "tabPageCreditCommitee");
            this.tabPageCreditCommitee.Name = "tabPageCreditCommitee";
            // 
            // flowLayoutPanel7
            // 
            resources.ApplyResources(this.flowLayoutPanel7, "flowLayoutPanel7");
            this.flowLayoutPanel7.Controls.Add(this.buttonCreditCommiteeSaveDecision);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            // 
            // buttonCreditCommiteeSaveDecision
            // 
            resources.ApplyResources(this.buttonCreditCommiteeSaveDecision, "buttonCreditCommiteeSaveDecision");
            this.buttonCreditCommiteeSaveDecision.Name = "buttonCreditCommiteeSaveDecision";
            this.buttonCreditCommiteeSaveDecision.Click += new System.EventHandler(this.buttonCreditCommiteeSaveDecision_Click);
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(this.tableLayoutPanel11, "tableLayoutPanel11");
            this.tableLayoutPanel11.Controls.Add(this.lblCCStatus, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.pnlCCStatus, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.labelCreditCommiteeDate, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.dateTimePickerCreditCommitee, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.labelCreditCommiteeComment, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.labelCreditCommiteeCode, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.textBoxCreditCommiteeComment, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.tBCreditCommitteeCode, 1, 2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            // 
            // lblCCStatus
            // 
            resources.ApplyResources(this.lblCCStatus, "lblCCStatus");
            this.lblCCStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCCStatus.Name = "lblCCStatus";
            // 
            // pnlCCStatus
            // 
            resources.ApplyResources(this.pnlCCStatus, "pnlCCStatus");
            this.pnlCCStatus.Controls.Add(this.flowLayoutPanel6);
            this.pnlCCStatus.Name = "pnlCCStatus";
            // 
            // flowLayoutPanel6
            // 
            resources.ApplyResources(this.flowLayoutPanel6, "flowLayoutPanel6");
            this.flowLayoutPanel6.Controls.Add(this.cmbContractStatus);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            // 
            // cmbContractStatus
            // 
            this.cmbContractStatus.DisplayMember = "Value";
            this.cmbContractStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContractStatus.FormattingEnabled = true;
            resources.ApplyResources(this.cmbContractStatus, "cmbContractStatus");
            this.cmbContractStatus.Name = "cmbContractStatus";
            this.cmbContractStatus.ValueMember = "Key";
            // 
            // labelCreditCommiteeDate
            // 
            resources.ApplyResources(this.labelCreditCommiteeDate, "labelCreditCommiteeDate");
            this.labelCreditCommiteeDate.BackColor = System.Drawing.Color.Transparent;
            this.labelCreditCommiteeDate.Name = "labelCreditCommiteeDate";
            // 
            // dateTimePickerCreditCommitee
            // 
            this.dateTimePickerCreditCommitee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePickerCreditCommitee, "dateTimePickerCreditCommitee");
            this.dateTimePickerCreditCommitee.Name = "dateTimePickerCreditCommitee";
            // 
            // labelCreditCommiteeComment
            // 
            resources.ApplyResources(this.labelCreditCommiteeComment, "labelCreditCommiteeComment");
            this.labelCreditCommiteeComment.BackColor = System.Drawing.Color.Transparent;
            this.labelCreditCommiteeComment.Name = "labelCreditCommiteeComment";
            // 
            // labelCreditCommiteeCode
            // 
            resources.ApplyResources(this.labelCreditCommiteeCode, "labelCreditCommiteeCode");
            this.labelCreditCommiteeCode.BackColor = System.Drawing.Color.Transparent;
            this.labelCreditCommiteeCode.Name = "labelCreditCommiteeCode";
            // 
            // textBoxCreditCommiteeComment
            // 
            resources.ApplyResources(this.textBoxCreditCommiteeComment, "textBoxCreditCommiteeComment");
            this.textBoxCreditCommiteeComment.Name = "textBoxCreditCommiteeComment";
            // 
            // tBCreditCommitteeCode
            // 
            resources.ApplyResources(this.tBCreditCommitteeCode, "tBCreditCommitteeCode");
            this.tBCreditCommitteeCode.Name = "tBCreditCommitteeCode";
            // 
            // tabPageLoanRepayment
            // 
            this.tabPageLoanRepayment.Controls.Add(this.tabControlRepayments);
            this.tabPageLoanRepayment.Controls.Add(this.richTextBoxStatus);
            this.tabPageLoanRepayment.Controls.Add(this.lblLoanStatus);
            resources.ApplyResources(this.tabPageLoanRepayment, "tabPageLoanRepayment");
            this.tabPageLoanRepayment.Name = "tabPageLoanRepayment";
            // 
            // tabControlRepayments
            // 
            this.tabControlRepayments.Controls.Add(this.tabPageRepayments);
            this.tabControlRepayments.Controls.Add(this.tabPageEvents);
            resources.ApplyResources(this.tabControlRepayments, "tabControlRepayments");
            this.tabControlRepayments.ImageList = this.imageListTab;
            this.tabControlRepayments.Name = "tabControlRepayments";
            this.tabControlRepayments.SelectedIndex = 0;
            // 
            // tabPageRepayments
            // 
            this.tabPageRepayments.Controls.Add(this.lvLoansRepayments);
            this.tabPageRepayments.Controls.Add(this.flowLayoutPanel8);
            resources.ApplyResources(this.tabPageRepayments, "tabPageRepayments");
            this.tabPageRepayments.Name = "tabPageRepayments";
            // 
            // lvLoansRepayments
            // 
            this.lvLoansRepayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeaderLateDays,
            this.columnHeaderComment});
            resources.ApplyResources(this.lvLoansRepayments, "lvLoansRepayments");
            this.lvLoansRepayments.DoubleClickActivation = false;
            this.lvLoansRepayments.FullRowSelect = true;
            this.lvLoansRepayments.GridLines = true;
            this.lvLoansRepayments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLoansRepayments.MultiSelect = false;
            this.lvLoansRepayments.Name = "lvLoansRepayments";
            this.lvLoansRepayments.UseCompatibleStateImageBehavior = false;
            this.lvLoansRepayments.View = System.Windows.Forms.View.Details;
            this.lvLoansRepayments.SelectedIndexChanged += new System.EventHandler(this.listViewLoansRepayments_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // columnHeaderLateDays
            // 
            resources.ApplyResources(this.columnHeaderLateDays, "columnHeaderLateDays");
            // 
            // columnHeaderComment
            // 
            resources.ApplyResources(this.columnHeaderComment, "columnHeaderComment");
            // 
            // flowLayoutPanel8
            // 
            resources.ApplyResources(this.flowLayoutPanel8, "flowLayoutPanel8");
            this.flowLayoutPanel8.Controls.Add(this.buttonLoanRepaymentRepay);
            this.flowLayoutPanel8.Controls.Add(this.buttonLoanReschedule);
            this.flowLayoutPanel8.Controls.Add(this.buttonManualSchedule);
            this.flowLayoutPanel8.Controls.Add(this.buttonAddTranche);
            this.flowLayoutPanel8.Controls.Add(this.btnWriteOff);
            this.flowLayoutPanel8.Controls.Add(this.btnRepaymentNotice);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            // 
            // buttonLoanRepaymentRepay
            // 
            resources.ApplyResources(this.buttonLoanRepaymentRepay, "buttonLoanRepaymentRepay");
            this.buttonLoanRepaymentRepay.Name = "buttonLoanRepaymentRepay";
            this.buttonLoanRepaymentRepay.Click += new System.EventHandler(this.buttonLoanRepaymentRepay_Click);
            // 
            // buttonLoanReschedule
            // 
            resources.ApplyResources(this.buttonLoanReschedule, "buttonLoanReschedule");
            this.buttonLoanReschedule.Name = "buttonLoanReschedule";
            this.buttonLoanReschedule.Click += new System.EventHandler(this.buttonLoanReschedule_Click);
            // 
            // buttonManualSchedule
            // 
            resources.ApplyResources(this.buttonManualSchedule, "buttonManualSchedule");
            this.buttonManualSchedule.Name = "buttonManualSchedule";
            this.buttonManualSchedule.Click += new System.EventHandler(this.buttonManualSchedule_Click);
            // 
            // buttonAddTranche
            // 
            resources.ApplyResources(this.buttonAddTranche, "buttonAddTranche");
            this.buttonAddTranche.Name = "buttonAddTranche";
            this.buttonAddTranche.Click += new System.EventHandler(this.buttonAddTranche_Click);
            // 
            // btnWriteOff
            // 
            resources.ApplyResources(this.btnWriteOff, "btnWriteOff");
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // btnRepaymentNotice
            // 
            resources.ApplyResources(this.btnRepaymentNotice, "btnRepaymentNotice");
            this.btnRepaymentNotice.Name = "btnRepaymentNotice";
            this.btnRepaymentNotice.Click += new System.EventHandler(this.btnRepaymentNotice_Click);
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Controls.Add(this.lvEvents);
            this.tabPageEvents.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPageEvents, "tabPageEvents");
            this.tabPageEvents.Name = "tabPageEvents";
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.EntryDate,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.colCommissions,
            this.colPenalties,
            this.colOverduePrincipal,
            this.colOverdueDays,
            this.columnHeader16,
            this.columnHeader18,
            this.ExportedDate,
            this.colId,
            this.colNumber,
            this.columnHeader30,
            this.colPaymentMethod,
            this.colCancelDate1,
            this.colIsDeleted});
            resources.ApplyResources(this.lvEvents, "lvEvents");
            this.lvEvents.DoubleClickActivation = false;
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // EntryDate
            // 
            resources.ApplyResources(this.EntryDate, "EntryDate");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // columnHeader13
            // 
            resources.ApplyResources(this.columnHeader13, "columnHeader13");
            // 
            // columnHeader14
            // 
            resources.ApplyResources(this.columnHeader14, "columnHeader14");
            // 
            // colCommissions
            // 
            resources.ApplyResources(this.colCommissions, "colCommissions");
            // 
            // colPenalties
            // 
            resources.ApplyResources(this.colPenalties, "colPenalties");
            // 
            // colOverduePrincipal
            // 
            resources.ApplyResources(this.colOverduePrincipal, "colOverduePrincipal");
            // 
            // colOverdueDays
            // 
            resources.ApplyResources(this.colOverdueDays, "colOverdueDays");
            // 
            // columnHeader16
            // 
            resources.ApplyResources(this.columnHeader16, "columnHeader16");
            // 
            // columnHeader18
            // 
            resources.ApplyResources(this.columnHeader18, "columnHeader18");
            // 
            // ExportedDate
            // 
            resources.ApplyResources(this.ExportedDate, "ExportedDate");
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            // 
            // colNumber
            // 
            resources.ApplyResources(this.colNumber, "colNumber");
            // 
            // columnHeader30
            // 
            resources.ApplyResources(this.columnHeader30, "columnHeader30");
            // 
            // colPaymentMethod
            // 
            resources.ApplyResources(this.colPaymentMethod, "colPaymentMethod");
            // 
            // colCancelDate1
            // 
            resources.ApplyResources(this.colCancelDate1, "colCancelDate1");
            // 
            // colIsDeleted
            // 
            resources.ApplyResources(this.colIsDeleted, "colIsDeleted");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWaiveFee);
            this.groupBox1.Controls.Add(this.btnDeleteEvent);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnWaiveFee
            // 
            resources.ApplyResources(this.btnWaiveFee, "btnWaiveFee");
            this.btnWaiveFee.Name = "btnWaiveFee";
            this.btnWaiveFee.Click += new System.EventHandler(this.btnWaiveFee_Click);
            // 
            // btnDeleteEvent
            // 
            resources.ApplyResources(this.btnDeleteEvent, "btnDeleteEvent");
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Click += new System.EventHandler(this.buttonDeleteEvent_Click);
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "client_bouton.ico");
            this.imageListTab.Images.SetKeyName(1, "credit_contract_bouton.ico");
            this.imageListTab.Images.SetKeyName(2, "edit.ico");
            this.imageListTab.Images.SetKeyName(3, "monthly_cash_flow.ico");
            this.imageListTab.Images.SetKeyName(4, "repayments.ico");
            // 
            // richTextBoxStatus
            // 
            resources.ApplyResources(this.richTextBoxStatus, "richTextBoxStatus");
            this.richTextBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.ReadOnly = true;
            // 
            // lblLoanStatus
            // 
            resources.ApplyResources(this.lblLoanStatus, "lblLoanStatus");
            this.lblLoanStatus.Name = "lblLoanStatus";
            // 
            // tabPageLoanGuarantees
            // 
            this.tabPageLoanGuarantees.Controls.Add(this.splitContainer1);
            resources.ApplyResources(this.tabPageLoanGuarantees, "tabPageLoanGuarantees");
            this.tabPageLoanGuarantees.Name = "tabPageLoanGuarantees";
            // 
            // tabPageSavingDetails
            // 
            this.tabPageSavingDetails.Controls.Add(this.tabControlSavingsDetails);
            this.tabPageSavingDetails.Controls.Add(this.flowLayoutPanel9);
            this.tabPageSavingDetails.Controls.Add(this.groupBoxSaving);
            resources.ApplyResources(this.tabPageSavingDetails, "tabPageSavingDetails");
            this.tabPageSavingDetails.Name = "tabPageSavingDetails";
            // 
            // tabControlSavingsDetails
            // 
            this.tabControlSavingsDetails.Controls.Add(this.tabPageSavingsAmountsAndFees);
            this.tabControlSavingsDetails.Controls.Add(this.tabPageSavingsEvents);
            this.tabControlSavingsDetails.Controls.Add(this.tabPageLoans);
            this.tabControlSavingsDetails.Controls.Add(this.tpTermDeposit);
            resources.ApplyResources(this.tabControlSavingsDetails, "tabControlSavingsDetails");
            this.tabControlSavingsDetails.Name = "tabControlSavingsDetails";
            this.tabControlSavingsDetails.SelectedIndex = 0;
            // 
            // tabPageSavingsAmountsAndFees
            // 
            this.tabPageSavingsAmountsAndFees.Controls.Add(this.flowLayoutPanel10);
            this.tabPageSavingsAmountsAndFees.Controls.Add(this.tlpSBDetails);
            resources.ApplyResources(this.tabPageSavingsAmountsAndFees, "tabPageSavingsAmountsAndFees");
            this.tabPageSavingsAmountsAndFees.Name = "tabPageSavingsAmountsAndFees";
            // 
            // flowLayoutPanel10
            // 
            resources.ApplyResources(this.flowLayoutPanel10, "flowLayoutPanel10");
            this.flowLayoutPanel10.Controls.Add(this.groupBoxSavingBalance);
            this.flowLayoutPanel10.Controls.Add(this.groupBoxSavingDeposit);
            this.flowLayoutPanel10.Controls.Add(this.groupBoxSavingWithdraw);
            this.flowLayoutPanel10.Controls.Add(this.groupBoxSavingTransfer);
            this.flowLayoutPanel10.Controls.Add(this.gbInterest);
            this.flowLayoutPanel10.Controls.Add(this.gbDepositInterest);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            // 
            // groupBoxSavingBalance
            // 
            resources.ApplyResources(this.groupBoxSavingBalance, "groupBoxSavingBalance");
            this.groupBoxSavingBalance.Controls.Add(this.tableLayoutPanel12);
            this.groupBoxSavingBalance.Name = "groupBoxSavingBalance";
            this.groupBoxSavingBalance.TabStop = false;
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(this.tableLayoutPanel12, "tableLayoutPanel12");
            this.tableLayoutPanel12.Controls.Add(this.lbBalanceMaxValue, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.lbBalanceMin, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.lbBalanceMinValue, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.lbBalanceMax, 0, 1);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            // 
            // lbBalanceMaxValue
            // 
            resources.ApplyResources(this.lbBalanceMaxValue, "lbBalanceMaxValue");
            this.lbBalanceMaxValue.Name = "lbBalanceMaxValue";
            // 
            // lbBalanceMin
            // 
            resources.ApplyResources(this.lbBalanceMin, "lbBalanceMin");
            this.lbBalanceMin.Name = "lbBalanceMin";
            // 
            // lbBalanceMinValue
            // 
            resources.ApplyResources(this.lbBalanceMinValue, "lbBalanceMinValue");
            this.lbBalanceMinValue.Name = "lbBalanceMinValue";
            // 
            // lbBalanceMax
            // 
            resources.ApplyResources(this.lbBalanceMax, "lbBalanceMax");
            this.lbBalanceMax.Name = "lbBalanceMax";
            // 
            // groupBoxSavingDeposit
            // 
            resources.ApplyResources(this.groupBoxSavingDeposit, "groupBoxSavingDeposit");
            this.groupBoxSavingDeposit.Controls.Add(this.tableLayoutPanel13);
            this.groupBoxSavingDeposit.Name = "groupBoxSavingDeposit";
            this.groupBoxSavingDeposit.TabStop = false;
            // 
            // tableLayoutPanel13
            // 
            resources.ApplyResources(this.tableLayoutPanel13, "tableLayoutPanel13");
            this.tableLayoutPanel13.Controls.Add(this.lbDepositMaxValue, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.lbDepositMin, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.lbDepositMinValue, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.lbDepositmax, 0, 1);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            // 
            // lbDepositMaxValue
            // 
            resources.ApplyResources(this.lbDepositMaxValue, "lbDepositMaxValue");
            this.lbDepositMaxValue.Name = "lbDepositMaxValue";
            // 
            // lbDepositMin
            // 
            resources.ApplyResources(this.lbDepositMin, "lbDepositMin");
            this.lbDepositMin.Name = "lbDepositMin";
            // 
            // lbDepositMinValue
            // 
            resources.ApplyResources(this.lbDepositMinValue, "lbDepositMinValue");
            this.lbDepositMinValue.Name = "lbDepositMinValue";
            // 
            // lbDepositmax
            // 
            resources.ApplyResources(this.lbDepositmax, "lbDepositmax");
            this.lbDepositmax.Name = "lbDepositmax";
            // 
            // groupBoxSavingWithdraw
            // 
            resources.ApplyResources(this.groupBoxSavingWithdraw, "groupBoxSavingWithdraw");
            this.groupBoxSavingWithdraw.Controls.Add(this.tableLayoutPanel14);
            this.groupBoxSavingWithdraw.Name = "groupBoxSavingWithdraw";
            this.groupBoxSavingWithdraw.TabStop = false;
            // 
            // tableLayoutPanel14
            // 
            resources.ApplyResources(this.tableLayoutPanel14, "tableLayoutPanel14");
            this.tableLayoutPanel14.Controls.Add(this.lbWithdrawMaxValue, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.lbWithdrawMin, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.lbWithdrawMinValue, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.lbWithdrawMax, 0, 1);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            // 
            // lbWithdrawMaxValue
            // 
            resources.ApplyResources(this.lbWithdrawMaxValue, "lbWithdrawMaxValue");
            this.lbWithdrawMaxValue.Name = "lbWithdrawMaxValue";
            // 
            // lbWithdrawMin
            // 
            resources.ApplyResources(this.lbWithdrawMin, "lbWithdrawMin");
            this.lbWithdrawMin.Name = "lbWithdrawMin";
            // 
            // lbWithdrawMinValue
            // 
            resources.ApplyResources(this.lbWithdrawMinValue, "lbWithdrawMinValue");
            this.lbWithdrawMinValue.Name = "lbWithdrawMinValue";
            // 
            // lbWithdrawMax
            // 
            resources.ApplyResources(this.lbWithdrawMax, "lbWithdrawMax");
            this.lbWithdrawMax.Name = "lbWithdrawMax";
            // 
            // groupBoxSavingTransfer
            // 
            resources.ApplyResources(this.groupBoxSavingTransfer, "groupBoxSavingTransfer");
            this.groupBoxSavingTransfer.Controls.Add(this.tableLayoutPanel15);
            this.groupBoxSavingTransfer.Name = "groupBoxSavingTransfer";
            this.groupBoxSavingTransfer.TabStop = false;
            // 
            // tableLayoutPanel15
            // 
            resources.ApplyResources(this.tableLayoutPanel15, "tableLayoutPanel15");
            this.tableLayoutPanel15.Controls.Add(this.labelSavingTransferMaxValue, 1, 1);
            this.tableLayoutPanel15.Controls.Add(this.labelSavingTransferMin, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.labelSavingTransferMinValue, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.labelSavingTransferMax, 0, 1);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            // 
            // labelSavingTransferMaxValue
            // 
            resources.ApplyResources(this.labelSavingTransferMaxValue, "labelSavingTransferMaxValue");
            this.labelSavingTransferMaxValue.Name = "labelSavingTransferMaxValue";
            // 
            // labelSavingTransferMin
            // 
            resources.ApplyResources(this.labelSavingTransferMin, "labelSavingTransferMin");
            this.labelSavingTransferMin.Name = "labelSavingTransferMin";
            // 
            // labelSavingTransferMinValue
            // 
            resources.ApplyResources(this.labelSavingTransferMinValue, "labelSavingTransferMinValue");
            this.labelSavingTransferMinValue.Name = "labelSavingTransferMinValue";
            // 
            // labelSavingTransferMax
            // 
            resources.ApplyResources(this.labelSavingTransferMax, "labelSavingTransferMax");
            this.labelSavingTransferMax.Name = "labelSavingTransferMax";
            // 
            // gbInterest
            // 
            resources.ApplyResources(this.gbInterest, "gbInterest");
            this.gbInterest.Controls.Add(this.tableLayoutPanel16);
            this.gbInterest.Name = "gbInterest";
            this.gbInterest.TabStop = false;
            // 
            // tableLayoutPanel16
            // 
            resources.ApplyResources(this.tableLayoutPanel16, "tableLayoutPanel16");
            this.tableLayoutPanel16.Controls.Add(this.lbInterestBasedOnValue, 1, 2);
            this.tableLayoutPanel16.Controls.Add(this.lbInterestAccrual, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.lbInterestPostingValue, 1, 1);
            this.tableLayoutPanel16.Controls.Add(this.lbInterestBasedOn, 0, 2);
            this.tableLayoutPanel16.Controls.Add(this.lbInterestAccrualValue, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.lbInterestPosting, 0, 1);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            // 
            // lbInterestBasedOnValue
            // 
            resources.ApplyResources(this.lbInterestBasedOnValue, "lbInterestBasedOnValue");
            this.lbInterestBasedOnValue.Name = "lbInterestBasedOnValue";
            // 
            // lbInterestAccrual
            // 
            resources.ApplyResources(this.lbInterestAccrual, "lbInterestAccrual");
            this.lbInterestAccrual.Name = "lbInterestAccrual";
            // 
            // lbInterestPostingValue
            // 
            resources.ApplyResources(this.lbInterestPostingValue, "lbInterestPostingValue");
            this.lbInterestPostingValue.Name = "lbInterestPostingValue";
            // 
            // lbInterestBasedOn
            // 
            resources.ApplyResources(this.lbInterestBasedOn, "lbInterestBasedOn");
            this.lbInterestBasedOn.Name = "lbInterestBasedOn";
            // 
            // lbInterestAccrualValue
            // 
            resources.ApplyResources(this.lbInterestAccrualValue, "lbInterestAccrualValue");
            this.lbInterestAccrualValue.Name = "lbInterestAccrualValue";
            // 
            // lbInterestPosting
            // 
            resources.ApplyResources(this.lbInterestPosting, "lbInterestPosting");
            this.lbInterestPosting.Name = "lbInterestPosting";
            // 
            // gbDepositInterest
            // 
            resources.ApplyResources(this.gbDepositInterest, "gbDepositInterest");
            this.gbDepositInterest.Controls.Add(this.tableLayoutPanel17);
            this.gbDepositInterest.Name = "gbDepositInterest";
            this.gbDepositInterest.TabStop = false;
            // 
            // tableLayoutPanel17
            // 
            resources.ApplyResources(this.tableLayoutPanel17, "tableLayoutPanel17");
            this.tableLayoutPanel17.Controls.Add(this.lbPeriodicityValue, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.lbAccrualDeposit, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.lbAccrualDepositValue, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.lbPeriodicity, 0, 1);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            // 
            // lbPeriodicityValue
            // 
            resources.ApplyResources(this.lbPeriodicityValue, "lbPeriodicityValue");
            this.lbPeriodicityValue.Name = "lbPeriodicityValue";
            // 
            // lbAccrualDeposit
            // 
            resources.ApplyResources(this.lbAccrualDeposit, "lbAccrualDeposit");
            this.lbAccrualDeposit.Name = "lbAccrualDeposit";
            // 
            // lbAccrualDepositValue
            // 
            resources.ApplyResources(this.lbAccrualDepositValue, "lbAccrualDepositValue");
            this.lbAccrualDepositValue.Name = "lbAccrualDepositValue";
            // 
            // lbPeriodicity
            // 
            resources.ApplyResources(this.lbPeriodicity, "lbPeriodicity");
            this.lbPeriodicity.Name = "lbPeriodicity";
            // 
            // tlpSBDetails
            // 
            resources.ApplyResources(this.tlpSBDetails, "tlpSBDetails");
            this.tlpSBDetails.Controls.Add(this.lblIbtFeeMinMax, 2, 7);
            this.tlpSBDetails.Controls.Add(this.lbTransferFees, 0, 0);
            this.tlpSBDetails.Controls.Add(this.nudIbtFee, 1, 7);
            this.tlpSBDetails.Controls.Add(this.lbDepositFees, 0, 1);
            this.tlpSBDetails.Controls.Add(this.nudTransferFees, 1, 0);
            this.tlpSBDetails.Controls.Add(this.lbReopenFeesMinMax, 2, 6);
            this.tlpSBDetails.Controls.Add(this.lbTransferFeesMinMax, 2, 0);
            this.tlpSBDetails.Controls.Add(this.nudReopenFees, 1, 6);
            this.tlpSBDetails.Controls.Add(this.lbReopenFees, 0, 6);
            this.tlpSBDetails.Controls.Add(this.lbDepositFeesMinMax, 2, 1);
            this.tlpSBDetails.Controls.Add(this.lbAgioFeesMinMax, 2, 5);
            this.tlpSBDetails.Controls.Add(this.lbChequeDepositFees, 0, 8);
            this.tlpSBDetails.Controls.Add(this.nudAgioFees, 1, 5);
            this.tlpSBDetails.Controls.Add(this.nudChequeDepositFees, 1, 8);
            this.tlpSBDetails.Controls.Add(this.lbAgioFees, 0, 5);
            this.tlpSBDetails.Controls.Add(this.lbOverdraftFeesMinMax, 2, 4);
            this.tlpSBDetails.Controls.Add(this.lblChequeDepositFeesMinMax, 2, 8);
            this.tlpSBDetails.Controls.Add(this.lbCloseFees, 0, 2);
            this.tlpSBDetails.Controls.Add(this.nudOverdraftFees, 1, 4);
            this.tlpSBDetails.Controls.Add(this.nudCloseFees, 1, 2);
            this.tlpSBDetails.Controls.Add(this.lbOverdraftFees, 0, 4);
            this.tlpSBDetails.Controls.Add(this.lbCloseFeesMinMax, 2, 2);
            this.tlpSBDetails.Controls.Add(this.lbManagementFeesMinMax, 2, 3);
            this.tlpSBDetails.Controls.Add(this.lbManagementFees, 0, 3);
            this.tlpSBDetails.Controls.Add(this.nudManagementFees, 1, 3);
            this.tlpSBDetails.Controls.Add(this.nudDepositFees, 1, 1);
            this.tlpSBDetails.Controls.Add(this.lblInterBranchTransfer, 0, 7);
            this.tlpSBDetails.Name = "tlpSBDetails";
            // 
            // lblIbtFeeMinMax
            // 
            this.lblIbtFeeMinMax.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblIbtFeeMinMax, "lblIbtFeeMinMax");
            this.lblIbtFeeMinMax.Name = "lblIbtFeeMinMax";
            // 
            // lbTransferFees
            // 
            resources.ApplyResources(this.lbTransferFees, "lbTransferFees");
            this.lbTransferFees.Name = "lbTransferFees";
            // 
            // nudIbtFee
            // 
            resources.ApplyResources(this.nudIbtFee, "nudIbtFee");
            this.nudIbtFee.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudIbtFee.Name = "nudIbtFee";
            // 
            // lbDepositFees
            // 
            resources.ApplyResources(this.lbDepositFees, "lbDepositFees");
            this.lbDepositFees.Name = "lbDepositFees";
            // 
            // nudTransferFees
            // 
            resources.ApplyResources(this.nudTransferFees, "nudTransferFees");
            this.nudTransferFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudTransferFees.Name = "nudTransferFees";
            // 
            // lbReopenFeesMinMax
            // 
            resources.ApplyResources(this.lbReopenFeesMinMax, "lbReopenFeesMinMax");
            this.lbReopenFeesMinMax.Name = "lbReopenFeesMinMax";
            // 
            // lbTransferFeesMinMax
            // 
            resources.ApplyResources(this.lbTransferFeesMinMax, "lbTransferFeesMinMax");
            this.lbTransferFeesMinMax.Name = "lbTransferFeesMinMax";
            // 
            // nudReopenFees
            // 
            resources.ApplyResources(this.nudReopenFees, "nudReopenFees");
            this.nudReopenFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudReopenFees.Name = "nudReopenFees";
            // 
            // lbReopenFees
            // 
            resources.ApplyResources(this.lbReopenFees, "lbReopenFees");
            this.lbReopenFees.Name = "lbReopenFees";
            // 
            // lbDepositFeesMinMax
            // 
            resources.ApplyResources(this.lbDepositFeesMinMax, "lbDepositFeesMinMax");
            this.lbDepositFeesMinMax.Name = "lbDepositFeesMinMax";
            // 
            // lbAgioFeesMinMax
            // 
            resources.ApplyResources(this.lbAgioFeesMinMax, "lbAgioFeesMinMax");
            this.lbAgioFeesMinMax.Name = "lbAgioFeesMinMax";
            // 
            // lbChequeDepositFees
            // 
            resources.ApplyResources(this.lbChequeDepositFees, "lbChequeDepositFees");
            this.lbChequeDepositFees.Name = "lbChequeDepositFees";
            // 
            // nudAgioFees
            // 
            resources.ApplyResources(this.nudAgioFees, "nudAgioFees");
            this.nudAgioFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudAgioFees.Name = "nudAgioFees";
            // 
            // nudChequeDepositFees
            // 
            resources.ApplyResources(this.nudChequeDepositFees, "nudChequeDepositFees");
            this.nudChequeDepositFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudChequeDepositFees.Name = "nudChequeDepositFees";
            // 
            // lbAgioFees
            // 
            resources.ApplyResources(this.lbAgioFees, "lbAgioFees");
            this.lbAgioFees.Name = "lbAgioFees";
            // 
            // lbOverdraftFeesMinMax
            // 
            resources.ApplyResources(this.lbOverdraftFeesMinMax, "lbOverdraftFeesMinMax");
            this.lbOverdraftFeesMinMax.Name = "lbOverdraftFeesMinMax";
            // 
            // lblChequeDepositFeesMinMax
            // 
            this.lblChequeDepositFeesMinMax.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblChequeDepositFeesMinMax, "lblChequeDepositFeesMinMax");
            this.lblChequeDepositFeesMinMax.Name = "lblChequeDepositFeesMinMax";
            // 
            // lbCloseFees
            // 
            resources.ApplyResources(this.lbCloseFees, "lbCloseFees");
            this.lbCloseFees.Name = "lbCloseFees";
            // 
            // nudOverdraftFees
            // 
            resources.ApplyResources(this.nudOverdraftFees, "nudOverdraftFees");
            this.nudOverdraftFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudOverdraftFees.Name = "nudOverdraftFees";
            // 
            // nudCloseFees
            // 
            resources.ApplyResources(this.nudCloseFees, "nudCloseFees");
            this.nudCloseFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCloseFees.Name = "nudCloseFees";
            // 
            // lbOverdraftFees
            // 
            resources.ApplyResources(this.lbOverdraftFees, "lbOverdraftFees");
            this.lbOverdraftFees.Name = "lbOverdraftFees";
            // 
            // lbCloseFeesMinMax
            // 
            resources.ApplyResources(this.lbCloseFeesMinMax, "lbCloseFeesMinMax");
            this.lbCloseFeesMinMax.Name = "lbCloseFeesMinMax";
            // 
            // lbManagementFeesMinMax
            // 
            resources.ApplyResources(this.lbManagementFeesMinMax, "lbManagementFeesMinMax");
            this.lbManagementFeesMinMax.Name = "lbManagementFeesMinMax";
            // 
            // lbManagementFees
            // 
            resources.ApplyResources(this.lbManagementFees, "lbManagementFees");
            this.lbManagementFees.Name = "lbManagementFees";
            // 
            // nudManagementFees
            // 
            resources.ApplyResources(this.nudManagementFees, "nudManagementFees");
            this.nudManagementFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudManagementFees.Name = "nudManagementFees";
            // 
            // nudDepositFees
            // 
            resources.ApplyResources(this.nudDepositFees, "nudDepositFees");
            this.nudDepositFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDepositFees.Name = "nudDepositFees";
            // 
            // lblInterBranchTransfer
            // 
            resources.ApplyResources(this.lblInterBranchTransfer, "lblInterBranchTransfer");
            this.lblInterBranchTransfer.BackColor = System.Drawing.Color.Transparent;
            this.lblInterBranchTransfer.Name = "lblInterBranchTransfer";
            // 
            // tabPageSavingsEvents
            // 
            this.tabPageSavingsEvents.Controls.Add(this.lvSavingEvent);
            resources.ApplyResources(this.tabPageSavingsEvents, "tabPageSavingsEvents");
            this.tabPageSavingsEvents.Name = "tabPageSavingsEvents";
            // 
            // lvSavingEvent
            // 
            this.lvSavingEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader26,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader27,
            this.columnHeader15,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader24,
            this.colCancelDate});
            resources.ApplyResources(this.lvSavingEvent, "lvSavingEvent");
            this.lvSavingEvent.FullRowSelect = true;
            this.lvSavingEvent.GridLines = true;
            this.lvSavingEvent.Name = "lvSavingEvent";
            this.lvSavingEvent.UseCompatibleStateImageBehavior = false;
            this.lvSavingEvent.View = System.Windows.Forms.View.Details;
            this.lvSavingEvent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewSavingEvent_MouseClick);
            // 
            // columnHeader21
            // 
            resources.ApplyResources(this.columnHeader21, "columnHeader21");
            // 
            // columnHeader26
            // 
            resources.ApplyResources(this.columnHeader26, "columnHeader26");
            // 
            // columnHeader22
            // 
            resources.ApplyResources(this.columnHeader22, "columnHeader22");
            // 
            // columnHeader23
            // 
            resources.ApplyResources(this.columnHeader23, "columnHeader23");
            // 
            // columnHeader27
            // 
            resources.ApplyResources(this.columnHeader27, "columnHeader27");
            // 
            // columnHeader15
            // 
            resources.ApplyResources(this.columnHeader15, "columnHeader15");
            // 
            // columnHeader28
            // 
            resources.ApplyResources(this.columnHeader28, "columnHeader28");
            // 
            // columnHeader29
            // 
            resources.ApplyResources(this.columnHeader29, "columnHeader29");
            // 
            // columnHeader24
            // 
            resources.ApplyResources(this.columnHeader24, "columnHeader24");
            // 
            // colCancelDate
            // 
            resources.ApplyResources(this.colCancelDate, "colCancelDate");
            // 
            // tabPageLoans
            // 
            this.tabPageLoans.Controls.Add(this.olvLoans);
            resources.ApplyResources(this.tabPageLoans, "tabPageLoans");
            this.tabPageLoans.Name = "tabPageLoans";
            // 
            // olvLoans
            // 
            this.olvLoans.AllColumns.Add(this.olvColumnContractCode);
            this.olvLoans.AllColumns.Add(this.olvColumnStatus);
            this.olvLoans.AllColumns.Add(this.olvColumnAmount);
            this.olvLoans.AllColumns.Add(this.olvColumnOLB);
            this.olvLoans.AllColumns.Add(this.olvColumnCreationDate);
            this.olvLoans.AllColumns.Add(this.olvColumnStratDate);
            this.olvLoans.AllColumns.Add(this.olvColumnCloseDate);
            this.olvLoans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnContractCode,
            this.olvColumnStatus,
            this.olvColumnAmount,
            this.olvColumnOLB,
            this.olvColumnCreationDate,
            this.olvColumnStratDate,
            this.olvColumnCloseDate});
            resources.ApplyResources(this.olvLoans, "olvLoans");
            this.olvLoans.FullRowSelect = true;
            this.olvLoans.GridLines = true;
            this.olvLoans.HideSelection = false;
            this.olvLoans.Name = "olvLoans";
            this.olvLoans.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.olvLoans.ShowGroups = false;
            this.olvLoans.UseCompatibleStateImageBehavior = false;
            this.olvLoans.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnContractCode
            // 
            this.olvColumnContractCode.AspectName = "Code";
            resources.ApplyResources(this.olvColumnContractCode, "olvColumnContractCode");
            // 
            // olvColumnStatus
            // 
            this.olvColumnStatus.AspectName = "ContractStatus";
            resources.ApplyResources(this.olvColumnStatus, "olvColumnStatus");
            // 
            // olvColumnAmount
            // 
            this.olvColumnAmount.AspectName = "Amount";
            this.olvColumnAmount.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.olvColumnAmount, "olvColumnAmount");
            // 
            // olvColumnOLB
            // 
            this.olvColumnOLB.AspectName = "OLB";
            this.olvColumnOLB.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.olvColumnOLB, "olvColumnOLB");
            // 
            // olvColumnCreationDate
            // 
            this.olvColumnCreationDate.AspectName = "CreationDate";
            resources.ApplyResources(this.olvColumnCreationDate, "olvColumnCreationDate");
            // 
            // olvColumnStratDate
            // 
            this.olvColumnStratDate.AspectName = "StartDate";
            resources.ApplyResources(this.olvColumnStratDate, "olvColumnStratDate");
            // 
            // olvColumnCloseDate
            // 
            this.olvColumnCloseDate.AspectName = "CloseDate";
            resources.ApplyResources(this.olvColumnCloseDate, "olvColumnCloseDate");
            // 
            // tpTermDeposit
            // 
            this.tpTermDeposit.Controls.Add(this.tlpTermDeposit);
            resources.ApplyResources(this.tpTermDeposit, "tpTermDeposit");
            this.tpTermDeposit.Name = "tpTermDeposit";
            // 
            // tlpTermDeposit
            // 
            resources.ApplyResources(this.tlpTermDeposit, "tlpTermDeposit");
            this.tlpTermDeposit.Controls.Add(this.lblNumberOfPeriods, 0, 0);
            this.tlpTermDeposit.Controls.Add(this.nudNumberOfPeriods, 1, 0);
            this.tlpTermDeposit.Controls.Add(this.lblLimitOfTermDepositPeriod, 2, 0);
            this.tlpTermDeposit.Controls.Add(this.tbTargetAccount2, 1, 2);
            this.tlpTermDeposit.Controls.Add(this.cmbRollover2, 1, 1);
            this.tlpTermDeposit.Controls.Add(this.lbRollover2, 0, 1);
            this.tlpTermDeposit.Controls.Add(this.btSearchContract2, 2, 2);
            this.tlpTermDeposit.Controls.Add(this.lblTermTransferToAccount, 0, 2);
            this.tlpTermDeposit.Name = "tlpTermDeposit";
            // 
            // lblNumberOfPeriods
            // 
            resources.ApplyResources(this.lblNumberOfPeriods, "lblNumberOfPeriods");
            this.lblNumberOfPeriods.Name = "lblNumberOfPeriods";
            // 
            // nudNumberOfPeriods
            // 
            resources.ApplyResources(this.nudNumberOfPeriods, "nudNumberOfPeriods");
            this.nudNumberOfPeriods.Name = "nudNumberOfPeriods";
            // 
            // lblLimitOfTermDepositPeriod
            // 
            resources.ApplyResources(this.lblLimitOfTermDepositPeriod, "lblLimitOfTermDepositPeriod");
            this.lblLimitOfTermDepositPeriod.Name = "lblLimitOfTermDepositPeriod";
            // 
            // tbTargetAccount2
            // 
            resources.ApplyResources(this.tbTargetAccount2, "tbTargetAccount2");
            this.tbTargetAccount2.Name = "tbTargetAccount2";
            // 
            // cmbRollover2
            // 
            this.cmbRollover2.DisplayMember = "id";
            this.cmbRollover2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRollover2.FormattingEnabled = true;
            resources.ApplyResources(this.cmbRollover2, "cmbRollover2");
            this.cmbRollover2.Name = "cmbRollover2";
            this.cmbRollover2.ValueMember = "rollover";
            this.cmbRollover2.SelectedIndexChanged += new System.EventHandler(this.cmbRollover2_SelectedIndexChanged);
            // 
            // lbRollover2
            // 
            resources.ApplyResources(this.lbRollover2, "lbRollover2");
            this.lbRollover2.Name = "lbRollover2";
            // 
            // btSearchContract2
            // 
            resources.ApplyResources(this.btSearchContract2, "btSearchContract2");
            this.btSearchContract2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.btSearchContract2.Name = "btSearchContract2";
            this.btSearchContract2.UseVisualStyleBackColor = true;
            this.btSearchContract2.Click += new System.EventHandler(this.btSearchContract_Click);
            // 
            // lblTermTransferToAccount
            // 
            resources.ApplyResources(this.lblTermTransferToAccount, "lblTermTransferToAccount");
            this.lblTermTransferToAccount.Name = "lblTermTransferToAccount";
            // 
            // flowLayoutPanel9
            // 
            resources.ApplyResources(this.flowLayoutPanel9, "flowLayoutPanel9");
            this.flowLayoutPanel9.Controls.Add(this.btSavingsUpdate);
            this.flowLayoutPanel9.Controls.Add(this.buttonSaveSaving);
            this.flowLayoutPanel9.Controls.Add(this.buttonFirstDeposit);
            this.flowLayoutPanel9.Controls.Add(this.buttonCloseSaving);
            this.flowLayoutPanel9.Controls.Add(this.buttonReopenSaving);
            this.flowLayoutPanel9.Controls.Add(this.pnlSavingsButtons);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            // 
            // btSavingsUpdate
            // 
            resources.ApplyResources(this.btSavingsUpdate, "btSavingsUpdate");
            this.btSavingsUpdate.Name = "btSavingsUpdate";
            this.btSavingsUpdate.Click += new System.EventHandler(this.btSavingsUpdate_Click);
            // 
            // buttonSaveSaving
            // 
            resources.ApplyResources(this.buttonSaveSaving, "buttonSaveSaving");
            this.buttonSaveSaving.Name = "buttonSaveSaving";
            this.buttonSaveSaving.Click += new System.EventHandler(this.buttonSaveSaving_Click);
            // 
            // buttonFirstDeposit
            // 
            resources.ApplyResources(this.buttonFirstDeposit, "buttonFirstDeposit");
            this.buttonFirstDeposit.Name = "buttonFirstDeposit";
            this.buttonFirstDeposit.Click += new System.EventHandler(this.buttonFirstDeposit_Click);
            // 
            // buttonCloseSaving
            // 
            resources.ApplyResources(this.buttonCloseSaving, "buttonCloseSaving");
            this.buttonCloseSaving.Name = "buttonCloseSaving";
            this.buttonCloseSaving.Click += new System.EventHandler(this.buttonCloseSaving_Click);
            // 
            // buttonReopenSaving
            // 
            resources.ApplyResources(this.buttonReopenSaving, "buttonReopenSaving");
            this.buttonReopenSaving.Name = "buttonReopenSaving";
            this.buttonReopenSaving.Click += new System.EventHandler(this.buttonReopenSaving_Click);
            // 
            // pnlSavingsButtons
            // 
            resources.ApplyResources(this.pnlSavingsButtons, "pnlSavingsButtons");
            this.pnlSavingsButtons.Controls.Add(this.buttonSavingsOperations);
            this.pnlSavingsButtons.Controls.Add(this.btCancelLastSavingEvent);
            this.pnlSavingsButtons.Name = "pnlSavingsButtons";
            // 
            // buttonSavingsOperations
            // 
            resources.ApplyResources(this.buttonSavingsOperations, "buttonSavingsOperations");
            this.buttonSavingsOperations.Name = "buttonSavingsOperations";
            this.buttonSavingsOperations.Click += new System.EventHandler(this.buttonSavingsOperations_Click);
            // 
            // btCancelLastSavingEvent
            // 
            resources.ApplyResources(this.btCancelLastSavingEvent, "btCancelLastSavingEvent");
            this.btCancelLastSavingEvent.Name = "btCancelLastSavingEvent";
            this.btCancelLastSavingEvent.Click += new System.EventHandler(this.btCancelLastSavingEvent_Click);
            // 
            // groupBoxSaving
            // 
            resources.ApplyResources(this.groupBoxSaving, "groupBoxSaving");
            this.groupBoxSaving.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxSaving.Name = "groupBoxSaving";
            this.groupBoxSaving.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.lbSavingAvBalanceValue, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.lBSavingAvBalance, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbEntryFeesMinMax, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbInitialAmountMinMax, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbEntryFees, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.labelInitialAmount, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.nudEntryFees, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.nudDownInitialAmount, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbSavingBalanceValue, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.lBSavingBalance, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.tBSavingCode, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbSavingsOfficer, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.labelInterestRate, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbWithdrawFees, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.nudWithdrawFees, 4, 3);
            this.tableLayoutPanel5.Controls.Add(this.lbInterestRateMinMax, 5, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbWithdrawFeesMinMax, 5, 3);
            this.tableLayoutPanel5.Controls.Add(this.nudDownInterestRate, 4, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // lbSavingAvBalanceValue
            // 
            resources.ApplyResources(this.lbSavingAvBalanceValue, "lbSavingAvBalanceValue");
            this.lbSavingAvBalanceValue.Name = "lbSavingAvBalanceValue";
            // 
            // lBSavingAvBalance
            // 
            resources.ApplyResources(this.lBSavingAvBalance, "lBSavingAvBalance");
            this.lBSavingAvBalance.Name = "lBSavingAvBalance";
            // 
            // lbEntryFeesMinMax
            // 
            resources.ApplyResources(this.lbEntryFeesMinMax, "lbEntryFeesMinMax");
            this.lbEntryFeesMinMax.Name = "lbEntryFeesMinMax";
            // 
            // lbInitialAmountMinMax
            // 
            resources.ApplyResources(this.lbInitialAmountMinMax, "lbInitialAmountMinMax");
            this.lbInitialAmountMinMax.Name = "lbInitialAmountMinMax";
            // 
            // lbEntryFees
            // 
            resources.ApplyResources(this.lbEntryFees, "lbEntryFees");
            this.lbEntryFees.Name = "lbEntryFees";
            // 
            // labelInitialAmount
            // 
            resources.ApplyResources(this.labelInitialAmount, "labelInitialAmount");
            this.labelInitialAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelInitialAmount.Name = "labelInitialAmount";
            // 
            // nudEntryFees
            // 
            resources.ApplyResources(this.nudEntryFees, "nudEntryFees");
            this.nudEntryFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudEntryFees.Name = "nudEntryFees";
            // 
            // nudDownInitialAmount
            // 
            resources.ApplyResources(this.nudDownInitialAmount, "nudDownInitialAmount");
            this.nudDownInitialAmount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDownInitialAmount.Name = "nudDownInitialAmount";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Name = "label9";
            // 
            // lbSavingBalanceValue
            // 
            resources.ApplyResources(this.lbSavingBalanceValue, "lbSavingBalanceValue");
            this.lbSavingBalanceValue.Name = "lbSavingBalanceValue";
            // 
            // lBSavingBalance
            // 
            resources.ApplyResources(this.lBSavingBalance, "lBSavingBalance");
            this.lBSavingBalance.Name = "lBSavingBalance";
            // 
            // tBSavingCode
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.tBSavingCode, 2);
            resources.ApplyResources(this.tBSavingCode, "tBSavingCode");
            this.tBSavingCode.Name = "tBSavingCode";
            this.tBSavingCode.ReadOnly = true;
            // 
            // cmbSavingsOfficer
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.cmbSavingsOfficer, 2);
            this.cmbSavingsOfficer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSavingsOfficer.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSavingsOfficer, "cmbSavingsOfficer");
            this.cmbSavingsOfficer.Name = "cmbSavingsOfficer";
            // 
            // labelInterestRate
            // 
            resources.ApplyResources(this.labelInterestRate, "labelInterestRate");
            this.labelInterestRate.BackColor = System.Drawing.Color.Transparent;
            this.labelInterestRate.Name = "labelInterestRate";
            // 
            // lbWithdrawFees
            // 
            resources.ApplyResources(this.lbWithdrawFees, "lbWithdrawFees");
            this.lbWithdrawFees.Name = "lbWithdrawFees";
            // 
            // nudWithdrawFees
            // 
            resources.ApplyResources(this.nudWithdrawFees, "nudWithdrawFees");
            this.nudWithdrawFees.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWithdrawFees.Name = "nudWithdrawFees";
            // 
            // lbInterestRateMinMax
            // 
            resources.ApplyResources(this.lbInterestRateMinMax, "lbInterestRateMinMax");
            this.lbInterestRateMinMax.Name = "lbInterestRateMinMax";
            // 
            // lbWithdrawFeesMinMax
            // 
            resources.ApplyResources(this.lbWithdrawFeesMinMax, "lbWithdrawFeesMinMax");
            this.lbWithdrawFeesMinMax.Name = "lbWithdrawFeesMinMax";
            // 
            // nudDownInterestRate
            // 
            this.nudDownInterestRate.DecimalPlaces = 4;
            this.nudDownInterestRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            resources.ApplyResources(this.nudDownInterestRate, "nudDownInterestRate");
            this.nudDownInterestRate.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDownInterestRate.Name = "nudDownInterestRate";
            // 
            // tabPageContracts
            // 
            this.tabPageContracts.Controls.Add(this.splitContainerContracts);
            resources.ApplyResources(this.tabPageContracts, "tabPageContracts");
            this.tabPageContracts.Name = "tabPageContracts";
            // 
            // tabPageFPCAContracts
            // 
            this.tabPageFPCAContracts.Controls.Add(this.lvFixedDeposits);
            this.tabPageFPCAContracts.Controls.Add(this.lvCurrentAccountProducts);
            this.tabPageFPCAContracts.Controls.Add(this.panel5);
            this.tabPageFPCAContracts.Controls.Add(this.panel4);
            this.tabPageFPCAContracts.Controls.Add(this.label3);
            this.tabPageFPCAContracts.Controls.Add(this.label2);
            resources.ApplyResources(this.tabPageFPCAContracts, "tabPageFPCAContracts");
            this.tabPageFPCAContracts.Name = "tabPageFPCAContracts";
            this.tabPageFPCAContracts.UseVisualStyleBackColor = true;
            // 
            // lvFixedDeposits
            // 
            this.lvFixedDeposits.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvFixedDeposits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContractCode,
            this.InitialAmount,
            this.InterestRate,
            this.MaturityPeriod,
            this.OpenDate,
            this.OpenAccountingOfficer,
            this.Status});
            this.lvFixedDeposits.FullRowSelect = true;
            this.lvFixedDeposits.GridLines = true;
            resources.ApplyResources(this.lvFixedDeposits, "lvFixedDeposits");
            this.lvFixedDeposits.Name = "lvFixedDeposits";
            this.lvFixedDeposits.UseCompatibleStateImageBehavior = false;
            this.lvFixedDeposits.View = System.Windows.Forms.View.Details;
            this.lvFixedDeposits.SelectedIndexChanged += new System.EventHandler(this.lvFixedDeposits_SelectedIndexChanged);
            // 
            // ContractCode
            // 
            resources.ApplyResources(this.ContractCode, "ContractCode");
            // 
            // InitialAmount
            // 
            resources.ApplyResources(this.InitialAmount, "InitialAmount");
            // 
            // InterestRate
            // 
            resources.ApplyResources(this.InterestRate, "InterestRate");
            // 
            // MaturityPeriod
            // 
            resources.ApplyResources(this.MaturityPeriod, "MaturityPeriod");
            // 
            // OpenDate
            // 
            resources.ApplyResources(this.OpenDate, "OpenDate");
            // 
            // OpenAccountingOfficer
            // 
            resources.ApplyResources(this.OpenAccountingOfficer, "OpenAccountingOfficer");
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            // 
            // lvCurrentAccountProducts
            // 
            this.lvCurrentAccountProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chContractCode,
            this.chBalance,
            this.chOpenedDate,
            this.chOpenAO,
            this.chStatus});
            this.lvCurrentAccountProducts.FullRowSelect = true;
            this.lvCurrentAccountProducts.GridLines = true;
            resources.ApplyResources(this.lvCurrentAccountProducts, "lvCurrentAccountProducts");
            this.lvCurrentAccountProducts.Name = "lvCurrentAccountProducts";
            this.lvCurrentAccountProducts.UseCompatibleStateImageBehavior = false;
            this.lvCurrentAccountProducts.View = System.Windows.Forms.View.Details;
            // 
            // chContractCode
            // 
            resources.ApplyResources(this.chContractCode, "chContractCode");
            // 
            // chBalance
            // 
            resources.ApplyResources(this.chBalance, "chBalance");
            // 
            // chOpenedDate
            // 
            resources.ApplyResources(this.chOpenedDate, "chOpenedDate");
            // 
            // chOpenAO
            // 
            resources.ApplyResources(this.chOpenAO, "chOpenAO");
            // 
            // chStatus
            // 
            resources.ApplyResources(this.chStatus, "chStatus");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnFDChargesNotice);
            this.panel5.Controls.Add(this.btnCAGenerateStatement);
            this.panel5.Controls.Add(this.btnViewCurrentAccount);
            this.panel5.Controls.Add(this.btnAddCurrentAccount);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btnFDChargesNotice
            // 
            resources.ApplyResources(this.btnFDChargesNotice, "btnFDChargesNotice");
            this.btnFDChargesNotice.Name = "btnFDChargesNotice";
            this.btnFDChargesNotice.UseVisualStyleBackColor = true;
            this.btnFDChargesNotice.Click += new System.EventHandler(this.btnFDChargesNotice_Click);
            // 
            // btnCAGenerateStatement
            // 
            resources.ApplyResources(this.btnCAGenerateStatement, "btnCAGenerateStatement");
            this.btnCAGenerateStatement.Name = "btnCAGenerateStatement";
            this.btnCAGenerateStatement.UseVisualStyleBackColor = true;
            this.btnCAGenerateStatement.Click += new System.EventHandler(this.btnCAGenerateStatement_Click);
            // 
            // btnViewCurrentAccount
            // 
            resources.ApplyResources(this.btnViewCurrentAccount, "btnViewCurrentAccount");
            this.btnViewCurrentAccount.Name = "btnViewCurrentAccount";
            this.btnViewCurrentAccount.UseVisualStyleBackColor = true;
            this.btnViewCurrentAccount.Click += new System.EventHandler(this.btnViewCurrentAccount_Click);
            // 
            // btnAddCurrentAccount
            // 
            resources.ApplyResources(this.btnAddCurrentAccount, "btnAddCurrentAccount");
            this.btnAddCurrentAccount.Name = "btnAddCurrentAccount";
            this.btnAddCurrentAccount.UseVisualStyleBackColor = true;
            this.btnAddCurrentAccount.Click += new System.EventHandler(this.btnAddCurrentAccount_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCAChargesNotice);
            this.panel4.Controls.Add(this.btnGenerateFDStatement);
            this.panel4.Controls.Add(this.btnViewFixedDeposit);
            this.panel4.Controls.Add(this.btnAddFixedDeposit);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnCAChargesNotice
            // 
            resources.ApplyResources(this.btnCAChargesNotice, "btnCAChargesNotice");
            this.btnCAChargesNotice.Name = "btnCAChargesNotice";
            this.btnCAChargesNotice.UseVisualStyleBackColor = true;
            this.btnCAChargesNotice.Click += new System.EventHandler(this.btnCAChargesNotice_Click);
            // 
            // btnGenerateFDStatement
            // 
            resources.ApplyResources(this.btnGenerateFDStatement, "btnGenerateFDStatement");
            this.btnGenerateFDStatement.Name = "btnGenerateFDStatement";
            this.btnGenerateFDStatement.UseVisualStyleBackColor = true;
            this.btnGenerateFDStatement.Click += new System.EventHandler(this.btnGenerateFDStatement_Click);
            // 
            // btnViewFixedDeposit
            // 
            resources.ApplyResources(this.btnViewFixedDeposit, "btnViewFixedDeposit");
            this.btnViewFixedDeposit.Name = "btnViewFixedDeposit";
            this.btnViewFixedDeposit.UseVisualStyleBackColor = true;
            this.btnViewFixedDeposit.Click += new System.EventHandler(this.btnViewFixedDeposit_Click);
            // 
            // btnAddFixedDeposit
            // 
            resources.ApplyResources(this.btnAddFixedDeposit, "btnAddFixedDeposit");
            this.btnAddFixedDeposit.Name = "btnAddFixedDeposit";
            this.btnAddFixedDeposit.UseVisualStyleBackColor = true;
            this.btnAddFixedDeposit.Click += new System.EventHandler(this.btnAddFixedDeposit_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // tabPageFixedDeposit
            // 
            this.tabPageFixedDeposit.Controls.Add(this.tbTransferNumberForm);
            resources.ApplyResources(this.tabPageFixedDeposit, "tabPageFixedDeposit");
            this.tabPageFixedDeposit.Name = "tabPageFixedDeposit";
            this.tabPageFixedDeposit.UseVisualStyleBackColor = true;
            // 
            // tbTransferNumberForm
            // 
            this.tbTransferNumberForm.BackColor = System.Drawing.SystemColors.Control;
            this.tbTransferNumberForm.Controls.Add(this.gbFDInitialPayment);
            this.tbTransferNumberForm.Controls.Add(this.cbAccountStatus);
            this.tbTransferNumberForm.Controls.Add(this.tbOpenedDate);
            this.tbTransferNumberForm.Controls.Add(this.label31);
            this.tbTransferNumberForm.Controls.Add(this.label30);
            this.tbTransferNumberForm.Controls.Add(this.tbFDContractCode);
            this.tbTransferNumberForm.Controls.Add(this.lblProductContractCode);
            this.tbTransferNumberForm.Controls.Add(this.btnPrint);
            this.tbTransferNumberForm.Controls.Add(this.btnExtendPeriod);
            this.tbTransferNumberForm.Controls.Add(this.btnCloseFDContract);
            this.tbTransferNumberForm.Controls.Add(this.gbInterestCalculation);
            this.tbTransferNumberForm.Controls.Add(this.tbComment);
            this.tbTransferNumberForm.Controls.Add(this.label14);
            this.tbTransferNumberForm.Controls.Add(this.cbAccountingOfficer);
            this.tbTransferNumberForm.Controls.Add(this.label11);
            this.tbTransferNumberForm.Controls.Add(this.tbProductCode);
            this.tbTransferNumberForm.Controls.Add(this.label8);
            this.tbTransferNumberForm.Controls.Add(this.btnAddFixedDepositProduct);
            this.tbTransferNumberForm.Controls.Add(this.cbFixedDepositProduct);
            this.tbTransferNumberForm.Controls.Add(this.groupBox4);
            this.tbTransferNumberForm.Controls.Add(this.groupBox5);
            this.tbTransferNumberForm.Controls.Add(this.gbFrequency);
            this.tbTransferNumberForm.Controls.Add(this.lbNameSavingProduct);
            this.tbTransferNumberForm.Controls.Add(this.gbInitialAmount);
            this.tbTransferNumberForm.Controls.Add(this.gbInterestRate);
            resources.ApplyResources(this.tbTransferNumberForm, "tbTransferNumberForm");
            this.tbTransferNumberForm.Name = "tbTransferNumberForm";
            this.tbTransferNumberForm.TabStop = false;
            // 
            // gbFDInitialPayment
            // 
            this.gbFDInitialPayment.Controls.Add(this.cbInitialAmountPaymentMethod);
            this.gbFDInitialPayment.Controls.Add(this.tbFDInitialAmountNumber);
            this.gbFDInitialPayment.Controls.Add(this.lblFDInitialAccount);
            this.gbFDInitialPayment.Controls.Add(this.label47);
            resources.ApplyResources(this.gbFDInitialPayment, "gbFDInitialPayment");
            this.gbFDInitialPayment.Name = "gbFDInitialPayment";
            this.gbFDInitialPayment.TabStop = false;
            // 
            // cbInitialAmountPaymentMethod
            // 
            this.cbInitialAmountPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbInitialAmountPaymentMethod, "cbInitialAmountPaymentMethod");
            this.cbInitialAmountPaymentMethod.FormattingEnabled = true;
            this.cbInitialAmountPaymentMethod.Items.AddRange(new object[] {
            resources.GetString("cbInitialAmountPaymentMethod.Items"),
            resources.GetString("cbInitialAmountPaymentMethod.Items1"),
            resources.GetString("cbInitialAmountPaymentMethod.Items2")});
            this.cbInitialAmountPaymentMethod.Name = "cbInitialAmountPaymentMethod";
            this.cbInitialAmountPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbInitialAmountPaymentMethod_SelectedIndexChanged);
            // 
            // tbFDInitialAmountNumber
            // 
            resources.ApplyResources(this.tbFDInitialAmountNumber, "tbFDInitialAmountNumber");
            this.tbFDInitialAmountNumber.Name = "tbFDInitialAmountNumber";
            // 
            // lblFDInitialAccount
            // 
            resources.ApplyResources(this.lblFDInitialAccount, "lblFDInitialAccount");
            this.lblFDInitialAccount.Name = "lblFDInitialAccount";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // cbAccountStatus
            // 
            this.cbAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbAccountStatus, "cbAccountStatus");
            this.cbAccountStatus.FormattingEnabled = true;
            this.cbAccountStatus.Items.AddRange(new object[] {
            resources.GetString("cbAccountStatus.Items"),
            resources.GetString("cbAccountStatus.Items1")});
            this.cbAccountStatus.Name = "cbAccountStatus";
            // 
            // tbOpenedDate
            // 
            resources.ApplyResources(this.tbOpenedDate, "tbOpenedDate");
            this.tbOpenedDate.Name = "tbOpenedDate";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // tbFDContractCode
            // 
            resources.ApplyResources(this.tbFDContractCode, "tbFDContractCode");
            this.tbFDContractCode.Name = "tbFDContractCode";
            // 
            // lblProductContractCode
            // 
            resources.ApplyResources(this.lblProductContractCode, "lblProductContractCode");
            this.lblProductContractCode.Name = "lblProductContractCode";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExtendPeriod
            // 
            resources.ApplyResources(this.btnExtendPeriod, "btnExtendPeriod");
            this.btnExtendPeriod.Name = "btnExtendPeriod";
            this.btnExtendPeriod.UseVisualStyleBackColor = true;
            this.btnExtendPeriod.Click += new System.EventHandler(this.btnExtendPeriod_Click);
            // 
            // btnCloseFDContract
            // 
            resources.ApplyResources(this.btnCloseFDContract, "btnCloseFDContract");
            this.btnCloseFDContract.Name = "btnCloseFDContract";
            this.btnCloseFDContract.UseVisualStyleBackColor = true;
            this.btnCloseFDContract.Click += new System.EventHandler(this.btnCloseFDContract_Click);
            // 
            // gbInterestCalculation
            // 
            this.gbInterestCalculation.Controls.Add(this.tbTransferNumber);
            this.gbInterestCalculation.Controls.Add(this.lblChequeNumber);
            this.gbInterestCalculation.Controls.Add(this.cbAmountTransferMethod);
            this.gbInterestCalculation.Controls.Add(this.lblAmountTransferMethod);
            this.gbInterestCalculation.Controls.Add(this.lblPreMatured);
            this.gbInterestCalculation.Controls.Add(this.label32);
            this.gbInterestCalculation.Controls.Add(this.lbTotalAmount);
            this.gbInterestCalculation.Controls.Add(this.lbEffectivePenalty);
            this.gbInterestCalculation.Controls.Add(this.lbEffectiveDepositPeriod);
            this.gbInterestCalculation.Controls.Add(this.lbEffectiveInterest);
            this.gbInterestCalculation.Controls.Add(this.lbEffectiveInterestRate);
            this.gbInterestCalculation.Controls.Add(this.lblEffectiveInterestRate);
            this.gbInterestCalculation.Controls.Add(this.label29);
            this.gbInterestCalculation.Controls.Add(this.label28);
            this.gbInterestCalculation.Controls.Add(this.label26);
            this.gbInterestCalculation.Controls.Add(this.label25);
            this.gbInterestCalculation.Controls.Add(this.label24);
            resources.ApplyResources(this.gbInterestCalculation, "gbInterestCalculation");
            this.gbInterestCalculation.Name = "gbInterestCalculation";
            this.gbInterestCalculation.TabStop = false;
            // 
            // tbTransferNumber
            // 
            resources.ApplyResources(this.tbTransferNumber, "tbTransferNumber");
            this.tbTransferNumber.Name = "tbTransferNumber";
            this.tbTransferNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPenality_KeyPress);
            // 
            // lblChequeNumber
            // 
            resources.ApplyResources(this.lblChequeNumber, "lblChequeNumber");
            this.lblChequeNumber.Name = "lblChequeNumber";
            // 
            // cbAmountTransferMethod
            // 
            this.cbAmountTransferMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbAmountTransferMethod, "cbAmountTransferMethod");
            this.cbAmountTransferMethod.FormattingEnabled = true;
            this.cbAmountTransferMethod.Items.AddRange(new object[] {
            resources.GetString("cbAmountTransferMethod.Items"),
            resources.GetString("cbAmountTransferMethod.Items1"),
            resources.GetString("cbAmountTransferMethod.Items2")});
            this.cbAmountTransferMethod.Name = "cbAmountTransferMethod";
            this.cbAmountTransferMethod.SelectedIndexChanged += new System.EventHandler(this.cbAmountTransferMethod_SelectedIndexChanged);
            // 
            // lblAmountTransferMethod
            // 
            resources.ApplyResources(this.lblAmountTransferMethod, "lblAmountTransferMethod");
            this.lblAmountTransferMethod.Name = "lblAmountTransferMethod";
            // 
            // lblPreMatured
            // 
            resources.ApplyResources(this.lblPreMatured, "lblPreMatured");
            this.lblPreMatured.Name = "lblPreMatured";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // lbTotalAmount
            // 
            resources.ApplyResources(this.lbTotalAmount, "lbTotalAmount");
            this.lbTotalAmount.Name = "lbTotalAmount";
            // 
            // lbEffectivePenalty
            // 
            resources.ApplyResources(this.lbEffectivePenalty, "lbEffectivePenalty");
            this.lbEffectivePenalty.Name = "lbEffectivePenalty";
            // 
            // lbEffectiveDepositPeriod
            // 
            resources.ApplyResources(this.lbEffectiveDepositPeriod, "lbEffectiveDepositPeriod");
            this.lbEffectiveDepositPeriod.Name = "lbEffectiveDepositPeriod";
            // 
            // lbEffectiveInterest
            // 
            resources.ApplyResources(this.lbEffectiveInterest, "lbEffectiveInterest");
            this.lbEffectiveInterest.Name = "lbEffectiveInterest";
            // 
            // lbEffectiveInterestRate
            // 
            resources.ApplyResources(this.lbEffectiveInterestRate, "lbEffectiveInterestRate");
            this.lbEffectiveInterestRate.Name = "lbEffectiveInterestRate";
            // 
            // lblEffectiveInterestRate
            // 
            resources.ApplyResources(this.lblEffectiveInterestRate, "lblEffectiveInterestRate");
            this.lblEffectiveInterestRate.Name = "lblEffectiveInterestRate";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // tbComment
            // 
            resources.ApplyResources(this.tbComment, "tbComment");
            this.tbComment.Name = "tbComment";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // cbAccountingOfficer
            // 
            this.cbAccountingOfficer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbAccountingOfficer, "cbAccountingOfficer");
            this.cbAccountingOfficer.FormattingEnabled = true;
            this.cbAccountingOfficer.Name = "cbAccountingOfficer";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tbProductCode
            // 
            resources.ApplyResources(this.tbProductCode, "tbProductCode");
            this.tbProductCode.Name = "tbProductCode";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnAddFixedDepositProduct
            // 
            resources.ApplyResources(this.btnAddFixedDepositProduct, "btnAddFixedDepositProduct");
            this.btnAddFixedDepositProduct.Name = "btnAddFixedDepositProduct";
            this.btnAddFixedDepositProduct.UseVisualStyleBackColor = true;
            this.btnAddFixedDepositProduct.Click += new System.EventHandler(this.btnAddFixedDepositProduct_Click);
            // 
            // cbFixedDepositProduct
            // 
            this.cbFixedDepositProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbFixedDepositProduct, "cbFixedDepositProduct");
            this.cbFixedDepositProduct.FormattingEnabled = true;
            this.cbFixedDepositProduct.Items.AddRange(new object[] {
            resources.GetString("cbFixedDepositProduct.Items")});
            this.cbFixedDepositProduct.Name = "cbFixedDepositProduct";
            this.cbFixedDepositProduct.SelectedIndexChanged += new System.EventHandler(this.cbFixedDepositProduct_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblFDMaturityMinMax);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbMaturityPeriod);
            this.groupBox4.Controls.Add(this.label12);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // lblFDMaturityMinMax
            // 
            resources.ApplyResources(this.lblFDMaturityMinMax, "lblFDMaturityMinMax");
            this.lblFDMaturityMinMax.Name = "lblFDMaturityMinMax";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tbMaturityPeriod
            // 
            resources.ApplyResources(this.tbMaturityPeriod, "tbMaturityPeriod");
            this.tbMaturityPeriod.Name = "tbMaturityPeriod";
            this.tbMaturityPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPenality_KeyPress);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblFDPenaltyMinMax);
            this.groupBox5.Controls.Add(this.rbPenalityTypeRate);
            this.groupBox5.Controls.Add(this.rbPenalityTypeFlat);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.tbPenality);
            this.groupBox5.Controls.Add(this.label15);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // lblFDPenaltyMinMax
            // 
            resources.ApplyResources(this.lblFDPenaltyMinMax, "lblFDPenaltyMinMax");
            this.lblFDPenaltyMinMax.Name = "lblFDPenaltyMinMax";
            // 
            // rbPenalityTypeRate
            // 
            resources.ApplyResources(this.rbPenalityTypeRate, "rbPenalityTypeRate");
            this.rbPenalityTypeRate.Name = "rbPenalityTypeRate";
            // 
            // rbPenalityTypeFlat
            // 
            resources.ApplyResources(this.rbPenalityTypeFlat, "rbPenalityTypeFlat");
            this.rbPenalityTypeFlat.Checked = true;
            this.rbPenalityTypeFlat.Name = "rbPenalityTypeFlat";
            this.rbPenalityTypeFlat.TabStop = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // tbPenality
            // 
            resources.ApplyResources(this.tbPenality, "tbPenality");
            this.tbPenality.Name = "tbPenality";
            this.tbPenality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPenality_KeyPress);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // gbFrequency
            // 
            this.gbFrequency.Controls.Add(this.label27);
            this.gbFrequency.Controls.Add(this.tbFrequencyMonths);
            this.gbFrequency.Controls.Add(this.lbAccrual);
            resources.ApplyResources(this.gbFrequency, "gbFrequency");
            this.gbFrequency.Name = "gbFrequency";
            this.gbFrequency.TabStop = false;
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // tbFrequencyMonths
            // 
            resources.ApplyResources(this.tbFrequencyMonths, "tbFrequencyMonths");
            this.tbFrequencyMonths.Name = "tbFrequencyMonths";
            this.tbFrequencyMonths.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPenality_KeyPress);
            // 
            // lbAccrual
            // 
            resources.ApplyResources(this.lbAccrual, "lbAccrual");
            this.lbAccrual.Name = "lbAccrual";
            // 
            // lbNameSavingProduct
            // 
            resources.ApplyResources(this.lbNameSavingProduct, "lbNameSavingProduct");
            this.lbNameSavingProduct.Name = "lbNameSavingProduct";
            // 
            // gbInitialAmount
            // 
            this.gbInitialAmount.Controls.Add(this.lblFDInitialAmountMinMax);
            this.gbInitialAmount.Controls.Add(this.tbInitialAmount);
            this.gbInitialAmount.Controls.Add(this.lbInitialAmountMin);
            resources.ApplyResources(this.gbInitialAmount, "gbInitialAmount");
            this.gbInitialAmount.Name = "gbInitialAmount";
            this.gbInitialAmount.TabStop = false;
            // 
            // lblFDInitialAmountMinMax
            // 
            resources.ApplyResources(this.lblFDInitialAmountMinMax, "lblFDInitialAmountMinMax");
            this.lblFDInitialAmountMinMax.Name = "lblFDInitialAmountMinMax";
            // 
            // tbInitialAmount
            // 
            resources.ApplyResources(this.tbInitialAmount, "tbInitialAmount");
            this.tbInitialAmount.Name = "tbInitialAmount";
            this.tbInitialAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPenality_KeyPress);
            // 
            // lbInitialAmountMin
            // 
            resources.ApplyResources(this.lbInitialAmountMin, "lbInitialAmountMin");
            this.lbInitialAmountMin.Name = "lbInitialAmountMin";
            // 
            // gbInterestRate
            // 
            this.gbInterestRate.Controls.Add(this.cbFDLibor);
            this.gbInterestRate.Controls.Add(this.lblFDLIBOR);
            this.gbInterestRate.Controls.Add(this.lblFDInterestMinMax);
            this.gbInterestRate.Controls.Add(this.lbYearlyInterestRateMin);
            this.gbInterestRate.Controls.Add(this.tbInterestRate);
            this.gbInterestRate.Controls.Add(this.lbInterestRateMin);
            resources.ApplyResources(this.gbInterestRate, "gbInterestRate");
            this.gbInterestRate.Name = "gbInterestRate";
            this.gbInterestRate.TabStop = false;
            // 
            // cbFDLibor
            // 
            resources.ApplyResources(this.cbFDLibor, "cbFDLibor");
            this.cbFDLibor.Name = "cbFDLibor";
            this.cbFDLibor.UseVisualStyleBackColor = true;
            // 
            // lblFDLIBOR
            // 
            resources.ApplyResources(this.lblFDLIBOR, "lblFDLIBOR");
            this.lblFDLIBOR.Name = "lblFDLIBOR";
            // 
            // lblFDInterestMinMax
            // 
            resources.ApplyResources(this.lblFDInterestMinMax, "lblFDInterestMinMax");
            this.lblFDInterestMinMax.Name = "lblFDInterestMinMax";
            // 
            // lbYearlyInterestRateMin
            // 
            resources.ApplyResources(this.lbYearlyInterestRateMin, "lbYearlyInterestRateMin");
            this.lbYearlyInterestRateMin.Name = "lbYearlyInterestRateMin";
            // 
            // tbInterestRate
            // 
            resources.ApplyResources(this.tbInterestRate, "tbInterestRate");
            this.tbInterestRate.Name = "tbInterestRate";
            this.tbInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPenality_KeyPress);
            // 
            // lbInterestRateMin
            // 
            resources.ApplyResources(this.lbInterestRateMin, "lbInterestRateMin");
            this.lbInterestRateMin.Name = "lbInterestRateMin";
            // 
            // tabPageCurrentAccount
            // 
            this.tabPageCurrentAccount.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCurrentAccount.Controls.Add(this.lblLIBOR);
            this.tabPageCurrentAccount.Controls.Add(this.cbLIBOR);
            this.tabPageCurrentAccount.Controls.Add(this.button3);
            this.tabPageCurrentAccount.Controls.Add(this.lblCAInterestRateMinMax);
            this.tabPageCurrentAccount.Controls.Add(this.lblCAInitialAmountMinMax);
            this.tabPageCurrentAccount.Controls.Add(this.checkBoxOverdraftApplied);
            this.tabPageCurrentAccount.Controls.Add(this.tbCurrentInitialAmount);
            this.tabPageCurrentAccount.Controls.Add(this.tbCalculationFrequency);
            this.tabPageCurrentAccount.Controls.Add(this.label43);
            this.tabPageCurrentAccount.Controls.Add(this.label20);
            this.tabPageCurrentAccount.Controls.Add(this.label34);
            this.tabPageCurrentAccount.Controls.Add(this.tabControlCurrentAccount);
            this.tabPageCurrentAccount.Controls.Add(this.tbCAInterestRate);
            this.tabPageCurrentAccount.Controls.Add(this.tbCABalanceAmount);
            this.tabPageCurrentAccount.Controls.Add(this.label33);
            this.tabPageCurrentAccount.Controls.Add(this.btnTransactions);
            this.tabPageCurrentAccount.Controls.Add(this.lblBalanceAmount);
            this.tabPageCurrentAccount.Controls.Add(this.btnOverdraft);
            this.tabPageCurrentAccount.Controls.Add(this.gbInitialPayment);
            this.tabPageCurrentAccount.Controls.Add(this.gbAmount);
            this.tabPageCurrentAccount.Controls.Add(this.tbCAClosedDate);
            this.tabPageCurrentAccount.Controls.Add(this.lblCAClosedDate);
            this.tabPageCurrentAccount.Controls.Add(this.btnCAPrint);
            this.tabPageCurrentAccount.Controls.Add(this.btnCloseAccount);
            this.tabPageCurrentAccount.Controls.Add(this.cbCAAccountStatus);
            this.tabPageCurrentAccount.Controls.Add(this.lblCAAcountStatus);
            this.tabPageCurrentAccount.Controls.Add(this.tbCAOpenedDate);
            this.tabPageCurrentAccount.Controls.Add(this.lblCAOpenedDate);
            this.tabPageCurrentAccount.Controls.Add(this.tbCAProductCode);
            this.tabPageCurrentAccount.Controls.Add(this.lblCAProductCode);
            this.tabPageCurrentAccount.Controls.Add(this.btnAddCurrentAccountProduct);
            this.tabPageCurrentAccount.Controls.Add(this.tbCurrentAccountComment);
            this.tabPageCurrentAccount.Controls.Add(this.label16);
            this.tabPageCurrentAccount.Controls.Add(this.cbCurrentAccountingOfficer);
            this.tabPageCurrentAccount.Controls.Add(this.label17);
            this.tabPageCurrentAccount.Controls.Add(this.tbCurrentAccountProductCode);
            this.tabPageCurrentAccount.Controls.Add(this.label18);
            this.tabPageCurrentAccount.Controls.Add(this.cbCurrentAccountProducts);
            this.tabPageCurrentAccount.Controls.Add(this.label19);
            resources.ApplyResources(this.tabPageCurrentAccount, "tabPageCurrentAccount");
            this.tabPageCurrentAccount.Name = "tabPageCurrentAccount";
            // 
            // lblLIBOR
            // 
            resources.ApplyResources(this.lblLIBOR, "lblLIBOR");
            this.lblLIBOR.Name = "lblLIBOR";
            // 
            // cbLIBOR
            // 
            resources.ApplyResources(this.cbLIBOR, "cbLIBOR");
            this.cbLIBOR.Name = "cbLIBOR";
            this.cbLIBOR.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblCAInterestRateMinMax
            // 
            resources.ApplyResources(this.lblCAInterestRateMinMax, "lblCAInterestRateMinMax");
            this.lblCAInterestRateMinMax.Name = "lblCAInterestRateMinMax";
            // 
            // lblCAInitialAmountMinMax
            // 
            resources.ApplyResources(this.lblCAInitialAmountMinMax, "lblCAInitialAmountMinMax");
            this.lblCAInitialAmountMinMax.Name = "lblCAInitialAmountMinMax";
            // 
            // checkBoxOverdraftApplied
            // 
            resources.ApplyResources(this.checkBoxOverdraftApplied, "checkBoxOverdraftApplied");
            this.checkBoxOverdraftApplied.Name = "checkBoxOverdraftApplied";
            this.checkBoxOverdraftApplied.UseVisualStyleBackColor = true;
            this.checkBoxOverdraftApplied.CheckedChanged += new System.EventHandler(this.checkBoxOverdraftApplied_CheckedChanged);
            // 
            // tbCurrentInitialAmount
            // 
            resources.ApplyResources(this.tbCurrentInitialAmount, "tbCurrentInitialAmount");
            this.tbCurrentInitialAmount.Name = "tbCurrentInitialAmount";
            this.tbCurrentInitialAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // tbCalculationFrequency
            // 
            resources.ApplyResources(this.tbCalculationFrequency, "tbCalculationFrequency");
            this.tbCalculationFrequency.Name = "tbCalculationFrequency";
            this.tbCalculationFrequency.TextChanged += new System.EventHandler(this.tbCalculationFrequency_TextChanged);
            this.tbCalculationFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // tabControlCurrentAccount
            // 
            this.tabControlCurrentAccount.Controls.Add(this.tabPageFees);
            this.tabControlCurrentAccount.Controls.Add(this.tabPageOverdraft);
            this.tabControlCurrentAccount.Controls.Add(this.tabPageCloseAccount);
            this.tabControlCurrentAccount.Controls.Add(this.tabPageReopenAccount);
            this.tabControlCurrentAccount.Controls.Add(this.tabPageFeesTransactions);
            this.tabControlCurrentAccount.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControlCurrentAccount, "tabControlCurrentAccount");
            this.tabControlCurrentAccount.Name = "tabControlCurrentAccount";
            this.tabControlCurrentAccount.SelectedIndex = 0;
            // 
            // tabPageFees
            // 
            this.tabPageFees.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFees.Controls.Add(this.gbEntryFees);
            this.tabPageFees.Controls.Add(this.gtManagementFees);
            resources.ApplyResources(this.tabPageFees, "tabPageFees");
            this.tabPageFees.Name = "tabPageFees";
            // 
            // gbEntryFees
            // 
            this.gbEntryFees.Controls.Add(this.lblCAEntryFeesMinMax);
            this.gbEntryFees.Controls.Add(this.rbRateEntryFees);
            this.gbEntryFees.Controls.Add(this.rbFlatEntryFees);
            this.gbEntryFees.Controls.Add(this.lbEntryFeesType);
            this.gbEntryFees.Controls.Add(this.tbEntryFees);
            this.gbEntryFees.Controls.Add(this.lbEntryFeesMin);
            resources.ApplyResources(this.gbEntryFees, "gbEntryFees");
            this.gbEntryFees.Name = "gbEntryFees";
            this.gbEntryFees.TabStop = false;
            // 
            // lblCAEntryFeesMinMax
            // 
            resources.ApplyResources(this.lblCAEntryFeesMinMax, "lblCAEntryFeesMinMax");
            this.lblCAEntryFeesMinMax.Name = "lblCAEntryFeesMinMax";
            // 
            // rbRateEntryFees
            // 
            resources.ApplyResources(this.rbRateEntryFees, "rbRateEntryFees");
            this.rbRateEntryFees.Name = "rbRateEntryFees";
            this.rbRateEntryFees.CheckedChanged += new System.EventHandler(this.rbRateEntryFees_CheckedChanged_1);
            // 
            // rbFlatEntryFees
            // 
            resources.ApplyResources(this.rbFlatEntryFees, "rbFlatEntryFees");
            this.rbFlatEntryFees.Checked = true;
            this.rbFlatEntryFees.Name = "rbFlatEntryFees";
            this.rbFlatEntryFees.TabStop = true;
            this.rbFlatEntryFees.CheckedChanged += new System.EventHandler(this.rbFlatEntryFees_CheckedChanged);
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
            this.tbEntryFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEntryFees_KeyPress);
            // 
            // lbEntryFeesMin
            // 
            resources.ApplyResources(this.lbEntryFeesMin, "lbEntryFeesMin");
            this.lbEntryFeesMin.Name = "lbEntryFeesMin";
            // 
            // gtManagementFees
            // 
            this.gtManagementFees.Controls.Add(this.lblCAManagementFeesMinMax);
            this.gtManagementFees.Controls.Add(this.label38);
            this.gtManagementFees.Controls.Add(this.rbRateManagementFees);
            this.gtManagementFees.Controls.Add(this.rbFlatManagementFees);
            this.gtManagementFees.Controls.Add(this.lbManagementFeesType);
            this.gtManagementFees.Controls.Add(this.tbManagementFees);
            this.gtManagementFees.Controls.Add(this.lbManagementFeesMin);
            resources.ApplyResources(this.gtManagementFees, "gtManagementFees");
            this.gtManagementFees.Name = "gtManagementFees";
            this.gtManagementFees.TabStop = false;
            // 
            // lblCAManagementFeesMinMax
            // 
            resources.ApplyResources(this.lblCAManagementFeesMinMax, "lblCAManagementFeesMinMax");
            this.lblCAManagementFeesMinMax.Name = "lblCAManagementFeesMinMax";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // rbRateManagementFees
            // 
            resources.ApplyResources(this.rbRateManagementFees, "rbRateManagementFees");
            this.rbRateManagementFees.Name = "rbRateManagementFees";
            this.rbRateManagementFees.CheckedChanged += new System.EventHandler(this.rbRateManagementFees_CheckedChanged);
            // 
            // rbFlatManagementFees
            // 
            resources.ApplyResources(this.rbFlatManagementFees, "rbFlatManagementFees");
            this.rbFlatManagementFees.Checked = true;
            this.rbFlatManagementFees.Name = "rbFlatManagementFees";
            this.rbFlatManagementFees.TabStop = true;
            this.rbFlatManagementFees.CheckedChanged += new System.EventHandler(this.rbFlatManagementFees_CheckedChanged);
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
            this.tbManagementFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEntryFees_KeyPress);
            // 
            // lbManagementFeesMin
            // 
            resources.ApplyResources(this.lbManagementFeesMin, "lbManagementFeesMin");
            this.lbManagementFeesMin.Name = "lbManagementFeesMin";
            // 
            // tabPageOverdraft
            // 
            this.tabPageOverdraft.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageOverdraft.Controls.Add(this.tbOverdraftDate);
            this.tabPageOverdraft.Controls.Add(this.lblOverdraftAppliedDate);
            this.tabPageOverdraft.Controls.Add(this.groupBox6);
            this.tabPageOverdraft.Controls.Add(this.groupBox3);
            this.tabPageOverdraft.Controls.Add(this.tbOverdraftAmount);
            this.tabPageOverdraft.Controls.Add(this.label35);
            this.tabPageOverdraft.Controls.Add(this.gtOverdraftFees);
            resources.ApplyResources(this.tabPageOverdraft, "tabPageOverdraft");
            this.tabPageOverdraft.Name = "tabPageOverdraft";
            // 
            // tbOverdraftDate
            // 
            resources.ApplyResources(this.tbOverdraftDate, "tbOverdraftDate");
            this.tbOverdraftDate.Name = "tbOverdraftDate";
            // 
            // lblOverdraftAppliedDate
            // 
            resources.ApplyResources(this.lblOverdraftAppliedDate, "lblOverdraftAppliedDate");
            this.lblOverdraftAppliedDate.Name = "lblOverdraftAppliedDate";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCACommitmentFeesMinMax);
            this.groupBox6.Controls.Add(this.label41);
            this.groupBox6.Controls.Add(this.rbODCommitmentTypeRate);
            this.groupBox6.Controls.Add(this.rbODCommitmentTypeFlat);
            this.groupBox6.Controls.Add(this.label42);
            this.groupBox6.Controls.Add(this.tbCAODCommitmentFee);
            this.groupBox6.Controls.Add(this.label45);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // lblCACommitmentFeesMinMax
            // 
            resources.ApplyResources(this.lblCACommitmentFeesMinMax, "lblCACommitmentFeesMinMax");
            this.lblCACommitmentFeesMinMax.Name = "lblCACommitmentFeesMinMax";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // rbODCommitmentTypeRate
            // 
            resources.ApplyResources(this.rbODCommitmentTypeRate, "rbODCommitmentTypeRate");
            this.rbODCommitmentTypeRate.Checked = true;
            this.rbODCommitmentTypeRate.Name = "rbODCommitmentTypeRate";
            this.rbODCommitmentTypeRate.TabStop = true;
            // 
            // rbODCommitmentTypeFlat
            // 
            resources.ApplyResources(this.rbODCommitmentTypeFlat, "rbODCommitmentTypeFlat");
            this.rbODCommitmentTypeFlat.Name = "rbODCommitmentTypeFlat";
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // tbCAODCommitmentFee
            // 
            resources.ApplyResources(this.tbCAODCommitmentFee, "tbCAODCommitmentFee");
            this.tbCAODCommitmentFee.Name = "tbCAODCommitmentFee";
            this.tbCAODCommitmentFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCAODInterestMinMax);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.rbODInterestTypeRate);
            this.groupBox3.Controls.Add(this.rbODInterestTypeFlat);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.tbCAODInterestRate);
            this.groupBox3.Controls.Add(this.label40);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // lblCAODInterestMinMax
            // 
            resources.ApplyResources(this.lblCAODInterestMinMax, "lblCAODInterestMinMax");
            this.lblCAODInterestMinMax.Name = "lblCAODInterestMinMax";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // rbODInterestTypeRate
            // 
            resources.ApplyResources(this.rbODInterestTypeRate, "rbODInterestTypeRate");
            this.rbODInterestTypeRate.Checked = true;
            this.rbODInterestTypeRate.Name = "rbODInterestTypeRate";
            this.rbODInterestTypeRate.TabStop = true;
            // 
            // rbODInterestTypeFlat
            // 
            resources.ApplyResources(this.rbODInterestTypeFlat, "rbODInterestTypeFlat");
            this.rbODInterestTypeFlat.Name = "rbODInterestTypeFlat";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // tbCAODInterestRate
            // 
            resources.ApplyResources(this.tbCAODInterestRate, "tbCAODInterestRate");
            this.tbCAODInterestRate.Name = "tbCAODInterestRate";
            this.tbCAODInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // tbOverdraftAmount
            // 
            resources.ApplyResources(this.tbOverdraftAmount, "tbOverdraftAmount");
            this.tbOverdraftAmount.Name = "tbOverdraftAmount";
            this.tbOverdraftAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // gtOverdraftFees
            // 
            this.gtOverdraftFees.Controls.Add(this.lblCAOverdraftFeesMinMax);
            this.gtOverdraftFees.Controls.Add(this.label36);
            this.gtOverdraftFees.Controls.Add(this.rbRateOverdraftFees);
            this.gtOverdraftFees.Controls.Add(this.rbFlatOverdraftFees);
            this.gtOverdraftFees.Controls.Add(this.lbOverdraftFeesType);
            this.gtOverdraftFees.Controls.Add(this.tbOverdraftFees);
            this.gtOverdraftFees.Controls.Add(this.lbOverdraftFeesMin);
            resources.ApplyResources(this.gtOverdraftFees, "gtOverdraftFees");
            this.gtOverdraftFees.Name = "gtOverdraftFees";
            this.gtOverdraftFees.TabStop = false;
            // 
            // lblCAOverdraftFeesMinMax
            // 
            resources.ApplyResources(this.lblCAOverdraftFeesMinMax, "lblCAOverdraftFeesMinMax");
            this.lblCAOverdraftFeesMinMax.Name = "lblCAOverdraftFeesMinMax";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // rbRateOverdraftFees
            // 
            resources.ApplyResources(this.rbRateOverdraftFees, "rbRateOverdraftFees");
            this.rbRateOverdraftFees.Name = "rbRateOverdraftFees";
            this.rbRateOverdraftFees.CheckedChanged += new System.EventHandler(this.rbRateOverdraftFees_CheckedChanged);
            // 
            // rbFlatOverdraftFees
            // 
            resources.ApplyResources(this.rbFlatOverdraftFees, "rbFlatOverdraftFees");
            this.rbFlatOverdraftFees.Checked = true;
            this.rbFlatOverdraftFees.Name = "rbFlatOverdraftFees";
            this.rbFlatOverdraftFees.TabStop = true;
            this.rbFlatOverdraftFees.CheckedChanged += new System.EventHandler(this.rbFlatOverdraftFees_CheckedChanged);
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
            this.tbOverdraftFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // lbOverdraftFeesMin
            // 
            resources.ApplyResources(this.lbOverdraftFeesMin, "lbOverdraftFeesMin");
            this.lbOverdraftFeesMin.Name = "lbOverdraftFeesMin";
            // 
            // tabPageCloseAccount
            // 
            this.tabPageCloseAccount.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCloseAccount.Controls.Add(this.gbCloseFees);
            resources.ApplyResources(this.tabPageCloseAccount, "tabPageCloseAccount");
            this.tabPageCloseAccount.Name = "tabPageCloseAccount";
            // 
            // gbCloseFees
            // 
            this.gbCloseFees.Controls.Add(this.lblCACloseFeesMinMax);
            this.gbCloseFees.Controls.Add(this.rbRateCloseFees);
            this.gbCloseFees.Controls.Add(this.rbFlatCloseFees);
            this.gbCloseFees.Controls.Add(this.lbCloseFeesType);
            this.gbCloseFees.Controls.Add(this.tbCloseFees);
            this.gbCloseFees.Controls.Add(this.lbCloseFeesMin);
            resources.ApplyResources(this.gbCloseFees, "gbCloseFees");
            this.gbCloseFees.Name = "gbCloseFees";
            this.gbCloseFees.TabStop = false;
            // 
            // lblCACloseFeesMinMax
            // 
            resources.ApplyResources(this.lblCACloseFeesMinMax, "lblCACloseFeesMinMax");
            this.lblCACloseFeesMinMax.Name = "lblCACloseFeesMinMax";
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
            this.tbCloseFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCloseFees_KeyPress);
            // 
            // lbCloseFeesMin
            // 
            resources.ApplyResources(this.lbCloseFeesMin, "lbCloseFeesMin");
            this.lbCloseFeesMin.Name = "lbCloseFeesMin";
            // 
            // tabPageReopenAccount
            // 
            this.tabPageReopenAccount.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageReopenAccount.Controls.Add(this.gbReopenFees);
            resources.ApplyResources(this.tabPageReopenAccount, "tabPageReopenAccount");
            this.tabPageReopenAccount.Name = "tabPageReopenAccount";
            // 
            // gbReopenFees
            // 
            this.gbReopenFees.Controls.Add(this.lblCAReopenFeesMinMax);
            this.gbReopenFees.Controls.Add(this.rbRateReopenFees);
            this.gbReopenFees.Controls.Add(this.rbFlatReopenFees);
            this.gbReopenFees.Controls.Add(this.lbReopenFeesType);
            this.gbReopenFees.Controls.Add(this.tbReopenFees);
            this.gbReopenFees.Controls.Add(this.lbReopenFeesMin);
            resources.ApplyResources(this.gbReopenFees, "gbReopenFees");
            this.gbReopenFees.Name = "gbReopenFees";
            this.gbReopenFees.TabStop = false;
            // 
            // lblCAReopenFeesMinMax
            // 
            resources.ApplyResources(this.lblCAReopenFeesMinMax, "lblCAReopenFeesMinMax");
            this.lblCAReopenFeesMinMax.Name = "lblCAReopenFeesMinMax";
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
            this.tbReopenFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReopenFees_KeyPress);
            // 
            // lbReopenFeesMin
            // 
            resources.ApplyResources(this.lbReopenFeesMin, "lbReopenFeesMin");
            this.lbReopenFeesMin.Name = "lbReopenFeesMin";
            // 
            // tabPageFeesTransactions
            // 
            this.tabPageFeesTransactions.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFeesTransactions.Controls.Add(this.listViewFeeTransactions);
            resources.ApplyResources(this.tabPageFeesTransactions, "tabPageFeesTransactions");
            this.tabPageFeesTransactions.Name = "tabPageFeesTransactions";
            // 
            // listViewFeeTransactions
            // 
            this.listViewFeeTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader39,
            this.chToAccount,
            this.chAmount,
            this.chFeeDate,
            this.chPurposeOfTransfer,
            this.chTransactionType,
            this.chFeesBalance});
            this.listViewFeeTransactions.GridLines = true;
            resources.ApplyResources(this.listViewFeeTransactions, "listViewFeeTransactions");
            this.listViewFeeTransactions.Name = "listViewFeeTransactions";
            this.listViewFeeTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewFeeTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader39
            // 
            resources.ApplyResources(this.columnHeader39, "columnHeader39");
            // 
            // chToAccount
            // 
            resources.ApplyResources(this.chToAccount, "chToAccount");
            // 
            // chAmount
            // 
            resources.ApplyResources(this.chAmount, "chAmount");
            // 
            // chFeeDate
            // 
            resources.ApplyResources(this.chFeeDate, "chFeeDate");
            // 
            // chPurposeOfTransfer
            // 
            resources.ApplyResources(this.chPurposeOfTransfer, "chPurposeOfTransfer");
            // 
            // chTransactionType
            // 
            resources.ApplyResources(this.chTransactionType, "chTransactionType");
            // 
            // chFeesBalance
            // 
            resources.ApplyResources(this.chFeesBalance, "chFeesBalance");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvCAEvents);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvCAEvents
            // 
            this.lvCAEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader42,
            this.columnHeader43,
            this.columnHeader44});
            this.lvCAEvents.GridLines = true;
            resources.ApplyResources(this.lvCAEvents, "lvCAEvents");
            this.lvCAEvents.Name = "lvCAEvents";
            this.lvCAEvents.UseCompatibleStateImageBehavior = false;
            this.lvCAEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader42
            // 
            resources.ApplyResources(this.columnHeader42, "columnHeader42");
            // 
            // columnHeader43
            // 
            resources.ApplyResources(this.columnHeader43, "columnHeader43");
            // 
            // columnHeader44
            // 
            resources.ApplyResources(this.columnHeader44, "columnHeader44");
            // 
            // tbCAInterestRate
            // 
            resources.ApplyResources(this.tbCAInterestRate, "tbCAInterestRate");
            this.tbCAInterestRate.Name = "tbCAInterestRate";
            this.tbCAInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // tbCABalanceAmount
            // 
            resources.ApplyResources(this.tbCABalanceAmount, "tbCABalanceAmount");
            this.tbCABalanceAmount.Name = "tbCABalanceAmount";
            this.tbCABalanceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // btnTransactions
            // 
            resources.ApplyResources(this.btnTransactions, "btnTransactions");
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // lblBalanceAmount
            // 
            resources.ApplyResources(this.lblBalanceAmount, "lblBalanceAmount");
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            // 
            // btnOverdraft
            // 
            resources.ApplyResources(this.btnOverdraft, "btnOverdraft");
            this.btnOverdraft.Name = "btnOverdraft";
            this.btnOverdraft.UseVisualStyleBackColor = true;
            this.btnOverdraft.Click += new System.EventHandler(this.btnOverdraft_Click);
            // 
            // gbInitialPayment
            // 
            this.gbInitialPayment.Controls.Add(this.cbCAInitialAmountMethod);
            this.gbInitialPayment.Controls.Add(this.tbInitialPaymentNumber);
            this.gbInitialPayment.Controls.Add(this.lblInitialChequeNumber);
            this.gbInitialPayment.Controls.Add(this.label23);
            resources.ApplyResources(this.gbInitialPayment, "gbInitialPayment");
            this.gbInitialPayment.Name = "gbInitialPayment";
            this.gbInitialPayment.TabStop = false;
            // 
            // cbCAInitialAmountMethod
            // 
            this.cbCAInitialAmountMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCAInitialAmountMethod, "cbCAInitialAmountMethod");
            this.cbCAInitialAmountMethod.FormattingEnabled = true;
            this.cbCAInitialAmountMethod.Items.AddRange(new object[] {
            resources.GetString("cbCAInitialAmountMethod.Items"),
            resources.GetString("cbCAInitialAmountMethod.Items1"),
            resources.GetString("cbCAInitialAmountMethod.Items2")});
            this.cbCAInitialAmountMethod.Name = "cbCAInitialAmountMethod";
            this.cbCAInitialAmountMethod.SelectedIndexChanged += new System.EventHandler(this.cbCAInitialAmountMethod_SelectedIndexChanged);
            // 
            // tbInitialPaymentNumber
            // 
            resources.ApplyResources(this.tbInitialPaymentNumber, "tbInitialPaymentNumber");
            this.tbInitialPaymentNumber.Name = "tbInitialPaymentNumber";
            this.tbInitialPaymentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // lblInitialChequeNumber
            // 
            resources.ApplyResources(this.lblInitialChequeNumber, "lblInitialChequeNumber");
            this.lblInitialChequeNumber.Name = "lblInitialChequeNumber";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // gbAmount
            // 
            this.gbAmount.Controls.Add(this.tbCAChequeAccount);
            this.gbAmount.Controls.Add(this.lblCAChequeNumber);
            this.gbAmount.Controls.Add(this.cbCAPaymentMethod);
            this.gbAmount.Controls.Add(this.label54);
            resources.ApplyResources(this.gbAmount, "gbAmount");
            this.gbAmount.Name = "gbAmount";
            this.gbAmount.TabStop = false;
            // 
            // tbCAChequeAccount
            // 
            resources.ApplyResources(this.tbCAChequeAccount, "tbCAChequeAccount");
            this.tbCAChequeAccount.Name = "tbCAChequeAccount";
            this.tbCAChequeAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentInitialAmount_KeyPress);
            // 
            // lblCAChequeNumber
            // 
            resources.ApplyResources(this.lblCAChequeNumber, "lblCAChequeNumber");
            this.lblCAChequeNumber.Name = "lblCAChequeNumber";
            // 
            // cbCAPaymentMethod
            // 
            this.cbCAPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCAPaymentMethod, "cbCAPaymentMethod");
            this.cbCAPaymentMethod.FormattingEnabled = true;
            this.cbCAPaymentMethod.Items.AddRange(new object[] {
            resources.GetString("cbCAPaymentMethod.Items"),
            resources.GetString("cbCAPaymentMethod.Items1"),
            resources.GetString("cbCAPaymentMethod.Items2")});
            this.cbCAPaymentMethod.Name = "cbCAPaymentMethod";
            this.cbCAPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbCAPaymentMethod_SelectedIndexChanged);
            // 
            // label54
            // 
            resources.ApplyResources(this.label54, "label54");
            this.label54.Name = "label54";
            // 
            // tbCAClosedDate
            // 
            resources.ApplyResources(this.tbCAClosedDate, "tbCAClosedDate");
            this.tbCAClosedDate.Name = "tbCAClosedDate";
            // 
            // lblCAClosedDate
            // 
            resources.ApplyResources(this.lblCAClosedDate, "lblCAClosedDate");
            this.lblCAClosedDate.Name = "lblCAClosedDate";
            // 
            // btnCAPrint
            // 
            resources.ApplyResources(this.btnCAPrint, "btnCAPrint");
            this.btnCAPrint.Name = "btnCAPrint";
            this.btnCAPrint.UseVisualStyleBackColor = true;
            // 
            // btnCloseAccount
            // 
            resources.ApplyResources(this.btnCloseAccount, "btnCloseAccount");
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.UseVisualStyleBackColor = true;
            this.btnCloseAccount.Click += new System.EventHandler(this.btnCloseAccount_Click);
            // 
            // cbCAAccountStatus
            // 
            this.cbCAAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCAAccountStatus, "cbCAAccountStatus");
            this.cbCAAccountStatus.FormattingEnabled = true;
            this.cbCAAccountStatus.Name = "cbCAAccountStatus";
            this.cbCAAccountStatus.SelectedIndexChanged += new System.EventHandler(this.cbCAAccountStatus_SelectedIndexChanged);
            // 
            // lblCAAcountStatus
            // 
            resources.ApplyResources(this.lblCAAcountStatus, "lblCAAcountStatus");
            this.lblCAAcountStatus.Name = "lblCAAcountStatus";
            // 
            // tbCAOpenedDate
            // 
            resources.ApplyResources(this.tbCAOpenedDate, "tbCAOpenedDate");
            this.tbCAOpenedDate.Name = "tbCAOpenedDate";
            // 
            // lblCAOpenedDate
            // 
            resources.ApplyResources(this.lblCAOpenedDate, "lblCAOpenedDate");
            this.lblCAOpenedDate.Name = "lblCAOpenedDate";
            // 
            // tbCAProductCode
            // 
            resources.ApplyResources(this.tbCAProductCode, "tbCAProductCode");
            this.tbCAProductCode.Name = "tbCAProductCode";
            // 
            // lblCAProductCode
            // 
            resources.ApplyResources(this.lblCAProductCode, "lblCAProductCode");
            this.lblCAProductCode.Name = "lblCAProductCode";
            // 
            // btnAddCurrentAccountProduct
            // 
            resources.ApplyResources(this.btnAddCurrentAccountProduct, "btnAddCurrentAccountProduct");
            this.btnAddCurrentAccountProduct.Name = "btnAddCurrentAccountProduct";
            this.btnAddCurrentAccountProduct.UseVisualStyleBackColor = true;
            this.btnAddCurrentAccountProduct.Click += new System.EventHandler(this.btnAddCurrentAccountProduct_Click);
            // 
            // tbCurrentAccountComment
            // 
            resources.ApplyResources(this.tbCurrentAccountComment, "tbCurrentAccountComment");
            this.tbCurrentAccountComment.Name = "tbCurrentAccountComment";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // cbCurrentAccountingOfficer
            // 
            this.cbCurrentAccountingOfficer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCurrentAccountingOfficer, "cbCurrentAccountingOfficer");
            this.cbCurrentAccountingOfficer.FormattingEnabled = true;
            this.cbCurrentAccountingOfficer.Name = "cbCurrentAccountingOfficer";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // tbCurrentAccountProductCode
            // 
            resources.ApplyResources(this.tbCurrentAccountProductCode, "tbCurrentAccountProductCode");
            this.tbCurrentAccountProductCode.Name = "tbCurrentAccountProductCode";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // cbCurrentAccountProducts
            // 
            this.cbCurrentAccountProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCurrentAccountProducts, "cbCurrentAccountProducts");
            this.cbCurrentAccountProducts.FormattingEnabled = true;
            this.cbCurrentAccountProducts.Items.AddRange(new object[] {
            resources.GetString("cbCurrentAccountProducts.Items")});
            this.cbCurrentAccountProducts.Name = "cbCurrentAccountProducts";
            this.cbCurrentAccountProducts.SelectedIndexChanged += new System.EventHandler(this.cbCurrentAccountProducts_SelectedIndexChanged);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.button2);
            this.tabPageTransactions.Controls.Add(this.button1);
            this.tabPageTransactions.Controls.Add(this.lvTransactions);
            this.tabPageTransactions.Controls.Add(this.label44);
            resources.ApplyResources(this.tabPageTransactions, "tabPageTransactions");
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvTransactions
            // 
            this.lvTransactions.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvTransactions.AllowColumnReorder = true;
            this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36,
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader41,
            this.columnHeader40});
            this.lvTransactions.FullRowSelect = true;
            this.lvTransactions.GridLines = true;
            resources.ApplyResources(this.lvTransactions, "lvTransactions");
            this.lvTransactions.Name = "lvTransactions";
            this.lvTransactions.UseCompatibleStateImageBehavior = false;
            this.lvTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader31
            // 
            resources.ApplyResources(this.columnHeader31, "columnHeader31");
            // 
            // columnHeader32
            // 
            resources.ApplyResources(this.columnHeader32, "columnHeader32");
            // 
            // columnHeader33
            // 
            resources.ApplyResources(this.columnHeader33, "columnHeader33");
            // 
            // columnHeader34
            // 
            resources.ApplyResources(this.columnHeader34, "columnHeader34");
            // 
            // columnHeader35
            // 
            resources.ApplyResources(this.columnHeader35, "columnHeader35");
            // 
            // columnHeader36
            // 
            resources.ApplyResources(this.columnHeader36, "columnHeader36");
            // 
            // columnHeader37
            // 
            resources.ApplyResources(this.columnHeader37, "columnHeader37");
            // 
            // columnHeader38
            // 
            resources.ApplyResources(this.columnHeader38, "columnHeader38");
            // 
            // columnHeader41
            // 
            resources.ApplyResources(this.columnHeader41, "columnHeader41");
            // 
            // columnHeader40
            // 
            resources.ApplyResources(this.columnHeader40, "columnHeader40");
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.label44, "label44");
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Name = "label44";
            // 
            // tabPageBGLC
            // 
            this.tabPageBGLC.Controls.Add(this.btnGenerateLOCLetter);
            this.tabPageBGLC.Controls.Add(this.btnGenerateBGLetter);
            this.tabPageBGLC.Controls.Add(this.btnViewLetterOfCredit);
            this.tabPageBGLC.Controls.Add(this.btnUpdateLetterOfCredit);
            this.tabPageBGLC.Controls.Add(this.btnAddLetterOfCredit);
            this.tabPageBGLC.Controls.Add(this.lvLetterOfCredit);
            this.tabPageBGLC.Controls.Add(this.label46);
            this.tabPageBGLC.Controls.Add(this.btnViewBankGuarantee);
            this.tabPageBGLC.Controls.Add(this.btnUpdateBankGuarantee);
            this.tabPageBGLC.Controls.Add(this.btnAddBankGuarantee);
            this.tabPageBGLC.Controls.Add(this.lvBankGuarantee);
            this.tabPageBGLC.Controls.Add(this.label22);
            resources.ApplyResources(this.tabPageBGLC, "tabPageBGLC");
            this.tabPageBGLC.Name = "tabPageBGLC";
            this.tabPageBGLC.UseVisualStyleBackColor = true;
            // 
            // btnGenerateLOCLetter
            // 
            resources.ApplyResources(this.btnGenerateLOCLetter, "btnGenerateLOCLetter");
            this.btnGenerateLOCLetter.Name = "btnGenerateLOCLetter";
            this.btnGenerateLOCLetter.Click += new System.EventHandler(this.btnGenerateLOCLetter_Click);
            // 
            // btnGenerateBGLetter
            // 
            resources.ApplyResources(this.btnGenerateBGLetter, "btnGenerateBGLetter");
            this.btnGenerateBGLetter.Name = "btnGenerateBGLetter";
            this.btnGenerateBGLetter.Click += new System.EventHandler(this.btnGenerateBGLetter_Click);
            // 
            // btnViewLetterOfCredit
            // 
            resources.ApplyResources(this.btnViewLetterOfCredit, "btnViewLetterOfCredit");
            this.btnViewLetterOfCredit.Name = "btnViewLetterOfCredit";
            this.btnViewLetterOfCredit.Click += new System.EventHandler(this.btnViewLetterOfCredit_Click);
            // 
            // btnUpdateLetterOfCredit
            // 
            resources.ApplyResources(this.btnUpdateLetterOfCredit, "btnUpdateLetterOfCredit");
            this.btnUpdateLetterOfCredit.Name = "btnUpdateLetterOfCredit";
            this.btnUpdateLetterOfCredit.Click += new System.EventHandler(this.btnUpdateLetterOfCredit_Click);
            // 
            // btnAddLetterOfCredit
            // 
            resources.ApplyResources(this.btnAddLetterOfCredit, "btnAddLetterOfCredit");
            this.btnAddLetterOfCredit.Name = "btnAddLetterOfCredit";
            this.btnAddLetterOfCredit.Click += new System.EventHandler(this.btnAddLetterOfCredit_Click);
            // 
            // lvLetterOfCredit
            // 
            this.lvLetterOfCredit.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvLetterOfCredit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader55,
            this.columnHeader56,
            this.columnHeader57,
            this.columnHeader58,
            this.columnHeader59,
            this.columnHeader60});
            this.lvLetterOfCredit.FullRowSelect = true;
            this.lvLetterOfCredit.GridLines = true;
            resources.ApplyResources(this.lvLetterOfCredit, "lvLetterOfCredit");
            this.lvLetterOfCredit.Name = "lvLetterOfCredit";
            this.lvLetterOfCredit.UseCompatibleStateImageBehavior = false;
            this.lvLetterOfCredit.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader53
            // 
            resources.ApplyResources(this.columnHeader53, "columnHeader53");
            // 
            // columnHeader54
            // 
            resources.ApplyResources(this.columnHeader54, "columnHeader54");
            // 
            // columnHeader55
            // 
            resources.ApplyResources(this.columnHeader55, "columnHeader55");
            // 
            // columnHeader56
            // 
            resources.ApplyResources(this.columnHeader56, "columnHeader56");
            // 
            // columnHeader57
            // 
            resources.ApplyResources(this.columnHeader57, "columnHeader57");
            // 
            // columnHeader58
            // 
            resources.ApplyResources(this.columnHeader58, "columnHeader58");
            // 
            // columnHeader59
            // 
            resources.ApplyResources(this.columnHeader59, "columnHeader59");
            // 
            // columnHeader60
            // 
            resources.ApplyResources(this.columnHeader60, "columnHeader60");
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.label46, "label46");
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Name = "label46";
            // 
            // btnViewBankGuarantee
            // 
            resources.ApplyResources(this.btnViewBankGuarantee, "btnViewBankGuarantee");
            this.btnViewBankGuarantee.Name = "btnViewBankGuarantee";
            this.btnViewBankGuarantee.Click += new System.EventHandler(this.btnViewBankGuarantee_Click);
            // 
            // btnUpdateBankGuarantee
            // 
            resources.ApplyResources(this.btnUpdateBankGuarantee, "btnUpdateBankGuarantee");
            this.btnUpdateBankGuarantee.Name = "btnUpdateBankGuarantee";
            this.btnUpdateBankGuarantee.Click += new System.EventHandler(this.btnUpdateBankGuarantee_Click);
            // 
            // btnAddBankGuarantee
            // 
            resources.ApplyResources(this.btnAddBankGuarantee, "btnAddBankGuarantee");
            this.btnAddBankGuarantee.Name = "btnAddBankGuarantee";
            this.btnAddBankGuarantee.Click += new System.EventHandler(this.btnAddBankGuarantee_Click);
            // 
            // lvBankGuarantee
            // 
            this.lvBankGuarantee.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvBankGuarantee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader45,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48,
            this.columnHeader49,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader52});
            this.lvBankGuarantee.FullRowSelect = true;
            this.lvBankGuarantee.GridLines = true;
            resources.ApplyResources(this.lvBankGuarantee, "lvBankGuarantee");
            this.lvBankGuarantee.Name = "lvBankGuarantee";
            this.lvBankGuarantee.UseCompatibleStateImageBehavior = false;
            this.lvBankGuarantee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader45
            // 
            resources.ApplyResources(this.columnHeader45, "columnHeader45");
            // 
            // columnHeader46
            // 
            resources.ApplyResources(this.columnHeader46, "columnHeader46");
            // 
            // columnHeader47
            // 
            resources.ApplyResources(this.columnHeader47, "columnHeader47");
            // 
            // columnHeader48
            // 
            resources.ApplyResources(this.columnHeader48, "columnHeader48");
            // 
            // columnHeader49
            // 
            resources.ApplyResources(this.columnHeader49, "columnHeader49");
            // 
            // columnHeader50
            // 
            resources.ApplyResources(this.columnHeader50, "columnHeader50");
            // 
            // columnHeader51
            // 
            resources.ApplyResources(this.columnHeader51, "columnHeader51");
            // 
            // columnHeader52
            // 
            resources.ApplyResources(this.columnHeader52, "columnHeader52");
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Name = "label22";
            // 
            // menuBtnAddSavingOperation
            // 
            this.menuBtnAddSavingOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savingDepositToolStripMenuItem,
            this.savingWithdrawToolStripMenuItem,
            this.savingTransferToolStripMenuItem,
            this.specialOperationToolStripMenuItem});
            this.menuBtnAddSavingOperation.Name = "contextMenuStrip1";
            resources.ApplyResources(this.menuBtnAddSavingOperation, "menuBtnAddSavingOperation");
            // 
            // savingDepositToolStripMenuItem
            // 
            this.savingDepositToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.savingDepositToolStripMenuItem.Name = "savingDepositToolStripMenuItem";
            resources.ApplyResources(this.savingDepositToolStripMenuItem, "savingDepositToolStripMenuItem");
            this.savingDepositToolStripMenuItem.Click += new System.EventHandler(this.buttonSavingDeposit_Click);
            // 
            // savingWithdrawToolStripMenuItem
            // 
            this.savingWithdrawToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.savingWithdrawToolStripMenuItem.Name = "savingWithdrawToolStripMenuItem";
            resources.ApplyResources(this.savingWithdrawToolStripMenuItem, "savingWithdrawToolStripMenuItem");
            this.savingWithdrawToolStripMenuItem.Click += new System.EventHandler(this.buttonSavingWithDraw_Click);
            // 
            // savingTransferToolStripMenuItem
            // 
            this.savingTransferToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.savingTransferToolStripMenuItem.Name = "savingTransferToolStripMenuItem";
            resources.ApplyResources(this.savingTransferToolStripMenuItem, "savingTransferToolStripMenuItem");
            this.savingTransferToolStripMenuItem.Click += new System.EventHandler(this.savingTransferToolStripMenuItem_Click);
            // 
            // specialOperationToolStripMenuItem
            // 
            this.specialOperationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.specialOperationToolStripMenuItem.Name = "specialOperationToolStripMenuItem";
            resources.ApplyResources(this.specialOperationToolStripMenuItem, "specialOperationToolStripMenuItem");
            this.specialOperationToolStripMenuItem.Click += new System.EventHandler(this.specialOperationToolStripMenuItem_Click);
            // 
            // olvColumnSACExportedBalance
            // 
            this.olvColumnSACExportedBalance.AspectName = "Id";
            this.olvColumnSACExportedBalance.IsVisible = false;
            resources.ApplyResources(this.olvColumnSACExportedBalance, "olvColumnSACExportedBalance");
            // 
            // olvColumnLACExportedBalance
            // 
            this.olvColumnLACExportedBalance.AspectName = "Id";
            this.olvColumnLACExportedBalance.IsVisible = false;
            resources.ApplyResources(this.olvColumnLACExportedBalance, "olvColumnLACExportedBalance");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // labelTitleRepayment
            // 
            resources.ApplyResources(this.labelTitleRepayment, "labelTitleRepayment");
            this.labelTitleRepayment.Name = "labelTitleRepayment";
            // 
            // buttonPrintSchedule
            // 
            this.buttonPrintSchedule.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.buttonPrintSchedule, "buttonPrintSchedule");
            this.buttonPrintSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.buttonPrintSchedule.Name = "buttonPrintSchedule";
            this.buttonPrintSchedule.UseVisualStyleBackColor = false;
            // 
            // buttonReschedule
            // 
            this.buttonReschedule.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.buttonReschedule, "buttonReschedule");
            this.buttonReschedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.buttonReschedule.Name = "buttonReschedule";
            this.buttonReschedule.UseVisualStyleBackColor = false;
            // 
            // buttonRepay
            // 
            this.buttonRepay.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.buttonRepay, "buttonRepay");
            this.buttonRepay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.buttonRepay.Name = "buttonRepay";
            this.buttonRepay.UseVisualStyleBackColor = false;
            // 
            // columnHeaderDate
            // 
            resources.ApplyResources(this.columnHeaderDate, "columnHeaderDate");
            // 
            // columnHeaderType
            // 
            resources.ApplyResources(this.columnHeaderType, "columnHeaderType");
            // 
            // columnHeaderPrincipal
            // 
            resources.ApplyResources(this.columnHeaderPrincipal, "columnHeaderPrincipal");
            // 
            // columnHeaderInterest
            // 
            resources.ApplyResources(this.columnHeaderInterest, "columnHeaderInterest");
            // 
            // columnHeaderFees
            // 
            resources.ApplyResources(this.columnHeaderFees, "columnHeaderFees");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // buttonLoanDisbursement
            // 
            resources.ApplyResources(this.buttonLoanDisbursement, "buttonLoanDisbursement");
            this.buttonLoanDisbursement.Name = "buttonLoanDisbursement";
            // 
            // labelExchangeRate
            // 
            resources.ApplyResources(this.labelExchangeRate, "labelExchangeRate");
            this.labelExchangeRate.Name = "labelExchangeRate";
            // 
            // contextMenuStripPackage
            // 
            this.contextMenuStripPackage.Name = "contextMenuStrip1";
            this.contextMenuStripPackage.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStripPackage, "contextMenuStripPackage");
            // 
            // toolStripSeparatorCopy
            // 
            this.toolStripSeparatorCopy.Name = "toolStripSeparatorCopy";
            resources.ApplyResources(this.toolStripSeparatorCopy, "toolStripSeparatorCopy");
            // 
            // toolStripMenuItemEditComment
            // 
            this.toolStripMenuItemEditComment.Name = "toolStripMenuItemEditComment";
            resources.ApplyResources(this.toolStripMenuItemEditComment, "toolStripMenuItemEditComment");
            this.toolStripMenuItemEditComment.Click += new System.EventHandler(this.toolStripMenuItemEditComment_Click);
            // 
            // toolStripMenuItemCancelPending
            // 
            this.toolStripMenuItemCancelPending.Name = "toolStripMenuItemCancelPending";
            resources.ApplyResources(this.toolStripMenuItemCancelPending, "toolStripMenuItemCancelPending");
            this.toolStripMenuItemCancelPending.Click += new System.EventHandler(this.toolStripMenuItemCancelPending_Click);
            // 
            // toolStripMenuItemConfirmPending
            // 
            this.toolStripMenuItemConfirmPending.Name = "toolStripMenuItemConfirmPending";
            resources.ApplyResources(this.toolStripMenuItemConfirmPending, "toolStripMenuItemConfirmPending");
            this.toolStripMenuItemConfirmPending.Click += new System.EventHandler(this.toolStripMenuItemConfirmPending_Click);
            // 
            // menuCollateralProducts
            // 
            this.menuCollateralProducts.Name = "menuCollateralProducts";
            resources.ApplyResources(this.menuCollateralProducts, "menuCollateralProducts");
            // 
            // menuPendingSavingEvents
            // 
            this.menuPendingSavingEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConfirmPendingSavingEvent,
            this.menuItemCancelPendingSavingEvent});
            this.menuPendingSavingEvents.Name = "menuPendingSavingEvents";
            resources.ApplyResources(this.menuPendingSavingEvents, "menuPendingSavingEvents");
            // 
            // menuItemConfirmPendingSavingEvent
            // 
            this.menuItemConfirmPendingSavingEvent.Name = "menuItemConfirmPendingSavingEvent";
            resources.ApplyResources(this.menuItemConfirmPendingSavingEvent, "menuItemConfirmPendingSavingEvent");
            this.menuItemConfirmPendingSavingEvent.Click += new System.EventHandler(this.menuItemConfirmPendingSavingEvent_Click);
            // 
            // menuItemCancelPendingSavingEvent
            // 
            this.menuItemCancelPendingSavingEvent.Name = "menuItemCancelPendingSavingEvent";
            resources.ApplyResources(this.menuItemCancelPendingSavingEvent, "menuItemCancelPendingSavingEvent");
            this.menuItemCancelPendingSavingEvent.Click += new System.EventHandler(this.menuItemCancelPendingSavingEvent_Click);
            // 
            // ClientForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabControlPerson);
            this.Name = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.Controls.SetChildIndex(this.tabControlPerson, 0);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel1.PerformLayout();
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProjectJobs)).EndInit();
            this.gBProjectFinancialPlan.ResumeLayout(false);
            this.gBProjectFinancialPlan.PerformLayout();
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            this.gBProjectFollowUp.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlGuarantorButtons.ResumeLayout(false);
            this.pnlGuarantorButtons.PerformLayout();
            this.pnlCollateralButtons.ResumeLayout(false);
            this.splitContainerContracts.Panel1.ResumeLayout(false);
            this.splitContainerContracts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContracts)).EndInit();
            this.splitContainerContracts.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tabControlPerson.ResumeLayout(false);
            this.tabPageProject.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxProjectDetails.ResumeLayout(false);
            this.groupBoxProjectDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControlProject.ResumeLayout(false);
            this.tabPageProjectLoans.ResumeLayout(false);
            this.pnlLoans.ResumeLayout(false);
            this.pnlLoans.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPageProjectAnalyses.ResumeLayout(false);
            this.tabPageProjectAnalyses.PerformLayout();
            this.tabPageCorporate.ResumeLayout(false);
            this.tabPageFollowUp.ResumeLayout(false);
            this.tabPageLoansDetails.ResumeLayout(false);
            this.tabPageLoansDetails.PerformLayout();
            this.tclLoanDetails.ResumeLayout(false);
            this.tabPageInstallments.ResumeLayout(false);
            this.loanDetailsButtonsPanel.ResumeLayout(false);
            this.gbxLoanDetails.ResumeLayout(false);
            this.gbxLoanDetails.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoanGracePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanNbOfInstallments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).EndInit();
            this.tabPageAdvancedSettings.ResumeLayout(false);
            this.tabPageAdvancedSettings.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.groupBoxAnticipatedRepaymentPenalties.ResumeLayout(false);
            this.groupBoxAnticipatedRepaymentPenalties.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBoxLoanLateFees.ResumeLayout(false);
            this.groupBoxLoanLateFees.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBoxEntryFees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEntryFees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCompulsoryAmountPercent)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tabPageCreditCommitee.ResumeLayout(false);
            this.tabPageCreditCommitee.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.pnlCCStatus.ResumeLayout(false);
            this.pnlCCStatus.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.tabPageLoanRepayment.ResumeLayout(false);
            this.tabControlRepayments.ResumeLayout(false);
            this.tabPageRepayments.ResumeLayout(false);
            this.tabPageRepayments.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageLoanGuarantees.ResumeLayout(false);
            this.tabPageSavingDetails.ResumeLayout(false);
            this.tabPageSavingDetails.PerformLayout();
            this.tabControlSavingsDetails.ResumeLayout(false);
            this.tabPageSavingsAmountsAndFees.ResumeLayout(false);
            this.tabPageSavingsAmountsAndFees.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.groupBoxSavingBalance.ResumeLayout(false);
            this.groupBoxSavingBalance.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.groupBoxSavingDeposit.ResumeLayout(false);
            this.groupBoxSavingDeposit.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.groupBoxSavingWithdraw.ResumeLayout(false);
            this.groupBoxSavingWithdraw.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.groupBoxSavingTransfer.ResumeLayout(false);
            this.groupBoxSavingTransfer.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.gbInterest.ResumeLayout(false);
            this.gbInterest.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.gbDepositInterest.ResumeLayout(false);
            this.gbDepositInterest.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tlpSBDetails.ResumeLayout(false);
            this.tlpSBDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIbtFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReopenFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgioFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChequeDepositFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverdraftFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCloseFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManagementFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositFees)).EndInit();
            this.tabPageSavingsEvents.ResumeLayout(false);
            this.tabPageLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvLoans)).EndInit();
            this.tpTermDeposit.ResumeLayout(false);
            this.tlpTermDeposit.ResumeLayout(false);
            this.tlpTermDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeriods)).EndInit();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.pnlSavingsButtons.ResumeLayout(false);
            this.groupBoxSaving.ResumeLayout(false);
            this.groupBoxSaving.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntryFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownInitialAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownInterestRate)).EndInit();
            this.tabPageContracts.ResumeLayout(false);
            this.tabPageFPCAContracts.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPageFixedDeposit.ResumeLayout(false);
            this.tbTransferNumberForm.ResumeLayout(false);
            this.tbTransferNumberForm.PerformLayout();
            this.gbFDInitialPayment.ResumeLayout(false);
            this.gbFDInitialPayment.PerformLayout();
            this.gbInterestCalculation.ResumeLayout(false);
            this.gbInterestCalculation.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbFrequency.ResumeLayout(false);
            this.gbFrequency.PerformLayout();
            this.gbInitialAmount.ResumeLayout(false);
            this.gbInitialAmount.PerformLayout();
            this.gbInterestRate.ResumeLayout(false);
            this.gbInterestRate.PerformLayout();
            this.tabPageCurrentAccount.ResumeLayout(false);
            this.tabPageCurrentAccount.PerformLayout();
            this.tabControlCurrentAccount.ResumeLayout(false);
            this.tabPageFees.ResumeLayout(false);
            this.gbEntryFees.ResumeLayout(false);
            this.gbEntryFees.PerformLayout();
            this.gtManagementFees.ResumeLayout(false);
            this.gtManagementFees.PerformLayout();
            this.tabPageOverdraft.ResumeLayout(false);
            this.tabPageOverdraft.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gtOverdraftFees.ResumeLayout(false);
            this.gtOverdraftFees.PerformLayout();
            this.tabPageCloseAccount.ResumeLayout(false);
            this.gbCloseFees.ResumeLayout(false);
            this.gbCloseFees.PerformLayout();
            this.tabPageReopenAccount.ResumeLayout(false);
            this.gbReopenFees.ResumeLayout(false);
            this.gbReopenFees.PerformLayout();
            this.tabPageFeesTransactions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbInitialPayment.ResumeLayout(false);
            this.gbInitialPayment.PerformLayout();
            this.gbAmount.ResumeLayout(false);
            this.gbAmount.PerformLayout();
            this.tabPageTransactions.ResumeLayout(false);
            this.tabPageBGLC.ResumeLayout(false);
            this.menuBtnAddSavingOperation.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuPendingSavingEvents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
           _product = null;
           _project = null;
           _credit = null;
           _guarantee = null;
           _person = null;
           _personUserControl = null;
           _groupUserControl = null;

           _loanShares = null;
           pendingFundingLineEvent = null;
           _users = null;
           _fundingLine = null;
           _corporate = null;
           _corporateUserControl = null;
           projectAddressUserControl = null;
           _followUpList = null;
           _savingsBookProduct = null;
           _saving = null;

           _client = null;

           _listGuarantors = null;
           _collaterals = null;

            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private TextBox textBoxProjectPurpose;
        private Label labelProjectPurpose;
        private System.Windows.Forms.Button buttonProjectSelectPurpose;
        private TabControl tabControlProject;
        private TabPage tabPageProjectAnalyses;
        private TabPage tabPageProjectLoans;
        private Label labelProjectAbilities;
        private Label labelProjectExperience;
        private TextBox textBoxProjectExperience;
        private TextBox textBoxProjectAbilities;
        private DateTimePicker dateTimePickerProjectBeginDate;
        private Label labelProjectDate;
        private TextBox textBoxProjectConcurrence;
        private TextBox textBoxProjectMarket;
        private Label labelProjectConcurrence;
        private Label labelProjectMarket;
        private TabPage tabPageCreditCommitee;
        private DateTimePicker dateTimePickerCreditCommitee;
        private Label labelCreditCommiteeComment;
        private TextBox textBoxCreditCommiteeComment;
        private Label labelCreditCommiteeDate;
        private System.Windows.Forms.Button buttonCreditCommiteeSaveDecision;
        private ColumnHeader columnHeaderStatus;
        private ColumnHeader columnProductType;
        private TextBox textBoxLoanContractCode;
        private Label labelLoanContractCode;
        private TabPage tabPageCorporate;
        private Label lProjectCorporateName;
        private TextBox tBProjectCorporateName;
        private Label lProjectCorporateSIRET;
        private Label lProjectJuridicStatus;
        private Label lProjectFiscalStatus;
        private TextBox tBProjectCorporateSIRET;
        private ComboBox cBProjectFiscalStatus;
        private ComboBox cBProjectJuridicStatus;
        private SplitContainer splitContainer10;
        private GroupBox gBProjectAddress;
        private Label lProjectNbOfNewJobs;
        private TextBox tBProjectCA;
        private Label lProjectCA;
        private GroupBox gBProjectFinancialPlan;
        private TextBox tBProjectFinancialPlanAmount;
        private ComboBox cBProjectFinancialPlanType;
        private Label lProjectFinancialPlanTotalAmount;
        private TextBox tBProjectFinancialPlanTotal;
        private Label lProjectFinancialPlanType;
        private Label lProjectFinancialPlanAmount;
        private TabPage tabPageFollowUp;
        private SplitContainer splitContainer11;
        private ListView listViewProjectFollowUp;
        private ColumnHeader columnHeaderProjectYear;
        private ColumnHeader columnHeaderProjectJobs1;
        private ColumnHeader columnHeaderProjectJobs2;
        private ColumnHeader columnHeaderProjectCA;
        private ColumnHeader columnHeaderprojectPersonalSituation;
        private ColumnHeader columnHeaderProjectActivity;
        private ColumnHeader columnHeaderProjectComment;
        private GroupBox gBProjectFollowUp;
        private System.Windows.Forms.Button buttonProjectAddFollowUp;
        private NumericUpDown numericUpDownProjectJobs;
        private TextBox tBCreditCommitteeCode;
        private Label labelCreditCommiteeCode;
        private TabPage tabPageSavingDetails;
        private TabPage tabPageLoanGuarantees;
        private SplitContainer splitContainer1;
        private Label lblGuarantorsList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelectAGarantors;
        private System.Windows.Forms.Button buttonModifyAGarantors;
        private ListView listViewGuarantors;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeaderPercentage;
        private ListView listViewCollaterals;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader25;
        private Label lblCollaterals;
        private System.Windows.Forms.Button buttonModifyCollateral;
        private System.Windows.Forms.Button buttonDelCollateral;
        private System.Windows.Forms.Button buttonAddCollateral;
        private System.Windows.Forms.Button btnLoanShares;
        private Label lblCreditCurrency;
        private Label labelDateOffirstInstallment;
        private DateTimePicker dtpDateOfFirstInstallment;
        private ToolStripMenuItem savingDepositToolStripMenuItem;
        private ToolStripMenuItem savingWithdrawToolStripMenuItem;
        private ToolStripMenuItem savingTransferToolStripMenuItem;
        private ContextMenuStrip menuBtnAddSavingOperation;
        private ColumnHeader columnHeaderCurrency;
        private TabPage tabPageContracts;
        private SplitContainer splitContainerContracts;
        private Panel panelLoansContracts;
        private Panel panelSavingsContracts;
        private Label labelSavingsContracts;
        private GroupBox groupBoxSaving;
        private GroupBox gbDepositInterest;
        private Label lbPeriodicityValue;
        private Label lbAccrualDepositValue;
        private Label lbPeriodicity;
        private Label lbAccrualDeposit;
        private Label lbWithdrawFeesMinMax;
        private NumericUpDown nudWithdrawFees;
        private Label lbWithdrawFees;
        private GroupBox groupBoxSavingBalance;
        private Label lbBalanceMaxValue;
        private Label lbBalanceMinValue;
        private Label lbBalanceMax;
        private Label lbBalanceMin;
        private GroupBox gbInterest;
        private Label lbInterestBasedOnValue;
        private Label lbInterestBasedOn;
        private Label lbInterestPostingValue;
        private Label lbInterestAccrualValue;
        private Label lbInterestPosting;
        private Label lbInterestAccrual;
        private System.Windows.Forms.Button buttonCloseSaving;
        private System.Windows.Forms.Button btSavingsUpdate;
        private System.Windows.Forms.Button buttonSaveSaving;
        private Label lbInterestRateMinMax;
        private NumericUpDown nudDownInterestRate;
        private Label lBSavingBalance;
        private Label labelInterestRate;
        private TextBox tBSavingCode;
        private Label label9;
        private GroupBox groupBoxSavingDeposit;
        private Label lbDepositMaxValue;
        private Label lbDepositMinValue;
        private Label lbDepositmax;
        private Label lbDepositMin;
        private GroupBox groupBoxSavingWithdraw;
        private Label lbWithdrawMaxValue;
        private Label lbWithdrawMinValue;
        private Label lbWithdrawMax;
        private Label lbWithdrawMin;
        private TabControl tabControlSavingsDetails;
        private TabPage tabPageSavingsEvents;
        private ListView lvSavingEvent;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader24;
        private System.Windows.Forms.Button buttonSavingsOperations;
        private System.Windows.Forms.Button btCancelLastSavingEvent;
        private GroupBox groupBoxSavingTransfer;
        private Label labelSavingTransferMaxValue;
        private Label labelSavingTransferMinValue;
        private Label labelSavingTransferMax;
        private Label labelSavingTransferMin;
        private Label lbTransferFeesMinMax;
        private NumericUpDown nudTransferFees;
        private Label lbTransferFees;
        private ColumnHeader columnHeaderOLB;
        private ComboBox cBProjectAffiliation;
        private Label lProjectAffiliation;
        private Label labelLoansContracts;
        private Label labelLoanNbOfInstallmentsMinMax;
        private Label labelLoanGracePeriodMinMax;
        private ToolStripSeparator toolStripSeparatorCopy;
        private ToolStripMenuItem toolStripMenuItemEditComment;
        private ToolStripMenuItem toolStripMenuItemCancelPending;
        private ToolStripMenuItem toolStripMenuItemConfirmPending;
        private Label lbSavingBalanceValue;
        private BrightIdeasSoftware.OLVColumn olvColumnLACExportedBalance;
        private BrightIdeasSoftware.OLVColumn olvColumnSACExportedBalance;
        private System.Windows.Forms.Button btnEditSchedule;
        private ColumnHeader columnHeaderDesc;
        private ColumnHeader columnHeaderColDesc;
        private TabPage tabPageAdvancedSettings;
        private GroupBox groupBoxLoanLateFees;
        private Label labelLoanLateFeesOnAmountMinMax;
        private TextBox textBoxLoanLateFeesOnOLB;
        private Label labelLoanLateFeesOnAmount;
        private Label labelLoanLateFeesOnOLB;
        private TextBox textBoxLoanLateFeesOnAmount;
        private Label labelLoanLateFeesOnOLBMinMax;
        private Label lbAPR;
        private Label lbATR;
        private Label lblEarlyPartialRepaimentBase;
        private Label lblLoanAnticipatedPartialFeesMinMax;
        private TextBox tbLoanAnticipatedPartialFees;
        private Label lblEarlyTotalRepaimentBase;
        private Label labelLoanAnticipatedTotalFeesMinMax;
        private TextBox textBoxLoanAnticipatedTotalFees;
        private Label labelLocAmount;
        private Label labelLocMinAmount;
        private Label labelLocMin;
        private Label labelLocMaxAmount;
        private Label labelLocMax;
        private TextBox tbLocAmount;
        private GroupBox groupBoxAnticipatedRepaymentPenalties;
        private ContextMenuStrip menuCollateralProducts;
        private NumericUpDown nudDepositFees;
        private Label lbDepositFees;
        private Label lbDepositFeesMinMax;
        private Label lbManagementFees;
        private NumericUpDown nudManagementFees;
        private Label lbCloseFees;
        private NumericUpDown nudCloseFees;
        private Label lbManagementFeesMinMax;
        private Label lbCloseFeesMinMax;
        private TabPage tabPageSavingsAmountsAndFees;
        private ColumnHeader columnHeader15;
        private NumericUpDown nudAgioFees;
        private Label lbAgioFees;
        private NumericUpDown nudOverdraftFees;
        private Label lbOverdraftFees;
        private Label lbOverdraftFeesMinMax;
        private Label lbAgioFeesMinMax;
        private ColumnHeader columnHeader28;
        private ContextMenuStrip menuPendingSavingEvents;
        private ToolStripMenuItem menuItemCancelPendingSavingEvent;
        private ToolStripMenuItem menuItemConfirmPendingSavingEvent;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlLoans;
        private FlowLayoutPanel loanDetailsButtonsPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel pnlGuarantorButtons;
        private FlowLayoutPanel pnlCollateralButtons;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label labelLoanLateFeesOnOverduePrincipalMinMax;
        private TextBox textBoxLoanLateFeesOnOverduePrincipal;
        private Label labelLoanLateFeesOnOverduePrincipal;
        private Label labelLoanLateFeesOnOverdueInterest;
        private TextBox textBoxLoanLateFeesOnOverdueInterest;
        private Label labelLoanLateFeesOnOverdueInterestMinMax;
        private TableLayoutPanel tableLayoutPanel9;
        private FlowLayoutPanel flowLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel11;
        private Label lblCCStatus;
        private Panel pnlCCStatus;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel9;
        private FlowLayoutPanel pnlSavingsButtons;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
        private FlowLayoutPanel flowLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel15;
        private TableLayoutPanel tableLayoutPanel16;
        private TableLayoutPanel tableLayoutPanel17;
        private Label label1;
        private ComboBox cmbSavingsOfficer;
        private System.Windows.Forms.Button buttonReopenSaving;
        private NumericUpDown nudChequeDepositFees;
        private Label lblChequeDepositFeesMinMax;
        private Label lbChequeDepositFees;
        private Label lblDay;
        private Label lbReopenFeesMinMax;
        private NumericUpDown nudReopenFees;
        private Label lbReopenFees;
        private TabPage tabPageLoans;
        private BrightIdeasSoftware.ObjectListView olvLoans;
        private BrightIdeasSoftware.OLVColumn olvColumnContractCode;
        private BrightIdeasSoftware.OLVColumn olvColumnAmount;
        private BrightIdeasSoftware.OLVColumn olvColumnStatus;
        private BrightIdeasSoftware.OLVColumn olvColumnOLB;
        private BrightIdeasSoftware.OLVColumn olvColumnStratDate;
        private BrightIdeasSoftware.OLVColumn olvColumnCreationDate;
        private BrightIdeasSoftware.OLVColumn olvColumnCloseDate;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblMinMaxEntryFees;
        private GroupBox groupBoxEntryFees;
        private NumericUpDown numEntryFees;
        private ColumnHeader columnHeader29;
        private ListViewEx lvEntryFees;
        private ColumnHeader colName;
        private ColumnHeader colValue;
        private ColumnHeader colType;
        private ToolStripMenuItem specialOperationToolStripMenuItem;
        private ColumnHeader colAmount;
        private System.Windows.Forms.Button buttonViewCollateral;
        private System.Windows.Forms.Button buttonViewAGarantors;
        private TextBox textBoxLoanPurpose;
        private Label labelLoanPurpose;
        private TextBox textBoxComments;
        private Label labelComments;
        private System.Windows.Forms.Button btnUpdateSettings;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel10;
        private Label lbCompulsorySavingsAmount;
        private Label lbCompulsorySavings;
        private Label lbCompAmountPercentMinMax;
        private LinkLabel linkCompulsorySavings;
        private NumericUpDown numCompulsoryAmountPercent;
        private System.Windows.Forms.Button buttonFirstDeposit;
        private NumericUpDown nudLoanAmount;
        private NumericUpDown nudInterestRate;
        private Label lblIbtFeeMinMax;
        private NumericUpDown nudIbtFee;
        private Label lblInterBranchTransfer;
        private NumericUpDown nudDownInitialAmount;
        private NumericUpDown nudEntryFees;
        private Label lbEntryFees;
        private Label labelInitialAmount;
        private Label lbEntryFeesMinMax;
        private Label lbInitialAmountMinMax;
        private Label lblCreditInsurance;
        private TextBox tbInsurance;
        private Label label4;
        private Label label5;
        private Label lblInsuranceMin;
        private Label lblInsuranceMax;
        private Label label6;
        private Label label7;
        private Label lblLocCurrencyMin;
        private Label lblLocCurrencyMax;
        private bool _useGregorienCalendar = true;
        private readonly Calendar targetCalendar = new PersianCalendar();
        private readonly Calendar currentCalendar = new GregorianCalendar();
        private FundingLineEvent pendingFundingLineEvent;
        private AddressUserControl projectAddressUserControl;
        private TabPage tpTermDeposit;
        private Label lblNumberOfPeriods;
        private TableLayoutPanel tlpTermDeposit;
        private NumericUpDown nudNumberOfPeriods;
        private Label lblTermTransferToAccount;
        private TextBox tbTargetAccount2;
        private Button btSearchContract2;
        private Label lbRollover2;
        private ComboBox cmbRollover2;
        private Label lblLimitOfTermDepositPeriod;
        private ComboBox cmbCompulsorySaving;
        private ComboBox cmbContractStatus;
        private TableLayoutPanel tlpSBDetails;
        private ColumnHeader colCancelDate;
        private PrintButton btnPrintLoanDetails = new PrintButton();
        private PrintButton btnPrintCreditCommittee = new PrintButton();
        private PrintButton btnPrintGuarantors = new PrintButton();
        private PrintButton btnPrintSavings = new PrintButton();
        private EconomicActivityControl eacLoan = new EconomicActivityControl();
        private Label lbSavingAvBalanceValue;
        private Label lBSavingAvBalance;
        private Label lblEconomicActivity;
        private TabControl tabControlRepayments;
        private TabPage tabPageRepayments;
        private ListViewEx lvLoansRepayments;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeaderLateDays;
        private ColumnHeader columnHeaderComment;
        private FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Button buttonLoanRepaymentRepay;
        private System.Windows.Forms.Button buttonLoanReschedule;
        private System.Windows.Forms.Button buttonAddTranche;
        private System.Windows.Forms.Button btnWriteOff;
        private PrintButton btnPrintLoanRepayment;
        private TabPage tabPageEvents;
        private ListViewEx lvEvents;
        private ColumnHeader columnHeader11;
        private ColumnHeader EntryDate;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader colCommissions;
        private ColumnHeader colPenalties;
        private ColumnHeader colOverduePrincipal;
        private ColumnHeader colOverdueDays;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader18;
        private ColumnHeader ExportedDate;
        private ColumnHeader colId;
        private ColumnHeader colNumber;
        private ColumnHeader columnHeader30;
        private ColumnHeader colPaymentMethod;
        private ColumnHeader colCancelDate1;
        private ColumnHeader colIsDeleted;
        private GroupBox groupBox1;
        private PrintButton btnPrintLoanEvents;
        private System.Windows.Forms.Button btnWaiveFee;
        private System.Windows.Forms.Button btnDeleteEvent;
        private Button buttonManualSchedule;
        private TabControl tclLoanDetails;
        private TabPage tabPageInstallments;
        private ListViewEx listViewLoanInstallments;
        private ColumnHeader columnHeaderLoanN;
        private ColumnHeader columnHeaderLoanDate;
        private ColumnHeader columnHeaderLoanIP;
        private ColumnHeader columnHeaderLoanPR;
        private ColumnHeader columnHeaderLoanInstallmentTotal;
        private ColumnHeader columnHeaderLoanOLB;
        private TabPage tabPageFPCAContracts;
        private TabPage tabPageFixedDeposit;
        private TabPage tabPageCurrentAccount;
        private Label label2;
        private Label label3;
        private Panel panel5;
        private Panel panel4;
        private Button btnViewFixedDeposit;
        private Button btnAddFixedDeposit;
        private Button btnViewCurrentAccount;
        private Button btnAddCurrentAccount;
        private GroupBox tbTransferNumberForm;
        private GroupBox groupBox4;
        private Label label10;
        private TextBox tbMaturityPeriod;
        private Label label12;
        private GroupBox groupBox5;
        private RadioButton rbPenalityTypeRate;
        private RadioButton rbPenalityTypeFlat;
        private Label label13;
        private TextBox tbPenality;
        private Label label15;
        private GroupBox gbFrequency;
        private Label lbAccrual;
        private Label lbNameSavingProduct;
        private GroupBox gbInitialAmount;
        private Label lbInitialAmountMin;
        private GroupBox gbInterestRate;
        private Label lbYearlyInterestRateMin;
        private TextBox tbInterestRate;
        private Label lbInterestRateMin;
        private ComboBox cbFixedDepositProduct;
        private TextBox tbInitialAmount;
        private Button btnAddFixedDepositProduct;
        private Label label8;
        private TextBox tbProductCode;
        private Label label11;
        private ComboBox cbAccountingOfficer;
        private Label label14;
        private TextBox tbComment;
        private TextBox tbCurrentAccountComment;
        private Label label16;
        private ComboBox cbCurrentAccountingOfficer;
        private Label label17;
        private TextBox tbCurrentAccountProductCode;
        private Label label18;
        private ComboBox cbCurrentAccountProducts;
        private Label label19;
        private TextBox tbCurrentInitialAmount;
        private Label label20;
        private GroupBox gtManagementFees;
        private RadioButton rbRateManagementFees;
        private RadioButton rbFlatManagementFees;
        private Label lbManagementFeesType;
        private TextBox tbManagementFees;
        private Label lbManagementFeesMin;
        private GroupBox gbEntryFees;
        private RadioButton rbRateEntryFees;
        private RadioButton rbFlatEntryFees;
        private Label lbEntryFeesType;
        private TextBox tbEntryFees;
        private Label lbEntryFeesMin;
        private GroupBox gtOverdraftFees;
        private RadioButton rbRateOverdraftFees;
        private RadioButton rbFlatOverdraftFees;
        private Label lbOverdraftFeesType;
        private TextBox tbOverdraftFees;
        private Label lbOverdraftFeesMin;
        private Button btnAddCurrentAccountProduct;
        private Label label23;
        private Button btnPrint;
        private Button btnExtendPeriod;
        private Button btnCloseFDContract;
        private ListView lvFixedDeposits;
        private ListView lvCurrentAccountProducts;
        private ColumnHeader ContractCode;
        private ColumnHeader InitialAmount;
        private ColumnHeader InterestRate;
        private ColumnHeader MaturityPeriod;
        private ColumnHeader OpenDate;
        private ColumnHeader OpenAccountingOfficer;
        private ColumnHeader Status;
        private TextBox tbFDContractCode;
        private Label lblProductContractCode;
        private TextBox tbOpenedDate;
        private Label label31;
        private Label label30;
        private GroupBox gbInterestCalculation;
        private Label lblPreMatured;
        private Label label32;
        private Label lbTotalAmount;
        private Label lbEffectivePenalty;
        private Label lbEffectiveDepositPeriod;
        private Label lbEffectiveInterest;
        private Label lbEffectiveInterestRate;
        private Label lblEffectiveInterestRate;
        private Label label29;
        private Label label28;
        private Label label26;
        private Label label25;
        private Label label24;
        private TextBox tbTransferNumber;
        private Label lblChequeNumber;
        private ComboBox cbAmountTransferMethod;
        private Label lblAmountTransferMethod;
        private ComboBox cbAccountStatus;
        private Button btnCAPrint;
        private Button btnCloseAccount;
        private ComboBox cbCAAccountStatus;
        private Label lblCAAcountStatus;
        private TextBox tbCAOpenedDate;
        private Label lblCAOpenedDate;
        private TextBox tbCAProductCode;
        private Label lblCAProductCode;
        private TextBox tbCAClosedDate;
        private Label lblCAClosedDate;
        private GroupBox gbAmount;
        private Label label54;
        private TextBox tbCAChequeAccount;
        private Label lblCAChequeNumber;
        private ComboBox cbCAPaymentMethod;
        private ColumnHeader chContractCode;
        private ColumnHeader chBalance;
        private ColumnHeader chOpenedDate;
        private ColumnHeader chOpenAO;
        private ColumnHeader chStatus;
        private Label label27;
        private TextBox tbFrequencyMonths;
        private TextBox tbCAInterestRate;
        private Label label33;
        private GroupBox gbInitialPayment;
        private TextBox tbCABalanceAmount;
        private Label lblBalanceAmount;
        private Label label34;
        private Label label43;
        private TextBox tbCalculationFrequency;
        private Button btnTransactions;
        private Button btnOverdraft;
        private TabPage tabPageTransactions;
        private ListView lvTransactions;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private ColumnHeader columnHeader34;
        private ColumnHeader columnHeader35;
        private ColumnHeader columnHeader36;
        private ColumnHeader columnHeader37;
        private Label label44;
        private ColumnHeader columnHeader38;
        private Button button1;
        private Button button2;
        private TextBox tbInitialPaymentNumber;
        private Label lblInitialChequeNumber;
        private ComboBox cbCAInitialAmountMethod;
        private TabControl tabControlCurrentAccount;
        private TabPage tabPageFees;
        private TabPage tabPageOverdraft;
        private CheckBox checkBoxOverdraftApplied;
        private TextBox tbOverdraftAmount;
        private Label label35;
        private TabPage tabPageCloseAccount;
        private GroupBox gbCloseFees;
        private RadioButton rbRateCloseFees;
        private RadioButton rbFlatCloseFees;
        private Label lbCloseFeesType;
        private TextBox tbCloseFees;
        private Label lbCloseFeesMin;
        private TabPage tabPageReopenAccount;
        private GroupBox gbReopenFees;
        private RadioButton rbRateReopenFees;
        private RadioButton rbFlatReopenFees;
        private Label lbReopenFeesType;
        private TextBox tbReopenFees;
        private Label lbReopenFeesMin;
        private TabPage tabPageFeesTransactions;
        private ListView listViewFeeTransactions;
        private ColumnHeader chToAccount;
        private ColumnHeader chAmount;
        private ColumnHeader chFeeDate;
        private ColumnHeader chPurposeOfTransfer;
        private ColumnHeader chTransactionType;
        private Label label36;
        private Label label38;
        private GroupBox groupBox3;
        private Label label21;
        private RadioButton rbODInterestTypeRate;
        private RadioButton rbODInterestTypeFlat;
        private Label label39;
        private TextBox tbCAODInterestRate;
        private Label label40;
        private GroupBox groupBox6;
        private Label label41;
        private RadioButton rbODCommitmentTypeRate;
        private RadioButton rbODCommitmentTypeFlat;
        private Label label42;
        private TextBox tbCAODCommitmentFee;
        private Label label45;
        private TextBox tbOverdraftDate;
        private Label lblOverdraftAppliedDate;
        private Label lblFDMaturityMinMax;
        private Label lblFDPenaltyMinMax;
        private Label lblFDInitialAmountMinMax;
        private Label lblFDInterestMinMax;
        private Label lblCAInitialAmountMinMax;
        private Label lblCAEntryFeesMinMax;
        private Label lblCAManagementFeesMinMax;
        private Label lblCACommitmentFeesMinMax;
        private Label lblCAODInterestMinMax;
        private Label lblCAOverdraftFeesMinMax;
        private Label lblCACloseFeesMinMax;
        private Label lblCAReopenFeesMinMax;
        private Label lblCAInterestRateMinMax;
        private GroupBox gbFDInitialPayment;
        private ComboBox cbInitialAmountPaymentMethod;
        private TextBox tbFDInitialAmountNumber;
        private Label lblFDInitialAccount;
        private Label label47;
        private Button button3;
        private ColumnHeader columnHeader39;
        private ColumnHeader chFeesBalance;
        private ColumnHeader columnHeader40;
        private ColumnHeader columnHeader41;
        private TabPage tabPage1;
        private ListView lvCAEvents;
        private ColumnHeader columnHeader42;
        private ColumnHeader columnHeader43;
        private ColumnHeader columnHeader44;
        private TabPage tabPageBGLC;
        private Label label22;
        private ListView lvBankGuarantee;
        private ColumnHeader columnHeader45;
        private ColumnHeader columnHeader46;
        private ColumnHeader columnHeader47;
        private ColumnHeader columnHeader48;
        private ColumnHeader columnHeader49;
        private ColumnHeader columnHeader50;
        private ColumnHeader columnHeader51;
        private ColumnHeader columnHeader52;
        private Button btnViewBankGuarantee;
        private Button btnUpdateBankGuarantee;
        private Button btnAddBankGuarantee;
        private Label label46;
        private Button btnViewLetterOfCredit;
        private Button btnUpdateLetterOfCredit;
        private Button btnAddLetterOfCredit;
        private ListView lvLetterOfCredit;
        private ColumnHeader columnHeader53;
        private ColumnHeader columnHeader54;
        private ColumnHeader columnHeader55;
        private ColumnHeader columnHeader56;
        private ColumnHeader columnHeader57;
        private ColumnHeader columnHeader58;
        private ColumnHeader columnHeader59;
        private ColumnHeader columnHeader60;
        private ColumnHeader columnHeaderLoanCategory;
        private RadioButton rbAmortisationSchedule;
        private RadioButton rbStraightSchedule;
        private CheckBox cbLIBOR;
        private Label lblLIBOR;
        private Label lblFDLIBOR;
        private CheckBox cbFDLibor;
        private Button btnCAGenerateStatement;
        private Button btnGenerateFDStatement;
        private Button btnGenerateLOCLetter;
        private Button btnGenerateBGLetter;
        private Button btnRepaymentNotice;
        private Button btnFDChargesNotice;
        private Button btnCAChargesNotice;
        private Button btnGenerateLoanStatement;
        private Button btnCurrentChargesNotice;
    }
}