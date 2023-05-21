// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IOutlay : IBudgetUnit
    {
        /// <summary> Gets or sets the appropriation code. </summary>
        /// <value> The appropriation code. </value>
        string AppropriationCode { get; set; }

        /// <summary> Gets or sets the name of the appropriation. </summary>
        /// <value> The name of the appropriation. </value>
        string AppropriationName { get; set; }

        /// <summary> Gets or sets the month processed. </summary>
        /// <value> The month processed. </value>
        string MonthProcessed { get; set; }

        /// <summary> Gets or sets the total obligations. </summary>
        /// <value> The total obligations. </value>
        double TotalObligations { get; set; }

        /// <summary> Gets or sets the unliquidated obligations. </summary>
        /// <value> The unliquidated obligations. </value>
        double UnliquidatedObligations { get; set; }

        /// <summary> Gets or sets the obligations paid. </summary>
        /// <value> The obligations paid. </value>
        double ObligationsPaid { get; set; }
    }
}