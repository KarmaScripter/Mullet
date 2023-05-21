// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using OfficeOpenXml;

    public interface IGrid
    {
        /// <summary> The range </summary>
        ExcelRange Range { get; set; }

        /// <summary> The workSheet </summary>
        ExcelWorksheet Worksheet { get; set; }

        /// <summary> The address </summary>
        ExcelAddress Address { get; set; }

        /// <summary> Gets or sets from. </summary>
        /// <value> From. </value>
        ( int Row, int Column ) From { get; set; }

        /// <summary> Gets or sets to. </summary>
        /// <value> To. </value>
        ( int Row, int Column ) To { get; set; }

        /// <summary> Counts the cells. </summary>
        /// <param name = "range" > The range. </param>
        /// <returns> </returns>
        int CountCells( ExcelRange range );

        /// <summary> Gets the row count. </summary>
        /// <returns> </returns>
        int GetRowCount( );

        /// <summary> Gets the column count. </summary>
        /// <returns> </returns>
        int GetColumnCount( );
    }
}