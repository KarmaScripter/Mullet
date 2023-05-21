// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public class ForeignKeySchema
    {
        /// <summary> The cascade on delete </summary>
        public bool CascadeOnDelete { get; set; }

        /// <summary> The column name </summary>
        public string ColumnName { get; set; }

        /// <summary> The foreign column name </summary>
        public string ForeignColumnName { get; set; }

        /// <summary> The foreign table name </summary>
        public string ForeignTableName { get; set; }

        /// <summary> The is nullable </summary>
        public bool IsNullable { get; set; }

        /// <summary> The table name </summary>
        public string TableName { get; set; }
    }
}