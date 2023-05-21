// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    /// <param name="viewSchema"> The view schema. </param>
    /// <returns> </returns>
    public delegate string FailedViewDefinitionHandler( ViewSchema viewSchema );
}