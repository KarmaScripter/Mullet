CREATE TABLE [FederalHolidays]
(
   [FederalHolidaysId] INT NOT NULL IDENTITY (15,1),
   [BFY] NVARCHAR(80) NULL,
   [ColumbusDay] DATETIME,
   [VeteransDay] DATETIME,
   [ThanksgivingDay] DATETIME,
   [ChristmasDay] DATETIME,
   [NewYears] DATETIME,
   [MartinLutherKingsDay] DATETIME,
   [Washingtonsday] DATETIME,
   [MemorialDay] DATETIME,
   [JuneteenthDay] DATETIME,
   [IndependenceDay] DATETIME,
   [LaborDay] DATETIME
);
