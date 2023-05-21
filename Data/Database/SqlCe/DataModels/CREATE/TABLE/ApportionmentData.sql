CREATE TABLE [ApportionmentData]
(
   [ApportionmentDataId] INT NOT NULL IDENTITY (2080,1),
   [FiscalYear] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [TreasuryAppropriationFundSymbol] NVARCHAR(80) NULL,
   [TreasuryAppropriationFundSymbolName] NVARCHAR(80) NULL,
   [ApportionmentAccountCode] NVARCHAR(80) NULL,
   [ApportionmentAccountName] NVARCHAR(80) NULL,
   [AvailabilityType] NVARCHAR(80) NULL,
   [BudgetAccountCode] NVARCHAR(80) NULL,
   [BudgetAccountName] NVARCHAR(80) NULL,
   [ApprovalDate] DATETIME,
   [LineNumber] NVARCHAR(80) NULL,
   [LineName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0)
);
