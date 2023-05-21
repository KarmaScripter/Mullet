// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
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
    using OfficeOpenXml;

    /// <summary> </summary>
    /// <seealso cref="ModelBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class DataModel : ModelBase
    {
        /// <summary> The program elements </summary>
        public IDictionary<string, IEnumerable<string>> DataElements { get; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        public DataModel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        public DataModel( Source source, Provider provider = Provider.Access )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, SQL.SELECTALL );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataElements = CreateSeries( DataTable );
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Keys = GetPrimaryKeys( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Dates = GetDates( );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The dictionary. </param>
        public DataModel( Source source, Provider provider, IDictionary<string, object> where )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, where );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataElements = CreateSeries( DataTable );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Keys = GetPrimaryKeys( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Dates = GetDates( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> The updates. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public DataModel( Source source, Provider provider, IDictionary<string, object> updates, IDictionary<string, object> where,
            SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Keys = GetPrimaryKeys( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Dates = GetDates( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public DataModel( Source source, Provider provider, IEnumerable<string> columns, IDictionary<string, object> where,
            SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Keys = GetPrimaryKeys( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Dates = GetDates( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The columns. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public DataModel( Source source, Provider provider, IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where, SQL commandType )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, fields, numerics, where,
                commandType );

            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Keys = GetPrimaryKeys( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Dates = GetDates( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="where"> The dictionary. </param>
        public DataModel( Source source, IDictionary<string, object> where )
        {
            Source = source;
            Provider = Provider.Access;
            ConnectionFactory = new ConnectionFactory( source, Provider.Access );
            SqlStatement = new SqlStatement( source, Provider.Access, where );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Keys = GetPrimaryKeys( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Dates = GetDates( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public DataModel( Source source, Provider provider, string sqlText )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, sqlText );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Keys = GetPrimaryKeys( );
            Dates = GetDates( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        public DataModel( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            ConnectionFactory = new ConnectionFactory( fullPath );
            Source = ConnectionFactory.Source;
            Provider = ConnectionFactory.Provider;
            SqlStatement = new SqlStatement( Source, Provider, sqlText, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataSetName = DataSet.DataSetName;
            TableName = DataTable.TableName;
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Keys = GetPrimaryKeys( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Dates = GetDates( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public DataModel( IQuery query )
        {
            Query = query;
            Source = query.Source;
            Provider = query.Provider;
            ConnectionFactory = query.ConnectionFactory;
            SqlStatement = query.SqlStatement;
            DataTable = GetDataTable( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetDataColumns( );
            ColumnNames = GetColumnNames( );
            Keys = GetPrimaryKeys( );
            Fields = GetFields( );
            Numerics = GetNumerics( );
            Dates = GetDates( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary> Gets the values. </summary>
        /// <param name="dataRows"> The dataRows. </param>
        /// <param name="column"> The column. </param>
        /// <returns> </returns>
        public static IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string column )
        {
            if( dataRows?.Any( ) == true
               && !string.IsNullOrEmpty( column ) )
            {
                try
                {
                    var _query = dataRows?.Select( v => v.Field<string>( column ) )?.Distinct( );
                    return _query?.Any( ) == true
                        ? _query
                        : default( IEnumerable<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary> Gets the values. </summary>
        /// <param name="dataRows"> The dataRows. </param>
        /// <param name="name"> The field. </param>
        /// <param name="value"> The filter. </param>
        /// <returns> </returns>
        public static IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string name, string value )
        {
            if( dataRows?.Any( ) == true
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _query = dataRows?.Where( v => v.Field<string>( $"{name}" ).Equals( value ) )?.Select( v => v.Field<string>( $"{name}" ) )?.Distinct( );
                    return _query?.Any( ) == true
                        ? _query
                        : default( IEnumerable<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary> Gets the schema table. </summary>
        /// <param name="dataTable"> The dataRows table. </param>
        /// <returns> </returns>
        public static DataTable CreateSchemaTable( DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    using var _reader = new DataTableReader( dataTable );
                    var _schema = _reader?.GetSchemaTable( );
                    return _schema?.Rows?.Count > 0
                        ? _schema
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

        /// <summary> Creates the table from excel. </summary>
        /// <param name="filePath"> The file path. </param>
        /// <param name="header">
        /// if set to
        /// <c> true </c>
        /// [header].
        /// </param>
        /// <returns> </returns>
        public static DataTable CreateTableFromWorksheet( string filePath, bool header = true )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath ) )
            {
                try
                {
                    using var _package = new ExcelPackage( );
                    using var _stream = File.OpenRead( filePath );
                    _package.Load( _stream );
                    var _sheet = _package?.Workbook?.Worksheets?.First( );
                    var _table = new DataTable( _sheet?.Name );
                    if( _sheet?.Cells != null )
                    {
                        var _lastColumn = _sheet.Dimension.End.Column;
                        var _lastRow = _sheet.Dimension.End.Row;
                        foreach( var _cell in _sheet?.Cells[ 1, 1, 1, _lastColumn ] )
                        {
                            _table?.Columns?.Add( header
                                ? _cell.Text
                                : $"Column {_cell.Start.Column}" );
                        }

                        var _start = header
                            ? 2
                            : 1;

                        for( var _row = _start; _row <= _lastRow; _row++ )
                        {
                            var _range = _sheet.Cells[ _row, 1, _row, _lastColumn ];
                            var _data = _table.Rows?.Add( );
                            foreach( var cell in _range )
                            {
                                _data[ cell.Start.Column - 1 ] = cell?.Text;
                            }
                        }

                        return _table?.Rows?.Count > 0
                            ? _table
                            : default( DataTable );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary> Gets the series. </summary>
        /// <param name="dataTable"> The dataRows. </param>
        /// <returns> </returns>
        static private IDictionary<string, IEnumerable<string>> CreateSeries( DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _dict = new Dictionary<string, IEnumerable<string>>( );
                    var _columns = dataTable?.Columns;
                    var _rows = dataTable?.AsEnumerable( );
                    for( var i = 0; i < _columns?.Count; i++ )
                    {
                        if( !string.IsNullOrEmpty( _columns[ i ]?.ColumnName )
                           && _columns[ i ]?.DataType == typeof( string ) )
                        {
                            _dict?.Add( _columns[ i ]?.ColumnName, GetValues( _rows, _columns[ i ]?.ColumnName ) );
                        }
                    }

                    return _dict?.Any( ) == true
                        ? _dict
                        : default( Dictionary<string, IEnumerable<string>> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, IEnumerable<string>> );
                }
            }

            return default( IDictionary<string, IEnumerable<string>> );
        }
    }
}