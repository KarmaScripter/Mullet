CREATE TABLE PayrollCostCodes
(
    PayrollCostCodesId INT NOT NULL IDENTITY (1,1),
    RpioCode   NVARCHAR(80) NULL,
    RpioName   NVARCHAR(80) NULL,
    AhCode     NVARCHAR(80) NULL,
    BFY NVARCHAR(80) NULL,
    RcCode     NVARCHAR(80) NULL,
    WorkCode   NVARCHAR(80) NULL,
    WorkCodeName       NVARCHAR(80) NULL,
    HrOrgCode  NVARCHAR(80) NULL,
    HrOrgName  NVARCHAR(80) NULL
);