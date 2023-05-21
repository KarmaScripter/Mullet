﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    interface IStatusOfFunds
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        string BudgetLevel { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        double Amount { get; set; }

        /// <summary> Gets or sets the budgeted. </summary>
        /// <value> The budgeted. </value>
        double Budgeted { get; set; }

        /// <summary> Gets or sets the posted. </summary>
        /// <value> The posted. </value>
        double Posted { get; set; }

        /// <summary> Gets or sets the open commitments. </summary>
        /// <value> The open commitments. </value>
        double OpenCommitments { get; set; }

        /// <summary> Gets or sets the ulo. </summary>
        /// <value> The ulo. </value>
        double ULO { get; set; }

        /// <summary> Gets or sets the expenditures. </summary>
        /// <value> The expenditures. </value>
        double Expenditures { get; set; }

        /// <summary> Gets or sets the obligations. </summary>
        /// <value> The obligations. </value>
        double Obligations { get; set; }

        /// <summary> Gets or sets the used. </summary>
        /// <value> The used. </value>
        double Used { get; set; }

        /// <summary> Gets or sets the available. </summary>
        /// <value> The available. </value>
        double Available { get; set; }

        /// <summary> Gets or sets the NPM code. </summary>
        /// <value> The NPM code. </value>
        string NpmCode { get; set; }

        /// <summary> Gets or sets the name of the NPM. </summary>
        /// <value> The name of the NPM. </value>
        string NpmName { get; set; }

        /// <summary> Gets or sets the treasury account code. </summary>
        /// <value> The treasury account code. </value>
        string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the treasury agency code. </summary>
        /// <value> The treasury agency code. </value>
        string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        Source Source { get; set; }

        /// <summary> Gets or sets the record. </summary>
        /// <value> The record. </value>
        DataRow Record { get; set; }

        /// <summary> Gets or sets the data. </summary>
        /// <value> The data. </value>
        IDictionary<string, object> Data { get; set; }

        /// <summary> Gets or sets the Provider. </summary>
        /// <value> The name of the Provider. </value>
        Provider Provider { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        string EFY { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        string FundName { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        string RpioName { get; set; }

        /// <summary> Gets or sets the ah code. </summary>
        /// <value> The ah code. </value>
        string AhCode { get; set; }

        /// <summary> Gets or sets the name of the ah. </summary>
        /// <value> The name of the ah. </value>
        string AhName { get; set; }

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        string OrgCode { get; set; }

        /// <summary> Gets or sets the name of the org. </summary>
        /// <value> The name of the org. </value>
        string OrgName { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        string AccountCode { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        string BocCode { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        string BocName { get; set; }

        /// <summary> Gets or sets the rc code. </summary>
        /// <value> The rc code. </value>
        string RcCode { get; set; }

        /// <summary> Gets or sets the name of the rc. </summary>
        /// <value> The name of the rc. </value>
        string RcName { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the program area code. </summary>
        /// <value> The program area code. </value>
        string ProgramAreaCode { get; set; }

        /// <summary> Gets or sets the name of the program area. </summary>
        /// <value> The name of the program area. </value>
        string ProgramAreaName { get; set; }
    }
}