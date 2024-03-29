USE [Data]
GO
/****** Object:  Table [dbo].[CongressionalReprogrammings]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongressionalReprogrammings](
	[CongressionalReprogrammingsId] [int] NOT NULL,
	[ReprogrammingNumber] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[Description] [nvarchar](max) NULL,
	[ExtendedDescription] [nvarchar](max) NULL,
	[FromTo] [nvarchar](80) NULL,
	[Cycle] [nvarchar](80) NULL,
 CONSTRAINT [PK_CongressionalReprogrammings] PRIMARY KEY CLUSTERED 
(
	[CongressionalReprogrammingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
