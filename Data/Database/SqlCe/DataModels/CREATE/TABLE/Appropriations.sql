CREATE TABLE [Appropriations]
(
   [AppropriationsId] INT NOT NULL IDENTITY (11,1),
   [BFY] NVARCHAR(80) NOT NULL,
   [Title] NVARCHAR(80) NULL,
   [PublicLaw] NVARCHAR(80) NULL,
   [EnactedDate] DATETIME
);
