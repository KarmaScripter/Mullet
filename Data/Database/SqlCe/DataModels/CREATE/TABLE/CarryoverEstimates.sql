CREATE TABLE CarryoverEstimates
(
    CarryoverEstimatesId INT NOT NULL IDENTITY (1,1),
    BudgetLevel          NVARCHAR(80) NULL,
    BFY                  NVARCHAR(80) NULL,
    AhCode               NVARCHAR(80) NULL,
    FundCode             NVARCHAR(80) NULL,
    FundName             NVARCHAR(80) NULL,
    OrgCode              NVARCHAR(80) NULL,
    AccountCode          NVARCHAR(80) NULL,
    RcCode               NVARCHAR(80) NULL,
    DivisionName         NVARCHAR(80) NULL,
    BocCode              NVARCHAR(80) NULL,
    BocName              NVARCHAR(80) NULL,
    Balance              FLOAT,
    OpenCommitment       FLOAT,
    Estimate             FLOAT,
    CONSTRAINT PK_CarryoverEstimates
        PRIMARY KEY ( CarryoverEstimatesId )
);
