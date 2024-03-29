USE [Data]
GO
/****** Object:  Table [dbo].[AppropriationDocuments]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppropriationDocuments](
	[AppropriationDocumentsId] [int] NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[AppropriationFund] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentDate] [datetime] NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BudgetingControls] [nvarchar](80) NULL,
	[PostingControls] [nvarchar](80) NULL,
	[PreCommitmentControls] [nvarchar](80) NULL,
	[CommitmentControls] [nvarchar](80) NULL,
	[ObligationControls] [nvarchar](80) NULL,
	[AccrualControls] [nvarchar](80) NULL,
	[ExpenditureControls] [nvarchar](255) NULL,
	[ExpenseControls] [nvarchar](80) NULL,
	[ReimbursementControls] [nvarchar](80) NULL,
	[ReimbursableAgreementControls] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[CarryoverOut] [float] NULL,
	[CarryoverIn] [float] NULL,
	[Reimbursements] [float] NULL,
	[Recoveries] [float] NULL,
 CONSTRAINT [PK_AppropriationDocuments] PRIMARY KEY CLUSTERED 
(
	[AppropriationDocumentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
