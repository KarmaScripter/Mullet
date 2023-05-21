﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    public interface IReprogramming
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        /// <summary> Gets or sets the budget level. </summary>
        /// <value> The budget level. </value>
        string BudgetLevel { get; set; }

        /// <summary> Gets or sets the document prefix. </summary>
        /// <value> The document prefix. </value>
        string DocPrefix { get; set; }

        /// <summary> Gets or sets the type of the document. </summary>
        /// <value> The type of the document. </value>
        string DocType { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the Ending Fiscal Year </summary>
        string EFY { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        string RpioName { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        string FundName { get; set; }

        /// <summary> Gets or sets the reprogramming number. </summary>
        /// <value> The reprogramming number. </value>
        string ReprogrammingNumber { get; set; }

        /// <summary> Gets or sets the control number. </summary>
        /// <value> The control number. </value>
        string ControlNumber { get; set; }

        /// <summary> Gets or sets the processed date. </summary>
        /// <value> The processed date. </value>
        DateOnly ProcessedDate { get; set; }

        /// <summary> Gets or sets the quarter. </summary>
        /// <value> The quarter. </value>
        string Quarter { get; set; }

        /// <summary> Gets or sets the line. </summary>
        /// <value> The line. </value>
        string Line { get; set; }

        /// <summary> Gets or sets the subline. </summary>
        /// <value> The subline. </value>
        string Subline { get; set; }

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

        /// <summary> Gets or sets the program area code. </summary>
        /// <value> The program area code. </value>
        string ProgramAreaCode { get; set; }

        /// <summary> Gets or sets the name of the program area. </summary>
        /// <value> The name of the program area. </value>
        string ProgramAreaName { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets from to. </summary>
        /// <value> From to. </value>
        string FromTo { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        string BocCode { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        string BocName { get; set; }

        /// <summary> Gets or sets the NPM code. </summary>
        /// <value> The NPM code. </value>
        string NpmCode { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        double Amount { get; set; }

        /// <summary> Gets or sets the type of the resource. </summary>
        /// <value> The type of the resource. </value>
        string ResourceType { get; set; }

        /// <summary> Gets or sets the purpose. </summary>
        /// <value> The purpose. </value>
        string Purpose { get; set; }

        /// <summary> Gets or sets the extended purpose. </summary>
        /// <value> The extended purpose. </value>
        string ExtendedPurpose { get; set; }
    }
}