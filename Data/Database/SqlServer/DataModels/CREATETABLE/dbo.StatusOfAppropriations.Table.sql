USE [Data]
GO
/****** Object:  Table [dbo].[StatusOfAppropriations]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfAppropriations](
	[StatusOfAppropriationsId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[Availability] [nvarchar](80) NULL,
	[TransType] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OriginalAmount] [float] NULL,
	[Authority] [float] NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[CarryoverOut] [float] NULL,
	[CarryoverIn] [float] NULL,
	[TransferIn] [float] NULL,
	[TransferOut] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[Used] [float] NULL,
	[Expenditures] [float] NULL,
	[UnliquidatedObligations] [float] NULL,
	[Available] [float] NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
 CONSTRAINT [PK_StatusOfAppropriations] PRIMARY KEY CLUSTERED 
(
	[StatusOfAppropriationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
