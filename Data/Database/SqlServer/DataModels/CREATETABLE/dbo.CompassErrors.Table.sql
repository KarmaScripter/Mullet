USE [Data]
GO
/****** Object:  Table [dbo].[CompassErrors]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompassErrors](
	[CompassErrorsId] [int] NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Message] [nvarchar](80) NULL,
	[Severity] [nvarchar](80) NULL,
 CONSTRAINT [PK_CompassErrors] PRIMARY KEY CLUSTERED 
(
	[CompassErrorsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
