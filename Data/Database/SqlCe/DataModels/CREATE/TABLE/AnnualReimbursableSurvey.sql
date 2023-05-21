CREATE TABLE [AnnualReimbursableSurvey]
(
   [AnnualReimbursableSurveyId] INT NOT NULL IDENTITY (2,1),
   [BFY] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0)
);
