// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public enum Status
    {
        /// <summary> The ns </summary>
        NS = 0,

        /// <summary> The loading </summary>
        Loading = 1,

        /// <summary> The processing </summary>
        Processing = 2,

        /// <summary> The waiting </summary>
        Waiting = 3
    }
}