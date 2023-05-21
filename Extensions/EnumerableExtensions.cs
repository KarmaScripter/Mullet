// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using OfficeOpenXml;
    using OfficeOpenXml.Table;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public static class EnumerableExtensions
    {
        /// <summary> Converts to bindinglist. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="enumerable"> The enumerable. </param>
        /// <returns> </returns>
        public static BindingList<T> ToBindingList<T>( this IEnumerable<T> enumerable )
        {
            if( enumerable?.Any( ) == true )
            {
                try
                {
                    var _list = new BindingList<T>( );
                    foreach( var item in enumerable )
                    {
                        _list.Add( item );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( BindingList<T> );
                }
            }

            return default( BindingList<T> );
        }

        /// <summary>
        /// Filters a sequence of values based on a given predicate and returns those values that don't match
        /// the predicate.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the elements of
        /// <paramref name="source"/>
        /// .
        /// </typeparam>
        /// <param name="source">
        /// An
        /// <see cref="IEnumerable{T}"/>
        /// to filter.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <returns> Those values that don't match the given predicate. </returns>
        public static IEnumerable<T> WhereNot<T>( this IEnumerable<T> source, Func<T, bool> predicate )
        {
            try
            {
                return source.Where( element => !predicate( element ) );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<T> );
            }
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate and returns those values that don't match the
        /// given predicate. Each element's index is used in the logic of predicate function.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the elements of
        /// <paramref name="source"/>
        /// .
        /// </typeparam>
        /// <param name="source">
        /// An
        /// <see cref="IEnumerable{T}"/>
        /// to filter.
        /// </param>
        /// <param name="predicate">
        /// A function to test each element for a condition; the second parameter of the functions represents
        /// the index of the source element.
        /// </param>
        /// <returns> Those values that don't match the given predicate. </returns>
        public static IEnumerable<T> WhereNot<T>( this IEnumerable<T> source, Func<T, int, bool> predicate )
        {
            try
            {
                return source.Where( ( element, index ) => !predicate( element, index ) );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<T> );
            }
        }

        /// <summary> Filters the specified columnName. </summary>
        /// <param name="dataRow"> The dataRow. </param>
        /// <param name="name"> The columnName. </param>
        /// <param name="value"> The filter. </param>
        /// <returns> </returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow, string name, string value )
        {
            if( dataRow?.Any( ) == true
               && !string.IsNullOrEmpty( name )
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _dictionary = _row.ToDictionary( );
                    var _array = _dictionary.Keys.ToArray( );
                    if( _array?.Contains( name ) == true )
                    {
                        var _select = dataRow?.Where( p => p.Field<string>( name ) == value )?.Select( p => p );
                        return _select?.Any( ) == true
                            ? _select
                            : default( IEnumerable<DataRow> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary> Filters the specified dictionary. </summary>
        /// <param name="dataRow"> The data row. </param>
        /// <param name="where"> The dictionary. </param>
        /// <returns> </returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow, IDictionary<string, object> where )
        {
            if( dataRow?.Any( ) == true
               && where?.Any( ) == true )
            {
                try
                {
                    var _table = dataRow.CopyToDataTable( );
                    var _rows = _table?.Select( where.ToCriteria( ) );
                    return _rows?.Any( ) == true
                        ? _rows
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

        /// <summary> Converts to excel. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="type"> The dataRow. </param>
        /// <param name="path"> The path. </param>
        /// <param name="style"> </param>
        /// <exception cref="Exception">
        /// Invalid file path. or Invalid file path. or No dataRow to export.
        /// </exception>
        public static ExcelPackage ToExcel<T>( this IEnumerable<T> type, string path, TableStyles style = TableStyles.Light1 )
        {
            if( string.IsNullOrEmpty( path )
               && type?.Any( ) == true
               && Enum.IsDefined( typeof( TableStyles ), style ) )
            {
                throw new ArgumentException( "Verify Path" );
            }

            try
            {
                using var _excel = new ExcelPackage( new FileInfo( path ) );
                var _workbook = _excel.Workbook;
                var _worksheet = _workbook.Worksheets[ 0 ];
                var _range = _worksheet.Cells;
                _range?.LoadFromCollection( type, true, style );
                return _excel;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelPackage );
            }
        }

        /// <summary>
        /// Extracts a contiguous count of elements from a sequence at a particular zero-based starting index.
        /// </summary>
        /// <typeparam name="T"> The type of the elements in the source sequence. </typeparam>
        /// <param name="sequence"> The sequence from which to extract elements. </param>
        /// <param name="startIndex"> The zero-based index at which to begin slicing. </param>
        /// <param name="count"> The number of items to slice out of the index. </param>
        /// <returns>
        /// A new sequence containing any elements sliced out from the source sequence.
        /// </returns>
        /// <remarks>
        /// <para>
        /// If the starting position or count specified result in slice extending past the end of the sequence,
        /// it will return all elements up to that point. There is no guarantee that the resulting sequence
        /// will contain the number of elements requested - it may have anywhere from 0 to
        /// <paramref name="count"/>
        /// .
        /// </para>
        /// <para>
        /// This method is implemented in an optimized manner for any sequence implementing
        /// <see cref="IList{T}"/>
        /// .
        /// </para>
        /// <para>
        /// The result of
        /// <see cref="Slice{T}"/>
        /// is identical to:
        /// <c> sequence.Skip(startIndex).Take(count) </c>
        /// </para>
        /// </remarks>
        public static IEnumerable<T> Slice<T>( this IEnumerable<T> sequence, int startIndex, int count )
        {
            return sequence switch
            {
                IList<T> list => SliceList( list.Count, i => list[ i ] ),
                IReadOnlyList<T> list => SliceList( list.Count, i => list[ i ] ),
                var seq => seq.Skip( startIndex ).Take( count )
            };

            IEnumerable<T> SliceList( int listCount, Func<int, T> indexer )
            {
                var countdown = count;
                var index = startIndex;
                while( index < listCount
                      && countdown-- > 0 )
                {
                    yield return indexer( index++ );
                }
            }
        }

        /// <summary> Slices the specified start. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="type"> The dataRow. </param>
        /// <param name="start"> The start. </param>
        /// <param name="end"> The end. </param>
        /// <returns> </returns>
        public static IEnumerable<T> LazySlice<T>( this IEnumerable<T> type, int start, int end )
        {
            if( type?.Any( ) == true
               && start > 0
               && end > 0 )
            {
                var _index = 0;
                foreach( var item in type )
                {
                    if( _index >= end )
                    {
                        yield break;
                    }

                    if( _index >= start )
                    {
                        yield return item;
                    }

                    ++_index;
                }
            }
        }

        /// <summary>
        /// Turns a finite sequence into a circular one, or equivalently, repeats the original sequence
        /// indefinitely.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the elements of
        /// <paramref name="source"/>
        /// .
        /// </typeparam>
        /// <param name="source">
        /// An
        /// <see cref="IEnumerable{T}"/>
        /// to cycle through.
        /// </param>
        /// <returns> An infinite sequence cycling through the given sequence. </returns>
        public static IEnumerable<T> Cycle<T>( this IEnumerable<T> source )
        {
            try
            {
                return CycleIterator( source );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<T> );
            }
        }

        /// <summary> Cycles the iterator. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="source"> The source. </param>
        /// <returns> </returns>
        static private IEnumerable<T> CycleIterator<T>( IEnumerable<T> source )
        {
            var elementBuffer = source is not ICollection<T> collection
                ? new List<T>( )
                : new List<T>( collection.Count );

            foreach( var element in source )
            {
                yield return element;

                elementBuffer.Add( element );
            }

            if( elementBuffer.IsEmpty<T>( ) )
            {
                yield break;
            }

            var index = 0;
            while( true )
            {
                yield return elementBuffer[ index ];

                index = ( index + 1 ) % elementBuffer.Count;
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