CREATE TABLE [AnnualCarryoverSurvey]
(
   [AnnualCarryoverSurveyId] INT NOT NULL IDENTITY (300,1),
   [BFY] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [TreasuryAccountCode] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0)
);
