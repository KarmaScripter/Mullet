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
    /// <seealso cref="BudgetExecution.DataConfig"/>
    /// <seealso cref="BudgetExecution.ISource"/>
    /// <seealso cref="BudgetExecution.IProvider"/>
    /// <seealso cref="DataConfig"/>
    /// <seealso cref="ISource"/>
    /// <seealso cref="IProvider"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public abstract class DataAccess : DataConfig, ISource, IProvider
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataAccess"/>
        /// class.
        /// </summary>
        protected DataAccess( )
        {
        }

        /// <summary> Gets the Data. </summary>
        /// <returns> </returns>
        public IEnumerable<DataRow> GetData( )
        {
            try
            {
                var _dataTable = GetDataTable( );
                var _data = _dataTable?.AsEnumerable( );
                return _data?.Any( ) == true
                    ? _data
                    : default( IEnumerable<DataRow> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<DataRow> );
            }
        }

        /// <summary> Gets the column schema. </summary>
        /// <returns> </returns>
        public DataColumnCollection GetTableSchema( )
        {
            if( Query != null )
            {
                try
                {
                    DataSet = new DataSet( $"{Provider}" );
                    DataTable = new DataTable( $"{Source}" );
                    DataSet.Tables.Add( DataTable );
                    var _adapter = Query?.DataAdapter;
                    _adapter?.Fill( DataSet, DataTable.TableName );
                    SetColumnCaptions( DataTable );
                    return DataTable?.Columns?.Count > 0
                        ? DataTable.Columns
                        : default( DataColumnCollection );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataColumnCollection );
                }
            }

            return default( DataColumnCollection );
        }

        /// <summary> Gets the Data table. </summary>
        /// <returns> </returns>
        protected private DataTable GetDataTable( )
        {
            if( Query != null )
            {
                try
                {
                    DataSet = new DataSet( $"{Provider}" );
                    DataTable = new DataTable( $"{Source}" );
                    DataTable.TableName = Source.ToString( );
                    DataSet.Tables.Add( DataTable );
                    var _adapter = Query.DataAdapter;
                    _adapter.Fill( DataSet, DataTable.TableName );
                    SetColumnCaptions( DataTable );
                    return DataTable?.Rows?.Count > 0
                        ? DataTable
                        : default( DataTable );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary> Gets the Data set. </summary>
        /// <returns> </returns>
        protected private DataSet GetDataSet( )
        {
            if( Query != null )
            {
                try
                {
                    DataSet = new DataSet( $"{Provider}" );
                    DataTable = new DataTable( $"{Source}" );
                    DataSet.Tables.Add( DataTable );
                    var _adapter = Query.DataAdapter;
                    _adapter?.Fill( DataSet, DataTable.TableName );
                    SetColumnCaptions( DataTable );
                    return DataSet?.Tables?.Count > 0
                        ? DataSet
                        : default( DataSet );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataSet );
                }
            }

            return default( DataSet );
        }

        /// <summary> Sets the column captions. </summary>
        /// <param name="dataTable"> The Data table. </param>
        protected private void SetColumnCaptions( DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    foreach( DataColumn column in dataTable.Columns )
                    {
                        if( column != null )
                        {
                            var _caption = column.ColumnName.SplitPascal( );
                            column.Caption = _caption;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Gets the fields. </summary>
        /// <returns> </returns>
        protected private IList<string> GetFields( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _fields = new List<string>( );
                    foreach( DataColumn col in DataTable.Columns )
                    {
                        if( col.DataType == typeof( string ) )
                        {
                            _fields.Add( col.ColumnName );
                        }
                    }

                    return _fields?.Any( ) == true
                        ? _fields
                        : default( IList<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }

        /// <summary> Gets the numerics. </summary>
        /// <returns> </returns>
        protected private IList<string> GetNumerics( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _numerics = new List<string>( );
                    foreach( DataColumn col in DataTable.Columns )
                    {
                        if( !col.ColumnName.EndsWith( "Id" )
                           && col.DataType != typeof( int )
                           && col.DataType != typeof( string )
                           && col.DataType != typeof( DateTime )
                           && col.DataType != typeof( DateOnly )
                           && col.DataType != typeof( DateTimeOffset )
                           && ( col.DataType == typeof( double ) || col.DataType == typeof( decimal ) || col.DataType == typeof( float ) ) )
                        {
                            _numerics.Add( col.ColumnName );
                        }
                    }

                    return _numerics?.Any( ) == true
                        ? _numerics
                        : default( IList<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }

        /// <summary> Gets the dates. </summary>
        /// <returns> </returns>
        protected private IList<string> GetDates( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _dates = new List<string>( );
                    foreach( DataColumn col in DataTable.Columns )
                    {
                        if( col.Ordinal > 0
                           && ( col.DataType == typeof( DateTime ) || col.DataType == typeof( DateOnly ) || col.DataType == typeof( DateTimeOffset ) || col.ColumnName.EndsWith( "Date" ) ) )
                        {
                            _dates.Add( col.ColumnName );
                        }
                    }

                    return _dates?.Any( ) == true
                        ? _dates
                        : default( IList<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }

        /// <summary> Gets the keys. </summary>
        /// <returns> </returns>
        protected private IList<int> GetPrimaryKeys( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _values = DataTable.GetIndexValues( );
                    return _values?.Any( ) == true
                        ? _values.ToList( )
                        : default( IList<int> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IList<int> );
                }
            }

            return default( IList<int> );
        }
    }
}