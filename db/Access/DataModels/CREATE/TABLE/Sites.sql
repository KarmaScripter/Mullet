﻿CREATE TABLE [Sites]
(
   [SiteId] INT NOT NULL IDENTITY (1,1),
   [RpioCode] NVARCHAR(255) DEFAULT ('NS'),
   [BFY] NVARCHAR(255) DEFAULT ('NS'),
   [FundCode] NVARCHAR(255) DEFAULT ('NS'),
   [AhCode] NVARCHAR(255) DEFAULT ('NS'),
   [AccountCode] NVARCHAR(255) DEFAULT ('NS'),
   [OrgCode] NVARCHAR(255) DEFAULT ('NS'),
   [OrgName] NVARCHAR(255) DEFAULT ('NS'),
   [RcCode] NVARCHAR(255) DEFAULT ('NS'),
   [ActivityCode] NVARCHAR(255) DEFAULT ('NS'),
   [ProgramProjectCode] NVARCHAR(255) DEFAULT ('NS'),
   [BocCode] NVARCHAR(255) DEFAULT ('NS'),
   [FocCode] NVARCHAR(255) DEFAULT ('NS'),
   [DCN] NVARCHAR(255) DEFAULT ('NS'),
   [EpaSiteId] NVARCHAR(255) DEFAULT ('NS'),
   [SiteName] NVARCHAR(255) DEFAULT ('NS'),
   [SiteProjectCode] NVARCHAR(50) DEFAULT ('NS'),
   [SiteProjectName] NVARCHAR(50) DEFAULT ('NS'),
   [City] NVARCHAR(255) DEFAULT ('NS'),
   [District] NVARCHAR(255) DEFAULT ('NS'),
   [County] NVARCHAR(255) DEFAULT ('NS'),
   [StateCode] NVARCHAR(255) DEFAULT ('NS'),
   [StateName] NVARCHAR(255) DEFAULT ('NS'),
   [StreetAddressLine1] NVARCHAR(255) DEFAULT ('NS'),
   [StreetAddressLine2] NVARCHAR(255) DEFAULT ('NS'),
   [ZipCode] NVARCHAR(255) DEFAULT ('NS'),
   [OriginalActionDate] NVARCHAR(255) DEFAULT ('NS'),
   [LastActionDate] NVARCHAR(255) DEFAULT ('NS'),
   [Commitments] FLOAT DEFAULT ('0.0'),
   [OpenCommitments] FLOAT DEFAULT ('0.0'),
   [Obligations] FLOAT DEFAULT ('0.0'),
   [ULO] FLOAT DEFAULT ('0.0'),
   [Deobligations] FLOAT DEFAULT ('0.0'),
   [Expenditures] FLOAT DEFAULT ('0.0')
);