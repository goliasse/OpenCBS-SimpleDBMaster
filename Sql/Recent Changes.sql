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

BEGIN
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
	[deleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

BEGIN
CREATE TABLE [dbo].[FixedDepositProductsClientTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fixed_deposit_product_id] [int] NOT NULL,
	[client_type_id] [int] NOT NULL
) ON [PRIMARY]
END
GO

BEGIN
CREATE TABLE [dbo].[FixedDepositProductHoldings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NULL,
	[client_type] [char](1) NULL,
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
	[pre_matured] [bit] NOT NULL,
	[comment] [nvarchar](50) NULL,
	[fixed_deposit_product_id] [int] NOT NULL,
	[effective_interest_rate] [float] NULL,
	[effective_deposit_period] [float] NULL,
	[final_amount] [money] NULL,
	[final_interest] [money] NULL,
	[initial_amount_payment_method] [nvarchar](50) NULL,
	[final_amount_payment_method] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[FixedDepositProductHoldings]  WITH CHECK ADD FOREIGN KEY([fixed_deposit_product_id])
REFERENCES [dbo].[FixedDepositProducts] ([id])

END
GO




