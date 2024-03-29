USE [Data]
GO
/****** Object:  Table [dbo].[PublicLaws]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicLaws](
	[PublicLawsId] [int] NOT NULL,
	[LawNumber] [nvarchar](80) NULL,
	[BillTitle] [nvarchar](80) NULL,
	[EnactedDate] [datetime] NULL,
	[Congress] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
 CONSTRAINT [PK_PublicLaws] PRIMARY KEY CLUSTERED 
(
	[PublicLawsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
