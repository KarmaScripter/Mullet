// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using OfficeOpenXml;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Grid : ExcelCellBase, IGrid
    {

        /// <summary> The range </summary>
        public ExcelRange Range { get; set; }

        /// <summary> The workSheet </summary>
        public ExcelWorksheet Worksheet { get; set; }

        /// <summary> The address </summary>
        public ExcelAddress Address { get; set; }

        /// <summary> Gets or sets from. </summary>
        /// <value> From. </value>
        public ( int Row, int Column ) From { get; set; }

        /// <summary> Gets or sets to. </summary>
        /// <value> To. </value>
        public ( int Row, int Column ) To { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        public Grid( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> </param>
        /// <param name="range"> The range. </param>
        public Grid( ExcelWorksheet workSheet, ExcelRange range )
        {
            Worksheet = workSheet;
            Range = range;
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.End.Row, Range.End.Row );
            From = ( Address.Start.Row, Address.Start.Column );
            To = ( Address.End.Row, Address.End.Column );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> The workSheet. </param>
        /// <param name="address"> The address. </param>
        public Grid( ExcelWorksheet workSheet, ExcelAddress address )
        {
            Worksheet = workSheet;
            Address = address;
            From = ( Address.Start.Row, Address.Start.Column );
            To = ( Address.End.Row, Address.End.Column );
            Range = Worksheet.Cells[ From.Row, From.Column, To.Row, To.Column ];
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> </param>
        /// <param name="fromRow"> The fromRow. </param>
        /// <param name="fromColumn"> The fromColumn. </param>
        /// <param name="toRow"> The toRow. </param>
        /// <param name="toColumn"> The toColumn. </param>
        public Grid( ExcelWorksheet workSheet, int fromRow = 1, int fromColumn = 1, int toRow = 55,
            int toColumn = 12 )
        {
            Worksheet = workSheet;
            Range = Worksheet.Cells[ fromRow, fromColumn, toRow, toColumn ];
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.End.Row, Range.End.Row );
            From = ( Address.Start.Row, Address.Start.Column );
            To = ( Address.End.Row, Address.End.Column );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> </param>
        /// <param name="cell"> The cell. </param>
        public Grid( ExcelWorksheet workSheet, IList<int> cell )
        {
            Worksheet = workSheet;
            Range = Worksheet.Cells[ cell[ 0 ], cell[ 1 ], cell[ 2 ], cell[ 3 ] ];
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.End.Row, Range.End.Column );
            From = ( Address.Start.Row, Address.Start.Column );
            To = ( Address.End.Row, Address.End.Column );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> </param>
        /// <param name="from"> From. </param>
        /// <param name="to"> To. </param>
        public Grid( ExcelWorksheet workSheet, (int Row, int Column) from, (int Row, int Column) to )
        {
            Worksheet = workSheet;
            Range = Worksheet.Cells[ from.Row, from.Column, to.Row, to.Column ];
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.End.Row, Range.End.Row );
            From = from;
            To = to;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> The work sheet. </param>
        /// <param name="from"> From. </param>
        public Grid( ExcelWorksheet workSheet, (int Row, int Column) from )
        {
            Worksheet = workSheet;
            Range = Worksheet.Cells[ from.Row, from.Column ];
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.Start.Row, Range.Start.Column );
            From = from;
            To = From;
        }

        /// <summary> Counts the cells. </summary>
        /// <param name="range"> The range. </param>
        /// <returns> </returns>
        public int CountCells( ExcelRange range )
        {
            try
            {
                return range?.Rows * range?.Columns ?? default( int );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary> Gets the row count. </summary>
        /// <returns> </returns>
        public int GetRowCount( )
        {
            try
            {
                return Range.Rows > 0
                    ? Range.Rows
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Gets the column count. </summary>
        /// <returns> </returns>
        public int GetColumnCount( )
        {
            try
            {
                return Range.Columns > 0
                    ? Range.Columns
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}