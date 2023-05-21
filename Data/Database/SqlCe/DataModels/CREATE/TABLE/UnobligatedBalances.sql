CREATE TABLE [UnobligatedBalances]
(
   [UnobligatedBalancesId] INT NOT NULL IDENTITY (35334,1),
   [BudgetYear] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [TreasurySymbol] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [OmbAccountCode] NVARCHAR(80) NULL,
   [AccountNumber] NVARCHAR(80) NULL,
   [AccountName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0)
);
