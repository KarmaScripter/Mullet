USE [Data]
GO
/****** Object:  Table [dbo].[StatusOfBudgetaryResources]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfBudgetaryResources](
	[StatusOfBudgetaryResourcesId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BeginningPeriodOfAvailability] [nvarchar](80) NULL,
	[EndingPeriodOfAvailability] [nvarchar](80) NULL,
	[SectionNumber] [nvarchar](80) NULL,
	[SectionName] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[November] [float] NULL,
	[December] [float] NULL,
	[January] [float] NULL,
	[Feburary] [float] NULL,
	[March] [float] NULL,
	[April] [float] NULL,
	[May] [float] NULL,
	[June] [float] NULL,
	[July] [float] NULL,
	[August] [float] NULL,
	[September] [float] NULL,
	[October] [float] NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [PK_StatusOfBudgetaryResources] PRIMARY KEY CLUSTERED 
(
	[StatusOfBudgetaryResourcesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
