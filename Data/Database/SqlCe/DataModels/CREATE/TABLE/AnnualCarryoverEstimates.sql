CREATE TABLE [AnnualCarryoverEstimates]
(
   [AnnualCarryoverEstimatesId] INT NOT NULL IDENTITY (6758,1),
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [TreasuryAccountCode] NVARCHAR(80) NULL,
   [RpioCode] NVARCHAR(80) NULL,
   [RpioName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [OpenCommitments] DECIMAL(18,0),
   [Obligations] DECIMAL(18,0),
   [Available] DECIMAL(18,0),
   [Estimate] DECIMAL(18,0)
);
