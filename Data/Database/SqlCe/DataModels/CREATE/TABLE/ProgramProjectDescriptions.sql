CREATE TABLE [ProgramProjectDescriptions]
(
   [ProgramProjectDescriptionsId] INT NOT NULL IDENTITY (1,1),
   [Code] NVARCHAR(80) NULL,
   [Name] NVARCHAR(80) NULL,
   [ProgramTitle] NVARCHAR(80) NULL,
   [Laws] NTEXT NULL,
   [Description] NTEXT NULL,
   [ProgramAreaCode] NVARCHAR(80) NULL,
   [ProgramAreaName] NVARCHAR(80)
);
