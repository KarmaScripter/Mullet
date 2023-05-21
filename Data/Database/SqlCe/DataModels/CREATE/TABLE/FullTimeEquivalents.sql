CREATE TABLE FullTimeEquivalents
(
    FullTimeEquivalentsId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    AllocationsId         INTEGER NOT NULL UNIQUE,
    BudgetLevel   NVARCHAR(80) NULL,
    RPIO   NVARCHAR(80) NULL,
    BFY    NVARCHAR(80) NULL,
    FundCode      NVARCHAR(80) NULL,
    AhCode NVARCHAR(80) NULL,
    OrgCode       NVARCHAR(80) NULL,
    RcCode NVARCHAR(80) NULL,
    AccountCode   NVARCHAR(80) NULL,
    BocCode       NVARCHAR(80) NULL,
    Amount                FLOAT NULL,
    FundName      NVARCHAR(80) NULL,
    BocName       NVARCHAR(80) NULL,
    Division      NVARCHAR(80) NULL,
    DivisionName  NVARCHAR(80) NULL,
    ActivityCode  NVARCHAR(80) NULL,
    NpmCode       NVARCHAR(80) NULL,
    NpmName       NVARCHAR(80) NULL,
    ProgramProjectCode    NVARCHAR(80) NULL,
    ProgramProjectName    NVARCHAR(80) NULL,
    ProgramAreaCode       NVARCHAR(80) NULL,
    ProgramAreaName       NVARCHAR(80) NULL,
    GoalCode      NVARCHAR(80) NULL,
    GoalName      NVARCHAR(80) NULL,
    ObjectiveCode NVARCHAR(80) NULL,
    ObjectiveName NVARCHAR(80) NULL,
    AllocationRatio       FLOAT NULL,
    ChangeDate            DATETIME NULL,
    CONSTRAINT PK_FullTimeEquivalents
        PRIMARY KEY ( FullTimeEquivalentsId ),
    CONSTRAINT FK_FullTimeEquivalents
        FOREIGN KEY ( AllocationsId )
            REFERENCES Allocations
);
