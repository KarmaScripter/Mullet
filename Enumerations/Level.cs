// <copyright file = "Level.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public enum Level
    {
        /// <summary> The ns </summary>
        NS = -1,

        /// <summary> </summary>
        Treasury = 0,

        /// <summary> The appropriation </summary>
        Appropriation = 1,

        /// <summary> The apportionment </summary>
        Apportionment = 2,

        /// <summary> The rpio </summary>
        RPIO = 3,

        /// <summary> The allowance holder </summary>
        AllowanceHolder = 4,

        /// <summary> The program area </summary>
        ProgramArea = 5,

        /// <summary> The program results code </summary>
        ProgramResultsCode = 6,

        /// <summary> The budget object class </summary>
        BudgetObjectClass = 7,

        /// <summary> The sub allocation </summary>
        SubAllocation = 8
    }
}