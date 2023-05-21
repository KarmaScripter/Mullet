CREATE TABLE [Changes]
(
   [ChangesId] INT NOT NULL IDENTITY (4194,1),
   [TableName] NVARCHAR(80) NULL,
   [FieldName] NVARCHAR(80) NULL,
   [Action] NVARCHAR(80) NULL,
   [OldValue] NVARCHAR(80) NULL,
   [NewValue] NVARCHAR(80) NULL,
   [TimeStamp] DATETIME,
   [Message] NVARCHAR(80)
);
