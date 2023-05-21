CREATE TABLE ResourcePlanningImplentationOffices
(
    RpioId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code   NVARCHAR(80) NULL,
    Name   NVARCHAR(80) NULL
);

