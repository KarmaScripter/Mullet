USE [Data]
GO
/****** Object:  Table [dbo].[ReferenceTables]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReferenceTables](
	[ReferenceTablesId] [int] NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
 CONSTRAINT [PK_ReferenceTables] PRIMARY KEY CLUSTERED 
(
	[ReferenceTablesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
