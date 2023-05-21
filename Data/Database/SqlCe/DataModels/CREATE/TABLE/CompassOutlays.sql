CREATE TABLE [CompassOutlays]
(
   [CompassOutlaysId] INT NOT NULL IDENTITY (3204,1),
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [AppropriationCode] NVARCHAR(80) NULL,
   [AppropriationName] NVARCHAR(80) NULL,
   [TreasurySymbol] NVARCHAR(80) NULL,
   [ProgramAreaCode] NVARCHAR(80) NULL,
   [ProgramAreaName] NVARCHAR(80) NULL,
   [ProgramProjectCode] NVARCHAR(80) NULL,
   [ProgramProjectName] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [BocName] NVARCHAR(80) NULL,
   [TotalObligations] DECIMAL(18,0),
   [UnliquidatedObligations] DECIMAL(18,0),
   [ObligationsPaid] DECIMAL(18,0)
);
