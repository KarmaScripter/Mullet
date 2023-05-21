CREATE TABLE [StateGrantObligations]
(
   [StateGrantObligationsId] INT NOT NULL IDENTITY (12833,1),
   [RpioCode] NVARCHAR(80) NULL,
   [RpioName] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [AhCode] NVARCHAR(80) NULL,
   [AhName] NVARCHAR(80) NULL,
   [OrgCode] NVARCHAR(80) NULL,
   [OrgName] NVARCHAR(80) NULL,
   [StateCode] NVARCHAR(80) NULL,
   [StateName] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [ProgramProjectCode] NVARCHAR(80) NULL,
   [ProgramProjectName] NVARCHAR(80) NULL,
   [RcCode] NVARCHAR(80) NULL,
   [RcName] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [BocName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0)
);
