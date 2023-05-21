// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "UseNullPropagation" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public static class BindingSourceExtensions
    {
        /// <summary> The GetCurrentDataRow </summary>
        /// <param name="bindingSource">
        /// The bindingSource
        /// <see cref="BindingSource"/>
        /// </param>
        /// <returns>
        /// The
        /// <see cref="DataRow"/>
        /// </returns>
        public static DataRow GetCurrentDataRow( this BindingSource bindingSource )
        {
            try
            {
                if( bindingSource.Current != null )
                {
                    return ( (DataRowView)bindingSource?.Current )?.Row;
                }
                else
                {
                    return default( DataRow );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataRow );
            }
        }

        /// <summary> Gets the rows. </summary>
        /// <param name="bindingSource"> The binding source. </param>
        /// <returns> </returns>
        public static IEnumerable<DataRow> GetDataRows( this BindingSource bindingSource )
        {
            if( bindingSource.DataSource != null )
            {
                try
                {
                    var _table = (DataTable)bindingSource.DataSource;
                    return _table?.Rows?.Count > 0
                        ? _table.AsEnumerable( )
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

        /// <summary> Gets the data table. </summary>
        /// <param name="bindingSource"> The binding source. </param>
        /// <returns> </returns>
        public static DataTable GetDataTable( this BindingSource bindingSource )
        {
            if( bindingSource.DataSource != null )
            {
                try
                {
                    var _table = (DataTable)bindingSource.DataSource;
                    return _table != null && _table.Rows.Count > 0
                        ? _table
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