﻿CREATE TABLE [FullTimeEquivalents]
(
   [FullTimeEquivialentsId] INT NOT NULL IDENTITY (14572,1),
   [OperatingPlansId] INT,
   [RpioCode] NVARCHAR(80) NULL,
   [RpioName] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [AhCode] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [OrgCode] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [RcCode] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [BocName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [ITProjectCode] NVARCHAR(80) NULL,
   [ProjectCode] NVARCHAR(80) NULL,
   [ProjectName] NVARCHAR(80) NULL,
   [NpmCode] NVARCHAR(80) NULL,
   [ProjectTypeName] NVARCHAR(80) NULL,
   [ProjectTypeCode] NVARCHAR(80) NULL,
   [ProgramProjectCode] NVARCHAR(80) NULL,
   [ProgramAreaCode] NVARCHAR(80) NULL,
   [NpmName] NVARCHAR(80) NULL,
   [AhName] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [OrgName] NVARCHAR(80) NULL,
   [RcName] NVARCHAR(80) NULL,
   [ProgramProjectName] NVARCHAR(80) NULL,
   [ActivityCode] NVARCHAR(80) NULL,
   [ActivityName] NVARCHAR(80) NULL,
   [LocalCode] NVARCHAR(80) NULL,
   [LocalCodeName] NVARCHAR(80) NULL,
   [ProgramAreaName] NVARCHAR(80) NULL,
   [CostAreaCode] NVARCHAR(80) NULL,
   [CostAreaName] NVARCHAR(80) NULL,
   [alCode] NVARCHAR(80) NULL,
   [alName] NVARCHAR(80) NULL,
   [ObjectiveCode] NVARCHAR(80) NULL,
   [ObjectiveName] NVARCHAR(80)
);
