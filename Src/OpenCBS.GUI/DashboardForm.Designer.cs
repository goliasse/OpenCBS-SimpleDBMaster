

namespace OpenCBS.GUI
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.generalInfoPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.disbursementsPanel = new System.Windows.Forms.Panel();
            this.olbTrendPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.riskTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.parListView = new BrightIdeasSoftware.ObjectListView();
            this.parNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.parAmountColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.parQuantityColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.portfolioPanel = new System.Windows.Forms.Panel();
            this.parPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._filterPanel = new System.Windows.Forms.Panel();
            this._refreshButton = new System.Windows.Forms.Button();
            this._loanProductFilterComboBox = new System.Windows.Forms.ComboBox();
            this._loanProductFilterLabel = new System.Windows.Forms.Label();
            this._userFilterComboBox = new System.Windows.Forms.ComboBox();
            this._userFilterLabel = new System.Windows.Forms.Label();
            this._branchFilterComboBox = new System.Windows.Forms.ComboBox();
            this._branchFilterLabel = new System.Windows.Forms.Label();
            this.topBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.smallLogoPictureBox = new System.Windows.Forms.PictureBox();
            this._infoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this._servicesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this._userGuideLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this._contactLinkLabel = new System.Windows.Forms.LinkLabel();
            this.quickLinksPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.operateLabel = new System.Windows.Forms.Label();
            this.searchClientLabel = new System.Windows.Forms.LinkLabel();
            this.searchContractLabel = new System.Windows.Forms.LinkLabel();
            this.newIndividualClientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newSolidarityGroupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newNonSolidairtyGroupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newCorporateClientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.configureLabel = new System.Windows.Forms.Label();
            this.configureLoanProductsLabel = new System.Windows.Forms.LinkLabel();
            this.configureSavingsProductsLabel = new System.Windows.Forms.LinkLabel();
            this.configureCollateralProducts = new System.Windows.Forms.LinkLabel();
            this.configureSettingsLabel = new System.Windows.Forms.LinkLabel();
            this.configurePermissionsLabel = new System.Windows.Forms.LinkLabel();
            this.controlLabel = new System.Windows.Forms.Label();
            this.auditTrailLabel = new System.Windows.Forms.LinkLabel();
            this.activeLoansLink = new System.Windows.Forms.LinkLabel();
            this.parAnalysisLink = new System.Windows.Forms.LinkLabel();
            this.delinquentLoansLink = new System.Windows.Forms.LinkLabel();
            this.disbursementsLink = new System.Windows.Forms.LinkLabel();
            this.generalInfoPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.riskTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parListView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this._filterPanel.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallLogoPictureBox)).BeginInit();
            this._infoFlowLayoutPanel.SuspendLayout();
            this.quickLinksPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalInfoPanel
            // 
            this.generalInfoPanel.Controls.Add(this.infoPanel);
            this.generalInfoPanel.Controls.Add(this.quickLinksPanel);
            resources.ApplyResources(this.generalInfoPanel, "generalInfoPanel");
            this.generalInfoPanel.Name = "generalInfoPanel";
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.Controls.Add(this.tableLayoutPanel1);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.riskTableLayoutPanel);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this._filterPanel);
            this.infoPanel.Controls.Add(this.topBarPanel);
            resources.ApplyResources(this.infoPanel, "infoPanel");
            this.infoPanel.Name = "infoPanel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.disbursementsPanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.olbTrendPanel, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // disbursementsPanel
            // 
            resources.ApplyResources(this.disbursementsPanel, "disbursementsPanel");
            this.disbursementsPanel.Name = "disbursementsPanel";
            // 
            // olbTrendPanel
            // 
            resources.ApplyResources(this.olbTrendPanel, "olbTrendPanel");
            this.olbTrendPanel.Name = "olbTrendPanel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Name = "label2";
            // 
            // riskTableLayoutPanel
            // 
            resources.ApplyResources(this.riskTableLayoutPanel, "riskTableLayoutPanel");
            this.riskTableLayoutPanel.Controls.Add(this.parListView, 1, 0);
            this.riskTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.riskTableLayoutPanel.Name = "riskTableLayoutPanel";
            // 
            // parListView
            // 
            this.parListView.AllColumns.Add(this.parNameColumn);
            this.parListView.AllColumns.Add(this.parAmountColumn);
            this.parListView.AllColumns.Add(this.parQuantityColumn);
            this.parListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.parNameColumn,
            this.parAmountColumn,
            this.parQuantityColumn});
            resources.ApplyResources(this.parListView, "parListView");
            this.parListView.FullRowSelect = true;
            this.parListView.GridLines = true;
            this.parListView.HasCollapsibleGroups = false;
            this.parListView.Name = "parListView";
            this.parListView.ShowGroups = false;
            this.parListView.UseCompatibleStateImageBehavior = false;
            this.parListView.View = System.Windows.Forms.View.Details;
            // 
            // parNameColumn
            // 
            this.parNameColumn.AspectName = "Name";
            resources.ApplyResources(this.parNameColumn, "parNameColumn");
            // 
            // parAmountColumn
            // 
            this.parAmountColumn.AspectName = "Amount";
            this.parAmountColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.parAmountColumn, "parAmountColumn");
            // 
            // parQuantityColumn
            // 
            this.parQuantityColumn.AspectName = "Quantity";
            this.parQuantityColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            resources.ApplyResources(this.parQuantityColumn, "parQuantityColumn");
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.portfolioPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.parPanel, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // portfolioPanel
            // 
            resources.ApplyResources(this.portfolioPanel, "portfolioPanel");
            this.portfolioPanel.Name = "portfolioPanel";
            // 
            // parPanel
            // 
            resources.ApplyResources(this.parPanel, "parPanel");
            this.parPanel.Name = "parPanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Name = "label1";
            // 
            // _filterPanel
            // 
            this._filterPanel.Controls.Add(this._refreshButton);
            this._filterPanel.Controls.Add(this._loanProductFilterComboBox);
            this._filterPanel.Controls.Add(this._loanProductFilterLabel);
            this._filterPanel.Controls.Add(this._userFilterComboBox);
            this._filterPanel.Controls.Add(this._userFilterLabel);
            this._filterPanel.Controls.Add(this._branchFilterComboBox);
            this._filterPanel.Controls.Add(this._branchFilterLabel);
            resources.ApplyResources(this._filterPanel, "_filterPanel");
            this._filterPanel.Name = "_filterPanel";
            // 
            // _refreshButton
            // 
            resources.ApplyResources(this._refreshButton, "_refreshButton");
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.UseVisualStyleBackColor = true;
            // 
            // _loanProductFilterComboBox
            // 
            this._loanProductFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._loanProductFilterComboBox.FormattingEnabled = true;
            resources.ApplyResources(this._loanProductFilterComboBox, "_loanProductFilterComboBox");
            this._loanProductFilterComboBox.Name = "_loanProductFilterComboBox";
            // 
            // _loanProductFilterLabel
            // 
            resources.ApplyResources(this._loanProductFilterLabel, "_loanProductFilterLabel");
            this._loanProductFilterLabel.Name = "_loanProductFilterLabel";
            // 
            // _userFilterComboBox
            // 
            this._userFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._userFilterComboBox.FormattingEnabled = true;
            resources.ApplyResources(this._userFilterComboBox, "_userFilterComboBox");
            this._userFilterComboBox.Name = "_userFilterComboBox";
            // 
            // _userFilterLabel
            // 
            resources.ApplyResources(this._userFilterLabel, "_userFilterLabel");
            this._userFilterLabel.Name = "_userFilterLabel";
            // 
            // _branchFilterComboBox
            // 
            this._branchFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._branchFilterComboBox.FormattingEnabled = true;
            resources.ApplyResources(this._branchFilterComboBox, "_branchFilterComboBox");
            this._branchFilterComboBox.Name = "_branchFilterComboBox";
            // 
            // _branchFilterLabel
            // 
            resources.ApplyResources(this._branchFilterLabel, "_branchFilterLabel");
            this._branchFilterLabel.Name = "_branchFilterLabel";
            // 
            // topBarPanel
            // 
            resources.ApplyResources(this.topBarPanel, "topBarPanel");
            this.topBarPanel.Controls.Add(this.smallLogoPictureBox, 0, 0);
            this.topBarPanel.Controls.Add(this._infoFlowLayoutPanel, 1, 0);
            this.topBarPanel.Name = "topBarPanel";
            // 
            // smallLogoPictureBox
            // 
            resources.ApplyResources(this.smallLogoPictureBox, "smallLogoPictureBox");
            this.smallLogoPictureBox.Image = global::OpenCBS.GUI.Properties.Resources.LOGO;
            this.smallLogoPictureBox.Name = "smallLogoPictureBox";
            this.smallLogoPictureBox.TabStop = false;
            // 
            // _infoFlowLayoutPanel
            // 
            this._infoFlowLayoutPanel.Controls.Add(this.label3);
            this._infoFlowLayoutPanel.Controls.Add(this._servicesLinkLabel);
            this._infoFlowLayoutPanel.Controls.Add(this.label4);
            this._infoFlowLayoutPanel.Controls.Add(this._userGuideLinkLabel);
            this._infoFlowLayoutPanel.Controls.Add(this.label5);
            this._infoFlowLayoutPanel.Controls.Add(this._contactLinkLabel);
            resources.ApplyResources(this._infoFlowLayoutPanel, "_infoFlowLayoutPanel");
            this._infoFlowLayoutPanel.Name = "_infoFlowLayoutPanel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // _servicesLinkLabel
            // 
            resources.ApplyResources(this._servicesLinkLabel, "_servicesLinkLabel");
            this._servicesLinkLabel.Name = "_servicesLinkLabel";
            this._servicesLinkLabel.TabStop = true;
            this._servicesLinkLabel.Tag = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // _userGuideLinkLabel
            // 
            resources.ApplyResources(this._userGuideLinkLabel, "_userGuideLinkLabel");
            this._userGuideLinkLabel.Name = "_userGuideLinkLabel";
            this._userGuideLinkLabel.TabStop = true;
            this._userGuideLinkLabel.Tag = "";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // _contactLinkLabel
            // 
            resources.ApplyResources(this._contactLinkLabel, "_contactLinkLabel");
            this._contactLinkLabel.Name = "_contactLinkLabel";
            this._contactLinkLabel.TabStop = true;
            // 
            // quickLinksPanel
            // 
            this.quickLinksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.quickLinksPanel.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.quickLinksPanel, "quickLinksPanel");
            this.quickLinksPanel.Name = "quickLinksPanel";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.operateLabel);
            this.flowLayoutPanel1.Controls.Add(this.searchClientLabel);
            this.flowLayoutPanel1.Controls.Add(this.searchContractLabel);
            this.flowLayoutPanel1.Controls.Add(this.newIndividualClientLinkLabel);
            this.flowLayoutPanel1.Controls.Add(this.newSolidarityGroupLinkLabel);
            this.flowLayoutPanel1.Controls.Add(this.newNonSolidairtyGroupLinkLabel);
            this.flowLayoutPanel1.Controls.Add(this.newCorporateClientLinkLabel);
            this.flowLayoutPanel1.Controls.Add(this.configureLabel);
            this.flowLayoutPanel1.Controls.Add(this.configureLoanProductsLabel);
            this.flowLayoutPanel1.Controls.Add(this.configureSavingsProductsLabel);
            this.flowLayoutPanel1.Controls.Add(this.configureCollateralProducts);
            this.flowLayoutPanel1.Controls.Add(this.configureSettingsLabel);
            this.flowLayoutPanel1.Controls.Add(this.configurePermissionsLabel);
            this.flowLayoutPanel1.Controls.Add(this.controlLabel);
            this.flowLayoutPanel1.Controls.Add(this.auditTrailLabel);
            this.flowLayoutPanel1.Controls.Add(this.activeLoansLink);
            this.flowLayoutPanel1.Controls.Add(this.parAnalysisLink);
            this.flowLayoutPanel1.Controls.Add(this.delinquentLoansLink);
            this.flowLayoutPanel1.Controls.Add(this.disbursementsLink);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // operateLabel
            // 
            resources.ApplyResources(this.operateLabel, "operateLabel");
            this.operateLabel.ForeColor = System.Drawing.Color.White;
            this.operateLabel.Name = "operateLabel";
            this.operateLabel.Tag = "123";
            // 
            // searchClientLabel
            // 
            this.searchClientLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.searchClientLabel, "searchClientLabel");
            this.searchClientLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.searchClientLabel.Name = "searchClientLabel";
            this.searchClientLabel.TabStop = true;
            this.searchClientLabel.Tag = "mnuSearchClient";
            this.searchClientLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSearchClientClick);
            // 
            // searchContractLabel
            // 
            this.searchContractLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.searchContractLabel, "searchContractLabel");
            this.searchContractLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.searchContractLabel.Name = "searchContractLabel";
            this.searchContractLabel.TabStop = true;
            this.searchContractLabel.Tag = "mnuSearchContract";
            this.searchContractLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSearchContractClick);
            // 
            // newIndividualClientLinkLabel
            // 
            this.newIndividualClientLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.newIndividualClientLinkLabel, "newIndividualClientLinkLabel");
            this.newIndividualClientLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.newIndividualClientLinkLabel.Name = "newIndividualClientLinkLabel";
            this.newIndividualClientLinkLabel.TabStop = true;
            this.newIndividualClientLinkLabel.Tag = "mnuNewPerson";
            this.newIndividualClientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnNewIndividualClientLinkLabelClick);
            // 
            // newSolidarityGroupLinkLabel
            // 
            this.newSolidarityGroupLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.newSolidarityGroupLinkLabel, "newSolidarityGroupLinkLabel");
            this.newSolidarityGroupLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.newSolidarityGroupLinkLabel.Name = "newSolidarityGroupLinkLabel";
            this.newSolidarityGroupLinkLabel.TabStop = true;
            this.newSolidarityGroupLinkLabel.Tag = "mnuNewGroup";
            this.newSolidarityGroupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnNewSolidarityGroupLinkLabelLinkClick);
            // 
            // newNonSolidairtyGroupLinkLabel
            // 
            this.newNonSolidairtyGroupLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.newNonSolidairtyGroupLinkLabel, "newNonSolidairtyGroupLinkLabel");
            this.newNonSolidairtyGroupLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.newNonSolidairtyGroupLinkLabel.Name = "newNonSolidairtyGroupLinkLabel";
            this.newNonSolidairtyGroupLinkLabel.TabStop = true;
            this.newNonSolidairtyGroupLinkLabel.Tag = "mnuNewVillage";
            this.newNonSolidairtyGroupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnNewNonSolidairtyGroupLinkLabelLinkClick);
            // 
            // newCorporateClientLinkLabel
            // 
            this.newCorporateClientLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.newCorporateClientLinkLabel, "newCorporateClientLinkLabel");
            this.newCorporateClientLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.newCorporateClientLinkLabel.Name = "newCorporateClientLinkLabel";
            this.newCorporateClientLinkLabel.TabStop = true;
            this.newCorporateClientLinkLabel.Tag = "newCorporateToolStripMenuItem";
            this.newCorporateClientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnCorporateClientLinkLabelLinkClick);
            // 
            // configureLabel
            // 
            resources.ApplyResources(this.configureLabel, "configureLabel");
            this.configureLabel.ForeColor = System.Drawing.Color.White;
            this.configureLabel.Name = "configureLabel";
            // 
            // configureLoanProductsLabel
            // 
            this.configureLoanProductsLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.configureLoanProductsLabel, "configureLoanProductsLabel");
            this.configureLoanProductsLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.configureLoanProductsLabel.Name = "configureLoanProductsLabel";
            this.configureLoanProductsLabel.TabStop = true;
            this.configureLoanProductsLabel.Tag = "mnuPackages";
            this.configureLoanProductsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnConfigureLoanProductsClick);
            // 
            // configureSavingsProductsLabel
            // 
            this.configureSavingsProductsLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.configureSavingsProductsLabel, "configureSavingsProductsLabel");
            this.configureSavingsProductsLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.configureSavingsProductsLabel.Name = "configureSavingsProductsLabel";
            this.configureSavingsProductsLabel.TabStop = true;
            this.configureSavingsProductsLabel.Tag = "savingProductsToolStripMenuItem";
            this.configureSavingsProductsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnConfigureSavingsProductsClick);
            // 
            // configureCollateralProducts
            // 
            this.configureCollateralProducts.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.configureCollateralProducts, "configureCollateralProducts");
            this.configureCollateralProducts.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.configureCollateralProducts.Name = "configureCollateralProducts";
            this.configureCollateralProducts.TabStop = true;
            this.configureCollateralProducts.Tag = "menuItemCollateralProducts";
            this.configureCollateralProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnConfigureCollateralProducts);
            // 
            // configureSettingsLabel
            // 
            this.configureSettingsLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.configureSettingsLabel, "configureSettingsLabel");
            this.configureSettingsLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.configureSettingsLabel.Name = "configureSettingsLabel";
            this.configureSettingsLabel.TabStop = true;
            this.configureSettingsLabel.Tag = "menuItemSetting";
            this.configureSettingsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnConfigureSettingsClick);
            // 
            // configurePermissionsLabel
            // 
            this.configurePermissionsLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.configurePermissionsLabel, "configurePermissionsLabel");
            this.configurePermissionsLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.configurePermissionsLabel.Name = "configurePermissionsLabel";
            this.configurePermissionsLabel.TabStop = true;
            this.configurePermissionsLabel.Tag = "rolesToolStripMenuItem";
            this.configurePermissionsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnConfigurePermissionsClick);
            // 
            // controlLabel
            // 
            resources.ApplyResources(this.controlLabel, "controlLabel");
            this.controlLabel.ForeColor = System.Drawing.Color.White;
            this.controlLabel.Name = "controlLabel";
            // 
            // auditTrailLabel
            // 
            this.auditTrailLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.auditTrailLabel, "auditTrailLabel");
            this.auditTrailLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.auditTrailLabel.Name = "auditTrailLabel";
            this.auditTrailLabel.TabStop = true;
            this.auditTrailLabel.Tag = "miAuditTrail";
            this.auditTrailLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnAuditTrailClick);
            // 
            // activeLoansLink
            // 
            this.activeLoansLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.activeLoansLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            resources.ApplyResources(this.activeLoansLink, "activeLoansLink");
            this.activeLoansLink.Name = "activeLoansLink";
            this.activeLoansLink.Tag = "Active_Loans.zip";
            this.activeLoansLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnReportsClick);
            // 
            // parAnalysisLink
            // 
            this.parAnalysisLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.parAnalysisLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            resources.ApplyResources(this.parAnalysisLink, "parAnalysisLink");
            this.parAnalysisLink.Name = "parAnalysisLink";
            this.parAnalysisLink.Tag = "PAR_Analysis.zip";
            this.parAnalysisLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnReportsClick);
            // 
            // delinquentLoansLink
            // 
            this.delinquentLoansLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.delinquentLoansLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            resources.ApplyResources(this.delinquentLoansLink, "delinquentLoansLink");
            this.delinquentLoansLink.Name = "delinquentLoansLink";
            this.delinquentLoansLink.Tag = "Delinquent_Loans.zip";
            this.delinquentLoansLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnReportsClick);
            // 
            // disbursementsLink
            // 
            this.disbursementsLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.disbursementsLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            resources.ApplyResources(this.disbursementsLink, "disbursementsLink");
            this.disbursementsLink.Name = "disbursementsLink";
            this.disbursementsLink.Tag = "Disbursments.zip";
            this.disbursementsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnReportsClick);
            // 
            // DashboardForm
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.generalInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DashboardForm";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoad);
            this.generalInfoPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.riskTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parListView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this._filterPanel.ResumeLayout(false);
            this._filterPanel.PerformLayout();
            this.topBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smallLogoPictureBox)).EndInit();
            this._infoFlowLayoutPanel.ResumeLayout(false);
            this._infoFlowLayoutPanel.PerformLayout();
            this.quickLinksPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel generalInfoPanel;
        private System.Windows.Forms.Panel quickLinksPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label operateLabel;
        private System.Windows.Forms.LinkLabel newIndividualClientLinkLabel;
        private System.Windows.Forms.LinkLabel newNonSolidairtyGroupLinkLabel;
        private System.Windows.Forms.LinkLabel newSolidarityGroupLinkLabel;
        private System.Windows.Forms.LinkLabel newCorporateClientLinkLabel;
        private System.Windows.Forms.TableLayoutPanel riskTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel portfolioPanel;
        private System.Windows.Forms.Panel parPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel disbursementsPanel;
        private System.Windows.Forms.Panel olbTrendPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel searchClientLabel;
        private System.Windows.Forms.LinkLabel searchContractLabel;
        private System.Windows.Forms.Label configureLabel;
        private System.Windows.Forms.LinkLabel configureLoanProductsLabel;
        private System.Windows.Forms.LinkLabel configureSavingsProductsLabel;
        private System.Windows.Forms.LinkLabel configureCollateralProducts;
        private System.Windows.Forms.LinkLabel configureSettingsLabel;
        private System.Windows.Forms.LinkLabel configurePermissionsLabel;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.LinkLabel auditTrailLabel;
        private System.Windows.Forms.LinkLabel activeLoansLink;
        private System.Windows.Forms.TableLayoutPanel topBarPanel;
        private System.Windows.Forms.PictureBox smallLogoPictureBox;
        private System.Windows.Forms.LinkLabel parAnalysisLink;
        private System.Windows.Forms.LinkLabel delinquentLoansLink;
        private System.Windows.Forms.LinkLabel disbursementsLink;
        private System.Windows.Forms.Panel _filterPanel;
        private System.Windows.Forms.Label _branchFilterLabel;
        private System.Windows.Forms.ComboBox _branchFilterComboBox;
        private System.Windows.Forms.ComboBox _userFilterComboBox;
        private System.Windows.Forms.Label _userFilterLabel;
        private System.Windows.Forms.ComboBox _loanProductFilterComboBox;
        private System.Windows.Forms.Label _loanProductFilterLabel;
        private System.Windows.Forms.Button _refreshButton;
        private System.Windows.Forms.FlowLayoutPanel _infoFlowLayoutPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel _servicesLinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel _userGuideLinkLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel _contactLinkLabel;
        private BrightIdeasSoftware.ObjectListView parListView;
        private BrightIdeasSoftware.OLVColumn parNameColumn;
        private BrightIdeasSoftware.OLVColumn parAmountColumn;
        private BrightIdeasSoftware.OLVColumn parQuantityColumn;
    }
}
