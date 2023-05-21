// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public class AdapterBase : DbDataAdapter, ISource, IProvider
    {
        /// <summary> The connection </summary>
        public virtual DbConnection DataConnection { get; set; }

        /// <summary> The SQL statement </summary>
        public virtual ISqlStatement SqlStatement { get; set; }

        /// <summary> The connection builder </summary>
        public virtual IConnectionFactory ConnectionFactory { get; set; }

        /// <summary> Gets the command builder. </summary>
        /// <value> The command builder. </value>
        public virtual IDictionary<string, DbCommand> Commands { get; set; }

        /// <summary> Gets the command factory. </summary>
        /// <value> The command factory. </value>
        public virtual ICommandFactory CommandFactory { get; set; }

        /// <summary> Gets or sets the command text. </summary>
        /// <value> The command text. </value>
        public virtual string CommandText { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public virtual Provider Provider { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public virtual Source Source { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AdapterBase"/>
        /// class.
        /// </summary>
        protected AdapterBase( )
        {
            MissingSchemaAction = MissingSchemaAction.AddWithKey;
            MissingMappingAction = MissingMappingAction.Ignore;
            ContinueUpdateOnError = true;
            AcceptChangesDuringFill = true;
            AcceptChangesDuringUpdate = true;
            ReturnProviderSpecificTypes = true;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AdapterBase"/>
        /// class.
        /// </summary>
        /// <param name="commandFactory"> The command factory. </param>
        protected AdapterBase( ICommandFactory commandFactory )
            : this( )
        {
            Source = commandFactory.Source;
            Provider = commandFactory.Provider;
            CommandFactory = commandFactory;
            ConnectionFactory = new ConnectionFactory( commandFactory.Source, commandFactory.Provider );
            DataConnection = ConnectionFactory.GetConnection( );
            CommandText = CommandFactory.GetCommand( ).CommandText;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AdapterBase"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        protected AdapterBase( ISqlStatement sqlStatement )
            : this( )
        {
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            SqlStatement = sqlStatement;
            ConnectionFactory = new ConnectionFactory( sqlStatement.Source, sqlStatement.Provider );
            DataConnection = ConnectionFactory.GetConnection( );
            CommandText = sqlStatement.CommandText;
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }

        /// <summary> Gets the sq lite adapter. </summary>
        /// <returns> </returns>
        protected private SQLiteDataAdapter GetSQLiteAdapter( )
        {
            if( DataConnection != null
               && !string.IsNullOrEmpty( CommandText ) )
            {
                try
                {
                    var _connection = DataConnection as SQLiteConnection;
                    var _adapter = new SQLiteDataAdapter( CommandText, _connection );
                    _adapter.ContinueUpdateOnError = true;
                    _adapter.AcceptChangesDuringFill = true;
                    _adapter.AcceptChangesDuringUpdate = true;
                    _adapter.ReturnProviderSpecificTypes = true;
                    if( CommandText.StartsWith( "SELECT *" )
                       || CommandText.StartsWith( "SELECT ALL" ) )
                    {
                        var _builder = new SQLiteCommandBuilder( _adapter );
                        _adapter.InsertCommand = _builder.GetInsertCommand( );
                        _adapter.UpdateCommand = _builder.GetUpdateCommand( );
                        _adapter.DeleteCommand = _builder.GetDeleteCommand( );
                        return _adapter;
                    }
                    else
                    {
                        return _adapter;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SQLiteDataAdapter );
                }
            }

            return default( SQLiteDataAdapter );
        }

        /// <summary> Gets the SQL adapter. </summary>
        /// <returns> </returns>
        protected private SqlDataAdapter GetSqlAdapter( )
        {
            if( DataConnection != null
               && !string.IsNullOrEmpty( CommandText ) )
            {
                try
                {
                    var _connection = DataConnection as SqlConnection;
                    var _adapter = new SqlDataAdapter( CommandText, _connection );
                    _adapter.ContinueUpdateOnError = true;
                    _adapter.AcceptChangesDuringFill = true;
                    _adapter.AcceptChangesDuringUpdate = true;
                    _adapter.ReturnProviderSpecificTypes = true;
                    if( CommandText.StartsWith( "SELECT *" )
                       || CommandText.StartsWith( "SELECT ALL" ) )
                    {
                        var _builder = new SqlCommandBuilder( _adapter );
                        _adapter.InsertCommand = _builder.GetInsertCommand( );
                        _adapter.UpdateCommand = _builder.GetUpdateCommand( );
                        _adapter.DeleteCommand = _builder.GetDeleteCommand( );
                        return _adapter;
                    }
                    else
                    {
                        return _adapter;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SqlDataAdapter );
                }
            }

            return default( SqlDataAdapter );
        }

        /// <summary> Gets the OLE database adapter. </summary>
        /// <returns> </returns>
        protected private OleDbDataAdapter GetOleDbAdapter( )
        {
            if( DataConnection != null
               && !string.IsNullOrEmpty( CommandText ) )
            {
                try
                {
                    var _connection = DataConnection as OleDbConnection;
                    var _adapter = new OleDbDataAdapter( CommandText, _connection );
                    _adapter.ContinueUpdateOnError = true;
                    _adapter.AcceptChangesDuringFill = true;
                    _adapter.AcceptChangesDuringUpdate = true;
                    _adapter.ReturnProviderSpecificTypes = true;
                    if( CommandText.StartsWith( "SELECT *" )
                       || CommandText.StartsWith( "SELECT ALL" ) )
                    {
                        var _builder = new OleDbCommandBuilder( _adapter );
                        _adapter.InsertCommand = _builder.GetInsertCommand( );
                        _adapter.UpdateCommand = _builder.GetUpdateCommand( );
                        _adapter.DeleteCommand = _builder.GetDeleteCommand( );
                        return _adapter;
                    }
                    else
                    {
                        return _adapter;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( OleDbDataAdapter );
                }
            }

            return default( OleDbDataAdapter );
        }

        /// <summary> Gets the SQL ce adapter. </summary>
        /// <returns> </returns>
        protected private DbDataAdapter GetSqlCeAdapter( )
        {
            if( DataConnection != null
               && !string.IsNullOrEmpty( CommandText ) )
            {
                try
                {
                    var _connection = DataConnection as SqlCeConnection;
                    var _adapter = new SqlCeDataAdapter( CommandText, _connection );
                    _adapter.ContinueUpdateOnError = true;
                    _adapter.AcceptChangesDuringFill = true;
                    _adapter.AcceptChangesDuringUpdate = true;
                    _adapter.ReturnProviderSpecificTypes = true;
                    if( CommandText.StartsWith( "SELECT *" )
                       || CommandText.StartsWith( "SELECT ALL" ) )
                    {
                        var _builder = new SqlCeCommandBuilder( _adapter );
                        _adapter.InsertCommand = _builder.GetInsertCommand( );
                        _adapter.UpdateCommand = _builder.GetUpdateCommand( );
                        _adapter.DeleteCommand = _builder.GetDeleteCommand( );
                        return _adapter;
                    }
                    else
                    {
                        return _adapter;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SqlCeDataAdapter );
                }
            }

            return default( SqlCeDataAdapter );
        }
    }
}