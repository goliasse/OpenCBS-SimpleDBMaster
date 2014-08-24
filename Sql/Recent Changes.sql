BEGIN
ALTER TABLE dbo.Persons ADD kyc_status nvarchar(50) NULL,marital_status nvarchar(50) NULL, type_of_facilities nvarchar(MAX) NULL,
estimated_work nvarchar(50) null
END
GO

BEGIN
ALTER TABLE dbo.ManualAccountingMovements 
ADD maker_id nvarchar(50) NULL,
checker_id nvarchar(50) NULL,
type_of_transaction nvarchar(50) NULL
END
GO

USE [Test]
GO

/****** Object:  Table [dbo].[CurrentAccountProduct]    Script Date: 07/30/2014 19:51:16 ******/
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




USE [Test]
GO

/****** Object:  Table [dbo].[CurrentAccountProductHoldings]    Script Date: 07/30/2014 19:51:29 ******/
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

ALTER TABLE [dbo].[CurrentAccountProductHoldings] ADD  CONSTRAINT [DF_CurrentAccountProductHoldings_balance]  DEFAULT ((0)) FOR [balance]
GO




USE [Test]
GO

/****** Object:  Table [dbo].[CurrentAccountTransactionFees]    Script Date: 07/30/2014 19:51:39 ******/
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



USE [Test]
GO

/****** Object:  Table [dbo].[CurrentAccountTransactions]    Script Date: 07/30/2014 19:51:49 ******/
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

ALTER TABLE [dbo].[CurrentAccountTransactions] ADD  CONSTRAINT [DF_CurrentAccountTransactions_from_account_balance]  DEFAULT ((0)) FOR [from_account_balance]
GO

ALTER TABLE [dbo].[CurrentAccountTransactions] ADD  CONSTRAINT [DF_CurrentAccountTransactions_to_account_balance]  DEFAULT ((0)) FOR [to_account_balance]
GO




USE [Test]
GO

/****** Object:  Table [dbo].[FixedDepositProductHoldings]    Script Date: 07/30/2014 19:52:02 ******/
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

ALTER TABLE [dbo].[FixedDepositProductHoldings]  WITH CHECK ADD  CONSTRAINT [FK__FixedDepo__fixed__5DEAEAF5] FOREIGN KEY([fixed_deposit_product_id])
REFERENCES [dbo].[FixedDepositProducts] ([id])
GO

ALTER TABLE [dbo].[FixedDepositProductHoldings] CHECK CONSTRAINT [FK__FixedDepo__fixed__5DEAEAF5]
GO


USE [Test]
GO

/****** Object:  Table [dbo].[FixedDepositProducts]    Script Date: 07/30/2014 19:52:11 ******/
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


USE [Test]
GO

/****** Object:  Table [dbo].[FixedDepositProductsClientTypes]    Script Date: 07/30/2014 19:52:27 ******/
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


USE [Test]
GO

/****** Object:  Table [dbo].[CurrentAccountEvents]    Script Date: 07/30/2014 20:22:28 ******/
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


USE [Test]
GO

/****** Object:  Table [dbo].[FixedDepositEvents]    Script Date: 07/30/2014 20:24:14 ******/
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

USE [Test]
GO

/****** Object:  Table [dbo].[FixedDepositProductsClientTypes]    Script Date: 07/30/2014 19:52:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT INTO [Test].[dbo].[EventTypes]
           ([event_type]
           ,[description]
           ,[sort_order]
           ,[accounting])
VALUES
('CAOP', 'Current Account Open',800 ,1),
('CACL', 'Current Account close',801 ,1),
('CARE', 'Current Account Reopen',802 ,1),
('CADO', 'Current Account Dormant',803 ,1),
('ODAP', 'Current Account OD applied',804 ,1),
('ODWT', 'Current Account OD withdrawn',805 ,1),
('CACT', 'Current Account Credit transaction',806 ,1),
('CADT', 'Current Account Debit transaction',807 ,1),
('REFT', 'Reopen Fee debit transaction',808 ,1),
('ENFT', 'Entry Fee debit transaction',809 ,1),
('CLFT', 'Close Fee debit transaction',810 ,1),
('TRFT', 'Transaction Fee debit transaction',811 ,1),
('ODFT', 'Fixed OD Fee debit transaction',812 ,1),
('RICT', 'Regular interest credit transaction',813 ,1),
('ODDT', 'OD Interest debit transaction',814 ,1),
('CFDT', 'Commitment fee debit transaction',815 ,1),
('MGFT', 'Management Fee debit transaction',816 ,1),
('FDOP', 'Fixed Deposit Open',817 ,1),
('FDCL', 'Fixed Deposit Close',818 ,1), 
('FDPR', 'Fixed Deposit Prematured',819 ,1),
('FDPE', 'Fixed Deposit Maturity Period Extended',820 ,1),
('FDCT', 'Fixed Deposit Credit transaction',821 ,1),
('FDDT', 'Fixed Deposit Debit transaction',822 ,1)
GO





USE [Test]
GO

/****** Object:  StoredProcedure [dbo].[GetDormantAccount]   Script Date: 08/04/2014 08:34:22 ******/
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


USE [Test]
GO
/****** Object:  UserDefinedFunction [dbo].[AuditTrailEvents]    Script Date: 08/17/2014 11:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[AuditTrailEvents] (
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


CREATE TABLE [dbo].[CounterBalance](
[id] [int] IDENTITY(1,1) NOT NULL  ,
[allocater_id] [int] NOT NULL  ,
[branch] [nvarchar](100) NOT NULL,
[cashier_id] [int] NOT NULL  ,
[counter_id] [int] NOT NULL  ,
[allocation_date] [date] NOT NULL  ,
[amount] [money] NULL,
[type] [nvarchar](100) NOT NULL,
Primary Key(id)
)


CREATE TABLE [dbo].[FixedAssetRegister](
[id] [int] IDENTITY(1,1) NOT NULL  ,
[updater_id] int NOT NULL,
[branch] [nvarchar](100) NOT NULL,
[Asset_id] [nvarchar](100) NOT NULL  ,
[Description] [nvarchar](1000) NOT NULL  ,
[Asset_type] [nvarchar](100) NOT NULL  ,
[No_of_assets] [int] NOT NULL  ,
[Acquisition_date] [date] NOT NULL  ,
[Original_cost] [money] NULL,
[Annual_depreciation_rate] [Float] NOT NULL,
[Accumulated_depreciation_charge] [money] NULL,
[Net_book_value] [money] NULL,
[Disposal_date] [date],
[Profit_loss_disposal] [int] NOT NULL  ,
[Acquisition_capital_finance] [nvarchar](100) NOT NULL,
[Acquisition_capital_transaction] [nvarchar](100) NOT NULL,
[Disposal_amount_transfer] [nvarchar](100),
[Disposal_amount_transaction] [nvarchar](100) NOT NULL,
Primary Key(id)
)
