CREATE TABLE EmployeePayroll
(
    EmployeePayrollId INT NOT NULL IDENTITY (1,1),
    RcCode    NVARCHAR(80) NULL,
    DivisionName      NVARCHAR(80) NULL,
    EpaNumber NVARCHAR(80) NULL,
    LastName  NVARCHAR(80) NULL,
    FirstName NVARCHAR(80) NULL,
    ReportingCode     NVARCHAR(80) NULL,
    ReportingCodeName NVARCHAR(80) NULL,
    Hours             FLOAT NULL,
    Days              FLOAT NULL
);
