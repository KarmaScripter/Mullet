CREATE TABLE [CarryoverRequests]
(
   [CarryoverRequestsId] INT NOT NULL IDENTITY (13,1),
   [ControlTeamAnalyst] NVARCHAR(80) NULL,
   [RpioCode] NVARCHAR(80) NULL,
   [DocumentTitle] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [FundCode] NVARCHAR(80) NULL,
   [Status] NVARCHAR(80) NULL,
   [OriginalRequestDate] DATETIME,
   [LastActivityDate] DATETIME,
   [BFS] NVARCHAR(80) NULL,
   [Comments] NTEXT,
   [RequestDocument] NTEXT,
   [Duration] INT
);
