CREATE TABLE Divisions
(
    DivisionId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code       NVARCHAR(80) NOT NULL,
    Name       NVARCHAR(80) NULL,
    Caption    NVARCHAR(80) NULL,
    Title      NVARCHAR(80) NULL,
    FCO NVARCHAR(80) NULL,
    Icon       NVARCHAR(80) NULL,
    Logo       NVARCHAR(80) NULL
);

