CREATE TABLE [ReimbursableAgreements]
(
   [ReimbursableAgreementsId] INT NOT NULL IDENTITY (1,1),
   [RPIO] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [AgreementNumber] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [StartDate] DATETIME,
   [EndDate] DATETIME,
   [RcCode] NVARCHAR(80) NULL,
   [RcName] NVARCHAR(80) NULL,
   [OrgCode] NVARCHAR(80) NULL,
   [SiteProjectCode] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [VendorCode] NVARCHAR(80) NULL,
   [VendorName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [OpenCommitments] DECIMAL(18,0),
   [Obligations] DECIMAL(18,0),
   [UnliquidatedObligations] DECIMAL(18,0),
   [Available] DECIMAL(18,0)
);
