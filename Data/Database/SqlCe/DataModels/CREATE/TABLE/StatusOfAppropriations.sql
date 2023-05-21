﻿CREATE TABLE [StatusOfAppropriations]
(
   [StatusOfAppropriationsId] INT NOT NULL IDENTITY (51123,1),
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [BudgetLevel] NVARCHAR(80) NULL,
   [AppropriationFundCode] NVARCHAR(80) NULL,
   [AppropriationFundName] NVARCHAR(80) NULL,
   [Availability] NVARCHAR(80) NULL,
   [TreasurySymbol] NVARCHAR(80) NULL,
   [OmbAccountCode] NVARCHAR(80) NULL,
   [AppropriationCreationDate] DATETIME,
   [AppropriationCode] NVARCHAR(80) NULL,
   [SubAppropriationCode] NVARCHAR(80) NULL,
   [AppropriationDescription] NVARCHAR(80) NULL,
   [FundGroup] NVARCHAR(80) NULL,
   [FundGroupName] NVARCHAR(80) NULL,
   [DocumentType] NVARCHAR(80) NULL,
   [TransType] NVARCHAR(80) NULL,
   [ActualRecoveryTransType] NVARCHAR(80) NULL,
   [CommitmentSpendingControlFlag] NVARCHAR(80) NULL,
   [AgreementLimit] NVARCHAR(80) NULL,
   [EstimatedRecoveriesTransType] NVARCHAR(80) NULL,
   [EstimatedReimbursmentsTransType] NVARCHAR(80) NULL,
   [ExpenseSpendingControlFlag] NVARCHAR(80) NULL,
   [ObligationSpendingControlFlag] NVARCHAR(80) NULL,
   [PreCommitmentSpendingControlFlag] NVARCHAR(80) NULL,
   [PostedControlFlag] NVARCHAR(80) NULL,
   [PostedFlag] NVARCHAR(80) NULL,
   [RecordCarryoverAtLowerLevel] NVARCHAR(80) NULL,
   [ReimbursableSpendinption] NVARCHAR(80) NULL,
   [RecoveriesOption] NVARCHAR(80) NULL,
   [RecoveriesSpendinption] NVARCHAR(80) NULL,
   [OriginalBudgetedAmount] DECIMAL(18,0),
   [ApportionmentsPosted] DECIMAL(18,0),
   [TotalAuthority] DECIMAL(18,0),
   [TotalBudgeted] DECIMAL(18,0),
   [TotalPostedAmount] DECIMAL(18,0),
   [FundsWithdrawnPriorYearsAmount] DECIMAL(18,0),
   [FundingInAmount] DECIMAL(18,0),
   [FundinutAmount] DECIMAL(18,0),
   [TotalAccrualRecoveries] DECIMAL(18,0),
   [TotalActualReimbursements] DECIMAL(18,0),
   [TotalAgreementReimbursables] DECIMAL(18,0),
   [TotalCarriedForwardIn] DECIMAL(18,0),
   [TotalCarriedForwardOut] DECIMAL(18,0),
   [TotalCommitted] DECIMAL(18,0),
   [TotalEstimatedRecoveries] DECIMAL(18,0),
   [TotalEstimatedReimbursements] DECIMAL(18,0),
   [TotalExpenses] DECIMAL(18,0),
   [TotalExpenditureExpenses] DECIMAL(18,0),
   [TotalExpenseAccruals] DECIMAL(18,0),
   [TotalPreCommitments] DECIMAL(18,0),
   [UnliquidatedPreCommitments] DECIMAL(18,0),
   [TotalObligations] DECIMAL(18,0),
   [ULO] DECIMAL(18,0),
   [VoidedAmount] DECIMAL(18,0),
   [TotalUsedAmount] DECIMAL(18,0),
   [AvailableAmount] DECIMAL(18,0)
);