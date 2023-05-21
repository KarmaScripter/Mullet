// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public static class DataRowExtensions
    {
        /// <summary> Converts to sql db parameters. </summary>
        /// <param name="dataRow"> The data row. </param>
        /// <param name="provider"> The provider. </param>
        /// <returns> </returns>
        /// <exception cref="InvalidEnumArgumentException"> provider </exception>
        public static IEnumerable<DbParameter> ToSqlDbParameters( this DataRow dataRow, Provider provider )
        {
            if( dataRow != null
               && dataRow.ItemArray.Length > 0
               && Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    {
                        var _table = dataRow.Table;
                        var _columns = _table?.Columns;
                        var _values = dataRow.ItemArray;
                        switch( provider )
                        {
                            case Provider.SQLite:
                            {
                                var _sqlite = new List<SQLiteParameter>( );
                                for( var i = 0; i < _columns?.Count; i++ )
                                {
                                    var _parameter = new SQLiteParameter( );
                                    _parameter.SourceColumn = _columns[ i ].ColumnName;
                                    _parameter.Value = _values[ i ];
                                    _sqlite.Add( _parameter );
                                }

                                return _sqlite?.Any( ) == true
                                    ? _sqlite
                                    : default( IList<DbParameter> );
                            }
                            case Provider.SqlCe:
                            {
                                var _sqlce = new List<SqlCeParameter>( );
                                for( var i = 0; i < _columns?.Count; i++ )
                                {
                                    var _parameter = new SqlCeParameter( );
                                    _parameter.SourceColumn = _columns[ i ].ColumnName;
                                    _parameter.Value = _values[ i ];
                                    _sqlce.Add( _parameter );
                                }

                                return _sqlce?.Any( ) == true
                                    ? _sqlce
                                    : default( IList<DbParameter> );
                            }
                            case Provider.OleDb:
                            case Provider.Excel:
                            case Provider.Access:
                            {
                                var _oledb = new List<OleDbParameter>( );
                                for( var i = 0; i < _columns?.Count; i++ )
                                {
                                    var parameter = new OleDbParameter( );
                                    parameter.SourceColumn = _columns[ i ].ColumnName;
                                    parameter.Value = _values[ i ];
                                    _oledb.Add( parameter );
                                }

                                return _oledb.Any( )
                                    ? _oledb
                                    : default( IList<DbParameter> );
                            }
                            case Provider.SqlServer:
                            {
                                var _sqlserver = new List<SqlParameter>( );
                                for( var i = 0; i < _columns?.Count; i++ )
                                {
                                    var _parameter = new SqlParameter( );
                                    _parameter.SourceColumn = _columns[ i ].ColumnName;
                                    _parameter.Value = _values[ i ];
                                    _sqlserver.Add( _parameter );
                                }

                                return _sqlserver?.Any( ) == true
                                    ? _sqlserver
                                    : default( IList<DbParameter> );
                            }
                        }

                        return default( IList<DbParameter> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IList<DbParameter> );
                }
            }

            return default( IList<DbParameter> );
        }

        /// <summary> Converts to dictionary. </summary>
        /// <param name="dataRow"> The data row. </param>
        /// <returns> </returns>
        public static IDictionary<string, object> ToDictionary( this DataRow dataRow )
        {
            try
            {
                if( dataRow?.ItemArray.Length > 0 )
                {
                    var _dictionary = new Dictionary<string, object>( );
                    var _table = dataRow?.Table;
                    var _column = _table?.Columns;
                    var _items = dataRow?.ItemArray;
                    for( var i = 0; i < _column?.Count; i++ )
                    {
                        if( !string.IsNullOrEmpty( _column[ i ]?.ColumnName ) )
                        {
                            _dictionary?.Add( _column[ i ].ColumnName, _items[ i ] ?? default( object ) );
                        }
                    }

                    return _dictionary?.Keys?.Count > 0
                        ? _dictionary
                        : default( IDictionary<string, object> );
                }

                return default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary> Gets the bytes. </summary>
        /// <param name="dataRow"> The data row. </param>
        /// <param name="columnName"> </param>
        /// <returns> </returns>
        public static IEnumerable<byte> GetBytes( this DataRow dataRow, string columnName )
        {
            try
            {
                return dataRow[ columnName ] as byte[ ];
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<byte> );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}