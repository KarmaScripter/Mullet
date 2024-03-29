USE [Data]
GO
/****** Object:  Table [dbo].[CongressionalControls]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongressionalControls](
	[CongressionalControlsId] [int] NOT NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[SubProjectCode] [nvarchar](80) NULL,
	[SubProjectName] [nvarchar](80) NULL,
	[ReprogrammingRestriction] [nvarchar](80) NULL,
	[IncreaseRestriction] [nvarchar](80) NULL,
	[DecreaseRestriction] [nvarchar](80) NULL,
	[MemoRequirement] [nvarchar](80) NULL,
 CONSTRAINT [PK_CongressionalControls] PRIMARY KEY CLUSTERED 
(
	[CongressionalControlsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
