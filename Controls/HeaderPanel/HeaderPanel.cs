// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using CBComponents;

    /// <summary> </summary>
    /// <seealso cref="CBComponents.HeaderTableLayoutPanel"/>
    public class HeaderPanel : HeaderTableLayoutPanel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HeaderPanel"/>
        /// class.
        /// </summary>
        public HeaderPanel( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.DarkGray;
            CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            Font = new Font( "Roboto", 9 );
            ColumnCount = 1;
            RowCount = 1;
            CaptionStyle = HighlightCaptionStyle.NavisionAxaptaStyle;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HeaderPanel"/>
        /// class.
        /// </summary>
        /// <param name="header"> The header. </param>
        public HeaderPanel( string header )
            : this( )
        {
            CaptionText = header;
        }
    }
}