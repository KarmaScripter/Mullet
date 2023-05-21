CREATE TABLE ProgramProjects
(
    ProgramProjectId  INT NOT NULL IDENTITY (1,1),
    Code NVARCHAR(80) NOT NULL,
    Name NVARCHAR(80) NULL,
    Title NVARCHAR(80) NULL,
    Laws NVARCHAR(80) NULL,
    Description NVARCHAR(80) NULL,
    ProgramAreaCode NVARCHAR(80) NULL,
    ProgramAreaName NVARCHAR(80) NULL
);

