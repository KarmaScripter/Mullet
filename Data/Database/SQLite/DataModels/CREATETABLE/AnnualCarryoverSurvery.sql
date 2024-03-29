CREATE TABLE IF NOT EXISTS AnnualCarryoverSurvey 
(
    AnnualCarryoverSurveyId INTEGER NOT NULL UNIQUE,
    BFY TEXT(80) NULL DEFAULT NS,
    FundCode TEXT(80) NULL DEFAULT NS,
    FundName TEXT(80) NULL DEFAULT NS,
    Amount DECIMAL NULL DEFAULT 0.0,
    PRIMARY KEY(AnnualCarryoverSurveyId AUTOINCREMENT)
);