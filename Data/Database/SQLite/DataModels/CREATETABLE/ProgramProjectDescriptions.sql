CREATE TABLE IF NOT EXISTS ProgramProjectDescriptions 
(
    ProgramProjectDescriptionsId	INTEGER NOT NULL UNIQUE,
    Code	TEXT(80) NULL DEFAULT NS,
    Name	TEXT(80) NULL DEFAULT NS,
    ProgramTitle	TEXT(80) NULL DEFAULT NS,
    Laws	TEXT(MAX) DEFAULT NS,
    Description	TEXT(MAX) DEFAULT NS,
    ProgramAreaCode	TEXT(80) NULL DEFAULT NS,
    ProgramAreaName	TEXT(80) NULL DEFAULT NS,
    PRIMARY KEY(ProgramProjectDescriptionsId AUTOINCREMENT)
);