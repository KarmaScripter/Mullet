// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data.Common;

    /// <summary> </summary>
    public interface IQuery
    {
        /// <summary> Gets the source. </summary>
        Source Source { get; set; }

        /// <summary> Gets the Provider </summary>
        Provider Provider { get; set; }

        /// <summary> Gets or sets the type of the command. </summary>
        /// <value> The type of the command. </value>
        SQL CommandType { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        IDictionary<string, object> Criteria { get; set; }

        /// <summary> Gets the SQL statement. </summary>
        /// <value> The SQL statement. </value>
        ISqlStatement SqlStatement { get; set; }

        /// <summary> Gets the connector. </summary>
        /// <value> The connector. </value>
        IConnectionFactory ConnectionFactory { get; set; }

        /// <summary> Gets or sets the connection. </summary>
        /// <value> The connection. </value>
        DbConnection DataConnection { get; set; }

        /// <summary> Gets the adapter. </summary>
        /// <value> The adapter. </value>
        DbDataAdapter DataAdapter { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets the adapter. </summary>
        /// <returns> </returns>
        DbDataAdapter GetAdapter( );
    }
}