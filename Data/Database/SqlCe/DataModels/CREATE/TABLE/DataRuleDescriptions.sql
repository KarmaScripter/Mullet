CREATE TABLE [DataRuleDescriptions]
(
   [DataRuleDescriptionsId] INT NOT NULL IDENTITY (1177,1),
   [Schedule] NVARCHAR(80) NULL,
   [LineNumber] NVARCHAR(80) NULL,
   [RuleNumber] NVARCHAR(80) NULL,
   [RuleDescription] NTEXT,
   [ScheduleOrder] NVARCHAR(80)
);
