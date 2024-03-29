USE [Data]
GO
/****** Object:  Table [dbo].[WorkCodes]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkCodes](
	[WorkCodesId] [int] NULL,
	[SecurityOrg] [nvarchar](80) NULL,
	[WorkCode] [nvarchar](80) NULL,
	[WorkCodeName] [nvarchar](80) NULL,
	[WorkCodeShortName] [nvarchar](80) NULL,
	[ChargeType] [nvarchar](80) NULL,
	[PreventNewUse] [nvarchar](80) NULL,
	[ReOrgCode] [nvarchar](80) NULL,
	[Active] [nvarchar](80) NULL,
	[Pay Year] [nvarchar](80) NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[PayType] [nvarchar](80) NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[Justification] [nvarchar](80) NULL,
	[AllocationReason] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[ApprovedBy] [nvarchar](80) NULL,
	[ApprovalDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](80) NULL,
	[ModifiedDate] [datetime] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[BETC] [nvarchar](80) NULL,
	[BetcName] [nvarchar](80) NULL,
	[CostOrgCode] [nvarchar](80) NULL,
	[CostOrgName] [nvarchar](80) NULL,
	[Organization] [nvarchar](80) NULL,
	[Organization Name] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramName] [nvarchar](80) NULL,
	[ProjectCode] [nvarchar](80) NULL,
	[ProjectName] [nvarchar](80) NULL,
	[BudgetYear] [nvarchar](80) NULL,
	[AllocationPercentage] [float] NULL
) ON [PRIMARY]
GO
