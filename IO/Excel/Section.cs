﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Section : Grid
    {
        /// <summary> Gets or sets from. </summary>
        /// <value> From. </value>
        public (int Row, int Column) Anchor { get; set; }

        /// <summary> Gets the span. </summary>
        /// <value> The span. </value>
        public int Span { get; set; }

        /// <summary> Gets the depth. </summary>
        /// <value> The depth. </value>
        public int Depth { get; set; }

        /// <summary> Gets the dimensions. </summary>
        /// <value> The dimensions. </value>
        public (int Depth, int Span) Area { get; set; }

        /// <summary> The grid </summary>
        private IGrid Grid { get;  }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Heading"/>
        /// class.
        /// </summary>
        public Section( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Section"/>
        /// class.
        /// </summary>
        /// <param name="grid"> </param>
        public Section( IGrid grid )

        {
            Grid = grid;
            Worksheet = Grid.Worksheet;
            Range = Grid.Range;
            Address = Grid.Address;
            From = ( Range.Start.Row, Range.Start.Column );
            To = ( Range.End.Row, Range.End.Column );
            Span = Range.Columns;
            Depth = Range.Rows;
            Area = ( Depth, Span );
        }

        /// <summary> Gets the anchor. </summary>
        /// <returns> </returns>
        public (int Row, int Column) GetAnchor( )
        {
            try
            {
                return default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ( 0, 0 );
            }
        }

        /// <summary> Gets the span. </summary>
        /// <returns> </returns>
        public int GetSpan( )
        {
            try
            {
                return default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary> Gets the depth. </summary>
        /// <returns> </returns>
        public int GetDepth( )
        {
            try
            {
                return default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary> Gets the area. </summary>
        /// <returns> </returns>
        public (int Depth, int Span) GetArea( )
        {
            try
            {
                return default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ( 0, 0 );
            }
        }
    }
}