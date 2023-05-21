﻿CREATE TABLE [SuperfundSites]
(
   [SuperfundSitesId] INT NOT NULL IDENTITY (1,1),
   [RpioCode] NVARCHAR(80) NULL,
   [RpioName] NVARCHAR(80) NULL,
   [City] NVARCHAR(80) NULL,
   [State] NVARCHAR(80) NULL,
   [SSID] NVARCHAR(80) NULL,
   [SiteProjectName] NVARCHAR(80) NULL,
   [EpaSiteId] NVARCHAR(80) NULL
);
