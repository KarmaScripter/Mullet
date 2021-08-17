USE [DataModels]
GO

/****** Object:  Table [dbo].[OperatingPlanUpdates]    Script Date: 8/2/2021 7:40:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OperatingPlanUpdates](
	[OppUpdateId] [int] NOT NULL,
	[OppId] [float] NULL,
	[RPIO] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[BudgetLevel] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[RcCode] [nvarchar](255) NULL,
	[Amount] [float] NULL,
	[NpmCode] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramAreaCode] [nvarchar](255) NULL,
	[NpmName] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[ActivityCode] [nvarchar](255) NULL,
	[ActivityName] [nvarchar](255) NULL,
	[DivisionName] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[ProgramAreaName] [nvarchar](255) NULL,
	[GoalCode] [nvarchar](255) NULL,
	[GoalName] [nvarchar](255) NULL,
	[ObjectiveCode] [nvarchar](255) NULL,
	[ObjectiveName] [nvarchar](255) NULL
) ON [PRIMARY]
GO


