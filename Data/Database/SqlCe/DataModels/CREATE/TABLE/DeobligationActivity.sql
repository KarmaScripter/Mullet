CREATE TABLE [DeobligationActivity]
(
	[DeobligationActivityId] INT NOT NULL IDENTITY(1,1),
	[BFY] NVARCHAR(80) NULL,
	[EFY] NVARCHAR(80) NULL,
	[TreasuryAccountCode] NVARCHAR(80) NULL,
	[BudgetAccountCode] NVARCHAR(80) NULL,
	[FundCode] NVARCHAR(80) NULL,
	[FundName] NVARCHAR(80) NULL,
	[RpioCode] NVARCHAR(80) NULL,
	[RpioName] NVARCHAR(80) NULL,
	[AhCode] NVARCHAR(80) NULL,
	[AhName] NVARCHAR(80) NULL,
	[OrgCode] NVARCHAR(80) NULL,
	[OrgName] NVARCHAR(80) NULL,
	[AccountCode] NVARCHAR(80) NULL,
	[ProgramProjectName] NVARCHAR(80) NULL,
	[BocCode] NVARCHAR(25) NULL,
	[BocName] NVARCHAR(80) NULL,
	[DocumentNumber] NVARCHAR(80) NULL,
	[ProcessedDate] [datetime] NULL,
	[Amount] FLOAT NULL
);

