USE [Data]
GO
/****** Object:  Table [dbo].[QueryDefinitions]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QueryDefinitions](
	[QueryDefinitionsId] [int] NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
 CONSTRAINT [PK_QueryDefinitions] PRIMARY KEY CLUSTERED 
(
	[QueryDefinitionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
