﻿CREATE TABLE [BudgetaryResourceExecution]
(
   [BudgetaryResourceExecutionId] INT NOT NULL IDENTITY (14806,1),
   [FiscalYear] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [LastUpdate] DATETIME,
   [TreasurySymbol] NVARCHAR(80) NULL,
   [OmbAccount] NVARCHAR(80) NULL,
   [TreasuryAgencyCode] NVARCHAR(80) NULL,
   [TreasuryAccountCode] NVARCHAR(80) NULL,
   [STAT] NVARCHAR(80) NULL,
   [CreditIndicator] NVARCHAR(80) NULL,
   [LineNumber] NVARCHAR(80) NULL,
   [LineDescription] NVARCHAR(80) NULL,
   [SectionName] NVARCHAR(80) NULL,
   [SectionNumber] NVARCHAR(80) NULL,
   [LineType] NVARCHAR(80) NULL,
   [FinancingAccounts] NVARCHAR(80) NULL,
   [November] DECIMAL(18,0),
   [January] DECIMAL(18,0),
   [Feburary] DECIMAL(18,0),
   [April] DECIMAL(18,0),
   [May] DECIMAL(18,0),
   [June] DECIMAL(18,0),
   [August] DECIMAL(18,0),
   [October] DECIMAL(18,0),
   [Amount1] DECIMAL(18,0),
   [Amount2] DECIMAL(18,0),
   [Amount3] DECIMAL(18,0),
   [Amount4] DECIMAL(18,0),
   [Agency] NVARCHAR(80) NULL,
   [Bureau] NVARCHAR(80)
);