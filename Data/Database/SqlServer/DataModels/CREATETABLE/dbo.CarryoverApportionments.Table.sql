USE [Data]
GO
/****** Object:  Table [dbo].[CarryoverApportionments]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarryoverApportionments](
	[CarryoverApportionmentsId] [int] NOT NULL,
	[BudgetAccount] [nvarchar](80) NULL,
	[TreasuryAccount] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[Group] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[AuthorityType] [nvarchar](80) NULL,
	[Request] [float] NULL,
	[Balance] [float] NULL,
	[Deobligations] [float] NULL,
	[Amount] [float] NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineSplit] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
 CONSTRAINT [PK_CarryoverApportionments] PRIMARY KEY CLUSTERED 
(
	[CarryoverApportionmentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
