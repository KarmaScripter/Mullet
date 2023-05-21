// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="DataAccess"/>
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public abstract class ModelBase : DataAccess
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ModelBase"/>
        /// class.
        /// </summary>
        protected ModelBase( )
        {
        }

        /// <summary> Gets the column ordinals. </summary>
        /// <returns> </returns>
        public virtual IEnumerable<int> GetOrdinals( )
        {
            if( DataTable?.Columns?.Count > 0 )
            {
                try
                {
                    var _columns = DataTable.Columns;
                    var _values = new List<int>( );
                    if( _columns?.Count > 0 )
                    {
                        foreach( DataColumn _column in _columns )
                        {
                            _values?.Add( _column.Ordinal );
                        }
                    }

                    return _values?.Any( ) == true
                        ? _values
                        : default( IEnumerable<int> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<int> );
                }
            }

            return default( IEnumerable<int> );
        }

        /// <summary> Gets the fields. </summary>
        /// <returns> </returns>
        public IDictionary<string, Type> GetColumnSchema( )
        {
            if( DataTable?.Columns?.Count > 0 )
            {
                try
                {
                    var _columns = DataTable?.Columns;
                    if( _columns?.Count > 0 )
                    {
                        var _schema = new Dictionary<string, Type>( );
                        foreach( DataColumn col in _columns )
                        {
                            _schema.Add( col.ColumnName, col.DataType );
                        }

                        return _schema?.Any( ) == true
                            ? _schema
                            : default( IDictionary<string, Type> );
                    }
                    else
                    {
                        return default( IDictionary<string, Type> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, Type> );
                }
            }

            return default( IDictionary<string, Type> );
        }

        /// <summary> Filters the data. </summary>
        /// <param name="dataRows"> </param>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public IEnumerable<DataRow> FilterData( IEnumerable<DataRow> dataRows, IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true
               && dataRows?.Any( ) == true )
            {
                try
                {
                    var _criteria = dict.ToCriteria( );
                    var _dataTable = dataRows.CopyToDataTable( );
                    var _data = _dataTable.Select( _criteria );
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

        /// <summary> Gets the columns. </summary>
        /// <returns> </returns>
        public IEnumerable<DataColumn> GetDataColumns( )
        {
            if( DataTable?.Columns?.Count > 0 )
            {
                try
                {
                    var _dataColumns = new List<DataColumn>( );
                    var _data = DataTable?.Columns;
                    if( _data?.Count > 0 )
                    {
                        foreach( DataColumn column in _data )
                        {
                            if( column != null )
                            {
                                _dataColumns.Add( column );
                            }
                        }

                        return _dataColumns?.Any( ) == true
                            ? _dataColumns
                            : default( IEnumerable<DataColumn> );
                    }
                    else
                    {
                        return default( IEnumerable<DataColumn> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataColumn> );
                }
            }

            return default( IEnumerable<DataColumn> );
        }

        /// <summary> Gets the column names. </summary>
        /// <returns> </returns>
        public IEnumerable<string> GetColumnNames( )
        {
            if( DataTable?.Columns?.Count > 0 )
            {
                try
                {
                    var _names = new List<string>( );
                    var _data = DataTable?.Columns;
                    if( _data?.Count > 0 )
                    {
                        foreach( DataColumn column in _data )
                        {
                            if( !string.IsNullOrEmpty( column?.ColumnName ) )
                            {
                                _names.Add( column.ColumnName );
                            }
                        }

                        return _names?.Any( ) == true
                            ? _names
                            : default( IEnumerable<string> );
                    }
                    else
                    {
                        return default( IEnumerable<string> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }
    }
}