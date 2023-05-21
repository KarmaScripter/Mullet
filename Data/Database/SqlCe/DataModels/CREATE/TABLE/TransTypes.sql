CREATE TABLE [TransTypes]
(
   [TransTypesId] INT NOT NULL IDENTITY (97,1),
   [FundCode] NVARCHAR(80) NULL,
   [Appropriation] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [TreasurySymbol] NVARCHAR(80) NULL,
   [DocType] NVARCHAR(80) NULL,
   [AppropriationBill] NVARCHAR(80) NULL,
   [ContinuingResolution] NVARCHAR(80) NULL,
   [RescissionCurrentYear] NVARCHAR(80) NULL,
   [RescissionPriorYear] NVARCHAR(80) NULL,
   [SequesterReduction] NVARCHAR(80) NULL,
   [SequesterReturn] NVARCHAR(80)
);
