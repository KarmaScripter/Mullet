USE [Data]
GO
/****** Object:  Table [dbo].[ProgramProjectDescriptions]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramProjectDescriptions](
	[ProgramProjectDescriptionsId] [int] NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[ProgramTitle] [nvarchar](80) NULL,
	[Laws] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramProjectDescriptions] PRIMARY KEY CLUSTERED 
(
	[ProgramProjectDescriptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
