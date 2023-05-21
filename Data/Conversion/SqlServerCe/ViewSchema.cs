// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> Describes a single view schema </summary>
    public class ViewSchema
    {
        /// <summary> Contains the view name </summary>
        public string ViewName { get; set; }

        /// <summary> Contains the view SQL statement </summary>
        public string ViewSql { get; set; }
    }
}