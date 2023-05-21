﻿CREATE TABLE [RecoveryAct]
(
   [RecoveryActId] INT NOT NULL IDENTITY (464,1),
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [RpioCode] NVARCHAR(80) NULL,
   [RpioName] NVARCHAR(80) NULL,
   [OrgCode] NVARCHAR(80) NULL,
   [OrgName] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [ProgramProjectName] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [BocName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0)
);
