CREATE TABLE [UnobligatedAuthority]
(
   [UnobligatedAuthorityId] INT NOT NULL IDENTITY (49,1),
   [ReportYear] NVARCHAR(80) NULL,
   [AgencyCode] NVARCHAR(80) NULL,
   [BureauCode] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [OmbAccount] NVARCHAR(80) NULL,
   [OmbAccountName] NVARCHAR(80) NULL,
   [LineName] NVARCHAR(80) NULL,
   [LineNumber] NVARCHAR(80) NULL,
   [BudgetYear] DECIMAL(18,0),
   [PriorYear] DECIMAL(18,0),
   [CurrentYear] DECIMAL(18,0),
   [AgencyName] NVARCHAR(80) NULL,
   [BureauName] NVARCHAR(80)
);
