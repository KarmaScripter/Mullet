// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class QueryBase
    {
        /// <summary> Gets the source. </summary>
        public virtual Source Source { get; set; }

        /// <summary> Gets the Provider </summary>
        public virtual Provider Provider { get; set; }

        /// <summary> Gets or sets the type of the command. </summary>
        /// <value> The type of the command. </value>
        public virtual SQL CommandType { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public virtual IDictionary<string, object> Criteria { get; set; }

        /// <summary> Gets the SQL statement. </summary>
        /// <value> The SQL statement. </value>
        public virtual ISqlStatement SqlStatement { get; set; }

        /// <summary> Gets the connector. </summary>
        /// <value> The connector. </value>
        public virtual IConnectionFactory ConnectionFactory { get; set; }

        /// <summary> Gets or sets the connection. </summary>
        /// <value> The connection. </value>
        public virtual DbConnection DataConnection { get; set; }

        /// <summary> Gets the adapter. </summary>
        /// <value> The adapter. </value>
        public virtual DbDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is disposed; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public virtual bool IsDisposed { get; set; }

        /// <summary> Gets or sets the Data reader. </summary>
        /// <value> The Data reader. </value>
        public virtual DbDataReader DataReader { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        protected QueryBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider = Provider.Access, SQL commandType = SQL.SELECTALL )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The dictionary. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider, IDictionary<string, object> where, SQL commandType = SQL.SELECTALL )
        {
            Source = source;
            Provider = provider;
            Criteria = where;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, where, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider, IDictionary<string, object> updates, IDictionary<string, object> where,
            SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            Criteria = where;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The having. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider, IEnumerable<string> columns, IDictionary<string, object> where,
            SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            Criteria = where;
            CommandType = commandType;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="having"> The having. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider, IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> having, SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            Criteria = having;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, fields, having, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        protected QueryBase( Source source, Provider provider, string sqlText )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, sqlText );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
            Criteria = null;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="sqlText"> </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            Criteria = null;
            ConnectionFactory = new ConnectionFactory( fullPath );
            Provider = ConnectionFactory.Provider;
            Source = ConnectionFactory.Source;
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( ConnectionFactory.Source, ConnectionFactory.Provider, sqlText );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="commandType"> Type of the command. </param>
        /// <param name="where"> The dictionary. </param>
        protected QueryBase( string fullPath, SQL commandType, IDictionary<string, object> where )
        {
            ConnectionFactory = new ConnectionFactory( fullPath );
            Criteria = where;
            CommandType = commandType;
            Source = ConnectionFactory.Source;
            Provider = ConnectionFactory.Provider;
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( Source, Provider, where, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        protected QueryBase( ISqlStatement sqlStatement )
        {
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            Criteria = sqlStatement.Criteria;
            ConnectionFactory = new ConnectionFactory( sqlStatement.Source, sqlStatement.Provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = sqlStatement;
            DataAdapter = new AdapterFactory( sqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <inheritdoc/>
        /// <summary> Gets the adapter. </summary>
        /// <returns> </returns>
        public virtual DbDataAdapter GetAdapter( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider )
               && SqlStatement != null )
            {
                try
                {
                    switch( Provider )
                    {
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.OleDb:
                        case Provider.Access:
                        {
                            var _adapter = new AdapterFactory( SqlStatement );
                            return _adapter?.GetAdapter( ) as OleDbDataAdapter;
                        }
                        case Provider.SQLite:
                        {
                            var _builder = new AdapterFactory( SqlStatement );
                            return _builder?.GetAdapter( ) as SQLiteDataAdapter;
                        }
                        case Provider.SqlCe:
                        {
                            var _builder = new AdapterFactory( SqlStatement );
                            return _builder?.GetAdapter( ) as SqlCeDataAdapter;
                        }
                        case Provider.SqlServer:
                        {
                            var _builder = new AdapterFactory( SqlStatement );
                            return _builder?.GetAdapter( ) as SqlDataAdapter;
                        }
                        default:
                        {
                            var _builder = new AdapterFactory( SqlStatement );
                            return _builder?.GetAdapter( ) as OleDbDataAdapter;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
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