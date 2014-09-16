USE [Test]
GO
/****** Object:  Table [dbo].[CollateralProducts]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollateralProducts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[desc] [nvarchar](1000) NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_CollateralProducts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_CollateralProducts_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientTypes]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type_name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientLocation]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientLocation](
	[client_id] [int] NOT NULL,
	[lat] [float] NULL,
	[lng] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomFields]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomFields](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[caption] [nvarchar](255) NOT NULL,
	[type] [varchar](20) NOT NULL,
	[owner] [varchar](20) NOT NULL,
	[tab] [nvarchar](255) NOT NULL,
	[unique] [bit] NOT NULL,
	[mandatory] [bit] NOT NULL,
	[order] [int] NOT NULL,
	[extra] [nvarchar](max) NULL,
	[deleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurrentAccountTransactions]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrentAccountTransactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[from_account] [nvarchar](100) NOT NULL,
	[to_account] [nvarchar](50) NOT NULL,
	[amount] [money] NULL,
	[transaction_date] [date] NOT NULL,
	[transaction_mode] [nvarchar](50) NOT NULL,
	[transaction_type] [nvarchar](50) NOT NULL,
	[transaction_fees] [money] NULL,
	[maker] [nvarchar](50) NOT NULL,
	[checker] [nvarchar](50) NOT NULL,
	[purpose_of_transfer] [nvarchar](max) NULL,
	[from_account_balance] [money] NULL,
	[to_account_balance] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrentAccountTransactionFees]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrentAccountTransactionFees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[current_account_product_id] [int] NULL,
	[transaction_type] [nvarchar](100) NOT NULL,
	[transaction_fees_type] [nvarchar](50) NOT NULL,
	[transaction_fees] [money] NULL,
	[transaction_fees_min] [money] NULL,
	[transaction_fees_max] [money] NULL,
	[transaction_mode] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrentAccountProductHoldings]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrentAccountProductHoldings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NULL,
	[client_type] [nvarchar](50) NULL,
	[current_account_contract_code] [nvarchar](50) NOT NULL,
	[current_account_product_id] [int] NOT NULL,
	[initial_amount] [money] NULL,
	[opening_accounting_officer] [nvarchar](50) NOT NULL,
	[closing_accounting_officer] [nvarchar](50) NULL,
	[open_date] [date] NOT NULL,
	[close_date] [date] NULL,
	[status] [nvarchar](50) NULL,
	[comment] [nvarchar](50) NULL,
	[entry_fees] [money] NULL,
	[reopen_fees] [money] NULL,
	[closing_fees] [money] NULL,
	[management_fees] [money] NULL,
	[overdraft_fees] [money] NULL,
	[entry_fees_type] [nvarchar](50) NULL,
	[reopen_fees_type] [nvarchar](50) NULL,
	[closing_fees_type] [nvarchar](50) NULL,
	[management_fees_type] [nvarchar](50) NULL,
	[overdraft_fees_type] [nvarchar](50) NULL,
	[management_fees_frequency] [nvarchar](50) NOT NULL,
	[initial_amount_payment_method] [nvarchar](50) NOT NULL,
	[final_amount_payment_method] [nvarchar](50) NULL,
	[final_amount_account_number] [nvarchar](50) NULL,
	[balance] [money] NULL,
	[overdraft_limit] [money] NULL,
	[interest_rate] [float] NULL,
	[interest_calculation_frequency] [int] NULL,
	[initial_amount_account_number] [nvarchar](50) NULL,
	[overdraft_interest_type] [nchar](10) NULL,
	[overdraft_interest] [float] NULL,
	[overdraft_commitment_fee_type] [nchar](10) NULL,
	[overdraft_commitment_fee] [float] NULL,
	[overdraft_applied] [int] NULL,
	[overdraft_applied_date] [date] NULL,
	[alloted_overdraft_limit] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrentAccountProduct]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrentAccountProduct](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deleted] [int] NULL,
	[current_account_product_name] [nvarchar](50) NOT NULL,
	[current_account_product_code] [nvarchar](50) NOT NULL,
	[client_type] [nvarchar](50) NULL,
	[currency] [nvarchar](50) NULL,
	[initial_amount_min] [money] NULL,
	[initial_amount_max] [money] NULL,
	[balance_min] [money] NULL,
	[balance_max] [money] NULL,
	[entry_fees_type] [nvarchar](50) NULL,
	[reopen_fees_type] [nvarchar](50) NULL,
	[closing_fees_type] [nvarchar](50) NULL,
	[management_fees_type] [nvarchar](50) NULL,
	[overdraft_type] [nvarchar](50) NULL,
	[entry_fees_min] [money] NULL,
	[reopen_fees_min] [money] NULL,
	[closing_fees_min] [money] NULL,
	[management_fees_min] [money] NULL,
	[overdraft_min] [money] NULL,
	[entry_fees_max] [money] NULL,
	[reopen_fees_max] [money] NULL,
	[closing_fees_max] [money] NULL,
	[management_fees_max] [money] NULL,
	[overdraft_max] [money] NULL,
	[entry_fees_value] [money] NULL,
	[reopen_fees_value] [money] NULL,
	[closing_fees_value] [money] NULL,
	[management_fees_value] [money] NULL,
	[overdraft_value] [money] NULL,
	[management_fees_frequency] [nvarchar](50) NOT NULL,
	[interest_min] [float] NULL,
	[interest_max] [float] NULL,
	[interest_type] [nvarchar](50) NULL,
	[interest_value] [float] NULL,
	[interest_frequency] [int] NULL,
	[overdraft_limit] [money] NULL,
	[overdraft_interest_type] [nchar](10) NULL,
	[overdraft_interest_value] [float] NULL,
	[overdraft_interest_min] [float] NULL,
	[overdraft_interest_max] [float] NULL,
	[commitment_fee_type] [nchar](10) NULL,
	[commitment_fee_min] [float] NULL,
	[commitment_fee_max] [float] NULL,
	[commitment_fee_value] [float] NULL,
	[overdraft_limit_min] [money] NULL,
	[overdraft_limit_max] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrentAccountEvents]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrentAccountEvents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contract_code] [nvarchar](50) NOT NULL,
	[event_code] [nchar](10) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[creation_date] [date] NOT NULL,
	[user_name] [nvarchar](50) NULL,
	[user_role] [nvarchar](50) NULL,
	[deleted] [int] NULL,
 CONSTRAINT [PK_CurrentAccountEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currencies]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currencies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[is_pivot] [bit] NOT NULL,
	[code] [nvarchar](20) NOT NULL,
	[is_swapped] [bit] NOT NULL,
	[use_cents] [bit] NOT NULL,
 CONSTRAINT [PK_Currencies] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditInsuranceEvents]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditInsuranceEvents](
	[id] [int] NOT NULL,
	[commission] [decimal](18, 2) NOT NULL,
	[principal] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConsolidatedData]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConsolidatedData](
	[branch] [nvarchar](20) NOT NULL,
	[date] [datetime] NOT NULL,
	[olb] [money] NULL,
	[par] [money] NULL,
	[number_of_clients] [int] NULL,
	[number_of_contracts] [int] NULL,
	[disbursements_amount] [money] NULL,
	[disbursements_fees] [money] NULL,
	[repayments_principal] [money] NULL,
	[repayments_interest] [money] NULL,
	[repayments_commissions] [money] NULL,
	[repayments_penalties] [money] NULL,
 CONSTRAINT [IX_ConsolidatedData] UNIQUE NONCLUSTERED 
(
	[branch] ASC,
	[date] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CollateralPropertyTypes]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollateralPropertyTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_CollateralPropertyTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountingClosure]    Script Date: 09/17/2014 00:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingClosure](
	[user_id] [int] NOT NULL,
	[date_of_closure] [datetime] NOT NULL,
	[count_of_transactions] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[is_deleted] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[DetermineLoanFacilityLimit]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DetermineLoanFacilityLimit]
(
	@clientid int
)
AS
BEGIN




SELECT 1000 AS ret
END
GO
/****** Object:  Table [dbo].[DelinquencyContracts]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DelinquencyContracts](
	[contract_id] [int] NOT NULL,
	[event_call_id] [int] IDENTITY(1,1) NOT NULL,
	[comment] [nvarchar](max) NULL,
	[amount] [decimal](20, 4) NULL,
	[interest] [decimal](20, 4) NULL,
	[late_days] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[person_in_charge] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cycles]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cycles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Cycles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CycleParameters]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CycleParameters](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[loan_cycle] [int] NOT NULL,
	[min] [money] NOT NULL,
	[max] [money] NOT NULL,
	[cycle_object_id] [int] NOT NULL,
	[cycle_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CycleObjects]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CycleObjects](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CounterBalance]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CounterBalance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[allocater_id] [int] NOT NULL,
	[branch] [nvarchar](100) NOT NULL,
	[cashier_id] [nvarchar](100) NOT NULL,
	[counter_id] [nvarchar](100) NOT NULL,
	[allocation_date] [date] NOT NULL,
	[amount] [money] NULL,
	[type] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorporateEventsType]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorporateEventsType](
	[id] [int] NOT NULL,
	[code] [nvarchar](50) NULL,
 CONSTRAINT [PK_CorporateEventsType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountsCategory]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountsCategory](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AccountsCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActionItems]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActionItems](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[class_name] [nvarchar](50) NOT NULL,
	[method_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ActionItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdvancedFieldsTypes]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvancedFieldsTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AdvancedFieldsTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdvancedFieldsLinkEntities]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdvancedFieldsLinkEntities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[link_type] [char](1) NOT NULL,
	[link_id] [int] NOT NULL,
 CONSTRAINT [PK_AdvancedFieldsLinkEntities] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdvancedFieldsEntities]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvancedFieldsEntities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AdvancedFieldsEntities] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[deleted] [bit] NOT NULL,
	[code] [nvarchar](20) NULL,
	[address] [nvarchar](255) NULL,
	[description] [nvarchar](255) NULL,
	[branch_account_number] [nvarchar](50) NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BranchCounter]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BranchCounter](
	[Branch] [nchar](10) NULL,
	[CounterId] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banks]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address] [nvarchar](200) NULL,
	[BIC] [nvarchar](50) NULL,
	[IBAN1] [nvarchar](100) NULL,
	[IBAN2] [nvarchar](100) NULL,
	[name] [nvarchar](50) NULL,
	[customIBAN1] [bit] NULL,
	[customIBAN2] [bit] NULL,
 CONSTRAINT [PK_Banks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankGuarantees]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankGuarantees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[bankGuaranteeCode] [nvarchar](100) NULL,
	[issuingDate] [datetime] NULL,
	[expiryDate] [datetime] NULL,
	[applicantId] [int] NOT NULL,
	[beneficiaryParty] [nvarchar](1000) NOT NULL,
	[guarnteeType] [nvarchar](100) NOT NULL,
	[feePerPeriod] [money] NOT NULL,
	[feePeriod] [nvarchar](100) NOT NULL,
	[instrumentDetails] [nvarchar](1000) NOT NULL,
	[value] [money] NOT NULL,
	[currency] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
	[branch] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlertSettings]    Script Date: 09/17/2014 00:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlertSettings](
	[parameter] [nvarchar](20) NOT NULL,
	[value] [nvarchar](5) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[IntListToTable]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IntListToTable] (@list nvarchar(MAX))
RETURNS @tbl TABLE (number INT NOT NULL) AS
BEGIN
   DECLARE @pos        int,
           @nextpos    int,
           @valuelen   int
   SELECT @pos = 0, @nextpos = 1
   WHILE @nextpos > 0
   BEGIN
      SELECT @nextpos = charindex(',', @list, @pos + 1)
      SELECT @valuelen = CASE WHEN @nextpos > 0
                              THEN @nextpos
                              ELSE len(@list) + 1
                         END - @pos - 1
      INSERT @tbl (number)
      VALUES (CONVERT(INT, RTRIM(LTRIM(SUBSTRING(@list, @pos + 1, @valuelen)))))
      SELECT @pos = @nextpos
   END
  RETURN
END
GO
/****** Object:  Table [dbo].[InstallmentTypes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstallmentTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[nb_of_days] [int] NOT NULL,
	[nb_of_months] [int] NOT NULL,
 CONSTRAINT [PK_InstallmentTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Info]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Info](
	[ceo] [nvarchar](50) NULL,
	[accountant] [nvarchar](50) NULL,
	[mfi] [nvarchar](50) NULL,
	[branch] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[cashier] [nvarchar](50) NULL,
	[branchmanager] [nvarchar](50) NULL,
	[branchadress] [nvarchar](50) NULL,
	[BIK] [nvarchar](50) NULL,
	[INN] [nvarchar](50) NULL,
	[AN] [nvarchar](50) NULL,
	[BranchLicense] [nvarchar](100) NULL,
	[LA] [nvarchar](50) NULL,
	[Superviser] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HousingSituation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HousingSituation](
	[name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanEntryFeeEvents]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanEntryFeeEvents](
	[id] [int] NOT NULL,
	[fee] [money] NOT NULL,
	[disbursement_event_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethods]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethods](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[description] [nvarchar](250) NULL,
	[pending] [bit] NULL,
 CONSTRAINT [PK_PaymentMethods] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PackagesClientTypes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PackagesClientTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_type_id] [int] NOT NULL,
	[package_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Provinces] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questionnaire]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questionnaire](
	[Name] [nvarchar](256) NULL,
	[Country] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[PositionInCompony] [nvarchar](100) NULL,
	[OtherMessages] [nvarchar](4000) NULL,
	[GrossPortfolio] [nvarchar](50) NULL,
	[NumberOfClients] [nvarchar](50) NULL,
	[PersonName] [nvarchar](200) NULL,
	[Phone] [nvarchar](200) NULL,
	[Skype] [nvarchar](200) NULL,
	[PurposeOfUsage] [nvarchar](200) NULL,
	[is_sent] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublicHolidays]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicHolidays](
	[date] [datetime] NOT NULL,
	[name] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProvisioningRules]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProvisioningRules](
	[id] [int] NOT NULL,
	[number_of_days_min] [int] NOT NULL,
	[number_of_days_max] [int] NOT NULL,
	[provisioning_value] [float] NOT NULL,
	[provisioning_interest] [float] NOT NULL,
	[provisioning_penalty] [float] NOT NULL,
 CONSTRAINT [PK_ProvisioningRules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rep_Active_Loans_Data]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rep_Active_Loans_Data](
	[id] [int] NOT NULL,
	[branch_name] [nvarchar](50) NULL,
	[load_date] [datetime] NULL,
	[break_down] [nvarchar](150) NULL,
	[break_down_type] [nvarchar](20) NULL,
	[contracts] [int] NULL,
	[individual] [int] NULL,
	[group] [int] NULL,
	[corporate] [int] NULL,
	[clients] [int] NULL,
	[in_groups] [int] NULL,
	[projects] [int] NULL,
	[olb] [money] NULL,
	[break_down_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanTransitionEvents]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanTransitionEvents](
	[id] [int] NOT NULL,
	[amount] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monitoring]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monitoring](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[object_id] [int] NOT NULL,
	[date] [datetime] NULL,
	[purpose] [nvarchar](255) NULL,
	[monitor] [nvarchar](255) NULL,
	[comment] [nvarchar](4000) NULL,
	[type] [bit] NOT NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: Client 1:Loan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Monitoring', @level2type=N'COLUMN',@level2name=N'type'
GO
/****** Object:  Table [dbo].[MFI]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MFI](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](55) NOT NULL,
	[login] [nvarchar](55) NULL,
	[password] [nvarchar](55) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuItems](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[component_name] [nvarchar](100) NOT NULL,
	[type] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[component_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: Normal menu items loaded for main menu
1: Extension control menus' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MenuItems', @level2type=N'COLUMN',@level2name=N'type'
GO
/****** Object:  Table [dbo].[ProjectPurposes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectPurposes](
	[name] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonsPhotos]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonsPhotos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NOT NULL,
	[picture_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanShareAmounts]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanShareAmounts](
	[person_id] [int] NOT NULL,
	[group_id] [int] NOT NULL,
	[contract_id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[event_id] [int] NULL,
	[payment_date] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanScale]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanScale](
	[id] [int] NOT NULL,
	[ScaleMin] [int] NULL,
	[ScaleMax] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanInterestAccruingEvents]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanInterestAccruingEvents](
	[id] [int] NOT NULL,
	[interest_prepayment] [money] NOT NULL,
	[accrued_interest] [money] NOT NULL,
	[rescheduled] [bit] NOT NULL,
	[installment_number] [int] NOT NULL,
 CONSTRAINT [PK_LoanInterestAccruingEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LateDaysRange]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LateDaysRange](
	[Min] [int] NOT NULL,
	[Max] [int] NOT NULL,
	[Label] [nvarchar](15) NULL,
	[Color] [nvarchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exotics]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exotics](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Exotics] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Exotics_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExchangeRates]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExchangeRates](
	[exchange_date] [datetime] NOT NULL,
	[exchange_rate] [float] NOT NULL,
	[currency_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventTypes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[event_type] [nvarchar](4) NOT NULL,
	[description] [nvarchar](50) NOT NULL,
	[sort_order] [int] NULL,
	[accounting] [bit] NULL,
 CONSTRAINT [PK_EventTypes_1] PRIMARY KEY CLUSTERED 
(
	[event_type] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EconomicActivityLoanHistory]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EconomicActivityLoanHistory](
	[contract_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[group_id] [int] NULL,
	[economic_activity_id] [int] NOT NULL,
	[deleted] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EconomicActivities]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EconomicActivities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[parent_id] [int] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_DomainOfApplications] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FixedDepositEvents]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FixedDepositEvents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contract_code] [nvarchar](50) NOT NULL,
	[event_code] [nchar](10) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[creation_date] [date] NOT NULL,
	[user_name] [nvarchar](50) NULL,
	[user_role] [nvarchar](50) NULL,
	[deleted] [int] NULL,
 CONSTRAINT [PK_FixedDepositEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FixedAssetRegister]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FixedAssetRegister](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[branch] [nvarchar](100) NOT NULL,
	[updater_id] [int] NULL,
	[Asset_id] [nvarchar](100) NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[Asset_type] [nvarchar](100) NOT NULL,
	[No_of_assets] [int] NOT NULL,
	[Acquisition_date] [date] NOT NULL,
	[Original_cost] [money] NULL,
	[Annual_depreciation_rate] [float] NOT NULL,
	[Accumulated_depreciation_charge] [money] NULL,
	[Net_book_value] [money] NULL,
	[Disposal_date] [date] NULL,
	[Profit_loss_disposal] [int] NULL,
	[Acquisition_capital_finance] [nvarchar](100) NOT NULL,
	[Acquisition_capital_transaction] [nvarchar](100) NOT NULL,
	[Disposal_amount_transfer] [nvarchar](100) NULL,
	[Disposal_amount_transaction] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FiscalYear]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiscalYear](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[open_date] [datetime] NULL,
	[close_date] [datetime] NULL,
 CONSTRAINT [PK_FiscalYear] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeneralParameters]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GeneralParameters](
	[key] [varchar](50) NOT NULL,
	[value] [nvarchar](200) NULL,
 CONSTRAINT [PK_GeneralParameters] PRIMARY KEY CLUSTERED 
(
	[key] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[GetClientIdFromContractCode]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetClientIdFromContractCode](@code  VARCHAR(200))
RETURNS VARCHAR(20) 
AS 
BEGIN
DECLARE @clientid  VARCHAR(20);
--DECLARE @code  VARCHAR(200);
DECLARE @len INT;
DECLARE @lastOcc INT;
DECLARE @nextOcc INT;
DECLARE @start INT;
--SET @code='DEF/14123/default-1/2123/8';
SELECT @len= LEN (@code);
SELECT @start=CHARINDEX('/', REVERSE(@code));
SELECT @lastOcc= (@len- CHARINDEX('/', REVERSE(@code)));
SELECT @nextOcc=(@len- CHARINDEX('/', REVERSE(@code),@start+1))+2;
SELECT   @clientid = SUBSTRING(@code,@nextOcc, (@len-@lastOcc+@start));
--RETURN @clientid;
RETURN 1;
END
GO
/****** Object:  Table [dbo].[FixedDepositProductsClientTypes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FixedDepositProductsClientTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fixed_deposit_product_id] [int] NOT NULL,
	[client_type_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FixedDepositProducts]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FixedDepositProducts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [nvarchar](100) NOT NULL,
	[product_code] [nvarchar](50) NOT NULL,
	[client_type] [nvarchar](50) NULL,
	[product_currency] [nvarchar](50) NOT NULL,
	[initial_amount_min] [money] NULL,
	[initial_amount_max] [money] NULL,
	[interest_rate_min] [float] NULL,
	[interest_rate_max] [float] NULL,
	[maturity_period_min] [int] NULL,
	[maturity_period_max] [int] NULL,
	[interest_calculation_frequency] [nvarchar](50) NOT NULL,
	[penality_type] [nvarchar](50) NOT NULL,
	[penality_min] [float] NULL,
	[penality_max] [float] NULL,
	[deleted] [int] NOT NULL,
	[penalty_value] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[GetLoanClientId]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetLoanClientId](@code  VARCHAR(200))
RETURNS int 
AS 
BEGIN
DECLARE @clientid  VARCHAR(20);
--DECLARE @code  VARCHAR(200);
DECLARE @len INT;
DECLARE @lastOcc INT;
DECLARE @nextOcc INT;
DECLARE @start INT;
--SET @code='DEF/14123/default-1/2123/8';
SELECT @len= LEN (@code);
SELECT @start=CHARINDEX('/', REVERSE(@code));
SELECT @lastOcc= (@len- CHARINDEX('/', REVERSE(@code)));
SELECT @nextOcc=(@len- CHARINDEX('/', REVERSE(@code),@start+1))+2;
SELECT   @clientid = SUBSTRING(@code,@nextOcc, (@len-@lastOcc+@start));
RETURN @clientid;
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetProfitLoss]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetProfitLoss](@profitLossDisposal INT)
RETURNS VARCHAR(20) 
AS 
BEGIN
    DECLARE @profitOrLoss VARCHAR(20) 
    
    IF @profitLossDisposal IS NULL
BEGIN
SET @profitOrLoss='Not Disposed'
END
    
ELSE IF @profitLossDisposal=-1
BEGIN
SET @profitOrLoss='Loss'
END
ELSE IF @profitLossDisposal=1 
BEGIN
SET @profitOrLoss='Profit'
END
ELSE  
BEGIN
SET @profitOrLoss='No Profit, No Loss'
END
    RETURN @profitOrLoss;
END
GO
/****** Object:  Table [dbo].[Rep_Par_Analysis_Data]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rep_Par_Analysis_Data](
	[id] [int] NOT NULL,
	[branch_name] [nvarchar](50) NULL,
	[load_date] [datetime] NULL,
	[break_down] [nvarchar](150) NULL,
	[break_down_type] [varchar](20) NULL,
	[olb] [money] NULL,
	[par] [money] NULL,
	[contracts] [int] NULL,
	[clients] [int] NULL,
	[all_contracts] [int] NULL,
	[all_clients] [int] NULL,
	[par_30] [money] NULL,
	[contracts_30] [int] NULL,
	[clients_30] [int] NULL,
	[par_1_30] [money] NULL,
	[contracts_1_30] [int] NULL,
	[clients_1_30] [int] NULL,
	[par_31_60] [money] NULL,
	[contracts_31_60] [int] NULL,
	[clients_31_60] [int] NULL,
	[par_61_90] [money] NULL,
	[contracts_61_90] [int] NULL,
	[clients_61_90] [int] NULL,
	[par_91_180] [money] NULL,
	[contracts_91_180] [int] NULL,
	[clients_91_180] [int] NULL,
	[par_181_365] [money] NULL,
	[contracts_181_365] [int] NULL,
	[clients_181_365] [int] NULL,
	[par_365] [money] NULL,
	[contracts_365] [int] NULL,
	[clients_365] [int] NULL,
	[break_down_id] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rep_OLB_and_LLP_Data]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rep_OLB_and_LLP_Data](
	[id] [int] NOT NULL,
	[branch_name] [nvarchar](50) NULL,
	[load_date] [datetime] NULL,
	[contract_code] [nvarchar](255) NULL,
	[olb] [money] NULL,
	[interest] [money] NULL,
	[late_days] [int] NULL,
	[client_name] [nvarchar](255) NULL,
	[loan_officer_name] [nvarchar](255) NULL,
	[product_name] [nvarchar](255) NULL,
	[district_name] [nvarchar](255) NULL,
	[start_date] [datetime] NULL,
	[close_date] [datetime] NULL,
	[range_from] [int] NULL,
	[range_to] [int] NULL,
	[llp_rate] [int] NULL,
	[llp] [money] NULL,
	[rescheduled] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rep_Rescheduled_Loans_Data]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rep_Rescheduled_Loans_Data](
	[id] [int] NOT NULL,
	[branch_name] [nvarchar](50) NULL,
	[load_date] [datetime] NULL,
	[loan_officer] [nvarchar](255) NULL,
	[client_name] [nvarchar](255) NULL,
	[contract_code] [nvarchar](255) NULL,
	[package_name] [nvarchar](255) NULL,
	[loan_amount] [money] NULL,
	[amount_rescheduled] [money] NULL,
	[maturity] [int] NULL,
	[reschedule_date] [datetime] NULL,
	[olb] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rep_Repayments_Data]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rep_Repayments_Data](
	[id] [int] NOT NULL,
	[branch_name] [nvarchar](50) NULL,
	[load_date] [datetime] NULL,
	[event_id] [int] NULL,
	[contract_code] [nvarchar](255) NULL,
	[client_name] [nvarchar](255) NULL,
	[district_name] [nvarchar](255) NULL,
	[loan_officer_name] [nvarchar](255) NULL,
	[loan_product_name] [nvarchar](255) NULL,
	[early_fee] [money] NULL,
	[late_fee] [money] NULL,
	[principal] [money] NULL,
	[interest] [money] NULL,
	[total] [money] NULL,
	[written_off] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rep_Disbursements_Data]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rep_Disbursements_Data](
	[id] [int] NOT NULL,
	[branch_name] [nvarchar](50) NULL,
	[load_date] [datetime] NULL,
	[contract_code] [nvarchar](255) NULL,
	[district] [nvarchar](255) NULL,
	[loan_product] [nvarchar](255) NULL,
	[client_name] [nvarchar](255) NULL,
	[loan_cycle] [int] NULL,
	[loan_officer] [nvarchar](255) NULL,
	[disbursement_date] [datetime] NULL,
	[amount] [money] NULL,
	[interest] [money] NULL,
	[fees] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](256) NOT NULL,
	[deleted] [bit] NOT NULL,
	[description] [nvarchar](2048) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RiskWeightedAssetPercenatge]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RiskWeightedAssetPercenatge](
	[risk_weighted_asset] [nvarchar](100) NULL,
	[risk_weighted_percentage] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraceUserLogs]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraceUserLogs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[event_code] [nvarchar](10) NULL,
	[event_date] [datetime] NULL,
	[user_id] [int] NULL,
	[event_description] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavingProductsClientTypes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavingProductsClientTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[saving_product_id] [int] NOT NULL,
	[client_type_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WriteOffOptions]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WriteOffOptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Test](
	[char_type] [char](1) NULL,
	[varchar_type] [varchar](50) NULL,
	[nvarchar_type] [nvarchar](50) NULL,
	[integer_type] [int] NULL,
	[double_type] [float] NULL,
	[money_type] [money] NULL,
	[boolean_type] [bit] NULL,
	[datetime_type] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SetUp_SubventionTypes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_SubventionTypes](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_StudyLevel]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_StudyLevel](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_Sponsor2]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_Sponsor2](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_Sponsor1]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_Sponsor1](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_SocialSituation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_SocialSituation](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_SageJournal]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_SageJournal](
	[product_code] [nvarchar](50) NOT NULL,
	[journal_code] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SetUp_SageJournal] PRIMARY KEY CLUSTERED 
(
	[product_code] ASC,
	[journal_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_Registre]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_Registre](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_ProfessionalSituation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_ProfessionalSituation](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_ProfessionalExperience]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_ProfessionalExperience](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_PersonalSituation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_PersonalSituation](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_LegalStatus]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_LegalStatus](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_InsertionTypes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_InsertionTypes](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_HousingSituation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_HousingSituation](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_HousingLocation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_HousingLocation](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_FiscalStatus]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_FiscalStatus](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_FamilySituation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_FamilySituation](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_DwellingPlace]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_DwellingPlace](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_BusinessPlan]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_BusinessPlan](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_BankSituation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_BankSituation](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUp_ActivityState]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUp_ActivityState](
	[value] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[ufnCalculateAccumulatedDepriciation]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnCalculateAccumulatedDepriciation](@depreciationRate FLOAT,@originalCost 

FLOAT,
 @acquiredDate DATETIME, @disposalDate DATETIME)
RETURNS int 
AS 
BEGIN
    DECLARE @days FLOAT;
DECLARE @totalDepreciation INT;
SET @days= DATEDIFF(day,@acquiredDate,@disposalDate)
SET @totalDepreciation= (@originalCost*@depreciationRate*@days)/(100*360);
    RETURN @totalDepreciation;
END
GO
/****** Object:  Table [dbo].[TechnicalParameters]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnicalParameters](
	[name] [nvarchar](100) NOT NULL,
	[value] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TechnicalParameters] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[StringListToTable]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[StringListToTable] (@list nvarchar(MAX))
RETURNS @tbl TABLE (string NVARCHAR(MAX) NOT NULL) AS
BEGIN
   DECLARE @pos        int,
           @nextpos    int,
           @valuelen   int
   SELECT @pos = 0, @nextpos = 1
   WHILE @nextpos > 0
   BEGIN
      SELECT @nextpos = charindex(',', @list, @pos + 1)
      SELECT @valuelen = CASE WHEN @nextpos > 0
                              THEN @nextpos
                              ELSE len(@list) + 1
                         END - @pos - 1
      INSERT @tbl (string)
      VALUES (rtrim(ltrim(substring(@list, @pos + 1, @valuelen))))
      SELECT @pos = @nextpos
   END
  RETURN
END
GO
/****** Object:  Table [dbo].[Statuses]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deleted] [bit] NOT NULL,
	[user_name] [nvarchar](50) NOT NULL,
	[user_pass] [nvarchar](50) NOT NULL,
	[role_code] [nvarchar](256) NOT NULL,
	[first_name] [nvarchar](200) NULL,
	[last_name] [nvarchar](200) NULL,
	[mail] [nvarchar](100) NOT NULL,
	[sex] [nchar](1) NOT NULL,
	[phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Users_username_pwd] UNIQUE NONCLUSTERED 
(
	[user_name] ASC,
	[user_pass] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Villages]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Villages](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[establishment_date] [datetime] NOT NULL,
	[loan_officer] [int] NOT NULL,
	[meeting_day] [int] NULL,
 CONSTRAINT [PK_Villages] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersSubordinates]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersSubordinates](
	[user_id] [int] NOT NULL,
	[subordinate_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersBranches]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersBranches](
	[user_id] [int] NOT NULL,
	[branch_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[role_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[date_role_set] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavingProducts]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SavingProducts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deleted] [bit] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[client_type] [char](1) NULL,
	[initial_amount_min] [money] NULL,
	[initial_amount_max] [money] NULL,
	[balance_min] [money] NULL,
	[balance_max] [money] NULL,
	[withdraw_min] [money] NULL,
	[withdraw_max] [money] NULL,
	[deposit_min] [money] NULL,
	[deposit_max] [money] NULL,
	[interest_rate] [float] NULL,
	[interest_rate_min] [float] NULL,
	[interest_rate_max] [float] NULL,
	[currency_id] [int] NOT NULL,
	[entry_fees_min] [money] NULL,
	[entry_fees_max] [money] NULL,
	[entry_fees] [money] NULL,
	[product_type] [char](1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[transfer_min] [money] NOT NULL,
	[transfer_max] [money] NOT NULL,
 CONSTRAINT [PK_SavingProduct] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_SavingProduct_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[GetXR]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return exchange rate for a given date and a couple of currencies
--
-- HISTORY
--
-- Apr 04, 2010 - v2.8.14 - Pasha BASTOV - Adds a check that prevents from returning NULL values
CREATE FUNCTION [dbo].[GetXR]
(
	@from INT
	, @to INT
	, @date DATETIME
)
RETURNS FLOAT
AS BEGIN
	IF @from = @to
	BEGIN
		RETURN 1
	END
	
	-- Get pivot currency
	DECLARE @pivot INT
	SELECT @pivot = id
	FROM dbo.Currencies
	WHERE is_pivot = 1
	
	-- Get exchange rate
	DECLARE @xr FLOAT
	SELECT TOP 1 @xr = exchange_rate
	FROM dbo.ExchangeRates
	WHERE exchange_date <= @date AND currency_id IN (@from, @to)
	ORDER BY exchange_date DESC
	SET @xr = CASE WHEN @from = @pivot THEN @xr ELSE 1/@xr END
	RETURN @xr
END
GO
/****** Object:  StoredProcedure [dbo].[GetFixedAssetRegister]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetFixedAssetRegister]

AS

BEGIN

SELECT [id]
      ,[updater_id]
      ,[branch]
      ,[Asset_id]
      ,[Description]
      ,[Asset_type]
      ,[No_of_assets]
      ,[Acquisition_date]
      ,[Original_cost]
      ,[Annual_depreciation_rate]
      ,dbo.ufnCalculateAccumulatedDepriciation([Annual_depreciation_rate],[Original_cost],
[Acquisition_date] ,[Disposal_date] ) As Accumulated_Depreciation_Charge
      ,([Original_cost] -
dbo.ufnCalculateAccumulatedDepriciation([Annual_depreciation_rate],[Original_cost],
[Acquisition_date] ,[Disposal_date] ))*[No_of_assets] as Net_Book_Value
      ,[Disposal_date]
	,dbo.GetProfitLoss([profit_loss_disposal]) As Profit_Loss
      ,[Acquisition_capital_finance]
      ,[Acquisition_capital_transaction]
      ,[Disposal_amount_transfer]
      ,[Disposal_amount_transaction]
  FROM [dbo].[FixedAssetRegister]

END
GO
/****** Object:  StoredProcedure [dbo].[GetDormantAccount]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure[dbo].[GetDormantAccount]
( @from_account	nvarchar(50)--,@error INT OUTPUT
)
AS
BEGIN
   DECLARE @date DATETIME 
   DECLARE @dateDiff INT
   SELECT @date=transaction_date FROM CurrentAccountTransactions where from_account=@from_account AND transaction_type
   <> 'Fee' AND transaction_type <> 'Interest' 
SELECT @dateDiff = DATEDIFF(day,@date ,GETDATE())
IF @dateDiff < 730
BEGIN
RETURN 1
--Update Status in CurrentAccountProductHoldings as Dormant
UPDATE CurrentAccountProductHoldings SET status = 'Dormant' WHERE
current_account_contract_code = @from_account
--Insert Event in CurrentAccountEvents
INSERT INTO [Test].[dbo].[CurrentAccountEvents]
           ([contract_code]
           ,[event_code]
           ,[description]
           ,[creation_date])
     VALUES
           (@from_account
           ,'CADO'
           ,'Automated Account Dormancy'
           ,GETDATE())

END
ELSE
BEGIN
RETURN -1
END
END
GO
/****** Object:  Table [dbo].[FixedDepositProductHoldings]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FixedDepositProductHoldings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NULL,
	[client_type] [nvarchar](50) NULL,
	[fixed_deposit_contract_code] [nvarchar](50) NOT NULL,
	[initial_amount] [money] NULL,
	[interest_rate] [float] NULL,
	[maturity_period] [int] NULL,
	[interest_calculation_frequency] [nvarchar](50) NOT NULL,
	[penality_type] [nvarchar](50) NOT NULL,
	[penality] [float] NULL,
	[opening_accounting_officer] [nvarchar](50) NOT NULL,
	[closing_accounting_officer] [nvarchar](50) NULL,
	[open_date] [date] NOT NULL,
	[close_date] [date] NULL,
	[status] [nvarchar](50) NULL,
	[pre_matured] [int] NULL,
	[comment] [nvarchar](50) NULL,
	[fixed_deposit_product_id] [int] NOT NULL,
	[effective_interest_rate] [float] NULL,
	[effective_deposit_period] [float] NULL,
	[final_amount] [money] NULL,
	[final_interest] [money] NULL,
	[initial_amount_payment_method] [nvarchar](50) NULL,
	[final_amount_payment_method] [nvarchar](50) NULL,
	[final_penalty] [float] NULL,
	[final_cheque_account_number] [nvarchar](50) NULL,
	[initial_cheque_account_number] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundingLines]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundingLines](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[begin_date] [datetime] NOT NULL,
	[end_date] [datetime] NOT NULL,
	[amount] [decimal](18, 0) NOT NULL,
	[purpose] [nvarchar](50) NOT NULL,
	[deleted] [bit] NOT NULL,
	[currency_id] [int] NOT NULL,
 CONSTRAINT [PK_TEMP_FUNDINGLINES_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Districts]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Districts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[province_id] [int] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Districts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventAttributes]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventAttributes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[event_type] [nvarchar](4) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EventAttributes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExoticInstallments]    Script Date: 09/17/2014 00:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExoticInstallments](
	[number] [int] NOT NULL,
	[principal_coeff] [float] NOT NULL,
	[interest_coeff] [float] NULL,
	[exotic_id] [int] NOT NULL,
 CONSTRAINT [PK_ExoticInstallments] PRIMARY KEY CLUSTERED 
(
	[number] ASC,
	[exotic_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[ExchangeRatesEx]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ExchangeRatesEx]
(
	@date DATETIME
)
RETURNS TABLE
AS
RETURN
(
	SELECT c.id, CASE WHEN 1 = c.is_pivot THEN 1 ELSE xr.exchange_rate END AS exchange_rate
	FROM dbo.Currencies AS c
	LEFT JOIN dbo.ExchangeRates AS xr ON c.id = xr.currency_id 
	AND xr.exchange_date = DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE()))
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetRemainingCounterCash]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetRemainingCounterCash](@cashierId varchar(50), @dateInput DateTime)
RETURNS Money
AS 
BEGIN
    DECLARE @cashAmountCredited Money;
DECLARE @cashAmountDebited Money;
DECLARE @AmountAllocated Money;
DECLARE @AmountRemaining Money;
SELECT @cashAmountCredited=   SUM(amount) FROM [CurrentAccountTransactions] 
WHERE  [transaction_date]=@dateInput AND [transaction_type]='Cash'
AND [transaction_mode]='Credit' AND maker=@cashierId 

SELECT @cashAmountDebited=   SUM(amount) FROM [CurrentAccountTransactions] 
WHERE  [transaction_date]=@dateInput AND [transaction_type]='Cash'
AND [transaction_mode]='Debit' AND maker=@cashierId 

SELECT @AmountAllocated=  SUM([amount]) FROM [CounterBalance]
WHERE [cashier_id]=@cashierId AND [allocation_date]=@dateInput AND type='Opening Amount' or type='TopUp Amount' 

SET @AmountRemaining=@AmountAllocated+@cashAmountCredited-@cashAmountDebited;
    RETURN @AmountRemaining;
END
GO
/****** Object:  Table [dbo].[Packages]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Packages](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deleted] [bit] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[client_type] [char](1) NULL,
	[amount] [money] NULL,
	[amount_min] [money] NULL,
	[amount_max] [money] NULL,
	[interest_rate] [numeric](16, 12) NULL,
	[interest_rate_min] [numeric](16, 12) NULL,
	[interest_rate_max] [numeric](16, 12) NULL,
	[installment_type] [int] NOT NULL,
	[grace_period] [int] NULL,
	[grace_period_min] [int] NULL,
	[grace_period_max] [int] NULL,
	[number_of_installments] [int] NULL,
	[number_of_installments_min] [int] NULL,
	[number_of_installments_max] [int] NULL,
	[anticipated_total_repayment_penalties] [float] NULL,
	[anticipated_total_repayment_penalties_min] [float] NULL,
	[anticipated_total_repayment_penalties_max] [float] NULL,
	[exotic_id] [int] NULL,
	[loan_type] [smallint] NOT NULL,
	[keep_expected_installment] [bit] NOT NULL,
	[charge_interest_within_grace_period] [bit] NOT NULL,
	[cycle_id] [int] NULL,
	[non_repayment_penalties_based_on_overdue_interest] [float] NULL,
	[non_repayment_penalties_based_on_initial_amount] [float] NULL,
	[non_repayment_penalties_based_on_olb] [float] NULL,
	[non_repayment_penalties_based_on_overdue_principal] [float] NULL,
	[non_repayment_penalties_based_on_overdue_interest_min] [float] NULL,
	[non_repayment_penalties_based_on_initial_amount_min] [float] NULL,
	[non_repayment_penalties_based_on_olb_min] [float] NULL,
	[non_repayment_penalties_based_on_overdue_principal_min] [float] NULL,
	[non_repayment_penalties_based_on_overdue_interest_max] [float] NULL,
	[non_repayment_penalties_based_on_initial_amount_max] [float] NULL,
	[non_repayment_penalties_based_on_olb_max] [float] NULL,
	[non_repayment_penalties_based_on_overdue_principal_max] [float] NULL,
	[fundingLine_id] [int] NULL,
	[currency_id] [int] NOT NULL,
	[rounding_type] [smallint] NOT NULL,
	[grace_period_of_latefees] [int] NOT NULL,
	[anticipated_partial_repayment_penalties] [float] NULL,
	[anticipated_partial_repayment_penalties_min] [float] NULL,
	[anticipated_partial_repayment_penalties_max] [float] NULL,
	[anticipated_partial_repayment_base] [smallint] NOT NULL,
	[anticipated_total_repayment_base] [smallint] NOT NULL,
	[number_of_drawings_loc] [int] NULL,
	[amount_under_loc] [money] NULL,
	[amount_under_loc_min] [money] NULL,
	[amount_under_loc_max] [money] NULL,
	[maturity_loc] [int] NULL,
	[maturity_loc_min] [int] NULL,
	[maturity_loc_max] [int] NULL,
	[activated_loc] [bit] NOT NULL,
	[allow_flexible_schedule] [bit] NOT NULL,
	[use_guarantor_collateral] [bit] NOT NULL,
	[set_separate_guarantor_collateral] [bit] NOT NULL,
	[percentage_total_guarantor_collateral] [int] NOT NULL,
	[percentage_separate_guarantor] [int] NOT NULL,
	[percentage_separate_collateral] [int] NOT NULL,
	[use_compulsory_savings] [bit] NOT NULL,
	[compulsory_amount] [int] NULL,
	[compulsory_amount_min] [int] NULL,
	[compulsory_amount_max] [int] NULL,
	[insurance_min] [decimal](18, 2) NOT NULL,
	[insurance_max] [decimal](18, 2) NOT NULL,
	[use_entry_fees_cycles] [bit] NOT NULL,
	[interest_scheme] [int] NOT NULL,
	[script_name] [nvarchar](255) NULL,
 CONSTRAINT [PK_Packages] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Packages_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AmountCycles]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AmountCycles](
	[cycle_id] [int] NOT NULL,
	[number] [int] NOT NULL,
	[amount_min] [money] NOT NULL,
	[amount_max] [money] NOT NULL,
 CONSTRAINT [PK_AmountCycle] PRIMARY KEY CLUSTERED 
(
	[cycle_id] ASC,
	[number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AllowedRoleMenus]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllowedRoleMenus](
	[menu_item_id] [int] NOT NULL,
	[role_id] [int] NOT NULL,
	[allowed] [bit] NOT NULL,
 CONSTRAINT [PK_AllowedRoleMenus] PRIMARY KEY CLUSTERED 
(
	[menu_item_id] ASC,
	[role_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AllowedRoleActions]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllowedRoleActions](
	[action_item_id] [int] NOT NULL,
	[role_id] [int] NOT NULL,
	[allowed] [bit] NOT NULL,
 CONSTRAINT [PK_AllowedRoleActions] PRIMARY KEY CLUSTERED 
(
	[action_item_id] ASC,
	[role_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[BalanceCalculation]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[BalanceCalculation]
    ( @transaction_mode NVARCHAR(50), 
    @transaction_type NVARCHAR(50),
        @to_account NVARCHAR(50), 
        @from_account NVARCHAR(50), 
        @amount money ,
        @transaction_date date,
        @transaction_fees money,
        @maker NVARCHAR(50), 
        @checker NVARCHAR(50), 
        @purpose_of_transfer NVARCHAR(MAX)
        
        
        )
            AS
    BEGIN
    DECLARE
        @From_Branch NVARCHAR(50),
        @To_Branch NVARCHAR(50),
        @current_account_contract_code NVARCHAR(50),
        @branch_account_number NVARCHAR(50),
        @From_Branch_account NVARCHAR(50),
        @To_Branch_account NVARCHAR(50),
        @from_account_balance money,
        @to_account_balance money
        
        BEGIN TRANSACTION
        
    IF @transaction_mode = 'Credit'
            --Extracting To_Branch
        SELECT @To_Branch = SUBSTRING(@to_account, 1, CHARINDEX('/', @to_account, 1)-1)
    SELECT @To_Branch_account = branch_account_number
        FROM branches
        WHERE code = @To_Branch
        BEGIN
        IF @transaction_type= 'Cash' OR @transaction_type = 'Cheque'
            BEGIN
            UPDATE currentAccountProductHoldings
                SET balance= @amount + balance
                WHERE current_account_contract_code=@to_account
            UPDATE currentAccountProductHoldings
                SET balance= @amount + balance
                WHERE current_account_contract_code=@To_Branch_account
            END
        IF  @transaction_type= 'Transfer'
            BEGIN
            IF ((SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account)
                    >= @amount)
                        OR
                
                ((SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) <= @amount
                    AND
                (
                SELECT overdraft_applied
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account)= 1
                    AND
                @amount <= (
                SELECT overdraft_limit + balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account AND balance > 0 ))
                    
                    OR
                    (@amount <= (
                SELECT overdraft_limit
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account AND balance < 0 ))
                    
                BEGIN
                
                IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) < @amount
                    BEGIN
                    IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) > 0
                    BEGIN
					UPDATE currentAccountProductHoldings
                    SET overdraft_limit =  overdraft_limit-@amount+balance
                    WHERE current_account_contract_code=@from_account
                    END
                    
                    IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) <= 0
                    BEGIN
					UPDATE currentAccountProductHoldings
                    SET overdraft_limit =  overdraft_limit-@amount
                    WHERE current_account_contract_code=@from_account
                    END
                    
                    END
                
                UPDATE currentAccountProductHoldings
                    SET balance= @amount + balance
                    WHERE current_account_contract_code=@to_account
                UPDATE currentAccountProductHoldings
                    SET balance=  balance-@amount
                    WHERE current_account_contract_code=@from_account
                    
                    
                    --Extracting From_Branch
                SELECT @From_Branch =SUBSTRING(@from_account, 1, CHARINDEX('/', @from_account, 1)-1)
                IF @From_Branch<>@To_Branch
                    BEGIN
                    SELECT @From_Branch_account=branch_account_number
                        FROM branches
                        WHERE code=@From_Branch
                    UPDATE currentAccountProductHoldings
                        SET balance= @amount + balance
                        WHERE current_account_contract_code=@To_Branch_account
                    UPDATE currentAccountProductHoldings
                        SET balance=  balance-@amount
                        WHERE current_account_contract_code=@From_Branch_account
                    END
                END
            ELSE
                BEGIN
                SELECT -1 AS ret --(Balance is less than amount to be withdrawn and account does not have OD facility)
                RETURN
                END
            END
        END
    IF @transaction_mode = 'Debit'
        BEGIN
            --Extracting From_Branch
        SELECT @From_Branch =SUBSTRING(@from_account, 1, CHARINDEX('/', @from_account, 1)-1)
        SELECT @From_Branch_account=branch_account_number
            FROM branches
            WHERE code=@From_Branch
        IF @transaction_type= 'Cash' OR @transaction_type = 'Cheque'
            BEGIN
           IF ((SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account)
                    >= @amount)
                        OR
                
                ((SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) <= @amount
                    AND
                (
                SELECT overdraft_applied
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account)= 1
                    AND
                @amount <= (
                SELECT overdraft_limit + balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account AND balance > 0 ))
                    
                    OR
                    (@amount <= (
                SELECT overdraft_limit
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account AND balance < 0 ))
                BEGIN
                
                
                IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) < @amount
                    BEGIN
                    IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) > 0
                    BEGIN
					UPDATE currentAccountProductHoldings
                    SET overdraft_limit =  overdraft_limit-@amount+balance
                    WHERE current_account_contract_code=@from_account
                    END
                    
                    IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) <= 0
                    BEGIN
					UPDATE currentAccountProductHoldings
                    SET overdraft_limit =  overdraft_limit-@amount
                    WHERE current_account_contract_code=@from_account
                    END
                    
                    END
                
                UPDATE currentAccountProductHoldings
                    SET balance=  balance-@amount  
                    WHERE current_account_contract_code=@from_account
                UPDATE currentAccountProductHoldings
                    SET balance= balance-@amount
                    WHERE current_account_contract_code=@From_Branch_account
                    
                    
                END
            ELSE
                BEGIN
                SELECT -1 AS ret --(Balance is less than amount to be withdrawn and account does not have OD facility)
                RETURN
                END
            END
        IF  @transaction_type= 'Transfer'
            BEGIN
            IF ((SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account)
                    >= @amount)
                        OR
                
                ((SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) <= @amount
                    AND
                (
                SELECT overdraft_applied
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account)= 1
                    AND
                @amount <= (
                SELECT overdraft_limit + balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account AND balance > 0 ))
                    
                    OR
                    (@amount <= (
                SELECT overdraft_limit
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account AND balance < 0 ))
                BEGIN
                
                
                IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) < @amount
                    BEGIN
                    IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) > 0
                    BEGIN
					UPDATE currentAccountProductHoldings
                    SET overdraft_limit =  overdraft_limit-@amount+balance
                    WHERE current_account_contract_code=@from_account
                    END
                    
                    IF (SELECT balance
                    FROM currentAccountProductHoldings
                    WHERE current_account_contract_code=@from_account) <= 0
                    BEGIN
					UPDATE currentAccountProductHoldings
                    SET overdraft_limit =  overdraft_limit-@amount
                    WHERE current_account_contract_code=@from_account
                    END
                    
                    END
                
                UPDATE currentAccountProductHoldings
                    SET balance= @amount + balance
                    WHERE current_account_contract_code=@to_account
                    UPDATE currentAccountProductHoldings
                    SET balance=  balance-@amount WHERE current_account_contract_code=@from_account
                    
                    
                SELECT @To_Branch = SUBSTRING(@to_account, 1, CHARINDEX('/', @to_account, 1)-1)
                IF @From_Branch<>@To_Branch
                    BEGIN
                    SELECT @To_Branch_account=branch_account_number
                        FROM branches
                        WHERE code=@To_Branch
                    UPDATE currentAccountProductHoldings
                        SET balance = @amount + balance
                        WHERE current_account_contract_code=@To_Branch_account
                    UPDATE currentAccountProductHoldings
                        SET balance =  balance-@amount
                        WHERE current_account_contract_code=@From_Branch_account
                    END
                END
            ELSE
                BEGIN
                SELECT -1 AS ret --(Balance is less than amount to be withdrawn and account does not have OD facility)
                RETURN
                END
            END
        END
    END
    COMMIT TRANSACTION
    SELECT @from_account_balance = balance FROM currentAccountProductHoldings
                        WHERE current_account_contract_code=@from_account
                        
    SELECT @to_account_balance = balance FROM currentAccountProductHoldings
                        WHERE current_account_contract_code=@to_account
    
    INSERT INTO [Test].[dbo].[CurrentAccountTransactions]
           ([from_account]
           ,[to_account]
           ,[amount]
           ,[transaction_date]
           ,[transaction_mode]
           ,[transaction_type]
           ,[transaction_fees]
           ,[maker]
           ,[checker]
           ,[purpose_of_transfer]
           ,[from_account_balance]
           ,[to_account_balance])
     VALUES
           (@from_account,
           @to_account,
           @amount,
           @transaction_date,
           @transaction_mode,
           @transaction_type,
           @transaction_fees,
           @maker,
           @checker,
           @purpose_of_transfer,
           @from_account_balance,
           @to_account_balance)
    
SELECT SCOPE_IDENTITY() AS ret
GO
/****** Object:  Table [dbo].[AdvancedFields]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvancedFields](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[entity_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[desc] [nvarchar](1000) NOT NULL,
	[is_mandatory] [bit] NOT NULL,
	[is_unique] [bit] NOT NULL,
 CONSTRAINT [PK_AdvancedFields] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Corporates]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corporates](
	[id] [int] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[deleted] [bit] NOT NULL,
	[sigle] [nvarchar](50) NULL,
	[small_name] [nvarchar](50) NULL,
	[volunteer_count] [int] NULL,
	[agrement_date] [datetime] NULL,
	[agrement_solidarity] [bit] NULL,
	[employee_count] [int] NULL,
	[siret] [nvarchar](50) NULL,
	[activity_id] [int] NULL,
	[date_create] [datetime] NULL,
	[fiscal_status] [nvarchar](50) NULL,
	[registre] [nvarchar](50) NULL,
	[legalForm] [nvarchar](50) NULL,
	[insertionType] [nvarchar](50) NULL,
	[loan_officer_id] [int] NULL,
 CONSTRAINT [PK_BODYCORPORATE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomFieldsValues]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomFieldsValues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[field_id] [int] NULL,
	[owner_id] [int] NOT NULL,
	[value] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[DebitFeeTransaction]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[DebitFeeTransaction]
    ( @transaction_mode NVARCHAR(50), 
    @transaction_type NVARCHAR(50),
        @to_account NVARCHAR(50), 
        @from_account NVARCHAR(50), 
        @amount money ,
        @transaction_date date,
        @transaction_fees money,
        @maker NVARCHAR(50), 
        @checker NVARCHAR(50), 
        @purpose_of_transfer NVARCHAR(MAX)
        
        
        )
            AS
    BEGIN
    DECLARE
        @From_Branch NVARCHAR(50),
        @To_Branch NVARCHAR(50),
        @current_account_contract_code NVARCHAR(50),
        @branch_account_number NVARCHAR(50),
        @From_Branch_account NVARCHAR(50),
        @To_Branch_account NVARCHAR(50),
        @from_account_balance money,
        @to_account_balance money

BEGIN TRANSACTION T1
				UPDATE currentAccountProductHoldings
                    SET balance= @amount + balance
                    WHERE current_account_contract_code=@to_account
                UPDATE currentAccountProductHoldings
                    SET balance=  balance-@amount
				WHERE current_account_contract_code=@from_account
COMMIT TRANSACTION T1

SELECT @from_account_balance = balance FROM currentAccountProductHoldings
                        WHERE current_account_contract_code=@from_account
                        
    SELECT @to_account_balance = balance FROM currentAccountProductHoldings
                        WHERE current_account_contract_code=@to_account
    
    INSERT INTO [Test].[dbo].[CurrentAccountTransactions]
           ([from_account]
           ,[to_account]
           ,[amount]
           ,[transaction_date]
           ,[transaction_mode]
           ,[transaction_type]
           ,[transaction_fees]
           ,[maker]
           ,[checker]
           ,[purpose_of_transfer]
           ,[from_account_balance]
           ,[to_account_balance])
     VALUES
           (@from_account,
           @to_account,
           @amount,
           @transaction_date,
           @transaction_mode,
           @transaction_type,
           @transaction_fees,
           @maker,
           @checker,
           @purpose_of_transfer,
           @from_account_balance,
           @to_account_balance)
           
           
           
           END
           SELECT SCOPE_IDENTITY() AS ret
GO
/****** Object:  Table [dbo].[CollateralProperties]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollateralProperties](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[desc] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_CollateralProperties] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChartOfAccounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[account_number] [nvarchar](50) NOT NULL,
	[label] [nvarchar](200) NOT NULL,
	[debit_plus] [bit] NOT NULL,
	[type_code] [varchar](60) NOT NULL,
	[account_category_id] [smallint] NOT NULL,
	[type] [bit] NOT NULL,
	[parent_account_id] [int] NULL,
	[lft] [int] NOT NULL,
	[rgt] [int] NOT NULL,
 CONSTRAINT [PK_ChartOfAccounts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UK_ChartOfAccounts] UNIQUE NONCLUSTERED 
(
	[account_number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[City]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[name] [nvarchar](100) NOT NULL,
	[district_id] [int] NOT NULL,
	[deleted] [bit] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CollateralPropertyCollections]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollateralPropertyCollections](
	[property_id] [int] NOT NULL,
	[value] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdvancedFieldsValues]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvancedFieldsValues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[entity_field_id] [int] NOT NULL,
	[field_id] [int] NOT NULL,
	[value] [nvarchar](300) NULL,
 CONSTRAINT [PK_AdvancedFieldsValues] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdvancedFieldsCollections]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvancedFieldsCollections](
	[field_id] [int] NOT NULL,
	[value] [nvarchar](100) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountingRules]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountingRules](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rule_type] [char](1) NOT NULL,
	[deleted] [bit] NOT NULL,
	[booking_direction] [smallint] NOT NULL,
	[event_type] [nvarchar](4) NOT NULL,
	[event_attribute_id] [int] NOT NULL,
	[debit_account_number_id] [int] NOT NULL,
	[credit_account_number_id] [int] NOT NULL,
	[order] [int] NOT NULL,
	[description] [nvarchar](256) NULL,
 CONSTRAINT [PK_AccountingRules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoanAccountingMovements]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanAccountingMovements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contract_id] [int] NOT NULL,
	[debit_account_number_id] [int] NOT NULL,
	[credit_account_number_id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[event_id] [int] NOT NULL,
	[transaction_date] [datetime] NOT NULL,
	[export_date] [datetime] NULL,
	[is_exported] [bit] NOT NULL,
	[currency_id] [int] NOT NULL,
	[exchange_rate] [float] NOT NULL,
	[rule_id] [int] NULL,
	[branch_id] [int] NOT NULL,
	[closure_id] [int] NULL,
	[fiscal_year_id] [int] NULL,
	[booking_type] [int] NOT NULL,
 CONSTRAINT [PK_LoanAccountingMovements] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LinkBranchesPaymentMethods]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LinkBranchesPaymentMethods](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[branch_id] [int] NOT NULL,
	[payment_method_id] [int] NOT NULL,
	[deleted] [bit] NOT NULL,
	[date] [datetime] NULL,
	[account_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManualAccountingMovements]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManualAccountingMovements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[debit_account_number_id] [int] NOT NULL,
	[credit_account_number_id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[transaction_date] [datetime] NOT NULL,
	[export_date] [datetime] NULL,
	[is_exported] [bit] NOT NULL,
	[currency_id] [int] NOT NULL,
	[exchange_rate] [float] NOT NULL,
	[description] [nvarchar](500) NULL,
	[user_id] [int] NOT NULL,
	[event_id] [int] NULL,
	[branch_id] [int] NOT NULL,
	[closure_id] [int] NULL,
	[fiscal_year_id] [int] NULL,
	[maker_id] [nvarchar](50) NULL,
	[checker_id] [nvarchar](50) NULL,
	[type_of_transaction] [nvarchar](50) NULL,
 CONSTRAINT [PK_ManualAccountingMovements] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[MakeFDTransaction]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakeFDTransaction] (@transaction_mode nvarchar(50),
@transaction_type nvarchar(50),
@to_account nvarchar(50),
@from_account nvarchar(50),
@amount money,
@transaction_date date,
@transaction_fees money,
@maker nvarchar(50),
@checker nvarchar(50),
@purpose_of_transfer nvarchar(max))
AS
BEGIN
  DECLARE @From_Branch nvarchar(50),
          @To_Branch nvarchar(50),
          @current_account_contract_code nvarchar(50),
          @branch_account_number nvarchar(50),
          @From_Branch_account nvarchar(50),
          @To_Branch_account nvarchar(50),
          @from_account_balance money,
          @to_account_balance money


    IF @transaction_mode = 'Debit'
    BEGIN
      IF @transaction_type = 'Cash' OR @transaction_type = 'Cheque'
      BEGIN
        SELECT
          @From_Branch = SUBSTRING(@from_account, 1, CHARINDEX('/', @from_account, 1) - 1)
        SELECT
          @From_Branch_account = branch_account_number
        FROM branches
        WHERE code = @From_Branch
        UPDATE currentAccountProductHoldings
        SET balance = balance - @amount
        WHERE current_account_contract_code = @From_Branch_account
        
        SET @from_account_balance = 0 
        
      END

      IF @transaction_type = 'Transfer'
      BEGIN
        SELECT
          @To_Branch = SUBSTRING(@to_account, 1, CHARINDEX('/', @to_account, 1) - 1)
        SELECT
          @To_Branch_account = branch_account_number
        FROM branches
        WHERE code = @To_Branch
        
        UPDATE CurrentAccountProductHoldings
        SET Balance = Balance + @amount
        WHERE current_account_contract_code = @To_Account
        
        SET @from_account_balance = 0 
        
        SELECT @to_account_balance = Balance FROM CurrentAccountProductHoldings
        WHERE current_account_contract_code = @to_account
        
        
        IF @From_Branch <> @To_Branch
        BEGIN
          UPDATE CurrentAccountProductHoldings
          SET Balance = Balance + @amount
          WHERE current_account_contract_code = @To_Branch_Account
          UPDATE CurrentAccountProductHoldings
          SET Balance = Balance - @amount
          WHERE current_account_contract_code = @From_Branch_Account
        END
      END
    END


    IF @transaction_mode = 'Credit'
    BEGIN
      --Extracting To_Branch
      SELECT
        @To_Branch = SUBSTRING(@to_account, 1, CHARINDEX('/', @to_account, 1) - 1)
    SELECT
      @To_Branch_account = branch_account_number
    FROM branches
    WHERE code = @To_Branch
    
      IF @transaction_type = 'Cash' OR @transaction_type = 'Cheque'
      BEGIN
        UPDATE FixedDepositProductHoldings
        SET Initial_Amount = @amount
        WHERE fixed_deposit_contract_code = @to_account
        UPDATE currentAccountProductHoldings
        SET balance = @amount + balance
        WHERE current_account_contract_code = @To_Branch_account
        
        SELECT @to_account_balance = initial_amount FROM FixedDepositProductHoldings
        WHERE fixed_deposit_contract_code = @to_account
      END
      IF @transaction_type = 'Transfer'
      BEGIN
        IF ((SELECT
            balance
          FROM currentAccountProductHoldings
          WHERE current_account_contract_code = @from_account)
          >= @amount)
          OR ((SELECT
            balance
          FROM currentAccountProductHoldings
          WHERE current_account_contract_code = @from_account)
          <= @amount
          AND (SELECT
            overdraft_applied
          FROM currentAccountProductHoldings
          WHERE current_account_contract_code = @from_account)
          = 1
          AND @amount <= (SELECT
            overdraft_limit + balance
          FROM currentAccountProductHoldings
          WHERE current_account_contract_code = @from_account
          AND balance > 0)
          )

          OR (@amount <= (SELECT
            overdraft_limit
          FROM currentAccountProductHoldings
          WHERE current_account_contract_code = @from_account
          AND balance < 0)
          )

        BEGIN

          IF (SELECT
              balance
            FROM currentAccountProductHoldings
            WHERE current_account_contract_code = @from_account)
            < @amount
          BEGIN
            IF (SELECT
                balance
              FROM currentAccountProductHoldings
              WHERE current_account_contract_code = @from_account)
              > 0
            BEGIN
              UPDATE currentAccountProductHoldings
              SET overdraft_limit = overdraft_limit - @amount + balance
              WHERE current_account_contract_code = @from_account
            END

            IF (SELECT
                balance
              FROM currentAccountProductHoldings
              WHERE current_account_contract_code = @from_account)
              <= 0
            BEGIN
              UPDATE currentAccountProductHoldings
              SET overdraft_limit = overdraft_limit - @amount
              WHERE current_account_contract_code = @from_account
            END

          END

          UPDATE FixedDepositProductHoldings
          SET initial_amount = @amount
          WHERE fixed_deposit_contract_code = @to_account
          UPDATE currentAccountProductHoldings
          SET balance = balance - @amount
          WHERE current_account_contract_code = @from_account

		  SELECT @from_account_balance = balance FROM currentAccountProductHoldings
                        WHERE current_account_contract_code=@from_account
                        
		  SELECT @to_account_balance = initial_amount FROM FixedDepositProductHoldings
                        WHERE fixed_deposit_contract_code = @to_account
		 

          --Extracting From_Branch
          SELECT
            @From_Branch = SUBSTRING(@from_account, 1, CHARINDEX('/', @from_account, 1) - 1)
          IF @From_Branch <> @To_Branch
          BEGIN
            SELECT
              @From_Branch_account = branch_account_number
            FROM branches
            WHERE code = @From_Branch
            UPDATE currentAccountProductHoldings
            SET balance = @amount + balance
            WHERE current_account_contract_code = @To_Branch_account
            UPDATE currentAccountProductHoldings
            SET balance = balance - @amount
            WHERE current_account_contract_code = @From_Branch_account
          END
        END
        ELSE
        BEGIN
          SELECT
            -1 AS ret --(Balance is less than amount to be withdrawn and account does not have OD facility)
          RETURN
        END
      END
    END
  END
	
    
    INSERT INTO [Test].[dbo].[CurrentAccountTransactions]
           ([from_account]
           ,[to_account]
           ,[amount]
           ,[transaction_date]
           ,[transaction_mode]
           ,[transaction_type]
           ,[transaction_fees]
           ,[maker]
           ,[checker]
           ,[purpose_of_transfer]
           ,[from_account_balance]
           ,[to_account_balance])
     VALUES
           (@from_account,
           @to_account,
           @amount,
           @transaction_date,
           @transaction_mode,
           @transaction_type,
           @transaction_fees,
           @maker,
           @checker,
           @purpose_of_transfer,
           @from_account_balance,
           @to_account_balance)
    
SELECT SCOPE_IDENTITY() AS ret
GO
/****** Object:  Table [dbo].[EntryFees]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntryFees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_product] [int] NOT NULL,
	[name_of_fee] [nvarchar](100) NOT NULL,
	[min] [decimal](18, 4) NULL,
	[max] [decimal](18, 4) NULL,
	[value] [decimal](18, 4) NULL,
	[rate] [bit] NULL,
	[is_deleted] [bit] NOT NULL,
	[fee_index] [int] NOT NULL,
	[cycle_id] [int] NULL,
 CONSTRAINT [PK_EntryFees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundingLineEvents]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundingLineEvents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](200) NOT NULL,
	[amount] [money] NOT NULL,
	[direction] [smallint] NOT NULL,
	[fundingline_id] [int] NOT NULL,
	[deleted] [bit] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[type] [smallint] NOT NULL,
	[user_id] [int] NULL,
	[contract_event_id] [int] NULL,
 CONSTRAINT [PK_EVENTFUNDINGLINE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[GetChartOfAccountNumber]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetChartOfAccountNumber]
(
	@name varchar (55)
)
RETURNS VARCHAR(20)
AS
	
BEGIN
	DECLARE @account VARCHAR(20);
	SELECT @account =  c.account_number FROM ChartOfAccounts c INNER JOIN AccountsCategory a
	ON c.account_category_id=a.id AND a.name=@name
	RETURN @account
END
GO
/****** Object:  StoredProcedure [dbo].[GetChartOfAccount]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetChartOfAccount]
(
@name varchar (55)
)
AS
SET NOCOUNT OFF;
BEGIN
SELECT c.account_number FROM ChartOfAccounts c INNER JOIN AccountsCategory a
ON c.account_category_id=a.id AND a.name=@name
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetAccountChilds]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetAccountChilds] ( @account_id INT )
RETURNS @result TABLE(
      id INT ,
      account_number CHAR(50) ,
      parent_account_id INT)
AS 
    BEGIN
        DECLARE @r INT
        DECLARE @i INT
        DECLARE @id INT
        DECLARE @tbl_temp 
          TABLE (
              i INT IDENTITY ,
              id INT ,
              account_number CHAR(50) ,
              parent_account_id INT)
        SET @i = 1
        INSERT  INTO @tbl_temp
        SELECT  
          id ,
          account_number ,
          parent_account_id
        FROM dbo.ChartOfAccounts
        SET @r = @@ROWCOUNT
        WHILE ( @i < = @r ) 
            BEGIN
                SELECT  @id = id
                FROM    @tbl_temp
                WHERE   i = @i
                INSERT  INTO @result
                SELECT  
                  id ,
                  account_number ,
                  parent_account_id
                FROM    @tbl_temp
                WHERE   id = @id
                  AND parent_account_id = @account_id 
                  
                IF @@ROWCOUNT > 0 
                    BEGIN
                        INSERT  INTO @result
                        SELECT  *
                        FROM    GetAccountChilds(@id)
                    END
                SET @i = @i + 1
            END       
        RETURN
    END
GO
/****** Object:  Table [dbo].[Tiers]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tiers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_type_code] [char](1) NOT NULL,
	[scoring] [float] NULL,
	[loan_cycle] [int] NOT NULL,
	[active] [bit] NOT NULL,
	[bad_client] [bit] NOT NULL,
	[other_org_name] [nvarchar](100) NULL,
	[other_org_amount] [money] NULL,
	[other_org_debts] [money] NULL,
	[district_id] [int] NOT NULL,
	[city] [nvarchar](50) NULL,
	[address] [nvarchar](500) NULL,
	[secondary_district_id] [int] NULL,
	[secondary_city] [nvarchar](50) NULL,
	[secondary_address] [nvarchar](500) NULL,
	[cash_input_voucher_number] [int] NULL,
	[cash_output_voucher_number] [int] NULL,
	[creation_date] [datetime] NULL,
	[home_phone] [varchar](50) NULL,
	[personal_phone] [varchar](50) NULL,
	[secondary_home_phone] [varchar](50) NULL,
	[secondary_personal_phone] [varchar](50) NULL,
	[e_mail] [nvarchar](50) NULL,
	[secondary_e_mail] [nvarchar](50) NULL,
	[status] [smallint] NOT NULL,
	[other_org_comment] [nvarchar](500) NULL,
	[sponsor1] [nvarchar](50) NULL,
	[sponsor1_comment] [nvarchar](100) NULL,
	[sponsor2] [nvarchar](50) NULL,
	[sponsor2_comment] [nvarchar](100) NULL,
	[follow_up_comment] [nvarchar](500) NULL,
	[home_type] [nvarchar](50) NULL,
	[secondary_homeType] [nvarchar](50) NULL,
	[zipCode] [nvarchar](50) NULL,
	[secondary_zipCode] [nvarchar](50) NULL,
	[branch_id] [int] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SavingsAccountingMovements]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavingsAccountingMovements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contract_id] [int] NOT NULL,
	[debit_account_number_id] [int] NOT NULL,
	[credit_account_number_id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[event_id] [int] NOT NULL,
	[transaction_date] [datetime] NOT NULL,
	[export_date] [datetime] NULL,
	[is_exported] [bit] NOT NULL,
	[currency_id] [int] NOT NULL,
	[exchange_rate] [float] NOT NULL,
	[rule_id] [int] NULL,
	[branch_id] [int] NOT NULL,
	[closure_id] [int] NULL,
	[fiscal_year_id] [int] NULL,
 CONSTRAINT [PK_SavingsAccountingMovements] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavingBookProducts]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavingBookProducts](
	[id] [int] NOT NULL,
	[interest_base] [smallint] NOT NULL,
	[interest_frequency] [smallint] NOT NULL,
	[calcul_amount_base] [smallint] NULL,
	[withdraw_fees_type] [smallint] NOT NULL,
	[flat_withdraw_fees_min] [money] NULL,
	[flat_withdraw_fees_max] [money] NULL,
	[flat_withdraw_fees] [money] NULL,
	[rate_withdraw_fees_min] [float] NULL,
	[rate_withdraw_fees_max] [float] NULL,
	[rate_withdraw_fees] [float] NULL,
	[transfer_fees_type] [smallint] NOT NULL,
	[flat_transfer_fees_min] [money] NULL,
	[flat_transfer_fees_max] [money] NULL,
	[flat_transfer_fees] [money] NULL,
	[rate_transfer_fees_min] [float] NULL,
	[rate_transfer_fees_max] [float] NULL,
	[rate_transfer_fees] [float] NULL,
	[deposit_fees] [money] NULL,
	[deposit_fees_max] [money] NULL,
	[deposit_fees_min] [money] NULL,
	[close_fees] [money] NULL,
	[close_fees_max] [money] NULL,
	[close_fees_min] [money] NULL,
	[management_fees] [money] NULL,
	[management_fees_max] [money] NULL,
	[management_fees_min] [money] NULL,
	[management_fees_freq] [int] NOT NULL,
	[overdraft_fees] [money] NULL,
	[overdraft_fees_max] [money] NULL,
	[overdraft_fees_min] [money] NULL,
	[agio_fees] [float] NULL,
	[agio_fees_max] [float] NULL,
	[agio_fees_min] [float] NULL,
	[agio_fees_freq] [int] NOT NULL,
	[cheque_deposit_min] [money] NULL,
	[cheque_deposit_max] [money] NULL,
	[cheque_deposit_fees] [money] NULL,
	[cheque_deposit_fees_min] [money] NULL,
	[cheque_deposit_fees_max] [money] NULL,
	[reopen_fees] [money] NULL,
	[reopen_fees_min] [money] NULL,
	[reopen_fees_max] [money] NULL,
	[is_ibt_fee_flat] [bit] NOT NULL,
	[ibt_fee_min] [money] NULL,
	[ibt_fee_max] [money] NULL,
	[ibt_fee] [money] NULL,
	[use_term_deposit] [bit] NOT NULL,
	[term_deposit_period_min] [int] NULL,
	[term_deposit_period_max] [int] NULL,
	[posting_frequency] [int] NULL,
 CONSTRAINT [PK_SavingBookProducts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StandardBookings]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StandardBookings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](128) NULL,
	[debit_account_id] [int] NOT NULL,
	[credit_account_id] [int] NOT NULL,
 CONSTRAINT [PK_StandardBookings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [inx_uniq_StandardBooking] UNIQUE NONCLUSTERED 
(
	[Name] ASC,
	[debit_account_id] ASC,
	[credit_account_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VillagesPersons]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VillagesPersons](
	[village_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[joined_date] [datetime] NOT NULL,
	[left_date] [datetime] NULL,
	[is_leader] [bit] NOT NULL,
	[currently_in] [bit] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_VillagesPersons] PRIMARY KEY CLUSTERED 
(
	[village_id] ASC,
	[person_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VillagesAttendance]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VillagesAttendance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[village_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[attended] [bit] NOT NULL,
	[comment] [nvarchar](1000) NULL,
	[loan_id] [int] NOT NULL,
 CONSTRAINT [PK_VillagesAttendance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TermDepositProducts]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TermDepositProducts](
	[id] [int] NOT NULL,
	[installment_types_id] [int] NOT NULL,
	[number_period] [int] NULL,
	[number_period_min] [int] NULL,
	[number_period_max] [int] NULL,
	[interest_frequency] [smallint] NOT NULL,
	[withdrawal_fees_type] [smallint] NOT NULL,
	[withdrawal_fees_min] [float] NULL,
	[withdrawal_fees_max] [float] NULL,
	[withdrawal_fees] [float] NULL,
 CONSTRAINT [PK_TermDepositProducts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tellers]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tellers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[desc] [nvarchar](100) NULL,
	[account_id] [int] NOT NULL,
	[deleted] [bit] NOT NULL,
	[branch_id] [int] NOT NULL,
	[currency_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[amount_min] [money] NULL,
	[amount_max] [money] NULL,
	[deposit_amount_min] [money] NULL,
	[deposit_amount_max] [money] NULL,
	[withdrawal_amount_min] [money] NULL,
	[withdrawal_amount_max] [money] NULL,
 CONSTRAINT [PK_Tellers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TellerEvents]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TellerEvents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[teller_id] [int] NOT NULL,
	[event_code] [nchar](4) NOT NULL,
	[amount] [money] NOT NULL,
	[date] [datetime] NOT NULL,
	[is_exported] [bit] NOT NULL,
	[description] [nvarchar](100) NULL,
 CONSTRAINT [PK_TellerEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCounterBalance]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCounterBalance](
@allocaterId INT,
@branch nvarchar(100),
@cashierId INT,
@counterId INT,
@allocationDate datetime,
@amount money,
@type nvarchar(100)
)
AS
DECLARE @Liabilities nvarchar(100);
BEGIN

If @type = 'Opening Amount' OR @type = 'TopUp Amount' 
BEGIN
--Debit the amount from COA
UPDATE [CurrentAccountProductHoldings]
Set Balance = Balance - @amount  Where current_account_contract_code = dbo.GetChartOfAccountNumber('BalanceSheetLiabilities')
--Insert the record into CounterBalance record
INSERT INTO [CounterBalance]
(
[allocater_id],
[branch],
[cashier_id],
[counter_id],
[allocation_date],
[amount],
[type])

VALUES
(
@allocaterId,
@branch,
@cashierId,
@counterId,
@allocationDate,
@amount,
@type)
END
If @type = 'Closing Amount' 
BEGIN
--Credit the amount into COA
UPDATE [CurrentAccountProductHoldings] Set Balance = Balance + @amount 
Where current_account_contract_code = dbo.GetChartOfAccountNumber('BalanceSheetLiabilities')
--Insert the record into CounterBalance record
INSERT INTO [CounterBalance]
(
[allocater_id],
[branch],
[cashier_id],
[counter_id],
[allocation_date],
[amount],
[type])

VALUES
(
@allocaterId,
@branch,
@cashierId,
@counterId,
@allocationDate,
@amount,
@type)
END

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateChartOfAccounts]
(@TransactionType varchar(50), @TransactionMode varchar(50), @amount Money)

AS
	DECLARE @accountNumber varchar(50);
	DECLARE @profitAndLossIncome varchar(50);
	DECLARE @balanceSheetLiabilities varchar(50);
BEGIN
SET @profitAndLossIncome='ProfitAndLossIncome'--hardcode it the way you want
SET @balanceSheetLiabilities='BalanceSheetLiabilities'--same as above
IF @TransactionMode='Debit'
BEGIN
	IF @TransactionType='Interest' OR @TransactionType='Fee'
	BEGIN
		SELECT @accountNumber =  [dbo].[GetChartOfAccountNumber](@profitAndLossIncome)
		UPDATE CurrentAccountProductHoldings SET Balance = Balance + @amount where [current_account_contract_code] = @accountNumber
	END
END

IF @TransactionMode='Credit'
BEGIN
	IF @TransactionType='Interest' 
	BEGIN
		SELECT @accountNumber = [dbo].[GetChartOfAccountNumber](@profitAndLossIncome)
		UPDATE CurrentAccountProductHoldings SET Balance = Balance - @amount where [current_account_contract_code] = @accountNumber
	END
END
IF @TransactionType='Cash' 
BEGIN
	IF @TransactionMode='Credit'
	BEGIN
		SELECT @accountNumber = [dbo].[GetChartOfAccountNumber](@balanceSheetLiabilities)
		UPDATE CurrentAccountProductHoldings SET Balance = Balance + @amount where [current_account_contract_code] = @accountNumber
	END
	IF @TransactionMode='Debit'
	BEGIN
			SELECT @accountNumber = [dbo].[GetChartOfAccountNumber](@balanceSheetLiabilities)
			UPDATE CurrentAccountProductHoldings SET Balance = Balance - @amount where [current_account_contract_code] = @accountNumber
	END
END

END
GO
/****** Object:  Table [dbo].[SavingContracts]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavingContracts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[tiers_id] [int] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[interest_rate] [float] NOT NULL,
	[status] [smallint] NOT NULL,
	[closed_date] [datetime] NULL,
	[savings_officer_id] [int] NOT NULL,
	[initial_amount] [money] NOT NULL,
	[entry_fees] [money] NOT NULL,
	[nsg_id] [int] NULL,
 CONSTRAINT [PK_SavingContracts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[establishment_date] [datetime] NULL,
	[comments] [nvarchar](500) NULL,
	[meeting_day] [int] NULL,
	[loan_officer_id] [int] NULL,
 CONSTRAINT [PK_ClientGroups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetChartOfAccountsBalances]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetChartOfAccountsBalances](
  @contract_id INT)
AS
BEGIN
    -- EXEC GetChartOfAccountsBalances 0
    CREATE TABLE #GAChart(
      account_number_id INT,
      account_number NVARCHAR(100),
      debit money,
      credit money,
      label NVARCHAR(250),
      currency_id int)
    
    INSERT INTO #GAChart(account_number_id, account_number, debit, label, currency_id)  
	SELECT
	  chart.id,
	  chart.account_number,
	  SUM(amount) AS debit,
	  chart.label,
	  cab.currency_id
	FROM ChartOfAccounts chart
	LEFT JOIN LoanAccountingMovements cab ON chart.id = cab.debit_account_number_id
	WHERE (contract_id = @contract_id OR @contract_id = 0) 
	GROUP BY chart.id, chart.account_number, chart.label, cab.currency_id
	SELECT
	  chart.id AS account_number_id,
	  SUM(amount) AS credit,
	  cab.currency_id
	INTO #Credit
	FROM ChartOfAccounts chart
	LEFT JOIN LoanAccountingMovements cab ON chart.id = cab.credit_account_number_id
	WHERE (contract_id = @contract_id OR @contract_id = 0)
	GROUP BY chart.id, cab.currency_id
	UPDATE #GAChart
	SET #GAChart.credit = #Credit.credit
	FROM #credit
	WHERE #GAChart.account_number_id = #credit.account_number_id 
	  AND #GAChart.currency_id = #credit.currency_id 
	SELECT 
	  account_number,                                     
	  debit,                 
	  credit,
	  currency_id,                
	  label
	FROM #GAChart
	ORDER BY account_number, currency_id
	DROP TABLE #GAChart
	DROP TABLE #Credit
END
GO
/****** Object:  StoredProcedure [dbo].[GetAccountBalance]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAccountBalance](
      @account_number_id INT,
      @currency_id INT,
      @contract_id INT,
      @mode BIT,
      @to_sum_parent BIT = 0,
      @date DATETIME = NULL,
      @branch_id INT)
AS 
    BEGIN
        SET NOCOUNT ON
        DECLARE @balance MONEY
        DECLARE @id INT
        DECLARE @debit_plus BIT
        
        SET @balance = 0
        
        SELECT @debit_plus = debit_plus
        FROM dbo.ChartOfAccounts
        WHERE id = @account_number_id
        
        CREATE TABLE #Accounts(
              account_number_id INT ,
              is_parent BIT)
    
        IF(@to_sum_parent = 1)
        BEGIN
          -- populate table with accouts by parent id
          INSERT  INTO #Accounts ( account_number_id, is_parent )
          SELECT  id, @to_sum_parent
          FROM  dbo.GetAccountChilds (@account_number_id) 
          
          INSERT  INTO #Accounts ( account_number_id, is_parent )
          SELECT  @account_number_id, @to_sum_parent
        END
        ELSE
        BEGIN
          INSERT  INTO #Accounts ( account_number_id, is_parent )
          SELECT @account_number_id, @to_sum_parent
        END
 
        IF @mode = 0 OR @mode IS NULL 
            BEGIN
                DECLARE @debit_loan MONEY
                DECLARE @credit_loan MONEY
                
                DECLARE BalanceCursor CURSOR
                FOR SELECT  account_number_id
                FROM    #Accounts       
  
                OPEN BalanceCursor
                FETCH NEXT FROM BalanceCursor INTO @id
                WHILE @@FETCH_STATUS = 0 
                    BEGIN
                        SELECT  @debit_loan = CASE WHEN @currency_id = 0
                                                   THEN SUM(ISNULL(amount, 0) / ISNULL(exchange_rate, 1))
                                                   ELSE SUM(ISNULL(amount, 0))
                                              END
                        FROM    LoanAccountingMovements
                        WHERE   debit_account_number_id = @id
                                AND ( currency_id = @currency_id OR @currency_id = 0)
                                AND ( branch_id = @branch_id OR @branch_id = 0)
                                AND ( contract_id = @contract_id OR @contract_id = 0)
                                AND (transaction_date <= @date OR @date IS NULL)
                                AND closure_id > 0
		  
                        SELECT  @credit_loan = CASE WHEN @currency_id = 0
                                                    THEN SUM(ISNULL(amount, 0) / ISNULL(exchange_rate, 1))
                                                    ELSE SUM(ISNULL(amount, 0))
                                               END
                        FROM    LoanAccountingMovements
                        WHERE   credit_account_number_id = @id
                                AND ( currency_id = @currency_id OR @currency_id = 0)
                                AND ( branch_id = @branch_id OR @branch_id = 0)
                                AND ( contract_id = @contract_id OR @contract_id = 0) 
		                        AND (transaction_date <= @date OR @date IS NULL)
		                        AND closure_id > 0
		                
		                IF @debit_plus = 1        
                           SET @balance = @balance + ISNULL(@debit_loan, 0) - ISNULL(@credit_loan, 0)
                        ELSE 
		                   SET @balance = @balance + ISNULL(@credit_loan, 0) - ISNULL(@debit_loan, 0)
		                           
                        FETCH NEXT FROM BalanceCursor INTO @id
                    END
                CLOSE BalanceCursor
                DEALLOCATE BalanceCursor
            END
	
        IF @mode = 1 OR @mode IS NULL 
            BEGIN  
                DECLARE @debit_saving MONEY
                DECLARE @credit_saving MONEY
	            
                DECLARE BalanceCursor CURSOR
                FOR SELECT  account_number_id
                FROM    #Accounts       
  
                OPEN BalanceCursor
 FETCH NEXT FROM BalanceCursor INTO @id
                WHILE @@FETCH_STATUS = 0 
                    BEGIN
                        SELECT  @debit_saving = CASE WHEN @currency_id = 0
                 THEN SUM(ISNULL(amount, 0) / ISNULL(exchange_rate, 1))
                                                     ELSE SUM(ISNULL(amount, 0))
                                                END
                        FROM  dbo.SavingsAccountingMovements
                        WHERE   debit_account_number_id = @id
                                AND ( currency_id = @currency_id OR @currency_id = 0)
                                AND ( branch_id = @branch_id OR @branch_id = 0)
                                AND ( contract_id = @contract_id OR @contract_id = 0) 
		                        AND (transaction_date <= @date OR @date IS NULL)
		                        AND closure_id > 0
		                        
                        SELECT  @credit_saving = CASE WHEN @currency_id = 0
                                                      THEN SUM(ISNULL(amount, 0) / ISNULL(exchange_rate, 1))
                                                      ELSE SUM(ISNULL(amount, 0))
                                                 END
                        FROM    SavingsAccountingMovements
                        WHERE   credit_account_number_id = @id
                                AND ( currency_id = @currency_id OR @currency_id = 0)
                                AND ( branch_id = @branch_id OR @branch_id = 0)
                                AND ( contract_id = @contract_id OR @contract_id = 0)
		                        AND (transaction_date <= @date OR @date IS NULL)
		                        AND closure_id > 0
		                
		                IF @debit_plus = 1        
                          SET @balance = ISNULL(@balance, 0) + ISNULL(@debit_saving, 0) - ISNULL(@credit_saving, 0)
                        ELSE
                          SET @balance = ISNULL(@balance, 0) + ISNULL(@credit_saving, 0) - ISNULL(@debit_saving, 0)
                    
                        FETCH NEXT FROM BalanceCursor INTO @id
                    END
                CLOSE BalanceCursor
                DEALLOCATE BalanceCursor
            END
	
        IF @mode IS NULL 
            BEGIN  
                DECLARE @debit_manualmvt MONEY
                DECLARE @credit_manualmvt MONEY
                DECLARE BalanceCursor CURSOR
                FOR SELECT  account_number_id
                FROM    #Accounts       
  
                OPEN BalanceCursor
                FETCH NEXT FROM BalanceCursor INTO @id
                WHILE @@FETCH_STATUS = 0 
                    BEGIN
                        SELECT  @debit_manualmvt = CASE WHEN @currency_id = 0
                                                        THEN SUM(ISNULL(amount, 0) / ISNULL(exchange_rate, 1))
                                                        ELSE SUM(ISNULL(amount, 0))
                                                   END
                        FROM    dbo.ManualAccountingMovements
                        WHERE   debit_account_number_id = @id
                                AND ( currency_id = @currency_id OR @currency_id = 0)
                                AND ( branch_id = @branch_id OR @branch_id = 0)
		                        AND (transaction_date <= @date OR @date IS NULL)
		                        AND closure_id > 0
		                        
                        SELECT  @credit_manualmvt = CASE WHEN @currency_id = 0
                                                         THEN SUM(ISNULL(amount, 0) / ISNULL(exchange_rate, 1))
                                                         ELSE SUM(ISNULL(amount, 0))
                                                    END
                        FROM    dbo.ManualAccountingMovements
                        WHERE   credit_account_number_id = @id
  AND ( currency_id = @currency_id OR @currency_id = 0)
                                AND ( branch_id = @branch_id OR @branch_id = 0)
		                        AND (transaction_date <= @date OR @date IS NULL)
		                        AND closure_id > 0
		                
		                IF @debit_plus = 1        
                          SET @balance = ISNULL(@balance, 0) + ISNULL(@debit_manualmvt, 0) - ISNULL(@credit_manualmvt, 0)
                        ELSE
                          SET @balance = ISNULL(@balance, 0) + ISNULL(@credit_manualmvt, 0) - ISNULL(@debit_manualmvt, 0)
                    
                        FETCH NEXT FROM BalanceCursor INTO @id
                    END
                CLOSE BalanceCursor
     DEALLOCATE BalanceCursor
            END
  
        SELECT  ISNULL(@balance, 0) AS balance
    END
GO
/****** Object:  StoredProcedure [dbo].[GetBalanceByAccountCategory]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBalanceByAccountCategory](
      @account_category_id INT,
      @currency_id INT ,
      @contract_id INT,
      @mode BIT)
AS 
    BEGIN
        CREATE TABLE #CategoriesBalance(
              category_id INT ,
              [name] NVARCHAR(100) ,
              amount MONEY)
              
        IF(@mode = 0 OR @mode IS NULL)
        BEGIN
        INSERT  INTO #CategoriesBalance ( category_id , name , amount)
                SELECT  AccountsCategory.id ,
                        AccountsCategory.name ,
                        CASE WHEN @currency_id = 0
                             THEN SUM(lam.amount) / ISNULL(exchange_rate, 1)
                             ELSE SUM(lam.amount)
                        END
                FROM    dbo.AccountsCategory
                        INNER JOIN ChartOfAccounts ON dbo.AccountsCategory.id = dbo.ChartOfAccounts.account_category_id
                        INNER JOIN dbo.LoanAccountingMovements lam ON dbo.ChartOfAccounts.id = lam.debit_account_number_id
                WHERE   
                  account_category_id = @account_category_id
                  AND ( currency_id = @currency_id OR @currency_id = 0)
                  AND ( contract_id = @contract_id OR @contract_id = 0)
                  AND closure_id > 0
                GROUP BY AccountsCategory.id ,
                        AccountsCategory.name, 
                        exchange_rate
  
        INSERT  INTO #CategoriesBalance ( category_id , name , amount)
                SELECT  AccountsCategory.id ,
                        AccountsCategory.name ,
                        CASE WHEN @currency_id = 0
                             THEN -1 * SUM(lam.amount) / ISNULL(exchange_rate, 1)
                             ELSE -1 * SUM(lam.amount)
                        END
                FROM    dbo.AccountsCategory
                        INNER JOIN ChartOfAccounts ON dbo.AccountsCategory.id = dbo.ChartOfAccounts.account_category_id
                        INNER JOIN dbo.LoanAccountingMovements lam ON dbo.ChartOfAccounts.id = lam.credit_account_number_id
                WHERE   account_category_id = @account_category_id
                        AND ( currency_id = @currency_id OR @currency_id = 0)
                        AND ( contract_id = @contract_id OR @contract_id = 0 )
                        AND closure_id > 0
                GROUP BY AccountsCategory.id ,
                        AccountsCategory.name,
                        exchange_rate
                ORDER BY AccountsCategory.id
        END
        IF(@mode = 1 OR @mode IS NULL)
        BEGIN
        INSERT  INTO #CategoriesBalance( category_id , name ,amount)
                SELECT  AccountsCategory.id ,
                        AccountsCategory.name ,
                        CASE WHEN @currency_id = 0
                             THEN SUM(sam.amount) / ISNULL(exchange_rate, 1)
                             ELSE SUM(sam.amount)
                        END
                FROM    dbo.AccountsCategory
                        INNER JOIN ChartOfAccounts ON dbo.AccountsCategory.id = dbo.ChartOfAccounts.account_category_id
                        INNER JOIN dbo.SavingsAccountingMovements sam ON dbo.ChartOfAccounts.id = sam.debit_account_number_id
                WHERE   account_category_id = @account_category_id
                        AND ( currency_id = @currency_id OR @currency_id = 0)
                        AND ( contract_id = @contract_id OR @contract_id = 0)
                        AND closure_id > 0
                GROUP BY AccountsCategory.id ,
                        AccountsCategory.name,
                        exchange_rate
                        
        INSERT  INTO #CategoriesBalance ( category_id , name , amount)
                SELECT  AccountsCategory.id ,
                        AccountsCategory.name ,
                        CASE WHEN @currency_id = 0
                             THEN -1 * SUM(sam.amount) / ISNULL(exchange_rate, 1)
    ELSE -1 * SUM(sam.amount)
                   END
                FROM    dbo.AccountsCategory
           INNER JOIN ChartOfAccounts ON dbo.AccountsCategory.id = dbo.ChartOfAccounts.account_category_id
                        INNER JOIN dbo.SavingsAccountingMovements sam ON dbo.ChartOfAccounts.id = sam.credit_account_number_id
                WHERE   
                  account_category_id = @account_category_id
                  AND ( currency_id = @currency_id OR @currency_id = 0)
                  AND ( contract_id = @contract_id OR @contract_id = 0)
                  AND closure_id > 0
                GROUP BY AccountsCategory.id ,
                        AccountsCategory.name,
                        exchange_rate
        END
        
        IF(@mode IS NULL)
        BEGIN
        INSERT  INTO #CategoriesBalance( category_id, name , amount)
                SELECT  AccountsCategory.id ,
                        AccountsCategory.name ,
                        CASE WHEN @currency_id = 0
                             THEN SUM(mam.amount) / ISNULL(exchange_rate, 1)
                             ELSE SUM(mam.amount)
                        END
                FROM    dbo.AccountsCategory
                        INNER JOIN ChartOfAccounts ON dbo.AccountsCategory.id = dbo.ChartOfAccounts.account_category_id
                        INNER JOIN dbo.ManualAccountingMovements mam ON dbo.ChartOfAccounts.id = mam.debit_account_number_id
                WHERE   account_category_id = @account_category_id
                  AND ( currency_id = @currency_id OR @currency_id = 0)
                  AND closure_id > 0
                GROUP BY AccountsCategory.id ,
                        AccountsCategory.name,
                        exchange_rate
                ORDER BY AccountsCategory.id
   
        INSERT  INTO #CategoriesBalance (category_id, name, amount)
                SELECT  AccountsCategory.id ,
                        AccountsCategory.name ,
                        CASE WHEN @currency_id = 0
                             THEN -1 * SUM(mam.amount) / ISNULL(exchange_rate, 1)
                             ELSE -1 * SUM(mam.amount)
                        END
                FROM    dbo.AccountsCategory
                        INNER JOIN ChartOfAccounts ON dbo.AccountsCategory.id = dbo.ChartOfAccounts.account_category_id
                        INNER JOIN dbo.ManualAccountingMovements mam ON dbo.ChartOfAccounts.id = mam.credit_account_number_id
                WHERE   account_category_id = @account_category_id
                  AND ( currency_id = @currency_id OR @currency_id = 0)
                  AND closure_id > 0
                GROUP BY AccountsCategory.id ,
                        AccountsCategory.name,
                        exchange_rate
                ORDER BY AccountsCategory.id
        END
         
        SELECT  ISNULL(SUM(amount), 0) AS balance
        FROM  #CategoriesBalance
        
        DROP TABLE #CategoriesBalance
    END
GO
/****** Object:  UserDefinedFunction [dbo].[GetAdvancedFieldValue]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a value of advanced customizable field
-- @id - loan_id, savings_id or tiers_id
-- @type - 'L', 'S' or 'C' (see @id accordingly)
-- @field_name - name of advanced field
-- HISTORY
--
-- Dec 26, 2011 - v3.5 - Ruslan KAZAKOV
CREATE FUNCTION [dbo].[GetAdvancedFieldValue]
    (
      @id INT ,
      @type CHAR(1) ,
      @field_name NVARCHAR(255)
    )
RETURNS NVARCHAR(255)
AS 
    BEGIN
        DECLARE @field_value NVARCHAR(255)
        DECLARE @field_id INT
        DECLARE @field_type INT
        
        SELECT  @field_id = id
        FROM    dbo.AdvancedFields
        WHERE   name = @field_name
        
        SELECT @field_type = [type_id] FROM dbo.AdvancedFields
		WHERE id = @field_id
        
        IF @field_type <> 5 
			SELECT  @field_value = value
			FROM    dbo.AdvancedFieldsValues
					INNER JOIN dbo.AdvancedFields ON dbo.AdvancedFieldsValues.field_id = dbo.AdvancedFields.id
					INNER JOIN dbo.AdvancedFieldsLinkEntities ON dbo.AdvancedFieldsLinkEntities.id = AdvancedFieldsValues.entity_field_id
			WHERE   dbo.AdvancedFields.name = @field_name
					AND link_type = @type
					AND link_id = @id
        ELSE
            SELECT  @field_value = Col.value
            FROM    dbo.AdvancedFieldsValues
                    INNER JOIN dbo.AdvancedFields ON dbo.AdvancedFieldsValues.field_id = dbo.AdvancedFields.id
                    INNER JOIN dbo.AdvancedFieldsLinkEntities ON dbo.AdvancedFieldsLinkEntities.id = AdvancedFieldsValues.entity_field_id
                    INNER JOIN ( SELECT value ,
                                        ( ROW_NUMBER() OVER ( ORDER BY id ) )
                                        - 1 AS id ,
                                        field_id
                                 FROM   dbo.AdvancedFieldsCollections
                                 WHERE  field_id = @field_id
                               ) Col ON Col.id = AdvancedFieldsValues.value
                                        AND Col.field_id = AdvancedFieldsValues.field_id
            WHERE   dbo.AdvancedFields.name = @field_name
                    AND link_type = @type
                    AND link_id = @id
                
            RETURN  @field_value
       
    END
GO
/****** Object:  UserDefinedFunction [dbo].[FilteredSavingsAccountingMovements]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FilteredSavingsAccountingMovements]
(
	@startDate        DATETIME,
	@endDate          DATETIME,
	@source_currency  INT,
	@contract_id      INT,
	@branch_id        INT,
	@isExported       BIT
)
RETURNS TABLE
AS
	RETURN 
(
    SELECT *
    FROM   dbo.SavingsAccountingMovements
    WHERE  (currency_id = @source_currency OR 0 = @source_currency)
           AND closure_id > 0
           AND (@isExported IS NULL OR is_exported = @isExported)
           AND (
                   @startDate IS NULL
                   OR CAST(FLOOR(CAST(@startDate AS FLOAT)) AS DATETIME) <= CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME)
               )
           AND (
                   CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME) <=
                   CAST(FLOOR(CAST(@endDate AS FLOAT)) AS DATETIME)
               )
           AND (0 = @contract_id OR contract_id = @contract_id)
           AND (0 = @branch_id OR branch_id = @branch_id)
)
GO
/****** Object:  UserDefinedFunction [dbo].[FilteredManualAccountingMovements]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FilteredManualAccountingMovements]
(
	@startDate        DATETIME,
	@endDate          DATETIME,
	@source_currency  INT,
	@contract_id      INT,
	@branch_id        INT,
	@isExported       BIT
)
RETURNS TABLE
AS
	RETURN 
(
    SELECT *
    FROM   dbo.ManualAccountingMovements
    WHERE  (currency_id = @source_currency OR 0 = @source_currency)
           AND closure_id > 0
           AND (@isExported IS NULL OR is_exported = @isExported)           
           AND (
                   @startDate IS NULL
                   OR CAST(FLOOR(CAST(@startDate AS FLOAT)) AS DATETIME) <= CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME)
               )
           AND (
                   CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME) <=
                   CAST(FLOOR(CAST(@endDate AS FLOAT)) AS DATETIME)
               )
           AND (0 = @contract_id)
           AND (0 = @branch_id OR branch_id = @branch_id)
)
GO
/****** Object:  UserDefinedFunction [dbo].[FilteredLoanAccountingMovements]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FilteredLoanAccountingMovements]
(
	@startDate        DATETIME,
	@endDate          DATETIME,
	@source_currency  INT,
	@contract_id      INT,
	@branch_id        INT,
	@isExported       BIT
)
RETURNS TABLE
AS
	RETURN 
(
    SELECT *
    FROM   dbo.LoanAccountingMovements
    WHERE  (currency_id = @source_currency OR 0 = @source_currency)
           AND closure_id > 0
           AND (@isExported IS NULL OR is_exported = @isExported)
           AND (
                   @startDate IS NULL
                   OR CAST(FLOOR(CAST(@startDate AS FLOAT)) AS DATETIME) <= CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME)
               )
           AND (
                   CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME) <=
                   CAST(FLOOR(CAST(@endDate AS FLOAT)) AS DATETIME)
               )
           AND (0 = @contract_id OR contract_id = @contract_id)
           AND (0 = @branch_id OR branch_id = @branch_id)
)
GO
/****** Object:  Table [dbo].[FundingLineAccountingRules]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundingLineAccountingRules](
	[id] [int] NOT NULL,
	[funding_line_id] [int] NULL,
 CONSTRAINT [PK_FundingLineAccountingRules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tiers_id] [int] NOT NULL,
	[status] [smallint] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[code] [nvarchar](255) NOT NULL,
	[aim] [nvarchar](200) NOT NULL,
	[begin_date] [datetime] NOT NULL,
	[abilities] [nvarchar](50) NULL,
	[experience] [nvarchar](50) NULL,
	[market] [nvarchar](50) NULL,
	[concurrence] [nvarchar](50) NULL,
	[purpose] [nvarchar](50) NULL,
	[corporate_name] [nvarchar](50) NULL,
	[corporate_juridicStatus] [nvarchar](50) NULL,
	[corporate_FiscalStatus] [nvarchar](50) NULL,
	[corporate_siret] [nvarchar](50) NULL,
	[corporate_CA] [money] NULL,
	[corporate_nbOfJobs] [int] NULL,
	[corporate_financialPlanType] [nvarchar](50) NULL,
	[corporateFinancialPlanAmount] [money] NULL,
	[corporate_financialPlanTotalAmount] [money] NULL,
	[address] [nvarchar](20) NULL,
	[city] [nvarchar](50) NULL,
	[zipCode] [nvarchar](50) NULL,
	[district_id] [int] NULL,
	[home_phone] [nvarchar](50) NULL,
	[personalPhone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[hometype] [nvarchar](50) NULL,
	[corporate_registre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Projects2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persons](
	[id] [int] NOT NULL,
	[first_name] [nvarchar](100) NOT NULL,
	[sex] [char](1) NOT NULL,
	[identification_data] [nvarchar](200) NOT NULL,
	[last_name] [nvarchar](100) NOT NULL,
	[birth_date] [datetime] NULL,
	[household_head] [bit] NOT NULL,
	[nb_of_dependents] [int] NULL,
	[nb_of_children] [int] NULL,
	[children_basic_education] [int] NULL,
	[livestock_number] [int] NULL,
	[livestock_type] [nvarchar](100) NULL,
	[landplot_size] [float] NULL,
	[home_size] [float] NULL,
	[home_time_living_in] [int] NULL,
	[capital_other_equipments] [nvarchar](500) NULL,
	[activity_id] [int] NULL,
	[experience] [int] NULL,
	[nb_of_people] [int] NULL,
	[monthly_income] [money] NULL,
	[monthly_expenditure] [money] NULL,
	[comments] [nvarchar](500) NULL,
	[image_path] [nvarchar](500) NULL,
	[father_name] [nvarchar](200) NULL,
	[birth_place] [nvarchar](50) NULL,
	[nationality] [nvarchar](50) NULL,
	[study_level] [nvarchar](50) NULL,
	[SS] [nvarchar](50) NULL,
	[CAF] [nvarchar](50) NULL,
	[housing_situation] [nvarchar](50) NULL,
	[bank_situation] [nvarchar](50) NULL,
	[handicapped] [bit] NOT NULL,
	[professional_experience] [nvarchar](50) NULL,
	[professional_situation] [nvarchar](50) NULL,
	[first_contact] [datetime] NULL,
	[family_situation] [nvarchar](50) NULL,
	[mother_name] [nvarchar](200) NULL,
	[povertylevel_childreneducation] [int] NOT NULL,
	[povertylevel_economiceducation] [int] NOT NULL,
	[povertylevel_socialparticipation] [int] NOT NULL,
	[povertylevel_healthsituation] [int] NOT NULL,
	[unemployment_months] [int] NULL,
	[personalBank_id] [int] NULL,
	[businessBank_id] [int] NULL,
	[first_appointment] [datetime] NULL,
	[loan_officer_id] [int] NULL,
	[kyc_status] [nvarchar](50) NULL,
	[marital_status] [nvarchar](50) NULL,
	[type_of_facilities] [nvarchar](max) NULL,
	[estimated_worth] [nvarchar](50) NULL,
	[loan_facility_limit] [nchar](10) NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Persons_personal_address_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[AccountMovements]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AccountMovements](@from DATETIME, @to DATETIME, @source_currency INT, @target_currency INT, @contract_id INT, @branch_id INT, @mode INT)
RETURNS TABLE AS RETURN
(
	--WITH _xr AS
	--(
	--	SELECT id, dbo.GetXR(id, @target_currency, @date) xr
	--	FROM dbo.Currencies
	--)
	WITH _movements AS
	(
		SELECT debit_account_number_id, credit_account_number_id
			--, CAST (ROUND(amount * _xr.xr, CASE WHEN cur.use_cents = 1 THEN 2 ELSE 0 END) AS MONEY) amount
			, CASE
				WHEN @target_currency = currency_id THEN amount
				ELSE CAST(ROUND(amount / exchange_rate, 0) AS MONEY)
			END amount
		FROM dbo.LoanAccountingMovements
		--LEFT JOIN dbo.Currencies cur ON cur.id = lam.currency_id
		--LEFT JOIN _xr ON _xr.id = lam.currency_id
		WHERE (currency_id = @source_currency OR 0 = @source_currency)
			AND (CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME) BETWEEN @from AND @to)
			AND (0 = @contract_id OR contract_id = @contract_id)
			AND (0 = @branch_id OR branch_id = @branch_id)
			AND (@mode & 1 > 0)
			AND closure_id > 0
		
		UNION ALL
		SELECT debit_account_number_id, credit_account_number_id
			, CASE
				WHEN @target_currency = currency_id THEN amount
				ELSE CAST(ROUND(amount / exchange_rate, 0) AS MONEY)
			END amount
		FROM dbo.SavingsAccountingMovements
		WHERE currency_id = @source_currency OR 0 = @source_currency
			AND (CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME) BETWEEN @from AND @to)
			AND (0 = @contract_id OR contract_id = @contract_id)
			AND (0 = @branch_id OR branch_id = @branch_id)
			AND (@mode & 2 > 0)
			AND closure_id > 0
			
		UNION ALL
		SELECT debit_account_number_id, credit_account_number_id
			, CASE
				WHEN @target_currency = currency_id THEN amount
				ELSE CAST(ROUND(amount / exchange_rate, 0) AS MONEY)
			END amount
		FROM dbo.ManualAccountingMovements
		WHERE currency_id = @source_currency OR 0 = @source_currency
			AND (CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME) BETWEEN @from AND @to)
			AND (0 = @contract_id)
			AND (0 = @branch_id OR branch_id = @branch_id)
			AND (@mode & 4 > 0)
			AND closure_id > 0
	)
	, _debit AS
	(
		SELECT coa.id account_id, ISNULL(SUM(m.amount), 0) amount
		FROM dbo.ChartOfAccounts coa
		LEFT JOIN _movements m ON coa.id = m.debit_account_number_id
		GROUP BY coa.id
	)
	, _credit AS
	(
		SELECT coa.id account_id, ISNULL(SUM(m.amount), 0) amount
		FROM dbo.ChartOfAccounts coa
		LEFT JOIN _movements m ON coa.id = m.credit_account_number_id
		GROUP BY coa.id
	)
	, _coa_tree AS
	(
		SELECT coa_parent.id parent_id, coa_child.id child_id
		FROM dbo.ChartOfAccounts coa_parent
		INNER JOIN dbo.ChartOfAccounts coa_child ON coa_child.lft >= coa_parent.lft AND coa_child.rgt <= coa_parent.rgt
	)
	SELECT coa.id account_id
		, coa.account_number
		, coa.label account_label
		, coa.account_category_id
		, SUM
		(
			CASE
				WHEN _coa_tree.child_id = _coa_tree.parent_id THEN dt.amount
				ELSe 0
			END
		) debit
		, SUM(dt.amount) agg_debit
		, SUM 
		(
			CASE
				WHEN _coa_tree.child_id = _coa_tree.parent_id THEN cr.amount
				ELSE 0
			END
		) credit
		, SUM(cr.amount) agg_credit
	FROM dbo.ChartOfAccounts coa
	LEFT JOIN _coa_tree ON _coa_tree.parent_id = coa.id
	LEFT JOIN _debit dt ON dt.account_id = _coa_tree.child_id
	LEFT JOIN _credit cr ON cr.account_id = _coa_tree.child_id
	GROUP BY coa.id, coa.account_number, coa.label, coa.account_category_id
)
GO
/****** Object:  Table [dbo].[ContractAccountingRules]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ContractAccountingRules](
	[id] [int] NOT NULL,
	[product_type] [smallint] NOT NULL,
	[loan_product_id] [int] NULL,
	[savings_product_id] [int] NULL,
	[client_type] [char](1) NOT NULL,
	[activity_id] [int] NULL,
	[currency_id] [int] NULL,
 CONSTRAINT [PK_ContractAccountingRules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClientBranchHistory]    Script Date: 09/17/2014 00:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientBranchHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_changed] [datetime] NULL,
	[branch_from_id] [int] NOT NULL,
	[branch_to_id] [int] NOT NULL,
	[client_id] [int] NOT NULL,
	[user_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Clients]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Clients]
AS
-- Persons
SELECT id, 'I' AS code, first_name + ' ' + last_name AS name
FROM dbo.Persons
-- Groups
UNION ALL
SELECT id, 'G', name FROM dbo.Groups
-- Corporates
UNION ALL
SELECT id, 'C', name FROM dbo.Corporates
-- Villages
UNION ALL
SELECT id, 'V', name FROM dbo.Villages
GO
/****** Object:  Table [dbo].[CorporatePersonBelonging]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorporatePersonBelonging](
	[corporate_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[position] [nvarchar](50) NULL,
 CONSTRAINT [PK_CorporatePersonBelonging] PRIMARY KEY CLUSTERED 
(
	[corporate_id] ASC,
	[person_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contracts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contract_code] [nvarchar](255) NOT NULL,
	[branch_code] [varchar](50) NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[start_date] [datetime] NOT NULL,
	[close_date] [datetime] NOT NULL,
	[closed] [bit] NOT NULL,
	[project_id] [int] NOT NULL,
	[status] [smallint] NOT NULL,
	[credit_commitee_date] [datetime] NULL,
	[credit_commitee_comment] [nvarchar](4000) NULL,
	[credit_commitee_code] [nvarchar](100) NULL,
	[align_disbursed_date] [datetime] NULL,
	[loan_purpose] [nvarchar](4000) NULL,
	[comments] [nvarchar](4000) NULL,
	[nsg_id] [int] NULL,
	[activity_id] [int] NOT NULL,
	[preferred_first_installment_date] [datetime] NULL,
 CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonGroupBelonging]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonGroupBelonging](
	[person_id] [int] NOT NULL,
	[group_id] [int] NOT NULL,
	[is_leader] [bit] NOT NULL,
	[currently_in] [bit] NOT NULL,
	[joined_date] [datetime] NOT NULL,
	[left_date] [datetime] NULL,
 CONSTRAINT [PK_PersonGroupBelonging] PRIMARY KEY CLUSTERED 
(
	[person_id] ASC,
	[group_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FollowUp]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FollowUp](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[project_id] [int] NOT NULL,
	[year] [int] NOT NULL,
	[CA] [money] NOT NULL,
	[Jobs1] [int] NOT NULL,
	[Jobs2] [int] NOT NULL,
	[PersonalSituation] [nvarchar](50) NOT NULL,
	[activity] [nvarchar](50) NOT NULL,
	[comment] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_FollowUp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavingEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SavingEvents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[contract_id] [int] NOT NULL,
	[code] [char](4) NOT NULL,
	[amount] [money] NOT NULL,
	[description] [nvarchar](200) NULL,
	[deleted] [bit] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[cancelable] [bit] NOT NULL,
	[is_fired] [bit] NOT NULL,
	[related_contract_code] [nvarchar](50) NULL,
	[fees] [money] NULL,
	[is_exported] [bit] NOT NULL,
	[savings_method] [smallint] NULL,
	[pending] [bit] NOT NULL,
	[pending_event_id] [int] NULL,
	[teller_id] [int] NULL,
	[loan_event_id] [int] NULL,
	[cancel_date] [datetime] NULL,
 CONSTRAINT [PK_SavingEvents_Tmp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SavingDepositContracts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavingDepositContracts](
	[id] [int] NOT NULL,
	[number_periods] [int] NOT NULL,
	[rollover] [smallint] NOT NULL,
	[transfer_account] [nvarchar](50) NULL,
	[withdrawal_fees] [float] NOT NULL,
	[next_maturity] [datetime] NULL,
 CONSTRAINT [PK_SavingDepositContracts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavingBookContracts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavingBookContracts](
	[id] [int] NOT NULL,
	[flat_withdraw_fees] [money] NULL,
	[rate_withdraw_fees] [float] NULL,
	[flat_transfer_fees] [money] NULL,
	[rate_transfer_fees] [float] NULL,
	[flat_deposit_fees] [money] NULL,
	[flat_close_fees] [money] NULL,
	[flat_management_fees] [money] NULL,
	[flat_overdraft_fees] [money] NULL,
	[in_overdraft] [bit] NOT NULL,
	[rate_agio_fees] [float] NULL,
	[cheque_deposit_fees] [money] NULL,
	[flat_reopen_fees] [money] NULL,
	[flat_ibt_fee] [money] NULL,
	[rate_ibt_fee] [float] NULL,
	[use_term_deposit] [bit] NOT NULL,
	[term_deposit_period] [int] NOT NULL,
	[term_deposit_period_min] [int] NULL,
	[term_deposit_period_max] [int] NULL,
	[transfer_account] [nvarchar](50) NULL,
	[rollover] [int] NULL,
	[next_maturity] [datetime] NULL,
 CONSTRAINT [PK_SavingBookContracts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Rep_Client_Personal_Information]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Client_Personal_Information]
	@person_id INT
	, @branch_id INT
AS BEGIN
	IF OBJECT_ID('tempdb..#thumbnails') IS NOT NULL
	BEGIN
	   DROP TABLE #thumbnails
	END

	CREATE TABLE #thumbnails	
	(
		num INT NOT NULL
		, thumbnail1 IMAGE NULL
		, thumbnail2 IMAGE NULL	
	)

	DECLARE @db_from NVARCHAR(MAX)
	DECLARE @db_to NVARCHAR(MAX)
	DECLARE @sql NVARCHAR(MAX)

	SELECT @db_from = DB_NAME()
	SET @db_to = @db_from + '_attachments'

	IF EXISTS (SELECT * FROM sys.databases WHERE name = @db_to)
	BEGIN
		SET @sql = 'INSERT INTO #thumbnails (num, thumbnail1)
		SELECT 1, thumbnail
		FROM ' + @db_to + '..Pictures
		WHERE id = ' + CAST(@person_id AS NVARCHAR(20)) + ' AND subid = 0'
		EXEC sp_executesql @sql	

		SET @sql = 'INSERT INTO #thumbnails (num, thumbnail2)
		SELECT 2, thumbnail
		FROM ' + @db_to + '..Pictures
		WHERE id = ' + CAST(@person_id AS NVARCHAR(20)) + ' AND subid = 1'
		EXEC sp_executesql @sql	
	END

	SELECT
	Pers.first_name
	,Pers.last_name
	,Pers.father_name
	,Pers.identification_data AS [id_number]
	,Pers.birth_date, Pers.sex AS [gender],
	ISNULL(Dis.name, '-') AS [district]
	,ISNULL(Tr.city, '-') AS [city]
	,ISNULL(Tr.address, '-') AS [address]
	,ISNULL(Dis2.name, '-') AS [sec_district]
	,ISNULL(Tr.secondary_city, '-') AS [sec_city]
	,ISNULL(Tr.secondary_address, '-') AS [sec_address]
	,ISNULL(Tr.personal_phone, '-') AS [phone]
	,ISNULL(Tr.secondary_home_phone, '-') AS [sec_phone], ISNULL(Tr.secondary_personal_phone, '-') AS [sec_pers_phone]
	, th1.thumbnail1 picture
	, th2.thumbnail2 picture2
	FROM Tiers AS Tr
	INNER JOIN Persons AS Pers ON Pers.id = Tr.id
	LEFT JOIN Districts AS Dis ON Dis.id = Tr.district_id
	LEFT JOIN Districts AS Dis2 ON Dis2.id = Tr.secondary_district_id
	LEFT JOIN #thumbnails th1 ON th1.num = 1
	LEFT JOIN #thumbnails th2 ON th2.num = 2
	WHERE Tr.id = @person_id
END
GO
/****** Object:  UserDefinedFunction [dbo].[TrialBalance]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TrialBalance](@date DATETIME, @source_currency INT, @target_currency INT, @contract_id INT, @branch_id INT, @mode INT)
RETURNS TABLE AS RETURN
(
	/*
	* Bit's that are used for mode parameter.
	* 1. bit indicates LoanAccountingMovements should be added or not.
	* 2. bit, same as 1. bit but for SavingsAccountingMovements.
	* 3. bit, same as 1. bit but for ManualAccountingMovements.
	* 4. bit indicates should we filter exported transactions
	* 5. which type exported transactions should we take.
	*/
	--WITH _xr AS
	--(
	--	SELECT id, dbo.GetXR(id, @target_currency, @date) xr
	--	FROM dbo.Currencies
	--)
	WITH _movements AS
	(
		SELECT debit_account_number_id, credit_account_number_id
			--, CAST (ROUND(amount * _xr.xr, CASE WHEN cur.use_cents = 1 THEN 2 ELSE 0 END) AS MONEY) amount
			, CASE
				WHEN @target_currency = currency_id THEN amount
				ELSE CAST(ROUND(amount / exchange_rate, 0) AS MONEY)
			END amount
		FROM dbo.FilteredLoanAccountingMovements(NULL, @date, @source_currency, @contract_id, @branch_id, CASE WHEN @mode & 8 = 0 THEN NULL ELSE CASE WHEN @mode & 16 > 0 THEN 1 ELSE 0 END END)
		--LEFT JOIN dbo.Currencies cur ON cur.id = lam.currency_id
		--LEFT JOIN _xr ON _xr.id = lam.currency_id
		WHERE (@mode & 1 > 0)
		
		UNION ALL
		SELECT debit_account_number_id, credit_account_number_id
			, CASE
				WHEN @target_currency = currency_id THEN amount
				ELSE CAST(ROUND(amount / exchange_rate, 0) AS MONEY)
			END amount
		FROM dbo.FilteredSavingsAccountingMovements(NULL, @date, @source_currency, @contract_id, @branch_id, CASE WHEN @mode & 8 = 0 THEN NULL ELSE CASE WHEN @mode & 16 > 0 THEN 1 ELSE 0 END END)
		WHERE (@mode & 2 > 0)
			
		UNION ALL
		SELECT debit_account_number_id, credit_account_number_id
			, CASE
				WHEN @target_currency = currency_id THEN amount
				ELSE CAST(ROUND(amount / exchange_rate, 0) AS MONEY)
			END amount
		FROM dbo.FilteredManualAccountingMovements(NULL, @date, @source_currency, @contract_id, @branch_id, CASE WHEN @mode & 8 = 0 THEN NULL ELSE CASE WHEN @mode & 16 > 0 THEN 1 ELSE 0 END END)
		WHERE (@mode & 4 > 0)
	)
	, _debit AS
	(
		SELECT coa.id account_id, ISNULL(SUM(m.amount), 0) amount
		FROM dbo.ChartOfAccounts coa
		LEFT JOIN _movements m ON coa.id = m.debit_account_number_id
		GROUP BY coa.id
	)
	, _credit AS
	(
		SELECT coa.id account_id, ISNULL(SUM(m.amount), 0) amount
		FROM dbo.ChartOfAccounts coa
		LEFT JOIN _movements m ON coa.id = m.credit_account_number_id
		GROUP BY coa.id
	)
	, _coa_tree AS
	(
		SELECT coa_parent.id parent_id, coa_child.id child_id, coa_child.debit_plus
		FROM dbo.ChartOfAccounts coa_parent
		INNER JOIN dbo.ChartOfAccounts coa_child ON coa_child.lft >= coa_parent.lft AND coa_child.rgt <= coa_parent.rgt
	)
	SELECT coa.id account_id
		, coa.account_number
		, coa.label account_label
		, coa.account_category_id
		, SUM
		(
			CASE
				WHEN _coa_tree.child_id = _coa_tree.parent_id THEN dt.amount
				ELSe 0
			END
		) debit
		, SUM(dt.amount) agg_debit
		, SUM 
		(
			CASE
				WHEN _coa_tree.child_id = _coa_tree.parent_id THEN cr.amount
				ELSE 0
			END
		) credit
		, SUM(cr.amount) agg_credit
		, SUM
		(
			CASE
				WHEN _coa_tree.child_id = _coa_tree.parent_id THEN --dt.amount - cr.amount
					CASE 
						WHEN 1 = _coa_tree.debit_plus THEN dt.amount - cr.amount
						ELSE cr.amount - dt.amount
					END
				ELSE 0
			END
		) balance
		, SUM(
			CASE
				WHEN 1 = _coa_tree.debit_plus THEN dt.amount - cr.amount
				ELSE cr.amount - dt.amount
			END
		) agg_balance
	FROM dbo.ChartOfAccounts coa
	LEFT JOIN _coa_tree ON _coa_tree.parent_id = coa.id
	LEFT JOIN _debit dt ON dt.account_id = _coa_tree.child_id
	LEFT JOIN _credit cr ON cr.account_id = _coa_tree.child_id
	GROUP BY coa.id, coa.account_number, coa.label, coa.account_category_id
)
GO
/****** Object:  UserDefinedFunction [dbo].[SavingWithdrawals]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingWithdrawals]
(
@pFrom DATETIME,
@pTo DATETIME
) RETURNS TABLE
AS RETURN
(
 SELECT SC.id AS contract_id,
  SE.id AS event_id,
  SE.creation_date AS event_date,
  SE.amount AS amount,
  SP.product_type,
  SP.currency_id
FROM SavingEvents SE
INNER JOIN SavingContracts SC ON SE.contract_id = SC.id 
INNER JOIN SavingProducts SP ON SP.id = SC.product_id
WHERE SE.code = 'SVWE' AND
(
 (@pFrom IS NULL AND SE.creation_date <= @pTo) OR
 (@pTo IS NULL AND SE.creation_date >= @pFrom) OR
 (SE.creation_date BETWEEN @pFrom AND @pTo) 
)
)
GO
/****** Object:  UserDefinedFunction [dbo].[SavingTransfers]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingTransfers]
(
@pFrom DATETIME,
@pTo DATETIME
) RETURNS TABLE
AS RETURN
(
 SELECT SC.id AS from_contract_id,
  SC2.id AS to_contract_id,
  SE.id AS event_id,
  SE.creation_date AS event_date,
  SE.amount AS amount,
  SP.product_type,
  SP.currency_id
FROM SavingEvents SE
INNER JOIN SavingContracts SC ON SE.contract_id = SC.id 
INNER JOIN SavingProducts SP ON SP.id = SC.product_id
INNER JOIN SavingContracts SC2 ON SC2.code = SE.related_contract_code
WHERE SE.code = 'SCTE' AND 
(
 (@pFrom IS NULL AND SE.creation_date <= @pTo) OR
 (@pTo IS NULL AND SE.creation_date >= @pFrom) OR
 (SE.creation_date BETWEEN @pFrom AND @pTo) 
)
)
GO
/****** Object:  UserDefinedFunction [dbo].[SavingPenalties]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingPenalties]
(
	@pFrom DATETIME,
	@pTo DATETIME
) RETURNS TABLE
AS RETURN
(
	SELECT contract_id
	, event_id
	, event_date
	, event_code
	, amount
	, CAST(ROUND(amount/(1+vat_rate), 2) AS MONEY) AS amount_wo_vat
	, amount - CAST(ROUND(amount/(1+vat_rate), 2) AS MONEY) AS amount_vat
	, product_type
	, currency_id
	FROM
	(
		SELECT SC.id AS contract_id
		, SE.id AS event_id
		, SE.creation_date AS event_date
		, SE.code AS event_code
		, SE.fees AS amount
		, SP.product_type
		, SP.currency_id
		, CAST((SELECT value 
			FROM dbo.GeneralParameters
			WHERE [key] = 'VAT_RATE'
		) AS FLOAT)/100 AS vat_rate
		FROM SavingEvents SE
		INNER JOIN SavingContracts SC ON SE.contract_id = SC.id 
		INNER JOIN SavingProducts SP ON SP.id = SC.product_id
		WHERE SE.code IN ('SOFE','SVAE') AND
		(
			(@pFrom IS NULL AND SE.creation_date <= @pTo) OR
			(@pTo IS NULL AND SE.creation_date >= @pFrom) OR
			(SE.creation_date BETWEEN @pFrom AND @pTo) 
		)
	) AS t
)
GO
/****** Object:  StoredProcedure [dbo].[Rep_Client_Personal_Information_Savings]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Client_Personal_Information_Savings]
	@person_id INT
AS BEGIN
	SELECT DISTINCT
	SaCont.code AS [savings_code],
	Balance.balance_amount,
	SaPr.name AS [product_name],
	SaPr.code AS [product_code],
	CASE 
	WHEN SaPr.product_type = 'B' THEN 'Savings Book'
	WHEN SaPr.product_type = 'C' THEN 'Compulsory savings'
	ELSE 'Savings Deposit'
	END
	AS [product_type],
	SaCont.creation_date, SaCont.closed_date
	FROM SavingContracts AS SaCont
	INNER JOIN SavingProducts AS SaPr ON SaPr.id = SaCont.product_id
	INNER JOIN
	(
	SELECT sum_deposit - ISNULL(sum_withdraw, 0) AS [balance_amount], Deposit.contract_id
	FROM
	(
		SELECT SUM(amount) AS [sum_deposit], contract_id
		FROM SavingEvents
		WHERE (code IN ('SVIE', 'SVDE', 'SIPE', 'SCTE')) AND deleted = 0 AND is_fired = 1 AND creation_date <= GETDATE()
		GROUP BY contract_id
	) AS Deposit
	LEFT JOIN
	(
		SELECT SUM(amount + ISNULL(fees, 0)) AS [sum_withdraw], contract_id
		FROM SavingEvents
		WHERE (code IN ('SVWE', 'SDTE')) AND deleted = 0 AND is_fired = 1 AND creation_date <= GETDATE() 
		GROUP BY contract_id
	) AS Withdraw ON Deposit.contract_id = Withdraw.contract_id
	) AS Balance ON Balance.contract_id = SaCont.id
	WHERE  SaCont.tiers_id = @person_id
END
GO
/****** Object:  UserDefinedFunction [dbo].[SavingCommissions]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingCommissions]
(@pFrom DATETIME, @pTo DATETIME) 
RETURNS TABLE
AS RETURN
(
	SELECT contract_id
	, event_id
	, event_date
	, event_code
	, amount
	, CAST(ROUND(amount/(1+vat_rate), 2) AS MONEY) AS amount_wo_vat
	, amount - CAST(ROUND(amount/(1+vat_rate), 2) AS MONEY) AS amount_vat
	, product_type
	, currency_id
	FROM
	(
		SELECT SC.id AS contract_id
		, SE.id AS event_id
		, SE.creation_date AS event_date
		, SE.code AS event_code
		, SE.fees AS amount
		, SP.product_type
		, SP.currency_id
		, CAST((SELECT value 
			FROM dbo.GeneralParameters
			WHERE [key] = 'VAT_RATE'
		) AS FLOAT)/100 AS vat_rate
		FROM SavingEvents AS SE
		INNER JOIN SavingContracts SC ON SE.contract_id = SC.id
		INNER JOIN SavingProducts SP ON SP.id = SC.product_id
		WHERE SE.code NOT IN ('SOFE','SVAE') AND
		(
			(@pFrom IS NULL AND SE.creation_date <= @pTo) OR
			(@pTo IS NULL AND SE.creation_date >= @pFrom) OR
			(SE.creation_date BETWEEN @pFrom AND @pTo) 
		)
	) AS t
)
GO
/****** Object:  UserDefinedFunction [dbo].[SavingDeposits]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingDeposits]
(
@pFrom DATETIME,
@pTo DATETIME
) RETURNS TABLE
AS RETURN
(
 SELECT SC.id AS contract_id,
  SE.id AS event_id,
  SE.creation_date AS event_date,
  SE.amount AS amount,
  SE.savings_method AS method,
  SP.product_type,
  SP.currency_id
FROM SavingEvents SE
INNER JOIN SavingContracts SC ON SE.contract_id = SC.id 
INNER JOIN SavingProducts SP ON SP.id = SC.product_id
WHERE SE.code = 'SVDE'
AND
(
 (@pFrom IS NULL AND SE.creation_date <= @pTo) OR
 (@pTo IS NULL AND SE.creation_date >= @pFrom) OR
 (SE.creation_date BETWEEN @pFrom AND @pTo) 
)
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetClientID]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetClientID]
(@contractID int)
RETURNS int
AS
BEGIN
DECLARE @ClientID int
SET @ClientID = (select tiers_id 
				   from projects inner join
					    contracts on contracts.project_id = projects.id
				   where contracts.id = @contractID)
return @ClientID
END
GO
/****** Object:  StoredProcedure [dbo].[DetermineTypeOfFacilities]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DetermineTypeOfFacilities]
(@clientId INT) 
AS

	DECLARE @fixedDepositNo INT;
	SET @fixedDepositNo = 0
	DECLARE @currentAccountNo INT;
	SET @currentAccountNo = 0
	DECLARE @savingContractNo INT;
	SET @savingContractNo = 0
	DECLARE @contractsNo INT;
	SET @contractsNo = 0
	DECLARE @output varchar(100);
BEGIN
--1
	SELECT @fixedDepositNo= COUNT(*) FROM FixedDepositProductHoldings WHERE [client_id] =@clientId
	AND status <> 'Closed'
--2
	SELECT @currentAccountNo= COUNT(*) FROM CurrentAccountProductHoldings WHERE [client_id] =@clientId
	AND status <> 'Closed'
--3
	SELECT @savingContractNo= COUNT(*) FROM [SavingContracts] WHERE [tiers_id] =@clientId
	AND status=1 
	
--4
	SELECT @contractsNo= COUNT(*) FROM [Contracts] WHERE dbo.GetClientIdFromContractCode([contract_code]) =@clientId 
	AND status='5'
	
	SELECT CAST(@fixedDepositNo AS VARCHAR)+' Fixed Deposits,'+CAST(@currentAccountNo AS VARCHAR)+' Current Accounts,'+ 
	CAST(@savingContractNo AS VARCHAR) +' Saving Accounts,'+ CAST(@contractsNo AS VARCHAR)+ ' Loan Accounts' AS ret
	-- how to display the values? 
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetNbMembers]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetNbMembers]
(@groupId int,@beginDate datetime)
RETURNS int
AS
BEGIN
DECLARE @nb_members int;
SET @nb_members = (select count(person_id) 
				   from persongroupbelonging 
				   where group_id = @groupId
						and @begindate between joined_date and isnull(left_date,@begindate))
return @nb_members;
END
GO
/****** Object:  UserDefinedFunction [dbo].[getSavingBalance]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery56.sql|7|0|C:\Users\TANUJ\AppData\Local\Temp\~vsC57C.sql
	-- It's beng assumed that ID numbers for events will be assigned only in increasing order.
	--
	-- History:
	-- 25 May 2011 v3.1.0 - Sanjar
	-- In order to take reopen events into account, filtering according to event IDs is added.
CREATE FUNCTION [dbo].[getSavingBalance]
    (
      @savingId INT,
      @date DATETIME
    )
RETURNS MONEY
AS BEGIN
   DECLARE @credit MONEY
	, @debit MONEY
	,@Fees MONEY
	, @previousReopenEventId INT
	, @laterReopenEventId INT
   
   SET @previousReopenEventId = ISNULL((
										SELECT MAX(id) 
										FROM SavingEvents 
										WHERE code = 'SVRE' 
										AND convert(date, creation_date) <= @date
										AND contract_id = @savingId 
										AND deleted = 0),0)
   SET @laterReopenEventId    = ISNULL(
   									   (SELECT MIN(id) 
										FROM SavingEvents 
										WHERE code = 'SVRE' 
										AND convert(date, creation_date) >@date
										AND contract_id = @savingId 
										AND deleted = 0),
										2147483647
									   ) -- if null, then maximum integer value
   
   SET @credit = (SELECT SUM(ISNULL(se.amount,0))
				 FROM SavingEvents se
				 WHERE se.contract_id = @savingId 
				 AND se.deleted = 0 
				 AND se.is_fired = 1 
				 AND convert(date, se.creation_date) <= @date
				 AND se.code IN ('SVIE','SVDE','SIPE','SCTE','SOCE','SVRE','SCIT','SVLD')
				 AND se.id BETWEEN @previousReopenEventId AND @laterReopenEventId)
   
   SET @debit = (SELECT SUM(ISNULL(se.amount,0))
				FROM SavingEvents se
				WHERE se.contract_id = @savingId 
				AND se.deleted = 0 
				AND se.is_fired = 1 
				AND convert(date, se.creation_date) <= @date
				AND se.code IN ('SVWE','SDTE','SMFE','SOFE','SVAE','SODE','SDIT','SRLE')
				AND se.id BETWEEN @previousReopenEventId AND @laterReopenEventId)
	
     SET @fees = (
     			SELECT SUM(ISNULL(se.fees,0))
				FROM SavingEvents se
				WHERE se.contract_id = @savingId 
				AND se.deleted = 0
				AND se.is_fired = 1
				AND convert(date, se.creation_date) <= @date
				AND se.code IN ('SVLD','SVCE','SVWE','SDTE','SDIT')
				AND se.id BETWEEN @previousReopenEventId AND @laterReopenEventId)	
   
   RETURN  (SELECT ISNULL(@credit,0) - ISNULL(@debit,0)-ISNULL(@fees,0))
END
GO
/****** Object:  Table [dbo].[LinkGuarantorCredit]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LinkGuarantorCredit](
	[tiers_id] [int] NOT NULL,
	[contract_id] [int] NOT NULL,
	[guarantee_amount] [money] NOT NULL,
	[guarantee_desc] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoansLinkSavingsBook]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoansLinkSavingsBook](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[loan_id] [int] NULL,
	[savings_id] [int] NULL,
	[loan_percentage] [int] NULL,
 CONSTRAINT [PK_LoansLinkSavingsBook] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[loan_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractEvents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[event_type] [nvarchar](4) NOT NULL,
	[contract_id] [int] NOT NULL,
	[event_date] [datetime] NOT NULL,
	[user_id] [int] NOT NULL,
	[is_deleted] [bit] NOT NULL,
	[entry_date] [datetime] NULL,
	[is_exported] [bit] NOT NULL,
	[comment] [nvarchar](4000) NULL,
	[teller_id] [int] NULL,
	[parent_id] [int] NULL,
	[cancel_date] [datetime] NULL,
 CONSTRAINT [PK_ContractEvents_Tmp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ContractEvents_type_contract_id] ON [dbo].[ContractEvents] 
(
	[event_type] ASC,
	[contract_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractAssignHistory]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractAssignHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateChanged] [datetime] NOT NULL,
	[loanofficerFrom_id] [int] NOT NULL,
	[loanofficerTo_id] [int] NOT NULL,
	[contract_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CollateralsLinkContracts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollateralsLinkContracts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contract_id] [int] NOT NULL,
 CONSTRAINT [PK_CollateralsLinkContracts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credit]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credit](
	[id] [int] NOT NULL,
	[package_id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[interest_rate] [numeric](16, 12) NOT NULL,
	[installment_type] [int] NOT NULL,
	[nb_of_installment] [int] NOT NULL,
	[anticipated_total_repayment_penalties] [float] NOT NULL,
	[disbursed] [bit] NOT NULL,
	[loanofficer_id] [int] NOT NULL,
	[grace_period] [int] NULL,
	[written_off] [bit] NOT NULL,
	[rescheduled] [bit] NOT NULL,
	[bad_loan] [bit] NOT NULL,
	[non_repayment_penalties_based_on_overdue_principal] [float] NOT NULL,
	[non_repayment_penalties_based_on_initial_amount] [float] NOT NULL,
	[non_repayment_penalties_based_on_olb] [float] NOT NULL,
	[non_repayment_penalties_based_on_overdue_interest] [float] NOT NULL,
	[fundingLine_id] [int] NOT NULL,
	[synchronize] [bit] NOT NULL,
	[interest] [money] NOT NULL,
	[grace_period_of_latefees] [int] NOT NULL,
	[anticipated_partial_repayment_penalties] [float] NULL,
	[number_of_drawings_loc] [int] NULL,
	[amount_under_loc] [money] NULL,
	[maturity_loc] [int] NULL,
	[anticipated_partial_repayment_base] [smallint] NOT NULL,
	[anticipated_total_repayment_base] [smallint] NOT NULL,
	[schedule_changed] [bit] NOT NULL,
	[amount_min] [money] NULL,
	[amount_max] [money] NULL,
	[ir_min] [numeric](16, 12) NULL,
	[ir_max] [numeric](16, 12) NULL,
	[nmb_of_inst_min] [int] NULL,
	[nmb_of_inst_max] [int] NULL,
	[loan_cycle] [int] NULL,
	[insurance] [decimal](18, 2) NOT NULL,
	[effective_interest_rate] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Credit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[CalculateLatePenalty]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CalculateLatePenalty]
@contract_id INT
, @date DATETIME
AS
BEGIN
	-- The formula for calculating late penalty (for one installment) is quite simple:
	-- late_days_(1) * late_amount(2) * late_interest_rate_(3) - paid_penalty_(4)
	-- (1) late_days = end_date - start_date, where end_date is given
	-- so the goal is to find out the start_date, which is not that
	-- complicated either: start_date is the date of the latest relevant
	-- repayment (the one affecting the installment under investigation)
	-- where principal or interest was repaid (*not* penalty)
	-- (2) late_amount is sum(installments) - sum(repayments) with adjustments
	-- for values that fall outside the legitimate range (more than zero and
	-- less then or equal to the installment amount)
	-- (3) late_interest_rate is stored in the Credit table for each contract
	-- (4) paid_penalty = sum of paid penalties (with zero for principal and interest)
	-- of all the repayment events between start_date (not including) and end_date (including).
	-- Get late penalty rates
	DECLARE @late_principal_penalty_rate FLOAT
	DECLARE @late_interest_penalty_rate FLOAT
	DECLARE @late_amount_penalty_rate FLOAT
	DECLARE @late_olb_penalty_rate FLOAT
	DECLARE @grace_period INT
	SELECT @late_principal_penalty_rate = non_repayment_penalties_based_on_overdue_principal
	, @late_interest_penalty_rate = non_repayment_penalties_based_on_overdue_interest
	, @late_amount_penalty_rate = non_repayment_penalties_based_on_initial_amount
	, @late_olb_penalty_rate = non_repayment_penalties_based_on_olb
	, @grace_period = grace_period_of_latefees
	FROM dbo.Credit
	WHERE id = @contract_id
	
	-- Get number of late days
	DECLARE @max_late_days INT
	SELECT @max_late_days = [value]
	FROM dbo.GeneralParameters
	WHERE [key] = 'LATE_DAYS_AFTER_ACCRUAL_CEASES'
	DECLARE @retval MONEY
	SET @retval = 0
	
	DECLARE @number INT
	DECLARE @principal MONEY
	DECLARE @interest MONEY
	DECLARE @expected_date DATETIME
	DECLARE @preceding_principal_due MONEY
	DECLARE @preceding_interest_due MONEY
	DECLARE @start_re INT
	DECLARE @start_date DATETIME
	DECLARE @late_days INT
	DECLARE @end_date DATETIME
	DECLARE @principal_late MONEY
	DECLARE @interest_late MONEY
	
	IF @late_interest_penalty_rate > 0 OR @late_principal_penalty_rate > 0
	BEGIN
		-- Traverse through installments
		DECLARE i_cursor CURSOR FOR
		SELECT number, expected_date, principal, interest
		FROM #installments
		WHERE contract_id = @contract_id AND expected_date < @date
		
		OPEN i_cursor
		FETCH NEXT FROM i_cursor
		INTO @number, @expected_date, @principal, @interest
		WHILE 0 = @@FETCH_STATUS
		BEGIN
			SET @start_re = NULL
			SET @start_date = NULL
			-- Get due values for all the preceding installments
			SELECT @preceding_principal_due = ISNULL(SUM(principal), 0)
			, @preceding_interest_due = ISNULL(SUM(interest), 0)
			FROM #installments
			WHERE contract_id = @contract_id AND number < @number
			-- Get start_date, i.e. the date of the latest event when principal or interest
			-- (but *not* penalty) has been repaid
			SELECT @start_re = ISNULL(MAX(num), 0)
			FROM
			(
				SELECT * 
				FROM #RepaymentEvents
				WHERE num >= (
                    SELECT MIN(num) 
                    FROM #RepaymentEvents 
                    WHERE rt_principal > @preceding_principal_due and contract_id = @contract_id
                )
				AND num <= ISNULL((
				    SELECT MAX(num) 
				    FROM #RepaymentEvents 
				    WHERE rt_principal < @preceding_principal_due + @principal and contract_id = @contract_id				    
				), 0) + 1
				and contract_id = @contract_id
				UNION ALL
				SELECT * 
				FROM #RepaymentEvents
				WHERE num >= (
				    SELECT MIN(num) 
				    FROM #RepaymentEvents 
				    WHERE rt_interest > @preceding_interest_due and contract_id = @contract_id
                )
				AND num <= ISNULL((
				    SELECT MAX(num) 
				    FROM #RepaymentEvents 
				    WHERE rt_interest < @preceding_interest_due + @interest and contract_id = @contract_id
				), 0) + 1
				and contract_id = @contract_id
			) AS _re
			WHERE principal > 0 OR interest > 0
			-- Get the first repayment event
			SELECT @start_date = event_date
			FROM #RepaymentEvents
			WHERE num = @start_re and contract_id = @contract_id
			SET @start_date = ISNULL(@start_date, @expected_date)
			-- Obviously, @start_date cannot come before @expected_date
			SET @start_date = CASE WHEN @start_date < @expected_date THEN @expected_date ELSE @start_date END
			SET @end_date = CASE
				WHEN NOT @max_late_days IS NULL THEN DATEADD(dd, @max_late_days, @expected_date)
				ELSE @date
			END
			SET @end_date = CASE WHEN @end_date > @date THEN @date ELSE @end_date END
			SET @late_days = DATEDIFF(dd, @start_date, @end_date)
			SET @late_days = CASE WHEN @late_days < 0 THEN 0 ELSE @late_days END
			SET @late_days = CASE WHEN @late_days <= @grace_period THEN 0 ELSE @late_days END
			-- Get late amounts
			SELECT @principal_late = @preceding_principal_due + @principal - ISNULL(SUM(principal), 0)
			, @interest_late = @preceding_interest_due + @interest - ISNULL(SUM(interest), 0)
			FROM #RepaymentEvents
			WHERE contract_id = @contract_id
			SET @principal_late = CASE
				WHEN @principal_late < 0 THEN 0
				WHEN @principal_late > @principal THEN @principal
				ELSE @principal_late
			END
			SET @interest_late = CASE
				WHEN @interest_late < 0 THEN 0
				WHEN @interest_late > @interest THEN @interest
				ELSE @interest_late
			END
			SET @retval = @retval + @principal_late * @late_principal_penalty_rate * @late_days
			SET @retval = @retval + @interest_late * @late_interest_penalty_rate * @late_days
			FETCH NEXT FROM i_cursor
			INTO @number, @expected_date, @principal, @interest
		END -- end of traversal
		CLOSE i_cursor
		DEALLOCATE i_cursor
	END
	IF @late_amount_penalty_rate > 0 OR @late_olb_penalty_rate > 0
	BEGIN
		-- Now calculate penalty on initial amount and / or OLB
		
		-- First, we have to get start date (which in turn will allow
		-- to calculate number of late days).
		-- To get the start date we have to figure out two things:
		-- a) expected date of the first unpaid installment, and
		-- b) date of the latest repayment event with principal > 0 or interest > 0
		-- Take the most recent one as the start date.
		-- If both are NULL then take @date.
		-- Get total paid amounts
		DECLARE @total_paid_principal MONEY
		DECLARE @total_paid_interest MONEY
		SELECT @total_paid_principal = ISNULL(SUM(principal), 0)
		, @total_paid_interest = ISNULL(SUM(interest), 0)
		FROM #RepaymentEvents
		where contract_id = @contract_id
		-- Get expected date of the first non-repaid installment
		DECLARE @i_date DATETIME
		SELECT @i_date = MIN(expected_date)
		FROM
		(
			SELECT a.number, a.expected_date
			, SUM(b.principal) AS rt_principal
			, SUM(b.interest) AS rt_interest
			FROM #installments AS a
			LEFT JOIN #installments AS b ON a.contract_id = b.contract_id AND b.number <= a.number
			WHERE a.contract_id = @contract_id AND a.expected_date < @date
			GROUP BY a.number, a.expected_date
		) AS i WHERE rt_principal > @total_paid_principal + 0.05 OR rt_interest > @total_paid_interest + 0.05
		-- Get the latest repayment date
		DECLARE @re_date DATETIME
		SELECT @re_date = MAX(event_date)
		FROM #RepaymentEvents
		WHERE (principal > 0 OR interest > 0) and contract_id = @contract_id
		-- Get start date
		IF @i_date IS NULL
		BEGIN
			SET @start_date = @re_date
		END
		ELSE
		BEGIN
			SET @start_date = CASE WHEN @i_date > @re_date OR @re_date IS NULL THEN @i_date ELSE @re_date END
		END
		SET @start_date = ISNULL(@start_date, @date)
		-- Get end date
		SET @end_date = CASE
			WHEN NOT @max_late_days IS NULL THEN DATEADD(dd, @max_late_days, @start_date)
			ELSE @date
		END
		SET @end_date = CASE WHEN @end_date > @date THEN @date ELSE @end_date END
		-- Get late days
		SET @late_days = DATEDIFF(dd, @start_date, @end_date)
		SET @late_days = CASE WHEN @late_days < 0 THEN 0 ELSE @late_days END
		SET @late_days = CASE WHEN @late_days <= @grace_period THEN 0 ELSE @late_days END
		-- Get amount
		DECLARE @amount MONEY
		SELECT @amount = SUM(principal)
		FROM #installments
		WHERE contract_id = @contract_id
		-- Get penalty on amount
		SET @retval = @retval + @amount * @late_days * @late_amount_penalty_rate
		
		-- Get penalty on OLB
		SET @retval = @retval + (@amount - @total_paid_principal) * @late_days * @late_olb_penalty_rate
	END
	-- Subtract paid penalty
	SET @start_re = NULL
	SELECT @start_re = MAX(num)
	FROM #RepaymentEvents
	WHERE (principal > 0 OR interest > 0) and contract_id = @contract_id
	SELECT @retval = @retval - ISNULL(SUM(penalty), 0)
	FROM #RepaymentEvents
	WHERE num > @start_re and contract_id = @contract_id
	SET @retval = CASE WHEN @retval < 0 THEN 0 ELSE @retval END
	INSERT INTO #penalties VALUES (@contract_id, @retval)
END
GO
/****** Object:  UserDefinedFunction [dbo].[ClosedContracts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of contracts closed within a period
--
-- HISTORY
--
-- 13 Apr, 2011 - v2.8.15 - Pasha BASTOV
-- Add the @branch_id parameter
CREATE FUNCTION [dbo].[ClosedContracts]
(	
	@from DATETIME
	, @to DATETIME
	, @branch_id INT
)
RETURNS TABLE 
AS
RETURN
( -- Function returns closed contracts, as it is obvious from it's name.
  -- It treats groups also as one contract. 
  -- On the contrary, ClosedLoans takes the result of ClosedContracts, and if client_id matches to groups,brakes down into individual loans.
  -- DISTINCT below is used, because, somehow sometimes more than one entries are inserted in ContractEvents for a single disbursement event,
  -- resulting in multiple result raws. 
	SELECT DISTINCT Contracts.id AS contract_id,
	ISNULL(ISNULL(persons.id,groups.id),corporates.id) AS client_id,
	Tiers.client_type_code AS client_type_code,
	ISNULL(ISNULL(Persons.first_name + ' ' + Persons.last_name, groups.name), corporates.name) AS client_name,
	Users.first_name + SPACE(1) + Users.last_name AS loan_officer,
	Credit.amount AS amount,
	ContractEvents.event_date AS start_date,
	Contracts.close_date AS close_date,
	packages.currency_id AS currency_id,
	Currencies.name AS currency,
	packages.code AS code	
	FROM
	Persons RIGHT OUTER JOIN
	Groups RIGHT OUTER JOIN
	Corporates RIGHT OUTER JOIN	Currencies 
	INNER JOIN Packages ON Packages.currency_id = Currencies.id
	INNER JOIN Credit ON Credit.package_id = Packages.id
	INNER JOIN Users ON Credit.loanofficer_id = Users.id
	INNER JOIN Contracts ON Contracts.id = Credit.id
	INNER JOIN ContractEvents ON ContractEvents.contract_id = Contracts.id AND ContractEvents.event_type = 'LODE' AND ContractEvents.is_deleted = 0
	INNER JOIN Projects ON Contracts.project_id = Projects.id
	INNER JOIN Tiers ON Projects.tiers_id = Tiers.id ON Tiers.id = corporates.id ON Tiers.id = groups.id ON Tiers.id = Persons.id
	WHERE Contracts.close_date BETWEEN @from AND @to
	AND Contracts.closed = 1
	AND (Tiers.branch_id = @branch_id OR 0 = @branch_id)
)
GO
/****** Object:  Table [dbo].[CreditEntryFees]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditEntryFees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[credit_id] [int] NOT NULL,
	[entry_fee_id] [int] NOT NULL,
	[fee_value] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_CreditEntryFees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Collaterals]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Collaterals]()
RETURNS TABLE
AS
RETURN (
    SELECT t.id AS client_id, clc.id AS collateral_id, clc.contract_id FROM dbo.CollateralsLinkContracts clc
    INNER JOIN Contracts co ON clc.contract_id = co.id
    INNER JOIN dbo.Projects j ON j.id = co.project_id
    INNER JOIN dbo.Tiers t ON t.id = j.tiers_id
)
GO
/****** Object:  Table [dbo].[CollateralPropertyValues]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollateralPropertyValues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contract_collateral_id] [int] NOT NULL,
	[property_id] [int] NOT NULL,
	[value] [nvarchar](1000) NULL,
 CONSTRAINT [PK_CollateralPropertyValues] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccrualInterestLoanEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccrualInterestLoanEvents](
	[id] [int] NOT NULL,
	[interest] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[ActiveSavingContracts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ActiveSavingContracts]
(
  @date DATETIME,
  @branch_id INT
)
RETURNS TABLE AS RETURN
(
    WITH _info AS
    (
        SELECT sc.id
            , SUM(CASE WHEN se.code IN ('SVIE', 'SVRE') THEN 1 ELSE 0 END) opens
            , SUM(CASE WHEN se.code = 'SVCE' THEN 1 ELSE 0 END) closes
        FROM dbo.SavingContracts sc
        LEFT JOIN dbo.SavingEvents se ON se.contract_id = sc.id
        WHERE CAST(FLOOR(CAST(se.creation_date AS FLOAT)) AS DATETIME) <= @date AND se.deleted = 0 AND se.is_fired = 1        
        GROUP BY sc.id
    )
    , _balances AS
    (
        SELECT contract_id id, SUM(amount) balance
        FROM
        (
            SELECT contract_id
                , CASE
                    WHEN code IN ('SVIE','SVDE','SIPE','SCTE','SOCE','SVRE','SCIT') THEN ISNULL(amount, 0)
                    WHEN code IN ('SVWE','SDTE','SMFE','SOFE','SVAE','SVCE','SODE','SDIT') THEN ISNULL(-amount, 0) + ISNULL(-fees, 0)
                    WHEN code = 'SVLD' THEN ISNULL(amount, 0) - ISNULL(fees, 0)
                    ELSE 0
                END amount
            FROM dbo.SavingEvents
            WHERE deleted = 0
                AND is_fired = 1
                AND CAST(FLOOR(CAST(creation_date AS FLOAT)) AS DATETIME) <= @date
        ) t
        GROUP BY t.contract_id
    )
    
    SELECT i.id contract_id
        , sp.product_type
        , sp.currency_id
        , t.id tier_id
        , t.client_type_code
        , ISNULL(b.balance, 0) balance
        , CASE WHEN llsb.loan_id IS NULL THEN 0 ELSE 1 END is_compulsary
        , CASE WHEN llsb.loan_id IS NULL THEN 1 ELSE 0 END is_voluntary
    FROM _info i
    INNER JOIN dbo.SavingContracts sc ON sc.id = i.id
    LEFT JOIN _balances b ON b.id = i.id
    LEFT JOIN dbo.SavingProducts sp ON sp.id = sc.product_id
    LEFT JOIN dbo.Tiers t ON t.id = sc.tiers_id
    LEFT JOIN dbo.LoansLinkSavingsBook llsb ON llsb.savings_id = sc.id
    WHERE i.opens > i.closes AND (0 = @branch_id OR t.branch_id = @branch_id)
)
GO
/****** Object:  UserDefinedFunction [dbo].[AuditTrailEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AuditTrailEvents] (
  @from    DATETIME, 
  @to      DATETIME, 
  @user_id INT, 
  @branch_id INT,
  @list    NVARCHAR(MAX), 
  @include_deleted BIT)
RETURNS @tbl TABLE (
	event_type NVARCHAR(10) NOT NULL, 
	event_date DATETIME NOT NULL, 
	entry_date DATETIME NOT NULL, 
	user_name  NVARCHAR(50) NULL, 
	user_role  NVARCHAR(255) NULL, 
	[description] NVARCHAR(255) NULL, 
	deleted    BIT NOT NULL,
	branch_name NVARCHAR(255) NULL
)
AS
BEGIN
	DECLARE @temp TABLE (
		event_type  NVARCHAR(10) NOT NULL, 
		event_date  DATETIME NOT NULL, 
		entry_date  DATETIME NOT NULL, 
		user_id     INT NULL, 
		description NVARCHAR(255) NULL, 
		deleted     BIT NOT NULL,
		branch_name NVARCHAR(255) NULL)
	
	-- Loan events
	INSERT INTO @temp
	SELECT 
	  ce.event_type, 
	  ce.event_date, 
	  ce.entry_date, 
	  ce.user_id, 
	  c.contract_code + '-' + CONVERT(NVARCHAR(50), ce.id), 
	  ce.is_deleted,
	  b.name
	FROM dbo.ContractEvents AS ce
	LEFT JOIN dbo.Contracts AS c ON c.id = ce.contract_id
	LEFT JOIN dbo.Projects j ON j.id = c.project_id
	LEFT JOIN dbo.Tiers t ON t.id = j.tiers_id
	LEFT JOIN dbo.Branches b ON b.id = t.branch_id
	WHERE (CONVERT(date, ce.event_date) >= @from OR @from IS NULL)
	  AND (CONVERT(date, ce.event_date) <= @to OR @to IS NULL)
	  AND (ce.user_id = @user_id OR 0 = @user_id)
	  AND (ce.is_deleted = 0 OR 1 = @include_deleted)
	  AND (0 = @branch_id OR t.branch_id = @branch_id)
	
	-- Saving events
	INSERT INTO @temp
	SELECT 
	  se.code, 
	  se.creation_date, 
	  se.creation_date, 
	  se.user_id, 
	  sc.code + '-' + CONVERT(NVARCHAR(50), se.id), 
	  se.deleted,
	  b.name
	FROM dbo.SavingEvents AS se
	LEFT JOIN dbo.SavingContracts As sc ON sc.id = se.contract_id
	LEFT JOIN dbo.Tiers t ON t.id = sc.tiers_id
	LEFT JOIN dbo.Branches b ON b.id = t.branch_id
	WHERE (CONVERT(date, se.creation_date) >= @from OR @from IS NULL)
	  AND (CONVERT(date, se.creation_date) <= @to OR @to IS NULL)
	  AND (se.user_id = @user_id OR 0 = @user_id)	
	  AND (se.deleted = 0 OR 1 = @include_deleted)	
	  AND (0 = @branch_id OR t.branch_id = @branch_id)
	
	-- Funding line events
	INSERT INTO @temp
	SELECT 
	  'FLNE', 
	  fle.creation_date, 
	  fle.creation_date, 
	  user_id, 
	  fle.code, 
	  fle.deleted,
	  ''
	FROM dbo.FundingLineEvents AS fle
	WHERE (Convert(date, fle.creation_date) >= @from OR @from IS NULL)
	  AND (CONVERT(date, fle.creation_date) <= @to OR @to IS NULL)
	  AND (fle.deleted = 0 OR 1 = @include_deleted)
    AND (fle.user_id = @user_id OR 0 = @user_id)
	  AND 0 = @branch_id
	
	-- User activity events
	INSERT INTO @temp
	SELECT 
	  tue.event_code, 
	  tue.event_date, 
	  tue.event_date, 
	  tue.user_id, 
	  tue.event_description, 
	  0,
	  ''
	FROM
	(
		SELECT 
		  event_code, 
		  user_id, 
		  event_description, 
		  event_date
		FROM dbo.TraceUserLogs
	) AS tue
	WHERE (CONVERT(date, tue.event_date) >= @from OR @from IS NULL)
	AND (CONVERT(date, tue.event_date) <= @to OR @to IS NULL)
	AND (tue.user_id = @user_id OR 0 = @user_id)
	AND 0 = @branch_id
	
	
	-- Fixed Deposit Events
	INSERT INTO @temp
	SELECT 
	  fde.event_code, 
	  fde.creation_date, 
	  fde.creation_date, 
	  fde.user_name, 
	  
	  fde.description,
	  fde.deleted,
	  SUBSTRING(fde.contract_code, 1, CHARINDEX('/', fde.contract_code, 1)-1)
	FROM dbo.FixedDepositEvents AS fde
	WHERE (Convert(date, fde.creation_date) >= @from OR @from IS NULL)
	  AND (CONVERT(date, fde.creation_date) <= @to OR @to IS NULL)
	  AND (fde.deleted = 0 OR 1 = @include_deleted)
    AND (fde.user_name = @user_id OR 0 = @user_id)
	  AND 0 = @branch_id
	
	
	-- Current Account Events
	INSERT INTO @temp
	SELECT 
	  cae.event_code, 
	  cae.creation_date, 
	  cae.creation_date, 
	  cae.user_name, 
	  cae.description,
	  cae.deleted,
	  SUBSTRING(cae.contract_code, 1, CHARINDEX('/', cae.contract_code, 1)-1)
	FROM dbo.CurrentAccountEvents AS cae
	WHERE (Convert(date, cae.creation_date) >= @from OR @from IS NULL)
	  AND (CONVERT(date, cae.creation_date) <= @to OR @to IS NULL)
	  AND (cae.deleted = 0 OR 1 = @include_deleted)
    AND (cae.user_name = @user_id OR 0 = @user_id)
	  AND 0 = @branch_id
	
	INSERT INTO @tbl
	SELECT 
	  t.event_type, 
	  t.event_date, 
	  t.entry_date, 
	  u.first_name + ' ' + u.last_name, 
	  r.code, 
	  t.description, 
	  t.deleted,
	  t.branch_name
	FROM @temp AS t
	  LEFT JOIN dbo.Users AS u ON u.id = t.user_id
	  LEFT JOIN dbo.UserRole AS ur ON ur.user_id = u.id
	  LEFT JOIN dbo.Roles AS r ON r.id = ur.role_id
	WHERE EXISTS (SELECT 1 
	              FROM dbo.StringListToTable(@list) AS sl 
	              WHERE sl.string = t.event_type)
	
    RETURN
END
GO
/****** Object:  Table [dbo].[ProvisionEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProvisionEvents](
	[id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[rate] [float] NOT NULL,
	[overdue_days] [int] NOT NULL,
 CONSTRAINT [PK_ProvisionEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanPenaltyAccrualEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanPenaltyAccrualEvents](
	[id] [int] NOT NULL,
	[penalty] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[LoanEntryFees]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[LoanEntryFees]
(
	@from DATETIME
	, @to DATETIME
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
	SELECT co.id AS contract_id, SUM(lee.fee) AS fees
	FROM Contracts co
	INNER JOIN Credit cr ON cr.id = co.id
	INNER JOIN Projects pr ON pr.id = co.project_id
	INNER JOIN Tiers ti ON ti.id = pr.tiers_id
	INNER JOIN ContractEvents ce ON ce.contract_id = co.id
	INNER JOIN LoanEntryFeeEvents lee ON lee.disbursement_event_id = ce.id
	WHERE ce.event_date BETWEEN @from AND @to
		AND	(0 = @branch_id OR ti.branch_id = @branch_id)
		AND ce.event_date BETWEEN @from AND @to
		AND ce.is_deleted = 0
		AND (@subordinate_id = 0 and cr.loanofficer_id in
		(		
			SELECT @user_id
			UNION ALL
			SELECT subordinate_id
			FROM dbo.UsersSubordinates
			WHERE user_id = @user_id) OR cr.loanofficer_id = @subordinate_id
		)
	GROUP BY co.id	
)
GO
/****** Object:  Table [dbo].[OverdueEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OverdueEvents](
	[id] [int] NOT NULL,
	[olb] [money] NOT NULL,
	[overdue_days] [int] NOT NULL,
	[overdue_principal] [money] NULL,
 CONSTRAINT [PK_OverdueEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[next_contractEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[next_contractEvents]
(@contractEvents int)
RETURNS int
AS
BEGIN
DECLARE @contractId int;
DECLARE @event_date DATETIME;
DECLARE @next_contractEvents INT;
SET @contractId = (SELECT contract_id FROM [ContractEvents] WHERE id = @contractEvents);
SET @event_date = (SELECT event_date FROM [ContractEvents] WHERE id = @contractEvents);
SET @next_contractEvents = (SELECT TOP 1 id 
							FROM [ContractEvents] 
							WHERE contract_id = @contractId AND event_date > @event_date);
return @next_contractEvents;
END
GO
/****** Object:  UserDefinedFunction [dbo].[Movements]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Movements](@FROM DATETIME
	, @to DATETIME
	, @source_currency INT
	, @target_currency INT
	, @contract_id INT
	, @branch_id INT
	, @mode INT
)
RETURNS TABLE AS RETURN
(
	WITH _mov AS
	(
		SELECT lam.id
			, lam.contract_id
			, lam.debit_account_number_id
			, lam.credit_account_number_id
				, CASE
					WHEN @target_currency = currency_id THEN amount
					ELSE CAST(ROUND(lam.amount / lam.exchange_rate, 0) AS MONEY)
				END amount
			, lam.transaction_date
			, ce.comment
			, 0 contract_type
			, lam.event_id
		FROM dbo.LoanAccountingMovements lam
		LEFT JOIN dbo.ContractEvents ce ON ce.id = lam.event_id
		WHERE (currency_id = @source_currency OR 0 = @source_currency)
			AND (CAST(ROUND(CAST(lam.transaction_date AS FLOAT), 0) AS DATETIME) BETWEEN @from AND @to)
			AND (0 = @contract_id OR lam.contract_id = @contract_id)
			AND (0 = @branch_id OR lam.branch_id = @branch_id)
			AND closure_id > 0
			AND (@mode & 1 > 0)
		
		UNION ALL
		
		SELECT sam.id
			, sam.contract_id
			, sam.debit_account_number_id
			, sam.credit_account_number_id
			, CASE
				WHEN @target_currency = sam.currency_id THEN sam.amount
				ELSE CAST(ROUND(sam.amount / exchange_rate, 0) AS MONEY)
			END amount
			, sam.transaction_date
			, se.description comment
			, 1 contract_type
			, sam.event_id
		FROM dbo.SavingsAccountingMovements sam
		LEFT JOIN dbo.SavingEvents se ON se.id = sam.event_id
		WHERE (currency_id = @source_currency OR 0 = @source_currency)
			AND (CAST(ROUND(CAST(sam.transaction_date AS FLOAT), 0) AS DATETIME) BETWEEN @from AND @to)
			AND (0 = @contract_id OR sam.contract_id = @contract_id)
			AND (0 = @branch_id OR sam.branch_id = @branch_id)
			AND (@mode & 2 > 0)
			AND closure_id > 0
		
		UNION ALL
		
		SELECT mam.id
			, se.contract_id contract_id
			, debit_account_number_id
			, credit_account_number_id
			, CASE
				WHEN @target_currency = currency_id THEN mam.amount
				ELSE CAST(ROUND(mam.amount / exchange_rate, 0) AS MONEY)
			END amount
			, transaction_date
			, mam.description comment
			, 1 contract_type
			, mam.event_id
		FROM dbo.ManualAccountingMovements mam
		LEFT JOIN SavingEvents se ON mam.event_id = se.id
		WHERE (currency_id = @source_currency OR 0 = @source_currency)
			AND (CAST(FLOOR(CAST(transaction_date AS FLOAT)) AS DATETIME) BETWEEN @from AND @to)
			AND (0 = @contract_id)
			AND (0 = @branch_id OR branch_id = @branch_id)
			AND (@mode & 4 > 0)
			AND closure_id > 0
	)
	SELECT id transaction_id
		, contract_id
		, debit_account_number_id account_id
		, transaction_date
		, amount debit
		, 0 credit
		, comment
		, contract_type --0: Loan contract, 1: Saving contract
		, event_id
	FROM _mov
	
	UNION ALL
	
	SELECT id
		, contract_id
		, credit_account_number_id account_id
		, transaction_date
		, 0 debit
		, amount credit
		, comment
		, contract_type --0: Loan contract, 1: Saving contract
		, event_id
	FROM _mov
)
GO
/****** Object:  Table [dbo].[LoanDisbursmentEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanDisbursmentEvents](
	[id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[fees] [money] NOT NULL,
	[interest] [money] NOT NULL,
	[payment_method_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Guarantors]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Guarantors]()
RETURNS TABLE
AS
RETURN
(
    SELECT tiers_id, contract_id, guarantee_amount, guarantee_desc FROM dbo.LinkGuarantorCredit
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetTrueLoanCycle]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[GetTrueLoanCycle]
(@clientId int)
RETURNS int
AS
BEGIN
DECLARE @loanCycleGL INT
DECLARE @loanCycleIL INT
SELECT @loanCycleIL = COUNT(tiers.id)
FROM [Tiers] INNER JOIN
	[Projects] ON projects.tiers_id = tiers.id inner join
	contracts on contracts.project_id = projects.id inner join
	credit on credit.id = contracts.id
WHERE tiers.id = @clientId and disbursed=1
SELECT @loanCycleGL = COUNT(tiers.id)
FROM tiers INNER JOIN
	 projects ON projects.[tiers_id] = tiers.id INNER JOIN
	 contracts c1 ON projects.id = c1.[project_id] inner join
	 credit on credit.id = c1.id
WHERE disbursed=1 and @clientId IN (SELECT person_id
				from [PersonGroupBelonging] pgb1
				WHERE pgb1.[group_id] = tiers.id AND
				      ((pgb1.joined_date <= c1.start_date) AND (ISNULL(pgb1.left_date,c1.close_date) >= c1.close_date))	  
				)
return @loanCycleGL+@loanCycleIL
END
GO
/****** Object:  UserDefinedFunction [dbo].[FilteredCreditContracts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FilteredCreditContracts](@user_id INT, @subordinate_id INT, @branch_id INT)
RETURNS TABLE AS RETURN
(
	WITH _users AS
	(
		SELECT @user_id user_id
		WHERE @subordinate_id = 0 OR @subordinate_id = @user_id
		UNION ALL
		SELECT id user_id
		FROM dbo.Users
		WHERE 0 = @user_id
		UNION ALL
		SELECT subordinate_id
		FROM dbo.UsersSubordinates
		WHERE user_id = @user_id AND (0 = @subordinate_id OR subordinate_id = @subordinate_id)
	)
	, _branches AS
	(
		SELECT id branch_id
		FROM dbo.Branches
		WHERE @user_id = 0 AND @branch_id = 0
		UNION ALL
		SELECT id
		FROM dbo.Branches
		WHERE @user_id = 0 AND id = @branch_id
		UNION ALL
		SELECT branch_id
		FROM dbo.UsersBranches
		WHERE user_id = @user_id AND @branch_id = 0
		UNION ALL
		SELECT branch_id
		FROM dbo.UsersBranches
		WHERE user_id = @user_id AND branch_id = @branch_id
	)
	SELECT c.id
	FROM dbo.Contracts c
	INNER JOIN dbo.Credit cr ON cr.id = c.id
	INNER JOIN dbo.Projects j ON j.id = c.project_id
	INNER JOIN dbo.Tiers t ON t.id = j.tiers_id
	INNER JOIN _users u ON u.user_id = cr.loanofficer_id
	INNER JOIN _branches b ON b.branch_id = t.branch_id
)
GO
/****** Object:  StoredProcedure [dbo].[ExportAccounting_Transactions]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportAccounting_Transactions]
AS 
    BEGIN
        SET NOCOUNT ON
     
        CREATE TABLE #ExportList(
              date DATETIME,
              elementary_id INT,
              [type] NVARCHAR(4),
              event_code NVARCHAR(4),
              contract_code NVARCHAR(100),
              amount MONEY,
              fundingLine NVARCHAR(100),
              currency_name NVARCHAR(50),
              currency_id INT,
              exchange_rate FLOAT,
              debit_local_account_number NVARCHAR(100),
              credit_local_account_number NVARCHAR(100),
              name NVARCHAR(500))
        
        -- loan
        INSERT  INTO #ExportList(
                  date,
                  elementary_id,
                  [type],
                  event_code,
                  contract_code,
                  amount,
                  fundingLine,
                  currency_name,
                  currency_id,
                  exchange_rate,
                  debit_local_account_number,
                  credit_local_account_number,
                  name)
                SELECT  cab.transaction_date AS date,
                        cab.id AS elementary_id,
                        'L',
                        ce.event_type,
                        Contracts.contract_code,
                        cab.amount,
                        ISNULL(FundingLines.name, '-') AS fundingLine,
                        curr.name AS currency_name,
                        cab.id AS currency_id,
                        cab.exchange_rate,
                        adeb.account_number AS debit_local_account_number,
                        acred.account_number AS credit_local_account_number,
                        ISNULL(ISNULL(l_group.name,
                                      l_person.first_name + ' '
                                      + l_person.last_name), '-') AS name
                FROM    LoanAccountingMovements cab
                        INNER JOIN ChartOfAccounts adeb ON adeb.id = cab.debit_account_number_id
                        INNER JOIN ChartOfAccounts acred ON acred.id = cab.credit_account_number_id
                        INNER JOIN Currencies curr ON cab.currency_id = curr.id
                        LEFT JOIN ContractEvents ce ON cab.event_id = ce.id
                        LEFT JOIN Contracts ON Contracts.id = ce.contract_id
                        LEFT JOIN Credit ON Contracts.id = Credit.id
                        LEFT JOIN FundingLines ON Credit.fundingLine_id = FundingLines.id
                        LEFT JOIN Projects ON Projects.id = Contracts.project_id
                        LEFT JOIN Tiers l_tiers ON Projects.tiers_id = l_tiers.id
                        LEFT JOIN Groups l_group ON l_tiers.id = l_group.id
                        LEFT JOIN Persons l_person ON l_tiers.id = l_person.id
                WHERE   cab.is_exported = 0
                AND closure_id > 0
                ORDER BY cab.id,
                        cab.transaction_date
	    -- Savings
        INSERT  INTO #ExportList(
                  date,
                  elementary_id,
                  [type],
                  event_code,
                  contract_code,
                  amount,
                  fundingLine,
                  currency_name,
                  currency_id,
                  exchange_rate,
                  debit_local_account_number,
                  credit_local_account_number,
                  name)
                SELECT  sab.transaction_date AS date,
                        sab.Id AS elementary_id,
                        'S',
                        se.code AS event_code,
                        sc.code AS contract_code,
                        sab.amount,
                        '-' AS fundingLine,
                        curr.name AS currency_name,
                        sab.id AS currency_id,
                        sab.exchange_rate,
                        adeb.account_number AS debit_local_account_number,
    acred.account_number AS credit_local_account_number,
                        ISNULL(ISNULL(s_person.first_name + ' '
                                      + s_person.last_name, s_group.name), ' ') AS Name
                FROM    SavingsAccountingMovements sab
                        INNER JOIN ChartOfAccounts adeb ON adeb.id = sab.debit_account_number_id
                        INNER JOIN ChartOfAccounts acred ON acred.id = sab.credit_account_number_id
                        INNER JOIN Currencies curr ON sab.currency_id = curr.id
                        LEFT JOIN SavingEvents se ON se.id = sab.event_id
                        LEFT JOIN SavingContracts sc ON sc.id = se.contract_id
                        LEFT JOIN Tiers l_tiers ON sc.tiers_id = l_tiers.id
                        LEFT JOIN Tiers s_tiers ON sc.tiers_id = s_tiers.id
                        LEFT JOIN Groups s_group ON s_tiers.id = s_group.id
                        LEFT JOIN Persons s_person ON s_tiers.id = s_person.id
                WHERE   ( sab.is_exported = 0 )
                AND closure_id > 0
                ORDER BY sab.id,
                        sab.transaction_date
        -- manual transactions
        INSERT  INTO #ExportList (
                  date,
                  elementary_id,
                  [type],
                  event_code,
                  contract_code,
                  amount,
                  fundingLine,
                  currency_name,
                  currency_id,
                  exchange_rate,
                  debit_local_account_number,
                  credit_local_account_number,
                  name)
                SELECT  mab.transaction_date AS date,
                        mab.Id AS elementary_id,
                        'M',
                        '-' AS event_code,
                        mab.description AS contract_code,
                        mab.amount,
                        '-' AS fundingLine,
                        curr.name AS currency_name,
                        mab.id AS currency_id,
                        mab.exchange_rate,
                        adeb.account_number AS debit_local_account_number,
                        acred.account_number AS credit_local_account_number,
                        '-' AS Name
                FROM    dbo.ManualAccountingMovements mab
                        INNER JOIN ChartOfAccounts adeb ON adeb.id = mab.debit_account_number_id
                        INNER JOIN ChartOfAccounts acred ON acred.id = mab.credit_account_number_id
                        INNER JOIN Currencies curr ON mab.currency_id = curr.id
                WHERE   mab.is_exported = 0
                AND closure_id > 0
                ORDER BY mab.id, mab.transaction_date
        
        SELECT  
                elementary_id,
                [type],
                date,
                event_code,
                contract_code,
                amount,
                fundingLine,
                currency_name,
                currency_id,
                exchange_rate,
                debit_local_account_number,
                credit_local_account_number,
                name
        FROM    #ExportList
        
        DROP TABLE #ExportList
    END
GO
/****** Object:  StoredProcedure [dbo].[ExportAccounting_Transaction_with_dates]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportAccounting_Transaction_with_dates]
    @begin_date DATETIME ,
    @end_date DATETIME
AS 
    BEGIN
        SET NOCOUNT ON
     
        CREATE TABLE #ExportList
            (
              date DATETIME ,
              elementary_id INT ,
              [type] NVARCHAR(4) ,
              event_code NVARCHAR(4) ,
              contract_code NVARCHAR(100) ,
              amount MONEY ,
              fundingLine NVARCHAR(100) ,
              currency_name NVARCHAR(50) ,
              currency_id INT ,
              exchange_rate FLOAT ,
              debit_local_account_number NVARCHAR(100) ,
              credit_local_account_number NVARCHAR(100) ,
              name NVARCHAR(500)
            )
        
        -- loan
        INSERT  INTO #ExportList
                ( date ,
                  elementary_id ,
                  [type] ,
                  event_code ,
                  contract_code ,
                  amount ,
                  fundingLine ,
                  currency_name ,
                  currency_id ,
                  exchange_rate ,
                  debit_local_account_number ,
                  credit_local_account_number ,
                  name
                )
                SELECT  cab.transaction_date AS date ,
                        cab.id AS elementary_id ,
                        'L' ,
                        ce.event_type ,
                        Contracts.contract_code ,
                        cab.amount ,
                        ISNULL(FundingLines.name, '-') AS fundingLine ,
                        curr.name AS currency_name ,
                        cab.id AS currency_id ,
                        cab.exchange_rate ,
                        adeb.account_number AS debit_local_account_number ,
                        acred.account_number AS credit_local_account_number ,
                        ISNULL(ISNULL(l_group.name,
                                      l_person.first_name + ' '
                                      + l_person.last_name), '-') AS name
                FROM    LoanAccountingMovements cab
                        INNER JOIN ChartOfAccounts adeb ON adeb.id = cab.debit_account_number_id
                        INNER JOIN ChartOfAccounts acred ON acred.id = cab.credit_account_number_id
                        INNER JOIN Currencies curr ON cab.currency_id = curr.id
                        LEFT JOIN ContractEvents ce ON cab.event_id = ce.id
                        LEFT JOIN Contracts ON Contracts.id = ce.contract_id
                        LEFT JOIN Credit ON Contracts.id = Credit.id
                        LEFT JOIN FundingLines ON Credit.fundingLine_id = FundingLines.id
                        LEFT JOIN Projects ON Projects.id = Contracts.project_id
                        LEFT JOIN Tiers l_tiers ON Projects.tiers_id = l_tiers.id
                        LEFT JOIN Groups l_group ON l_tiers.id = l_group.id
                        LEFT JOIN Persons l_person ON l_tiers.id = l_person.id
                WHERE   cab.is_exported = 0
                        AND cab.transaction_date BETWEEN @begin_date
                                                 AND     @end_date
                        AND closure_id > 0
                ORDER BY cab.id ,
                        cab.transaction_date
	    -- Savings
        INSERT  INTO #ExportList
                ( date ,
                  elementary_id ,
                  [type] ,
                  event_code ,
                  contract_code ,
                  amount ,
                  fundingLine ,
                  currency_name ,
                  currency_id ,
                  exchange_rate ,
                  debit_local_account_number ,
                  credit_local_account_number ,
                  name
                )
                SELECT  sab.transaction_date AS date ,
                        sab.Id AS elementary_id ,
                        'S' ,
                        se.code AS event_code ,
  sc.code AS contract_code ,
                        sab.amount ,
                        '-' AS fundingLine ,
                        curr.name AS currency_name ,
                        sab.id AS currency_id ,
                        sab.exchange_rate ,
                        adeb.account_number AS debit_local_account_number ,
                        acred.account_number AS credit_local_account_number ,
                        ISNULL(ISNULL(s_person.first_name + ' '
                                      + s_person.last_name, s_group.name), ' ') AS Name
                FROM    SavingsAccountingMovements sab
                        INNER JOIN ChartOfAccounts adeb ON adeb.id = sab.debit_account_number_id
                        INNER JOIN ChartOfAccounts acred ON acred.id = sab.credit_account_number_id
                        INNER JOIN Currencies curr ON sab.currency_id = curr.id
                        LEFT JOIN SavingEvents se ON se.id = sab.event_id
                        LEFT JOIN SavingContracts sc ON sc.id = se.contract_id
                        LEFT JOIN Tiers l_tiers ON sc.tiers_id = l_tiers.id
                        LEFT JOIN Tiers s_tiers ON sc.tiers_id = s_tiers.id
                        LEFT JOIN Groups s_group ON s_tiers.id = s_group.id
                        LEFT JOIN Persons s_person ON s_tiers.id = s_person.id
                WHERE   ( sab.is_exported = 0 )
                        AND closure_id > 0
                        AND sab.transaction_date BETWEEN @begin_date
                                                 AND     @end_date
                ORDER BY sab.id ,
                        sab.transaction_date
        -- manual transactions
        INSERT  INTO #ExportList
                ( date ,
                  elementary_id ,
                  [type] ,
                  event_code ,
                  contract_code ,
                  amount ,
                  fundingLine ,
                  currency_name ,
                  currency_id ,
                  exchange_rate ,
                  debit_local_account_number ,
                  credit_local_account_number ,
                  name
                )
                SELECT  mab.transaction_date AS date ,
                        mab.Id AS elementary_id ,
                        'M' ,
                        '-' AS event_code ,
                        mab.description AS contract_code ,
                        mab.amount ,
                        '-' AS fundingLine ,
                        curr.name AS currency_name ,
                        mab.id AS currency_id ,
                        mab.exchange_rate ,
                        adeb.account_number AS debit_local_account_number ,
                        acred.account_number AS credit_local_account_number ,
                        '-' AS Name
                FROM    dbo.ManualAccountingMovements mab
                        INNER JOIN ChartOfAccounts adeb ON adeb.id = mab.debit_account_number_id
                        INNER JOIN ChartOfAccounts acred ON acred.id = mab.credit_account_number_id
                        INNER JOIN Currencies curr ON mab.currency_id = curr.id
                WHERE   mab.is_exported = 0
                        AND closure_id > 0
                        AND mab.transaction_date BETWEEN @begin_date
                                                 AND     @end_date
                ORDER BY mab.id ,
                        mab.transaction_date
        
        SELECT  elementary_id ,
                [type] ,
                date ,
                event_code ,
                contract_code ,
                amount ,
                fundingLine ,
                currency_name ,
                currency_id ,
                exchange_rate ,
                debit_local_account_number ,
                credit_local_account_number ,
                name
        FROM    #ExportList
        
  DROP TABLE #ExportList
    END
GO
/****** Object:  Table [dbo].[Installments]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Installments](
	[expected_date] [datetime] NOT NULL,
	[interest_repayment] [money] NOT NULL,
	[capital_repayment] [money] NOT NULL,
	[contract_id] [int] NOT NULL,
	[number] [int] NOT NULL,
	[paid_interest] [money] NOT NULL,
	[paid_capital] [money] NOT NULL,
	[fees_unpaid] [money] NOT NULL,
	[paid_date] [datetime] NULL,
	[paid_fees] [money] NOT NULL,
	[comment] [nvarchar](50) NULL,
	[pending] [bit] NOT NULL,
	[start_date] [datetime] NOT NULL,
	[olb] [money] NOT NULL,
	[commission] [money] NOT NULL,
	[paid_commission] [money] NOT NULL,
 CONSTRAINT [PK_Installments] PRIMARY KEY CLUSTERED 
(
	[contract_id] ASC,
	[number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstallmentHistory]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstallmentHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contract_id] [int] NOT NULL,
	[event_id] [int] NOT NULL,
	[number] [int] NOT NULL,
	[expected_date] [datetime] NOT NULL,
	[capital_repayment] [money] NOT NULL,
	[interest_repayment] [money] NOT NULL,
	[paid_interest] [money] NOT NULL,
	[paid_capital] [money] NOT NULL,
	[paid_fees] [money] NOT NULL,
	[fees_unpaid] [money] NOT NULL,
	[paid_date] [datetime] NULL,
	[delete_date] [datetime] NULL,
	[comment] [nvarchar](50) NULL,
	[pending] [bit] NOT NULL,
	[start_date] [datetime] NOT NULL,
	[olb] [money] NOT NULL,
	[commission] [money] NOT NULL,
	[paid_commission] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[GetListMembersGroupLoan]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetListMembersGroupLoan]
(   
    @contract_id int
)
RETURNS TABLE 
AS
RETURN 
(
     SELECT first_name, last_name, joined_date,left_date, lsa.amount as [loan_share_amount], pgb.person_id
	 FROM contracts INNER JOIN
	 credit ON credit.id = contracts.id INNER JOIN
	 projects ON projects.id = contracts.[project_id] INNER JOIN
	 tiers ON tiers.id = projects.[tiers_id] INNER JOIN
	 groups ON groups.id = tiers.id INNER JOIN
	 [PersonGroupBelonging] AS pgb ON pgb.[group_id] = groups.id INNER JOIN
	 [Persons] ON persons.id = pgb.[person_id]
	LEFT JOIN dbo.LoanShareAmounts AS lsa ON pgb.group_id = lsa.group_id AND pgb.person_id = lsa.person_id AND lsa.contract_id = @contract_id
	  WHERE contracts.id = @contract_id AND
	  (([closed] =0 AND [currently_in] = 1) OR
      ((closed = 1) AND (joined_date <= contracts.start_date) AND (ISNULL(left_date, GETDATE()) >= close_date))) 
)
GO
/****** Object:  StoredProcedure [dbo].[GetAccountBookings]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAccountBookings](
      @beginDate DATETIME,
      @endDate DATETIME,
      @account_id INT,
      @currency_id INT,
      @is_exported BIT,
      @branch_id INT)
AS 
    BEGIN
        SET NOCOUNT ON
        CREATE TABLE #ListOfBookings(
          date DATETIME,
          amount MONEY,
          is_exported BIT,
          event_code NVARCHAR(4),
          contract_code NVARCHAR(100),
          debit_local_account_number  NVARCHAR(100),
          credit_local_account_number NVARCHAR(100),
          exchange_rate FLOAT)
        -- Loan transactions  
        
        INSERT INTO #ListOfBookings
                ( date ,
                  amount,
                  is_exported,
                  event_code ,
                  contract_code ,
                  debit_local_account_number ,
                  credit_local_account_number ,
                  exchange_rate
                )         
        SELECT  transaction_date AS date,
                cab.amount,
                cab.is_exported,
                ce.event_type AS event_code,
                c.contract_code AS contract_code,
                chartDebit.account_number AS debit_local_account_number,
                chartCredit.account_number AS credit_local_account_number,
                cab.exchange_rate
        FROM    LoanAccountingMovements cab
                INNER JOIN ChartOfAccounts chartDebit ON chartDebit.id = cab.debit_account_number_id
                INNER JOIN ChartOfAccounts chartCredit ON chartCredit.id = cab.credit_account_number_id
                LEFT JOIN Contracts c ON cab.contract_id = c.id
                LEFT JOIN ContractEvents ce ON cab.event_id = ce.id
        WHERE   cab.transaction_date >= @beginDate
                AND cab.transaction_date <= @endDate
                AND closure_id > 0
                AND ( debit_account_number_id = @account_id
                      OR credit_account_number_id = @account_id
                    )
                AND ( cab.currency_id = @currency_id
                      OR @currency_id = 0
                    )
                AND ( cab.branch_id = @branch_id
                      OR @branch_id = 0
                    )    
                AND ( cab.is_exported = @is_exported
                      OR @is_exported IS NULL
                    )
        ORDER BY cab.id
        --Savings transactions
        INSERT INTO #ListOfBookings
                ( date ,
                  amount ,
                  is_exported,
                  event_code ,
                  contract_code ,
                  debit_local_account_number ,
                  credit_local_account_number ,
                  exchange_rate
                )         
        SELECT  transaction_date AS date,
                sab.amount,
                sab.is_exported,
                se.code AS event_code,
                sc.code AS contract_code,
                chartDebit.account_number AS debit_local_account_number,
                chartCredit.account_number AS credit_local_account_number,
                sab.exchange_rate
        FROM    dbo.SavingsAccountingMovements sab
                INNER JOIN ChartOfAccounts chartDebit ON chartDebit.id = sab.debit_account_number_id
                INNER JOIN ChartOfAccounts chartCredit ON chartCredit.id = sab.credit_account_number_id
                LEFT JOIN SavingContracts sc ON sc.id = sab.id
                LEFT JOIN SavingEvents se ON se.id = sab.event_id
        WHERE   sab.transaction_date >= @beginDate
                AND sab.transaction_date <= @endDate
                AND closure_id > 0
                AND ( debit_account_number_id = @account_id
                      OR credit_account_number_id = @account_id
                    )
                AND ( sab.currency_id = @currency_id
                      OR @currency_id = 0
                    )
                AND ( sab.branch_id = @branch_id
                      OR @branch_id = 0
                    )    
     AND ( sab.is_exported = @is_exported
                      OR @is_exported IS NULL
                    )
        ORDER BY sab.id
        
        INSERT INTO #ListOfBookings
                ( date ,
                  amount ,
   is_exported,
                  event_code ,
                  contract_code ,
                  debit_local_account_number ,
                  credit_local_account_number ,
                  exchange_rate
                )         
        SELECT  transaction_date AS date,
                mab.amount,
                mab.is_exported,
                '-' AS event_code,
                mab.description AS contract_code,
                chartDebit.account_number AS debit_local_account_number,
                chartCredit.account_number AS credit_local_account_number,
                mab.exchange_rate
        FROM    dbo.ManualAccountingMovements mab
                INNER JOIN ChartOfAccounts chartDebit ON chartDebit.id = mab.debit_account_number_id
                INNER JOIN ChartOfAccounts chartCredit ON chartCredit.id = mab.credit_account_number_id                
        WHERE   mab.transaction_date >= @beginDate
                AND mab.transaction_date <= @endDate
                AND closure_id > 0
                AND ( debit_account_number_id = @account_id
                      OR credit_account_number_id = @account_id
                    )
                AND ( mab.currency_id = @currency_id
                      OR @currency_id = 0
                    )
                AND ( mab.currency_id = @branch_id
                      OR @branch_id = 0
                    )    
                AND ( mab.is_exported = @is_exported
                      OR @is_exported IS NULL
                    )
        ORDER BY mab.id
        
        SELECT  
          date,
          amount,
          is_exported,
          event_code,
          contract_code,
          debit_local_account_number ,
          credit_local_account_number ,
          exchange_rate
        FROM #ListOfBookings
        
        DROP TABLE #ListOfBookings
    END
GO
/****** Object:  UserDefinedFunction [dbo].[GetDisbursementDate]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetDisbursementDate] (@contract_id INT)
RETURNS DATETIME
AS
BEGIN
	DECLARE @retval DATETIME
	SELECT @retval = event_date
	FROM dbo.ContractEvents
	WHERE event_type = 'LODE' AND contract_id = @contract_id AND is_deleted = 0
	RETURN @retval
END
GO
/****** Object:  UserDefinedFunction [dbo].[SavingPenalties_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingPenalties_MC]
(
	@pFrom DATETIME,
	@pTo DATETIME,
	@pWithdrawedIn INT,
	@pDisplayIn INT
) RETURNS TABLE
AS RETURN
(
	SELECT p.contract_id
	, p.event_id
	, p.event_date
	, p.event_code
	, p.amount * dbo.GetXR(p.currency_id,@pDisplayIn,p.event_date) AS amount	
	, p.amount_wo_vat * dbo.GetXR(p.currency_id,@pDisplayIn,p.event_date) AS amount_wo_vat
	, p.amount_vat * dbo.GetXR(p.currency_id,@pDisplayIn,p.event_date) AS amount_vat
	, p.product_type
	FROM SavingPenalties(@pFrom,@pTo) p
	WHERE p.currency_id = @pWithdrawedIn OR 0 = @pWithdrawedIn
)
GO
/****** Object:  UserDefinedFunction [dbo].[SavingDeposits_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingDeposits_MC]
(
@pFrom DATETIME,
@pTo DATETIME,
@pWithdrawedIn INT,
@pDisplayIn INT
) RETURNS TABLE
AS RETURN
(
 SELECT d.contract_id,
  d.event_id,
  d.event_date,
  d.amount * dbo.GetXR(d.currency_id,@pDisplayIn,d.event_date) AS amount,
  d.method,
  d.product_type
FROM SavingDeposits(@pFrom,@pTo) d
WHERE d.currency_id = @pWithdrawedIn OR 0 = @pWithdrawedIn
)
GO
/****** Object:  UserDefinedFunction [dbo].[SavingCommissions_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingCommissions_MC]
(
	@pFrom DATETIME,
	@pTo DATETIME,
	@pWithdrawedIn INT,
	@pDisplayIn INT
) RETURNS TABLE
AS RETURN
(
	SELECT c.contract_id
	, c.event_id
	, c.event_date
	, c.event_code
	, c.amount * dbo.GetXR(c.currency_id,@pDisplayIn,c.event_date) AS amount
	, c.amount_wo_vat * dbo.GetXR(c.currency_id,@pDisplayIn,c.event_date) AS amount_wo_vat
	, c.amount_vat * dbo.GetXR(c.currency_id,@pDisplayIn,c.event_date) AS amount_vat
	, c.product_type
	FROM SavingCommissions(@pFrom,@pTo) c
	WHERE c.currency_id = @pWithdrawedIn OR 0 = @pWithdrawedIn
)
GO
/****** Object:  Table [dbo].[ReschedulingOfALoanEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReschedulingOfALoanEvents](
	[id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[interest] [money] NOT NULL,
	[nb_of_maturity] [int] NOT NULL,
	[grace_period] [int] NOT NULL,
	[charge_interest_during_grace_period] [bit] NOT NULL,
	[previous_interest_rate] [money] NOT NULL,
	[preferred_first_installment_date] [datetime] NOT NULL,
 CONSTRAINT [PK_ReschedulingOfALoanEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RepaymentEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RepaymentEvents](
	[id] [int] NOT NULL,
	[past_due_days] [int] NOT NULL,
	[principal] [money] NOT NULL,
	[interests] [money] NOT NULL,
	[installment_number] [int] NOT NULL,
	[commissions] [money] NOT NULL,
	[penalties] [money] NOT NULL,
	[payment_method_id] [int] NULL,
	[calculated_penalties] [money] NOT NULL,
	[written_off_penalties] [money] NOT NULL,
	[unpaid_penalties] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Rep_Committee_Appraisal]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Committee_Appraisal]
@contract_id int
AS BEGIN
SELECT 
contracts.id as contract_id,
contracts.status,
credit_commitee_comment,
credit_commitee_code,
credit_commitee_date,
credit.amount,
ISNULL(groups.name, ISNULL(persons.first_name + ' ' + persons.last_name, corporates.name)) as client_name,
tiers.address,
tiers.city,
districts.name as district,
packages.name as product,
users.first_name + ' ' + users.last_name as loan_officer,
credit.interest_rate as interest_rate,
credit.nb_of_installment,
credit.grace_period,
currencies.name as currency,
DATEDIFF(m, contracts.start_date, contracts.close_date) as loan_length
FROM Corporates RIGHT OUTER JOIN
Persons RIGHT OUTER JOIN
Groups RIGHT OUTER JOIN
currencies 
inner join packages on currencies.id = packages.currency_id
inner join credit on credit.package_id = packages.id
inner join users on credit.loanofficer_id = users.id
inner join contracts on contracts.id = credit.id 
inner join projects on contracts.project_id = projects.id
inner join tiers on projects.tiers_id = tiers.id on groups.id = tiers.id on persons.id = tiers.id on corporates.id = tiers.id
inner join districts on districts.id = tiers.district_id
where contracts.id = @contract_id
END
GO
/****** Object:  Table [dbo].[TrancheEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrancheEvents](
	[id] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[maturity] [int] NOT NULL,
	[start_date] [datetime] NOT NULL,
	[interest_rate] [money] NOT NULL,
	[started_from_installment] [int] NULL,
	[applied_new_interest] [bit] NOT NULL,
	[first_repayment_date] [date] NOT NULL,
	[grace_period] [int] NOT NULL,
	[payment_method_id] [int] NULL,
 CONSTRAINT [PK_TrancheEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[SavingWithdrawals_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingWithdrawals_MC]
(
@pFrom DATETIME,
@pTo DATETIME,
@pWithdrawedIn INT,
@pDisplayIn INT
) RETURNS TABLE
AS RETURN
(
 SELECT w.contract_id,
  w.event_id,
  w.event_date,
  w.amount * dbo.GetXR(w.currency_id,@pDisplayIn,w.event_date) AS amount,
  w.product_type
FROM SavingWithdrawals(@pFrom,@pTo) w
WHERE w.currency_id = @pWithdrawedIn OR 0 = @pWithdrawedIn
)
GO
/****** Object:  UserDefinedFunction [dbo].[SavingTransfers_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SavingTransfers_MC]
(
@pFrom DATETIME,
@pTo DATETIME,
@pWithdrawedIn INT,
@pDisplayIn INT
) RETURNS TABLE
AS RETURN
(
 SELECT t.from_contract_id,
  t.to_contract_id,
  t.event_id,
  t.event_date,
  t.amount * dbo.GetXR(t.currency_id,@pDisplayIn,t.event_date) AS amount,
  t.product_type
FROM SavingTransfers(@pFrom,@pTo) t
WHERE t.currency_id = @pWithdrawedIn OR 0 = @pWithdrawedIn
)
GO
/****** Object:  Table [dbo].[WriteOffEvents]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WriteOffEvents](
	[id] [int] NOT NULL,
	[olb] [money] NOT NULL,
	[accrued_interests] [money] NOT NULL,
	[accrued_penalties] [money] NOT NULL,
	[past_due_days] [int] NOT NULL,
	[overdue_principal] [money] NOT NULL,
	[comment] [nvarchar](255) NULL,
	[write_off_method] [int] NULL,
 CONSTRAINT [PK_WriteOffEvents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[WrittenOffLoans]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[WrittenOffLoans](@from DATETIME, @to DATETIME, @disbursed_in INT, @display_in INT, @user_id INT, @subordinate_id INT, @branch_id INT)
RETURNS TABLE AS RETURN
(
	WITH _contracts AS
	(
		SELECT c.id contract_id, cr.amount + ISNULL(SUM(te.amount), 0) amount, j.tiers_id client_id, t.client_type_code, pack.currency_id
		, ISNULL(target_cur.use_cents, cur.use_cents) use_cents
		FROM dbo.Contracts c
		LEFT JOIN dbo.Credit cr ON cr.id = c.id
		LEFT JOIN dbo.Projects j ON j.id = c.project_id
		LEFT JOIN dbo.Tiers t ON t.id = j.tiers_id
		LEFT JOIN dbo.ContractEvents ce ON ce.contract_id = c.id
		LEFT JOIN dbo.TrancheEvents te ON te.id = ce.id
		INNER JOIN dbo.FilteredCreditContracts(@user_id, @subordinate_id, @branch_id) fcc ON fcc.id = c.id
		INNER JOIN dbo.Packages pack ON pack.id = cr.package_id
		LEFT JOIN dbo.Currencies cur ON cur.id = pack.currency_id
		LEFT JOIN dbo.Currencies target_cur ON target_cur.id = @display_in
		WHERE ce.is_deleted = 0 AND ce.event_date <= @to AND (0 = @disbursed_in OR pack.currency_id = @disbursed_in)
		GROUP BY c.id, cr.amount, j.tiers_id, t.client_type_code, pack.currency_id, cur.use_cents, target_cur.use_cents
	)
	, _written_off_contracts AS
	(
		SELECT ce.id event_id, ce.event_date, ce.contract_id, c.client_id, c.currency_id, c.use_cents
			, woe.olb principal
			, CASE
				WHEN 0 = @display_in THEN woe.olb
				ELSE CAST(ROUND(woe.olb * dbo.GetXR(c.currency_id, @display_in, ce.event_date), CASE WHEN 1 = c.use_cents THEN 2 ELSE 0 END) AS MONEY)
			END principal_x
			, woe.accrued_interests interest
			, CASE
				WHEN 0 = @display_in THEN woe.accrued_interests
				ELSE CAST(ROUND(woe.accrued_interests * dbo.GetXR(c.currency_id, @display_in, ce.event_date), CASE WHEN 1 = c.use_cents THEN 2 ELSE 0 END) AS MONEY)
			END interest_x
			, c.amount
			, CASE
				WHEN 0 = @display_in THEN c.amount
				ELSE CAST(ROUND(c.amount * dbo.GetXR(c.currency_id, @display_in, ce.event_date), CASE WHEN 1 = c.use_cents THEN 2 ELSE 0 END) AS MONEY)
			END amount_x
			, c.client_type_code
		FROM dbo.WriteOffEvents woe
		INNER JOIN dbo.ContractEvents ce ON ce.id = woe.id
		INNER JOIN _contracts c ON c.contract_id = ce.contract_id
		WHERE ce.is_deleted = 0 AND ce.event_date BETWEEN @from AND @to
	)
	, _shares AS
	(
		SELECT woc.event_id, woc.event_date, woc.contract_id, woc.principal_x principal, woc.interest_x interest
			, CASE
				WHEN 0 = @display_in THEN lsa.amount
				ELSE CAST(lsa.amount * dbo.GetXR(woc.currency_id, @display_in, woc.event_date) AS DECIMAL(10,2))
			END amount
			, lsa.person_id
			, CAST(ROUND(lsa.amount/woc.amount*woc.principal_x, CASE WHEN 1 = woc.use_cents THEN 2 ELSE 0 END) AS MONEY) principal_share
			, CAST(ROUND(lsa.amount/woc.amount*woc.interest_x, CASE WHEN 1 = woc.use_cents THEN 2 ELSE 0 END) AS MONEY) interest_share
			, ROW_NUMBER() OVER (PARTITION BY lsa.contract_id ORDER BY lsa.person_id) row_num
		FROM dbo.LoanShareAmounts lsa
		INNER JOIN _written_off_contracts woc ON woc.contract_id = lsa.contract_id
	)
	, _shares_running_total AS
	(
		SELECT a.event_id, a.event_date, a.contract_id, a.amount, a.row_num, a.principal, a.interest, a.person_id
			, a.principal_share, a.interest_share
			, ISNULL(SUM(b.principal_share), 0) principal_share_running_total
			, ISNULL(SUM(b.interest_share), 0) interest_share_running_total
		FROM _shares a
		LEFT JOIN _shares b ON a.contract_id = b.contract_id AND b.row_num < a.row_num
		GROUP BY a.event_id, a.event_date, a.contract_id, a.amount, a.principal, a.interest, a.principal_share, a.interest_share, a.row_num, a.person_id
	)
	, _totals AS
	(
		SELECT lsa.contract_id, COUNT(person_id) total
		FROM dbo.LoanShareAmounts lsa
		INNER JOIN _written_off_contracts woc ON woc.contract_id = lsa.contract_id
		GROUP BY lsa.contract_id
	)
	SELECT srt.event_date write_off_date, srt.contract_id, srt.person_id client_id, srt.amount
		, CASE
			WHEN srt.row_num < t.total THEN principal_share
			ELSE srt.principal - srt.principal_share_running_total
		END written_off_principal
		, CASE
			WHEN srt.row_num < t.total THEN interest_share
			ELSE srt.interest - srt.interest_share_running_total
		END written_off_interest
	FROM _shares_running_total srt
	INNER JOIN _totals t ON t.contract_id = srt.contract_id
	UNION ALL
	SELECT event_date, contract_id, client_id, amount_x, principal_x, interest_x
	FROM _written_off_contracts
	WHERE client_type_code <> 'G'
)
GO
/****** Object:  StoredProcedure [dbo].[Rep_Collection_Sheet]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Collection_Sheet] 
@beginDate DATETIME
, @endDate DATETIME
, @disbursed_in INT
, @display_in INT
, @user_id INT
, @subordinate_id INT
, @branch_id INT
AS BEGIN
	DECLARE @_beginDate DATETIME
	DECLARE @_endDate DATETIME
	DECLARE @_disbursed_in INT
	DECLARE @_display_in INT
	DECLARE @_user_id INT
	DECLARE @_subordinate_id INT
	DECLARE @_branch_id INT
	
	SET @_beginDate = @beginDate
	SET @_endDate = @endDate
	SET @_disbursed_in = @disbursed_in
	SET @_display_in = @display_in
	SET @_user_id = @user_id
	SET @_subordinate_id = @subordinate_id
	SET @_branch_id = @branch_id
	
	SELECT 
		  i.contract_id
		, i.expected_date
		, c.contract_code
	        , cr.amount
		, i.olb
		,substring(cl.name,0,CHARINDEX(' ',cl.name)) as client_first_name
                ,substring(cl.name,CHARINDEX(' ',cl.name),LEN(cl.name)) as client_last_name
		, t.city
		, d.name AS district_name
		, u.first_name + ' ' + u.last_name AS loan_officer_name
		, COALESCE(t.personal_phone, t.home_phone, secondary_personal_phone, secondary_home_phone) AS phone_number
		, i.capital_repayment - i.paid_capital AS principal
		, i.interest_repayment - i.paid_interest AS interest
		, dbo.GetXR(p.currency_id, @_display_in, @_beginDate) AS exchange_rate
		, i.capital_repayment + i.interest_repayment - i.paid_capital - i.paid_interest total
		, ea.name AS activity_name
	FROM dbo.Installments AS i
	LEFT JOIN dbo.Contracts AS c ON c.id = i.contract_id
	LEFT JOIN dbo.Credit AS cr ON cr.id = c.id
	LEFT JOIN dbo.Projects AS j ON j.id = c.project_id
	LEFT JOIN dbo.Tiers AS t ON t.id = j.tiers_id
	LEFT JOIN dbo.Clients AS cl ON cl.id = t.id
	LEFT JOIN dbo.Districts AS d ON d.id = t.district_id
	LEFT JOIN dbo.Users AS u ON u.id = cr.loanofficer_id
	LEFT JOIN dbo.Packages AS p ON p.id = cr.package_id
	LEFT JOIN dbo.EconomicActivities AS ea ON ea.id = c.activity_id
        LEFT JOIN dbo.Branches b ON b.id = t.branch_id
	WHERE expected_date BETWEEN @beginDate AND @endDate
	    AND (capital_repayment > paid_capital OR interest_repayment > paid_interest)
	    AND (c.status = 5 OR c.status = 10)
	    AND (t.branch_id = @_branch_id OR @_branch_id = 0)
	    AND (@subordinate_id = 0 and cr.loanofficer_id in
		(		SELECT @user_id
				UNION ALL
				SELECT subordinate_id
				FROM dbo.UsersSubordinates
				WHERE user_id = @user_id OR 0=@user_id) OR cr.loanofficer_id = @subordinate_id
		)
	ORDER BY i.expected_date
END
GO
/****** Object:  StoredProcedure [dbo].[Rep_ClosedContracts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_ClosedContracts]
	@beginDate DATETIME,
	@endDate DATETIME,
	@disbursed_in INT,
	@display_in INT,
	@branch_id INT
AS
BEGIN
	--DECLARE @beginDate     DATETIME = CAST(DATEADD(M, -1, GETDATE()) AS DATE),
	--        @endDate       DATETIME = CAST(GETDATE() AS DATE),
	--        @disbursed_in  INT = 0,
	--        @display_in    INT = 1,
	--        @branch_id     INT = 1
	
	SELECT co.contract_code,
	       pa.name
	       ,substring(cc.client_name,0,CHARINDEX(' ',cc.client_name)) as client_first_name
          ,substring(cc.client_name,CHARINDEX(' ',cc.client_name),LEN(cc.client_name)) as client_last_name
	       ,cc.loan_officer,
	       cc.amount * dbo.GetXR(cc.currency_id, @display_in, cc.close_date) AS 
	       amount,
	       ce.event_date AS disb_date,
	       cc.close_date,
	       cc.currency
	FROM   ClosedContracts(@beginDate, @endDate, @branch_id) cc
	       INNER JOIN Contracts co
	            ON  co.id = cc.contract_id
	       INNER JOIN Credit cr
	            ON  cr.id = cc.contract_id
	       INNER JOIN Packages pa
	            ON  pa.id = cr.package_id
	       INNER JOIN ContractEvents ce
	            ON  co.id = ce.contract_id
	            AND ce.event_type = 'LODE'
	            AND ce.is_deleted = 0
	WHERE  (cc.currency_id = @disbursed_in OR 0 = @disbursed_in)
	ORDER BY
	       close_date,
	       loan_officer
END
GO
/****** Object:  UserDefinedFunction [dbo].[RepaymentsAll]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[RepaymentsAll]
(
	@from DATETIME
	, @to DATETIME
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
	SELECT contract_id
	, event_id
	, event_type
	, event_date
	, principal
	, interest
	, CAST(ROUND(interest/(1+vat_rate), 2) AS MONEY) AS interest_wo_vat
	, interest - CAST(ROUND(interest/(1+vat_rate), 2) AS MONEY) AS interest_vat
	, commissions
	, CAST(ROUND(commissions/(1+vat_rate), 2) AS MONEY) AS commissions_wo_vat
	, commissions - CAST(ROUND(commissions/(1+vat_rate), 2) AS MONEY) AS commissions_vat
	, penalties
	, CAST(ROUND(penalties/(1+vat_rate), 2) AS MONEY) AS penalties_wo_vat
	, penalties - CAST(ROUND(penalties/(1+vat_rate), 2) AS MONEY) AS penalties_vat
	, written_off
	, parent_id
	FROM 
	(
		SELECT ce.contract_id
		, ce.id AS event_id
		, ce.event_type
		, ce.event_date
		, re.principal
		, re.interests AS interest
		, re.commissions
		, re.penalties
		, CAST((SELECT value 
			FROM dbo.GeneralParameters
			WHERE [key] = 'VAT_RATE'
		) AS FLOAT)/100 AS vat_rate
		, CASE
			WHEN wroe.event_date IS NULL THEN 0
			WHEN CONVERT(date, wroe.event_date) <= CONVERT(date, ce.event_date) THEN 1
			ELSE 0
		END AS written_off
		, ce.parent_id
		FROM dbo.RepaymentEvents re
		LEFT JOIN dbo.ContractEvents AS ce ON ce.id = re.id
		LEFT JOIN
		(
			SELECT contract_id, MIN(event_date) AS event_date
			FROM dbo.ContractEvents
			WHERE event_type = 'WROE' AND CONVERT(date, event_date) <= @to AND is_deleted = 0
			GROUP BY contract_id
		) AS wroe ON wroe.contract_id = ce.contract_id
		LEFT JOIN dbo.Contracts AS c ON c.id = ce.contract_id
		LEFT JOIN dbo.Credit cr ON cr.id = c.id
		INNER JOIN dbo.Projects AS j ON j.id = c.project_id
		INNER JOIN dbo.Tiers AS t ON t.id = j.tiers_id
		WHERE ce.is_deleted = 0
		AND ((@from IS NULL AND @to IS NULL)
			OR (@from IS NULL AND CONVERT(date, ce.event_date) <= @to)
			OR (@to IS NULL AND CONVERT(date, ce.event_date) >= @from)
			OR (CONVERT(date, ce.event_date) >= @from AND CONVERT(date, ce.event_date) <= @to))
		AND ((0 = @branch_id AND t.branch_id IN (SELECT branch_id FROM dbo.UsersBranches WHERE user_id = @user_id))
			OR t.branch_id = @branch_id)
		AND 
		(
			0 = @user_id OR 
			(
				0 = @subordinate_id AND cr.loanofficer_id IN (
					SELECT @user_id
					UNION ALL
					SELECT subordinate_id
					FROM dbo.UsersSubordinates
					WHERE user_id = @user_id
				)
				OR cr.loanofficer_id = @subordinate_id
			)
		)
	) AS t			 
)
GO
/****** Object:  UserDefinedFunction [dbo].[RescheduledLoans]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[RescheduledLoans](@from DATETIME, @to DATETIME, @branch_id INT)
RETURNS TABLE AS RETURN
(
	SELECT re.id
		, ce.contract_id
		, re.amount
		, re.interest
		, re.nb_of_maturity
		, re.grace_period
		, re.charge_interest_during_grace_period
    , re.preferred_first_installment_date
		, ce.event_date reschedule_date
	FROM dbo.ReschedulingOfALoanEvents re
	LEFT JOIN dbo.ContractEvents ce ON re.id = ce.id
	LEFT JOIN dbo.Contracts c ON c.id = ce.contract_id
	LEFT JOIN dbo.Projects j ON j.id = c.project_id
	LEFT JOIN dbo.Tiers t ON t.id = j.tiers_id
	WHERE CAST(ROUND(CAST(ce.event_date AS FLOAT), 0) AS DATETIME) BETWEEN @from AND @to
		AND ce.is_deleted = 0
		AND (0 = @branch_id OR t.branch_id = @branch_id)
)
GO
/****** Object:  UserDefinedFunction [dbo].[RepaymentSchedule]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery12.sql|7|0|C:\Users\TANUJ\AppData\Local\Temp\~vs4929.sql
CREATE FUNCTION [dbo].[RepaymentSchedule](@contract_id INT)
RETURNS TABLE
AS RETURN
(
	SELECT *
	, CAST(ROUND(paid_interest/(1+vat_rate), 2) AS MONEY) AS paid_interest_wo_vat
	, paid_interest - CAST(ROUND(paid_interest/(1+vat_rate), 2) AS MONEY) AS paid_interest_vat
	FROM
	(
		SELECT i.number
		, i.expected_date
		, i.capital_repayment AS expected_principal
		, i.interest_repayment AS expected_interest
		, i.interest_repayment + i.capital_repayment AS total
		, cr.amount - SUM(i2.capital_repayment) AS olb
		, i.paid_capital AS paid_principal
		, i.paid_interest
		, CAST((SELECT value 
			FROM dbo.GeneralParameters
			WHERE [key] = 'VAT_RATE'
		) AS FLOAT)/100 AS vat_rate
		FROM dbo.Installments AS i
		INNER JOIN dbo.Credit AS cr ON cr.id = i.contract_id
		LEFT JOIN dbo.Installments AS i2 ON i2.contract_id = i.contract_id AND i2.number <= i.number
		WHERE i.contract_id = @contract_id
		GROUP BY cr.amount
		, i.number
		, i.expected_date
		, i.contract_id
		, i.capital_repayment
		, i.interest_repayment
		, i.paid_capital
		, i.paid_interest
	) AS i
)
GO
/****** Object:  StoredProcedure [dbo].[Rep_Audit_Trail_Events]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Audit_Trail_Events] 
    @from DATETIME
    , @to DATETIME
    , @user INT
    , @events NVARCHAR(MAX)
    , @include_deleted BIT
AS 
BEGIN
    SELECT event_type, event_date, entry_date
      , user_name, user_role, description, deleted
    FROM AuditTrailEvents(@from, @to, @user, 0, @events, @include_deleted) 
END
GO
/****** Object:  UserDefinedFunction [dbo].[getEntryFees]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getEntryFees]
    (
      @contractId INT
    )
RETURNS MONEY
AS BEGIN
   IF EXISTS( SELECT ce.id FROM 
			   ContractEvents ce 
			   INNER JOIN LoanEntryFeeEvents lee ON ce.id = lee.id AND ce.contract_id = @contractId AND ce.is_deleted = 0 
		)
   RETURN  (
			 SELECT SUM(lee.fee) 
			 FROM ContractEvents ce 
			 INNER JOIN LoanEntryFeeEvents lee ON ce.id = lee.id AND ce.contract_id = @contractId AND ce.is_deleted = 0
          ) 
   RETURN
		(
			SELECT  SUM(EntryFeesForContract.EntryFee) 
			FROM
			(				
				SELECT 
					CASE WHEN rate=1 THEN amount*fee_value/100 ELSE fee_value END AS EntryFee
				FROM CreditEntryFees
				INNER JOIN EntryFees ON CreditEntryFees.entry_fee_id=EntryFees.id
				INNER JOIN Credit ON Credit.id=CreditEntryFees.credit_id
				WHERE Credit.id = @contractId
			) AS EntryFeesForContract
		 )
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetDueInterest]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetDueInterest]
(@contractId int,@endDate datetime)
RETURNS float
AS
BEGIN
DECLARE @dueInterest real;
DECLARE @due real;
DECLARE @paid real;
SET @due = (select ISNULL(sum(interest_repayment),0)
			from installments 
			where installments.contract_id = @contractId)
SET @paid = (select ISNULL(sum(interests),0)
			 from contractEvents inner join 
				  repaymentEvents on contractEvents.id = repaymentEvents.id
			 where is_deleted=0 and contractEvents.contract_id = @contractId and event_date <= @endDate)
SET @dueInterest = @due - @paid;
return @dueInterest;
END
GO
/****** Object:  UserDefinedFunction [dbo].[Disbursements]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Disbursements]
(
	@from DATETIME
	, @to DATETIME
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
	WITH _installments
	AS
	(
		SELECT contract_id, SUM(capital_repayment) AS amount,
		SUM(interest_repayment) AS interest
		FROM dbo.installments
		GROUP BY contract_id
	)
	, _lode
	AS
	(
		SELECT ce.contract_id, ISNULL(SUM(lode.amount),0)+ISNULL(SUM(te.amount),0) AS amount, 
		SUM(lode.interest) AS interest, 
		SUM(lode.fees) AS fees, 
		ce.event_date,
		ce.event_type
		FROM dbo.LoanDisbursmentEvents AS lode
		RIGHT JOIN dbo.ContractEvents AS ce ON ce.id = lode.id
		LEFT JOIN dbo.TrancheEvents te ON te.id = ce.id
		WHERE ce.event_type IN ('LODE','TEET') AND ce.is_deleted = 0
		AND CONVERT(date, ce.event_date) BETWEEN @from AND @to
		GROUP BY ce.contract_id,ce.event_date,ce.event_type
	),
	
	_contracts
			AS
			(
				SELECT DISTINCT(c.id) AS contract_id,
				ISNULL(_lode.event_date, c.start_date) AS disbursement_date,
				CASE WHEN _lode.event_date IS NULL THEN 0 ELSE 1 END AS disbursed,
				CASE WHEN _lode.event_date IS NULL THEN i.amount ELSE _lode.amount END AS amount,
				CASE WHEN _lode.event_date IS NULL THEN i.interest ELSE ISNULL(_lode.interest,0) END AS interest,
				ISNULL(lee.fees,0) AS fees,
				_lode.event_type
				FROM dbo.Contracts AS c
				INNER JOIN dbo.Credit cr ON c.id = cr.id
				INNER JOIN dbo.Projects AS j ON j.id = c.project_id
				INNER JOIN dbo.Tiers AS t ON t.id = j.tiers_id
				INNER JOIN dbo.ContractEvents AS ce ON c.id = ce.contract_id
				LEFT JOIN _installments AS i ON i.contract_id = c.id
				LEFT JOIN _lode ON _lode.contract_id = c.id
				LEFT JOIN LoanEntryFees(@from,@to,@user_id, @subordinate_id, @branch_id) lee ON lee.contract_id = c.id
				WHERE (c.start_date BETWEEN @from AND @to OR _lode.event_date IS NOT NULL)
				AND ((0 = @branch_id AND t.branch_id IN 
					(SELECT branch_id 
					 FROM dbo.UsersBranches 
					 WHERE user_id = @user_id OR 0=@user_id
					 ))
					OR t.branch_id = @branch_id)
				AND (@subordinate_id = 0 and cr.loanofficer_id in
				(		SELECT @user_id
						UNION ALL
						SELECT subordinate_id
						FROM dbo.UsersSubordinates
						WHERE user_id = @user_id OR 0=@user_id) OR cr.loanofficer_id = @subordinate_id
				)
			)
	SELECT contract_id
	, disbursement_date
	, disbursed
	, amount
	, interest
	, fees
	, CAST(ROUND(fees/(1+vat_rate), 2) AS MONEY) AS fees_wo_vat
	, fees - CAST(ROUND(fees/(1+vat_rate), 2) AS MONEY) AS fees_vat
	,event_type
	FROM
	(
		SELECT c.* 
		, CAST((SELECT value
			FROM dbo.GeneralParameters
			WHERE [key] = 'VAT_RATE'
		) AS FLOAT)/100 AS vat_rate
		FROM _contracts AS c
		LEFT JOIN dbo.Credit AS cr ON cr.id = c.contract_id
	) AS t
)
GO
/****** Object:  StoredProcedure [dbo].[EstimatedWorthCalculation ]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EstimatedWorthCalculation ]
(
	@clientid int
)
AS
	DECLARE @savingAccountBalance FLOAT;
	SET @savingAccountBalance = 0;
	DECLARE @curentAccountBalance FLOAT;
	SET @curentAccountBalance = 0;
	DECLARE @fixedDeposits FLOAT;
	SET @fixedDeposits = 0;
	DECLARE @loanBalance FLOAT;
	SET @loanBalance = 0;
	DECLARE @idSavingContracts INT;

BEGIN
SELECT @curentAccountBalance = SUM(initial_amount) FROM CurrentAccountProductHoldings WHERE client_id=@clientid AND status <> 'Closed'
SELECT @fixedDeposits= SUM(initial_amount)  FROM FixedDepositProductHoldings WHERE client_id=@clientid AND status <> 'Closed'
SELECT @idSavingContracts= [id] from [SavingContracts] WHERE [tiers_id]=@clientid
WHILE (SELECT [id] from [SavingContracts] WHERE [tiers_id]=@clientid AND status = 1) IS NOT NULL
BEGIN
	SET @savingAccountBalance=@savingAccountBalance+ [dbo].[getSavingBalance](@idSavingContracts, GETDATE())
END
SELECT @loanBalance= ISNULL(SUM(Installments.capital_repayment -
Installments.paid_capital),0)
                    FROM Credit
                   INNER JOIN Installments ON Credit.id =
Installments.contract_id
                   INNER JOIN Contracts ON Credit.id = Contracts.id
                    WHERE (Credit.disbursed = 1)
                      AND (Credit.written_off = 0)
                      AND (Credit.bad_loan = 0)
                      AND  dbo.GetClientIdFromContractCode(Contracts.contract_code)=@clientid


SELECT (@savingAccountBalance+@curentAccountBalance+@fixedDeposits-@loanBalance) AS ret
END
GO
/****** Object:  UserDefinedFunction [dbo].[InstallmentSnapshot]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[InstallmentSnapshot]
(
	@date DATETIME
)
RETURNS TABLE
AS
RETURN
(
	WITH _installments AS
	(
		-- Unite Installments and InstallmentHistory
		SELECT h.event_id AS snapshot_id
			, CAST(e.event_date AS DATE) AS snapshot_date
			, h.contract_id
			, h.number
			, h.expected_date
			, h.capital_repayment
			, h.interest_repayment
			, h.paid_capital
			, h.paid_interest
			, h.paid_date
      , h.commission
      , h.paid_commission
		FROM dbo.InstallmentHistory AS h
		LEFT JOIN dbo.ContractEvents AS e ON h.event_id = e.id
		WHERE e.is_deleted = 0 AND CAST(e.event_date AS DATE) > @date
		UNION ALL
		SELECT 0 AS snapshot_id
			, '2050-01-01' AS snapshot_date -- date in a very distant future
			, contract_id
			, number
			, expected_date
			, capital_repayment
			, interest_repayment
			, paid_capital
			, paid_interest
			, paid_date
      , commission
      , paid_commission
		FROM dbo.Installments
	)
	SELECT i.contract_id
		, i.number
		, i.expected_date
		, capital_repayment AS principal
		, interest_repayment AS interest
		, paid_capital paid_principal
		, paid_interest
    , commission
    , paid_commission
		, paid_date
	FROM [_installments] AS i
	RIGHT JOIN
	(
		-- Rank snapshots according to dates
		SELECT *, ROW_NUMBER() OVER (PARTITION BY contract_id ORDER BY snapshot_date ASC) AS [rank]
		FROM
		(
			-- Get relevant snapshots only
			SELECT contract_id, snapshot_id, snapshot_date FROM [_installments]
			WHERE snapshot_date > @date
			GROUP BY contract_id, snapshot_id, snapshot_date
		) AS t
	) AS s ON s.contract_id = i.contract_id AND s.snapshot_id = i.snapshot_id
	WHERE s.[rank] = 1
)
GO
/****** Object:  StoredProcedure [dbo].[GetTellerBalance]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Titov Mikhail
-- Create date: 22-jan-2013
-- Description:	The procedure is proposed to sum cash amount in till
-- =============================================
CREATE PROCEDURE [dbo].[GetTellerBalance]
	-- Add the parameters for the stored procedure here
	@teller_id int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    DECLARE @positive_amount MONEY
    DECLARE @negative_amount MONEY
    -- Insert statements for procedure here
	SELECT 
	@positive_amount =
			SUM(
					ISNULL(CreditInsuranceEvents.commission,0)
				   +ISNULL(CreditInsuranceEvents.principal,0)
				   +ISNULL(LoanEntryFeeEvents.fee,0)
				   +ISNULL(RepaymentEvents.principal,0)
				   +ISNULL(RepaymentEvents.interests,0)
				   +ISNULL(RepaymentEvents.commissions,0)
				   +ISNULL(RepaymentEvents.penalties,0)
			    )
	FROM ContractEvents ce
	LEFT JOIN dbo.CreditInsuranceEvents  ON ce.id = CreditInsuranceEvents.id
	LEFT JOIN dbo.LoanEntryFeeEvents ON ce.id = LoanEntryFeeEvents.disbursement_event_id 
	LEFT JOIN dbo.RepaymentEvents ON ce.id = RepaymentEvents.id
	WHERE ce.teller_id = @teller_id 
		  AND ce.is_deleted = 0 
		  
    SELECT @negative_amount = 
    SUM(
    	ISNULL(LoanDisbursmentEvents.amount,0)
      )
    FROM ContractEvents ce 
    LEFT JOIN dbo.LoanDisbursmentEvents ON ce.id = LoanDisbursmentEvents.id
    WHERE ce.teller_id = @teller_id 
		  AND ce.is_deleted = 0 
		  
		  
	SELECT @negative_amount = @negative_amount
	+ISNULL(SUM(se.amount),0)	   
	FROM SavingEvents se
	WHERE se.code IN ('SVWE') 
		  AND se.teller_id=@teller_id 
	      AND se.deleted=0 
	      
	SELECT @positive_amount = 
	@positive_amount 
	+ISNULL(SUM(se.amount),0)+ISNULL(SUM(se.fees),0)		
	FROM SavingEvents se
	WHERE se.code IN ('SVIE', 'SVDE') 
		  AND se.teller_id=@teller_id 
	      AND se.deleted=0
	
	SELECT ISNULL(@positive_amount,0) - ISNULL(@negative_amount,0) 
END
GO
/****** Object:  UserDefinedFunction [dbo].[ActiveSavingContracts_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ActiveSavingContracts_MC]
(
  @pDate DATETIME,
  @pAccountCurrency INT,
  @pDisplayCurrency INT, 
  @branch_id INT
)
RETURNS TABLE
AS 
RETURN
(
SELECT 
  sc.contract_id,
  sc.product_type,
  sc.client_type_code,
  sc.tier_id AS client_id,
  sc.balance * dbo.GetXR(sc.currency_id,@pDisplayCurrency,@pDate) AS balance,
  sc.is_compulsary,
  sc.is_voluntary
FROM ActiveSavingContracts(@pDate, @branch_id) sc
WHERE sc.currency_id = @pAccountCurrency OR 0 = @pAccountCurrency
)
GO
/****** Object:  UserDefinedFunction [dbo].[ActiveSavingAccounts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ActiveSavingAccounts]
(
  @pDate DATETIME, 
  @branch_id INT
)
RETURNS TABLE AS
RETURN
(
WITH _accounts AS (		
					SELECT SC.contract_id,
					  SC.currency_id,
					  SC.client_type_code,
					  SC.tier_id AS client_id,  
					  SC.balance balance
					  , SC.is_compulsary
					  , SC.is_voluntary
					FROM ActiveSavingContracts(@pDate, @branch_id) SC	
				   ),
_share_accounts AS(
					SELECT ac.contract_id,
					  ac.currency_id,
					  ac.client_type_code,
					  PGB.person_id AS client_id,
					  ROW_NUMBER() OVER (PARTITION BY PGB.group_id ORDER BY person_id) AS number,
					  PGB2.total AS total,
					  ac.balance balance,
					  FLOOR(ac.balance/PGB2.total) AS share_balance
					  , ac.is_compulsary
					  , ac.is_voluntary
					FROM _accounts ac
					INNER JOIN PersonGroupBelonging PGB ON PGB.group_id = ac.client_id AND joined_date <= @pDate AND (@pDate <= left_date OR left_date IS NULL)
					INNER JOIN (
					  SELECT group_id,COUNT(*) AS total
					  FROM PersonGroupBelonging 
					  WHERE joined_date <= @pDate AND (@pDate <= left_date OR left_date IS NULL)
					  GROUP BY group_id
					) AS PGB2 ON ac.client_id = PGB2.group_id AND ac.client_type_code = 'G'
				   )
SELECT
  SA.contract_id,
  SA.currency_id,
  SA.client_type_code,
  SA.client_id,
  CASE WHEN SA.number<SA.total THEN SA.share_balance
	   ELSE SA.balance - ISNULL(SUM(SB.share_balance),0)
  END AS balance
  , SA.is_compulsary
  , SA.is_voluntary
FROM _share_accounts SA
LEFT JOIN _share_accounts SB ON SA.contract_id = SB.contract_id AND SA.number > SB.number
GROUP BY SA.contract_id,SA.currency_id,SA.client_type_code,SA.client_id,SA.number,
		SA.total,SA.balance,SA.share_balance, SA.is_compulsary, SA.is_voluntary
UNION ALL
SELECT ac.contract_id,
  ac.currency_id,
  ac.client_type_code,
  ac.client_id,
  ac.balance
  , ac.is_compulsary
  , ac.is_voluntary
FROM _accounts ac
WHERE ac.client_type_code IN ('I','C')
)
GO
/****** Object:  UserDefinedFunction [dbo].[ClosedLoans]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of closed loans
--
-- HISTORY
--
-- 13 Apr, 2011 - v2.8.15 - Pasha BASTOV
-- Add the @branch_id parameter
CREATE FUNCTION [dbo].[ClosedLoans]
(	
	@from DATETIME
	, @to DATETIME
	, @branch_id INT
)
RETURNS TABLE 
AS
RETURN
(--Function splits groups into individual loans.
	SELECT cc.contract_id,
	ISNULL(per.id,cc.client_id) AS client_id,
	cc.client_type_code,
	ISNULL(per.first_name + SPACE(1)+per.last_name,cc.client_name) AS client_name,
	cc.loan_officer,
	ISNULL(lsa.amount,cc.amount) AS amount,
	cc.start_date,
	cc.close_date,
	cc.currency_id,
	cc.currency,code	
	FROM ClosedContracts(@from, @to, @branch_id) cc
	LEFT OUTER JOIN LoanShareAmounts lsa ON cc.client_id = lsa.group_id AND lsa.contract_id = cc.contract_id
	LEFT OUTER JOIN Persons per ON lsa.person_id = per.id	
)
GO
/****** Object:  UserDefinedFunction [dbo].[ClosedContracts_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of contracts closed within a period with exchange rates applied
--
-- HISTORY
--
-- 13 Apr, 2011 - v2.8.15 - Pasha BASTOV
-- Add the @branch_id parameter
CREATE FUNCTION [dbo].[ClosedContracts_MC]
(	
@from DATETIME,
@to DATETIME,
@disbursed_in INT,
@display_in INT,
@branch_id INT
)
RETURNS TABLE 
AS
RETURN
(   SELECT
	contract_id,
	client_id,
	client_type_code,
	client_name,
	loan_officer,
	amount*dbo.GetXR(currency_id, @display_in, close_date) AS amount,
	start_date,
	close_date,
	currency_id,
	currency,code	
	FROM ClosedContracts(@from, @to, @branch_id)
	WHERE currency_id = @disbursed_in OR 0 = @disbursed_in
	
)
GO
/****** Object:  UserDefinedFunction [dbo].[check_installment_paid]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[check_installment_paid]
(@endDate datetime,@contractId int,@installmentId int)
RETURNS bit
AS
BEGIN
DECLARE @due real;
DECLARE @paid real;
DECLARE @result bit;
SET @due = (select sum(capital_repayment + interest_repayment)
			from installments 
			where installments.contract_id = @contractId and installments.number <= @installmentId)
SET @paid = (select sum(principal + interests) 
			 from contractEvents inner join 
				  repaymentEvents on contractEvents.id = repaymentEvents.id
			 where is_deleted=0 and contractEvents.contract_id = @contractId and event_date <= @endDate)
if(@paid>=@due) SET @result = 1 else SET @result =  0;
return @result;
END
GO
/****** Object:  UserDefinedFunction [dbo].[ClosedLoans_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of loans closed within a period with exchange rates applied
--
-- HISTORY
--
-- 13 Apr, 2011 - v2.8.15 - Pasha BASTOV
-- Add the @branch_id parameter
CREATE FUNCTION [dbo].[ClosedLoans_MC]
(	
	@from DATETIME
	, @to DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @branch_id INT
)
RETURNS TABLE 
AS
RETURN
(
	SELECT
	contract_id,
	client_id,
	client_type_code,
	client_name,
	loan_officer,
	amount*dbo.GetXR(currency_id, @display_in, close_date) AS amount,
	start_date,
	close_date,
	currency_id,
	currency,code	
	FROM ClosedLoans(@from, @to, @branch_id)
	WHERE currency_id = @disbursed_in OR 0 = @disbursed_in
)
GO
/****** Object:  UserDefinedFunction [dbo].[ActiveLoans]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ActiveLoans](@date DATETIME, @branch_id INT)
RETURNS TABLE
AS RETURN
(
	WITH _amounts AS
	(
		SELECT contract_id id, SUM(amount) amount
		FROM
		(
		    SELECT ce.contract_id, lode.amount
		    FROM dbo.ContractEvents ce
		    INNER JOIN dbo.LoanDisbursmentEvents lode ON ce.id = lode.id
		    WHERE ce.is_deleted = 0 AND CONVERT(date, ce.event_date) <= @date
		    
		    UNION ALL
		    
		    SELECT ce.contract_id, te.amount
		    FROM dbo.ContractEvents ce
		    INNER JOIN dbo.TrancheEvents te ON ce.id = te.id
		    WHERE ce.is_deleted = 0 AND CONVERT(date, ce.event_date) <= @date
		) t
		GROUP BY contract_id
	)
	, _installments AS
	(
		SELECT contract_id
			, expected_date
			, CAST(ROUND(principal, 2) AS MONEY) principal
			, CAST(ROUND(paid_principal, 2) AS MONEY) paid_principal
			, CAST(ROUND(interest, 2) AS MONEY) interest
			, CAST(ROUND(paid_interest, 2) AS MONEY) paid_interest
		FROM dbo.InstallmentSnapshot(@date)
	)
	, _loans AS
	(
		SELECT contract_id id
			, SUM(principal - paid_principal) olb
			, SUM(interest - paid_interest) interest
			, SUM(interest) initial_interest
			, SUM(paid_interest) paid_interest
			, MAX(late_days) late_days
			, MIN(expected_date_before) expected_date
			, CAST(ROUND(SUM(
				CASE
					WHEN expected_date <= @date THEN principal_due
					ELSE 0
				END
			), 2) AS MONEY) principal_due
			, CAST(ROUND(SUM(
				CASE
					WHEN expected_date <= @date THEN interest_due
					ELSE 0
				END
			), 2) AS MONEY) interest_due
		FROM
		(
			SELECT *
				, CASE
					WHEN expected_date > @date THEN 0
					--WHEN ABS(principal - paid_principal) > 0.05 OR ABS(interest - paid_interest) > 0.05 THEN DATEDIFF(DD, expected_date, @date)
					WHEN principal > paid_principal OR interest > paid_interest THEN DATEDIFF(DD, expected_date, @date)
					ELSE 0
				END late_days
				, CASE
					--WHEN (ABS(principal - paid_principal) > 0.05 OR ABS(interest - paid_interest) > 0.05) AND expected_date <= @date THEN expected_date
					WHEN (principal > paid_principal OR interest > paid_interest) AND expected_date <= @date THEN expected_date
					ELSE NULL
				END expected_date_before
				, principal - paid_principal principal_due
				, interest - paid_interest interest_due
			--FROM dbo.InstallmentSnapshot(@date)
			FROM _installments
		) i
		GROUP BY contract_id
	)
    , _flags AS (
        -- Disbursed / written off
        SELECT c.id contract_id
        , SUM(CASE WHEN 'LODE' = ce.event_type THEN 1 ELSE 0 END) disbursed
        , SUM(CASE WHEN 'WROE' = ce.event_type THEN 1 ELSE 0 END) written_off
        , SUM(CASE WHEN 'LOCE' = ce.event_type THEN 1 ELSE 0 END) closed
        FROM dbo.Credit c
        LEFT JOIN dbo.ContractEvents ce ON ce.contract_id = c.id
        WHERE ce.is_deleted = 0 AND CAST(FLOOR(CAST(ce.event_date AS FLOAT)) AS DATETIME) <= @date
        GROUP BY c.id
    )
    
	SELECT l.*, a.amount, t.id client_id, t.client_type_code
	FROM _loans l
	LEFT JOIN _flags f ON f.contract_id = l.id
	LEFT JOIN dbo.Contracts c ON c.id = l.id
	LEFT JOIN dbo.Projects j ON j.id = c.project_id
	LEFT JOIN dbo.Tiers t ON t.id = j.tiers_id
	LEFT JOIN _amounts a ON a.id = l.id
	WHERE olb > 0.5
		AND f.disbursed > 0 AND f.written_off < 1 AND f.closed < 1 
		AND (0 = @branch_id OR t.branch_id = @branch_id)
)
GO
/****** Object:  UserDefinedFunction [dbo].[ActiveSavingAccounts_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ActiveSavingAccounts_MC]
(
  @pDate DATETIME,
  @pAccountCurrency INT,
  @pDisplayCurrency INT, 
  @branch_id INT
)
RETURNS TABLE
AS 
RETURN
(
SELECT 
  acs.contract_id,
  acs.client_type_code,
  acs.client_id,
  acs.balance * dbo.GetXR(acs.currency_id,@pDisplayCurrency,@pDate) AS balance
  , acs.is_compulsary
  , acs.is_voluntary
FROM ActiveSavingAccounts(@pDate, @branch_id) acs
WHERE acs.currency_id = @pAccountCurrency OR 0 = @pAccountCurrency
)
GO
/****** Object:  UserDefinedFunction [dbo].[LateAmounts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[LateAmounts] (@date datetime, @user_id INT, @subordinate_id INT, @branch_id int)
RETURNS TABLE AS RETURN
(
	WITH events AS
	(
		SELECT contract_id,
			SUM(CASE WHEN 'LODE' = event_type THEN 1 ELSE 0 END) disbursements,
			SUM(CASE WHEN 'WROE' = event_type THEN 1 ELSE 0 END) write_offs,
			SUM(CASE WHEN 'LOCE' = event_type THEN 1 ELSE 0 END) closes
		FROM dbo.ContractEvents
		WHERE is_deleted = 0 AND event_date <= @date
		GROUP BY contract_id
	)
	SELECT *
	FROM
	(
		SELECT i.contract_id, SUM(principal - paid_principal) principal, SUM(interest - paid_interest) interest
		FROM dbo.InstallmentSnapshot(@date) i
		INNER JOIN events e ON e.contract_id = i.contract_id
		INNER JOIN dbo.FilteredCreditContracts(@user_id, @subordinate_id, @branch_id) fcc ON fcc.id = i.contract_id
		WHERE i.expected_date < @date 
			AND e.disbursements > 0 
			AND e.write_offs = 0 
			AND e.closes = 0
		GROUP BY i.contract_id
	) t
	WHERE t.principal + t.interest > 0
)
GO
/****** Object:  UserDefinedFunction [dbo].[Disbursements_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of disbursements withing a given period with exchange rates applied
--
-- HISTORY
--
-- 14 Apr 2011 - v2.8.15 - Pasha BASTOV
-- Add @branch_id to the list of parameters
CREATE FUNCTION [dbo].[Disbursements_MC]
(
	@from DATETIME
	, @to DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
	SELECT d.contract_id
	, d.disbursement_date
	, d.disbursed
	, CAST(d.amount * dbo.GetXR(pkg.currency_id, @display_in, d.disbursement_date) AS MONEY) AS amount
	, CAST(d.interest * dbo.GetXR(pkg.currency_id, @display_in, d.disbursement_date) AS MONEY) AS interest
	, CAST(d.fees * dbo.GetXR(pkg.currency_id, @display_in, d.disbursement_date) AS MONEY) AS fees
	, CAST(d.fees_wo_vat * dbo.GetXR(pkg.currency_id, @display_in, d.disbursement_date) AS MONEY) AS fees_wo_vat
	, CAST(d.fees_vat * dbo.GetXR(pkg.currency_id, @display_in, d.disbursement_date) AS MONEY) AS fees_vat
    ,d.event_type
	FROM dbo.Disbursements(@from, @to, @user_id, @subordinate_id, @branch_id) AS d
	LEFT JOIN dbo.Credit AS cr ON cr.id = d.contract_id
	LEFT JOIN dbo.Packages AS pkg ON pkg.id = cr.package_id
	WHERE pkg.currency_id = @disbursed_in OR 0 = @disbursed_in
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetXIRR]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetXIRR](@contractId INT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @cashflows TABLE
    (
	    n FLOAT
	    , amount MONEY
    )
    DECLARE @startDate DATETIME
    DECLARE @eventType NVARCHAR(4)
    DECLARE @eventId INT
    SELECT TOP 1 @startDate = event_date, @eventType = event_type, @eventId = id
    FROM dbo.ContractEvents
    WHERE is_deleted = 0
        AND event_type IN ('LODE', 'TEET', 'ROLE', 'APR')
        AND contract_id = @contractId
    ORDER BY event_date DESC
  
    DECLARE @amount MONEY
    SELECT @amount = SUM(principal - paid_principal)
    FROM dbo.InstallmentSnapshot(@startDate)
    WHERE contract_id = @contractId
    IF @eventType = 'LODE'
    BEGIN
      SET @amount = @amount - ISNULL(dbo.getEntryFees(@contractId), 0)
    END
  
    IF @eventType = 'TEET'
    BEGIN
      DECLARE @trancheFee MONEY
      SELECT @trancheFee = SUM(lee.fee) FROM LoanEntryFeeEvents lee
      INNER JOIN TrancheEvents te ON lee.disbursement_event_id = te.id
      INNER JOIN ContractEvents ce ON ce.id = lee.id
      WHERE ce.contract_id = @contractId
          AND ce.is_deleted = 0
          AND lee.disbursement_event_id = @eventId 
    END
      
    INSERT INTO @cashflows
    SELECT 0, -@amount
    INSERT INTO @cashflows
    SELECT -DATEDIFF(dd, @startDate, expected_date)/365.0, principal + interest
    FROM dbo.InstallmentSnapshot(@startDate)
    WHERE contract_id = @contractId
        AND principal + interest - paid_principal - paid_interest > 0
        
    DECLARE @rate FLOAT
    DECLARE @temp FLOAT
    SET @rate = 0
    DECLARE @err FLOAT
    SET @err = .00000001
    DECLARE @val FLOAT
    DECLARE @pval FLOAT
    DECLARE @i INT
    SET @i = 0
    WHILE @i < 10
    BEGIN
	    SELECT @val = SUM(amount * POWER(1 + @rate, n)) FROM @cashflows
	    SELECT @pval = SUM(amount * n * POWER(1 + @rate, n - 1)) FROM @cashflows
	    SET @temp = @rate - @val/@pval
	    IF ABS(@temp - @rate) < @err
	    BEGIN
		    SET @rate = @temp
		    BREAK
	    END
	    SET @rate = @temp
	    SET @i = @i + 1
    END
    RETURN @rate
END
GO
/****** Object:  UserDefinedFunction [dbo].[ExpectedInstallments]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ExpectedInstallments] (@from DATETIME, @to DATETIME, @user_id INT, @subordinate_id INT, @branch_id INT)
RETURNS TABLE AS RETURN
(
	WITH flags AS
	(
		SELECT contract_id,
			SUM(CASE WHEN 'LODE' = event_type THEN 1 ELSE 0 END) disbursed,
			SUM(CASE WHEN 'WROE' = event_type THEN 1 ELSE 0 END) written_off,
			SUM(CASE WHEN 'LOCE' = event_type THEN 1 ELSE 0 END) closed
		FROM dbo.ContractEvents
		WHERE event_date <= @from AND is_deleted = 0
		GROUP BY contract_id
	)
	SELECT i.contract_id, i.expected_date, i.number, i.principal, i.interest, i.paid_principal prepaid_principal, i.paid_interest prepaid_interest
	FROM dbo.InstallmentSnapshot(@from) i	
	LEFT JOIN flags f ON f.contract_id = i.contract_id
	INNER JOIN dbo.FilteredCreditContracts(@user_id, @subordinate_id, @branch_id) fcc ON fcc.id = i.contract_id
	WHERE i.expected_date BETWEEN @from AND @to
		AND f.disbursed > 0 
		AND 0 = f.written_off 
		AND 0 = closed
		AND (i.principal > i.paid_principal OR i.interest > i.paid_interest)
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetOLB]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetOLB]
(@contractId int,@endDate datetime)
RETURNS MONEY
AS
BEGIN
	DECLARE @retval MONEY
	DECLARE @amount MONEY
	DECLARE @paid MONEY
	SELECT @amount = ISNULL(SUM(principal), 0)
	FROM dbo.InstallmentSnapshot(@endDate)
	WHERE contract_id = @contractId
	SELECT @paid = ISNULL(SUM(principal), 0)
	FROM dbo.RepaymentEvents AS re
	LEFT JOIN dbo.ContractEvents AS ce ON re.id = ce.id
	WHERE ce.is_deleted = 0 AND event_date <= @endDate AND contract_id = @contractId
	SET @retval = @amount - @paid
	SET @retval = CASE WHEN @retval < 0 THEN 0 ELSE @retval END
	
	RETURN @retval	
END
GO
/****** Object:  UserDefinedFunction [dbo].[getLateDays]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getLateDays]
    (
      @endDate datetime,
      @contractId INT,
      @installmentId int
    )
RETURNS INT
AS BEGIN
    DECLARE @result int ;
    DECLARE @installment_date DATETIME ;
    DECLARE @paid BIT ;
    DECLARE @contractNbInstallment INT ;
    DECLARE @counter INT ;
    IF ( @installmentId = -1 ) 
        BEGIN
            SELECT @contractNbInstallment =  MAX(number)
            FROM   installments
            WHERE  contract_id = @contractId
          
		    SET @counter = (SELECT ISNULL(MAX([Installments].[number]),1)
							FROM [Installments] 
							WHERE [Installments].[contract_id] = @contractId 
							  AND [Installments].[paid_interest]<>0)		
            WHILE ( @installmentId = -1 )
                AND ( @counter <= @contractNbInstallment )
                BEGIN
                    IF ( dbo.[check_installment_paid](@endDate, @contractId,
                                                      @counter) = 0 ) 
                        BEGIN 
                            SET @installmentId = @counter ;
                        END
                    SET @counter = @counter + 1 ;
                END	
        END
    SET @paid = ( dbo.check_installment_paid(@endDate, @contractId, @installmentId) ) ;
    SELECT @installment_date = [expected_date]
    FROM      [Installments]
    WHERE     contract_id = @contractId AND number = @installmentId
    SET @result = CASE WHEN @paid = 1 THEN 0
                       ELSE CASE WHEN datediff(d, @installment_date, @endDate) < 0  THEN 0
                                 ELSE datediff(d, @installment_date, @endDate)
                            END
                  END
    return @result
   END
GO
/****** Object:  UserDefinedFunction [dbo].[RescheduledLoans_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[RescheduledLoans_MC](@from DATETIME, @to DATETIME, @disbursed_in INT, @display_in INT, @branch_id INT)
RETURNS TABLE AS RETURN
(
	SELECT rl.id
		, rl.contract_id
		, rl.amount * dbo.GetXR(p.currency_id, @display_in, rl.reschedule_date) amount
		, rl.interest * dbo.GetXR(p.currency_id, @display_in, rl.reschedule_date) interest
		, rl.nb_of_maturity
		, rl.grace_period
		, rl.charge_interest_during_grace_period
    , rl.preferred_first_installment_date
		, rl.reschedule_date
	FROM dbo.RescheduledLoans(@from, @to, @branch_id) rl
	LEFT JOIN dbo.Credit cr ON cr.id = rl.contract_id
	LEFT JOIN dbo.Packages p ON p.id = cr.package_id
	WHERE 0 = @disbursed_in OR p.currency_id = @disbursed_in
)
GO
/****** Object:  UserDefinedFunction [dbo].[Repayments]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Repayments]
(
	@from DATETIME
	, @to DATETIME
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
    WITH parents AS
    (
        SELECT contract_id
            , event_id
            , event_type
            , event_date
            , principal
            , interest
            , interest_wo_vat
            , interest_vat
            , commissions
            , commissions_wo_vat
            , commissions_vat
            , penalties
            , penalties_wo_vat
            , penalties_vat
            , written_off
        FROM dbo.RepaymentsAll(@from, @to, @user_id, @subordinate_id, @branch_id)
        WHERE parent_id IS NULL
    )
    , children AS
    (
        SELECT parent_id event_id
            , SUM(principal) principal
            , SUM(interest) interest
            , SUM(interest_wo_vat) interest_wo_vat
            , SUM(interest_vat) interest_vat
            , SUM(commissions) commissions
            , SUM(commissions_wo_vat) commissions_wo_vat
            , SUM(commissions_vat) commissions_vat
            , SUM(penalties) penalties
            , SUM(penalties_wo_vat) penalties_wo_vat
            , SUM(penalties_vat) penalties_vat
        FROM dbo.RepaymentsAll(@from, @to, @user_id, @subordinate_id, @branch_id)
        WHERE NOT parent_id IS NULL
        GROUP BY (parent_id)
    )
    SELECT p.contract_id 
        , p.event_id
        , p.event_type
        , p.event_date
        , p.principal + ISNULL(c.principal, 0) principal
        , p.interest + ISNULL(c.interest, 0) interest
        , p.interest_wo_vat + ISNULL(c.interest_wo_vat, 0) interest_wo_vat
        , p.interest_vat + ISNULL(c.interest_vat, 0) interest_vat
        , p.commissions + ISNULL(c.commissions, 0) commissions
        , p.commissions_wo_vat + ISNULL(c.commissions_wo_vat, 0) commissions_wo_vat
        , p.commissions_vat + ISNULL(c.commissions_vat, 0) commissions_vat
        , p.penalties + ISNULL(c.penalties, 0) penalties
        , p.penalties_wo_vat + ISNULL(c.penalties_wo_vat, 0) penalties_wo_vat
        , p.penalties_vat + ISNULL(c.penalties_vat, 0) penalties_vat
        , p.written_off
    FROM parents p
    LEFT JOIN children c ON p.event_id = c.event_id
)
GO
/****** Object:  UserDefinedFunction [dbo].[RepaymentsAll_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of repayments within a given period with exchange rates applied
--
-- HISTORY
--
-- 14 Apr 2011 - v2.8.15 - Pasha BASTOV
-- Add @branch_id as a parameter
CREATE FUNCTION [dbo].[RepaymentsAll_MC]
(
	@from DATETIME
	, @to DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
	SELECT re.contract_id
	, re.event_id
	, re.event_type
	, re.event_date
	, CAST(re.principal * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS principal
	, CAST(re.interest * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS interest
	, CAST(re.interest_wo_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS interest_wo_vat
	, CAST(re.interest_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS interest_vat
	, CAST(re.commissions * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS commissions
	, CAST(re.commissions_wo_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS commissions_wo_vat
	, CAST(re.commissions_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS commissions_vat
	, CAST(re.penalties * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS penalties
	, CAST(re.penalties_wo_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS penalties_wo_vat
	, CAST(re.penalties_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS penalties_vat
	, re.written_off
	FROM dbo.RepaymentsAll(@from, @to, @user_id, @subordinate_id, @branch_id) AS re
	LEFT JOIN dbo.Credit AS cr ON cr.id = re.contract_id
	LEFT JOIN dbo.Packages AS pkg ON pkg.id = cr.package_id
	WHERE pkg.currency_id = @disbursed_in OR 0 = @disbursed_in	
)
GO
/****** Object:  StoredProcedure [dbo].[Rep_Disbursements]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Disbursements]
	@start_date DATETIME
	, @end_date DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
AS BEGIN

		SELECT Cont.contract_code, Dts.name AS [district], Pack.name AS [loan_product]
		,ISNULL(Gr.name, ISNULL(Pers.first_name, '')) AS [client_first_name]
		,ISNULL(Gr.name,ISNULL(Pers.last_name, '')) AS [client_last_name]
,Trs.loan_cycle,
		Us.first_name + SPACE(1) + Us.last_name AS [loan_officer], Br.code AS branch_name, Dis.disbursement_date, Dis.amount, Dis.interest, Dis.fees  
		FROM dbo.Disbursements_MC(@start_date, @end_date, @disbursed_in, @display_in, @user_id, @subordinate_id, @branch_id) AS Dis
		LEFT JOIN dbo.Credit AS Cr ON Cr.id = Dis.contract_id
		LEFT JOIN dbo.Contracts AS Cont ON Dis.contract_id = Cont.id
		LEFT JOIN dbo.Projects AS Pr ON Cont.project_id = Pr.id
		LEFT JOIN dbo.Groups AS Gr ON Gr.id = Pr.tiers_id
		LEFT JOIN dbo.Persons AS Pers ON Pers.id = Pr.tiers_id
		LEFT JOIN dbo.Tiers AS Trs ON Pr.tiers_id = Trs.id
		LEFT JOIN dbo.Branches Br ON Br.id = Trs.branch_id
		LEFT JOIN dbo.Districts AS Dts ON Dts.id = Trs.district_id
		LEFT JOIN dbo.Users AS Us ON Cr.loanofficer_id = Us.id
		LEFT JOIN dbo.Packages AS Pack ON Cr.package_id = Pack.id
		WHERE Dis.disbursement_date BETWEEN @start_date AND @end_date
		AND Dis.disbursed = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Rep_Client_Personal_Information_Credit]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Client_Personal_Information_Credit]
	@person_id INT
	, @branch_id INT
AS BEGIN
	SELECT DISTINCT
	Cont.contract_code, 
	dbo.Statuses.Status_name AS [status],
	CASE WHEN LoSh.amount IS NOT NULL THEN LoSh.amount ELSE Cr.amount END AS [amount],
	ISNULL(AcLo.olb, '') AS [olb], 
	Cont.creation_date, Cont.start_date, Cont.close_date, 
	ISNULL(Gr.name, '-') AS [group_name], 
	CASE WHEN AcLo.late_days IS NOT NULL AND AcLo.late_days!=0 THEN total_late_days
	ELSE total_late_days END
	AS [total_late_days],
	CAST(CASE WHEN ContEv.count_atr > 0 THEN 1 ELSE 0 END AS BIT) AS has_atr
	FROM Contracts AS Cont
	INNER JOIN Credit As Cr On Cr.id = Cont.id
	INNER JOIN Projects AS Pr ON Cont.project_id = Pr.id
	INNER JOIN Tiers AS Tr ON Tr.id = Pr.tiers_id
	LEFT JOIN ActiveLoans(GETDATE(), @branch_id) AS AcLo ON AcLo.id = Cont.id
	LEFT JOIN LoanShareAmounts AS LoSh ON LoSh.contract_id = Cont.id
	LEFT JOIN Groups AS Gr On Gr.id = LoSh.group_id
	INNER JOIN 
	(
	SELECT     Installments.contract_id, 
	SUM (
		  CASE WHEN Installments.expected_date IS NULL AND Installments.paid_date IS NULL THEN 0
		  ELSE
			  CASE WHEN  Installments.paid_date IS NULL THEN 
				    CASE WHEN DATEDIFF(dd, Installments.expected_date, GETDATE())<0 THEN 0
					     ELSE DATEDIFF(dd, Installments.expected_date, GETDATE()) 
						 END
					ELSE CASE WHEN DATEDIFF(dd, Installments.expected_date, paid_date)<0 THEN 0 
						 ELSE DATEDIFF(dd, Installments.expected_date, paid_date)
					     END
					END
			  END
		)AS total_late_days
	FROM      dbo.Installments
	GROUP BY Installments.contract_id
	) AS Ins ON Ins.contract_id = Cont.id INNER JOIN
	dbo.Statuses ON Cont.status = dbo.Statuses.id
	LEFT JOIN
	(
	SELECT
	contract_id, COUNT(id) AS [count_atr]
	FROM ContractEvents AS ContEv
	WHERE ContEv.event_type = 'ATR' AND ContEv.is_deleted = 0
	GROUP BY contract_id
	) AS ContEv ON ContEv.contract_id = Cont.id
	WHERE (Tr.id = @person_id OR LoSh.person_id = @person_id)
END
GO
/****** Object:  StoredProcedure [dbo].[Rep_Client_Information]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Client_Information] 
	@disbursed_in INT, @display_in INT, @from DATETIME, @branch_id INT
AS BEGIN 
	DECLARE @advanced_fields TABLE
	(
		id INT IDENTITY(1,1) NOT NULL
		, name NVARCHAR(255)	
	)
	INSERT INTO @advanced_fields SELECT name FROM dbo.AdvancedFields WHERE entity_id = 1

	DECLARE @custom1 NVARCHAR(255)
	DECLARE @custom2 NVARCHAR(255)
	DECLARE @custom3 NVARCHAR(255)
	DECLARE @custom4 NVARCHAR(255)
	DECLARE @custom5 NVARCHAR(255)
	DECLARE @custom6 NVARCHAR(255)
	DECLARE @custom7 NVARCHAR(255)
	DECLARE @custom8 NVARCHAR(255)
	DECLARE @custom9 NVARCHAR(255)
	DECLARE @custom10 NVARCHAR(255)

	SELECT @custom1 = name FROM @advanced_fields WHERE id = 1
	SELECT @custom2 = name FROM @advanced_fields WHERE id = 2
	SELECT @custom3 = name FROM @advanced_fields WHERE id = 3
	SELECT @custom4 = name FROM @advanced_fields WHERE id = 4
	SELECT @custom5 = name FROM @advanced_fields WHERE id = 5
	SELECT @custom6 = name FROM @advanced_fields WHERE id = 6
	SELECT @custom7 = name FROM @advanced_fields WHERE id = 7
	SELECT @custom8 = name FROM @advanced_fields WHERE id = 8
	SELECT @custom9 = name FROM @advanced_fields WHERE id = 9
	SELECT @custom10 = name FROM @advanced_fields WHERE id = 10
	
    DECLARE @active_loans TABLE
    (
        id INT NOT NULL
        , late_days INT NOT NULL
        , olb MONEY
        , amount MONEY
    )
    INSERT INTO @active_loans
    SELECT id, late_days, olb, amount
    FROM dbo.ActiveLoans(@from, @branch_id)
    
	SELECT DISTINCT  
	  Tr.id 
	, COALESCE(Corporates.Name, Gr.name, ISNULL(Pers.first_name, ''))  AS [client_first_name]
	,ISNULL(Pers.last_name, '') AS [client_last_name]
	, Tr.client_type_code AS [type]
	, Dis.name AS [district]
	, ISNULL(Tr.personal_phone, '-') AS [pers_phone]
	, ISNULL(Tr.secondary_home_phone, '-') AS [s_home_phone]
	, ISNULL(Tr.secondary_personal_phone, '-') AS [s_pers_phone]
	, COALESCE(EcAc.name, CorporateActivities.name, '-') AS [activity]
	, ISNULL(Pers.sex, '-') AS sex, Cont.contract_code AS [contract_code]
	, Cont.start_date
	, Cont.close_date 
	, CAST(al.amount * dbo.GetXR(Pack.currency_id, @display_in, @from) AS MONEY) AS [loan_amount]
	, CAST(al.olb * dbo.GetXR(Pack.currency_id, @display_in, @from) AS MONEY) AS [olb]
	, Tr.loan_cycle
	, Us.first_name + SPACE(1) + Us.last_name AS [loan_admin]
	, Pack.name AS [product_name], Pack.code AS [product_code]
	, ISNULL(LiGrCr.guarantor, '-') AS [guarantor]
	, ISNULL(CAST(LiGrCr.guarantee_amount * dbo.GetXR(Pack.currency_id, @display_in, @from) AS MONEY), '-') AS [g_amount]
	, ISNULL(LiClCr.name, '-') AS [collateral]
	, ISNULL(CAST(LiClCr.collateral_amount * dbo.GetXR(Pack.currency_id, @display_in, @from) AS MONEY), '-') AS [c_amount]
	, Cr.grace_period
	, Cr.nb_of_installment AS [maturity]
	, Cr.interest_rate
	, al.late_days
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom1), '-') AS custom#1
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom2), '-') AS custom#2
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom3), '-') AS custom#3
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom4), '-') AS custom#4
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom5), '-') AS custom#5
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom6), '-') AS custom#6
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom7), '-') AS custom#7
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom8), '-') AS custom#8
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom9), '-') AS custom#9
	, ISNULL(dbo.GetAdvancedFieldValue(Tr.id, 'C', @custom10), '-') AS custom#10
	, COALESCE(nsg.name, LoShAm.group_name, '-') AS [group_name]
	, ISNULL(CAST(LoShAm.loan_share * dbo.GetXR(Pack.currency_id, @display_in, @from) AS MONEY), '-') AS [loan_share]
	, Br.code AS branch_name
	FROM @active_loans AS al
	INNER JOIN dbo.Contracts AS Cont ON Cont.id = al.id
	INNER JOIN dbo.Credit AS Cr ON Cr.id = Cont.id
	INNER JOIN dbo.Packages AS Pack ON Cr.package_id = Pack.id
	INNER JOIN dbo.Users AS Us ON Us.id = Cr.loanofficer_id
	LEFT JOIN dbo.Projects AS Pr ON Cont.project_id = Pr.id
	LEFT JOIN dbo.Tiers AS Tr ON Tr.id = Pr.tiers_id
	LEFT JOIN dbo.Branches Br ON Br.id = Tr.branch_id
	LEFT JOIN dbo.Districts AS Dis ON Dis.id = Tr.district_id
	LEFT JOIN dbo.Groups AS Gr ON Gr.id = Tr.id
	LEFT JOIN dbo.Persons AS Pers ON Pers.id = Tr.id
	LEFT JOIN dbo.EconomicActivities AS EcAc ON EcAc.id = Pers.activity_id
	LEFT JOIN 
	(
		SELECT DISTINCT LiGrCr.contract_id
		, Pr.first_name + SPACE(1) + Pr.last_name AS [guarantor]
		, LiGrCr.guarantee_amount
		FROM LinkGuarantorCredit AS LiGrCr
		INNER JOIN Tiers AS Tr ON Tr.id = LiGrCr.tiers_id
		INNER JOIN Persons AS Pr ON Pr.id = Tr.id
	) AS LiGrCr ON LiGrCr.contract_id = Cont.id
	LEFT JOIN
	(
		SELECT 
		CASE WHEN ISNUMERIC(CollateralPropertyValues.value) = 1 
			 THEN CONVERT(MONEY, CollateralPropertyValues.value) 
			 ELSE 0 
		END AS collateral_amount
		, CollateralsLinkContracts.contract_id AS [contract_id]
		, CollateralProducts.name AS [name]
		FROM dbo.CollateralsLinkContracts 
		INNER JOIN dbo.CollateralPropertyValues ON CollateralsLinkContracts.id = CollateralPropertyValues.contract_collateral_id
		INNER JOIN dbo.CollateralProperties ON CollateralProperties.id = CollateralPropertyValues.property_id
		INNER JOIN dbo.CollateralProducts ON CollateralProperties.product_id = CollateralProducts.id
		WHERE CollateralProperties.name = 'Amount' AND CollateralProperties.[type_id] = 1
	) AS LiClCr ON LiClCr.contract_id = Cont.id	
	LEFT JOIN
	(
		SELECT LoShAm.contract_id, LoShAm.person_id, Gr.name AS [group_name], LoShAm.amount AS [loan_share]
		FROM LoanShareAmounts AS LoShAm
		LEFT JOIN Groups AS Gr ON Gr.id = LoShAm.group_id
	) AS LoShAm ON LoShAm.person_id = Pers.id
	LEFT JOIN Corporates ON Tr.id = Corporates.id
	LEFT JOIN dbo.EconomicActivities AS CorporateActivities ON CorporateActivities.id = Corporates.activity_id
	LEFT JOIN dbo.Villages nsg ON Cont.nsg_id = nsg.id
	WHERE (Pack.currency_id = @disbursed_in OR 0 = @disbursed_in) AND (Tr.branch_id = @branch_id OR @branch_id = 0)
	ORDER BY type DESC, district, client_first_name,client_last_name
END
GO
/****** Object:  UserDefinedFunction [dbo].[Repayments_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Repayments_MC]
(
	@from DATETIME
	, @to DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
	SELECT re.contract_id
	, re.event_id
	, re.event_type
	, re.event_date
	, CAST(re.principal * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS principal
	, CAST(re.interest * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS interest
	, CAST(re.interest_wo_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS interest_wo_vat
	, CAST(re.interest_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS interest_vat
	, CAST(re.commissions * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS commissions
	, CAST(re.commissions_wo_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS commissions_wo_vat
	, CAST(re.commissions_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS commissions_vat
	, CAST(re.penalties * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS penalties
	, CAST(re.penalties_wo_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS penalties_wo_vat
	, CAST(re.penalties_vat * dbo.GetXR(pkg.currency_id, @display_in, re.event_date) AS MONEY) AS penalties_vat
	, re.written_off
	FROM dbo.Repayments(@from, @to, @user_id, @subordinate_id, @branch_id) AS re
	LEFT JOIN dbo.Credit AS cr ON cr.id = re.contract_id
	LEFT JOIN dbo.Packages AS pkg ON pkg.id = cr.package_id
	WHERE pkg.currency_id = @disbursed_in OR 0 = @disbursed_in	
)
GO
/****** Object:  StoredProcedure [dbo].[GetDashboard]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDashboard]
    @date DATETIME, 
    @userId INT,
    @branchId INT,
    @subordinateId INT,
    @loanProductId INT
AS BEGIN
    DECLARE @users TABLE
    (
        id INT
    )
    IF @subordinateId = 0
    BEGIN
        INSERT INTO @users
        SELECT @userId
        INSERT INTO @users
        SELECT subordinate_id
        FROM dbo.UsersSubordinates
        WHERE user_id = @userId
    END
    ELSE
    BEGIN
        INSERT INTO @users
        SELECT @subordinateId
    END
    
    DECLARE @branches TABLE
    (
        id INT
    )
    IF @branchId = 0
    BEGIN
        INSERT INTO @branches
        SELECT branch_id
        FROM dbo.UsersBranches
        WHERE user_id = @userId
    END
    ELSE
    BEGIN
        INSERT INTO @branches
        SELECT @branchId
    END
    
    IF @subordinateId = 0 AND @branchId > 0
    BEGIN
        DELETE @users
        INSERT INTO @users
        SELECT user_id
        FROM dbo.UsersBranches
        WHERE branch_id IN (SELECT id FROM @branches)
    END
    
    DECLARE @loanProducts TABLE
    (
        id INT
    )
    IF @loanProductId = 0
    BEGIN
        INSERT INTO @loanProducts
        SELECT id FROM dbo.Packages
    END
    ELSE
    BEGIN
        INSERT INTO @loanProducts
        SELECT @loanProductId
    END
    ;
    
    DECLARE @activeLoans TABLE
    (
        id INT,
        late_days INT,
        olb MONEY
    )
    INSERT INTO @activeLoans
    SELECT
        al.id,
        al.late_days,
        al.olb
    FROM dbo.ActiveLoans(@date, 0) al
    INNER JOIN dbo.Credit cr ON cr.id = al.id
    WHERE cr.loanofficer_id IN (SELECT id FROM @users)
        AND cr.package_id IN (SELECT id FROM @loanProducts)
     
    
         SELECT 
         ldr.Label AS name,
         (SELECT ISNULL(SUM(al.olb), 0) FROM @activeLoans AS al WHERE al.late_days BETWEEN ldr.Min AND ldr.Max) AS amount
         , (SELECT  COUNT(al.id)  FROM @activeLoans AS al WHERE al.late_days BETWEEN ldr.Min AND ldr.Max) AS quantity
         , ISNULL(ldr.Color, '0') AS color
         FROM dbo.LateDaysRange AS ldr
          
    ----------------------------------------------------------------------------------------------
    DECLARE @endDate DATETIME = CAST(@date as date) 
    DECLARE @startDate DATETIME = CAST(DATEADD(DD, -9, @endDate) AS DATE)
    ;
    WITH dates AS
    (
        SELECT @startDate date
        UNION ALL
        SELECT date + 1
        FROM dates
        WHERE date + 1 <= @endDate
    )
    SELECT
        d.date,
        ISNULL(de.number, 0) number_disbursed,
        ISNULL(de.amount, 0) amount_disbursed,
        ISNULL(re.number, 0) number_repaid,
        ISNULL(re.amount, 0) amount_repaid
    FROM dates d
    LEFT JOIN
    (
        SELECT
            CAST(ce.event_date AS DATE) date,
            COUNT(de.id) number,
            SUM(de.amount) amount
        FROM dbo.ContractEvents ce
        INNER JOIN dbo.LoanDisbursmentEvents de ON de.id = ce.id
        INNER JOIN dbo.Credit cr ON cr.id = ce.contract_id
        WHERE
            ce.is_deleted = 0
            AND ce.user_id IN (SELECT id FROM @users)
            AND cr.package_id IN (SELECT id FROM @loanProducts)
        GROUP BY
            CAST(ce.event_date AS DATE)
    ) de ON de.date = d.date
    LEFT JOIN
    (
        SELECT
            CAST(ce.event_date AS DATE) date,
            COUNT(ce.parent_id) number,
            SUM(re.principal + re.interests + re.penalties + re.commissions) amount
        FROM dbo.ContractEvents ce
        INNER JOIN dbo.RepaymentEvents re ON re.id = ce.id
        INNER JOIN dbo.Credit cr ON cr.id = ce.contract_id
        WHERE
            ce.is_deleted = 0
            AND ce.user_id IN (SELECT id FROM @users)
            AND cr.package_id IN (SELECT id FROM @loanProducts)
        GROUP BY
            CAST(ce.event_date AS DATE)
    ) re ON re.date = d.date
END
GO
/****** Object:  UserDefinedFunction [dbo].[ExpectedInstallments_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- The multi-currency counterpart of ExpectedInstallments -
-- see the comment to *that* function for details.
--
-- HISTORY
--
-- Mar 30, 2011 - v2.8.14 - Pasha BASTOV - Create the function
--
-- Apr 14, 2011 - v2.8.15 - Pasha BASTOV - Add @branch_id as a parameter
CREATE FUNCTION [dbo].[ExpectedInstallments_MC]
(
	@from DATETIME
	, @to DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
)
RETURNS TABLE AS
RETURN
(
	SELECT contract_id
	, i.number
	, i.expected_date
	, i.principal * dbo.GetXR(p.currency_id, @display_in, @from) AS principal
	, i.prepaid_principal * dbo.GetXR(p.currency_id, @display_in, @from) AS prepaid_principal
	, i.interest * dbo.GetXR(p.currency_id, @display_in, @from) AS interest
	, i.prepaid_interest * dbo.GetXR(p.currency_id, @display_in, @from) AS prepaid_interest
	FROM dbo.ExpectedInstallments(@from, @to, @user_id, @subordinate_id, @branch_id) AS i
	LEFT JOIN dbo.Credit AS c ON c.id = i.contract_id
	LEFT JOIN dbo.Packages AS p ON p.id = c.package_id
	WHERE 0 = @disbursed_in OR p.currency_id = @disbursed_in
)
GO
/****** Object:  UserDefinedFunction [dbo].[PenaltiesCalculation]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[PenaltiesCalculation]
( @contract_id INT, @installment_number INT, @endDate datetime)
RETURNS MONEY
AS 
BEGIN
  DECLARE @Penalties TABLE (
   IDD INT IDENTITY(1, 1),
   expected_date datetime,
   capital_repayment money,
   interest_repayment money,
   contract_id int NOT NULL,
   paid_capital money,
   paid_date datetime,
   number int,
   Penalties_based_on_overdue_principal MONEY,
   Penalties_based_on_overdue_interest MONEY,
   Penalties_based_on_OLB MONEY,
   Penalties_based_on_initial_amount MONEY
  )
 
  DECLARE @counter INT
  DECLARE @LastInst INT
  DECLARE @I INT
  DECLARE @Date1 DATETIME
  DECLARE @LATE_DAYS_AFTER_ACCRUAL_CEASES INT
  DECLARE @Penalties_based_on_overdue_principal FLOAT
  DECLARE @Penalties_based_on_overdue_interest FLOAT
  DECLARE @Penalties_based_on_OLB FLOAT
  DECLARE @Penalties_based_on_initial_amount FLOAT
  DECLARE @TotalPenalties FLOAT
  DECLARE @expected_principal FLOAT
  DECLARE @expected_interests FLOAT
  DECLARE @value_first_inst_principal FLOAT
  DECLARE @value_first_inst_interest FLOAT
  DECLARE @OLB FLOAT
  DECLARE @Last_repayment_date DATETIME
  DECLARE @days_late INT
  SET @Last_repayment_date = (select max(event_date)
			    		    from contractEvents inner join
					             repaymentEvents on repaymentEvents.id = contractEvents.id
					        where contractEvents.contract_id = @contract_id and is_deleted=0)
  SET @days_late = CASE 
						WHEN dbo.getLateDays(@endDate, @contract_Id,@installment_number) < DATEDIFF(d,@Last_repayment_date,@endDate)
							THEN DATEDIFF(d,@Last_repayment_date,@endDate)
						ELSE dbo.getLateDays(@endDate, @contract_Id,@installment_number) 
				   END
					
  SELECT @LATE_DAYS_AFTER_ACCRUAL_CEASES = CONVERT(INT, value)
  FROM GeneralParameters
  WHERE [key] = 'LATE_DAYS_AFTER_ACCRUAL_CEASES'
  
  
  SELECT @Penalties_based_on_overdue_principal = non_repayment_penalties_based_on_overdue_principal,
		 @Penalties_based_on_overdue_interest = non_repayment_penalties_based_on_overdue_interest,
		 @Penalties_based_on_OLB = non_repayment_penalties_based_on_OLB,
		 @Penalties_based_on_initial_amount = non_repayment_penalties_based_on_initial_amount
  FROM   dbo.Contracts INNER JOIN 
		 Credit ON contracts.id = credit.id inner join
		 projects on projects.id = contracts.project_id 
  WHERE Contracts.id = @contract_id
  INSERT INTO @Penalties ( expected_date, capital_repayment, interest_repayment, contract_id, paid_capital, paid_date, number )
  SELECT
     expected_date,
     capital_repayment,
	 interest_repayment,
     contract_id,
     paid_capital,
     paid_date,	
	 number
  FROM dbo.Installments
  WHERE contract_id = @contract_id
	AND number >= @installment_number
	AND expected_date <= @endDate
  SET @counter = @installment_number;
  SET @LastInst = (select max(number) from @Penalties);
  
  WHILE ( @counter <= @LastInst)
    BEGIN             
  
	
      SELECT @Date1 =  ISNULL(paid_date, expected_date), @expected_principal = capital_repayment, @expected_interests = interest_repayment
      FROM   @Penalties
      WHERE  number = @counter  
     
SET @value_first_inst_principal = 		( (isnull((select sum(capital_repayment)
								 from installments
								 where installments.contract_id = @contract_id and number <= @counter),0))
								 - (isnull((select sum(principal)
								  from contractEvents inner join
									   repaymentEvents on repaymentEvents.id = contractEvents.id
								   where contractEvents.contract_id = @contract_id and is_deleted=0  and event_date <= @endDate),0))
								)
SET @value_first_inst_interest = 	( (isnull((select sum(interest_repayment)
								 from installments
								 where installments.contract_id = @contract_id and number <= @counter),0))
								 - (isnull((select sum(interests)
								  from contractEvents inner join
									   repaymentEvents on repaymentEvents.id = contractEvents.id
								   where contractEvents.contract_id = @contract_id and is_deleted=0  and event_date <= @endDate),0))
								)
      UPDATE @Penalties
      SET 
      Penalties_based_on_overdue_interest = @Penalties_based_on_overdue_interest * 
								(CASE WHEN (@counter = @installment_number) and (@value_first_inst_interest < @expected_interests)
								 then 0
								 else (@expected_interests) 
								END)
									 *
                                               CASE 
                                                 WHEN DATEDIFF(day, @Date1, @endDate) > @LATE_DAYS_AFTER_ACCRUAL_CEASES THEN @LATE_DAYS_AFTER_ACCRUAL_CEASES
                                                 ELSE DATEDIFF(day, @Date1, @endDate)
                                               END
      WHERE number = @counter ;   
      UPDATE @Penalties
      SET 
      Penalties_based_on_overdue_principal = @Penalties_based_on_overdue_principal * 
								(CASE WHEN (@counter = @installment_number) and (@value_first_inst_principal < @expected_principal)
								 then 0
								 else (@expected_principal) 
								END)
									 *
                                   CASE 
                                     WHEN DATEDIFF(day, @Date1, @endDate) > @LATE_DAYS_AFTER_ACCRUAL_CEASES THEN @LATE_DAYS_AFTER_ACCRUAL_CEASES
                                     ELSE DATEDIFF(day, @Date1, @endDate)
                                   END
      WHERE number = @counter ;     
     
      SET @counter = @counter + 1;
    END  
SET @OLB = 	ISNULL (
			        (SELECT credit.amount
					 FROM credit
					 WHERE (credit.id = @contract_id))
					-
					(select sum(principal)
					 from contractEvents inner join
					      repaymentEvents on repaymentEvents.id = contractEvents.id
					 where contractEvents.contract_id = @contract_id and is_deleted=0 and event_date <= @endDate)
				  , 0)
      UPDATE @Penalties
      SET 
      Penalties_based_on_OLB = @Penalties_based_on_OLB * @OLB * 
							   CASE WHEN datediff(day,@Last_repayment_date,@endDate) < @days_late
									then datediff(day,@Last_repayment_date,@endDate) 
									else @days_late 
							   end
      WHERE number = @counter-1 ;             
     
      UPDATE @Penalties
      SET 
      Penalties_based_on_initial_amount = @Penalties_based_on_initial_amount * 	(select credit.amount from credit where credit.id = @contract_id) *
							   CASE WHEN datediff(day,@Last_repayment_date,@endDate) < @days_late
									then datediff(day,@Last_repayment_date,@endDate) 
									else @days_late 
							   end
      WHERE number = @counter-1 ;   
  SELECT @TotalPenalties = (isnull(SUM(Penalties_based_on_initial_amount),0)
						  +isnull(sum(Penalties_based_on_OLB),0)
                          +isnull(sum(Penalties_based_on_overdue_principal),0)
                          +isnull(sum(Penalties_based_on_overdue_interest),0))
  FROM  @Penalties 
  RETURN round(@TotalPenalties,2)
END
GO
/****** Object:  UserDefinedFunction [dbo].[LateAmounts_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[LateAmounts_MC] (@date DATETIME, @disbursed_in INT, @display_in INT, @user_id INT, @subordinate_id INT, @branch_id INT)
RETURNS TABLE AS
RETURN
(
	SELECT la.contract_id
	, la.principal * dbo.GetXR(p.currency_id, @display_in, @date) AS principal
	, la.interest * dbo.GetXR(p.currency_id, @display_in, @date) AS interest
	FROM dbo.LateAmounts(@date, @user_id, @subordinate_id, @branch_id) AS la
	INNER JOIN dbo.Credit AS c ON c.id = la.contract_id
	LEFT JOIN dbo.Packages AS p ON p.id = c.package_id
	WHERE 0 = @disbursed_in OR p.currency_id = @disbursed_in
)
GO
/****** Object:  UserDefinedFunction [dbo].[ActiveLoans_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of active loans with exchange rates applied
--
-- HISTORY
--
-- Apr 13, 2011 - v2.8.15 - Pasha BASTOV
-- Add @branch_id to the list of parameters
CREATE FUNCTION [dbo].[ActiveLoans_MC](@date DATETIME, @disbursed_in INT, @display_in INT, @branch_id INT)
RETURNS TABLE AS
RETURN
(
	SELECT al.id
	, al.amount * dbo.GetXR(p.currency_id, @display_in, @date) amount
	, al.olb* dbo.GetXR(p.currency_id, @display_in, @date) olb
	, al.interest * dbo.GetXR(p.currency_id, @display_in, @date) interest
	, al.initial_interest * dbo.GetXR(p.currency_id, @display_in, @date) initial_interest
	, al.initial_interest * dbo.GetXR(p.currency_id, @display_in, @date) - al.interest * dbo.GetXR(p.currency_id, @display_in, @date) paid_interest
	, al.late_days
	FROM dbo.ActiveLoans(@date, @branch_id) AS al
	LEFT JOIN dbo.Credit AS c ON c.id = al.id
	LEFT JOIN dbo.Packages AS p ON p.id = c.package_id
	WHERE 0 = @disbursed_in OR p.currency_id = @disbursed_in
)
GO
/****** Object:  UserDefinedFunction [dbo].[Balances]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Balances]
(
	@date DATETIME
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
	WITH _installments
	AS
	(
		SELECT i.contract_id, SUM(principal) AS principal,
		SUM(interest) AS interest
		FROM dbo.InstallmentSnapshot(@date) AS i
		WHERE i.expected_date <= @date
		GROUP BY i.contract_id
	)
	, _repayments
	AS
	(
		SELECT ce.contract_id, SUM(re.principal) AS principal,
		SUM(re.interests) AS interest
		FROM dbo.RepaymentEvents AS re
		LEFT JOIN dbo.ContractEvents AS ce ON ce.id = re.id
		WHERE ce.is_deleted = 0 AND ce.event_date <= @date
		GROUP BY ce.contract_id
	)
	SELECT al.id AS contract_id, ISNULL(_r.principal, 0) - ISNULL(_i.principal, 0) AS principal,
	ISNULL(_r.interest, 0) - ISNULL(_i.interest, 0) AS interest
	FROM dbo.ActiveLoans(@date, @branch_id) AS al
	LEFT JOIN _installments AS _i ON _i.contract_id = al.id
	LEFT JOIN _repayments AS _r ON _r.contract_id = _i.contract_id
)
GO
/****** Object:  UserDefinedFunction [dbo].[Alerts]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of alerts, i.e. pending and late loans, 
-- along with overdraft and pending savings
--
-- HISTORY
--
-- Jul 13, 2011 - v3.2.0  - Ruslan KAZAKOV
-- Overdraft and pending savings update to use ActiveSavingContracts()
--
-- Apr 13, 2011 - v2.8.15 - Pasha BASTOV
-- Add @branch_id to the list of parameters
-- Apr 16, 2012 - v3.8 - Munduzbek SUBANOV
CREATE FUNCTION [dbo].[Alerts](@date DATETIME, @user_id INT, @branch_id INT)
RETURNS @tbl TABLE (
	id INT NOT NULL
	, kind INT NOT NULL
	, status INT NOT NULL
	, date DATETIME NOT NULL
	, late_days INT NOT NULL
	, amount MONEY NOT NULL
	, use_cents BIT NOT NULL
	, contract_code NVARCHAR(255) NOT NULL
	, client_name NVARCHAR(100) NOT NULL
	, loan_officer_id INT NOT NULL
	, city NVARCHAR(100) NOT NULL
	, address NVARCHAR(255) NOT NULL
	, phone NVARCHAR(100) NOT NULL
	, branch_name NVARCHAR(100) NOT NULL
) AS
BEGIN
	DECLARE @_date DATETIME
	DECLARE @_user_id INT
	
	SET @_date = @date
	SET @_user_id = @user_id
	
	DECLARE @active_loans TABLE
	(
	    id INT
	    , client_id INT
	    , expected_date DATETIME
	    , principal_due MONEY
	    , interest_due MONEY
	    , late_days INT
	    , branch_name NVARCHAR(100)
	)
	
	INSERT INTO @active_loans
	SELECT al.id, client_id, expected_date, principal_due, interest_due, late_days, Branches.name
	FROM dbo.ActiveLoans(@_date, 0) AS al
	INNER JOIN Tiers ON al.client_id=Tiers.id
	INNER JOIN Branches ON Tiers.branch_id=Branches.id
	
	;WITH _contracts
	AS (
		-- Late and performing loans (due today)
		SELECT al.id
		, 5 AS status	
		, al.expected_date AS date
		, al.principal_due + interest_due AS amount
		, al.late_days
		, br.name AS branch_name
		FROM @active_loans al
		INNER JOIN dbo.Tiers t on t.id = al.client_id
		INNER JOIN dbo.Branches AS br ON t.branch_id=br.id
		WHERE (late_days > 0 OR (0 = late_days AND NOT expected_date IS NULL))
		and t.branch_id in (
			select branch_id
			from dbo.UsersBranches
			where user_id = @_user_id
		)
		
		UNION ALL
		-- Pending, Postponed and Validated loans	
		SELECT c.id
		, c.status
		, c.start_date AS date
		, cr.amount
		, 0 AS late_days
		, br.name AS branch_name
		FROM dbo.Contracts AS c
		INNER JOIN dbo.Credit AS cr ON cr.id = c.id
		INNER JOIN dbo.Projects AS j ON j.id = c.project_id
		INNER JOIN dbo.Tiers AS t ON t.id = j.tiers_id
		INNER JOIN dbo.Branches AS br ON t.branch_id=br.id
		WHERE c.status IN (1, 2, 8)
		and t.branch_id in (
			select branch_id
			from dbo.UsersBranches
			where user_id = @_user_id
		)
	)
	INSERT @tbl
	SELECT _c.id
	, 1 AS kind
	, _c.status
	, _c.date
	, _c.late_days
	, _c.amount
	, cur.use_cents
	, c.contract_code
	, cl.name AS client_name
	, cr.loanofficer_id
	, ISNULL(t.city, '') AS city
	, COALESCE(t.address, t.secondary_address, '') AS address
	, COALESCE(t.home_phone, t.personal_phone, t.secondary_home_phone, t.secondary_personal_phone, '') AS phone
	, _c.branch_name
	FROM _contracts AS _c
	LEFT JOIN dbo.Contracts AS c ON c.id = _c.id
	LEFT JOIN dbo.Credit AS cr ON cr.id = c.id
	LEFT JOIN dbo.Projects AS j ON j.id = c.project_id
	LEFT JOIN dbo.Packages AS pack ON pack.id = cr.package_id
	LEFT JOIN dbo.Currencies AS cur ON cur.id = pack.currency_id
	LEFT JOIN dbo.Tiers AS t ON t.id = j.tiers_id
	LEFT JOIN dbo.Clients AS cl ON cl.id = t.id
	WHERE cr.loanofficer_id = @_user_id OR cr.loanofficer_id IN (
		SELECT subordinate_id 
		FROM dbo.UsersSubordinates
		WHERE user_id = @_user_id
	)
	
	-- Overdraft savings
	INSERT @tbl
	SELECT c.id
	, 2 AS kind
	-- Pasha BASTOV:
	-- The status below is in fact 1, since 1 for Savings means Active.
	-- But for the sake of consistency I intentionally change it to 5,
	-- since 5 means Active for loans and somehow loans prevail because
	-- they appeared first historically blah blah blah.
	-- Since it does not seem to be used / affect any code outside the
	-- Alerts window, I dare do so.
	, 5 AS status
	, c.creation_date AS date
	, 0 AS late_days
	, ActSC.balance AS amount
	, cur.use_cents
	, c.code AS contract_code
	, cl.name AS client_name
	, c.savings_officer_id
	, ISNULL(t.city, '') AS city 
	, COALESCE(t.address, t.secondary_address, '') AS address
	, COALESCE(t.home_phone, t.personal_phone, t.secondary_home_phone, t.secondary_personal_phone, '') AS phone
	, br.name AS branch_name
	FROM ActiveSavingContracts(@_date, @branch_id) AS ActSC
	INNER JOIN SavingContracts AS c ON c.id = ActSC.contract_id
	INNER JOIN SavingProducts AS SaPr ON SaPr.id = c.product_id
	INNER JOIN Tiers AS t ON t.id = c.tiers_id 
	LEFT JOIN dbo.Clients AS cl ON cl.id = t.id
	INNER JOIN dbo.Currencies AS cur ON cur.id = SaPr.currency_id
	INNER JOIN Branches AS br ON t.branch_id=br.id
	WHERE ActSC.balance < 0 AND c.status = 1
	AND (c.savings_officer_id = @_user_id OR c.savings_officer_id IN
	(
		SELECT subordinate_id
		FROM dbo.UsersSubordinates
		WHERE user_id = @_user_id
	))
	and t.branch_id in (
		select branch_id
		from dbo.UsersBranches
		where user_id = @_user_id
	)
	
	UNION ALL
	
	-- Pending savings
	SELECT c.id
	, 2 AS kind
	, 1 AS status
	, c.creation_date AS date
	, 0 AS late_days
	, ActSC.balance AS amount
	, cur.use_cents
	, c.code AS contract_code
	, cl.name AS client_name
	, c.savings_officer_id
	, ISNULL(t.city, '') AS city 
	, COALESCE(t.address, t.secondary_address, '') AS address
	, COALESCE(t.home_phone, t.personal_phone, t.secondary_home_phone, t.secondary_personal_phone, '') AS phone
	, br.name AS branch_name
	FROM ActiveSavingContracts(@_date, @branch_id) AS ActSC
	
	INNER JOIN SavingContracts AS c ON c.id = ActSC.contract_id
	INNER JOIN SavingProducts AS SaPr ON SaPr.id = c.product_id
	INNER JOIN
	(
		SELECT contract_id
		FROM SavingEvents 
		WHERE code = 'SPDE' AND deleted = 0 AND is_fired = 1 AND pending = 1 AND creation_date <= @_date
		GROUP BY contract_id
	) AS b ON b.contract_id = c.id
	INNER JOIN Tiers AS t ON t.id = c.tiers_id 
	LEFT JOIN dbo.Clients AS cl ON cl.id = t.id
	INNER JOIN dbo.Currencies AS cur ON cur.id = SaPr.currency_id
	INNER JOIN dbo.Branches AS br ON t.branch_id=br.id
	WHERE (c.savings_officer_id = @_user_id OR c.savings_officer_id IN
	(
		SELECT subordinate_id
		FROM dbo.UsersSubordinates
		WHERE user_id = @_user_id
	))
	and t.branch_id in (
		select branch_id
		from dbo.UsersBranches
		where user_id = @_user_id
	)
	
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[ActiveClients]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ActiveClients](@date datetime, @branch_id int)
returns table as return (
WITH loans
AS
(
	select id contract_id
		, olb
		, interest
		, late_days
		, amount
		, client_id
		, client_type_code
		, initial_interest
		, paid_interest
	from dbo.ActiveLoans(@date, @branch_id)	
)
, counts as (
	select contract_id, count(*) total
	from dbo.LoanShareAmounts
	group by contract_id
)
, shares as (
	select al.*
	, lsa.person_id
	, lsa.amount share	
	, row_number() over (partition by lsa.contract_id order by person_id) number
	, floor(lsa.amount*al.olb/al.amount) olb_share
	, floor(lsa.amount*al.interest/al.amount) interest_share
	, FLOOR(lsa.amount*al.initial_interest/al.amount) initial_interest_share
	, FLOOR(lsa.amount*al.paid_interest/al.amount) paid_interest_share
	from loans al
	left join dbo.LoanShareAmounts lsa on lsa.contract_id = al.contract_id
	where al.client_type_code = 'G'
)
, shares_rt as (
	select a.contract_id
	, a.person_id
	, a.olb
	, a.interest
	, a.share
	, a.amount
	, a.number
	, a.olb_share
	, a.initial_interest
	, a.interest_share
	, a.initial_interest_share
	, isnull(sum(b.olb_share), 0) olb_share_rt
	, isnull(sum(b.interest_share), 0) interest_share_rt
	, ISNULL(SUM(b.initial_interest_share), 0) initial_interest_share_rt
	, a.late_days
	from shares a
	left join shares b on a.contract_id = b.contract_id and b.number < a.number
	group by a.contract_id
	, a.person_id
	, a.olb
	, a.interest
	, a.initial_interest
	, a.initial_interest_share
	, a.share
	, a.amount
	, a.number
	, a.olb_share
	, a.interest_share	
	, a.late_days
)
select s.person_id id
, s.contract_id
, s.share amount
, case 
	when s.number < c.total then olb_share
	else olb - olb_share_rt
end olb
, case 
	when s.number < c.total then interest_share
	else interest - interest_share_rt
end interest
, CASE
	WHEN s.number < c.total THEN initial_interest_share
	ELSE initial_interest - initial_interest_share_rt
END initial_interest
, CASE
	WHEN s.number < c.total THEN initial_interest_share - interest_share
	ELSE (initial_interest - initial_interest_share_rt) - (interest - interest_share_rt)
END paid_interest
, s.late_days
from shares_rt s
left join counts c on s.contract_id = c.contract_id
union all
select client_id id
, contract_id
, amount
, olb
, interest
, initial_interest
, paid_interest
, late_days
from loans
where client_type_code in ('I','C')
)
GO
/****** Object:  UserDefinedFunction [dbo].[Balances_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Balances_MC]
(
	@date DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @branch_id INT
)
RETURNS TABLE
AS
RETURN
(
	SELECT b.contract_id,
	CAST(b.principal * dbo.GetXR(pkg.currency_id, @display_in, @date) AS MONEY) AS principal,
	CAST(b.interest * dbo.GetXR(pkg.currency_id, @display_in, @date) AS MONEY) AS interest
	FROM dbo.Balances(@date, @branch_id) AS b
	LEFT JOIN dbo.Credit AS cr ON cr.id = b.contract_id
	LEFT JOIN dbo.Packages AS pkg ON pkg.id = cr.package_id
	WHERE pkg.currency_id = @disbursed_in OR 0 = @disbursed_in
)
GO
/****** Object:  UserDefinedFunction [dbo].[ActiveClients_MC]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Return a list of active clients with exchange rates applied
--
-- HISTORY
--
-- 13 Apr, 2011 - v2.8.15 - Pasha BASTOV
-- Add @branch_id to the list of parameters
CREATE FUNCTION [dbo].[ActiveClients_MC](@date DATETIME, @disbursed_in INT, @display_in INT, @branch_id INT)
RETURNS TABLE AS
RETURN
(
	SELECT ac.id
	, ac.contract_id
	, ac.amount * dbo.GetXR(p.currency_id, @display_in, @date) amount
	, ac.olb* dbo.GetXR(p.currency_id, @display_in, @date) olb
	, ac.interest * dbo.GetXR(p.currency_id, @display_in, @date) interest
	, ac.initial_interest * dbo.GetXR(p.currency_id, @display_in, @date) initial_interest
	, ac.initial_interest * dbo.GetXR(p.currency_id, @display_in, @date) - ac.interest * dbo.GetXR(p.currency_id, @display_in, @date) paid_interest
	, ac.late_days
	FROM dbo.ActiveClients(@date, @branch_id) AS ac
	INNER JOIN dbo.Credit AS c ON c.id = ac.contract_id
	LEFT JOIN dbo.Packages AS p ON p.id = c.package_id
	WHERE 0 = @disbursed_in OR p.currency_id = @disbursed_in
)
GO
/****** Object:  StoredProcedure [dbo].[Rep_Repayments]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Repayments]
	@from DATETIME
	, @to DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @user_id INT
	, @subordinate_id INT
	, @branch_id INT
AS BEGIN
	 
		SELECT Reps.event_date AS [date]
			, Cont.contract_code 
			,COALESCE(Gr.name, Corp.name, ISNULL(Pers.first_name, '')) AS [client_first_name]
                        ,ISNULL(Pers.last_name, '') AS [client_last_name]
                        , Dts.name AS [district_name]
			, Us.first_name + SPACE(1) + Us.last_name AS [loan_officer_name]
			, Pack.name AS [loan_product_name]
			, Br.code AS branch_name
			, Reps.commissions AS [early_fee]
			, Reps.penalties AS [late_fee]
			, Reps.principal
			, Reps.interest
			, (Reps.principal + Reps.interest + Reps.commissions + Reps.penalties) AS [total]
			, Reps.written_off
		FROM dbo.Repayments_MC(@from, @to, @disbursed_in, @display_in, @user_id, @subordinate_id, @branch_id) AS Reps
		LEFT JOIN dbo.ContractEvents AS ConEv ON ConEv.id = Reps.event_id
		LEFT JOIN dbo.Credit AS Cr ON Cr.id = Reps.contract_id
		LEFT JOIN dbo.Contracts AS Cont ON Reps.contract_id = Cont.id
		LEFT JOIN dbo.Projects AS Pr ON Cont.project_id = Pr.id
		LEFT JOIN dbo.Groups AS Gr ON Gr.id = Pr.tiers_id
		LEFT JOIN dbo.Persons AS Pers ON Pers.id = Pr.tiers_id
		LEFT JOIN dbo.Corporates AS Corp ON Corp.id = Pr.tiers_id
		LEFT JOIN dbo.Tiers AS Trs ON Pr.tiers_id = Trs.id
		LEFT JOIN dbo.Branches Br ON Br.id = Trs.branch_id
		LEFT JOIN dbo.Districts AS Dts ON Dts.id = Trs.district_id
		LEFT JOIN dbo.Users AS Us ON Cr.loanofficer_id = Us.id
		LEFT JOIN dbo.Packages AS Pack ON Cr.package_id = Pack.id
		ORDER BY Reps.event_date DESC
END
GO
/****** Object:  StoredProcedure [dbo].[Rep_OLB_and_LLP]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--if OBJECT_ID('dbo.Rep_OLB_and_LLP ') is not null
--drop procedure dbo.Rep_OLB_and_LLP 
--go

CREATE PROCEDURE [dbo].[Rep_OLB_and_LLP] 
	@date DATETIME
	, @disbursed_in INT
	, @display_in INT
	, @user_id INT
	, @subordinate_id nvarchar(max)
    , @branch_id INT
AS BEGIN
	

		DECLARE @users TABLE
		(
			id INT NOT NULL
		)
		IF EXISTS (SELECT * FROM dbo.IntListToTable(@subordinate_id) WHERE number = 0)
		BEGIN
			INSERT INTO @users
			SELECT @user_id
			INSERT INTO @users
			SELECT subordinate_id
			FROM dbo.UsersSubordinates
			WHERE user_id = @user_id
		END
		ELSE
		BEGIN
			INSERT INTO @users
			SELECT number
			FROM dbo.IntListToTable(@subordinate_id)
		END

		DECLARE @active_loans TABLE (
			id INT NOT NULL
			, olb MONEY NOT NULL
			, interest MONEY NOT NULL
			, late_days INT NOT NULL
			, rescheduled BIT NOT NULL
		)

		DECLARE @re_llp_rate FLOAT
		SELECT @re_llp_rate = provisioning_value
		FROM dbo.ProvisioningRules
		WHERE number_of_days_min = -1 AND number_of_days_max = -1

		INSERT INTO @active_loans
		SELECT id, olb, interest, late_days, CASE WHEN re.contract_id IS NULL THEN 0 ELSE 1 END
		FROM dbo.ActiveLoans_MC(@date, @disbursed_in, @display_in, @branch_id) al
		LEFT JOIN (
			SELECT contract_id
			FROM dbo.ContractEvents
			WHERE event_type = 'ROLE' AND convert(date, event_date) <= @date AND is_deleted = 0
			GROUP BY contract_id
		) re ON re.contract_id = al.id

        DECLARE @installments TABLE
        (
            contract_id INT NOT NULL
            , last_expected_date DATETIME NOT NULL
        )
        INSERT INTO @installments
        SELECT contract_id, MAX(expected_date)
        FROM dbo.InstallmentSnapshot(@date)
        GROUP BY contract_id

		SELECT c.contract_code
		, al.olb
		, al.interest
		, al.late_days
		,substring(cl.name,0,CHARINDEX(' ',cl.name)) as client_first_name
                ,substring(cl.name,CHARINDEX(' ',cl.name),LEN(cl.name)) as client_last_name
		, u.first_name + ' ' + u.last_name loan_officer_name
		, b.code AS branch_name
		, pack.name product_name
		, d.name district_name
		, cur.name currency_name
		, c.start_date
                , i.last_expected_date close_date
		, pr.number_of_days_min range_from
		, pr.number_of_days_max range_to
		, CASE
			WHEN 1 = al.rescheduled AND pr.provisioning_value < @re_llp_rate THEN @re_llp_rate * 100
			ELSE pr.provisioning_value * 100
		END llp_rate
		, CASE
			WHEN 1 = al.rescheduled AND pr.provisioning_value < @re_llp_rate THEN CAST(ROUND(al.olb * @re_llp_rate, 0) AS MONEY)
			ELSE CAST(ROUND(al.olb * pr.provisioning_value, 0) AS MONEY)
		END llp
		, CASE WHEN 1 = al.rescheduled THEN 'Rescheduled loans' ELSE '' END rescheduled
		FROM @active_loans al
		INNER JOIN dbo.Contracts c ON c.id = al.id
		INNER JOIN dbo.Projects j ON j.id = c.project_id
		INNER JOIN dbo.Credit cr ON cr.id = c.id
		INNER JOIN dbo.Packages pack ON pack.id = cr.package_id
		INNER JOIN dbo.Tiers t ON t.id = j.tiers_id
		LEFT JOIN dbo.Branches b ON b.id = t.branch_id
		INNER JOIN dbo.Districts d ON d.id = t.district_id
		INNER JOIN dbo.Clients cl ON cl.id = t.id
		INNER JOIN dbo.Users u ON u.id = cr.loanofficer_id
		INNER JOIN dbo.Currencies cur ON cur.id = pack.currency_id
		--INNER JOIN dbo.ProvisioningRules pr ON al.late_days BETWEEN pr.number_of_days_min AND pr.number_of_days_max
		INNER JOIN (
			SELECT number_of_days_min, number_of_days_max, provisioning_value
			FROM dbo.ProvisioningRules
			GROUP BY number_of_days_min, number_of_days_max, provisioning_value
		           ) pr ON al.late_days BETWEEN pr.number_of_days_min AND pr.number_of_days_max
            INNER JOIN @installments i ON i.contract_id = c.id
		--WHERE (cr.loanofficer_id IN (SELECT id FROM @users) or SELECT * FROM dbo.IntListToTable(@subordinate_id) where number!=0))
		WHERE cr.loanofficer_id IN (SELECT id FROM @users)
		ORDER BY al.rescheduled, al.late_days, cur.name
	
END
GO
/****** Object:  StoredProcedure [dbo].[Rep_PAR_Analysis]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_PAR_Analysis] @date DATETIME, @user_id INT, @branch_id INT, @subordinate_id INT, @disbursed_in INT, @display_in INT
AS BEGIN
		DECLARE @active_clients TABLE
		(
			id INT NOT NULL
			, contract_id INT NOT NULL
			, olb MONEY NOT NULL
			, late_days INT NOT NULL
			, district_id INT NOT NULL
			, loan_officer_id INT NOT NULL
			, product_id INT NOT NULL
			, client_type_code CHAR(1) NOT NULL
			, activity_id INT NOT NULL
			, branch_id INT NOT NULL
			, num INT NOT NULL
			
		)

		DECLARE @active_loans TABLE
		(
			id INT NOT NULL
			, olb MONEY NOT NULL
			, late_days INT NOT NULL
			, district_id INT NOT NULL
		)

		DECLARE @users TABLE
		(
			id INT NOT NULL
		)
		
		INSERT INTO @users
		SELECT @user_id
		INSERT INTO @users
		SELECT subordinate_id
		FROM dbo.UsersSubordinates
		WHERE user_id = @user_id
		
		INSERT INTO @active_clients
		SELECT ac.id
			, ac.contract_id
			, ac.olb
			, ac.late_days
			, t.district_id
			, cr.loanofficer_id
			, cr.package_id
			, t2.client_type_code
			, ISNULL(p.activity_id, cp.activity_id) activity_id
			, t.branch_id
			, ROW_NUMBER() OVER (PARTITION BY ac.contract_id ORDER BY ac.contract_id) row
		FROM dbo.ActiveClients_MC(@date, @disbursed_in, @display_in, @branch_id) ac
		INNER JOIN dbo.Contracts c ON c.id = ac.contract_id
		INNER JOIN dbo.Credit cr ON cr.id = c.id
		INNER JOIN dbo.Projects j ON j.id = c.project_id
		LEFT JOIN dbo.Tiers t2 ON t2.id = j.tiers_id
		LEFT JOIN dbo.Tiers t ON t.id = ac.id
		LEFT JOIN dbo.persons p ON p.id = t.id
		LEFT JOIN dbo.Corporates cp ON cp.id = t.id
		WHERE (0 = @branch_id OR t.branch_id = @branch_id)
			AND (0 = @subordinate_id AND cr.loanofficer_id IN (SELECT id FROM @users) OR cr.loanofficer_id = @subordinate_id)

		INSERT INTO @active_loans
		SELECT ac.contract_id, SUM(ac.olb), ac.late_days, t.district_id
		FROM @active_clients ac
		INNER JOIN dbo.Contracts c ON c.id = ac.contract_id
		INNER JOIN dbo.Projects j ON j.id = c.project_id
		LEFT JOIN dbo.Tiers t ON t.id = j.tiers_id
		GROUP BY ac.contract_id, ac.late_days, t.district_id

		SELECT 'district' break_down_type
			, d.name break_down
			, ac.olb
			, ac.par
			, ac.clients
			, ac.all_clients
			, al.contracts
			, al.all_contracts
			, ac.par_30
			, ac.clients_30
			, al.contracts_30
			, ac.par_1_30
			, ac.clients_1_30
			, al.contracts_1_30
			, ac.par_31_60
			, ac.clients_31_60
			, al.contracts_31_60
			, ac.par_61_90
			, ac.clients_61_90
			, al.contracts_61_90
			, ac.par_91_180
			, ac.clients_91_180
			, al.contracts_91_180
			, ac.par_181_365
			, ac.clients_181_365
			, al.contracts_181_365
			, ac.par_365
			, ac.clients_365
			, al.contracts_365
		FROM
		(
			SELECT district_id
				, SUM(olb) olb
				, SUM(CASE WHEN late_days > 0 THEN olb ELSE 0 END) par
				, SUM(CASE WHEN late_days > 0 THEN 1 ELSE 0 END) clients
				, COUNT(DISTINCT id) all_clients
				, SUM(CASE WHEN late_days > 30 THEN olb ELSE 0 END) par_30
				, SUM(CASE WHEN late_days > 30 THEN 1 ELSE 0 END) clients_30
				, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN olb ELSE 0 END) par_1_30
				, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN 1 ELSE 0 END) clients_1_30
				, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN olb ELSE 0 END) par_31_60
				, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN 1 ELSE 0 END) clients_31_60
				, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN olb ELSE 0 END) par_61_90
				, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN 1 ELSE 0 END) clients_61_90
				, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN olb ELSE 0 END) par_91_180
				, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN 1 ELSE 0 END) clients_91_180
				, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN olb ELSE 0 END) par_181_365
				, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN 1 ELSE 0 END) clients_181_365   
				, SUM(CASE WHEN late_days > 365 THEN olb ELSE 0 END) par_365
				, SUM(CASE WHEN late_days > 365 THEN 1 ELSE 0 END) clients_365
			FROM @active_clients
			GROUP BY district_id
		) ac
		LEFT JOIN
		(
			SELECT district_id
				, SUM(CASE WHEN late_days > 0 THEN 1 ELSE 0 END) contracts
				, COUNT(id) all_contracts
				, SUM(CASE WHEN late_days > 30 THEN 1 ELSE 0 END) contracts_30
				, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN 1 ELSE 0 END) contracts_1_30
				, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN 1 ELSE 0 END) contracts_31_60
				, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN 1 ELSE 0 END) contracts_61_90
				, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN 1 ELSE 0 END) contracts_91_180
				, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN 1 ELSE 0 END) contracts_181_365
				, SUM(CASE WHEN late_days > 365 THEN 1 ELSE 0 END) contracts_365
			FROM @active_loans
			GROUP BY district_id
		) al ON ac.district_id = al.district_id
		LEFT JOIN dbo.Districts d ON d.id = ac.district_id

		UNION ALL
		
		SELECT 'loan_officer' break_down_type
			, u.first_name + ' ' + u.last_name break_down
			, SUM(olb) olb
			, SUM(CASE WHEN late_days > 0 THEN olb ELSE 0 END) par
			, SUM(CASE WHEN late_days > 0 THEN 1 ELSE 0 END) clients
			, COUNT(DISTINCT ac.id) all_clients
			, SUM(CASE WHEN late_days > 0 AND 1 = num THEN 1 ELSE 0 END) contracts
			, SUM(CASE WHEN 1 = num THEN 1 ELSE 0 END) all_contracts
			, SUM(CASE WHEN late_days > 30 THEN olb ELSE 0 END) par_30
			, SUM(CASE WHEN late_days > 30 THEN 1 ELSE 0 END) clients_30
			, SUM(CASE WHEN late_days > 30 AND 1 = num THEN 1 ELSE 0 END) contracts_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN olb ELSE 0 END) par_1_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN 1 ELSE 0 END) clients_1_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 AND 1 = num THEN 1 ELSE 0 END) contracts_1_30
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN olb ELSE 0 END) par_31_60
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN 1 ELSE 0 END) clients_31_60
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 AND 1 = num THEN 1 ELSE 0 END) contracts_31_60
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN olb ELSE 0 END) par_61_90
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN 1 ELSE 0 END) clients_61_90
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 AND 1 = num THEN 1 ELSE 0 END) contracts_61_90
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN olb ELSE 0 END) par_91_180
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN 1 ELSE 0 END) clients_91_180
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 AND 1 = num THEN 1 ELSE 0 END) contracts_91_180
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN olb ELSE 0 END) par_181_365
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN 1 ELSE 0 END) clients_181_365
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 AND 1 = num THEN 1 ELSE 0 END) contracts_181_365
			, SUM(CASE WHEN late_days > 365 THEN olb ELSE 0 END) par_365
			, SUM(CASE WHEN late_days > 365 THEN 1 ELSE 0 END) clients_365
			, SUM(CASE WHEN late_days > 365 AND 1 = num THEN 1 ELSE 0 END) contracts_365
		FROM @active_clients ac
		LEFT JOIN dbo.Users u ON u.id = ac.loan_officer_Id
		GROUP BY loan_officer_id, u.first_name, u.last_name

		UNION ALL
		
		SELECT 'product' break_down_type
			, pack.name break_down
			, SUM(olb) olb
			, SUM(CASE WHEN late_days > 0 THEN olb ELSE 0 END) par
			, SUM(CASE WHEN late_days > 0 THEN 1 ELSE 0 END) clients
			, COUNT(DISTINCT ac.id) all_clients
			, SUM(CASE WHEN late_days > 0 AND 1 = num THEN 1 ELSE 0 END) contracts
			, SUM(CASE WHEN 1 = num THEN 1 ELSE 0 END) all_contracts
			, SUM(CASE WHEN late_days > 30 THEN olb ELSE 0 END) par_30
			, SUM(CASE WHEN late_days > 30 THEN 1 ELSE 0 END) clients_30
			, SUM(CASE WHEN late_days > 30 AND 1 = num THEN 1 ELSE 0 END) contracts_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN olb ELSE 0 END) par_1_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN 1 ELSE 0 END) clients_1_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 AND 1 = num THEN 1 ELSE 0 END) contracts_1_30
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN olb ELSE 0 END) par_31_60
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN 1 ELSE 0 END) clients_31_60
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 AND 1 = num THEN 1 ELSE 0 END) contracts_31_60
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN olb ELSE 0 END) par_61_90
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN 1 ELSE 0 END) clients_61_90
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 AND 1 = num THEN 1 ELSE 0 END) contracts_61_90
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN olb ELSE 0 END) par_91_180
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN 1 ELSE 0 END) clients_91_180
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 AND 1 = num THEN 1 ELSE 0 END) contracts_91_180
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN olb ELSE 0 END) par_181_365
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN 1 ELSE 0 END) clients_181_365
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 AND 1 = num THEN 1 ELSE 0 END) contracts_181_365
			, SUM(CASE WHEN late_days > 365 THEN olb ELSE 0 END) par_365
			, SUM(CASE WHEN late_days > 365 THEN 1 ELSE 0 END) clients_365
			, SUM(CASE WHEN late_days > 365 AND 1 = num THEN 1 ELSE 0 END) contracts_365
		FROM @active_clients ac
		LEFT JOIN dbo.Packages pack ON pack.id = ac.product_id
		GROUP BY pack.id, pack.name

		UNION ALL
		
		SELECT 'activity' break_down_type
			, doa.name break_down
			, SUM(olb) olb
			, SUM(CASE WHEN late_days > 0 THEN olb ELSE 0 END) par
			, SUM(CASE WHEN late_days > 0 THEN 1 ELSE 0 END) clients
			, COUNT(DISTINCT ac.id) all_clients
			, SUM(CASE WHEN late_days > 0 AND 1 = num THEN 1 ELSE 0 END) contracts
			, SUM(CASE WHEN 'I' = client_type_code THEN 1 ELSE 0 END) all_contracts
			, SUM(CASE WHEN late_days > 30 THEN olb ELSE 0 END) par_30
			, SUM(CASE WHEN late_days > 30 THEN 1 ELSE 0 END) clients_30
			, SUM(CASE WHEN late_days > 30 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN olb ELSE 0 END) par_1_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN 1 ELSE 0 END) clients_1_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_1_30
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN olb ELSE 0 END) par_31_60
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN 1 ELSE 0 END) clients_31_60
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_31_60
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN olb ELSE 0 END) par_61_90
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN 1 ELSE 0 END) clients_61_90
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_61_90
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN olb ELSE 0 END) par_91_180
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN 1 ELSE 0 END) clients_91_180
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_91_180
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN olb ELSE 0 END) par_181_365
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN 1 ELSE 0 END) clients_181_365
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_181_365
			, SUM(CASE WHEN late_days > 365 THEN olb ELSE 0 END) par_365
			, SUM(CASE WHEN late_days > 365 THEN 1 ELSE 0 END) clients_365
			, SUM(CASE WHEN late_days > 365 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_365
		FROM @active_clients ac
		LEFT JOIN dbo.EconomicActivities doa ON doa.id = ac.activity_id
		GROUP BY ac.activity_id, doa.NAME
		
		UNION ALL
		
		SELECT 'branch' break_down_type
			, b.name break_down
			, SUM(olb) olb
			, SUM(CASE WHEN late_days > 0 THEN olb ELSE 0 END) par
			, SUM(CASE WHEN late_days > 0 THEN 1 ELSE 0 END) clients
			, COUNT(DISTINCT ac.id) all_clients
			, SUM(CASE WHEN late_days > 0 AND 1 = num THEN 1 ELSE 0 END) contracts
			, SUM(CASE WHEN 'I' = client_type_code THEN 1 ELSE 0 END) all_contracts
			, SUM(CASE WHEN late_days > 30 THEN olb ELSE 0 END) par_30
			, SUM(CASE WHEN late_days > 30 THEN 1 ELSE 0 END) clients_30
			, SUM(CASE WHEN late_days > 30 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN olb ELSE 0 END) par_1_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 THEN 1 ELSE 0 END) clients_1_30
			, SUM(CASE WHEN late_days BETWEEN 1 AND 30 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_1_30
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN olb ELSE 0 END) par_31_60
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 THEN 1 ELSE 0 END) clients_31_60
			, SUM(CASE WHEN late_days BETWEEN 31 AND 60 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_31_60
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN olb ELSE 0 END) par_61_90
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 THEN 1 ELSE 0 END) clients_61_90
			, SUM(CASE WHEN late_days BETWEEN 61 AND 90 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_61_90
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN olb ELSE 0 END) par_91_180
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 THEN 1 ELSE 0 END) clients_91_180
			, SUM(CASE WHEN late_days BETWEEN 91 AND 180 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_91_180
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN olb ELSE 0 END) par_181_365
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 THEN 1 ELSE 0 END) clients_181_365
			, SUM(CASE WHEN late_days BETWEEN 181 AND 365 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_181_365
			, SUM(CASE WHEN late_days > 365 THEN olb ELSE 0 END) par_365
			, SUM(CASE WHEN late_days > 365 THEN 1 ELSE 0 END) clients_365
			, SUM(CASE WHEN late_days > 365 AND 'I' = client_type_code THEN 1 ELSE 0 END) contracts_365
		FROM @active_clients ac
		LEFT JOIN dbo.Branches b ON b.id = ac.branch_id
		GROUP BY b.id, b.name
		ORDER BY break_down_type, break_down
END
GO
/****** Object:  StoredProcedure [dbo].[Rep_Active_Loans]    Script Date: 09/17/2014 00:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rep_Active_Loans] @date DATETIME, @disbursed_in INT, @display_in INT, @branch_id INT, @user_id INT, @subordinate_id INT
AS BEGIN
		DECLARE @active_clients TABLE
		(
			id INT NOT NULL
			, contract_id INT NOT NULL
			, olb MONEY NOT NULL
			, amount MONEY NOT NULL
			, client_type_code CHAR(1) NOT NULL
			, package_id INT NOT NULL
			, activity_id INT NOT NULL
			, district_id INT NOT NULL
			, interest_rate FLOAT NOT NULL
			, installment_type_id INT NOT NULL
			, loan_officer_id INT NOT NULL
			, branch_id INT NOT NULL
			, row INT NOT NULL
		)

		DECLARE @active_loans TABLE
		(
			contract_id INT NOT NULL
			, amount MONEY NOT NULL
		)

		DECLARE @users TABLE
		(
			id INT NOT NULL
		)
		
		INSERT INTO @users
		SELECT @user_id
		INSERT INTO @users
		SELECT subordinate_id
		FROM dbo.UsersSubordinates
		WHERE user_id = @user_id

		INSERT INTO @active_clients
		SELECT ac.id
		, ac.contract_id
		, ac.olb
		, ac.amount
		, t.client_type_code
		, cr.package_id
		, c.activity_id
		, t.district_id
		, cr.interest_rate
		, pack.installment_type
		, cr.loanofficer_id
		, t.branch_id
		, ROW_NUMBER() OVER (PARTITION BY ac.contract_id ORDER BY ac.contract_id) row
		FROM dbo.ActiveClients_MC(@date, @disbursed_in, @display_in, @branch_id) ac
		INNER JOIN dbo.Contracts c on c.id = ac.contract_id
		INNER JOIN dbo.Credit cr on cr.id = c.id
		INNER JOIN dbo.Projects j on j.id = c.project_id
		INNER JOIN dbo.Tiers t on t.id = j.tiers_id
		LEFT JOIN dbo.Packages pack ON pack.id = cr.package_id		
		WHERE (0 = @subordinate_id AND cr.loanofficer_id IN (SELECT id FROM @users) OR cr.loanofficer_id = @subordinate_id)

		INSERT INTO @active_loans
		SELECT contract_id, SUM(amount)
		FROM @active_clients
		GROUP BY contract_id

		DECLARE @retval TABLE
		(
			break_down NVARCHAR(100) NULL
			, break_down_type VARCHAR(20) NOT NULL
			, contracts INT NOT NULL
			, individual INT NOT NULL
			, [group] INT NOT NULL
			, corporate INT NOT NULL
			, clients INT NOT NULL
			, in_groups INT NOT NULL
			, projects INT NOT NULL
			, olb MONEY NOT NULL
		)

		INSERT INTO @retval
		SELECT pack.name break_down
		, 'product' break_down_type
		, COUNT(DISTINCT ac.contract_id) contracts
		, SUM(CASE WHEN 'I' = ac.client_type_code THEN 1 ELSE 0 END) individual
		, SUM(CASE WHEN 'G' = ac.client_type_code AND 1 = ac.row THEN 1 ELSE 0 END) [group]
		, SUM(CASE WHEN 'C' = ac.client_type_code THEN 1 ELSE 0 END) corporate
		, COUNT(DISTINCT ac.id) clients
		, COUNT(DISTINCT CASE WHEN ac.client_type_code = 'G' THEN ac.id ELSE null END) in_groups
		, COUNT(DISTINCT ac.contract_id) projects
		, SUM(olb) olb    
		FROM @active_clients ac
		INNER JOIN dbo.Packages pack on pack.id = ac.package_id
		GROUP BY ac.package_id, pack.name
		ORDER BY pack.name

		INSERT INTO @retval
		SELECT doa.name break_down
		, 'activity' break_down_type
		, 0 contracts
		, SUM(CASE WHEN 'I' = ac.client_type_code THEN 1 ELSE 0 END) individual
		, 0 [group]
		, SUM(CASE WHEN 'C' = ac.client_type_code THEN 1 ELSE 0 END) corporate
		, COUNT(DISTINCT ac.id) clients
		, COUNT(DISTINCT CASE WHEN ac.client_type_code = 'G' THEN ac.id ELSE null END) in_groups
		, 0 projects
		, SUM(olb) olb    
		FROM @active_clients ac
		LEFT JOIN dbo.EconomicActivities doa on doa.id = ac.activity_id
		GROUP BY ac.activity_id, doa.name
		ORDER BY doa.name

		INSERT INTO @retval
		SELECT d.name break_down
		, 'district' break_down_type
		, COUNT(DISTINCT ac.contract_id) contracts
		, SUM(CASE WHEN 'I' = ac.client_type_code THEN 1 ELSE 0 END) individual
		, SUM(CASE WHEN 'G' = ac.client_type_code AND 1 = ac.row THEN 1 ELSE 0 END) [group]
		, SUM(CASE WHEN 'C' = ac.client_type_code THEN 1 ELSE 0 END) corporate
		, COUNT(DISTINCT ac.id) clients
		, COUNT(DISTINCT CASE WHEN ac.client_type_code = 'G' THEN ac.id ELSE null END) in_groups
		, COUNT(DISTINCT ac.contract_id) projects
		, SUM(olb) olb    
		FROM @active_clients ac
		LEFT JOIN dbo.Districts d ON d.id = ac.district_id
		GROUP BY ac.district_id, d.name
		ORDER BY d.name
		
		INSERT INTO @retval
		SELECT cur.name break_down
		, 'currency' break_down_type
		, COUNT(DISTINCT ac.contract_id) contracts
		, SUM(CASE WHEN 'I' = ac.client_type_code THEN 1 ELSE 0 END) individual
		, SUM(CASE WHEN 'G' = ac.client_type_code AND 1 = ac.row THEN 1 ELSE 0 END) [group]
		, SUM(CASE WHEN 'C' = ac.client_type_code THEN 1 ELSE 0 END) corporate
		, COUNT(DISTINCT ac.id) clients
		, COUNT(DISTINCT CASE WHEN ac.client_type_code = 'G' THEN ac.id ELSE null END) in_groups
		, COUNT(DISTINCT ac.contract_id) projects
		, SUM(olb) olb 
		FROM @active_clients ac
		INNER JOIN dbo.Packages pack ON pack.id = ac.package_id
		INNER JOIN dbo.Currencies cur ON cur.id = pack.currency_id
		GROUP BY cur.id, cur.name
		ORDER BY cur.name

		INSERT INTO @retval
		SELECT CAST(ac.interest_rate * 100 AS NVARCHAR(100)) + '% ' + it.name break_down
		, 'interest_rate' break_down_type
		, COUNT(DISTINCT ac.contract_id) contracts
		, SUM(CASE WHEN 'I' = ac.client_type_code THEN 1 ELSE 0 END) individual
		, SUM(CASE WHEN 'G' = ac.client_type_code AND 1 = ac.row THEN 1 ELSE 0 END) [group]
		, SUM(CASE WHEN 'C' = ac.client_type_code THEN 1 ELSE 0 END) corporate
		, COUNT(DISTINCT ac.id) clients
		, COUNT(DISTINCT CASE WHEN ac.client_type_code = 'G' THEN ac.id ELSE null END) in_groups
		, COUNT(DISTINCT ac.contract_id) projects
		, SUM(olb) olb    
		FROM @active_clients ac
		LEFT JOIN dbo.InstallmentTypes it ON it.id = ac.installment_type_id
		GROUP BY ac.interest_rate, it.name
		ORDER BY it.name, ac.interest_rate

		INSERT INTO @retval
		SELECT u.first_name + ' ' + u.last_name break_down
		, 'loan_officer' break_down_type
		, COUNT(DISTINCT ac.contract_id) contracts
		, SUM(CASE WHEN 'I' = ac.client_type_code THEN 1 ELSE 0 END) individual
		, SUM(CASE WHEN 'G' = ac.client_type_code AND 1 = ac.row THEN 1 ELSE 0 END) [group]
		, SUM(CASE WHEN 'C' = ac.client_type_code THEN 1 ELSE 0 END) corporate
		, COUNT(DISTINCT ac.id) clients
		, COUNT(DISTINCT CASE WHEN ac.client_type_code = 'G' THEN ac.id ELSE null END) in_groups
		, COUNT(DISTINCT ac.contract_id) projects
		, SUM(olb) olb    
		FROM @active_clients ac
		LEFT JOIN dbo.Users u ON u.id = ac.loan_officer_id
		GROUP BY u.first_name, u.last_name
		ORDER BY u.first_name + ' ' + u.last_name
		
		INSERT INTO @retval
		SELECT b.name break_down
		, 'branch' break_down_type
		, COUNT(DISTINCT ac.contract_id) contracts
		, SUM(CASE WHEN 'I' = ac.client_type_code THEN 1 ELSE 0 END) individual
		, SUM(CASE WHEN 'G' = ac.client_type_code AND 1 = ac.row THEN 1 ELSE 0 END) [group]
		, SUM(CASE WHEN 'C' = ac.client_type_code THEN 1 ELSE 0 END) corporate
		, COUNT(DISTINCT ac.id) clients
		, COUNT(DISTINCT CASE WHEN ac.client_type_code = 'G' THEN ac.id ELSE null END) in_groups
		, COUNT(DISTINCT ac.contract_id) projects
		, SUM(olb) olb    
		FROM @active_clients ac
		LEFT JOIN dbo.Branches b ON b.id = ac.branch_id
		GROUP BY b.id, b.name
		ORDER BY b.name

		INSERT INTO @retval
		SELECT CAST(ls.ScaleMin AS NVARCHAR(20)) + ' - ' + CAST(ls.ScaleMax AS NVARCHAR(20)) break_down
		, 'loan_size' break_down_type
		, 0 contracts
		, SUM(CASE WHEN 'I' = ac.client_type_code THEN 1 ELSE 0 END) individual
		, 0 [group]
		, 0 corporate
		, COUNT(DISTINCT ac.id) clients
		, COUNT(DISTINCT CASE WHEN ac.client_type_code = 'G' THEN ac.id ELSE null END) in_groups
		, 0 projects
		, SUM(olb) olb    
		FROM @active_clients ac
		LEFT JOIN dbo.LoanScale ls ON ac.amount > ls.ScaleMin AND ac.amount <= ls.ScaleMax
		GROUP BY ls.id, ls.ScaleMin, ls.ScaleMax
		ORDER BY ls.ScaleMin
		SELECT * FROM @retval
END
GO
/****** Object:  Default [DF__CustomFie__order__33F4B129]    Script Date: 09/17/2014 00:58:17 ******/
ALTER TABLE [dbo].[CustomFields] ADD  DEFAULT ((1)) FOR [order]
GO
/****** Object:  Default [DF__CustomFie__delet__34E8D562]    Script Date: 09/17/2014 00:58:17 ******/
ALTER TABLE [dbo].[CustomFields] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF_CurrentAccountTransactions_from_account_balance]    Script Date: 09/17/2014 00:58:17 ******/
ALTER TABLE [dbo].[CurrentAccountTransactions] ADD  CONSTRAINT [DF_CurrentAccountTransactions_from_account_balance]  DEFAULT ((0)) FOR [from_account_balance]
GO
/****** Object:  Default [DF_CurrentAccountTransactions_to_account_balance]    Script Date: 09/17/2014 00:58:17 ******/
ALTER TABLE [dbo].[CurrentAccountTransactions] ADD  CONSTRAINT [DF_CurrentAccountTransactions_to_account_balance]  DEFAULT ((0)) FOR [to_account_balance]
GO
/****** Object:  Default [DF_CurrentAccountProductHoldings_balance]    Script Date: 09/17/2014 00:58:17 ******/
ALTER TABLE [dbo].[CurrentAccountProductHoldings] ADD  CONSTRAINT [DF_CurrentAccountProductHoldings_balance]  DEFAULT ((0)) FOR [balance]
GO
/****** Object:  Default [DF__Currencie__is_sw__3E52440B]    Script Date: 09/17/2014 00:58:17 ******/
ALTER TABLE [dbo].[Currencies] ADD  DEFAULT ((0)) FOR [is_swapped]
GO
/****** Object:  Default [DF__Currencie__use_c__3F466844]    Script Date: 09/17/2014 00:58:17 ******/
ALTER TABLE [dbo].[Currencies] ADD  DEFAULT ((1)) FOR [use_cents]
GO
/****** Object:  Default [DF__Accountin__is_de__5FB337D6]    Script Date: 09/17/2014 00:58:17 ******/
ALTER TABLE [dbo].[AccountingClosure] ADD  DEFAULT ((0)) FOR [is_deleted]
GO
/****** Object:  Default [DF__AdvancedF__link___6A30C649]    Script Date: 09/17/2014 00:58:37 ******/
ALTER TABLE [dbo].[AdvancedFieldsLinkEntities] ADD  DEFAULT ('-') FOR [link_type]
GO
/****** Object:  Default [DF__Branches__delete__6EF57B66]    Script Date: 09/17/2014 00:58:37 ******/
ALTER TABLE [dbo].[Branches] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__PaymentMe__pendi__59063A47]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[PaymentMethods] ADD  DEFAULT ((0)) FOR [pending]
GO
/****** Object:  Default [DF__Provinces__delet__0DAF0CB0]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Provinces] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__Questionn__is_se__0425A276]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Questionnaire] ADD  DEFAULT ((0)) FOR [is_sent]
GO
/****** Object:  Default [DF_LoanMonitoring_type]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Monitoring] ADD  CONSTRAINT [DF_LoanMonitoring_type]  DEFAULT ((1)) FOR [type]
GO
/****** Object:  Default [DF_MenuItems_type]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[MenuItems] ADD  CONSTRAINT [DF_MenuItems_type]  DEFAULT ((0)) FOR [type]
GO
/****** Object:  Default [DF_LoanInterestAccruingEvents_installment_number]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[LoanInterestAccruingEvents] ADD  CONSTRAINT [DF_LoanInterestAccruingEvents_installment_number]  DEFAULT ((1)) FOR [installment_number]
GO
/****** Object:  Default [DF__EventType__accou__30F848ED]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[EventTypes] ADD  DEFAULT ((0)) FOR [accounting]
GO
/****** Object:  Default [DF__Roles__deleted__09DE7BCC]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Roles] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__Roles__descripti__0AD2A005]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Roles] ADD  DEFAULT ('') FOR [description]
GO
/****** Object:  Default [DF_Users_delete]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_delete]  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF_Users_mail]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_mail]  DEFAULT (N'Not Set') FOR [mail]
GO
/****** Object:  Default [DF_Users_sex]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_sex]  DEFAULT ('M') FOR [sex]
GO
/****** Object:  Default [DF__SavingPro__delet__2BFE89A6]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[SavingProducts] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__SavingPro__clien__2CF2ADDF]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[SavingProducts] ADD  DEFAULT ('-') FOR [client_type]
GO
/****** Object:  Default [DF__Districts__delet__1EA48E88]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Districts] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__Tmp_Packa__delet__6F2063EF]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  CONSTRAINT [DF__Tmp_Packa__delet__6F2063EF]  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF_Packages_code]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  CONSTRAINT [DF_Packages_code]  DEFAULT (N'NotSet') FOR [code]
GO
/****** Object:  Default [DF__Tmp_Packa__clien__70148828]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  CONSTRAINT [DF__Tmp_Packa__clien__70148828]  DEFAULT ('-') FOR [client_type]
GO
/****** Object:  Default [DF__Packages__roundi__0D7A0286]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((1)) FOR [rounding_type]
GO
/****** Object:  Default [DF__Packages__grace___0E6E26BF]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [grace_period_of_latefees]
GO
/****** Object:  Default [DF__Packages__antici__0F624AF8]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [anticipated_partial_repayment_base]
GO
/****** Object:  Default [DF__Packages__antici__10566F31]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [anticipated_total_repayment_base]
GO
/****** Object:  Default [DF__Packages__activa__114A936A]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [activated_loc]
GO
/****** Object:  Default [DF__Packages__allow___123EB7A3]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [allow_flexible_schedule]
GO
/****** Object:  Default [DF__Packages__use_gu__1332DBDC]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [use_guarantor_collateral]
GO
/****** Object:  Default [DF__Packages__set_se__14270015]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [set_separate_guarantor_collateral]
GO
/****** Object:  Default [DF__Packages__percen__151B244E]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [percentage_total_guarantor_collateral]
GO
/****** Object:  Default [DF__Packages__percen__160F4887]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [percentage_separate_guarantor]
GO
/****** Object:  Default [DF__Packages__percen__17036CC0]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [percentage_separate_collateral]
GO
/****** Object:  Default [DF__Packages__use_co__17F790F9]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [use_compulsory_savings]
GO
/****** Object:  Default [DF__Packages__insura__18EBB532]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [insurance_min]
GO
/****** Object:  Default [DF__Packages__insura__19DFD96B]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [insurance_max]
GO
/****** Object:  Default [DF__Packages__use_en__1AD3FDA4]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [use_entry_fees_cycles]
GO
/****** Object:  Default [DF__Packages__intere__1BC821DD]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages] ADD  DEFAULT ((0)) FOR [interest_scheme]
GO
/****** Object:  Default [DF__ChartOfAcc__type__797309D9]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ChartOfAccounts] ADD  DEFAULT ((0)) FOR [type]
GO
/****** Object:  Default [DF__ChartOfAcco__lft__7A672E12]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ChartOfAccounts] ADD  DEFAULT ((0)) FOR [lft]
GO
/****** Object:  Default [DF__ChartOfAcco__rgt__7B5B524B]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ChartOfAccounts] ADD  DEFAULT ((0)) FOR [rgt]
GO
/****** Object:  Default [DF__City__deleted__6166761E]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[City] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__Accountin__delet__662B2B3B]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AccountingRules] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__Accountin__booki__671F4F74]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AccountingRules] ADD  DEFAULT ((3)) FOR [booking_direction]
GO
/****** Object:  Default [DF__Accountin__order__681373AD]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AccountingRules] ADD  DEFAULT ((0)) FOR [order]
GO
/****** Object:  Default [DF__LoanAccou__excha__58D1301D]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LoanAccountingMovements] ADD  DEFAULT ((1)) FOR [exchange_rate]
GO
/****** Object:  Default [DF__LoanAccou__rule___59C55456]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LoanAccountingMovements] ADD  DEFAULT ((0)) FOR [rule_id]
GO
/****** Object:  Default [DF__LoanAccou__booki__5AB9788F]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LoanAccountingMovements] ADD  DEFAULT ((1)) FOR [booking_type]
GO
/****** Object:  Default [DF__LinkBranc__delet__5CA1C101]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LinkBranchesPaymentMethods] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__LinkBranch__date__5D95E53A]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LinkBranchesPaymentMethods] ADD  DEFAULT (getdate()) FOR [date]
GO
/****** Object:  Default [DF__LinkBranc__accou__5E8A0973]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LinkBranchesPaymentMethods] ADD  DEFAULT ((1)) FOR [account_id]
GO
/****** Object:  Default [DF__ManualAcc__excha__55F4C372]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ManualAccountingMovements] ADD  DEFAULT ((1)) FOR [exchange_rate]
GO
/****** Object:  Default [DF_EntryFees_is_deleted]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[EntryFees] ADD  CONSTRAINT [DF_EntryFees_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
/****** Object:  Default [DF__EntryFees__fee_i__503BEA1C]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[EntryFees] ADD  DEFAULT ((-1)) FOR [fee_index]
GO
/****** Object:  Default [DF__FundingLi__fundi__531856C7]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[FundingLineEvents] ADD  DEFAULT ((1)) FOR [fundingline_id]
GO
/****** Object:  Default [DF_Tiers_loan_cycle]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tiers] ADD  CONSTRAINT [DF_Tiers_loan_cycle]  DEFAULT ((1)) FOR [loan_cycle]
GO
/****** Object:  Default [DF_Tiers_status]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tiers] ADD  CONSTRAINT [DF_Tiers_status]  DEFAULT ((1)) FOR [status]
GO
/****** Object:  Default [DF__Tiers__branch_id__32AB8735]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tiers] ADD  DEFAULT ((1)) FOR [branch_id]
GO
/****** Object:  Default [DF__SavingsAc__excha__3E1D39E1]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingsAccountingMovements] ADD  DEFAULT ((1)) FOR [exchange_rate]
GO
/****** Object:  Default [DF__SavingsAc__rule___3F115E1A]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingsAccountingMovements] ADD  DEFAULT ((0)) FOR [rule_id]
GO
/****** Object:  Default [DF__SavingBoo__manag__3864608B]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingBookProducts] ADD  DEFAULT ((1)) FOR [management_fees_freq]
GO
/****** Object:  Default [DF__SavingBoo__agio___395884C4]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingBookProducts] ADD  DEFAULT ((1)) FOR [agio_fees_freq]
GO
/****** Object:  Default [DF__SavingBoo__is_ib__3A4CA8FD]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingBookProducts] ADD  DEFAULT ((0)) FOR [is_ibt_fee_flat]
GO
/****** Object:  Default [DF__SavingBoo__use_t__3B40CD36]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingBookProducts] ADD  DEFAULT ((0)) FOR [use_term_deposit]
GO
/****** Object:  Default [DF__VillagesP__is_le__41EDCAC5]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[VillagesPersons] ADD  DEFAULT ((0)) FOR [is_leader]
GO
/****** Object:  Default [DF__VillagesP__curre__42E1EEFE]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[VillagesPersons] ADD  DEFAULT ((0)) FOR [currently_in]
GO
/****** Object:  Default [DF__VillagesA__atten__45BE5BA9]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[VillagesAttendance] ADD  DEFAULT ((0)) FOR [attended]
GO
/****** Object:  Default [DF__VillagesA__loan___46B27FE2]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[VillagesAttendance] ADD  DEFAULT ((0)) FOR [loan_id]
GO
/****** Object:  Default [DF__Tellers__deleted__4B7734FF]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tellers] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF__Tellers__branch___4C6B5938]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tellers] ADD  DEFAULT ((0)) FOR [branch_id]
GO
/****** Object:  Default [DF__TellerEve__is_ex__7B264821]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[TellerEvents] ADD  DEFAULT ((0)) FOR [is_exported]
GO
/****** Object:  Default [DF__SavingCon__savin__7FEAFD3E]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingContracts] ADD  DEFAULT ((1)) FOR [savings_officer_id]
GO
/****** Object:  Default [DF__SavingCon__initi__00DF2177]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingContracts] ADD  DEFAULT ((0)) FOR [initial_amount]
GO
/****** Object:  Default [DF__SavingCon__entry__01D345B0]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingContracts] ADD  DEFAULT ((0)) FOR [entry_fees]
GO
/****** Object:  Default [DF_Credit_handicapped]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons] ADD  CONSTRAINT [DF_Credit_handicapped]  DEFAULT ((0)) FOR [handicapped]
GO
/****** Object:  Default [DF_Persons_povertylevel_childreneducation]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons] ADD  CONSTRAINT [DF_Persons_povertylevel_childreneducation]  DEFAULT ((0)) FOR [povertylevel_childreneducation]
GO
/****** Object:  Default [DF_Persons_povertylevel_economiceducation]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons] ADD  CONSTRAINT [DF_Persons_povertylevel_economiceducation]  DEFAULT ((0)) FOR [povertylevel_economiceducation]
GO
/****** Object:  Default [DF_Persons_povertylevel_socialparticipation]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons] ADD  CONSTRAINT [DF_Persons_povertylevel_socialparticipation]  DEFAULT ((0)) FOR [povertylevel_socialparticipation]
GO
/****** Object:  Default [DF_Persons_povertylevel_healthsituation]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons] ADD  CONSTRAINT [DF_Persons_povertylevel_healthsituation]  DEFAULT ((0)) FOR [povertylevel_healthsituation]
GO
/****** Object:  Default [DF_Contracts_project_id]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Contracts] ADD  CONSTRAINT [DF_Contracts_project_id]  DEFAULT ((0)) FOR [project_id]
GO
/****** Object:  Default [DF_Contracts_status]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Contracts] ADD  CONSTRAINT [DF_Contracts_status]  DEFAULT ((1)) FOR [status]
GO
/****** Object:  Default [DF__SavingEve__is_ex__09746778]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingEvents] ADD  DEFAULT ((0)) FOR [is_exported]
GO
/****** Object:  Default [DF__SavingEve__pendi__0A688BB1]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingEvents] ADD  DEFAULT ((0)) FOR [pending]
GO
/****** Object:  Default [DF__SavingBoo__in_ov__04AFB25B]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingBookContracts] ADD  DEFAULT ((0)) FOR [in_overdraft]
GO
/****** Object:  Default [DF__SavingBoo__use_t__05A3D694]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingBookContracts] ADD  DEFAULT ((0)) FOR [use_term_deposit]
GO
/****** Object:  Default [period_default]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingBookContracts] ADD  CONSTRAINT [period_default]  DEFAULT ((0)) FOR [term_deposit_period]
GO
/****** Object:  Default [DF__ContractE__entry__18B6AB08]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractEvents] ADD  DEFAULT (getdate()) FOR [entry_date]
GO
/****** Object:  Default [DF__ContractE__is_ex__19AACF41]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractEvents] ADD  DEFAULT ((0)) FOR [is_exported]
GO
/****** Object:  Default [DF_ContractAssignHistory_DateChanged]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractAssignHistory] ADD  CONSTRAINT [DF_ContractAssignHistory_DateChanged]  DEFAULT (getdate()) FOR [DateChanged]
GO
/****** Object:  Default [DF_Credit_synchronize]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit] ADD  CONSTRAINT [DF_Credit_synchronize]  DEFAULT ((0)) FOR [synchronize]
GO
/****** Object:  Default [DF__Credit__interest__1F63A897]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit] ADD  DEFAULT ((0)) FOR [interest]
GO
/****** Object:  Default [DF__Credit__grace_pe__2057CCD0]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit] ADD  DEFAULT ((0)) FOR [grace_period_of_latefees]
GO
/****** Object:  Default [DF__Credit__anticipa__214BF109]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit] ADD  DEFAULT ((0)) FOR [anticipated_partial_repayment_penalties]
GO
/****** Object:  Default [DF__Credit__anticipa__22401542]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit] ADD  DEFAULT ((0)) FOR [anticipated_partial_repayment_base]
GO
/****** Object:  Default [DF__Credit__anticipa__2334397B]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit] ADD  DEFAULT ((0)) FOR [anticipated_total_repayment_base]
GO
/****** Object:  Default [DF__Credit__schedule__24285DB4]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit] ADD  DEFAULT ((0)) FOR [schedule_changed]
GO
/****** Object:  Default [DF__Credit__insuranc__251C81ED]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit] ADD  DEFAULT ((0)) FOR [insurance]
GO
/****** Object:  Default [DF_ProvisionEvents_amount]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ProvisionEvents] ADD  CONSTRAINT [DF_ProvisionEvents_amount]  DEFAULT ((0)) FOR [amount]
GO
/****** Object:  Default [DF_OverdueEvents_olb]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[OverdueEvents] ADD  CONSTRAINT [DF_OverdueEvents_olb]  DEFAULT ((0)) FOR [olb]
GO
/****** Object:  Default [DF_OverdueEvents_overdue_days]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[OverdueEvents] ADD  CONSTRAINT [DF_OverdueEvents_overdue_days]  DEFAULT ((0)) FOR [overdue_days]
GO
/****** Object:  Default [DF_LoanDisbursmentEvents_amount]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LoanDisbursmentEvents] ADD  CONSTRAINT [DF_LoanDisbursmentEvents_amount]  DEFAULT ((0)) FOR [amount]
GO
/****** Object:  Default [DF_LoanDisbursmentEvents_fees]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LoanDisbursmentEvents] ADD  CONSTRAINT [DF_LoanDisbursmentEvents_fees]  DEFAULT ((0)) FOR [fees]
GO
/****** Object:  Default [DF__LoanDisbu__inter__52E34C9D]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LoanDisbursmentEvents] ADD  DEFAULT ((0)) FOR [interest]
GO
/****** Object:  Default [DF_Installments_fees_unpaid]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Installments] ADD  CONSTRAINT [DF_Installments_fees_unpaid]  DEFAULT ((0)) FOR [fees_unpaid]
GO
/****** Object:  Default [DF__Installme__paid___56B3DD81]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Installments] ADD  DEFAULT ((0)) FOR [paid_fees]
GO
/****** Object:  Default [DF__Installme__pendi__57A801BA]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Installments] ADD  DEFAULT ((0)) FOR [pending]
GO
/****** Object:  Default [DF__Installme__start__589C25F3]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Installments] ADD  DEFAULT (getdate()) FOR [start_date]
GO
/****** Object:  Default [DF__Installment__olb__59904A2C]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Installments] ADD  DEFAULT ((0)) FOR [olb]
GO
/****** Object:  Default [DF__Installme__commi__5A846E65]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Installments] ADD  DEFAULT ((0)) FOR [commission]
GO
/****** Object:  Default [DF__Installme__paid___5B78929E]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Installments] ADD  DEFAULT ((0)) FOR [paid_commission]
GO
/****** Object:  Default [DF__Installme__paid___5D60DB10]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT ((0)) FOR [paid_interest]
GO
/****** Object:  Default [DF__Installme__paid___5E54FF49]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT ((0)) FOR [paid_capital]
GO
/****** Object:  Default [DF__Installme__paid___5F492382]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT ((0)) FOR [paid_fees]
GO
/****** Object:  Default [DF__Installme__fees___603D47BB]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT ((0)) FOR [fees_unpaid]
GO
/****** Object:  Default [DF__Installme__pendi__61316BF4]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT ((0)) FOR [pending]
GO
/****** Object:  Default [DF__Installme__start__6225902D]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT (getdate()) FOR [start_date]
GO
/****** Object:  Default [DF__Installment__olb__6319B466]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT ((0)) FOR [olb]
GO
/****** Object:  Default [DF__Installme__commi__640DD89F]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT ((0)) FOR [commission]
GO
/****** Object:  Default [DF__Installme__paid___6501FCD8]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory] ADD  DEFAULT ((0)) FOR [paid_commission]
GO
/****** Object:  Default [DF_ReschedulingOfALoanEvents_amount]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ReschedulingOfALoanEvents] ADD  CONSTRAINT [DF_ReschedulingOfALoanEvents_amount]  DEFAULT ((0)) FOR [amount]
GO
/****** Object:  Default [DF__Reschedul__inter__3A179ED3]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ReschedulingOfALoanEvents] ADD  DEFAULT ((0)) FOR [interest]
GO
/****** Object:  Default [DF__Reschedul__nb_of__3B0BC30C]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ReschedulingOfALoanEvents] ADD  DEFAULT ((0)) FOR [nb_of_maturity]
GO
/****** Object:  Default [DF__Reschedul__grace__3BFFE745]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ReschedulingOfALoanEvents] ADD  DEFAULT ((0)) FOR [grace_period]
GO
/****** Object:  Default [DF__Reschedul__charg__3CF40B7E]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ReschedulingOfALoanEvents] ADD  DEFAULT ((0)) FOR [charge_interest_during_grace_period]
GO
/****** Object:  Default [DF__Reschedul__previ__3DE82FB7]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ReschedulingOfALoanEvents] ADD  DEFAULT ((0)) FOR [previous_interest_rate]
GO
/****** Object:  Default [DF__Reschedul__prefe__3EDC53F0]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ReschedulingOfALoanEvents] ADD  DEFAULT (getdate()) FOR [preferred_first_installment_date]
GO
/****** Object:  Default [DF__Repayment__commi__40C49C62]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[RepaymentEvents] ADD  DEFAULT ((0)) FOR [commissions]
GO
/****** Object:  Default [DF__Repayment__penal__41B8C09B]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[RepaymentEvents] ADD  DEFAULT ((0)) FOR [penalties]
GO
/****** Object:  Default [DF__Repayment__payme__42ACE4D4]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[RepaymentEvents] ADD  DEFAULT ((1)) FOR [payment_method_id]
GO
/****** Object:  Default [DF__Repayment__calcu__43A1090D]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[RepaymentEvents] ADD  DEFAULT ((0)) FOR [calculated_penalties]
GO
/****** Object:  Default [DF__Repayment__writt__44952D46]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[RepaymentEvents] ADD  DEFAULT ((0)) FOR [written_off_penalties]
GO
/****** Object:  Default [DF__Repayment__unpai__4589517F]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[RepaymentEvents] ADD  DEFAULT ((0)) FOR [unpaid_penalties]
GO
/****** Object:  Default [DF__TrancheEv__inter__345EC57D]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[TrancheEvents] ADD  DEFAULT ((0)) FOR [interest_rate]
GO
/****** Object:  Default [DF__TrancheEv__first__3552E9B6]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[TrancheEvents] ADD  DEFAULT (getdate()) FOR [first_repayment_date]
GO
/****** Object:  Default [DF__TrancheEv__grace__36470DEF]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[TrancheEvents] ADD  DEFAULT ((0)) FOR [grace_period]
GO
/****** Object:  Default [DF_WriteOffEvents_olb]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[WriteOffEvents] ADD  CONSTRAINT [DF_WriteOffEvents_olb]  DEFAULT ((0)) FOR [olb]
GO
/****** Object:  Default [DF_WriteOffEvents_past_due_days]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[WriteOffEvents] ADD  CONSTRAINT [DF_WriteOffEvents_past_due_days]  DEFAULT ((365)) FOR [past_due_days]
GO
/****** Object:  Default [WriteOffMethodDF]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[WriteOffEvents] ADD  CONSTRAINT [WriteOffMethodDF]  DEFAULT ((0)) FOR [write_off_method]
GO
/****** Object:  Check [CK_Packages]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages]  WITH NOCHECK ADD  CONSTRAINT [CK_Packages] CHECK NOT FOR REPLICATION (([client_type]='I' OR [client_type]='G' OR [client_type]='-' OR [client_type]='C' OR [client_type]='V'))
GO
ALTER TABLE [dbo].[Packages] CHECK CONSTRAINT [CK_Packages]
GO
/****** Object:  Check [CK_TiersTypeCode]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tiers]  WITH NOCHECK ADD  CONSTRAINT [CK_TiersTypeCode] CHECK  (([client_type_code]='G' OR [client_type_code]='I' OR [client_type_code]='C' OR [client_type_code]='V'))
GO
ALTER TABLE [dbo].[Tiers] CHECK CONSTRAINT [CK_TiersTypeCode]
GO
/****** Object:  Check [CK_Persons_Sex]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons]  WITH NOCHECK ADD  CONSTRAINT [CK_Persons_Sex] CHECK  (([sex]='M' OR [sex]='F'))
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [CK_Persons_Sex]
GO
/****** Object:  ForeignKey [FK_DomainOfApplications_DomainOfApplications]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[EconomicActivities]  WITH NOCHECK ADD  CONSTRAINT [FK_DomainOfApplications_DomainOfApplications] FOREIGN KEY([parent_id])
REFERENCES [dbo].[EconomicActivities] ([id])
GO
ALTER TABLE [dbo].[EconomicActivities] CHECK CONSTRAINT [FK_DomainOfApplications_DomainOfApplications]
GO
/****** Object:  ForeignKey [FK_Villages_Users]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Villages]  WITH CHECK ADD  CONSTRAINT [FK_Villages_Users] FOREIGN KEY([loan_officer])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Villages] CHECK CONSTRAINT [FK_Villages_Users]
GO
/****** Object:  ForeignKey [FK_UsersSubordinates_Users]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[UsersSubordinates]  WITH CHECK ADD  CONSTRAINT [FK_UsersSubordinates_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UsersSubordinates] CHECK CONSTRAINT [FK_UsersSubordinates_Users]
GO
/****** Object:  ForeignKey [FK_UsersBranches_Users]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[UsersBranches]  WITH CHECK ADD  CONSTRAINT [FK_UsersBranches_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UsersBranches] CHECK CONSTRAINT [FK_UsersBranches_Users]
GO
/****** Object:  ForeignKey [FK_UserRole_Roles]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Roles]
GO
/****** Object:  ForeignKey [FK_UserRole_Users]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Users]
GO
/****** Object:  ForeignKey [FK_SavingProducts_Currencies]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[SavingProducts]  WITH NOCHECK ADD  CONSTRAINT [FK_SavingProducts_Currencies] FOREIGN KEY([currency_id])
REFERENCES [dbo].[Currencies] ([id])
GO
ALTER TABLE [dbo].[SavingProducts] CHECK CONSTRAINT [FK_SavingProducts_Currencies]
GO
/****** Object:  ForeignKey [FK__FixedDepo__fixed__5DEAEAF5]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[FixedDepositProductHoldings]  WITH CHECK ADD  CONSTRAINT [FK__FixedDepo__fixed__5DEAEAF5] FOREIGN KEY([fixed_deposit_product_id])
REFERENCES [dbo].[FixedDepositProducts] ([id])
GO
ALTER TABLE [dbo].[FixedDepositProductHoldings] CHECK CONSTRAINT [FK__FixedDepo__fixed__5DEAEAF5]
GO
/****** Object:  ForeignKey [FK_FundingLines_Currencies]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[FundingLines]  WITH NOCHECK ADD  CONSTRAINT [FK_FundingLines_Currencies] FOREIGN KEY([currency_id])
REFERENCES [dbo].[Currencies] ([id])
GO
ALTER TABLE [dbo].[FundingLines] CHECK CONSTRAINT [FK_FundingLines_Currencies]
GO
/****** Object:  ForeignKey [FK_Districts_Provinces]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[Districts]  WITH NOCHECK ADD  CONSTRAINT [FK_Districts_Provinces] FOREIGN KEY([province_id])
REFERENCES [dbo].[Provinces] ([id])
GO
ALTER TABLE [dbo].[Districts] CHECK CONSTRAINT [FK_Districts_Provinces]
GO
/****** Object:  ForeignKey [FK_EventAttributes_EventTypes]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[EventAttributes]  WITH NOCHECK ADD  CONSTRAINT [FK_EventAttributes_EventTypes] FOREIGN KEY([event_type])
REFERENCES [dbo].[EventTypes] ([event_type])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[EventAttributes] CHECK CONSTRAINT [FK_EventAttributes_EventTypes]
GO
/****** Object:  ForeignKey [FK_ExoticInstallments_Exotics]    Script Date: 09/17/2014 00:58:40 ******/
ALTER TABLE [dbo].[ExoticInstallments]  WITH NOCHECK ADD  CONSTRAINT [FK_ExoticInstallments_Exotics] FOREIGN KEY([exotic_id])
REFERENCES [dbo].[Exotics] ([id])
GO
ALTER TABLE [dbo].[ExoticInstallments] CHECK CONSTRAINT [FK_ExoticInstallments_Exotics]
GO
/****** Object:  ForeignKey [FK_Packages_Currencies]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages]  WITH NOCHECK ADD  CONSTRAINT [FK_Packages_Currencies] FOREIGN KEY([currency_id])
REFERENCES [dbo].[Currencies] ([id])
GO
ALTER TABLE [dbo].[Packages] CHECK CONSTRAINT [FK_Packages_Currencies]
GO
/****** Object:  ForeignKey [FK_Packages_Cycles]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages]  WITH NOCHECK ADD  CONSTRAINT [FK_Packages_Cycles] FOREIGN KEY([cycle_id])
REFERENCES [dbo].[Cycles] ([id])
GO
ALTER TABLE [dbo].[Packages] NOCHECK CONSTRAINT [FK_Packages_Cycles]
GO
/****** Object:  ForeignKey [FK_Packages_Exotics]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages]  WITH NOCHECK ADD  CONSTRAINT [FK_Packages_Exotics] FOREIGN KEY([exotic_id])
REFERENCES [dbo].[Exotics] ([id])
GO
ALTER TABLE [dbo].[Packages] NOCHECK CONSTRAINT [FK_Packages_Exotics]
GO
/****** Object:  ForeignKey [FK_Packages_InstallmentTypes]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Packages]  WITH NOCHECK ADD  CONSTRAINT [FK_Packages_InstallmentTypes] FOREIGN KEY([installment_type])
REFERENCES [dbo].[InstallmentTypes] ([id])
GO
ALTER TABLE [dbo].[Packages] NOCHECK CONSTRAINT [FK_Packages_InstallmentTypes]
GO
/****** Object:  ForeignKey [FK_AmountCycles_Cycles]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AmountCycles]  WITH CHECK ADD  CONSTRAINT [FK_AmountCycles_Cycles] FOREIGN KEY([cycle_id])
REFERENCES [dbo].[Cycles] ([id])
GO
ALTER TABLE [dbo].[AmountCycles] CHECK CONSTRAINT [FK_AmountCycles_Cycles]
GO
/****** Object:  ForeignKey [FK_AllowedRoleMenus_Roles]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AllowedRoleMenus]  WITH CHECK ADD  CONSTRAINT [FK_AllowedRoleMenus_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[AllowedRoleMenus] CHECK CONSTRAINT [FK_AllowedRoleMenus_Roles]
GO
/****** Object:  ForeignKey [FK_AllowedRoleActions_ActionItems]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AllowedRoleActions]  WITH CHECK ADD  CONSTRAINT [FK_AllowedRoleActions_ActionItems] FOREIGN KEY([action_item_id])
REFERENCES [dbo].[ActionItems] ([id])
GO
ALTER TABLE [dbo].[AllowedRoleActions] CHECK CONSTRAINT [FK_AllowedRoleActions_ActionItems]
GO
/****** Object:  ForeignKey [FK_AllowedRoleActions_AllowedRoleActions]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AllowedRoleActions]  WITH CHECK ADD  CONSTRAINT [FK_AllowedRoleActions_AllowedRoleActions] FOREIGN KEY([action_item_id], [role_id])
REFERENCES [dbo].[AllowedRoleActions] ([action_item_id], [role_id])
GO
ALTER TABLE [dbo].[AllowedRoleActions] CHECK CONSTRAINT [FK_AllowedRoleActions_AllowedRoleActions]
GO
/****** Object:  ForeignKey [FK_AllowedRoleActions_Roles]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AllowedRoleActions]  WITH CHECK ADD  CONSTRAINT [FK_AllowedRoleActions_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[AllowedRoleActions] CHECK CONSTRAINT [FK_AllowedRoleActions_Roles]
GO
/****** Object:  ForeignKey [FK_AdvancedFields_AdvancedFieldsEntities]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AdvancedFields]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedFields_AdvancedFieldsEntities] FOREIGN KEY([entity_id])
REFERENCES [dbo].[AdvancedFieldsEntities] ([id])
GO
ALTER TABLE [dbo].[AdvancedFields] CHECK CONSTRAINT [FK_AdvancedFields_AdvancedFieldsEntities]
GO
/****** Object:  ForeignKey [FK_AdvancedFields_AdvancedFieldsTypes]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AdvancedFields]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedFields_AdvancedFieldsTypes] FOREIGN KEY([type_id])
REFERENCES [dbo].[AdvancedFieldsTypes] ([id])
GO
ALTER TABLE [dbo].[AdvancedFields] CHECK CONSTRAINT [FK_AdvancedFields_AdvancedFieldsTypes]
GO
/****** Object:  ForeignKey [FK_Corporates_DomainOfApplications]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Corporates]  WITH CHECK ADD  CONSTRAINT [FK_Corporates_DomainOfApplications] FOREIGN KEY([activity_id])
REFERENCES [dbo].[EconomicActivities] ([id])
GO
ALTER TABLE [dbo].[Corporates] CHECK CONSTRAINT [FK_Corporates_DomainOfApplications]
GO
/****** Object:  ForeignKey [FK__CustomFie__field__39AD8A7F]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[CustomFieldsValues]  WITH CHECK ADD FOREIGN KEY([field_id])
REFERENCES [dbo].[CustomFields] ([id])
GO
/****** Object:  ForeignKey [FK_CollateralProperties_CollateralProducts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[CollateralProperties]  WITH CHECK ADD  CONSTRAINT [FK_CollateralProperties_CollateralProducts] FOREIGN KEY([product_id])
REFERENCES [dbo].[CollateralProducts] ([id])
GO
ALTER TABLE [dbo].[CollateralProperties] CHECK CONSTRAINT [FK_CollateralProperties_CollateralProducts]
GO
/****** Object:  ForeignKey [FK_CollateralProperties_CollateralPropertyTypes]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[CollateralProperties]  WITH CHECK ADD  CONSTRAINT [FK_CollateralProperties_CollateralPropertyTypes] FOREIGN KEY([type_id])
REFERENCES [dbo].[CollateralPropertyTypes] ([id])
GO
ALTER TABLE [dbo].[CollateralProperties] CHECK CONSTRAINT [FK_CollateralProperties_CollateralPropertyTypes]
GO
/****** Object:  ForeignKey [FK_ChartOfAccounts_AccountsCategory]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ChartOfAccounts]  WITH CHECK ADD  CONSTRAINT [FK_ChartOfAccounts_AccountsCategory] FOREIGN KEY([account_category_id])
REFERENCES [dbo].[AccountsCategory] ([id])
GO
ALTER TABLE [dbo].[ChartOfAccounts] CHECK CONSTRAINT [FK_ChartOfAccounts_AccountsCategory]
GO
/****** Object:  ForeignKey [FK_City_Districts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Districts] FOREIGN KEY([district_id])
REFERENCES [dbo].[Districts] ([id])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Districts]
GO
/****** Object:  ForeignKey [FK_CollateralPropertyCollections_CollateralProperties]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[CollateralPropertyCollections]  WITH CHECK ADD  CONSTRAINT [FK_CollateralPropertyCollections_CollateralProperties] FOREIGN KEY([property_id])
REFERENCES [dbo].[CollateralProperties] ([id])
GO
ALTER TABLE [dbo].[CollateralPropertyCollections] CHECK CONSTRAINT [FK_CollateralPropertyCollections_CollateralProperties]
GO
/****** Object:  ForeignKey [FK_AdvancedFieldsValues_AdvancedFields]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AdvancedFieldsValues]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedFieldsValues_AdvancedFields] FOREIGN KEY([field_id])
REFERENCES [dbo].[AdvancedFields] ([id])
GO
ALTER TABLE [dbo].[AdvancedFieldsValues] CHECK CONSTRAINT [FK_AdvancedFieldsValues_AdvancedFields]
GO
/****** Object:  ForeignKey [FK_AdvancedFieldsValues_AdvancedFieldsLinkEntities]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AdvancedFieldsValues]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedFieldsValues_AdvancedFieldsLinkEntities] FOREIGN KEY([entity_field_id])
REFERENCES [dbo].[AdvancedFieldsLinkEntities] ([id])
GO
ALTER TABLE [dbo].[AdvancedFieldsValues] CHECK CONSTRAINT [FK_AdvancedFieldsValues_AdvancedFieldsLinkEntities]
GO
/****** Object:  ForeignKey [FK_AdvancedFieldsCollections_AdvancedFields]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AdvancedFieldsCollections]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedFieldsCollections_AdvancedFields] FOREIGN KEY([field_id])
REFERENCES [dbo].[AdvancedFields] ([id])
GO
ALTER TABLE [dbo].[AdvancedFieldsCollections] CHECK CONSTRAINT [FK_AdvancedFieldsCollections_AdvancedFields]
GO
/****** Object:  ForeignKey [FK_AccountingRules_ChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AccountingRules]  WITH CHECK ADD  CONSTRAINT [FK_AccountingRules_ChartOfAccounts] FOREIGN KEY([debit_account_number_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[AccountingRules] CHECK CONSTRAINT [FK_AccountingRules_ChartOfAccounts]
GO
/****** Object:  ForeignKey [FK_AccountingRules_ChartOfAccounts1]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AccountingRules]  WITH CHECK ADD  CONSTRAINT [FK_AccountingRules_ChartOfAccounts1] FOREIGN KEY([credit_account_number_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[AccountingRules] CHECK CONSTRAINT [FK_AccountingRules_ChartOfAccounts1]
GO
/****** Object:  ForeignKey [FK_AccountingRules_EventAttributes]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AccountingRules]  WITH NOCHECK ADD  CONSTRAINT [FK_AccountingRules_EventAttributes] FOREIGN KEY([event_attribute_id])
REFERENCES [dbo].[EventAttributes] ([id])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[AccountingRules] CHECK CONSTRAINT [FK_AccountingRules_EventAttributes]
GO
/****** Object:  ForeignKey [FK_AccountingRules_EventTypes]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[AccountingRules]  WITH NOCHECK ADD  CONSTRAINT [FK_AccountingRules_EventTypes] FOREIGN KEY([event_type])
REFERENCES [dbo].[EventTypes] ([event_type])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[AccountingRules] CHECK CONSTRAINT [FK_AccountingRules_EventTypes]
GO
/****** Object:  ForeignKey [FK_LoanAccountingMovements_ChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LoanAccountingMovements]  WITH CHECK ADD  CONSTRAINT [FK_LoanAccountingMovements_ChartOfAccounts] FOREIGN KEY([debit_account_number_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[LoanAccountingMovements] CHECK CONSTRAINT [FK_LoanAccountingMovements_ChartOfAccounts]
GO
/****** Object:  ForeignKey [FK_LoanAccountingMovements_ChartOfAccounts1]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LoanAccountingMovements]  WITH CHECK ADD  CONSTRAINT [FK_LoanAccountingMovements_ChartOfAccounts1] FOREIGN KEY([credit_account_number_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[LoanAccountingMovements] CHECK CONSTRAINT [FK_LoanAccountingMovements_ChartOfAccounts1]
GO
/****** Object:  ForeignKey [FK_LinkBranchesPaymentMethods_ChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LinkBranchesPaymentMethods]  WITH CHECK ADD  CONSTRAINT [FK_LinkBranchesPaymentMethods_ChartOfAccounts] FOREIGN KEY([account_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[LinkBranchesPaymentMethods] CHECK CONSTRAINT [FK_LinkBranchesPaymentMethods_ChartOfAccounts]
GO
/****** Object:  ForeignKey [FK_LinkBranchesPaymentMethods_PaymentMethods]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[LinkBranchesPaymentMethods]  WITH CHECK ADD  CONSTRAINT [FK_LinkBranchesPaymentMethods_PaymentMethods] FOREIGN KEY([payment_method_id])
REFERENCES [dbo].[PaymentMethods] ([id])
GO
ALTER TABLE [dbo].[LinkBranchesPaymentMethods] CHECK CONSTRAINT [FK_LinkBranchesPaymentMethods_PaymentMethods]
GO
/****** Object:  ForeignKey [FK_ManualAccountingMovements_ChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ManualAccountingMovements]  WITH CHECK ADD  CONSTRAINT [FK_ManualAccountingMovements_ChartOfAccounts] FOREIGN KEY([debit_account_number_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[ManualAccountingMovements] CHECK CONSTRAINT [FK_ManualAccountingMovements_ChartOfAccounts]
GO
/****** Object:  ForeignKey [FK_ManualAccountingMovements_ChartOfAccounts1]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ManualAccountingMovements]  WITH CHECK ADD  CONSTRAINT [FK_ManualAccountingMovements_ChartOfAccounts1] FOREIGN KEY([credit_account_number_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[ManualAccountingMovements] CHECK CONSTRAINT [FK_ManualAccountingMovements_ChartOfAccounts1]
GO
/****** Object:  ForeignKey [FK_EntryFees_Packages]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[EntryFees]  WITH CHECK ADD  CONSTRAINT [FK_EntryFees_Packages] FOREIGN KEY([id_product])
REFERENCES [dbo].[Packages] ([id])
GO
ALTER TABLE [dbo].[EntryFees] CHECK CONSTRAINT [FK_EntryFees_Packages]
GO
/****** Object:  ForeignKey [FK_FundingLineEvents_FundingLines]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[FundingLineEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_FundingLineEvents_FundingLines] FOREIGN KEY([fundingline_id])
REFERENCES [dbo].[FundingLines] ([id])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[FundingLineEvents] CHECK CONSTRAINT [FK_FundingLineEvents_FundingLines]
GO
/****** Object:  ForeignKey [FK_Tiers_Branches]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tiers]  WITH CHECK ADD  CONSTRAINT [FK_Tiers_Branches] FOREIGN KEY([branch_id])
REFERENCES [dbo].[Branches] ([id])
GO
ALTER TABLE [dbo].[Tiers] CHECK CONSTRAINT [FK_Tiers_Branches]
GO
/****** Object:  ForeignKey [FK_Tiers_Corporates]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tiers]  WITH NOCHECK ADD  CONSTRAINT [FK_Tiers_Corporates] FOREIGN KEY([id])
REFERENCES [dbo].[Corporates] ([id])
GO
ALTER TABLE [dbo].[Tiers] NOCHECK CONSTRAINT [FK_Tiers_Corporates]
GO
/****** Object:  ForeignKey [FK_Tiers_Districts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tiers]  WITH NOCHECK ADD  CONSTRAINT [FK_Tiers_Districts] FOREIGN KEY([district_id])
REFERENCES [dbo].[Districts] ([id])
GO
ALTER TABLE [dbo].[Tiers] CHECK CONSTRAINT [FK_Tiers_Districts]
GO
/****** Object:  ForeignKey [FK_Tiers_Districts1]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tiers]  WITH NOCHECK ADD  CONSTRAINT [FK_Tiers_Districts1] FOREIGN KEY([secondary_district_id])
REFERENCES [dbo].[Districts] ([id])
GO
ALTER TABLE [dbo].[Tiers] CHECK CONSTRAINT [FK_Tiers_Districts1]
GO
/****** Object:  ForeignKey [FK_SavingsAccountingMovements_ChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingsAccountingMovements]  WITH CHECK ADD  CONSTRAINT [FK_SavingsAccountingMovements_ChartOfAccounts] FOREIGN KEY([debit_account_number_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[SavingsAccountingMovements] CHECK CONSTRAINT [FK_SavingsAccountingMovements_ChartOfAccounts]
GO
/****** Object:  ForeignKey [FK_SavingsAccountingMovements_ChartOfAccounts1]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingsAccountingMovements]  WITH CHECK ADD  CONSTRAINT [FK_SavingsAccountingMovements_ChartOfAccounts1] FOREIGN KEY([credit_account_number_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[SavingsAccountingMovements] CHECK CONSTRAINT [FK_SavingsAccountingMovements_ChartOfAccounts1]
GO
/****** Object:  ForeignKey [FK_SavingBookProducts_SavingProducts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingBookProducts]  WITH CHECK ADD  CONSTRAINT [FK_SavingBookProducts_SavingProducts] FOREIGN KEY([id])
REFERENCES [dbo].[SavingProducts] ([id])
GO
ALTER TABLE [dbo].[SavingBookProducts] CHECK CONSTRAINT [FK_SavingBookProducts_SavingProducts]
GO
/****** Object:  ForeignKey [FK_StandardBookings_ChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[StandardBookings]  WITH CHECK ADD  CONSTRAINT [FK_StandardBookings_ChartOfAccounts] FOREIGN KEY([debit_account_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[StandardBookings] CHECK CONSTRAINT [FK_StandardBookings_ChartOfAccounts]
GO
/****** Object:  ForeignKey [FK_StandardBookings_ChartOfAccounts1]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[StandardBookings]  WITH CHECK ADD  CONSTRAINT [FK_StandardBookings_ChartOfAccounts1] FOREIGN KEY([credit_account_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[StandardBookings] CHECK CONSTRAINT [FK_StandardBookings_ChartOfAccounts1]
GO
/****** Object:  ForeignKey [FK_VillagesPersons_Villages]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[VillagesPersons]  WITH CHECK ADD  CONSTRAINT [FK_VillagesPersons_Villages] FOREIGN KEY([village_id])
REFERENCES [dbo].[Villages] ([id])
GO
ALTER TABLE [dbo].[VillagesPersons] CHECK CONSTRAINT [FK_VillagesPersons_Villages]
GO
/****** Object:  ForeignKey [FK_VillagesAttendance_Villages]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[VillagesAttendance]  WITH CHECK ADD  CONSTRAINT [FK_VillagesAttendance_Villages] FOREIGN KEY([village_id])
REFERENCES [dbo].[Villages] ([id])
GO
ALTER TABLE [dbo].[VillagesAttendance] CHECK CONSTRAINT [FK_VillagesAttendance_Villages]
GO
/****** Object:  ForeignKey [FK_TermDepositProducts_InstallmentTypes]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[TermDepositProducts]  WITH CHECK ADD  CONSTRAINT [FK_TermDepositProducts_InstallmentTypes] FOREIGN KEY([installment_types_id])
REFERENCES [dbo].[InstallmentTypes] ([id])
GO
ALTER TABLE [dbo].[TermDepositProducts] CHECK CONSTRAINT [FK_TermDepositProducts_InstallmentTypes]
GO
/****** Object:  ForeignKey [FK_TermDepositProducts_SavingProducts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[TermDepositProducts]  WITH CHECK ADD  CONSTRAINT [FK_TermDepositProducts_SavingProducts] FOREIGN KEY([id])
REFERENCES [dbo].[SavingProducts] ([id])
GO
ALTER TABLE [dbo].[TermDepositProducts] CHECK CONSTRAINT [FK_TermDepositProducts_SavingProducts]
GO
/****** Object:  ForeignKey [FK_Tellers_Branches]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tellers]  WITH CHECK ADD  CONSTRAINT [FK_Tellers_Branches] FOREIGN KEY([branch_id])
REFERENCES [dbo].[Branches] ([id])
GO
ALTER TABLE [dbo].[Tellers] CHECK CONSTRAINT [FK_Tellers_Branches]
GO
/****** Object:  ForeignKey [FK_Tellers_ChartOfAccounts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tellers]  WITH CHECK ADD  CONSTRAINT [FK_Tellers_ChartOfAccounts] FOREIGN KEY([account_id])
REFERENCES [dbo].[ChartOfAccounts] ([id])
GO
ALTER TABLE [dbo].[Tellers] CHECK CONSTRAINT [FK_Tellers_ChartOfAccounts]
GO
/****** Object:  ForeignKey [FK_Tellers_Currencies]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Tellers]  WITH CHECK ADD  CONSTRAINT [FK_Tellers_Currencies] FOREIGN KEY([currency_id])
REFERENCES [dbo].[Currencies] ([id])
GO
ALTER TABLE [dbo].[Tellers] CHECK CONSTRAINT [FK_Tellers_Currencies]
GO
/****** Object:  ForeignKey [FK_TellerEvents_Tellers]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[TellerEvents]  WITH CHECK ADD  CONSTRAINT [FK_TellerEvents_Tellers] FOREIGN KEY([teller_id])
REFERENCES [dbo].[Tellers] ([id])
GO
ALTER TABLE [dbo].[TellerEvents] CHECK CONSTRAINT [FK_TellerEvents_Tellers]
GO
/****** Object:  ForeignKey [FK_SavingContracts_Tiers]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingContracts]  WITH CHECK ADD  CONSTRAINT [FK_SavingContracts_Tiers] FOREIGN KEY([tiers_id])
REFERENCES [dbo].[Tiers] ([id])
GO
ALTER TABLE [dbo].[SavingContracts] CHECK CONSTRAINT [FK_SavingContracts_Tiers]
GO
/****** Object:  ForeignKey [FK_SavingContracts_Users]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingContracts]  WITH CHECK ADD  CONSTRAINT [FK_SavingContracts_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[SavingContracts] CHECK CONSTRAINT [FK_SavingContracts_Users]
GO
/****** Object:  ForeignKey [FK_Savings_SavingProducts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[SavingContracts]  WITH CHECK ADD  CONSTRAINT [FK_Savings_SavingProducts] FOREIGN KEY([product_id])
REFERENCES [dbo].[SavingProducts] ([id])
GO
ALTER TABLE [dbo].[SavingContracts] CHECK CONSTRAINT [FK_Savings_SavingProducts]
GO
/****** Object:  ForeignKey [FK_Groups_Tiers]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Groups]  WITH NOCHECK ADD  CONSTRAINT [FK_Groups_Tiers] FOREIGN KEY([id])
REFERENCES [dbo].[Tiers] ([id])
GO
ALTER TABLE [dbo].[Groups] NOCHECK CONSTRAINT [FK_Groups_Tiers]
GO
/****** Object:  ForeignKey [FK_FundingLineAccountingRules_AccountingRules]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[FundingLineAccountingRules]  WITH CHECK ADD  CONSTRAINT [FK_FundingLineAccountingRules_AccountingRules] FOREIGN KEY([id])
REFERENCES [dbo].[AccountingRules] ([id])
GO
ALTER TABLE [dbo].[FundingLineAccountingRules] CHECK CONSTRAINT [FK_FundingLineAccountingRules_AccountingRules]
GO
/****** Object:  ForeignKey [FK_FundingLineAccountingRules_FundingLine]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[FundingLineAccountingRules]  WITH CHECK ADD  CONSTRAINT [FK_FundingLineAccountingRules_FundingLine] FOREIGN KEY([funding_line_id])
REFERENCES [dbo].[FundingLines] ([id])
GO
ALTER TABLE [dbo].[FundingLineAccountingRules] CHECK CONSTRAINT [FK_FundingLineAccountingRules_FundingLine]
GO
/****** Object:  ForeignKey [FK_Projects_Tiers]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Tiers] FOREIGN KEY([tiers_id])
REFERENCES [dbo].[Tiers] ([id])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_Tiers]
GO
/****** Object:  ForeignKey [FK_Persons_Banks]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Banks] FOREIGN KEY([personalBank_id])
REFERENCES [dbo].[Banks] ([id])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Banks]
GO
/****** Object:  ForeignKey [FK_Persons_Banks1]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Banks1] FOREIGN KEY([businessBank_id])
REFERENCES [dbo].[Banks] ([id])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Banks1]
GO
/****** Object:  ForeignKey [FK_Persons_DomainOfApplications]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons]  WITH NOCHECK ADD  CONSTRAINT [FK_Persons_DomainOfApplications] FOREIGN KEY([activity_id])
REFERENCES [dbo].[EconomicActivities] ([id])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_DomainOfApplications]
GO
/****** Object:  ForeignKey [FK_Persons_Tiers]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[Persons]  WITH NOCHECK ADD  CONSTRAINT [FK_Persons_Tiers] FOREIGN KEY([id])
REFERENCES [dbo].[Tiers] ([id])
GO
ALTER TABLE [dbo].[Persons] NOCHECK CONSTRAINT [FK_Persons_Tiers]
GO
/****** Object:  ForeignKey [FK_ContractAccountingRules_AccountingRules]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ContractAccountingRules]  WITH CHECK ADD  CONSTRAINT [FK_ContractAccountingRules_AccountingRules] FOREIGN KEY([id])
REFERENCES [dbo].[AccountingRules] ([id])
GO
ALTER TABLE [dbo].[ContractAccountingRules] CHECK CONSTRAINT [FK_ContractAccountingRules_AccountingRules]
GO
/****** Object:  ForeignKey [FK_ContractAccountingRules_DomainOfApplications]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ContractAccountingRules]  WITH CHECK ADD  CONSTRAINT [FK_ContractAccountingRules_DomainOfApplications] FOREIGN KEY([activity_id])
REFERENCES [dbo].[EconomicActivities] ([id])
GO
ALTER TABLE [dbo].[ContractAccountingRules] CHECK CONSTRAINT [FK_ContractAccountingRules_DomainOfApplications]
GO
/****** Object:  ForeignKey [FK_ContractAccountingRules_Packages]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ContractAccountingRules]  WITH CHECK ADD  CONSTRAINT [FK_ContractAccountingRules_Packages] FOREIGN KEY([loan_product_id])
REFERENCES [dbo].[Packages] ([id])
GO
ALTER TABLE [dbo].[ContractAccountingRules] CHECK CONSTRAINT [FK_ContractAccountingRules_Packages]
GO
/****** Object:  ForeignKey [FK_ContractAccountingRules_SavingProducts]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ContractAccountingRules]  WITH CHECK ADD  CONSTRAINT [FK_ContractAccountingRules_SavingProducts] FOREIGN KEY([savings_product_id])
REFERENCES [dbo].[SavingProducts] ([id])
GO
ALTER TABLE [dbo].[ContractAccountingRules] CHECK CONSTRAINT [FK_ContractAccountingRules_SavingProducts]
GO
/****** Object:  ForeignKey [FK_ClientBranchHistory_Branches]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ClientBranchHistory]  WITH CHECK ADD  CONSTRAINT [FK_ClientBranchHistory_Branches] FOREIGN KEY([branch_from_id])
REFERENCES [dbo].[Branches] ([id])
GO
ALTER TABLE [dbo].[ClientBranchHistory] CHECK CONSTRAINT [FK_ClientBranchHistory_Branches]
GO
/****** Object:  ForeignKey [FK_ClientBranchHistory_Tiers]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ClientBranchHistory]  WITH CHECK ADD  CONSTRAINT [FK_ClientBranchHistory_Tiers] FOREIGN KEY([client_id])
REFERENCES [dbo].[Tiers] ([id])
GO
ALTER TABLE [dbo].[ClientBranchHistory] CHECK CONSTRAINT [FK_ClientBranchHistory_Tiers]
GO
/****** Object:  ForeignKey [FK_ClientBranchHistory_Users]    Script Date: 09/17/2014 00:58:41 ******/
ALTER TABLE [dbo].[ClientBranchHistory]  WITH CHECK ADD  CONSTRAINT [FK_ClientBranchHistory_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[ClientBranchHistory] CHECK CONSTRAINT [FK_ClientBranchHistory_Users]
GO
/****** Object:  ForeignKey [FK_CorporatePersonBelonging_Corporates]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[CorporatePersonBelonging]  WITH CHECK ADD  CONSTRAINT [FK_CorporatePersonBelonging_Corporates] FOREIGN KEY([corporate_id])
REFERENCES [dbo].[Corporates] ([id])
GO
ALTER TABLE [dbo].[CorporatePersonBelonging] CHECK CONSTRAINT [FK_CorporatePersonBelonging_Corporates]
GO
/****** Object:  ForeignKey [FK_CorporatePersonBelonging_Persons]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[CorporatePersonBelonging]  WITH CHECK ADD  CONSTRAINT [FK_CorporatePersonBelonging_Persons] FOREIGN KEY([person_id])
REFERENCES [dbo].[Persons] ([id])
GO
ALTER TABLE [dbo].[CorporatePersonBelonging] CHECK CONSTRAINT [FK_CorporatePersonBelonging_Persons]
GO
/****** Object:  ForeignKey [FK_Contracts_EconomicActivities]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_EconomicActivities] FOREIGN KEY([activity_id])
REFERENCES [dbo].[EconomicActivities] ([id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_EconomicActivities]
GO
/****** Object:  ForeignKey [FK_Contracts_Projects]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_Projects] FOREIGN KEY([project_id])
REFERENCES [dbo].[Projects] ([id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_Projects]
GO
/****** Object:  ForeignKey [FK_Contracts_Villages]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_Villages] FOREIGN KEY([nsg_id])
REFERENCES [dbo].[Villages] ([id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_Villages]
GO
/****** Object:  ForeignKey [FK_PersonGroupBelonging_Persons1]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[PersonGroupBelonging]  WITH NOCHECK ADD  CONSTRAINT [FK_PersonGroupBelonging_Persons1] FOREIGN KEY([person_id])
REFERENCES [dbo].[Persons] ([id])
GO
ALTER TABLE [dbo].[PersonGroupBelonging] CHECK CONSTRAINT [FK_PersonGroupBelonging_Persons1]
GO
/****** Object:  ForeignKey [FK_PersonGroupCorrespondance_Groups]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[PersonGroupBelonging]  WITH NOCHECK ADD  CONSTRAINT [FK_PersonGroupCorrespondance_Groups] FOREIGN KEY([group_id])
REFERENCES [dbo].[Groups] ([id])
GO
ALTER TABLE [dbo].[PersonGroupBelonging] CHECK CONSTRAINT [FK_PersonGroupCorrespondance_Groups]
GO
/****** Object:  ForeignKey [FK_FollowUp_Projects]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[FollowUp]  WITH CHECK ADD  CONSTRAINT [FK_FollowUp_Projects] FOREIGN KEY([project_id])
REFERENCES [dbo].[Projects] ([id])
GO
ALTER TABLE [dbo].[FollowUp] CHECK CONSTRAINT [FK_FollowUp_Projects]
GO
/****** Object:  ForeignKey [FK_SavingEvents_SavingContracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingEvents]  WITH CHECK ADD  CONSTRAINT [FK_SavingEvents_SavingContracts] FOREIGN KEY([contract_id])
REFERENCES [dbo].[SavingContracts] ([id])
GO
ALTER TABLE [dbo].[SavingEvents] CHECK CONSTRAINT [FK_SavingEvents_SavingContracts]
GO
/****** Object:  ForeignKey [FK_SavingEvents_Tellers]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingEvents]  WITH CHECK ADD  CONSTRAINT [FK_SavingEvents_Tellers] FOREIGN KEY([teller_id])
REFERENCES [dbo].[Tellers] ([id])
GO
ALTER TABLE [dbo].[SavingEvents] CHECK CONSTRAINT [FK_SavingEvents_Tellers]
GO
/****** Object:  ForeignKey [FK_SavingEvents_Users]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingEvents]  WITH CHECK ADD  CONSTRAINT [FK_SavingEvents_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[SavingEvents] CHECK CONSTRAINT [FK_SavingEvents_Users]
GO
/****** Object:  ForeignKey [FK_SavingDepositContract_SavingContracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingDepositContracts]  WITH CHECK ADD  CONSTRAINT [FK_SavingDepositContract_SavingContracts] FOREIGN KEY([id])
REFERENCES [dbo].[SavingContracts] ([id])
GO
ALTER TABLE [dbo].[SavingDepositContracts] CHECK CONSTRAINT [FK_SavingDepositContract_SavingContracts]
GO
/****** Object:  ForeignKey [FK_SavingBookContract_SavingContracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[SavingBookContracts]  WITH CHECK ADD  CONSTRAINT [FK_SavingBookContract_SavingContracts] FOREIGN KEY([id])
REFERENCES [dbo].[SavingContracts] ([id])
GO
ALTER TABLE [dbo].[SavingBookContracts] CHECK CONSTRAINT [FK_SavingBookContract_SavingContracts]
GO
/****** Object:  ForeignKey [FK_LinkGuarantorCredit_Contracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LinkGuarantorCredit]  WITH NOCHECK ADD  CONSTRAINT [FK_LinkGuarantorCredit_Contracts] FOREIGN KEY([contract_id])
REFERENCES [dbo].[Contracts] ([id])
GO
ALTER TABLE [dbo].[LinkGuarantorCredit] CHECK CONSTRAINT [FK_LinkGuarantorCredit_Contracts]
GO
/****** Object:  ForeignKey [FK_LinkGuarantorCredit_Tiers]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LinkGuarantorCredit]  WITH NOCHECK ADD  CONSTRAINT [FK_LinkGuarantorCredit_Tiers] FOREIGN KEY([tiers_id])
REFERENCES [dbo].[Tiers] ([id])
GO
ALTER TABLE [dbo].[LinkGuarantorCredit] CHECK CONSTRAINT [FK_LinkGuarantorCredit_Tiers]
GO
/****** Object:  ForeignKey [FK_LoansLinkSavingsBook_Contracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LoansLinkSavingsBook]  WITH CHECK ADD  CONSTRAINT [FK_LoansLinkSavingsBook_Contracts] FOREIGN KEY([loan_id])
REFERENCES [dbo].[Contracts] ([id])
GO
ALTER TABLE [dbo].[LoansLinkSavingsBook] CHECK CONSTRAINT [FK_LoansLinkSavingsBook_Contracts]
GO
/****** Object:  ForeignKey [FK_LoansLinkSavingsBook_SavingContracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LoansLinkSavingsBook]  WITH CHECK ADD  CONSTRAINT [FK_LoansLinkSavingsBook_SavingContracts] FOREIGN KEY([savings_id])
REFERENCES [dbo].[SavingContracts] ([id])
GO
ALTER TABLE [dbo].[LoansLinkSavingsBook] CHECK CONSTRAINT [FK_LoansLinkSavingsBook_SavingContracts]
GO
/****** Object:  ForeignKey [FK_ContractEvents_Contracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_ContractEvents_Contracts] FOREIGN KEY([contract_id])
REFERENCES [dbo].[Contracts] ([id])
GO
ALTER TABLE [dbo].[ContractEvents] CHECK CONSTRAINT [FK_ContractEvents_Contracts]
GO
/****** Object:  ForeignKey [FK_ContractEvents_LoanInterestAccruingEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_ContractEvents_LoanInterestAccruingEvents] FOREIGN KEY([id])
REFERENCES [dbo].[LoanInterestAccruingEvents] ([id])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[ContractEvents] NOCHECK CONSTRAINT [FK_ContractEvents_LoanInterestAccruingEvents]
GO
/****** Object:  ForeignKey [FK_ContractEvents_Tellers]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_ContractEvents_Tellers] FOREIGN KEY([teller_id])
REFERENCES [dbo].[Tellers] ([id])
GO
ALTER TABLE [dbo].[ContractEvents] CHECK CONSTRAINT [FK_ContractEvents_Tellers]
GO
/****** Object:  ForeignKey [FK_ContractEvents_Users]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_ContractEvents_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[ContractEvents] CHECK CONSTRAINT [FK_ContractEvents_Users]
GO
/****** Object:  ForeignKey [FK_ContractAssignHistory_Contracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractAssignHistory]  WITH CHECK ADD  CONSTRAINT [FK_ContractAssignHistory_Contracts] FOREIGN KEY([contract_id])
REFERENCES [dbo].[Contracts] ([id])
GO
ALTER TABLE [dbo].[ContractAssignHistory] CHECK CONSTRAINT [FK_ContractAssignHistory_Contracts]
GO
/****** Object:  ForeignKey [FK_ContractAssignHistory_Users]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractAssignHistory]  WITH CHECK ADD  CONSTRAINT [FK_ContractAssignHistory_Users] FOREIGN KEY([loanofficerFrom_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[ContractAssignHistory] CHECK CONSTRAINT [FK_ContractAssignHistory_Users]
GO
/****** Object:  ForeignKey [FK_ContractAssignHistory_Users1]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ContractAssignHistory]  WITH CHECK ADD  CONSTRAINT [FK_ContractAssignHistory_Users1] FOREIGN KEY([loanofficerTo_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[ContractAssignHistory] CHECK CONSTRAINT [FK_ContractAssignHistory_Users1]
GO
/****** Object:  ForeignKey [FK_CollateralsLinkContracts_Contracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[CollateralsLinkContracts]  WITH CHECK ADD  CONSTRAINT [FK_CollateralsLinkContracts_Contracts] FOREIGN KEY([contract_id])
REFERENCES [dbo].[Contracts] ([id])
GO
ALTER TABLE [dbo].[CollateralsLinkContracts] CHECK CONSTRAINT [FK_CollateralsLinkContracts_Contracts]
GO
/****** Object:  ForeignKey [FK_Credit_Contracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit]  WITH NOCHECK ADD  CONSTRAINT [FK_Credit_Contracts] FOREIGN KEY([id])
REFERENCES [dbo].[Contracts] ([id])
GO
ALTER TABLE [dbo].[Credit] CHECK CONSTRAINT [FK_Credit_Contracts]
GO
/****** Object:  ForeignKey [FK_Credit_InstallmentTypes]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit]  WITH NOCHECK ADD  CONSTRAINT [FK_Credit_InstallmentTypes] FOREIGN KEY([installment_type])
REFERENCES [dbo].[InstallmentTypes] ([id])
GO
ALTER TABLE [dbo].[Credit] CHECK CONSTRAINT [FK_Credit_InstallmentTypes]
GO
/****** Object:  ForeignKey [FK_Credit_Packages]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit]  WITH NOCHECK ADD  CONSTRAINT [FK_Credit_Packages] FOREIGN KEY([package_id])
REFERENCES [dbo].[Packages] ([id])
GO
ALTER TABLE [dbo].[Credit] CHECK CONSTRAINT [FK_Credit_Packages]
GO
/****** Object:  ForeignKey [FK_Credit_Temp_FundingLines]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit]  WITH NOCHECK ADD  CONSTRAINT [FK_Credit_Temp_FundingLines] FOREIGN KEY([fundingLine_id])
REFERENCES [dbo].[FundingLines] ([id])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Credit] CHECK CONSTRAINT [FK_Credit_Temp_FundingLines]
GO
/****** Object:  ForeignKey [FK_Credit_Users]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Credit]  WITH NOCHECK ADD  CONSTRAINT [FK_Credit_Users] FOREIGN KEY([loanofficer_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Credit] NOCHECK CONSTRAINT [FK_Credit_Users]
GO
/****** Object:  ForeignKey [FK_CreditEntryFees_Credit]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[CreditEntryFees]  WITH CHECK ADD  CONSTRAINT [FK_CreditEntryFees_Credit] FOREIGN KEY([credit_id])
REFERENCES [dbo].[Credit] ([id])
GO
ALTER TABLE [dbo].[CreditEntryFees] CHECK CONSTRAINT [FK_CreditEntryFees_Credit]
GO
/****** Object:  ForeignKey [FK_CollateralPropertyValues_CollateralProperties]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[CollateralPropertyValues]  WITH CHECK ADD  CONSTRAINT [FK_CollateralPropertyValues_CollateralProperties] FOREIGN KEY([property_id])
REFERENCES [dbo].[CollateralProperties] ([id])
GO
ALTER TABLE [dbo].[CollateralPropertyValues] CHECK CONSTRAINT [FK_CollateralPropertyValues_CollateralProperties]
GO
/****** Object:  ForeignKey [FK_CollateralPropertyValues_CollateralsLinkContracts]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[CollateralPropertyValues]  WITH CHECK ADD  CONSTRAINT [FK_CollateralPropertyValues_CollateralsLinkContracts] FOREIGN KEY([contract_collateral_id])
REFERENCES [dbo].[CollateralsLinkContracts] ([id])
GO
ALTER TABLE [dbo].[CollateralPropertyValues] CHECK CONSTRAINT [FK_CollateralPropertyValues_CollateralsLinkContracts]
GO
/****** Object:  ForeignKey [FK_AccrualInterestLoanEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[AccrualInterestLoanEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_AccrualInterestLoanEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[AccrualInterestLoanEvents] NOCHECK CONSTRAINT [FK_AccrualInterestLoanEvents_ContractEvents]
GO
/****** Object:  ForeignKey [FK_ProvisionEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ProvisionEvents]  WITH CHECK ADD  CONSTRAINT [FK_ProvisionEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[ProvisionEvents] CHECK CONSTRAINT [FK_ProvisionEvents_ContractEvents]
GO
/****** Object:  ForeignKey [FK_LoanPenaltyAccrualEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LoanPenaltyAccrualEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_LoanPenaltyAccrualEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[LoanPenaltyAccrualEvents] NOCHECK CONSTRAINT [FK_LoanPenaltyAccrualEvents_ContractEvents]
GO
/****** Object:  ForeignKey [FK_OverdueEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[OverdueEvents]  WITH CHECK ADD  CONSTRAINT [FK_OverdueEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[OverdueEvents] CHECK CONSTRAINT [FK_OverdueEvents_ContractEvents]
GO
/****** Object:  ForeignKey [FK_LoanDisbursmentEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[LoanDisbursmentEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_LoanDisbursmentEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[LoanDisbursmentEvents] CHECK CONSTRAINT [FK_LoanDisbursmentEvents_ContractEvents]
GO
/****** Object:  ForeignKey [FK_Installments_Credit]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[Installments]  WITH NOCHECK ADD  CONSTRAINT [FK_Installments_Credit] FOREIGN KEY([contract_id])
REFERENCES [dbo].[Credit] ([id])
GO
ALTER TABLE [dbo].[Installments] NOCHECK CONSTRAINT [FK_Installments_Credit]
GO
/****** Object:  ForeignKey [FK_InstallmentHistory_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[InstallmentHistory]  WITH CHECK ADD  CONSTRAINT [FK_InstallmentHistory_ContractEvents] FOREIGN KEY([event_id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[InstallmentHistory] CHECK CONSTRAINT [FK_InstallmentHistory_ContractEvents]
GO
/****** Object:  ForeignKey [FK_ReschedulingOfALoanEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[ReschedulingOfALoanEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_ReschedulingOfALoanEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[ReschedulingOfALoanEvents] NOCHECK CONSTRAINT [FK_ReschedulingOfALoanEvents_ContractEvents]
GO
/****** Object:  ForeignKey [FK_RepaymentEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[RepaymentEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_RepaymentEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[RepaymentEvents] NOCHECK CONSTRAINT [FK_RepaymentEvents_ContractEvents]
GO
/****** Object:  ForeignKey [FK_TrancheEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[TrancheEvents]  WITH CHECK ADD  CONSTRAINT [FK_TrancheEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[TrancheEvents] CHECK CONSTRAINT [FK_TrancheEvents_ContractEvents]
GO
/****** Object:  ForeignKey [FK_WriteOffEvents_ContractEvents]    Script Date: 09/17/2014 00:58:42 ******/
ALTER TABLE [dbo].[WriteOffEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_WriteOffEvents_ContractEvents] FOREIGN KEY([id])
REFERENCES [dbo].[ContractEvents] ([id])
GO
ALTER TABLE [dbo].[WriteOffEvents] NOCHECK CONSTRAINT [FK_WriteOffEvents_ContractEvents]
GO
