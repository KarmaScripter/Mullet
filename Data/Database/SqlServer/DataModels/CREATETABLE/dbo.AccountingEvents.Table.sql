USE [Data]
GO
/****** Object:  Table [dbo].[AccountingEvents]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingEvents](
	[AccountingEventsId] [int] NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL
) ON [PRIMARY]
GO
