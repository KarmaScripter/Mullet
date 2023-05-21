CREATE TABLE [Accounts]
(
   [AccountsId] INT NOT NULL IDENTITY (64047,1),
   [Code] NVARCHAR(80) NULL,
   [alCode] NVARCHAR(80) NULL,
   [ObjectiveCode] NVARCHAR(80) NULL,
   [NpmCode] NVARCHAR(80) NULL,
   [NpmName] NVARCHAR(80) NULL,
   [ProgramProjectCode] NVARCHAR(80) NULL,
   [ProgramProjectName] NVARCHAR(80) NULL,
   [ProgramAreaCode] NVARCHAR(80) NULL,
   [ProgramAreaName] NVARCHAR(80) NULL,
   [ActivityCode] NVARCHAR(80) NULL,
   [ActivityName] NVARCHAR(80) NULL,
   [AgencyActivity] NVARCHAR(80)
);
