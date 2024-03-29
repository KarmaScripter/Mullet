﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="DataModel"/>
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class DataBuilder : DataModel, IDataModel
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        public DataBuilder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        public DataBuilder( Source source, Provider provider = Provider.Access )
            : base( source, provider )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The arguments. </param>
        public DataBuilder( Source source, Provider provider, IDictionary<string, object> where )
            : base( source, provider, where )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        public DataBuilder( Source source, IDictionary<string, object> dict )
            : base( source, dict )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> The updates. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public DataBuilder( Source source, Provider provider, IDictionary<string, object> updates, IDictionary<string, object> where,
            SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public DataBuilder( Source source, Provider provider, IEnumerable<string> columns, IDictionary<string, object> where,
            SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public DataBuilder( Source source, Provider provider, IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where, SQL commandType )
            : base( source, provider, fields, numerics, where,
                commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public DataBuilder( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public DataBuilder( IQuery query )
            : base( query )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        public DataBuilder( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataBuilder"/>
        /// class.
        /// </summary>
        /// <param name="row"> The row. </param>
        public DataBuilder( DataRow row )
        {
            Record = row;
        }

        /// <summary> Filters the dataRows. </summary>
        /// <param name="dataRows"> The dataRows. </param>
        /// <param name="name"> The field. </param>
        /// <param name="value"> The filter. </param>
        /// <returns> </returns>
        public IEnumerable<DataRow> FilterData( string name, string value )
        {
            if( DataTable != null
               && !string.IsNullOrEmpty( name )
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )?.Where( r => r.Field<string>( name ).Equals( value ) )?.Select( r => r );
                    return _query?.Any( ) == true
                        ? _query.ToArray( )
                        : default( DataRow[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary> Gets the series. </summary>
        /// <param name="dataRows"> The dataRows. </param>
        /// <param name="name"> The field. </param>
        /// <param name="value"> The filter. </param>
        /// <returns> </returns>
        [ SuppressMessage( "ReSharper", "BadParensLineBreaks" ) ]
        public IDictionary<string, IEnumerable<string>> GetSeries( string name, string value )
        {
            if( DataTable != null
               && !string.IsNullOrEmpty( name )
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _columns = DataTable.Columns;
                    var _rows = DataTable.AsEnumerable( );
                    var _dictionary = new Dictionary<string, IEnumerable<string>>( );
                    var _values = GetValues( _rows, name, value );
                    if( _values?.Any( ) == true )
                    {
                        for( var i = 0; i < _columns?.Count; i++ )
                        {
                            var _columnName = _columns[ i ].ColumnName;
                            if( !string.IsNullOrEmpty( _columnName )
                               && _columns[ i ]?.DataType == typeof( string ) )
                            {
                                _dictionary.Add( _columns[ i ].ColumnName, _values );
                            }
                        }

                        return _dictionary?.Any( ) == true
                            ? _dictionary
                            : default( Dictionary<string, IEnumerable<string>> );
                    }

                    return default( IDictionary<string, IEnumerable<string>> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, IEnumerable<string>> );
                }
            }

            return default( IDictionary<string, IEnumerable<string>> );
        }

        /// <summary> Gets the provider. </summary>
        /// <param name="provider"> The provider. </param>
        /// <returns> </returns>
        public static Provider GetProvider( string provider )
        {
            if( !string.IsNullOrEmpty( provider ) )
            {
                try
                {
                    if( Enum.IsDefined( typeof( Provider ), provider ) )
                    {
                        return (Provider)Enum.Parse( typeof( Provider ), provider );
                    }
                    else if( Path.HasExtension( provider ) )
                    {
                        var _path = Path.GetExtension( provider );
                        var _ext = (EXT)Enum.Parse( typeof( EXT ), _path );
                        switch( _ext )
                        {
                            case EXT.MDB:
                            case EXT.ACCDB:
                            {
                                return Provider.Access;
                            }
                            case EXT.SDF:
                            {
                                return Provider.SqlCe;
                            }
                            case EXT.MDF:
                            {
                                return Provider.SqlServer;
                            }
                            case EXT.DB:
                            {
                                return Provider.SQLite;
                            }
                            default:
                            {
                                return Provider.Access;
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Provider );
                }
            }

            return default( Provider );
        }

        /// <summary> Gets the provider. </summary>
        /// <param name="ext"> The ext. </param>
        /// <returns> </returns>
        public static Provider GetProvider( EXT ext )
        {
            if( Enum.IsDefined( typeof( EXT ), ext ) )
            {
                try
                {
                    switch( ext )
                    {
                        case EXT.MDB:
                        case EXT.ACCDB:
                        {
                            return Provider.Access;
                        }
                        case EXT.SDF:
                        {
                            return Provider.SqlCe;
                        }
                        case EXT.MDF:
                        {
                            return Provider.SqlServer;
                        }
                        case EXT.DB:
                        {
                            return Provider.SQLite;
                        }
                        default:
                        {
                            return Provider.Access;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Provider );
                }
            }

            return default( Provider );
        }

        /// <summary> Gets the source. </summary>
        /// <param name="tableName"> The source. </param>
        /// <returns> </returns>
        public static Source GetSource( string tableName )
        {
            if( !string.IsNullOrEmpty( tableName ) )
            {
                try
                {
                    var _names = Enum.GetNames( typeof( Source ) );
                    foreach( var _name in _names )
                    {
                        if( _name.Equals( tableName ) )
                        {
                            return (Source)Enum.Parse( typeof( Source ), tableName );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Source );
                }
            }

            return default( Source );
        }

        /// <summary> Filters the data. </summary>
        /// <param name="where"> The dictionary. </param>
        /// <returns> </returns>
        public IEnumerable<DataRow> FilterData( IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && DataTable != null )
            {
                try
                {
                    var _criteria = where.ToCriteria( );
                    var _data = DataTable.Select( _criteria );
                    return _data?.Length > 0
                        ? _data
                        : default( IEnumerable<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }
    }
}