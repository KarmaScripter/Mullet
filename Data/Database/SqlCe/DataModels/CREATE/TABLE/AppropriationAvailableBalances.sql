CREATE TABLE [AppropriationAvailableBalances]
(
   [AppropriationAvailableBalancesId] INT NOT NULL IDENTITY (1299,1),
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [AppropriationFundCode] NVARCHAR(80) NULL,
   [AppropriationFundName] NVARCHAR(80) NULL,
   [TreasurySymbol] NVARCHAR(80) NULL,
   [OmbAccountCode] NVARCHAR(80) NULL,
   [Availability] NVARCHAR(80) NULL,
   [TotalAuthority] DECIMAL(18,0),
   [TotalUsed] DECIMAL(18,0),
   [Available] DECIMAL(18,0)
);
