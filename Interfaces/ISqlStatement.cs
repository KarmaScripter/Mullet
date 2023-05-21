// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    /// <summary> </summary>
    public interface ISqlStatement
    {
        /// <summary> The extension </summary>
        EXT Extension { get; set; }

        /// <summary> The source </summary>
        Source Source { get; set; }

        /// <summary> The provider </summary>
        Provider Provider { get; set; }

        /// <summary> The command type </summary>
        SQL CommandType { get; set; }

        /// <summary> Gets or sets the command text. </summary>
        /// <value> The command text. </value>
        string CommandText { get; set; }

        /// <summary> The arguments </summary>
        IDictionary<string, object> Criteria { get; set; }

        /// <summary> Gets or sets the updates. </summary>
        /// <value> The updates. </value>
        IDictionary<string, object> Updates { get; set; }

        /// <summary> Gets or sets the columns. </summary>
        /// <value> The columns. </value>
        IList<string> Fields { get; set; }

        /// <summary> Gets or sets the numerics. </summary>
        /// <value> The numerics. </value>
        IList<string> Numerics { get; set; }

        /// <summary> Gets or sets the name of the table. </summary>
        /// <value> The name of the table. </value>
        string TableName { get; set; }

        /// <summary> The provider path </summary>
        string DbPath { get; set; }

        /// <summary> The file name </summary>
        string FileName { get; set; }

        /// <summary> Gets the command text. </summary>
        /// <returns> </returns>
        string GetCommandText( );
    }
}