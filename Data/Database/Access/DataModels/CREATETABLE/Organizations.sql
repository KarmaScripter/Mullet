CREATE TABLE Organizations 
(
    OrganizationsId AUTOINCREMENT NOT NULL UNIQUE,
    Code TEXT(80) NULL DEFAULT NS,
    Name TEXT(80) NULL DEFAULT NS,
    CONSTRAINT PrimaryKeyOrganizations PRIMARY KEY(OrganizationsId)
);