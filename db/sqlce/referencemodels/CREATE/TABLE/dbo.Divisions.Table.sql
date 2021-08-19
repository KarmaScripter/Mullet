USE [ReferenceModels]
GO
/****** Object:  Table [dbo].[Divisions]    Script Date: 7/17/2021 9:04:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divisions](
	[DivisionId] [float] NOT NULL,
	[Code] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Caption] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL,
	[FCO] [nvarchar](255) NULL,
	[Icon] [nvarchar](max) NULL,
	[Logo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Divisions] PRIMARY KEY CLUSTERED 
(
	[DivisionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
