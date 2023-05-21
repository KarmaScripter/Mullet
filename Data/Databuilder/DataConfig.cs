// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    public abstract class DataConfig
    {
        /// <summary> The source </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> The provider </summary>
        /// <value> The provider. </value>
        public Provider Provider { get; set; }

        /// <summary> The connection builder </summary>
        /// <value> The connection factory. </value>
        public IConnectionFactory ConnectionFactory { get; set; }

        /// <summary> The arguments </summary>
        /// <value> The map. </value>
        public IDictionary<string, object> Map { get; set; }

        /// <summary> The SQL statement </summary>
        /// <value> The SQL statement. </value>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary> The query </summary>
        /// <value> The query. </value>
        public IQuery Query { get; set; }

        /// <summary> The record </summary>
        /// <value> The record. </value>
        public DataRow Record { get; set; }

        /// <summary> The Data table </summary>
        /// <value> The data table. </value>
        public DataTable DataTable { get; set; }

        /// <summary> Gets or sets the columns. </summary>
        /// <value> The columns. </value>
        public IEnumerable<DataColumn> DataColumns { get; set; }

        /// <summary> Gets or sets the column names. </summary>
        /// <value> The column names. </value>
        public IEnumerable<string> ColumnNames { get; set; }

        /// <summary> Gets or sets the keys. </summary>
        /// <value> The keys. </value>
        public IList<int> Keys { get; set; }

        /// <summary> Gets or sets the fields. </summary>
        /// <value> The fields. </value>
        public IList<string> Fields { get; set; }

        /// <summary> Gets or sets the dates. </summary>
        /// <value> The dates. </value>
        public IList<string> Dates { get; set; }

        /// <summary> Gets or sets the numerics. </summary>
        /// <value> The numerics. </value>
        public IList<string> Numerics { get; set; }

        /// <summary> Gets or sets the name of the table. </summary>
        /// <value> The name of the table. </value>
        public string TableName { get; set; }

        /// <summary> Gets or sets the Data set. </summary>
        /// <value> The Data set. </value>
        public DataSet DataSet { get; set; }

        /// <summary> Gets or sets the name of the data set. </summary>
        /// <value> The name of the data set. </value>
        public string DataSetName { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataConfig"/>
        /// class.
        /// </summary>
        protected DataConfig( )
        {
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}