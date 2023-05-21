// <copyright file = "PrimaryKey.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public enum PrimaryKey
    {
        /// <summary> The ns </summary>
        NS = -1,

        /// <summary> The actuals identifier </summary>
        ActualsId,

        /// <summary> The administrative requests identifier </summary>
        AdministrativeRequestsId,

        /// <summary> The allocations identifier </summary>
        AllocationsId,

        /// <summary> The american rescue plan identifier </summary>
        AmericanRescuePlanId,

        /// <summary> ARP Primary Key </summary>
        AmericanRescuePlanCarryoverEstimateId,

        /// <summary> The annual carryover estimates identifier </summary>
        AnnualCarryoverEstimatesId,

        /// <summary> The annual carryover survey identifier </summary>
        AnnualCarryoverSurveyId,

        /// <summary> The annual reimbursable estimates identifier </summary>
        AnnualReimbursableEstimatesId,

        /// <summary> The annual reimbursable survey identifier </summary>
        AnnualReimbursableSurveyId,

        /// <summary> The application tables identifier </summary>
        ApplicationTablesId,

        /// <summary> The appropriation available balances identifier </summary>
        AppropriationAvailableBalancesId,

        /// <summary> The appropriation documents identifier </summary>
        AppropriationDocumentsId,

        /// <summary> The appropriation level authority identifier </summary>
        AppropriationLevelAuthorityId,

        /// <summary> The accounting events identifier </summary>
        AccountingEventsId,

        /// <summary> The accounts identifier </summary>
        AccountsId,

        /// <summary> The activity codes identifier </summary>
        ActivityCodesId,

        /// <summary> The allowance holders identifier </summary>
        AllowanceHoldersId,

        /// <summary> The apportionment data identifier </summary>
        ApportionmentDataId,

        /// <summary> The appropriations identifier </summary>
        AppropriationsId,

        /// <summary> The budget documents identifier </summary>
        BudgetDocumentsId,

        /// <summary> The budgetary resource execution identifier </summary>
        BudgetaryResourceExecutionId,

        /// <summary> The budget controls identifier </summary>
        BudgetControlsId,

        /// <summary> The budget object classes identifier </summary>
        BudgetObjectClassesId,

        /// <summary> The budget outlays identifier </summary>
        BudgetOutlaysId,

        /// <summary> The carryover apportionments identifier </summary>
        CarryoverApportionmentsId,

        /// <summary> The carryover requests identifier </summary>
        CarryoverRequestsId,

        /// <summary> The changes identifier </summary>
        ChangesId,

        /// <summary> The compass levels identifier </summary>
        CompassLevelsId,

        /// <summary> The compass outlays identifier </summary>
        CompassOutlaysId,

        /// <summary> The congressional reprogrammings identifier </summary>
        CongressionalReprogrammingsId,

        /// <summary> The contacts identifier </summary>
        ContactsId,

        /// <summary> The capital planning investment codes identifier </summary>
        CapitalPlanningInvestmentCodesId,

        /// <summary> The carryover outlays identifier </summary>
        CarryoverOutlaysId,

        /// <summary> The congressional controls identifier </summary>
        CongressionalControlsId,

        /// <summary> The cost areas identifier </summary>
        CostAreasId,

        /// <summary> The defactos identifier </summary>
        DefactosId,

        /// <summary> The deobligation activity identifier </summary>
        DeobligationActivityId,

        /// <summary> The deobligations identifier </summary>
        DeobligationsId,

        /// <summary> The document control numbers identifier </summary>
        DocumentControlNumbersId,

        /// <summary> The data rule descriptions identifier </summary>
        DataRuleDescriptionsId,

        /// <summary> The documents identifier </summary>
        DocumentsId,

        /// <summary> The earmarks identifier </summary>
        EarmarksId,

        /// <summary> The expenditures identifier </summary>
        ExpendituresId,

        /// <summary> The federal holidays identifier </summary>
        FederalHolidaysId,

        /// <summary> The finance object classes identifier </summary>
        FinanceObjectClassesId,

        /// <summary> The fiscal years identifier </summary>
        FiscalYearsId,

        /// <summary> The fiscal years back up identifier </summary>
        FiscalYearsBackUpId,

        /// <summary> The fund categories identifier </summary>
        FundCategoriesId,

        /// <summary> The funds identifier </summary>
        FundsId,

        /// <summary> The fund symbols identifier </summary>
        FundSymbolsId,

        /// <summary> The general ledger accounts identifier </summary>
        GeneralLedgerAccountsId,

        /// <summary> The goals identifier </summary>
        GoalsId,

        /// <summary> The growth rates identifier </summary>
        GrowthRatesId,

        /// <summary> The gs pay scales identifier </summary>
        GsPayScalesId,

        /// <summary> The headquarters offices identifier </summary>
        HeadquartersOfficesId,

        /// <summary> The headquarters authority identifier </summary>
        HeadquartersAuthorityId,

        /// <summary> The human resource organizations identifier </summary>
        HumanResourceOrganizationsId,

        /// <summary> The images identifier </summary>
        ImagesId,

        /// <summary> The IRA Carryover Estimates Table Id </summary>
        InflationReductionActCarryoverEstimatesId,

        /// <summary> The infrastructure accounts identifier </summary>
        InfrastructureAccountsId,

        /// <summary> The jobs act carryover estimates identifier </summary>
        JobsActCarryoverEstimatesId,

        /// <summary> The monthly ledger account balances identifier </summary>
        MonthlyLedgerAccountBalancesId,

        /// <summary> The messages identifier </summary>
        MessagesId,

        /// <summary> The messages actuals Id </summary>
        MonthlyActualsId,

        /// <summary> The monthly outlays identifier </summary>
        MonthlyOutlaysId,

        /// <summary> The net authority identifier </summary>
        NetAuthorityId,

        /// <summary> The national programs identifier </summary>
        NationalProgramsId,

        /// <summary> The obligation activity identifier </summary>
        ObligationActivityId,

        /// <summary> The obligations identifier </summary>
        ObligationsId,

        /// <summary> The open commitments identifier </summary>
        OpenCommitmentsId,

        /// <summary> The object class outlays identifier </summary>
        ObjectClassOutlaysId,

        /// <summary> The objectives identifier </summary>
        ObjectivesId,

        /// <summary> The operating plans identifier </summary>
        OperatingPlansId,

        /// <summary> The operating plan updates identifier </summary>
        OperatingPlanUpdatesId,

        /// <summary> The organizations identifier </summary>
        OrganizationsId,

        /// <summary> The pay periods identifier </summary>
        PayPeriodsId,

        /// <summary> The payroll activity identifier </summary>
        PayrollActivityId,

        /// <summary> The payroll authority identifier </summary>
        PayrollAuthorityId,

        /// <summary> The payroll cost codes identifier </summary>
        PayrollCostCodesId,

        /// <summary> The payroll requests identifier </summary>
        PayrollRequestsId,

        /// <summary> The PRC identifier </summary>
        PRCId,

        /// <summary> The project cost codes identifier </summary>
        ProjectCostCodesId,

        /// <summary> The program areas identifier </summary>
        ProgramAreasId,

        /// <summary> The program financing schedule identifier </summary>
        ProgramFinancingScheduleId,

        /// <summary> The program project descriptions identifier </summary>
        ProgramProjectDescriptionsId,

        /// <summary> The program projects identifier </summary>
        ProgramProjectsId,

        /// <summary> The projects identifier </summary>
        ProjectsId,

        /// <summary> The providers identifier </summary>
        ProvidersId,

        /// <summary> The public laws identifier </summary>
        PublicLawsId,

        /// <summary> The query definitions identifier </summary>
        QueryDefinitionsId,

        /// <summary> The regional authority identifier </summary>
        RegionalAuthorityId,

        /// <summary> The reimbursable agreements identifier </summary>
        ReimbursableAgreementsId,

        /// <summary> The reimbursable funds identifier </summary>
        ReimbursableFundsId,

        /// <summary> The reports identifier </summary>
        ReportsId,

        /// <summary> The reprogrammings identifier </summary>
        ReprogrammingsId,

        /// <summary> The recovery act identifier </summary>
        RecoveryActId,

        /// <summary> The reference tables identifier </summary>
        ReferenceTablesId,

        /// <summary> The regional offices identifier </summary>
        RegionalOfficesId,

        /// <summary> The resource planning offices identifier </summary>
        ResourcePlanningOfficesId,

        /// <summary> The resources identifier </summary>
        ResourcesId,

        /// <summary> The responsibility centers identifier </summary>
        ResponsibilityCentersId,

        /// <summary> The site activity identifier </summary>
        SiteActivityId,

        /// <summary> The site project codes identifier </summary>
        SiteProjectCodesId,

        /// <summary> The special accounts identifier </summary>
        SpecialAccountsId,

        /// <summary> The spending documents primary key </summary>
        SpendingDocumentsId,

        /// <summary> The state grant obligations identifier </summary>
        StateGrantObligationsId,

        /// <summary> The status of appropriations identifier </summary>
        StatusOfAppropriationsId,

        /// <summary> The status of budgetary resources identifier </summary>
        StatusOfBudgetaryResourcesId,

        /// <summary> The status of earmarks identifier </summary>
        StatusOfEarmarksId,

        /// <summary> The status of funds identifier </summary>
        StatusOfFundsId,

        /// <summary> The status of jobs act funding identifier </summary>
        StatusOfJobsActFundingId,

        /// <summary> The status of supplemental funding identifier </summary>
        StatusOfSupplementalFundingId,

        /// <summary> The superfund sites identifier </summary>
        SuperfundSitesId,

        /// <summary> The supplemental carryover estimates identifier </summary>
        SupplementalCarryoverEstimatesId,

        /// <summary> The supplemental reimburseable estimates identifier </summary>
        SupplementalReimburseableEstimatesId,

        /// <summary> The schema types identifier </summary>
        SchemaTypesId,

        /// <summary> The spending rates identifier </summary>
        SpendingRatesId,

        /// <summary> The state organizations identifier </summary>
        StateOrganizationsId,

        /// <summary> The sub appropriations identifier </summary>
        SubAppropriationsId,

        /// <summary> The transfer activity identifier </summary>
        TransferActivityId,

        /// <summary> The transfers identifier </summary>
        TransfersId,

        /// <summary> The trans types identifier </summary>
        TransTypesId,

        /// <summary> The unobligated authority identifier </summary>
        UnobligatedAuthorityId,

        /// <summary> The URL identifier </summary>
        URLId,

        /// <summary> The unliquidated obligations identifier </summary>
        UnliquidatedObligationsId,

        /// <summary> The unobligated balances identifier </summary>
        UnobligatedBalancesId,

        /// <summary> The work codes identifier </summary>
        WorkCodesId
    }
}