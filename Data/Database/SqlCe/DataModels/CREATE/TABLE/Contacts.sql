﻿CREATE TABLE [Contacts]
(
   [ContactsId] INT NOT NULL IDENTITY (13,1),
   [FirstName] NVARCHAR(80) NULL,
   [LastName] NVARCHAR(80) NULL,
   [FullName] NVARCHAR(80) NULL,
   [Email] NVARCHAR(80) NULL,
   [RPIO] NVARCHAR(80) NULL,
   [Section] NVARCHAR(80)
);
