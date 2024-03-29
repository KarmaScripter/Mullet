USE [Data]
GO
/****** Object:  Table [dbo].[FederalHolidays]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FederalHolidays](
	[FederalHolidaysId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[Columbus] [datetime] NULL,
	[Veterans] [datetime] NULL,
	[Thanksgiving] [datetime] NULL,
	[Christmas] [datetime] NULL,
	[NewYears] [datetime] NULL,
	[MartinLutherKing] [datetime] NULL,
	[Washingtons] [datetime] NULL,
	[Memorial] [datetime] NULL,
	[Juneteenth] [datetime] NULL,
	[Independence] [datetime] NULL,
	[Labor] [datetime] NULL,
 CONSTRAINT [PK_FederalHolidays] PRIMARY KEY CLUSTERED 
(
	[FederalHolidaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
