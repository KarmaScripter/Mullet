CREATE TABLE CompassLevels 
(
	CompassLevelsId AUTOINCREMENT NOT NULL UNIQUE,
	BFY	TEXT(80) NULL DEFAULT NS,
	EFY	TEXT(80) NULL DEFAULT NS,
	FundCode	TEXT(80) NULL DEFAULT NS,
	FundName	TEXT(80) NULL DEFAULT NS,
	TreasurySymbol	TEXT(80) NULL DEFAULT NS,
	BudgetLevel	TEXT(80) NULL DEFAULT NS,
	RpioCode	TEXT(80) NULL DEFAULT NS,
	RpioName	TEXT(80) NULL DEFAULT NS,
	AccountCode	TEXT(80) NULL DEFAULT NS,
	ProgramProjectName	TEXT(80) NULL DEFAULT NS,
	ProgramAreaCode	TEXT(80) NULL DEFAULT NS,
	ProgramAreaName	TEXT(80) NULL DEFAULT NS,
	Authority	DOUBLE DEFAULT 0.0,
	CarryoverIn	DOUBLE DEFAULT 0.0,
	CarryoverOut	DOUBLE DEFAULT 0.0,
	Recoveries	DOUBLE DEFAULT 0.0,
	Reimbursements	DOUBLE DEFAULT 0.0,
	TreasuryAccountCode	TEXT(80) NULL DEFAULT NS,
	TreasuryAccountName	TEXT(80) NULL DEFAULT NS,
	BudgetAccountCode	TEXT(80) NULL DEFAULT NS,
	BudgetAccountName	TEXT(80) NULL DEFAULT NS,
	PRIMARY KEY(CompassLevelsId)
);