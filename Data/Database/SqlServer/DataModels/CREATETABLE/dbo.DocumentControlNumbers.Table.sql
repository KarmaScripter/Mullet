USE [Data]
GO
/****** Object:  Table [dbo].[DocumentControlNumbers]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentControlNumbers](
	[DocumentControlNumbersId] [int] NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentPrefix] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
 CONSTRAINT [PK_DocumentControlNumbers] PRIMARY KEY CLUSTERED 
(
	[DocumentControlNumbersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
