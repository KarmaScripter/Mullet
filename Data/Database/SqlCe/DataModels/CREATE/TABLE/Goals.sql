CREATE TABLE Goals
(
    GoalsId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code    NVARCHAR(80) NULL,
    Name    NVARCHAR(80) NULL,
    Title   NVARCHAR(80) NULL
);

