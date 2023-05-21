CREATE TABLE [Providers]
(
	[ProvidersId] INT NOT NULL IDENTITY(1,1),
	[ProviderName] NVARCHAR(80) NULL,
	[FileExtension] NVARCHAR(80) NULL,
	[Connection] NVARCHAR(80) NULL,
	[Properties] NVARCHAR(80) NULL
);

