﻿CREATE TABLE [SpendingRates]
(
   [SpendingRatesId] INT NOT NULL IDENTITY (107,1),
   [OmbAgencyCode] NVARCHAR(80) NULL,
   [OmbAgencyName] NVARCHAR(80) NULL,
   [OmbBureauCode] NVARCHAR(80) NULL,
   [OmbBureauName] NVARCHAR(80) NULL,
   [TreausuryAgencyCode] NVARCHAR(80) NULL,
   [TreausuryAccountCode] NVARCHAR(80) NULL,
   [TreausuryAccountName] NVARCHAR(80) NULL,
   [AccountTitle] NVARCHAR(80) NULL,
   [Subfunction] NVARCHAR(80) NULL,
   [Line] NVARCHAR(80) NULL,
   [LineNumber] NVARCHAR(80) NULL,
   [Catery] NVARCHAR(80) NULL,
   [Subcatery] NVARCHAR(80) NULL,
   [SubcateryName] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [Jurisdiction] NVARCHAR(80) NULL,
   [YearOfAuthority] NVARCHAR(80) NULL,
   [BudgetAuthority] DECIMAL(18,0),
   [OutYear1] DECIMAL(18,0),
   [OutYear2] DECIMAL(18,0),
   [OutYear3] DECIMAL(18,0),
   [OutYear4] DECIMAL(18,0),
   [OutYear5] DECIMAL(18,0),
   [OutYear6] DECIMAL(18,0),
   [OutYear7] DECIMAL(18,0),
   [OutYear8] DECIMAL(18,0),
   [OutYear9] DECIMAL(18,0),
   [OutYear10] DECIMAL(18,0),
   [OutYear11] DECIMAL(18,0),
   [TotalSpendout] DECIMAL(18,0)
);