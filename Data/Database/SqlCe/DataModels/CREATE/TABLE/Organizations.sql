CREATE TABLE Organizations
(
    OrganizationsId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code NVARCHAR(80) NOT NULL,
    Name NVARCHAR(80) NULL
);
