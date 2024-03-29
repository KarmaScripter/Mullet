USE [Data]
GO
/****** Object:  Table [dbo].[SiteProjectCodes]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteProjectCodes](
	[SiteProjectCodesId] [int] NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[CongressionalDistrict] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[ActionCode] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL,
 CONSTRAINT [PK_SiteProjectCodes] PRIMARY KEY CLUSTERED 
(
	[SiteProjectCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
