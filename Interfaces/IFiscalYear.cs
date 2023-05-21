// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;

    /// <summary> </summary>
    public interface IFiscalYear
    {
        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the fiscal year identifier. </summary>
        /// <value> The fiscal year identifier. </value>
        int ID { get; set; }

        /// <summary> Gets or sets the first year. </summary>
        /// <value> The first year. </value>
        string FirstYear { get; set; }

        /// <summary> Gets or sets the last year. </summary>
        /// <value> The last year. </value>
        string LastYear { get; set; }

        /// <summary> Gets or sets the expiring year. </summary>
        /// <value> The expiring year. </value>
        string ExpiringYear { get; set; }

        /// <summary> Gets or sets the input year. </summary>
        /// <value> The input year. </value>
        string InputYear { get; set; }

        /// <summary> Gets or sets the start date. </summary>
        /// <value> The start date. </value>
        DateOnly StartDate { get; set; }

        /// <summary> Gets or sets the end date. </summary>
        /// <value> The end date. </value>
        DateOnly EndDate { get; set; }

        /// <summary> Gets or sets the cancellation date. </summary>
        /// <value> The cancellation date. </value>
        DateOnly CancellationDate { get; set; }

        /// <summary> Gets or sets the record. </summary>
        /// <value> The record. </value>
        DataRow Record { get; set; }

        /// <summary> Determines whether this instance is current. </summary>
        /// <returns>
        /// <c> true </c>
        /// if this instance is current; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool IsCurrent( );

        /// <summary> Determines whether this instance is carryover. </summary>
        /// <returns>
        /// <c> true </c>
        /// if this instance is carryover; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool IsCarryover( );
    }
}