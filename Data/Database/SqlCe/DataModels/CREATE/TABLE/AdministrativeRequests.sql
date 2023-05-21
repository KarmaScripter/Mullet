CREATE TABLE [AdministrativeRequests]
(
   [AdministrativeRequestsId] INT NOT NULL IDENTITY (28,1),
   [RequestId] INT,
   [ControlTeamAnalyst] NVARCHAR(80) NULL,
   [RpioCode] NVARCHAR(80) NULL,
   [DocumentTitle] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [FundCode] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [Status] NVARCHAR(80) NULL,
   [OriginalRequestDate] DATETIME,
   [LastActivityDate] DATETIME,
   [Duration] FLOAT,
   [BFS] NVARCHAR(80) NULL,
   [Comments] NTEXT,
   [RequestDocument] NTEXT,
   [RequestType] NVARCHAR(80) NULL,
   [TypeCode] NVARCHAR(80) NULL,
   [Decision] NVARCHAR(80)
);
