CREATE TABLE [Resources]
(
   [ResourcesId] INT NOT NULL IDENTITY (78,1),
   [FileName] NVARCHAR(80) NULL,
   [FileType] NVARCHAR(80) NULL,
   [FilePath] NTEXT,
   [FileExtension] NVARCHAR(80)
);
