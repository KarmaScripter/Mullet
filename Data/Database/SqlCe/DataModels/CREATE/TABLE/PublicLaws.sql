CREATE TABLE [PublicLaws]
(
   [PublicLawsId] INT NOT NULL IDENTITY (5302,1),
   [LawNumber] NVARCHAR(80) NULL,
   [BillTitle] NVARCHAR(80) NULL,
   [EnactedDate] DATETIME,
   [Congress] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80)
);
