CREATE TABLE [ReimbursableFunds]
(
   [ReimbursableFundsId] INT NOT NULL IDENTITY (1,1),
   [RpioCode] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [RcCode] NVARCHAR(80) NULL,
   [RcName] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [DocumentControlNumber] NVARCHAR(80) NULL,
   [AgreeementNumber] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [OpenCommitments] DECIMAL(18,0),
   [Obligations] DECIMAL(18,0),
   [UnliquatedObligations] DECIMAL(18,0),
   [Available] DECIMAL(18,0)
);
