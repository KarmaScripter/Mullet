﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public static class DictionaryExtensions
    {
        /// <summary> Adds the or update. </summary>
        /// <typeparam name="TKey"> The type of the key. </typeparam>
        /// <typeparam name="TValue"> The type of the value. </typeparam>
        /// <param name="dict"> The dictionary. </param>
        /// <param name="key"> The key. </param>
        /// <param name="value"> The value. </param>
        /// <returns> </returns>
        public static TValue AddOrUpdate<TKey, TValue>( this IDictionary<TKey, TValue> dict, TKey key, TValue value )
        {
            if( !dict.ContainsKey( key ) )
            {
                try
                {
                    dict.Add( new KeyValuePair<TKey, TValue>( key, value ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }
            else
            {
                dict[ key ] = value;
            }

            return dict[ key ];
        }

        /// <summary> Predicates the specified logic. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static string ToCriteria( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _criteria = "";
                    if( dict.HasPrimaryKey( ) )
                    {
                        var _key = dict.GetPrimaryKey( );
                        if( !string.IsNullOrEmpty( _key.Key ) & int.Parse( _key.Value.ToString( ) ) > -1 )
                        {
                            foreach( var kvp in dict )
                            {
                                _criteria += $"{kvp.Key} = '{kvp.Value}' AND ";
                            }

                            var _sql = _criteria.TrimEnd( " AND ".ToCharArray( ) );
                            _sql += $" WHERE {_key.Key} = {int.Parse( _key.Value.ToString( ) )};";
                            return !string.IsNullOrEmpty( _sql )
                                ? _sql
                                : string.Empty;
                        }
                    }
                    else if( !dict.HasPrimaryKey( ) )
                    {
                        foreach( var kvp in dict )
                        {
                            _criteria += $"{kvp.Key} = '{kvp.Value}' AND ";
                        }

                        var _sql = _criteria.TrimEnd( " AND ".ToCharArray( ) );
                        return !string.IsNullOrEmpty( _sql )
                            ? _sql
                            : string.Empty;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary> Converts to sorteddictionary. </summary>
        /// <typeparam name="TKey"> The type of the key. </typeparam>
        /// <typeparam name="TValue"> The type of the value. </typeparam>
        /// <param name="nvc"> The this. </param>
        /// <returns> </returns>
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>( this IDictionary<TKey, TValue> nvc )
        {
            try
            {
                return new SortedDictionary<TKey, TValue>( nvc );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Converts to bindinglist. </summary>
        /// <param name="nvc"> The NVC. </param>
        /// <returns> </returns>
        public static BindingList<KeyValuePair<string, object>> ToBindingList( this IDictionary<string, object> nvc )
        {
            try
            {
                var _bindingList = new BindingList<KeyValuePair<string, object>>( );
                foreach( var kvp in nvc )
                {
                    _bindingList.Add( kvp );
                }

                return _bindingList?.Any( ) == true
                    ? _bindingList
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Converts to sorteddictionary. </summary>
        /// <typeparam name="TKey"> The type of the key. </typeparam>
        /// <typeparam name="TValue"> The type of the value. </typeparam>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>( this IDictionary<TKey, TValue> dict )
        {
            try
            {
                return new SortedList<TKey, TValue>( dict );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Converts to sql db parameters. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <param name="provider"> The provider. </param>
        /// <returns> </returns>
        public static IEnumerable<DbParameter> ToSqlDbParameters( this IDictionary<string, object> dict, Provider provider )
        {
            if( dict?.Keys?.Count > 0
               && Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    var _columns = dict.Keys.ToArray( );
                    var _values = dict.Values.ToArray( );
                    switch( provider )
                    {
                        case Provider.SQLite:
                        {
                            var _sqlite = new List<SQLiteParameter>( );
                            for( var i = 0; i < _columns.Length; i++ )
                            {
                                var _parameter = new SQLiteParameter
                                {
                                    SourceColumn = _columns[ i ],
                                    Value = _values[ i ]
                                };

                                _sqlite.Add( _parameter );
                            }

                            return _sqlite.Any( )
                                ? (IEnumerable<DbParameter>)_sqlite.ToArray( )
                                : default( List<DbParameter> );
                        }
                        case Provider.SqlCe:
                        {
                            var _sqlce = new List<SqlCeParameter>( );
                            for( var i = 0; i < _columns.Length; i++ )
                            {
                                var _parameter = new SqlCeParameter
                                {
                                    SourceColumn = _columns[ i ],
                                    Value = _values[ i ]
                                };

                                _sqlce.Add( _parameter );
                            }

                            return _sqlce.Any( )
                                ? (IEnumerable<DbParameter>)_sqlce.ToArray( )
                                : default( List<DbParameter> );
                        }
                        case Provider.OleDb:
                        case Provider.Excel:
                        case Provider.Access:
                        {
                            var _oledb = new List<OleDbParameter>( );
                            for( var i = 0; i < _columns.Length; i++ )
                            {
                                var _parameter = new OleDbParameter
                                {
                                    SourceColumn = _columns[ i ],
                                    Value = _values[ i ]
                                };

                                _oledb.Add( _parameter );
                            }

                            return _oledb.Any( )
                                ? (IEnumerable<DbParameter>)_oledb.ToArray( )
                                : default( List<DbParameter> );
                        }
                        case Provider.SqlServer:
                        {
                            var _sqlserver = new List<SqlParameter>( );
                            for( var i = 0; i < _columns.Length; i++ )
                            {
                                var _parameter = new SqlParameter
                                {
                                    SourceColumn = _columns[ i ],
                                    Value = _values[ i ]
                                };

                                _sqlserver.Add( _parameter );
                            }

                            return _sqlserver?.Any( ) == true
                                ? (IEnumerable<DbParameter>)_sqlserver.ToArray( )
                                : default( List<DbParameter> );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( List<DbParameter> );
                }

                return default( List<DbParameter> );
            }

            return default( List<DbParameter> );
        }

        /// <summary> Determines whether [has a primary key]. </summary>
        /// <param name="dict"> The row. </param>
        /// <returns>
        /// <c> true </c>
        /// if [has primary key] [the specified row]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        public static bool HasPrimaryKey( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _array = dict.Keys?.ToArray( );
                    var _names = Enum.GetNames( typeof( PrimaryKey ) );
                    var _count = 0;
                    for( var i = 1; i < _array.Length; i++ )
                    {
                        var _name = _array[ i ];
                        if( _names.Contains( _name ) )
                        {
                            _count++;
                        }
                    }

                    return _count > 0;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return false;
        }

        /// <summary> Gets the primary key. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static KeyValuePair<string, object> GetPrimaryKey( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true
               && dict.HasPrimaryKey( ) )
            {
                try
                {
                    var _names = Enum.GetNames( typeof( PrimaryKey ) );
                    foreach( var kvp in dict )
                    {
                        if( _names.Contains( kvp.Key ) )
                        {
                            return new KeyValuePair<string, object>( kvp.Key, kvp.Value );
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

        /// <summary> Converts to Key bindinglist. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static BindingList<string> ToKeyBindingList<T>( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _list = new BindingList<string>( );
                    foreach( var kvp in dict )
                    {
                        _list.Add( kvp.Key );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( BindingList<string> );
                }
            }

            return default( BindingList<string> );
        }

        /// <summary> Converts to value bindinglist. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static BindingList<object> ToValueBindingList<T>( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _list = new BindingList<object>( );
                    foreach( var kvp in dict )
                    {
                        _list.Add( kvp.Value );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( BindingList<object> );
                }
            }

            return default( BindingList<object> );
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}