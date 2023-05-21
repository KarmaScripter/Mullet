CREATE TABLE [AppropriationLevelAuthority]
(
   [AppropriationLevelAuthorityId] INT NOT NULL IDENTITY (939,1),
   [BudgetAccountCode] NVARCHAR(80) NULL,
   [BudgetAccountName] NVARCHAR(80) NULL,
   [FiscalYear] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [Budgeted] DECIMAL(18,0),
   [Posted] DECIMAL(18,0),
   [CarryOut] DECIMAL(18,0),
   [CarryIn] DECIMAL(18,0),
   [EstimatedReimbursements] DECIMAL(18,0),
   [EstimatedRecoveries] DECIMAL(18,0)
);
