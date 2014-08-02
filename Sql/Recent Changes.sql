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
	[creation_date] [date] NOT NULL
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
	[creation_date] [date] NOT NULL
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