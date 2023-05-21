// <copyright file = "STAT.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> Defines the STAT </summary>
    public enum STAT
    {
        /// <summary> Defines the Total </summary>
        Total = 1,

        /// <summary> Defines the Count </summary>
        Count = 2,

        /// <summary> Defines the Average </summary>
        Average = 3,

        /// <summary> Defines the Percentage </summary>
        Percentage = 4,

        /// <summary> The standard deviation </summary>
        Deviation = 5,

        /// <summary> The variance </summary>
        Variance = 6
    }
}