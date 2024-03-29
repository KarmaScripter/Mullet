USE [Data]
GO
/****** Object:  Table [dbo].[MonthlyLedgerAccountBalances]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonthlyLedgerAccountBalances](
	[MonthlyLedgerAccountBalancesId] [int] NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[LedgerAccount] [nvarchar](80) NULL,
	[LedgerName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[TreasurySymbolName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[FiscalMonth] [nvarchar](80) NULL,
	[CreditBalance] [float] NULL,
	[DebitBalance] [float] NULL,
	[YearToDateAmount] [float] NULL,
 CONSTRAINT [PK_MonthlyLedgerAccountBalances] PRIMARY KEY CLUSTERED 
(
	[MonthlyLedgerAccountBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
