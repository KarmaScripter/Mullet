// <copyright file = "SQL.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> Defines the SQL </summary>
    public enum SQL
    {
        /// <summary> Defines the SELECT </summary>
        SELECT,

        /// <summary> The select all </summary>
        SELECTALL,

        /// <summary> Defines the INSERT </summary>
        INSERT,

        /// <summary> Defines the UPDATE </summary>
        UPDATE,

        /// <summary> Defines the DELETE </summary>
        DELETE,

        /// <summary> Defines the CREATE </summary>
        CREATEDATABASE,

        /// <summary> The create table </summary>
        CREATETABLE,

        /// <summary> The create view </summary>
        CREATEVIEW,

        /// <summary> Defines the DROP </summary>
        DROP,

        /// <summary> Defines the ALTER </summary>
        ALTERTABLE
    }
}