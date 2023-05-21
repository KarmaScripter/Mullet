﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Threading;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    /// <summary> </summary>
    /// <seealso cref="ExcelConfig"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class ExcelBase : ExcelConfig
    {
        /// <summary> Gets or sets the data connection. </summary>
        /// <value> The data connection. </value>
        public OleDbConnection DataConnection { get; set; }

        /// <summary> Gets or sets the data command. </summary>
        /// <value> The data command. </value>
        public OleDbCommand DataCommand { get; set; }

        /// <summary> Gets or sets the data adapter. </summary>
        /// <value> The data adapter. </value>
        public OleDbDataAdapter DataAdapter { get; set; }

        /// <summary> Gets or sets the ext. </summary>
        /// <value> The ext. </value>
        public EXT Ext { get; set; }

        /// <summary> Gets or sets the file information. </summary>
        /// <value> The file information. </value>
        public FileInfo FileInfo { get; set; }

        /// <summary> Gets or sets the excel. </summary>
        /// <value> The excel. </value>
        public ExcelPackage Application { get; set; }

        /// <summary> Gets or sets the workbook. </summary>
        /// <value> The workbook. </value>
        public ExcelWorkbook Workbook { get; set; }

        /// <summary> Gets or sets the worksheet. </summary>
        /// <value> The worksheet. </value>
        public ExcelWorksheet Worksheet { get; set; }

        /// <summary> Gets or sets the comment. </summary>
        /// <value> The comment. </value>
        public IEnumerable<ExcelComment> Comment { get; set; }

        /// <summary> Gets or sets the data. </summary>
        /// <value> The data. </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary> Sets the width of the column. </summary>
        /// <param name="grid"> The grid. </param>
        /// <param name="width"> The width. </param>
        public void SetColumnWidth( Grid grid, double width )
        {
            if( grid?.Worksheet != null
               && width > 0d )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.AutoFitColumns( width );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the color of the background. </summary>
        /// <param name="grid"> The grid. </param>
        /// <param name="color"> The color. </param>
        public void SetBackgroundColor( Grid grid, Color color )
        {
            if( grid?.Worksheet != null
               && grid?.Range != null
               && color != Color.Empty )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    _range.Style.Fill.BackgroundColor.SetColor( color );
                    _range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the range font. </summary>
        /// <param name="grid"> The grid. </param>
        /// <param name="font"> The font. </param>
        public void SetRangeFont( Grid grid, Font font )
        {
            if( grid?.Worksheet != null
               && grid?.Range != null
               && font != null )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.Style.Font.SetFromFont( font.Name, font.Size );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the color of the font. </summary>
        /// <param name="grid"> The grid. </param>
        /// <param name="color"> The color. </param>
        public void SetFontColor( Grid grid, Color color )
        {
            if( grid?.Worksheet != null
               && grid?.Range != null
               && color != Color.Empty )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.Style.Font.Color.SetColor( color );
                    _range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the border style. </summary>
        /// <param name="grid"> The grid. </param>
        /// <param name="side"> The side. </param>
        /// <param name="style"> The style. </param>
        public void SetBorderStyle( Grid grid, BorderSide side, ExcelBorderStyle style )
        {
            if( grid?.Worksheet != null
               && grid?.Range != null
               && Enum.IsDefined( typeof( ExcelBorderStyle ), style )
               && Enum.IsDefined( typeof( BorderSide ), side ) )
            {
                try
                {
                    using var _range = grid.Range;
                    switch( side )
                    {
                        case BorderSide.Top:
                        {
                            _range.Style.Border.Top.Style = style;
                            break;
                        }
                        case BorderSide.Bottom:
                        {
                            _range.Style.Border.Bottom.Style = style;
                            break;
                        }
                        case BorderSide.Right:
                        {
                            _range.Style.Border.Right.Style = style;
                            break;
                        }
                        case BorderSide.Left:
                        {
                            _range.Style.Border.Left.Style = style;
                            break;
                        }
                        default:
                        {
                            _range.Style.Border.BorderAround( ExcelBorderStyle.None );
                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the horizontal alignment. </summary>
        /// <param name="grid"> The grid. </param>
        /// <param name="align"> The align. </param>
        public void SetHorizontalAlignment( Grid grid, ExcelHorizontalAlignment align )
        {
            if( grid?.Worksheet != null
               && grid?.Range != null
               && Enum.IsDefined( typeof( ExcelHorizontalAlignment ), align ) )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.Style.HorizontalAlignment = align;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the vertical aligment. </summary>
        /// <param name="grid"> The grid. </param>
        /// <param name="align"> The align. </param>
        public void SetVerticalAlignment( Grid grid, ExcelVerticalAlignment align )
        {
            if( grid?.Worksheet != null
               && Enum.IsDefined( typeof( ExcelVerticalAlignment ), align ) )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.Style.VerticalAlignment = align;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Merges the cells. </summary>
        /// <param name="grid"> The grid. </param>
        public void MergeCells( Grid grid )
        {
            if( grid?.Worksheet != null
               && grid?.Range != null )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.Merge = true;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}