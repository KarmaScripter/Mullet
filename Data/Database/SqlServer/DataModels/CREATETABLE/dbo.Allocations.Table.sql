USE [Data]
GO
/****** Object:  Table [dbo].[Allocations]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allocations](
	[AllocationsId] [int] NOT NULL,
	[StatusOfFundsId] [int] NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[Amount] [float] NOT NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
 CONSTRAINT [PK_Allocations] PRIMARY KEY CLUSTERED 
(
	[AllocationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
