// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="IProvider"/>
    /// <seealso cref="ISource"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class SqlBase
    {
        /// <summary> The extension </summary>
        public EXT Extension { get; set; }

        /// <summary> The source </summary>
        public Source Source { get; set; }

        /// <summary> The provider </summary>
        public Provider Provider { get; set; }

        /// <summary> The command type </summary>
        public SQL CommandType { get; set; }

        /// <summary> The arguments </summary>
        public IDictionary<string, object> Criteria { get; set; }

        /// <summary> Gets or sets the updates. </summary>
        /// <value> The updates. </value>
        public IDictionary<string, object> Updates { get; set; }

        /// <summary> Gets or sets the columns. </summary>
        /// <value> The columns. </value>
        public IList<string> Fields { get; set; }

        /// <summary> Gets or sets the numerics. </summary>
        /// <value> The numerics. </value>
        public IList<string> Numerics { get; set; }

        /// <summary> Gets or sets the groups. </summary>
        /// <value> The groups. </value>
        public IList<string> Groups { get; set; }

        /// <summary> Gets or sets the name of the table. </summary>
        /// <value> The name of the table. </value>
        public string TableName { get; set; }

        /// <summary> The provider path </summary>
        public string DbPath { get; set; }

        /// <summary> The file name </summary>
        public string FileName { get; set; }

        /// <summary> Gets or sets the select statement. </summary>
        /// <value> The select statement. </value>
        public string CommandText { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlBase"/>
        /// class.
        /// </summary>
        protected SqlBase( )
        {
            Criteria = new Dictionary<string, object>( );
            Fields = new List<string>( );
            Numerics = new List<string>( );
            Groups = new List<string>( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected SqlBase( Source source, Provider provider, SQL commandType = SQL.SELECTALL )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            CommandText = $"SELECT * FROM {source}";
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected SqlBase( Source source, Provider provider, string sqlText, SQL commandType )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            CommandText = sqlText;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> </param>
        /// <param name="commandType"> </param>
        protected SqlBase( Source source, Provider provider, IDictionary<string, object> where, SQL commandType = SQL.SELECTALL )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = where;
            CommandText = $"SELECT * FROM {source} WHERE {where.ToCriteria( )}";
        }

        /// <summary> </summary>
        /// <param name="source"> </param>
        /// <param name="provider"> </param>
        /// <param name="updates"> </param>
        /// <param name="where"> </param>
        /// <param name="commandType"> </param>
        protected SqlBase( Source source, Provider provider, IDictionary<string, object> updates, IDictionary<string, object> where,
            SQL commandType = SQL.UPDATE )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Updates = updates;
            Criteria = where;
            Fields = updates.Keys.ToList( );
            CommandText = GetCommandText( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The dictionary. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected SqlBase( Source source, Provider provider, IEnumerable<string> columns, IDictionary<string, object> where,
            SQL commandType = SQL.SELECT )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = where;
            Fields = columns.ToList( );
            CommandText = GetCommandText( );
        }

        /// <summary> </summary>
        /// <param name="source"> </param>
        /// <param name="provider"> </param>
        /// <param name="fields"> </param>
        /// <param name="numerics"> </param>
        /// <param name="having"> </param>
        /// <param name="commandType"> </param>
        protected SqlBase( Source source, Provider provider, IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> having, SQL commandType = SQL.SELECT )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = having;
            Fields = fields.ToList( );
            Numerics = numerics.ToList( );
            CommandText = GetCommandText( );
        }

        /// <summary> Gets the command text. </summary>
        /// <returns> </returns>
        public string GetCommandText( )
        {
            if( Enum.IsDefined( typeof( SQL ), CommandType ) )
            {
                try
                {
                    switch( CommandType )
                    {
                        case SQL.SELECT:
                        case SQL.SELECTALL:
                        {
                            return GetSelectStatement( );
                        }
                        case SQL.INSERT:
                        {
                            return GetInsertStatement( );
                        }
                        case SQL.UPDATE:
                        {
                            return GetUpdateStatement( );
                        }
                        case SQL.DELETE:
                        {
                            return GetDeleteStatement( );
                        }
                        default:
                        {
                            return GetSelectStatement( );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }

        /// <summary> Sets the select statement. </summary>
        protected private string GetSelectStatement( )
        {
            if( Fields?.Any( ) == true
               && Criteria?.Any( ) == true
               && Numerics?.Any( ) == true )
            {
                var _cols = string.Empty;
                var _aggr = string.Empty;
                foreach( var name in Fields )
                {
                    _cols += $"{name}, ";
                }

                foreach( var metric in Numerics )
                {
                    _aggr += $"SUM({metric}) AS {metric}, ";
                }

                var _criteria = Criteria.ToCriteria( );
                var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                var _groups = _cols.TrimEnd( ", ".ToCharArray( ) );
                return $"SELECT {_columns} FROM {Source} " + $"WHERE {_criteria} " + $"GROUP BY {_groups};";
            }

            if( Fields?.Any( ) == true
               && Criteria?.Any( ) == true
               && Numerics?.Any( ) == false )
            {
                var _cols = string.Empty;
                var _aggr = string.Empty;
                foreach( var name in Fields )
                {
                    _cols += $"{name}, ";
                }

                var _criteria = Criteria.ToCriteria( );
                var _columns = _cols.TrimEnd( ", ".ToCharArray( ) );
                return $"SELECT {_columns} FROM {Source} " + $"WHERE {_criteria} " + $"GROUP BY {_columns};";
            }
            else if( Fields?.Any( ) == false
                    && Criteria?.Any( ) == true
                    && Numerics?.Any( ) == false )
            {
                var _criteria = Criteria.ToCriteria( );
                return $"SELECT * FROM {Source} WHERE {_criteria};";
            }
            else if( Fields?.Any( ) == false
                    && Criteria?.Any( ) == false
                    && Numerics?.Any( ) == false )
            {
                return $"SELECT * FROM {Source};";
            }

            return default;
        }

        /// <summary> Gets the update statement. </summary>
        /// <returns> </returns>
        protected private string GetUpdateStatement( )
        {
            if( Updates?.Any( ) == true
               && Criteria?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _update = string.Empty;
                    if( Updates.Count == 1 )
                    {
                        foreach( var kvp in Updates )
                        {
                            _update += $"{kvp.Key} = '{kvp.Value}'";
                        }
                    }
                    else if( Updates.Count > 1 )
                    {
                        foreach( var kvp in Updates )
                        {
                            _update += $"{kvp.Key} = '{kvp.Value}', ";
                        }
                    }

                    var _criteria = Criteria.ToCriteria( );
                    var _values = _update.TrimEnd( ", ".ToCharArray( ) );
                    return $"UPDATE {Source} SET {_values} WHERE {_criteria};";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary> Sets the insert statement. </summary>
        protected private string GetInsertStatement( )
        {
            if( Updates?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _columns = string.Empty;
                    var _values = string.Empty;
                    if( Updates.Count == 1 )
                    {
                        foreach( var kvp in Updates )
                        {
                            _columns += $"{kvp.Key}";
                            _values += $"{kvp.Value}";
                        }
                    }
                    else if( Updates.Count > 1 )
                    {
                        foreach( var kvp in Updates )
                        {
                            _columns += $"{kvp.Key}, ";
                            _values += $"{kvp.Value}, ";
                        }
                    }

                    var _columnValues = $"({_columns.TrimEnd( ", ".ToCharArray( ) )})" + $" VALUES ({_values.TrimEnd( ", ".ToCharArray( ) )})";
                    return $"INSERT INTO {Source} {_columnValues};";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary> Gets the delete statement. </summary>
        /// <returns> </returns>
        protected private string GetDeleteStatement( )
        {
            if( Criteria?.Any( ) == true )
            {
                try
                {
                    var _criteria = Criteria.ToCriteria( );
                    return !string.IsNullOrEmpty( _criteria )
                        ? $"DELETE FROM {Source} WHERE {_criteria};"
                        : $"DELETE FROM {Source};";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }
    }
}