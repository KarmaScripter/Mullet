// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Data.Common;
    using System.Threading;

    /// <summary> </summary>
    public interface IConnectionFactory
    {
        /// <summary> The connector </summary>
        /// <value> The connection path. </value>
        ConnectionStringSettingsCollection ConnectionPath { get; set; }

        /// <summary> Gets the client path. </summary>
        /// <value> The client path. </value>
        NameValueCollection DbClientPath { get; set; }

        /// <summary> Gets or sets the connection. </summary>
        /// <value> The connection. </value>
        DbConnection Connection { get; set; }

        /// <summary> The provider path </summary>
        /// <value> The database path. </value>
        string DbPath { get; set; }

        /// <summary> The source </summary>
        /// <value> The source. </value>
        Source Source { get; set; }

        /// <summary> The provider </summary>
        /// <value> The provider. </value>
        Provider Provider { get; set; }

        /// <summary> The file extension </summary>
        /// <value> The extension. </value>
        EXT Extension { get; set; }

        /// <summary> Gets or sets the path extension. </summary>
        /// <value> The path extension. </value>
        string PathExtension { get; set; }

        /// <summary> The file path </summary>
        /// <value> The file path. </value>
        string FilePath { get; set; }

        /// <summary> The file name </summary>
        /// <value> The name of the file. </value>
        string FileName { get; set; }

        /// <summary> The table name </summary>
        /// <value> The name of the table. </value>
        string TableName { get; set; }

        /// <summary> The connection string </summary>
        /// <value> The connection string. </value>
        string ConnectionString { get; set; }

        /// <summary> Gets the connection. </summary>
        /// <returns> </returns>
        DbConnection GetConnection( );
    }
}