CREATE TABLE [Earmarks]
(
   [EarmarksId] INT NOT NULL IDENTITY (492,1),
   [RpioCode] NVARCHAR(80) NULL,
   [RpioName] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [StateCode] NVARCHAR(80) NULL,
   [Description] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [ProjectOfficerLastName] NVARCHAR(80) NULL,
   [ProjectOfficerFirstName] NVARCHAR(80) NULL,
   [ProjectOfficerPhoneNumber] NVARCHAR(80) NULL,
   [ProjectOfficerMailCode] NVARCHAR(80) NULL,
   [CommitmentDate] DATETIME,
   [ObligationDate] DATETIME,
   [ProjectStatus] NVARCHAR(80) NULL,
   [ProjectOfficerComments] NVARCHAR(80)
);
